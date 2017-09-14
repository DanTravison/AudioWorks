﻿using JetBrains.Annotations;
using System.IO;

namespace AudioWorks.Common
{
    [PublicAPI]
    public sealed class AudioFile
    {
        [NotNull]
        public FileInfo FileInfo { get; }

        [NotNull]
        public AudioInfo AudioInfo { get; }

        [NotNull]
        public AudioMetadata Metadata { get; } = new AudioMetadata();

        internal AudioFile([NotNull] FileInfo fileInfo, [NotNull] AudioInfo audioInfo)
        {
            FileInfo = fileInfo;
            AudioInfo = audioInfo;
        }
    }
}
