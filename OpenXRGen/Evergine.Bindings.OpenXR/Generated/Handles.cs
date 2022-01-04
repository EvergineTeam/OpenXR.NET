using System;

namespace Evergine.Bindings.OpenXR
{
	public partial struct XrInstance : IEquatable<XrInstance>
{
		public readonly ulong Handle;
		public XrInstance(ulong existingHandle) { Handle = existingHandle; }
		public static XrInstance Null => new XrInstance(0);
		public static implicit operator XrInstance(ulong handle) => new XrInstance(handle);
		public static bool operator ==(XrInstance left, XrInstance right) => left.Handle == right.Handle;
		public static bool operator !=(XrInstance left, XrInstance right) => left.Handle != right.Handle;
		public static bool operator ==(XrInstance left, ulong right) => left.Handle == right;
		public static bool operator !=(XrInstance left, ulong right) => left.Handle != right;
		public bool Equals(XrInstance h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrInstance h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSession : IEquatable<XrSession>
{
		public readonly ulong Handle;
		public XrSession(ulong existingHandle) { Handle = existingHandle; }
		public static XrSession Null => new XrSession(0);
		public static implicit operator XrSession(ulong handle) => new XrSession(handle);
		public static bool operator ==(XrSession left, XrSession right) => left.Handle == right.Handle;
		public static bool operator !=(XrSession left, XrSession right) => left.Handle != right.Handle;
		public static bool operator ==(XrSession left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSession left, ulong right) => left.Handle != right;
		public bool Equals(XrSession h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSession h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrActionSet : IEquatable<XrActionSet>
{
		public readonly ulong Handle;
		public XrActionSet(ulong existingHandle) { Handle = existingHandle; }
		public static XrActionSet Null => new XrActionSet(0);
		public static implicit operator XrActionSet(ulong handle) => new XrActionSet(handle);
		public static bool operator ==(XrActionSet left, XrActionSet right) => left.Handle == right.Handle;
		public static bool operator !=(XrActionSet left, XrActionSet right) => left.Handle != right.Handle;
		public static bool operator ==(XrActionSet left, ulong right) => left.Handle == right;
		public static bool operator !=(XrActionSet left, ulong right) => left.Handle != right;
		public bool Equals(XrActionSet h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrActionSet h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrAction : IEquatable<XrAction>
{
		public readonly ulong Handle;
		public XrAction(ulong existingHandle) { Handle = existingHandle; }
		public static XrAction Null => new XrAction(0);
		public static implicit operator XrAction(ulong handle) => new XrAction(handle);
		public static bool operator ==(XrAction left, XrAction right) => left.Handle == right.Handle;
		public static bool operator !=(XrAction left, XrAction right) => left.Handle != right.Handle;
		public static bool operator ==(XrAction left, ulong right) => left.Handle == right;
		public static bool operator !=(XrAction left, ulong right) => left.Handle != right;
		public bool Equals(XrAction h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrAction h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSwapchain : IEquatable<XrSwapchain>
{
		public readonly ulong Handle;
		public XrSwapchain(ulong existingHandle) { Handle = existingHandle; }
		public static XrSwapchain Null => new XrSwapchain(0);
		public static implicit operator XrSwapchain(ulong handle) => new XrSwapchain(handle);
		public static bool operator ==(XrSwapchain left, XrSwapchain right) => left.Handle == right.Handle;
		public static bool operator !=(XrSwapchain left, XrSwapchain right) => left.Handle != right.Handle;
		public static bool operator ==(XrSwapchain left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSwapchain left, ulong right) => left.Handle != right;
		public bool Equals(XrSwapchain h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSwapchain h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSpace : IEquatable<XrSpace>
{
		public readonly ulong Handle;
		public XrSpace(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpace Null => new XrSpace(0);
		public static implicit operator XrSpace(ulong handle) => new XrSpace(handle);
		public static bool operator ==(XrSpace left, XrSpace right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpace left, XrSpace right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpace left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpace left, ulong right) => left.Handle != right;
		public bool Equals(XrSpace h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpace h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrDebugUtilsMessengerEXT : IEquatable<XrDebugUtilsMessengerEXT>
{
		public readonly ulong Handle;
		public XrDebugUtilsMessengerEXT(ulong existingHandle) { Handle = existingHandle; }
		public static XrDebugUtilsMessengerEXT Null => new XrDebugUtilsMessengerEXT(0);
		public static implicit operator XrDebugUtilsMessengerEXT(ulong handle) => new XrDebugUtilsMessengerEXT(handle);
		public static bool operator ==(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrDebugUtilsMessengerEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrDebugUtilsMessengerEXT left, ulong right) => left.Handle != right;
		public bool Equals(XrDebugUtilsMessengerEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrDebugUtilsMessengerEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSpatialAnchorMSFT : IEquatable<XrSpatialAnchorMSFT>
{
		public readonly ulong Handle;
		public XrSpatialAnchorMSFT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialAnchorMSFT Null => new XrSpatialAnchorMSFT(0);
		public static implicit operator XrSpatialAnchorMSFT(ulong handle) => new XrSpatialAnchorMSFT(handle);
		public static bool operator ==(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAnchorMSFT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialAnchorMSFT left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialAnchorMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAnchorMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrHandTrackerEXT : IEquatable<XrHandTrackerEXT>
{
		public readonly ulong Handle;
		public XrHandTrackerEXT(ulong existingHandle) { Handle = existingHandle; }
		public static XrHandTrackerEXT Null => new XrHandTrackerEXT(0);
		public static implicit operator XrHandTrackerEXT(ulong handle) => new XrHandTrackerEXT(handle);
		public static bool operator ==(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrHandTrackerEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrHandTrackerEXT left, ulong right) => left.Handle != right;
		public bool Equals(XrHandTrackerEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrHandTrackerEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

}
