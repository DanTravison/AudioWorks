﻿using AudioWorks.Common;
using Id3Lib;
using Id3Lib.Exceptions;
using JetBrains.Annotations;
using System.IO;

namespace AudioWorks.Extensions.Id3
{
    [AudioMetadataEncoderExport(".mp3")]
    sealed class Id3AudioMetadataEncoder : IAudioMetadataEncoder
    {
        public SettingInfoDictionary GetSettingInfo()
        {
            return new SettingInfoDictionary
            {
                ["Padding"] = new SettingInfo(typeof(int))
            };
        }

        public void WriteMetadata(FileStream stream, AudioMetadata metadata, SettingDictionary settings)
        {
            var existingTagLength = GetExistingTagLength(stream);

            var tagModel = new MetadataToTagModelAdapter(metadata);
            tagModel.Header.Version = 3;
            if (settings.TryGetValue("Padding", out var padding))
                tagModel.Header.PaddingSize = (uint) (int) padding;
            tagModel.UpdateSize();

            if (!settings.ContainsKey("Padding") && existingTagLength >= tagModel.Header.TagSizeWithHeaderFooter)
                Overwrite(stream, existingTagLength, tagModel);
            else
                FullRewrite(stream, existingTagLength, tagModel);
        }

        static uint GetExistingTagLength([NotNull] Stream stream)
        {
            try
            {
                var existingTag = TagManager.Deserialize(stream);
                return existingTag.Header.TagSizeWithHeaderFooter + existingTag.Header.PaddingSize;
            }
            catch (TagNotFoundException)
            {
                return 0u;
            }
        }

        static void Overwrite([NotNull] Stream stream, uint existingTagLength, [NotNull] TagModel tagModel)
        {
            // Write the new tag overtop of the old one, leaving unused space as padding
            stream.Seek(0, SeekOrigin.Begin);
            tagModel.Header.PaddingSize = existingTagLength - tagModel.Header.TagSizeWithHeaderFooter;
            TagManager.Serialize(tagModel, stream);
        }

        static void FullRewrite([NotNull] Stream stream, uint existingTagLength, [NotNull] TagModel tagModel)
        {
            // Copy the audio to memory, then rewrite the whole stream
            stream.Seek(existingTagLength, SeekOrigin.Begin);
            using (var tempStream = new MemoryStream())
            {
                // Copy the MP3 portion to memory
                stream.CopyTo(tempStream);

                // Rewrite the stream with the new tag in front
                stream.Position = 0;
                stream.SetLength(tagModel.Header.TagSizeWithHeaderFooter + tagModel.Header.PaddingSize + tempStream.Length);
                TagManager.Serialize(tagModel, stream);
                tempStream.Position = 0;
                tempStream.CopyTo(stream);
            }
        }
    }
}
