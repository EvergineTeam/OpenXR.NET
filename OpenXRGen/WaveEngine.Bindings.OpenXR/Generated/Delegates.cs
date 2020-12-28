using System;

namespace WaveEngine.Bindings.OpenXR
{
	public unsafe delegate void PFN_xrVoidFunction();

	public unsafe delegate XrBool32 PFN_xrDebugUtilsMessengerCallbackEXT(
		ulong messageSeverity,
		ulong messageTypes,
		XrDebugUtilsMessengerCallbackDataEXT* callbackData,
		void* userData);

}
