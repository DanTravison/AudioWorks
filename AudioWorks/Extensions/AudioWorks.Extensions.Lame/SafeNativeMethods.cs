﻿using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using JetBrains.Annotations;

namespace AudioWorks.Extensions.Lame
{
    [SuppressUnmanagedCodeSecurity]
    static class SafeNativeMethods
    {
        const string _lameLibrary = "libmp3lame";

#if (WINDOWS)
        static SafeNativeMethods()
        {
            // Select an architecture-appropriate directory by prefixing the PATH variable
            var newPath = new StringBuilder(
                Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath));
            newPath.Append(Path.DirectorySeparatorChar);
            newPath.Append(Environment.Is64BitProcess ? "x64" : "x86");
            newPath.Append(Path.PathSeparator);
            newPath.Append(Environment.GetEnvironmentVariable("PATH"));

            Environment.SetEnvironmentVariable("PATH", newPath.ToString());
        }
#endif

        [NotNull]
        [DllImport(_lameLibrary, EntryPoint = "lame_init",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern EncoderHandle Init();

        [DllImport(_lameLibrary, EntryPoint = "lame_set_num_channels",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern void SetChannels(
            [NotNull] EncoderHandle handle,
            int channels);

        [DllImport(_lameLibrary, EntryPoint = "lame_set_in_samplerate",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern void SetSampleRate(
            [NotNull] EncoderHandle handle,
            int sampleRate);

        [DllImport(_lameLibrary, EntryPoint = "lame_set_num_samples",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern void SetSampleCount(
            [NotNull] EncoderHandle handle,
            uint samples);

        [DllImport(_lameLibrary, EntryPoint = "lame_init_params",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern int InitParams(
            [NotNull] EncoderHandle handle);

        [DllImport(_lameLibrary, EntryPoint = "lame_encode_buffer_ieee_float",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern int EncodeBufferIeeeFloat(
            [NotNull] EncoderHandle handle,
            [NotNull] float[] leftSamples,
            [CanBeNull] float[] rightSamples,
            int sampleCount,
            [NotNull] [In, Out] byte[] buffer,
            int bufferSize);

        [DllImport(_lameLibrary, EntryPoint = "lame_encode_flush",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern int EncodeFlush(
            [NotNull] EncoderHandle handle,
            [NotNull] [In, Out] byte[] buffer,
            int bufferSize);

        [DllImport(_lameLibrary, EntryPoint = "lame_get_lametag_frame",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern UIntPtr GetLameTagFrame(
            [NotNull] EncoderHandle handle,
            [NotNull] [In, Out] byte[] buffer,
            UIntPtr bufferSize);

        [DllImport(_lameLibrary, EntryPoint = "lame_close",
            CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Close(
            IntPtr handle);
    }
}