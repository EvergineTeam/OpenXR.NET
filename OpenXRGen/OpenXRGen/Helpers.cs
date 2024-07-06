using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXRGen
{
    public static class Helpers
    {
        public static string ToCSharp(this ConstantType type)
        {
            switch (type)
            {
                case ConstantType.UInt32:
                    return "uint";
                case ConstantType.UInt64:
                    return "ulong";
                case ConstantType.Float32:
                    return "float";
                case ConstantType.String:
                    return "string";
                default:
                    throw new InvalidOperationException("Invalid value");
            }
        }

        public static string ValidatedName(string name)
        {
            if (name == "object")
            {
                return "vkObject";
            }
            else if (name == "event")
            {
                return "vkEvent";
            }

            return name;
        }

        public static string GetPrettyEnumName(string value)
        {
            int start;
            if((start = value.IndexOf("bit", StringComparison.OrdinalIgnoreCase)) != -1)
            {
                return value.Remove(start, 3);
            }

            return value;
        }

        public static uint GetTypeSize(string type)
        {
            if (type == "char" || type == "uint8_t")
                return 1;
            else if (type == "uint16_t" || type == "int16_t")
                return 2;

            // uint32_t, uint64_t, int32_t, int64_t, int64_t*, size_t, DWORD
            return 4;
        }

        public static string ConvertToCSharpType(string type, int pointerlevel, OpenXRSpecification spec)
        {
            string memberType = type;

            if (type.StartsWith("PFN"))
            {
                string fp = memberType.Replace("*", "");
                if (spec.FuncPointers.Exists(f => f.Name == fp))
                    return fp;
            }


            if(IsIntPtr(memberType))
                return "IntPtr";

            string result = ConvertBasicTypes(memberType);
            if (result == string.Empty)
            {
                if (spec.Alias.TryGetValue(memberType, out string alias))
                {
                    memberType = alias;
                }

                spec.BaseTypes.TryGetValue(memberType, out string baseType);
                if (baseType != null)
                {
                    result = ConvertBasicTypes(baseType);
                }
                else
                {
                    var typeDef = spec.TypeDefs.Find(t => t.Name == memberType);
                    if (typeDef != null)
                    {
                        if (typeDef.Requires != null)
                        {
                            result = typeDef.Requires;
                        }
                        else
                        {
                            spec.BaseTypes.TryGetValue(typeDef.Type, out baseType);
                            if (baseType != null)
                            {
                                result = ConvertBasicTypes(baseType);
                            }
                        }
                    }
                    else
                    {
                        result = memberType;
                    }
                }
            }

            if (pointerlevel > 0)
            {
                for (int i = 0; i < pointerlevel; i++)
                {
                    result += "*";
                }
            }

            return result;
        }

        public static string ConvertBasicTypes(string type)
        {
            switch (type)
            {
                case "int8_t":
                    return "sbyte";
                case "int8_t*":
                    return "sbyte*";
                case "uint8_t":
                case "char":
                    return "byte";
                case "wchar_t":
                    return "string";
                case "uint8_t*":
                case "char*":
                    return "byte*";
                case "uint16_t":
                    return "ushort";
                case "uint16_t*":
                    return "ushort*";
                case "int16_t":
                    return "short";
                case "int16_t*":
                    return "int16*";
                case "uint32_t":
                case "DWORD":
                    return "uint";
                case "uint32_t*":
                    return "uint*";
                case "uint64_t":
                case "XR_DEFINE_ATOM":
                    return "ulong";
                case "uint64_t*":
                    return "ulong*";
                case "int32_t":
                    return "int";
                case "int32_t*":
                    return "int*";
                case "int64_t":
                    return "long";
                case "int64_t*":
                    return "long*";
                case "size_t":
                    return "UIntPtr";
                case "float":
                    return "float";
                case "float*":
                    return "float*";
                case "double":
                    return "double";
                case "double*":
                    return "double*";
                case "void":
                    return "void";
                case "XrBool32":
                    return "XrBool32";
                case "D3D_FEATURE_LEVEL":
                    return "uint";
                case "XR_DEFINE_OPAQUE_64":
                    return "ulong";
                default:
                    return string.Empty;
            }
        }

        public static bool SupportFixed(string type)
        {
            switch (type)
            {
                case "bool":
                case "byte":
                case "short":
                case "int":
                case "long":
                case "char":
                case "sbyte":
                case "ushort":
                case "uint":
                case "ulong":
                case "float":
                case "double":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsIntPtr(string type)
        {
            switch (type)
            {
                case "ANativeWindow":
                case "jobject":
                case "ID3D11Device":
                case "ID3D11Texture2D":
                case "ID3D12CommandQueue":
                case "ID3D12Device":
                case "ID3D12Resource":
                case "EGLDisplay":
                case "EGLConfig":
                case "EGLContext":
                case "PFNEGLGETPROCADDRESSPROC":
                case "GLXFBConfig":
                case "GLXDrawable":
                case "GLXContext":
                case "HGLRC":
                case "IUnknown":
                case "wl_display":
                case "HDC":
                case "LUID":
                case "LARGE_INTEGER":
                case "Display":
                case "VisualID":
                case "Window":
                case "xcb_glx_fbconfig_t":
                case "xcb_glx_drawable_t":
                case "xcb_glx_context_t":
                case "xcb_connection_t":
                case "xcb_visualid_t":
                case "xcb_window_t":
                case "PFN_vkGetInstanceProcAddr":
                case "VkAllocationCallbacks":
                case "VkDevice":
                case "VkDeviceCreateInfo":
                case "VkFormat":
                case "VkImage":
                case "VkInstance":
                case "VkInstanceCreateInfo":
                case "VkPhysicalDevice":
                case "VkResult":
                case "timespec":
                case "EGLenum":
                case "VkFilter":
                case "VkSamplerMipmapMode":
                case "VkSamplerAddressMode":
                case "VkComponentSwizzle":
                case "MLCoordinateFrameUID":
                    return true;
                default:
                    return false;
            }
        }
    }
}