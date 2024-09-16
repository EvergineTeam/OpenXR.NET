using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.OpenXR
{
    public static unsafe partial class OpenXRNative
    {
        private const CallingConvention CallConv = CallingConvention.StdCall;

        private static NativeLibrary nativeLib;

        public static NativeLibrary NativeLibrary => nativeLib;

        static OpenXRNative()
        {
            nativeLib = LoadNativeLibrary();
            LoadFunctionPointers();
        }

        private static NativeLibrary LoadNativeLibrary()
        {
            return NativeLibrary.Load(GetOpenXRName());
        }

        private static string GetOpenXRName()
        {
            if (OperatingSystem.IsWindows())
            {
                return "openxr_loader.dll";
            }
            else if (OperatingSystem.IsAndroid())
            {
                // Android
                return "libopenxr_loader.so";
            }
            else if (OperatingSystem.IsLinux())
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
