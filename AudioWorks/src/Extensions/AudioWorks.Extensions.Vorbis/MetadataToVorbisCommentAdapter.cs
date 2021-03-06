﻿/* Copyright © 2018 Jeremy Herbison

This file is part of AudioWorks.

AudioWorks is free software: you can redistribute it and/or modify it under the terms of the GNU Affero General Public
License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later
version.

AudioWorks is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied
warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more
details.

You should have received a copy of the GNU Affero General Public License along with AudioWorks. If not, see
<https://www.gnu.org/licenses/>. */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
#if NETSTANDARD2_0
using System.Runtime.CompilerServices;
#endif
using System.Text;
using AudioWorks.Common;

namespace AudioWorks.Extensions.Vorbis
{
    sealed class MetadataToVorbisCommentAdapter : IDisposable
    {
        VorbisComment _comment;
        bool _unmanagedMemoryAllocated;

        internal MetadataToVorbisCommentAdapter(AudioMetadata metadata)
        {
            SafeNativeMethods.VorbisCommentInit(out _comment);

            if (!string.IsNullOrEmpty(metadata.Title))
                AddTag("TITLE", metadata.Title);
            if (!string.IsNullOrEmpty(metadata.Artist))
                AddTag("ARTIST", metadata.Artist);
            if (!string.IsNullOrEmpty(metadata.Album))
                AddTag("ALBUM", metadata.Album);
            if (!string.IsNullOrEmpty(metadata.AlbumArtist))
                AddTag("ALBUMARTIST", metadata.AlbumArtist);
            if (!string.IsNullOrEmpty(metadata.Composer))
                AddTag("COMPOSER", metadata.Composer);
            if (!string.IsNullOrEmpty(metadata.Genre))
                AddTag("GENRE", metadata.Genre);
            if (!string.IsNullOrEmpty(metadata.Comment))
                AddTag("DESCRIPTION", metadata.Comment);

            if (!string.IsNullOrEmpty(metadata.Day) &&
                !string.IsNullOrEmpty(metadata.Month) &&
                !string.IsNullOrEmpty(metadata.Year))
                AddTag("DATE", $"{metadata.Year}-{metadata.Month}-{metadata.Day}");
            else if (!string.IsNullOrEmpty(metadata.Year))
                AddTag("YEAR", metadata.Year);

            if (!string.IsNullOrEmpty(metadata.TrackNumber))
                AddTag("TRACKNUMBER", !string.IsNullOrEmpty(metadata.TrackCount)
                    ? $"{metadata.TrackNumber}/{metadata.TrackCount}"
                    : metadata.TrackNumber);

            if (!string.IsNullOrEmpty(metadata.TrackPeak))
                AddTag("REPLAYGAIN_TRACK_PEAK", metadata.TrackPeak);
            if (!string.IsNullOrEmpty(metadata.AlbumPeak))
                AddTag("REPLAYGAIN_ALBUM_PEAK", metadata.AlbumPeak);
            if (!string.IsNullOrEmpty(metadata.TrackGain))
                AddTag("REPLAYGAIN_TRACK_GAIN", $"{metadata.TrackGain} dB");
            if (!string.IsNullOrEmpty(metadata.AlbumGain))
                AddTag("REPLAYGAIN_ALBUM_GAIN", $"{metadata.AlbumGain} dB");

            // Always store images in JPEG format since Vorbis is also lossy
            if (metadata.CoverArt != null)
                AddTag("METADATA_BLOCK_PICTURE", CoverArtAdapter.ToBase64(
                    CoverArtFactory.ConvertToLossy(metadata.CoverArt)));
        }

        [SuppressMessage("Performance", "CA1806:Do not ignore method results",
            Justification = "Native method is always expected to return 0")]
        internal void HeaderOut(out OggPacket packet) => SafeNativeMethods.VorbisCommentHeaderOut(_comment, out packet);

        [SuppressMessage("Performance", "CA1806:Do not ignore method results",
            Justification = "Native method is always expected to return 0")]
        internal void HeaderOut(
            IntPtr dspState,
            out OggPacket first,
            out OggPacket second,
            out OggPacket third) =>
            SafeNativeMethods.VorbisAnalysisHeaderOut(dspState, _comment, out first, out second, out third);

        public void Dispose()
        {
            FreeUnmanaged();
            GC.SuppressFinalize(this);
        }

        unsafe void AddTag(string key, string value)
        {
            // Optimization - avoid allocating on the heap
            Span<byte> keyBytes = stackalloc byte[Encoding.ASCII.GetMaxByteCount(key.Length) + 1];
#if NETSTANDARD2_0
            fixed (char* keyAddress = key)
                Encoding.ASCII.GetBytes(
                    keyAddress, key.Length,
                    (byte*) Unsafe.AsPointer(ref MemoryMarshal.GetReference(keyBytes)), keyBytes.Length);
#else
            Encoding.ASCII.GetBytes(key, keyBytes);
#endif

            // Use heap allocations for comments > 256kB (usually pictures)
            var valueMaxByteCount = Encoding.UTF8.GetMaxByteCount(value.Length) + 1;
            var valueBytes = valueMaxByteCount < 0x40000
                ? stackalloc byte[valueMaxByteCount]
                : new byte[valueMaxByteCount];
#if NETSTANDARD2_0
            fixed (char* valueAddress = value)
            fixed (byte* valueBytesAddress = valueBytes)
                Encoding.UTF8.GetBytes(valueAddress, value.Length, valueBytesAddress, valueMaxByteCount);
#else
            Encoding.ASCII.GetBytes(value, valueBytes);
#endif

            fixed (byte* valueBytesAddress = valueBytes)
                SafeNativeMethods.VorbisCommentAddTag(_comment, ref MemoryMarshal.GetReference(keyBytes),
                    valueBytesAddress);

            _unmanagedMemoryAllocated = true;
        }

        unsafe void AddTag(string key, ReadOnlySpan<byte> value)
        {
            // Optimization - avoid allocating on the heap
            Span<byte> keyBytes = stackalloc byte[Encoding.ASCII.GetMaxByteCount(key.Length) + 1];
#if NETSTANDARD2_0
            fixed (char* keyAddress = key)
                Encoding.ASCII.GetBytes(
                    keyAddress, key.Length,
                    (byte*) Unsafe.AsPointer(ref MemoryMarshal.GetReference(keyBytes)), keyBytes.Length);
#else
            Encoding.ASCII.GetBytes(key, keyBytes);
#endif

            fixed (byte* valueAddress = value)
                SafeNativeMethods.VorbisCommentAddTag(_comment, ref MemoryMarshal.GetReference(keyBytes),
                    valueAddress);

            _unmanagedMemoryAllocated = true;
        }

        void FreeUnmanaged()
        {
            if (_unmanagedMemoryAllocated)
                SafeNativeMethods.VorbisCommentClear(ref _comment);
        }

        ~MetadataToVorbisCommentAdapter() => FreeUnmanaged();
    }
}
