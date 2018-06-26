﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace AudioWorks.Extensions.Flac
{
    sealed class StreamEncoder : IDisposable
    {
        [NotNull] readonly StreamEncoderHandle _handle = SafeNativeMethods.StreamEncoderNew();
        [NotNull] readonly NativeCallbacks.StreamEncoderWriteCallback _writeCallback;
        [NotNull] readonly NativeCallbacks.StreamEncoderSeekCallback _seekCallback;
        [NotNull] readonly NativeCallbacks.StreamEncoderTellCallback _tellCallback;
        [NotNull] readonly Stream _stream;

        internal StreamEncoder([NotNull] Stream stream)
        {
            // Need a reference to the callbacks for the lifetime of the encoder
            _writeCallback = WriteCallback;
            _seekCallback = SeekCallback;
            _tellCallback = TellCallback;

            _stream = stream;
        }

        internal void SetChannels(uint channels)
        {
            SafeNativeMethods.StreamEncoderSetChannels(_handle, channels);
        }

        internal void SetBitsPerSample(uint bitsPerSample)
        {
            SafeNativeMethods.StreamEncoderSetBitsPerSample(_handle, bitsPerSample);
        }

        internal void SetSampleRate(uint sampleRate)
        {
            SafeNativeMethods.StreamEncoderSetSampleRate(_handle, sampleRate);
        }

        internal void SetTotalSamplesEstimate(ulong sampleCount)
        {
            SafeNativeMethods.StreamEncoderSetTotalSamplesEstimate(_handle, sampleCount);
        }

        internal void SetCompressionLevel(uint compressionLevel)
        {
            SafeNativeMethods.StreamEncoderSetCompressionLevel(_handle, compressionLevel);
        }

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods",
            Justification = "Can't pass an array of SafeHandles")]
        internal void SetMetadata([NotNull, ItemNotNull] IEnumerable<MetadataBlock> metadataBlocks)
        {
            var blockPointers = metadataBlocks.Select(block => block.Handle.DangerousGetHandle()).ToArray();
            SafeNativeMethods.StreamEncoderSetMetadata(_handle, blockPointers, (uint) blockPointers.Length);
        }

        [SuppressMessage("Performance", "CA1806:Do not ignore method results",
            Justification = "Native method is always expected to return 0")]
        internal void Initialize()
        {
            SafeNativeMethods.StreamEncoderInitStream(_handle, _writeCallback, _seekCallback, _tellCallback, null,
                IntPtr.Zero);
        }

        internal bool ProcessInterleaved(Span<int> buffer, uint frameCount)
        {
            return SafeNativeMethods.StreamEncoderProcessInterleaved(
                _handle,
                Unsafe.AsRef(buffer.GetPinnableReference()),
                frameCount);
        }

        internal bool Finish()
        {
            return SafeNativeMethods.StreamEncoderFinish(_handle);
        }

        [Pure]
        internal EncoderState GetState()
        {
            return SafeNativeMethods.StreamEncoderGetState(_handle);
        }

        public void Dispose()
        {
            _handle.Dispose();
        }

        EncoderWriteStatus WriteCallback(IntPtr handle, [NotNull] byte[] buffer, int bytes, uint samples, uint currentFrame, IntPtr userData)
        {
            _stream.Write(buffer, 0, bytes);
            return EncoderWriteStatus.Ok;
        }

        EncoderSeekStatus SeekCallback(IntPtr handle, ulong absoluteOffset, IntPtr userData)
        {
            _stream.Position = (long) absoluteOffset;
            return EncoderSeekStatus.Ok;
        }

        EncoderTellStatus TellCallback(IntPtr handle, out ulong absoluteOffset, IntPtr userData)
        {
            absoluteOffset = (ulong) _stream.Position;
            return EncoderTellStatus.Ok;
        }
    }
}