using System;

namespace Evergine.Bindings.OpenXR
{
	public partial struct XrInstance : IEquatable<XrInstance>
	{
		public readonly IntPtr Handle;
		public XrInstance(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrInstance Null => new XrInstance(IntPtr.Zero);
		public static implicit operator XrInstance(IntPtr handle) => new XrInstance(handle);
		public static bool operator ==(XrInstance left, XrInstance right) => left.Handle == right.Handle;
		public static bool operator !=(XrInstance left, XrInstance right) => left.Handle != right.Handle;
		public static bool operator ==(XrInstance left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrInstance left, IntPtr right) => left.Handle != right;
		public bool Equals(XrInstance h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrInstance h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSession : IEquatable<XrSession>
	{
		public readonly IntPtr Handle;
		public XrSession(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSession Null => new XrSession(IntPtr.Zero);
		public static implicit operator XrSession(IntPtr handle) => new XrSession(handle);
		public static bool operator ==(XrSession left, XrSession right) => left.Handle == right.Handle;
		public static bool operator !=(XrSession left, XrSession right) => left.Handle != right.Handle;
		public static bool operator ==(XrSession left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSession left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSession h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSession h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrActionSet : IEquatable<XrActionSet>
	{
		public readonly IntPtr Handle;
		public XrActionSet(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrActionSet Null => new XrActionSet(IntPtr.Zero);
		public static implicit operator XrActionSet(IntPtr handle) => new XrActionSet(handle);
		public static bool operator ==(XrActionSet left, XrActionSet right) => left.Handle == right.Handle;
		public static bool operator !=(XrActionSet left, XrActionSet right) => left.Handle != right.Handle;
		public static bool operator ==(XrActionSet left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrActionSet left, IntPtr right) => left.Handle != right;
		public bool Equals(XrActionSet h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrActionSet h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrAction : IEquatable<XrAction>
	{
		public readonly IntPtr Handle;
		public XrAction(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrAction Null => new XrAction(IntPtr.Zero);
		public static implicit operator XrAction(IntPtr handle) => new XrAction(handle);
		public static bool operator ==(XrAction left, XrAction right) => left.Handle == right.Handle;
		public static bool operator !=(XrAction left, XrAction right) => left.Handle != right.Handle;
		public static bool operator ==(XrAction left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrAction left, IntPtr right) => left.Handle != right;
		public bool Equals(XrAction h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrAction h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSwapchain : IEquatable<XrSwapchain>
	{
		public readonly IntPtr Handle;
		public XrSwapchain(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSwapchain Null => new XrSwapchain(IntPtr.Zero);
		public static implicit operator XrSwapchain(IntPtr handle) => new XrSwapchain(handle);
		public static bool operator ==(XrSwapchain left, XrSwapchain right) => left.Handle == right.Handle;
		public static bool operator !=(XrSwapchain left, XrSwapchain right) => left.Handle != right.Handle;
		public static bool operator ==(XrSwapchain left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSwapchain left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSwapchain h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSwapchain h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpace : IEquatable<XrSpace>
	{
		public readonly IntPtr Handle;
		public XrSpace(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpace Null => new XrSpace(IntPtr.Zero);
		public static implicit operator XrSpace(IntPtr handle) => new XrSpace(handle);
		public static bool operator ==(XrSpace left, XrSpace right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpace left, XrSpace right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpace left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpace left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpace h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpace h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrDebugUtilsMessengerEXT : IEquatable<XrDebugUtilsMessengerEXT>
	{
		public readonly IntPtr Handle;
		public XrDebugUtilsMessengerEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrDebugUtilsMessengerEXT Null => new XrDebugUtilsMessengerEXT(IntPtr.Zero);
		public static implicit operator XrDebugUtilsMessengerEXT(IntPtr handle) => new XrDebugUtilsMessengerEXT(handle);
		public static bool operator ==(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrDebugUtilsMessengerEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrDebugUtilsMessengerEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrDebugUtilsMessengerEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrDebugUtilsMessengerEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialAnchorMSFT : IEquatable<XrSpatialAnchorMSFT>
	{
		public readonly IntPtr Handle;
		public XrSpatialAnchorMSFT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialAnchorMSFT Null => new XrSpatialAnchorMSFT(IntPtr.Zero);
		public static implicit operator XrSpatialAnchorMSFT(IntPtr handle) => new XrSpatialAnchorMSFT(handle);
		public static bool operator ==(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAnchorMSFT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialAnchorMSFT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialAnchorMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAnchorMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrHandTrackerEXT : IEquatable<XrHandTrackerEXT>
	{
		public readonly IntPtr Handle;
		public XrHandTrackerEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrHandTrackerEXT Null => new XrHandTrackerEXT(IntPtr.Zero);
		public static implicit operator XrHandTrackerEXT(IntPtr handle) => new XrHandTrackerEXT(handle);
		public static bool operator ==(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrHandTrackerEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrHandTrackerEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrHandTrackerEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrHandTrackerEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFoveationProfileFB : IEquatable<XrFoveationProfileFB>
	{
		public readonly IntPtr Handle;
		public XrFoveationProfileFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFoveationProfileFB Null => new XrFoveationProfileFB(IntPtr.Zero);
		public static implicit operator XrFoveationProfileFB(IntPtr handle) => new XrFoveationProfileFB(handle);
		public static bool operator ==(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrFoveationProfileFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFoveationProfileFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFoveationProfileFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFoveationProfileFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrTriangleMeshFB : IEquatable<XrTriangleMeshFB>
	{
		public readonly IntPtr Handle;
		public XrTriangleMeshFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrTriangleMeshFB Null => new XrTriangleMeshFB(IntPtr.Zero);
		public static implicit operator XrTriangleMeshFB(IntPtr handle) => new XrTriangleMeshFB(handle);
		public static bool operator ==(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrTriangleMeshFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrTriangleMeshFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrTriangleMeshFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrTriangleMeshFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPassthroughFB : IEquatable<XrPassthroughFB>
	{
		public readonly IntPtr Handle;
		public XrPassthroughFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrPassthroughFB Null => new XrPassthroughFB(IntPtr.Zero);
		public static implicit operator XrPassthroughFB(IntPtr handle) => new XrPassthroughFB(handle);
		public static bool operator ==(XrPassthroughFB left, XrPassthroughFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughFB left, XrPassthroughFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrPassthroughFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrPassthroughFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPassthroughLayerFB : IEquatable<XrPassthroughLayerFB>
	{
		public readonly IntPtr Handle;
		public XrPassthroughLayerFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrPassthroughLayerFB Null => new XrPassthroughLayerFB(IntPtr.Zero);
		public static implicit operator XrPassthroughLayerFB(IntPtr handle) => new XrPassthroughLayerFB(handle);
		public static bool operator ==(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughLayerFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrPassthroughLayerFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrPassthroughLayerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughLayerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrGeometryInstanceFB : IEquatable<XrGeometryInstanceFB>
	{
		public readonly IntPtr Handle;
		public XrGeometryInstanceFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrGeometryInstanceFB Null => new XrGeometryInstanceFB(IntPtr.Zero);
		public static implicit operator XrGeometryInstanceFB(IntPtr handle) => new XrGeometryInstanceFB(handle);
		public static bool operator ==(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrGeometryInstanceFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrGeometryInstanceFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrGeometryInstanceFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrGeometryInstanceFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFacialTrackerHTC : IEquatable<XrFacialTrackerHTC>
	{
		public readonly IntPtr Handle;
		public XrFacialTrackerHTC(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFacialTrackerHTC Null => new XrFacialTrackerHTC(IntPtr.Zero);
		public static implicit operator XrFacialTrackerHTC(IntPtr handle) => new XrFacialTrackerHTC(handle);
		public static bool operator ==(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Handle == right.Handle;
		public static bool operator !=(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Handle != right.Handle;
		public static bool operator ==(XrFacialTrackerHTC left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFacialTrackerHTC left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFacialTrackerHTC h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFacialTrackerHTC h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPassthroughHTC : IEquatable<XrPassthroughHTC>
	{
		public readonly IntPtr Handle;
		public XrPassthroughHTC(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrPassthroughHTC Null => new XrPassthroughHTC(IntPtr.Zero);
		public static implicit operator XrPassthroughHTC(IntPtr handle) => new XrPassthroughHTC(handle);
		public static bool operator ==(XrPassthroughHTC left, XrPassthroughHTC right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughHTC left, XrPassthroughHTC right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughHTC left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrPassthroughHTC left, IntPtr right) => left.Handle != right;
		public bool Equals(XrPassthroughHTC h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughHTC h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFaceTrackerANDROID : IEquatable<XrFaceTrackerANDROID>
	{
		public readonly IntPtr Handle;
		public XrFaceTrackerANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFaceTrackerANDROID Null => new XrFaceTrackerANDROID(IntPtr.Zero);
		public static implicit operator XrFaceTrackerANDROID(IntPtr handle) => new XrFaceTrackerANDROID(handle);
		public static bool operator ==(XrFaceTrackerANDROID left, XrFaceTrackerANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrFaceTrackerANDROID left, XrFaceTrackerANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrFaceTrackerANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFaceTrackerANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFaceTrackerANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFaceTrackerANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrTrackableTrackerANDROID : IEquatable<XrTrackableTrackerANDROID>
	{
		public readonly IntPtr Handle;
		public XrTrackableTrackerANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrTrackableTrackerANDROID Null => new XrTrackableTrackerANDROID(IntPtr.Zero);
		public static implicit operator XrTrackableTrackerANDROID(IntPtr handle) => new XrTrackableTrackerANDROID(handle);
		public static bool operator ==(XrTrackableTrackerANDROID left, XrTrackableTrackerANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrTrackableTrackerANDROID left, XrTrackableTrackerANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrTrackableTrackerANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrTrackableTrackerANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrTrackableTrackerANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrTrackableTrackerANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrDeviceAnchorPersistenceANDROID : IEquatable<XrDeviceAnchorPersistenceANDROID>
	{
		public readonly IntPtr Handle;
		public XrDeviceAnchorPersistenceANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrDeviceAnchorPersistenceANDROID Null => new XrDeviceAnchorPersistenceANDROID(IntPtr.Zero);
		public static implicit operator XrDeviceAnchorPersistenceANDROID(IntPtr handle) => new XrDeviceAnchorPersistenceANDROID(handle);
		public static bool operator ==(XrDeviceAnchorPersistenceANDROID left, XrDeviceAnchorPersistenceANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrDeviceAnchorPersistenceANDROID left, XrDeviceAnchorPersistenceANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrDeviceAnchorPersistenceANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrDeviceAnchorPersistenceANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrDeviceAnchorPersistenceANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrDeviceAnchorPersistenceANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPassthroughLayerANDROID : IEquatable<XrPassthroughLayerANDROID>
	{
		public readonly IntPtr Handle;
		public XrPassthroughLayerANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrPassthroughLayerANDROID Null => new XrPassthroughLayerANDROID(IntPtr.Zero);
		public static implicit operator XrPassthroughLayerANDROID(IntPtr handle) => new XrPassthroughLayerANDROID(handle);
		public static bool operator ==(XrPassthroughLayerANDROID left, XrPassthroughLayerANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughLayerANDROID left, XrPassthroughLayerANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughLayerANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrPassthroughLayerANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrPassthroughLayerANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughLayerANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSceneMeshingTrackerANDROID : IEquatable<XrSceneMeshingTrackerANDROID>
	{
		public readonly IntPtr Handle;
		public XrSceneMeshingTrackerANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSceneMeshingTrackerANDROID Null => new XrSceneMeshingTrackerANDROID(IntPtr.Zero);
		public static implicit operator XrSceneMeshingTrackerANDROID(IntPtr handle) => new XrSceneMeshingTrackerANDROID(handle);
		public static bool operator ==(XrSceneMeshingTrackerANDROID left, XrSceneMeshingTrackerANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrSceneMeshingTrackerANDROID left, XrSceneMeshingTrackerANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrSceneMeshingTrackerANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSceneMeshingTrackerANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSceneMeshingTrackerANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSceneMeshingTrackerANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSceneMeshSnapshotANDROID : IEquatable<XrSceneMeshSnapshotANDROID>
	{
		public readonly IntPtr Handle;
		public XrSceneMeshSnapshotANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSceneMeshSnapshotANDROID Null => new XrSceneMeshSnapshotANDROID(IntPtr.Zero);
		public static implicit operator XrSceneMeshSnapshotANDROID(IntPtr handle) => new XrSceneMeshSnapshotANDROID(handle);
		public static bool operator ==(XrSceneMeshSnapshotANDROID left, XrSceneMeshSnapshotANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrSceneMeshSnapshotANDROID left, XrSceneMeshSnapshotANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrSceneMeshSnapshotANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSceneMeshSnapshotANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSceneMeshSnapshotANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSceneMeshSnapshotANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFaceTrackerFB : IEquatable<XrFaceTrackerFB>
	{
		public readonly IntPtr Handle;
		public XrFaceTrackerFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFaceTrackerFB Null => new XrFaceTrackerFB(IntPtr.Zero);
		public static implicit operator XrFaceTrackerFB(IntPtr handle) => new XrFaceTrackerFB(handle);
		public static bool operator ==(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrFaceTrackerFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFaceTrackerFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFaceTrackerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFaceTrackerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFaceTracker2FB : IEquatable<XrFaceTracker2FB>
	{
		public readonly IntPtr Handle;
		public XrFaceTracker2FB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFaceTracker2FB Null => new XrFaceTracker2FB(IntPtr.Zero);
		public static implicit operator XrFaceTracker2FB(IntPtr handle) => new XrFaceTracker2FB(handle);
		public static bool operator ==(XrFaceTracker2FB left, XrFaceTracker2FB right) => left.Handle == right.Handle;
		public static bool operator !=(XrFaceTracker2FB left, XrFaceTracker2FB right) => left.Handle != right.Handle;
		public static bool operator ==(XrFaceTracker2FB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFaceTracker2FB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFaceTracker2FB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFaceTracker2FB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrBodyTrackerFB : IEquatable<XrBodyTrackerFB>
	{
		public readonly IntPtr Handle;
		public XrBodyTrackerFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrBodyTrackerFB Null => new XrBodyTrackerFB(IntPtr.Zero);
		public static implicit operator XrBodyTrackerFB(IntPtr handle) => new XrBodyTrackerFB(handle);
		public static bool operator ==(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrBodyTrackerFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrBodyTrackerFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrBodyTrackerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrBodyTrackerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrEyeTrackerFB : IEquatable<XrEyeTrackerFB>
	{
		public readonly IntPtr Handle;
		public XrEyeTrackerFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrEyeTrackerFB Null => new XrEyeTrackerFB(IntPtr.Zero);
		public static implicit operator XrEyeTrackerFB(IntPtr handle) => new XrEyeTrackerFB(handle);
		public static bool operator ==(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrEyeTrackerFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrEyeTrackerFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrEyeTrackerFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEyeTrackerFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpaceUserFB : IEquatable<XrSpaceUserFB>
	{
		public readonly IntPtr Handle;
		public XrSpaceUserFB(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpaceUserFB Null => new XrSpaceUserFB(IntPtr.Zero);
		public static implicit operator XrSpaceUserFB(IntPtr handle) => new XrSpaceUserFB(handle);
		public static bool operator ==(XrSpaceUserFB left, XrSpaceUserFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpaceUserFB left, XrSpaceUserFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpaceUserFB left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpaceUserFB left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpaceUserFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpaceUserFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPassthroughColorLutMETA : IEquatable<XrPassthroughColorLutMETA>
	{
		public readonly IntPtr Handle;
		public XrPassthroughColorLutMETA(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrPassthroughColorLutMETA Null => new XrPassthroughColorLutMETA(IntPtr.Zero);
		public static implicit operator XrPassthroughColorLutMETA(IntPtr handle) => new XrPassthroughColorLutMETA(handle);
		public static bool operator ==(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrPassthroughColorLutMETA left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrPassthroughColorLutMETA left, IntPtr right) => left.Handle != right;
		public bool Equals(XrPassthroughColorLutMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPassthroughColorLutMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPlaneDetectorEXT : IEquatable<XrPlaneDetectorEXT>
	{
		public readonly IntPtr Handle;
		public XrPlaneDetectorEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrPlaneDetectorEXT Null => new XrPlaneDetectorEXT(IntPtr.Zero);
		public static implicit operator XrPlaneDetectorEXT(IntPtr handle) => new XrPlaneDetectorEXT(handle);
		public static bool operator ==(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrPlaneDetectorEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrPlaneDetectorEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrPlaneDetectorEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPlaneDetectorEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrVirtualKeyboardMETA : IEquatable<XrVirtualKeyboardMETA>
	{
		public readonly IntPtr Handle;
		public XrVirtualKeyboardMETA(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrVirtualKeyboardMETA Null => new XrVirtualKeyboardMETA(IntPtr.Zero);
		public static implicit operator XrVirtualKeyboardMETA(IntPtr handle) => new XrVirtualKeyboardMETA(handle);
		public static bool operator ==(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrVirtualKeyboardMETA left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrVirtualKeyboardMETA left, IntPtr right) => left.Handle != right;
		public bool Equals(XrVirtualKeyboardMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrVirtualKeyboardMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialAnchorsStorageML : IEquatable<XrSpatialAnchorsStorageML>
	{
		public readonly IntPtr Handle;
		public XrSpatialAnchorsStorageML(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialAnchorsStorageML Null => new XrSpatialAnchorsStorageML(IntPtr.Zero);
		public static implicit operator XrSpatialAnchorsStorageML(IntPtr handle) => new XrSpatialAnchorsStorageML(handle);
		public static bool operator ==(XrSpatialAnchorsStorageML left, XrSpatialAnchorsStorageML right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAnchorsStorageML left, XrSpatialAnchorsStorageML right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAnchorsStorageML left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialAnchorsStorageML left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialAnchorsStorageML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAnchorsStorageML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrExportedLocalizationMapML : IEquatable<XrExportedLocalizationMapML>
	{
		public readonly IntPtr Handle;
		public XrExportedLocalizationMapML(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrExportedLocalizationMapML Null => new XrExportedLocalizationMapML(IntPtr.Zero);
		public static implicit operator XrExportedLocalizationMapML(IntPtr handle) => new XrExportedLocalizationMapML(handle);
		public static bool operator ==(XrExportedLocalizationMapML left, XrExportedLocalizationMapML right) => left.Handle == right.Handle;
		public static bool operator !=(XrExportedLocalizationMapML left, XrExportedLocalizationMapML right) => left.Handle != right.Handle;
		public static bool operator ==(XrExportedLocalizationMapML left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrExportedLocalizationMapML left, IntPtr right) => left.Handle != right;
		public bool Equals(XrExportedLocalizationMapML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrExportedLocalizationMapML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrMarkerDetectorML : IEquatable<XrMarkerDetectorML>
	{
		public readonly IntPtr Handle;
		public XrMarkerDetectorML(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrMarkerDetectorML Null => new XrMarkerDetectorML(IntPtr.Zero);
		public static implicit operator XrMarkerDetectorML(IntPtr handle) => new XrMarkerDetectorML(handle);
		public static bool operator ==(XrMarkerDetectorML left, XrMarkerDetectorML right) => left.Handle == right.Handle;
		public static bool operator !=(XrMarkerDetectorML left, XrMarkerDetectorML right) => left.Handle != right.Handle;
		public static bool operator ==(XrMarkerDetectorML left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrMarkerDetectorML left, IntPtr right) => left.Handle != right;
		public bool Equals(XrMarkerDetectorML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrMarkerDetectorML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFacialExpressionClientML : IEquatable<XrFacialExpressionClientML>
	{
		public readonly IntPtr Handle;
		public XrFacialExpressionClientML(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFacialExpressionClientML Null => new XrFacialExpressionClientML(IntPtr.Zero);
		public static implicit operator XrFacialExpressionClientML(IntPtr handle) => new XrFacialExpressionClientML(handle);
		public static bool operator ==(XrFacialExpressionClientML left, XrFacialExpressionClientML right) => left.Handle == right.Handle;
		public static bool operator !=(XrFacialExpressionClientML left, XrFacialExpressionClientML right) => left.Handle != right.Handle;
		public static bool operator ==(XrFacialExpressionClientML left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFacialExpressionClientML left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFacialExpressionClientML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFacialExpressionClientML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrEnvironmentDepthProviderMETA : IEquatable<XrEnvironmentDepthProviderMETA>
	{
		public readonly IntPtr Handle;
		public XrEnvironmentDepthProviderMETA(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrEnvironmentDepthProviderMETA Null => new XrEnvironmentDepthProviderMETA(IntPtr.Zero);
		public static implicit operator XrEnvironmentDepthProviderMETA(IntPtr handle) => new XrEnvironmentDepthProviderMETA(handle);
		public static bool operator ==(XrEnvironmentDepthProviderMETA left, XrEnvironmentDepthProviderMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrEnvironmentDepthProviderMETA left, XrEnvironmentDepthProviderMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrEnvironmentDepthProviderMETA left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrEnvironmentDepthProviderMETA left, IntPtr right) => left.Handle != right;
		public bool Equals(XrEnvironmentDepthProviderMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEnvironmentDepthProviderMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrEnvironmentDepthSwapchainMETA : IEquatable<XrEnvironmentDepthSwapchainMETA>
	{
		public readonly IntPtr Handle;
		public XrEnvironmentDepthSwapchainMETA(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrEnvironmentDepthSwapchainMETA Null => new XrEnvironmentDepthSwapchainMETA(IntPtr.Zero);
		public static implicit operator XrEnvironmentDepthSwapchainMETA(IntPtr handle) => new XrEnvironmentDepthSwapchainMETA(handle);
		public static bool operator ==(XrEnvironmentDepthSwapchainMETA left, XrEnvironmentDepthSwapchainMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrEnvironmentDepthSwapchainMETA left, XrEnvironmentDepthSwapchainMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrEnvironmentDepthSwapchainMETA left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrEnvironmentDepthSwapchainMETA left, IntPtr right) => left.Handle != right;
		public bool Equals(XrEnvironmentDepthSwapchainMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEnvironmentDepthSwapchainMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialContextEXT : IEquatable<XrSpatialContextEXT>
	{
		public readonly IntPtr Handle;
		public XrSpatialContextEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialContextEXT Null => new XrSpatialContextEXT(IntPtr.Zero);
		public static implicit operator XrSpatialContextEXT(IntPtr handle) => new XrSpatialContextEXT(handle);
		public static bool operator ==(XrSpatialContextEXT left, XrSpatialContextEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialContextEXT left, XrSpatialContextEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialContextEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialContextEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialContextEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialContextEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialEntityEXT : IEquatable<XrSpatialEntityEXT>
	{
		public readonly IntPtr Handle;
		public XrSpatialEntityEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialEntityEXT Null => new XrSpatialEntityEXT(IntPtr.Zero);
		public static implicit operator XrSpatialEntityEXT(IntPtr handle) => new XrSpatialEntityEXT(handle);
		public static bool operator ==(XrSpatialEntityEXT left, XrSpatialEntityEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialEntityEXT left, XrSpatialEntityEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialEntityEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialEntityEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialEntityEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialEntityEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialSnapshotEXT : IEquatable<XrSpatialSnapshotEXT>
	{
		public readonly IntPtr Handle;
		public XrSpatialSnapshotEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialSnapshotEXT Null => new XrSpatialSnapshotEXT(IntPtr.Zero);
		public static implicit operator XrSpatialSnapshotEXT(IntPtr handle) => new XrSpatialSnapshotEXT(handle);
		public static bool operator ==(XrSpatialSnapshotEXT left, XrSpatialSnapshotEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialSnapshotEXT left, XrSpatialSnapshotEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialSnapshotEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialSnapshotEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialSnapshotEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialSnapshotEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialPersistenceContextEXT : IEquatable<XrSpatialPersistenceContextEXT>
	{
		public readonly IntPtr Handle;
		public XrSpatialPersistenceContextEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialPersistenceContextEXT Null => new XrSpatialPersistenceContextEXT(IntPtr.Zero);
		public static implicit operator XrSpatialPersistenceContextEXT(IntPtr handle) => new XrSpatialPersistenceContextEXT(handle);
		public static bool operator ==(XrSpatialPersistenceContextEXT left, XrSpatialPersistenceContextEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialPersistenceContextEXT left, XrSpatialPersistenceContextEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialPersistenceContextEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialPersistenceContextEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialPersistenceContextEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialPersistenceContextEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrBodyTrackerHTC : IEquatable<XrBodyTrackerHTC>
	{
		public readonly IntPtr Handle;
		public XrBodyTrackerHTC(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrBodyTrackerHTC Null => new XrBodyTrackerHTC(IntPtr.Zero);
		public static implicit operator XrBodyTrackerHTC(IntPtr handle) => new XrBodyTrackerHTC(handle);
		public static bool operator ==(XrBodyTrackerHTC left, XrBodyTrackerHTC right) => left.Handle == right.Handle;
		public static bool operator !=(XrBodyTrackerHTC left, XrBodyTrackerHTC right) => left.Handle != right.Handle;
		public static bool operator ==(XrBodyTrackerHTC left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrBodyTrackerHTC left, IntPtr right) => left.Handle != right;
		public bool Equals(XrBodyTrackerHTC h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrBodyTrackerHTC h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrWorldMeshDetectorML : IEquatable<XrWorldMeshDetectorML>
	{
		public readonly IntPtr Handle;
		public XrWorldMeshDetectorML(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrWorldMeshDetectorML Null => new XrWorldMeshDetectorML(IntPtr.Zero);
		public static implicit operator XrWorldMeshDetectorML(IntPtr handle) => new XrWorldMeshDetectorML(handle);
		public static bool operator ==(XrWorldMeshDetectorML left, XrWorldMeshDetectorML right) => left.Handle == right.Handle;
		public static bool operator !=(XrWorldMeshDetectorML left, XrWorldMeshDetectorML right) => left.Handle != right.Handle;
		public static bool operator ==(XrWorldMeshDetectorML left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrWorldMeshDetectorML left, IntPtr right) => left.Handle != right;
		public bool Equals(XrWorldMeshDetectorML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrWorldMeshDetectorML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialAudioRendererBD : IEquatable<XrSpatialAudioRendererBD>
	{
		public readonly IntPtr Handle;
		public XrSpatialAudioRendererBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialAudioRendererBD Null => new XrSpatialAudioRendererBD(IntPtr.Zero);
		public static implicit operator XrSpatialAudioRendererBD(IntPtr handle) => new XrSpatialAudioRendererBD(handle);
		public static bool operator ==(XrSpatialAudioRendererBD left, XrSpatialAudioRendererBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAudioRendererBD left, XrSpatialAudioRendererBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAudioRendererBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialAudioRendererBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialAudioRendererBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAudioRendererBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSoundFieldBD : IEquatable<XrSoundFieldBD>
	{
		public readonly IntPtr Handle;
		public XrSoundFieldBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSoundFieldBD Null => new XrSoundFieldBD(IntPtr.Zero);
		public static implicit operator XrSoundFieldBD(IntPtr handle) => new XrSoundFieldBD(handle);
		public static bool operator ==(XrSoundFieldBD left, XrSoundFieldBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSoundFieldBD left, XrSoundFieldBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSoundFieldBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSoundFieldBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSoundFieldBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSoundFieldBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSoundObjectBD : IEquatable<XrSoundObjectBD>
	{
		public readonly IntPtr Handle;
		public XrSoundObjectBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSoundObjectBD Null => new XrSoundObjectBD(IntPtr.Zero);
		public static implicit operator XrSoundObjectBD(IntPtr handle) => new XrSoundObjectBD(handle);
		public static bool operator ==(XrSoundObjectBD left, XrSoundObjectBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSoundObjectBD left, XrSoundObjectBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSoundObjectBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSoundObjectBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSoundObjectBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSoundObjectBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSoundObstacleBD : IEquatable<XrSoundObstacleBD>
	{
		public readonly IntPtr Handle;
		public XrSoundObstacleBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSoundObstacleBD Null => new XrSoundObstacleBD(IntPtr.Zero);
		public static implicit operator XrSoundObstacleBD(IntPtr handle) => new XrSoundObstacleBD(handle);
		public static bool operator ==(XrSoundObstacleBD left, XrSoundObstacleBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSoundObstacleBD left, XrSoundObstacleBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSoundObstacleBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSoundObstacleBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSoundObstacleBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSoundObstacleBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSoundObstacleMaterialBD : IEquatable<XrSoundObstacleMaterialBD>
	{
		public readonly IntPtr Handle;
		public XrSoundObstacleMaterialBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSoundObstacleMaterialBD Null => new XrSoundObstacleMaterialBD(IntPtr.Zero);
		public static implicit operator XrSoundObstacleMaterialBD(IntPtr handle) => new XrSoundObstacleMaterialBD(handle);
		public static bool operator ==(XrSoundObstacleMaterialBD left, XrSoundObstacleMaterialBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSoundObstacleMaterialBD left, XrSoundObstacleMaterialBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSoundObstacleMaterialBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSoundObstacleMaterialBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSoundObstacleMaterialBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSoundObstacleMaterialBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrBodyTrackerBD : IEquatable<XrBodyTrackerBD>
	{
		public readonly IntPtr Handle;
		public XrBodyTrackerBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrBodyTrackerBD Null => new XrBodyTrackerBD(IntPtr.Zero);
		public static implicit operator XrBodyTrackerBD(IntPtr handle) => new XrBodyTrackerBD(handle);
		public static bool operator ==(XrBodyTrackerBD left, XrBodyTrackerBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrBodyTrackerBD left, XrBodyTrackerBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrBodyTrackerBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrBodyTrackerBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrBodyTrackerBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrBodyTrackerBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrRenderModelEXT : IEquatable<XrRenderModelEXT>
	{
		public readonly IntPtr Handle;
		public XrRenderModelEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrRenderModelEXT Null => new XrRenderModelEXT(IntPtr.Zero);
		public static implicit operator XrRenderModelEXT(IntPtr handle) => new XrRenderModelEXT(handle);
		public static bool operator ==(XrRenderModelEXT left, XrRenderModelEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrRenderModelEXT left, XrRenderModelEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrRenderModelEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrRenderModelEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrRenderModelEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrRenderModelEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrRenderModelAssetEXT : IEquatable<XrRenderModelAssetEXT>
	{
		public readonly IntPtr Handle;
		public XrRenderModelAssetEXT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrRenderModelAssetEXT Null => new XrRenderModelAssetEXT(IntPtr.Zero);
		public static implicit operator XrRenderModelAssetEXT(IntPtr handle) => new XrRenderModelAssetEXT(handle);
		public static bool operator ==(XrRenderModelAssetEXT left, XrRenderModelAssetEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrRenderModelAssetEXT left, XrRenderModelAssetEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrRenderModelAssetEXT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrRenderModelAssetEXT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrRenderModelAssetEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrRenderModelAssetEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSenseDataProviderBD : IEquatable<XrSenseDataProviderBD>
	{
		public readonly IntPtr Handle;
		public XrSenseDataProviderBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSenseDataProviderBD Null => new XrSenseDataProviderBD(IntPtr.Zero);
		public static implicit operator XrSenseDataProviderBD(IntPtr handle) => new XrSenseDataProviderBD(handle);
		public static bool operator ==(XrSenseDataProviderBD left, XrSenseDataProviderBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSenseDataProviderBD left, XrSenseDataProviderBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSenseDataProviderBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSenseDataProviderBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSenseDataProviderBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSenseDataProviderBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSenseDataSnapshotBD : IEquatable<XrSenseDataSnapshotBD>
	{
		public readonly IntPtr Handle;
		public XrSenseDataSnapshotBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSenseDataSnapshotBD Null => new XrSenseDataSnapshotBD(IntPtr.Zero);
		public static implicit operator XrSenseDataSnapshotBD(IntPtr handle) => new XrSenseDataSnapshotBD(handle);
		public static bool operator ==(XrSenseDataSnapshotBD left, XrSenseDataSnapshotBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSenseDataSnapshotBD left, XrSenseDataSnapshotBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSenseDataSnapshotBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSenseDataSnapshotBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSenseDataSnapshotBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSenseDataSnapshotBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrAnchorBD : IEquatable<XrAnchorBD>
	{
		public readonly IntPtr Handle;
		public XrAnchorBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrAnchorBD Null => new XrAnchorBD(IntPtr.Zero);
		public static implicit operator XrAnchorBD(IntPtr handle) => new XrAnchorBD(handle);
		public static bool operator ==(XrAnchorBD left, XrAnchorBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrAnchorBD left, XrAnchorBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrAnchorBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrAnchorBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrAnchorBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrAnchorBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrFaceTrackerBD : IEquatable<XrFaceTrackerBD>
	{
		public readonly IntPtr Handle;
		public XrFaceTrackerBD(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrFaceTrackerBD Null => new XrFaceTrackerBD(IntPtr.Zero);
		public static implicit operator XrFaceTrackerBD(IntPtr handle) => new XrFaceTrackerBD(handle);
		public static bool operator ==(XrFaceTrackerBD left, XrFaceTrackerBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrFaceTrackerBD left, XrFaceTrackerBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrFaceTrackerBD left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrFaceTrackerBD left, IntPtr right) => left.Handle != right;
		public bool Equals(XrFaceTrackerBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrFaceTrackerBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrEnvironmentRaycasterMETA : IEquatable<XrEnvironmentRaycasterMETA>
	{
		public readonly IntPtr Handle;
		public XrEnvironmentRaycasterMETA(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrEnvironmentRaycasterMETA Null => new XrEnvironmentRaycasterMETA(IntPtr.Zero);
		public static implicit operator XrEnvironmentRaycasterMETA(IntPtr handle) => new XrEnvironmentRaycasterMETA(handle);
		public static bool operator ==(XrEnvironmentRaycasterMETA left, XrEnvironmentRaycasterMETA right) => left.Handle == right.Handle;
		public static bool operator !=(XrEnvironmentRaycasterMETA left, XrEnvironmentRaycasterMETA right) => left.Handle != right.Handle;
		public static bool operator ==(XrEnvironmentRaycasterMETA left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrEnvironmentRaycasterMETA left, IntPtr right) => left.Handle != right;
		public bool Equals(XrEnvironmentRaycasterMETA h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrEnvironmentRaycasterMETA h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialGraphNodeBindingMSFT : IEquatable<XrSpatialGraphNodeBindingMSFT>
	{
		public readonly IntPtr Handle;
		public XrSpatialGraphNodeBindingMSFT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialGraphNodeBindingMSFT Null => new XrSpatialGraphNodeBindingMSFT(IntPtr.Zero);
		public static implicit operator XrSpatialGraphNodeBindingMSFT(IntPtr handle) => new XrSpatialGraphNodeBindingMSFT(handle);
		public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialGraphNodeBindingMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialGraphNodeBindingMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSceneObserverMSFT : IEquatable<XrSceneObserverMSFT>
	{
		public readonly IntPtr Handle;
		public XrSceneObserverMSFT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSceneObserverMSFT Null => new XrSceneObserverMSFT(IntPtr.Zero);
		public static implicit operator XrSceneObserverMSFT(IntPtr handle) => new XrSceneObserverMSFT(handle);
		public static bool operator ==(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSceneObserverMSFT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSceneObserverMSFT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSceneObserverMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSceneObserverMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSceneMSFT : IEquatable<XrSceneMSFT>
	{
		public readonly IntPtr Handle;
		public XrSceneMSFT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSceneMSFT Null => new XrSceneMSFT(IntPtr.Zero);
		public static implicit operator XrSceneMSFT(IntPtr handle) => new XrSceneMSFT(handle);
		public static bool operator ==(XrSceneMSFT left, XrSceneMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSceneMSFT left, XrSceneMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSceneMSFT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSceneMSFT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSceneMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSceneMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialAnchorStoreConnectionMSFT : IEquatable<XrSpatialAnchorStoreConnectionMSFT>
	{
		public readonly IntPtr Handle;
		public XrSpatialAnchorStoreConnectionMSFT(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrSpatialAnchorStoreConnectionMSFT Null => new XrSpatialAnchorStoreConnectionMSFT(IntPtr.Zero);
		public static implicit operator XrSpatialAnchorStoreConnectionMSFT(IntPtr handle) => new XrSpatialAnchorStoreConnectionMSFT(handle);
		public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, IntPtr right) => left.Handle != right;
		public bool Equals(XrSpatialAnchorStoreConnectionMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialAnchorStoreConnectionMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrTrackableImageDatabaseANDROID : IEquatable<XrTrackableImageDatabaseANDROID>
	{
		public readonly IntPtr Handle;
		public XrTrackableImageDatabaseANDROID(IntPtr existingHandle) { Handle = existingHandle; }
		public static XrTrackableImageDatabaseANDROID Null => new XrTrackableImageDatabaseANDROID(IntPtr.Zero);
		public static implicit operator XrTrackableImageDatabaseANDROID(IntPtr handle) => new XrTrackableImageDatabaseANDROID(handle);
		public static bool operator ==(XrTrackableImageDatabaseANDROID left, XrTrackableImageDatabaseANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrTrackableImageDatabaseANDROID left, XrTrackableImageDatabaseANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrTrackableImageDatabaseANDROID left, IntPtr right) => left.Handle == right;
		public static bool operator !=(XrTrackableImageDatabaseANDROID left, IntPtr right) => left.Handle != right;
		public bool Equals(XrTrackableImageDatabaseANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrTrackableImageDatabaseANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrPath : IEquatable<XrPath>
	{
		public readonly ulong Handle;
		public XrPath(ulong existingHandle) { Handle = existingHandle; }
		public static XrPath Null => new XrPath(0);
		public static implicit operator XrPath(ulong handle) => new XrPath(handle);
		public static bool operator ==(XrPath left, XrPath right) => left.Handle == right.Handle;
		public static bool operator !=(XrPath left, XrPath right) => left.Handle != right.Handle;
		public static bool operator ==(XrPath left, ulong right) => left.Handle == right;
		public static bool operator !=(XrPath left, ulong right) => left.Handle != right;
		public bool Equals(XrPath h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrPath h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSystemId : IEquatable<XrSystemId>
	{
		public readonly ulong Handle;
		public XrSystemId(ulong existingHandle) { Handle = existingHandle; }
		public static XrSystemId Null => new XrSystemId(0);
		public static implicit operator XrSystemId(ulong handle) => new XrSystemId(handle);
		public static bool operator ==(XrSystemId left, XrSystemId right) => left.Handle == right.Handle;
		public static bool operator !=(XrSystemId left, XrSystemId right) => left.Handle != right.Handle;
		public static bool operator ==(XrSystemId left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSystemId left, ulong right) => left.Handle != right;
		public bool Equals(XrSystemId h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSystemId h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrControllerModelKeyMSFT : IEquatable<XrControllerModelKeyMSFT>
	{
		public readonly ulong Handle;
		public XrControllerModelKeyMSFT(ulong existingHandle) { Handle = existingHandle; }
		public static XrControllerModelKeyMSFT Null => new XrControllerModelKeyMSFT(0);
		public static implicit operator XrControllerModelKeyMSFT(ulong handle) => new XrControllerModelKeyMSFT(handle);
		public static bool operator ==(XrControllerModelKeyMSFT left, XrControllerModelKeyMSFT right) => left.Handle == right.Handle;
		public static bool operator !=(XrControllerModelKeyMSFT left, XrControllerModelKeyMSFT right) => left.Handle != right.Handle;
		public static bool operator ==(XrControllerModelKeyMSFT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrControllerModelKeyMSFT left, ulong right) => left.Handle != right;
		public bool Equals(XrControllerModelKeyMSFT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrControllerModelKeyMSFT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrAsyncRequestIdFB : IEquatable<XrAsyncRequestIdFB>
	{
		public readonly ulong Handle;
		public XrAsyncRequestIdFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrAsyncRequestIdFB Null => new XrAsyncRequestIdFB(0);
		public static implicit operator XrAsyncRequestIdFB(ulong handle) => new XrAsyncRequestIdFB(handle);
		public static bool operator ==(XrAsyncRequestIdFB left, XrAsyncRequestIdFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrAsyncRequestIdFB left, XrAsyncRequestIdFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrAsyncRequestIdFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrAsyncRequestIdFB left, ulong right) => left.Handle != right;
		public bool Equals(XrAsyncRequestIdFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrAsyncRequestIdFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrRenderModelKeyFB : IEquatable<XrRenderModelKeyFB>
	{
		public readonly ulong Handle;
		public XrRenderModelKeyFB(ulong existingHandle) { Handle = existingHandle; }
		public static XrRenderModelKeyFB Null => new XrRenderModelKeyFB(0);
		public static implicit operator XrRenderModelKeyFB(ulong handle) => new XrRenderModelKeyFB(handle);
		public static bool operator ==(XrRenderModelKeyFB left, XrRenderModelKeyFB right) => left.Handle == right.Handle;
		public static bool operator !=(XrRenderModelKeyFB left, XrRenderModelKeyFB right) => left.Handle != right.Handle;
		public static bool operator ==(XrRenderModelKeyFB left, ulong right) => left.Handle == right;
		public static bool operator !=(XrRenderModelKeyFB left, ulong right) => left.Handle != right;
		public bool Equals(XrRenderModelKeyFB h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrRenderModelKeyFB h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrTrackableANDROID : IEquatable<XrTrackableANDROID>
	{
		public readonly ulong Handle;
		public XrTrackableANDROID(ulong existingHandle) { Handle = existingHandle; }
		public static XrTrackableANDROID Null => new XrTrackableANDROID(0);
		public static implicit operator XrTrackableANDROID(ulong handle) => new XrTrackableANDROID(handle);
		public static bool operator ==(XrTrackableANDROID left, XrTrackableANDROID right) => left.Handle == right.Handle;
		public static bool operator !=(XrTrackableANDROID left, XrTrackableANDROID right) => left.Handle != right.Handle;
		public static bool operator ==(XrTrackableANDROID left, ulong right) => left.Handle == right;
		public static bool operator !=(XrTrackableANDROID left, ulong right) => left.Handle != right;
		public bool Equals(XrTrackableANDROID h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrTrackableANDROID h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrMarkerML : IEquatable<XrMarkerML>
	{
		public readonly ulong Handle;
		public XrMarkerML(ulong existingHandle) { Handle = existingHandle; }
		public static XrMarkerML Null => new XrMarkerML(0);
		public static implicit operator XrMarkerML(ulong handle) => new XrMarkerML(handle);
		public static bool operator ==(XrMarkerML left, XrMarkerML right) => left.Handle == right.Handle;
		public static bool operator !=(XrMarkerML left, XrMarkerML right) => left.Handle != right.Handle;
		public static bool operator ==(XrMarkerML left, ulong right) => left.Handle == right;
		public static bool operator !=(XrMarkerML left, ulong right) => left.Handle != right;
		public bool Equals(XrMarkerML h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrMarkerML h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrRenderModelIdEXT : IEquatable<XrRenderModelIdEXT>
	{
		public readonly ulong Handle;
		public XrRenderModelIdEXT(ulong existingHandle) { Handle = existingHandle; }
		public static XrRenderModelIdEXT Null => new XrRenderModelIdEXT(0);
		public static implicit operator XrRenderModelIdEXT(ulong handle) => new XrRenderModelIdEXT(handle);
		public static bool operator ==(XrRenderModelIdEXT left, XrRenderModelIdEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrRenderModelIdEXT left, XrRenderModelIdEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrRenderModelIdEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrRenderModelIdEXT left, ulong right) => left.Handle != right;
		public bool Equals(XrRenderModelIdEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrRenderModelIdEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialEntityIdEXT : IEquatable<XrSpatialEntityIdEXT>
	{
		public readonly ulong Handle;
		public XrSpatialEntityIdEXT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialEntityIdEXT Null => new XrSpatialEntityIdEXT(0);
		public static implicit operator XrSpatialEntityIdEXT(ulong handle) => new XrSpatialEntityIdEXT(handle);
		public static bool operator ==(XrSpatialEntityIdEXT left, XrSpatialEntityIdEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialEntityIdEXT left, XrSpatialEntityIdEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialEntityIdEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialEntityIdEXT left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialEntityIdEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialEntityIdEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialBufferIdEXT : IEquatable<XrSpatialBufferIdEXT>
	{
		public readonly ulong Handle;
		public XrSpatialBufferIdEXT(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialBufferIdEXT Null => new XrSpatialBufferIdEXT(0);
		public static implicit operator XrSpatialBufferIdEXT(ulong handle) => new XrSpatialBufferIdEXT(handle);
		public static bool operator ==(XrSpatialBufferIdEXT left, XrSpatialBufferIdEXT right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialBufferIdEXT left, XrSpatialBufferIdEXT right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialBufferIdEXT left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialBufferIdEXT left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialBufferIdEXT h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialBufferIdEXT h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

	public partial struct XrSpatialEntityIdBD : IEquatable<XrSpatialEntityIdBD>
	{
		public readonly ulong Handle;
		public XrSpatialEntityIdBD(ulong existingHandle) { Handle = existingHandle; }
		public static XrSpatialEntityIdBD Null => new XrSpatialEntityIdBD(0);
		public static implicit operator XrSpatialEntityIdBD(ulong handle) => new XrSpatialEntityIdBD(handle);
		public static bool operator ==(XrSpatialEntityIdBD left, XrSpatialEntityIdBD right) => left.Handle == right.Handle;
		public static bool operator !=(XrSpatialEntityIdBD left, XrSpatialEntityIdBD right) => left.Handle != right.Handle;
		public static bool operator ==(XrSpatialEntityIdBD left, ulong right) => left.Handle == right;
		public static bool operator !=(XrSpatialEntityIdBD left, ulong right) => left.Handle != right;
		public bool Equals(XrSpatialEntityIdBD h) => Handle == h.Handle;
		public override bool Equals(object o) => o is XrSpatialEntityIdBD h && Equals(h);
		public override int GetHashCode() => Handle.GetHashCode();
	}

}
