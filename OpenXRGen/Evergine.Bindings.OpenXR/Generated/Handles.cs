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

	public partial struct XrFacialTrackerHTC : IEquatable<XrFacialTrackerHTC>
{
		public readonly ulong Handle;
		public XrFacialTrackerHTC(ulong existingHandle) { Handle = existingHandle; }
		public static XrFacialTrackerHTC Null => new XrFacialTrackerHTC(0);
		public static implicit operator XrFacialTrackerHTC(ulong handle) => new XrFacialTrackerHTC(handle);
		public static bool operator ==(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Handle == right.Handle;
		public static bool operator !=(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Handle != right.Handle;
		public static bool operator ==(XrFacialTrackerHTC left, ulong right) => left.Handle == right;
		public static bool operator !=(XrFacialTrackerHTC left, ulong right) => left.Handle != right;
		public bool Equals(XrFacialTrackerHTC h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFacialTrackerHTC h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrPassthroughHTC : IEquatable<XrPassthroughHTC>
{
		public readonly ulong Handle;
		public XrPassthroughHTC(ulong existingHandle) { Handle = existingHandle; }
		public static XrPassthroughHTC Null => new XrPassthroughHTC(0);
		public static implicit operator XrPassthroughHTC(ulong handle) => new XrPassthroughHTC(handle);
		public static bool operator ==(XrPassthroughHTC left, XrPassthroughHTC right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughHTC left, XrPassthroughHTC right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughHTC left, ulong right) => left.Handle == right;
		public static bool operator !=(XrPassthroughHTC left, ulong right) => left.Handle != right;
		public bool Equals(XrPassthroughHTC h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughHTC h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrFaceTrackerFB : IEquatable<XrFaceTrackerFB>
{
		public readonly ulong Handle;
		public XrFaceTrackerFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrFaceTrackerFB Null => new XrFaceTrackerFB(0);
		public static implicit operator XrFaceTrackerFB(ulong handle) => new XrFaceTrackerFB(handle);
		public static bool operator ==(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrFaceTrackerFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrFaceTrackerFB left, ulong right) => left.Handle != right;
		public bool Equals(XrFaceTrackerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFaceTrackerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrFaceTracker2FB : IEquatable<XrFaceTracker2FB>
{
		public readonly ulong Handle;
		public XrFaceTracker2FB(ulong existingHandle) { Handle = existingHandle; }
		public static XrFaceTracker2FB Null => new XrFaceTracker2FB(0);
		public static implicit operator XrFaceTracker2FB(ulong handle) => new XrFaceTracker2FB(handle);
		public static bool operator ==(XrFaceTracker2FB left, XrFaceTracker2FB right) => left.Handle == right.Handle;
		public static bool operator !=(XrFaceTracker2FB left, XrFaceTracker2FB right) => left.Handle != right.Handle;
		public static bool operator ==(XrFaceTracker2FB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrFaceTracker2FB left, ulong right) => left.Handle != right;
		public bool Equals(XrFaceTracker2FB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFaceTracker2FB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrBodyTrackerFB : IEquatable<XrBodyTrackerFB>
{
		public readonly ulong Handle;
		public XrBodyTrackerFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrBodyTrackerFB Null => new XrBodyTrackerFB(0);
		public static implicit operator XrBodyTrackerFB(ulong handle) => new XrBodyTrackerFB(handle);
		public static bool operator ==(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrBodyTrackerFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrBodyTrackerFB left, ulong right) => left.Handle != right;
		public bool Equals(XrBodyTrackerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrBodyTrackerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrEyeTrackerFB : IEquatable<XrEyeTrackerFB>
{
		public readonly ulong Handle;
		public XrEyeTrackerFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrEyeTrackerFB Null => new XrEyeTrackerFB(0);
		public static implicit operator XrEyeTrackerFB(ulong handle) => new XrEyeTrackerFB(handle);
		public static bool operator ==(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrEyeTrackerFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrEyeTrackerFB left, ulong right) => left.Handle != right;
		public bool Equals(XrEyeTrackerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEyeTrackerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSpaceUserFB : IEquatable<XrSpaceUserFB>
{
		public readonly ulong Handle;
		public XrSpaceUserFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpaceUserFB Null => new XrSpaceUserFB(0);
		public static implicit operator XrSpaceUserFB(ulong handle) => new XrSpaceUserFB(handle);
		public static bool operator ==(XrSpaceUserFB left, XrSpaceUserFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpaceUserFB left, XrSpaceUserFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpaceUserFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpaceUserFB left, ulong right) => left.Handle != right;
		public bool Equals(XrSpaceUserFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpaceUserFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrPassthroughColorLutMETA : IEquatable<XrPassthroughColorLutMETA>
{
		public readonly ulong Handle;
		public XrPassthroughColorLutMETA(ulong existingHandle) { Handle = existingHandle; }
		public static XrPassthroughColorLutMETA Null => new XrPassthroughColorLutMETA(0);
		public static implicit operator XrPassthroughColorLutMETA(ulong handle) => new XrPassthroughColorLutMETA(handle);
		public static bool operator ==(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughColorLutMETA left, ulong right) => left.Handle == right;
		public static bool operator !=(XrPassthroughColorLutMETA left, ulong right) => left.Handle != right;
		public bool Equals(XrPassthroughColorLutMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughColorLutMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrPlaneDetectorEXT : IEquatable<XrPlaneDetectorEXT>
{
		public readonly ulong Handle;
		public XrPlaneDetectorEXT(ulong existingHandle) { Handle = existingHandle; }
		public static XrPlaneDetectorEXT Null => new XrPlaneDetectorEXT(0);
		public static implicit operator XrPlaneDetectorEXT(ulong handle) => new XrPlaneDetectorEXT(handle);
		public static bool operator ==(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrPlaneDetectorEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrPlaneDetectorEXT left, ulong right) => left.Handle != right;
		public bool Equals(XrPlaneDetectorEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPlaneDetectorEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrVirtualKeyboardMETA : IEquatable<XrVirtualKeyboardMETA>
{
		public readonly ulong Handle;
		public XrVirtualKeyboardMETA(ulong existingHandle) { Handle = existingHandle; }
		public static XrVirtualKeyboardMETA Null => new XrVirtualKeyboardMETA(0);
		public static implicit operator XrVirtualKeyboardMETA(ulong handle) => new XrVirtualKeyboardMETA(handle);
		public static bool operator ==(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrVirtualKeyboardMETA left, ulong right) => left.Handle == right;
		public static bool operator !=(XrVirtualKeyboardMETA left, ulong right) => left.Handle != right;
		public bool Equals(XrVirtualKeyboardMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrVirtualKeyboardMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSpatialAnchorsStorageML : IEquatable<XrSpatialAnchorsStorageML>
{
		public readonly ulong Handle;
		public XrSpatialAnchorsStorageML(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialAnchorsStorageML Null => new XrSpatialAnchorsStorageML(0);
		public static implicit operator XrSpatialAnchorsStorageML(ulong handle) => new XrSpatialAnchorsStorageML(handle);
		public static bool operator ==(XrSpatialAnchorsStorageML left, XrSpatialAnchorsStorageML right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAnchorsStorageML left, XrSpatialAnchorsStorageML right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAnchorsStorageML left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialAnchorsStorageML left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialAnchorsStorageML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAnchorsStorageML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrExportedLocalizationMapML : IEquatable<XrExportedLocalizationMapML>
{
		public readonly ulong Handle;
		public XrExportedLocalizationMapML(ulong existingHandle) { Handle = existingHandle; }
		public static XrExportedLocalizationMapML Null => new XrExportedLocalizationMapML(0);
		public static implicit operator XrExportedLocalizationMapML(ulong handle) => new XrExportedLocalizationMapML(handle);
		public static bool operator ==(XrExportedLocalizationMapML left, XrExportedLocalizationMapML right) => left.Handle == right.Handle;
		public static bool operator !=(XrExportedLocalizationMapML left, XrExportedLocalizationMapML right) => left.Handle != right.Handle;
		public static bool operator ==(XrExportedLocalizationMapML left, ulong right) => left.Handle == right;
		public static bool operator !=(XrExportedLocalizationMapML left, ulong right) => left.Handle != right;
		public bool Equals(XrExportedLocalizationMapML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrExportedLocalizationMapML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrMarkerDetectorML : IEquatable<XrMarkerDetectorML>
{
		public readonly ulong Handle;
		public XrMarkerDetectorML(ulong existingHandle) { Handle = existingHandle; }
		public static XrMarkerDetectorML Null => new XrMarkerDetectorML(0);
		public static implicit operator XrMarkerDetectorML(ulong handle) => new XrMarkerDetectorML(handle);
		public static bool operator ==(XrMarkerDetectorML left, XrMarkerDetectorML right) => left.Handle == right.Handle;
		public static bool operator !=(XrMarkerDetectorML left, XrMarkerDetectorML right) => left.Handle != right.Handle;
		public static bool operator ==(XrMarkerDetectorML left, ulong right) => left.Handle == right;
		public static bool operator !=(XrMarkerDetectorML left, ulong right) => left.Handle != right;
		public bool Equals(XrMarkerDetectorML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrMarkerDetectorML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrFacialExpressionClientML : IEquatable<XrFacialExpressionClientML>
{
		public readonly ulong Handle;
		public XrFacialExpressionClientML(ulong existingHandle) { Handle = existingHandle; }
		public static XrFacialExpressionClientML Null => new XrFacialExpressionClientML(0);
		public static implicit operator XrFacialExpressionClientML(ulong handle) => new XrFacialExpressionClientML(handle);
		public static bool operator ==(XrFacialExpressionClientML left, XrFacialExpressionClientML right) => left.Handle == right.Handle;
		public static bool operator !=(XrFacialExpressionClientML left, XrFacialExpressionClientML right) => left.Handle != right.Handle;
		public static bool operator ==(XrFacialExpressionClientML left, ulong right) => left.Handle == right;
		public static bool operator !=(XrFacialExpressionClientML left, ulong right) => left.Handle != right;
		public bool Equals(XrFacialExpressionClientML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFacialExpressionClientML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrEnvironmentDepthProviderMETA : IEquatable<XrEnvironmentDepthProviderMETA>
{
		public readonly ulong Handle;
		public XrEnvironmentDepthProviderMETA(ulong existingHandle) { Handle = existingHandle; }
		public static XrEnvironmentDepthProviderMETA Null => new XrEnvironmentDepthProviderMETA(0);
		public static implicit operator XrEnvironmentDepthProviderMETA(ulong handle) => new XrEnvironmentDepthProviderMETA(handle);
		public static bool operator ==(XrEnvironmentDepthProviderMETA left, XrEnvironmentDepthProviderMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrEnvironmentDepthProviderMETA left, XrEnvironmentDepthProviderMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrEnvironmentDepthProviderMETA left, ulong right) => left.Handle == right;
		public static bool operator !=(XrEnvironmentDepthProviderMETA left, ulong right) => left.Handle != right;
		public bool Equals(XrEnvironmentDepthProviderMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEnvironmentDepthProviderMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrEnvironmentDepthSwapchainMETA : IEquatable<XrEnvironmentDepthSwapchainMETA>
{
		public readonly ulong Handle;
		public XrEnvironmentDepthSwapchainMETA(ulong existingHandle) { Handle = existingHandle; }
		public static XrEnvironmentDepthSwapchainMETA Null => new XrEnvironmentDepthSwapchainMETA(0);
		public static implicit operator XrEnvironmentDepthSwapchainMETA(ulong handle) => new XrEnvironmentDepthSwapchainMETA(handle);
		public static bool operator ==(XrEnvironmentDepthSwapchainMETA left, XrEnvironmentDepthSwapchainMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrEnvironmentDepthSwapchainMETA left, XrEnvironmentDepthSwapchainMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrEnvironmentDepthSwapchainMETA left, ulong right) => left.Handle == right;
		public static bool operator !=(XrEnvironmentDepthSwapchainMETA left, ulong right) => left.Handle != right;
		public bool Equals(XrEnvironmentDepthSwapchainMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEnvironmentDepthSwapchainMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrBodyTrackerHTC : IEquatable<XrBodyTrackerHTC>
{
		public readonly ulong Handle;
		public XrBodyTrackerHTC(ulong existingHandle) { Handle = existingHandle; }
		public static XrBodyTrackerHTC Null => new XrBodyTrackerHTC(0);
		public static implicit operator XrBodyTrackerHTC(ulong handle) => new XrBodyTrackerHTC(handle);
		public static bool operator ==(XrBodyTrackerHTC left, XrBodyTrackerHTC right) => left.Handle == right.Handle;
		public static bool operator !=(XrBodyTrackerHTC left, XrBodyTrackerHTC right) => left.Handle != right.Handle;
		public static bool operator ==(XrBodyTrackerHTC left, ulong right) => left.Handle == right;
		public static bool operator !=(XrBodyTrackerHTC left, ulong right) => left.Handle != right;
		public bool Equals(XrBodyTrackerHTC h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrBodyTrackerHTC h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrWorldMeshDetectorML : IEquatable<XrWorldMeshDetectorML>
{
		public readonly ulong Handle;
		public XrWorldMeshDetectorML(ulong existingHandle) { Handle = existingHandle; }
		public static XrWorldMeshDetectorML Null => new XrWorldMeshDetectorML(0);
		public static implicit operator XrWorldMeshDetectorML(ulong handle) => new XrWorldMeshDetectorML(handle);
		public static bool operator ==(XrWorldMeshDetectorML left, XrWorldMeshDetectorML right) => left.Handle == right.Handle;
		public static bool operator !=(XrWorldMeshDetectorML left, XrWorldMeshDetectorML right) => left.Handle != right.Handle;
		public static bool operator ==(XrWorldMeshDetectorML left, ulong right) => left.Handle == right;
		public static bool operator !=(XrWorldMeshDetectorML left, ulong right) => left.Handle != right;
		public bool Equals(XrWorldMeshDetectorML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrWorldMeshDetectorML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrBodyTrackerBD : IEquatable<XrBodyTrackerBD>
{
		public readonly ulong Handle;
		public XrBodyTrackerBD(ulong existingHandle) { Handle = existingHandle; }
		public static XrBodyTrackerBD Null => new XrBodyTrackerBD(0);
		public static implicit operator XrBodyTrackerBD(ulong handle) => new XrBodyTrackerBD(handle);
		public static bool operator ==(XrBodyTrackerBD left, XrBodyTrackerBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrBodyTrackerBD left, XrBodyTrackerBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrBodyTrackerBD left, ulong right) => left.Handle == right;
		public static bool operator !=(XrBodyTrackerBD left, ulong right) => left.Handle != right;
		public bool Equals(XrBodyTrackerBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrBodyTrackerBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
}

	public partial struct XrSpatialGraphNodeBindingMSFT : IEquatable<XrSpatialGraphNodeBindingMSFT>
{
		public readonly ulong Handle;
		public XrSpatialGraphNodeBindingMSFT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialGraphNodeBindingMSFT Null => new XrSpatialGraphNodeBindingMSFT(0);
		public static implicit operator XrSpatialGraphNodeBindingMSFT(ulong handle) => new XrSpatialGraphNodeBindingMSFT(handle);
		public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialGraphNodeBindingMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialGraphNodeBindingMSFT h && Equals(h);
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
