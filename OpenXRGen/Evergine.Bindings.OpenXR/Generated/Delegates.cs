using System;

namespace Evergine.Bindings.OpenXR
{
	public unsafe delegate void PFN_xrVoidFunction();

	public unsafe delegate XrResult PFN_xrGetInstanceProcAddr(
		XrInstance instance,
		byte* name,
		IntPtr function);

	public unsafe delegate XrResult PFN_xrCreateApiLayerInstance(
		XrInstanceCreateInfo* info,
		XrApiLayerCreateInfo* apiLayerInfo,
		XrInstance* instance);

	public unsafe delegate XrBool32 PFN_xrDebugUtilsMessengerCallbackEXT(
		ulong messageSeverity,
		ulong messageTypes,
		XrDebugUtilsMessengerCallbackDataEXT* callbackData,
		void* userData);

	public unsafe delegate PFN_xrVoidFunction PFN_xrEglGetProcAddressMNDX(
		byte* name);

}
