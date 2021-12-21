using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.OpenXR
{
    public static unsafe partial class OpenXRNative
    {
        private const CallingConvention CallConv = CallingConvention.StdCall;

        private static NativeLibrary nativeLib;

        static OpenXRNative()
        {
            nativeLib = LoadNativeLibrary();
            LoadFuncionPointers();
        }

        private static NativeLibrary LoadNativeLibrary()
        {
            return NativeLibrary.Load(GetOpenXRName());
        }

        private static string GetOpenXRName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "openxr_loader.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                if (RuntimeInformation.OSDescription.Contains("Unix"))
                {
                    // Android
                    return "libopenxr_loader.so";
                }
                else
                {
                    // Desktop Linux
                    return "libopenxr_loader.so.1";
                }
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
