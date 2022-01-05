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

	public partial struct XrFoveationProfileFB : IEquatable<XrFoveationProfileFB>
{
		public readonly ulong Handle;
		public XrFoveationProfileFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrFoveationProfileFB Null => new XrFoveationProfileFB(0);
		public static implicit operator XrFoveationProfileFB(ulong handle) => new XrFoveationProfileFB(handle);
		public static bool operator ==(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrFoveationProfileFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrFoveationProfileFB left, ulong right) => left.Handle != right;
		public bool Equals(XrFoveationProfileFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFoveationProfileFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrTriangleMeshFB : IEquatable<XrTriangleMeshFB>
{
		public readonly ulong Handle;
		public XrTriangleMeshFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrTriangleMeshFB Null => new XrTriangleMeshFB(0);
		public static implicit operator XrTriangleMeshFB(ulong handle) => new XrTriangleMeshFB(handle);
		public static bool operator ==(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrTriangleMeshFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrTriangleMeshFB left, ulong right) => left.Handle != right;
		public bool Equals(XrTriangleMeshFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrTriangleMeshFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrPassthroughFB : IEquatable<XrPassthroughFB>
{
		public readonly ulong Handle;
		public XrPassthroughFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrPassthroughFB Null => new XrPassthroughFB(0);
		public static implicit operator XrPassthroughFB(ulong handle) => new XrPassthroughFB(handle);
		public static bool operator ==(XrPassthroughFB left, XrPassthroughFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughFB left, XrPassthroughFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrPassthroughFB left, ulong right) => left.Handle != right;
		public bool Equals(XrPassthroughFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrPassthroughLayerFB : IEquatable<XrPassthroughLayerFB>
{
		public readonly ulong Handle;
		public XrPassthroughLayerFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrPassthroughLayerFB Null => new XrPassthroughLayerFB(0);
		public static implicit operator XrPassthroughLayerFB(ulong handle) => new XrPassthroughLayerFB(handle);
		public static bool operator ==(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughLayerFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrPassthroughLayerFB left, ulong right) => left.Handle != right;
		public bool Equals(XrPassthroughLayerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughLayerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrGeometryInstanceFB : IEquatable<XrGeometryInstanceFB>
{
		public readonly ulong Handle;
		public XrGeometryInstanceFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrGeometryInstanceFB Null => new XrGeometryInstanceFB(0);
		public static implicit operator XrGeometryInstanceFB(ulong handle) => new XrGeometryInstanceFB(handle);
		public static bool operator ==(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrGeometryInstanceFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrGeometryInstanceFB left, ulong right) => left.Handle != right;
		public bool Equals(XrGeometryInstanceFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrGeometryInstanceFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSceneObserverMSFT : IEquatable<XrSceneObserverMSFT>
{
		public readonly ulong Handle;
		public XrSceneObserverMSFT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSceneObserverMSFT Null => new XrSceneObserverMSFT(0);
		public static implicit operator XrSceneObserverMSFT(ulong handle) => new XrSceneObserverMSFT(handle);
		public static bool operator ==(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSceneObserverMSFT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSceneObserverMSFT left, ulong right) => left.Handle != right;
		public bool Equals(XrSceneObserverMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSceneObserverMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSceneMSFT : IEquatable<XrSceneMSFT>
{
		public readonly ulong Handle;
		public XrSceneMSFT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSceneMSFT Null => new XrSceneMSFT(0);
		public static implicit operator XrSceneMSFT(ulong handle) => new XrSceneMSFT(handle);
		public static bool operator ==(XrSceneMSFT left, XrSceneMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSceneMSFT left, XrSceneMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSceneMSFT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSceneMSFT left, ulong right) => left.Handle != right;
		public bool Equals(XrSceneMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSceneMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSpatialAnchorStoreConnectionMSFT : IEquatable<XrSpatialAnchorStoreConnectionMSFT>
{
		public readonly ulong Handle;
		public XrSpatialAnchorStoreConnectionMSFT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialAnchorStoreConnectionMSFT Null => new XrSpatialAnchorStoreConnectionMSFT(0);
		public static implicit operator XrSpatialAnchorStoreConnectionMSFT(ulong handle) => new XrSpatialAnchorStoreConnectionMSFT(handle);
		public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialAnchorStoreConnectionMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAnchorStoreConnectionMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

}
