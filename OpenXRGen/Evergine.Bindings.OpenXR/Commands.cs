using System;
using System.Runtime.InteropServices;
using static Evergine.Bindings.OpenXR.OperatingSystemHelper;

namespace Evergine.Bindings.OpenXR
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
            if (IsOSPlatform(PlatformType.Windows))
            {
                return "openxr_loader.dll";
            }
            else if (IsOSPlatform(PlatformType.Android))
            {
                // Android
                return "libopenxr_loader.so";
            }
            else if (IsOSPlatform(PlatformType.Linux))
            {
                // Desktop Linux
                return "libopenxr_loader.so.1";
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }
    }
}
