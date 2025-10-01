using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.OpenXR
{
	public static unsafe partial class OpenXRNative
	{
		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetInstanceProcAddrDelegate(XrInstance instance, byte* name, IntPtr function);
		private static xrGetInstanceProcAddrDelegate xrGetInstanceProcAddr_ptr;
		public static XrResult xrGetInstanceProcAddr(XrInstance instance, byte* name, IntPtr function)
			=> xrGetInstanceProcAddr_ptr(instance, name, function);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateApiLayerPropertiesDelegate(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties);
		private static xrEnumerateApiLayerPropertiesDelegate xrEnumerateApiLayerProperties_ptr;
		public static XrResult xrEnumerateApiLayerProperties(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties)
			=> xrEnumerateApiLayerProperties_ptr(propertyCapacityInput, propertyCountOutput, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateInstanceExtensionPropertiesDelegate(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties);
		private static xrEnumerateInstanceExtensionPropertiesDelegate xrEnumerateInstanceExtensionProperties_ptr;
		public static XrResult xrEnumerateInstanceExtensionProperties(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties)
			=> xrEnumerateInstanceExtensionProperties_ptr(layerName, propertyCapacityInput, propertyCountOutput, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateInstanceDelegate(XrInstanceCreateInfo* createInfo, XrInstance* instance);
		private static xrCreateInstanceDelegate xrCreateInstance_ptr;
		public static XrResult xrCreateInstance(XrInstanceCreateInfo* createInfo, XrInstance* instance)
			=> xrCreateInstance_ptr(createInfo, instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyInstanceDelegate(XrInstance instance);
		private static xrDestroyInstanceDelegate xrDestroyInstance_ptr;
		public static XrResult xrDestroyInstance(XrInstance instance)
			=> xrDestroyInstance_ptr(instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetInstancePropertiesDelegate(XrInstance instance, XrInstanceProperties* instanceProperties);
		private static xrGetInstancePropertiesDelegate xrGetInstanceProperties_ptr;
		public static XrResult xrGetInstanceProperties(XrInstance instance, XrInstanceProperties* instanceProperties)
			=> xrGetInstanceProperties_ptr(instance, instanceProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPollEventDelegate(XrInstance instance, XrEventDataBuffer* eventData);
		private static xrPollEventDelegate xrPollEvent_ptr;
		public static XrResult xrPollEvent(XrInstance instance, XrEventDataBuffer* eventData)
			=> xrPollEvent_ptr(instance, eventData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrResultToStringDelegate(XrInstance instance, XrResult value, byte buffer);
		private static xrResultToStringDelegate xrResultToString_ptr;
		public static XrResult xrResultToString(XrInstance instance, XrResult value, byte buffer)
			=> xrResultToString_ptr(instance, value, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStructureTypeToStringDelegate(XrInstance instance, XrStructureType value, byte buffer);
		private static xrStructureTypeToStringDelegate xrStructureTypeToString_ptr;
		public static XrResult xrStructureTypeToString(XrInstance instance, XrStructureType value, byte buffer)
			=> xrStructureTypeToString_ptr(instance, value, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSystemDelegate(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId);
		private static xrGetSystemDelegate xrGetSystem_ptr;
		public static XrResult xrGetSystem(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId)
			=> xrGetSystem_ptr(instance, getInfo, systemId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSystemPropertiesDelegate(XrInstance instance, ulong systemId, XrSystemProperties* properties);
		private static xrGetSystemPropertiesDelegate xrGetSystemProperties_ptr;
		public static XrResult xrGetSystemProperties(XrInstance instance, ulong systemId, XrSystemProperties* properties)
			=> xrGetSystemProperties_ptr(instance, systemId, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateEnvironmentBlendModesDelegate(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes);
		private static xrEnumerateEnvironmentBlendModesDelegate xrEnumerateEnvironmentBlendModes_ptr;
		public static XrResult xrEnumerateEnvironmentBlendModes(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes)
			=> xrEnumerateEnvironmentBlendModes_ptr(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, environmentBlendModeCountOutput, environmentBlendModes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSessionDelegate(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session);
		private static xrCreateSessionDelegate xrCreateSession_ptr;
		public static XrResult xrCreateSession(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session)
			=> xrCreateSession_ptr(instance, createInfo, session);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySessionDelegate(XrSession session);
		private static xrDestroySessionDelegate xrDestroySession_ptr;
		public static XrResult xrDestroySession(XrSession session)
			=> xrDestroySession_ptr(session);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateReferenceSpacesDelegate(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces);
		private static xrEnumerateReferenceSpacesDelegate xrEnumerateReferenceSpaces_ptr;
		public static XrResult xrEnumerateReferenceSpaces(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces)
			=> xrEnumerateReferenceSpaces_ptr(session, spaceCapacityInput, spaceCountOutput, spaces);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateReferenceSpaceDelegate(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space);
		private static xrCreateReferenceSpaceDelegate xrCreateReferenceSpace_ptr;
		public static XrResult xrCreateReferenceSpace(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space)
			=> xrCreateReferenceSpace_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetReferenceSpaceBoundsRectDelegate(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds);
		private static xrGetReferenceSpaceBoundsRectDelegate xrGetReferenceSpaceBoundsRect_ptr;
		public static XrResult xrGetReferenceSpaceBoundsRect(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds)
			=> xrGetReferenceSpaceBoundsRect_ptr(session, referenceSpaceType, bounds);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateActionSpaceDelegate(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space);
		private static xrCreateActionSpaceDelegate xrCreateActionSpace_ptr;
		public static XrResult xrCreateActionSpace(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space)
			=> xrCreateActionSpace_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateSpaceDelegate(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location);
		private static xrLocateSpaceDelegate xrLocateSpace_ptr;
		public static XrResult xrLocateSpace(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location)
			=> xrLocateSpace_ptr(space, baseSpace, time, location);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpaceDelegate(XrSpace space);
		private static xrDestroySpaceDelegate xrDestroySpace_ptr;
		public static XrResult xrDestroySpace(XrSpace space)
			=> xrDestroySpace_ptr(space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateViewConfigurationsDelegate(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes);
		private static xrEnumerateViewConfigurationsDelegate xrEnumerateViewConfigurations_ptr;
		public static XrResult xrEnumerateViewConfigurations(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes)
			=> xrEnumerateViewConfigurations_ptr(instance, systemId, viewConfigurationTypeCapacityInput, viewConfigurationTypeCountOutput, viewConfigurationTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetViewConfigurationPropertiesDelegate(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties);
		private static xrGetViewConfigurationPropertiesDelegate xrGetViewConfigurationProperties_ptr;
		public static XrResult xrGetViewConfigurationProperties(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties)
			=> xrGetViewConfigurationProperties_ptr(instance, systemId, viewConfigurationType, configurationProperties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateViewConfigurationViewsDelegate(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views);
		private static xrEnumerateViewConfigurationViewsDelegate xrEnumerateViewConfigurationViews_ptr;
		public static XrResult xrEnumerateViewConfigurationViews(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views)
			=> xrEnumerateViewConfigurationViews_ptr(instance, systemId, viewConfigurationType, viewCapacityInput, viewCountOutput, views);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSwapchainFormatsDelegate(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats);
		private static xrEnumerateSwapchainFormatsDelegate xrEnumerateSwapchainFormats_ptr;
		public static XrResult xrEnumerateSwapchainFormats(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats)
			=> xrEnumerateSwapchainFormats_ptr(session, formatCapacityInput, formatCountOutput, formats);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSwapchainDelegate(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain);
		private static xrCreateSwapchainDelegate xrCreateSwapchain_ptr;
		public static XrResult xrCreateSwapchain(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain)
			=> xrCreateSwapchain_ptr(session, createInfo, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySwapchainDelegate(XrSwapchain swapchain);
		private static xrDestroySwapchainDelegate xrDestroySwapchain_ptr;
		public static XrResult xrDestroySwapchain(XrSwapchain swapchain)
			=> xrDestroySwapchain_ptr(swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSwapchainImagesDelegate(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images);
		private static xrEnumerateSwapchainImagesDelegate xrEnumerateSwapchainImages_ptr;
		public static XrResult xrEnumerateSwapchainImages(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
			=> xrEnumerateSwapchainImages_ptr(swapchain, imageCapacityInput, imageCountOutput, images);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrAcquireSwapchainImageDelegate(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index);
		private static xrAcquireSwapchainImageDelegate xrAcquireSwapchainImage_ptr;
		public static XrResult xrAcquireSwapchainImage(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index)
			=> xrAcquireSwapchainImage_ptr(swapchain, acquireInfo, index);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrWaitSwapchainImageDelegate(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo);
		private static xrWaitSwapchainImageDelegate xrWaitSwapchainImage_ptr;
		public static XrResult xrWaitSwapchainImage(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo)
			=> xrWaitSwapchainImage_ptr(swapchain, waitInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrReleaseSwapchainImageDelegate(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo);
		private static xrReleaseSwapchainImageDelegate xrReleaseSwapchainImage_ptr;
		public static XrResult xrReleaseSwapchainImage(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo)
			=> xrReleaseSwapchainImage_ptr(swapchain, releaseInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrBeginSessionDelegate(XrSession session, XrSessionBeginInfo* beginInfo);
		private static xrBeginSessionDelegate xrBeginSession_ptr;
		public static XrResult xrBeginSession(XrSession session, XrSessionBeginInfo* beginInfo)
			=> xrBeginSession_ptr(session, beginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEndSessionDelegate(XrSession session);
		private static xrEndSessionDelegate xrEndSession_ptr;
		public static XrResult xrEndSession(XrSession session)
			=> xrEndSession_ptr(session);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestExitSessionDelegate(XrSession session);
		private static xrRequestExitSessionDelegate xrRequestExitSession_ptr;
		public static XrResult xrRequestExitSession(XrSession session)
			=> xrRequestExitSession_ptr(session);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrWaitFrameDelegate(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState);
		private static xrWaitFrameDelegate xrWaitFrame_ptr;
		public static XrResult xrWaitFrame(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState)
			=> xrWaitFrame_ptr(session, frameWaitInfo, frameState);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrBeginFrameDelegate(XrSession session, XrFrameBeginInfo* frameBeginInfo);
		private static xrBeginFrameDelegate xrBeginFrame_ptr;
		public static XrResult xrBeginFrame(XrSession session, XrFrameBeginInfo* frameBeginInfo)
			=> xrBeginFrame_ptr(session, frameBeginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEndFrameDelegate(XrSession session, XrFrameEndInfo* frameEndInfo);
		private static xrEndFrameDelegate xrEndFrame_ptr;
		public static XrResult xrEndFrame(XrSession session, XrFrameEndInfo* frameEndInfo)
			=> xrEndFrame_ptr(session, frameEndInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateViewsDelegate(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views);
		private static xrLocateViewsDelegate xrLocateViews_ptr;
		public static XrResult xrLocateViews(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views)
			=> xrLocateViews_ptr(session, viewLocateInfo, viewState, viewCapacityInput, viewCountOutput, views);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStringToPathDelegate(XrInstance instance, byte* pathString, ulong* path);
		private static xrStringToPathDelegate xrStringToPath_ptr;
		public static XrResult xrStringToPath(XrInstance instance, byte* pathString, ulong* path)
			=> xrStringToPath_ptr(instance, pathString, path);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPathToStringDelegate(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrPathToStringDelegate xrPathToString_ptr;
		public static XrResult xrPathToString(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrPathToString_ptr(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateActionSetDelegate(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet);
		private static xrCreateActionSetDelegate xrCreateActionSet_ptr;
		public static XrResult xrCreateActionSet(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet)
			=> xrCreateActionSet_ptr(instance, createInfo, actionSet);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyActionSetDelegate(XrActionSet actionSet);
		private static xrDestroyActionSetDelegate xrDestroyActionSet_ptr;
		public static XrResult xrDestroyActionSet(XrActionSet actionSet)
			=> xrDestroyActionSet_ptr(actionSet);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateActionDelegate(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action);
		private static xrCreateActionDelegate xrCreateAction_ptr;
		public static XrResult xrCreateAction(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action)
			=> xrCreateAction_ptr(actionSet, createInfo, action);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyActionDelegate(XrAction action);
		private static xrDestroyActionDelegate xrDestroyAction_ptr;
		public static XrResult xrDestroyAction(XrAction action)
			=> xrDestroyAction_ptr(action);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSuggestInteractionProfileBindingsDelegate(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings);
		private static xrSuggestInteractionProfileBindingsDelegate xrSuggestInteractionProfileBindings_ptr;
		public static XrResult xrSuggestInteractionProfileBindings(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings)
			=> xrSuggestInteractionProfileBindings_ptr(instance, suggestedBindings);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrAttachSessionActionSetsDelegate(XrSession session, XrSessionActionSetsAttachInfo* attachInfo);
		private static xrAttachSessionActionSetsDelegate xrAttachSessionActionSets_ptr;
		public static XrResult xrAttachSessionActionSets(XrSession session, XrSessionActionSetsAttachInfo* attachInfo)
			=> xrAttachSessionActionSets_ptr(session, attachInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetCurrentInteractionProfileDelegate(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile);
		private static xrGetCurrentInteractionProfileDelegate xrGetCurrentInteractionProfile_ptr;
		public static XrResult xrGetCurrentInteractionProfile(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile)
			=> xrGetCurrentInteractionProfile_ptr(session, topLevelUserPath, interactionProfile);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetActionStateBooleanDelegate(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state);
		private static xrGetActionStateBooleanDelegate xrGetActionStateBoolean_ptr;
		public static XrResult xrGetActionStateBoolean(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state)
			=> xrGetActionStateBoolean_ptr(session, getInfo, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetActionStateFloatDelegate(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state);
		private static xrGetActionStateFloatDelegate xrGetActionStateFloat_ptr;
		public static XrResult xrGetActionStateFloat(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state)
			=> xrGetActionStateFloat_ptr(session, getInfo, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetActionStateVector2fDelegate(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state);
		private static xrGetActionStateVector2fDelegate xrGetActionStateVector2f_ptr;
		public static XrResult xrGetActionStateVector2f(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state)
			=> xrGetActionStateVector2f_ptr(session, getInfo, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetActionStatePoseDelegate(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state);
		private static xrGetActionStatePoseDelegate xrGetActionStatePose_ptr;
		public static XrResult xrGetActionStatePose(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state)
			=> xrGetActionStatePose_ptr(session, getInfo, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSyncActionsDelegate(XrSession session, XrActionsSyncInfo* syncInfo);
		private static xrSyncActionsDelegate xrSyncActions_ptr;
		public static XrResult xrSyncActions(XrSession session, XrActionsSyncInfo* syncInfo)
			=> xrSyncActions_ptr(session, syncInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateBoundSourcesForActionDelegate(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources);
		private static xrEnumerateBoundSourcesForActionDelegate xrEnumerateBoundSourcesForAction_ptr;
		public static XrResult xrEnumerateBoundSourcesForAction(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources)
			=> xrEnumerateBoundSourcesForAction_ptr(session, enumerateInfo, sourceCapacityInput, sourceCountOutput, sources);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetInputSourceLocalizedNameDelegate(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetInputSourceLocalizedNameDelegate xrGetInputSourceLocalizedName_ptr;
		public static XrResult xrGetInputSourceLocalizedName(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetInputSourceLocalizedName_ptr(session, getInfo, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrApplyHapticFeedbackDelegate(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback);
		private static xrApplyHapticFeedbackDelegate xrApplyHapticFeedback_ptr;
		public static XrResult xrApplyHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback)
			=> xrApplyHapticFeedback_ptr(session, hapticActionInfo, hapticFeedback);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStopHapticFeedbackDelegate(XrSession session, XrHapticActionInfo* hapticActionInfo);
		private static xrStopHapticFeedbackDelegate xrStopHapticFeedback_ptr;
		public static XrResult xrStopHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo)
			=> xrStopHapticFeedback_ptr(session, hapticActionInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateApiLayerInstanceDelegate(XrInstanceCreateInfo* info, XrApiLayerCreateInfo* layerInfo, XrInstance* instance);
		private static xrCreateApiLayerInstanceDelegate xrCreateApiLayerInstance_ptr;
		public static XrResult xrCreateApiLayerInstance(XrInstanceCreateInfo* info, XrApiLayerCreateInfo* layerInfo, XrInstance* instance)
			=> xrCreateApiLayerInstance_ptr(info, layerInfo, instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrNegotiateLoaderRuntimeInterfaceDelegate(XrNegotiateLoaderInfo* loaderInfo, XrNegotiateRuntimeRequest* runtimeRequest);
		private static xrNegotiateLoaderRuntimeInterfaceDelegate xrNegotiateLoaderRuntimeInterface_ptr;
		public static XrResult xrNegotiateLoaderRuntimeInterface(XrNegotiateLoaderInfo* loaderInfo, XrNegotiateRuntimeRequest* runtimeRequest)
			=> xrNegotiateLoaderRuntimeInterface_ptr(loaderInfo, runtimeRequest);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrNegotiateLoaderApiLayerInterfaceDelegate(XrNegotiateLoaderInfo* loaderInfo, byte* layerName, XrNegotiateApiLayerRequest* apiLayerRequest);
		private static xrNegotiateLoaderApiLayerInterfaceDelegate xrNegotiateLoaderApiLayerInterface_ptr;
		public static XrResult xrNegotiateLoaderApiLayerInterface(XrNegotiateLoaderInfo* loaderInfo, byte* layerName, XrNegotiateApiLayerRequest* apiLayerRequest)
			=> xrNegotiateLoaderApiLayerInterface_ptr(loaderInfo, layerName, apiLayerRequest);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateSpacesDelegate(XrSession session, XrSpacesLocateInfo* locateInfo, XrSpaceLocations* spaceLocations);
		private static xrLocateSpacesDelegate xrLocateSpaces_ptr;
		public static XrResult xrLocateSpaces(XrSession session, XrSpacesLocateInfo* locateInfo, XrSpaceLocations* spaceLocations)
			=> xrLocateSpaces_ptr(session, locateInfo, spaceLocations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetAndroidApplicationThreadKHRDelegate(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId);
		private static xrSetAndroidApplicationThreadKHRDelegate xrSetAndroidApplicationThreadKHR_ptr;
		public static XrResult xrSetAndroidApplicationThreadKHR(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId)
			=> xrSetAndroidApplicationThreadKHR_ptr(session, threadType, threadId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSwapchainAndroidSurfaceKHRDelegate(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, IntPtr surface);
		private static xrCreateSwapchainAndroidSurfaceKHRDelegate xrCreateSwapchainAndroidSurfaceKHR_ptr;
		public static XrResult xrCreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, IntPtr surface)
			=> xrCreateSwapchainAndroidSurfaceKHR_ptr(session, info, swapchain, surface);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPerfSettingsSetPerformanceLevelEXTDelegate(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level);
		private static xrPerfSettingsSetPerformanceLevelEXTDelegate xrPerfSettingsSetPerformanceLevelEXT_ptr;
		public static XrResult xrPerfSettingsSetPerformanceLevelEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level)
			=> xrPerfSettingsSetPerformanceLevelEXT_ptr(session, domain, level);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrThermalGetTemperatureTrendEXTDelegate(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope);
		private static xrThermalGetTemperatureTrendEXTDelegate xrThermalGetTemperatureTrendEXT_ptr;
		public static XrResult xrThermalGetTemperatureTrendEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope)
			=> xrThermalGetTemperatureTrendEXT_ptr(session, domain, notificationLevel, tempHeadroom, tempSlope);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetDebugUtilsObjectNameEXTDelegate(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo);
		private static xrSetDebugUtilsObjectNameEXTDelegate xrSetDebugUtilsObjectNameEXT_ptr;
		public static XrResult xrSetDebugUtilsObjectNameEXT(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo)
			=> xrSetDebugUtilsObjectNameEXT_ptr(instance, nameInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateDebugUtilsMessengerEXTDelegate(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger);
		private static xrCreateDebugUtilsMessengerEXTDelegate xrCreateDebugUtilsMessengerEXT_ptr;
		public static XrResult xrCreateDebugUtilsMessengerEXT(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger)
			=> xrCreateDebugUtilsMessengerEXT_ptr(instance, createInfo, messenger);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyDebugUtilsMessengerEXTDelegate(XrDebugUtilsMessengerEXT messenger);
		private static xrDestroyDebugUtilsMessengerEXTDelegate xrDestroyDebugUtilsMessengerEXT_ptr;
		public static XrResult xrDestroyDebugUtilsMessengerEXT(XrDebugUtilsMessengerEXT messenger)
			=> xrDestroyDebugUtilsMessengerEXT_ptr(messenger);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSubmitDebugUtilsMessageEXTDelegate(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData);
		private static xrSubmitDebugUtilsMessageEXTDelegate xrSubmitDebugUtilsMessageEXT_ptr;
		public static XrResult xrSubmitDebugUtilsMessageEXT(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData)
			=> xrSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, callbackData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSessionBeginDebugUtilsLabelRegionEXTDelegate(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
		private static xrSessionBeginDebugUtilsLabelRegionEXTDelegate xrSessionBeginDebugUtilsLabelRegionEXT_ptr;
		public static XrResult xrSessionBeginDebugUtilsLabelRegionEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
			=> xrSessionBeginDebugUtilsLabelRegionEXT_ptr(session, labelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSessionEndDebugUtilsLabelRegionEXTDelegate(XrSession session);
		private static xrSessionEndDebugUtilsLabelRegionEXTDelegate xrSessionEndDebugUtilsLabelRegionEXT_ptr;
		public static XrResult xrSessionEndDebugUtilsLabelRegionEXT(XrSession session)
			=> xrSessionEndDebugUtilsLabelRegionEXT_ptr(session);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSessionInsertDebugUtilsLabelEXTDelegate(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
		private static xrSessionInsertDebugUtilsLabelEXTDelegate xrSessionInsertDebugUtilsLabelEXT_ptr;
		public static XrResult xrSessionInsertDebugUtilsLabelEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
			=> xrSessionInsertDebugUtilsLabelEXT_ptr(session, labelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetOpenGLGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements);
		private static xrGetOpenGLGraphicsRequirementsKHRDelegate xrGetOpenGLGraphicsRequirementsKHR_ptr;
		public static XrResult xrGetOpenGLGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements)
			=> xrGetOpenGLGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetOpenGLESGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements);
		private static xrGetOpenGLESGraphicsRequirementsKHRDelegate xrGetOpenGLESGraphicsRequirementsKHR_ptr;
		public static XrResult xrGetOpenGLESGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements)
			=> xrGetOpenGLESGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVulkanInstanceExtensionsKHRDelegate(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetVulkanInstanceExtensionsKHRDelegate xrGetVulkanInstanceExtensionsKHR_ptr;
		public static XrResult xrGetVulkanInstanceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetVulkanInstanceExtensionsKHR_ptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVulkanDeviceExtensionsKHRDelegate(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetVulkanDeviceExtensionsKHRDelegate xrGetVulkanDeviceExtensionsKHR_ptr;
		public static XrResult xrGetVulkanDeviceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetVulkanDeviceExtensionsKHR_ptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVulkanGraphicsDeviceKHRDelegate(XrInstance instance, ulong systemId, IntPtr vkInstance, IntPtr vkPhysicalDevice);
		private static xrGetVulkanGraphicsDeviceKHRDelegate xrGetVulkanGraphicsDeviceKHR_ptr;
		public static XrResult xrGetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, IntPtr vkInstance, IntPtr vkPhysicalDevice)
			=> xrGetVulkanGraphicsDeviceKHR_ptr(instance, systemId, vkInstance, vkPhysicalDevice);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVulkanGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements);
		private static xrGetVulkanGraphicsRequirementsKHRDelegate xrGetVulkanGraphicsRequirementsKHR_ptr;
		public static XrResult xrGetVulkanGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
			=> xrGetVulkanGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetD3D11GraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements);
		private static xrGetD3D11GraphicsRequirementsKHRDelegate xrGetD3D11GraphicsRequirementsKHR_ptr;
		public static XrResult xrGetD3D11GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements)
			=> xrGetD3D11GraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetD3D12GraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements);
		private static xrGetD3D12GraphicsRequirementsKHRDelegate xrGetD3D12GraphicsRequirementsKHR_ptr;
		public static XrResult xrGetD3D12GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements)
			=> xrGetD3D12GraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMetalGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsMetalKHR* graphicsRequirements);
		private static xrGetMetalGraphicsRequirementsKHRDelegate xrGetMetalGraphicsRequirementsKHR_ptr;
		public static XrResult xrGetMetalGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsMetalKHR* graphicsRequirements)
			=> xrGetMetalGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVisibilityMaskKHRDelegate(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask);
		private static xrGetVisibilityMaskKHRDelegate xrGetVisibilityMaskKHR_ptr;
		public static XrResult xrGetVisibilityMaskKHR(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask)
			=> xrGetVisibilityMaskKHR_ptr(session, viewConfigurationType, viewIndex, visibilityMaskType, visibilityMask);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrConvertWin32PerformanceCounterToTimeKHRDelegate(XrInstance instance, IntPtr performanceCounter, long* time);
		private static xrConvertWin32PerformanceCounterToTimeKHRDelegate xrConvertWin32PerformanceCounterToTimeKHR_ptr;
		public static XrResult xrConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, IntPtr performanceCounter, long* time)
			=> xrConvertWin32PerformanceCounterToTimeKHR_ptr(instance, performanceCounter, time);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrConvertTimeToWin32PerformanceCounterKHRDelegate(XrInstance instance, long time, IntPtr performanceCounter);
		private static xrConvertTimeToWin32PerformanceCounterKHRDelegate xrConvertTimeToWin32PerformanceCounterKHR_ptr;
		public static XrResult xrConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, IntPtr performanceCounter)
			=> xrConvertTimeToWin32PerformanceCounterKHR_ptr(instance, time, performanceCounter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrConvertTimespecTimeToTimeKHRDelegate(XrInstance instance, IntPtr timespecTime, long* time);
		private static xrConvertTimespecTimeToTimeKHRDelegate xrConvertTimespecTimeToTimeKHR_ptr;
		public static XrResult xrConvertTimespecTimeToTimeKHR(XrInstance instance, IntPtr timespecTime, long* time)
			=> xrConvertTimespecTimeToTimeKHR_ptr(instance, timespecTime, time);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrConvertTimeToTimespecTimeKHRDelegate(XrInstance instance, long time, IntPtr timespecTime);
		private static xrConvertTimeToTimespecTimeKHRDelegate xrConvertTimeToTimespecTimeKHR_ptr;
		public static XrResult xrConvertTimeToTimespecTimeKHR(XrInstance instance, long time, IntPtr timespecTime)
			=> xrConvertTimeToTimespecTimeKHR_ptr(instance, time, timespecTime);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorMSFTDelegate(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor);
		private static xrCreateSpatialAnchorMSFTDelegate xrCreateSpatialAnchorMSFT_ptr;
		public static XrResult xrCreateSpatialAnchorMSFT(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor)
			=> xrCreateSpatialAnchorMSFT_ptr(session, createInfo, anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorSpaceMSFTDelegate(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space);
		private static xrCreateSpatialAnchorSpaceMSFTDelegate xrCreateSpatialAnchorSpaceMSFT_ptr;
		public static XrResult xrCreateSpatialAnchorSpaceMSFT(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space)
			=> xrCreateSpatialAnchorSpaceMSFT_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialAnchorMSFTDelegate(XrSpatialAnchorMSFT anchor);
		private static xrDestroySpatialAnchorMSFTDelegate xrDestroySpatialAnchorMSFT_ptr;
		public static XrResult xrDestroySpatialAnchorMSFT(XrSpatialAnchorMSFT anchor)
			=> xrDestroySpatialAnchorMSFT_ptr(anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetInputDeviceActiveEXTDelegate(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive);
		private static xrSetInputDeviceActiveEXTDelegate xrSetInputDeviceActiveEXT_ptr;
		public static XrResult xrSetInputDeviceActiveEXT(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive)
			=> xrSetInputDeviceActiveEXT_ptr(session, interactionProfile, topLevelPath, isActive);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetInputDeviceStateBoolEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state);
		private static xrSetInputDeviceStateBoolEXTDelegate xrSetInputDeviceStateBoolEXT_ptr;
		public static XrResult xrSetInputDeviceStateBoolEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state)
			=> xrSetInputDeviceStateBoolEXT_ptr(session, topLevelPath, inputSourcePath, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetInputDeviceStateFloatEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state);
		private static xrSetInputDeviceStateFloatEXTDelegate xrSetInputDeviceStateFloatEXT_ptr;
		public static XrResult xrSetInputDeviceStateFloatEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state)
			=> xrSetInputDeviceStateFloatEXT_ptr(session, topLevelPath, inputSourcePath, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetInputDeviceStateVector2fEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state);
		private static xrSetInputDeviceStateVector2fEXTDelegate xrSetInputDeviceStateVector2fEXT_ptr;
		public static XrResult xrSetInputDeviceStateVector2fEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state)
			=> xrSetInputDeviceStateVector2fEXT_ptr(session, topLevelPath, inputSourcePath, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetInputDeviceLocationEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose);
		private static xrSetInputDeviceLocationEXTDelegate xrSetInputDeviceLocationEXT_ptr;
		public static XrResult xrSetInputDeviceLocationEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose)
			=> xrSetInputDeviceLocationEXT_ptr(session, topLevelPath, inputSourcePath, space, pose);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialGraphNodeSpaceMSFTDelegate(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space);
		private static xrCreateSpatialGraphNodeSpaceMSFTDelegate xrCreateSpatialGraphNodeSpaceMSFT_ptr;
		public static XrResult xrCreateSpatialGraphNodeSpaceMSFT(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space)
			=> xrCreateSpatialGraphNodeSpaceMSFT_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFTDelegate(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding);
		private static xrTryCreateSpatialGraphStaticNodeBindingMSFTDelegate xrTryCreateSpatialGraphStaticNodeBindingMSFT_ptr;
		public static XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFT(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding)
			=> xrTryCreateSpatialGraphStaticNodeBindingMSFT_ptr(session, createInfo, nodeBinding);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialGraphNodeBindingMSFTDelegate(XrSpatialGraphNodeBindingMSFT nodeBinding);
		private static xrDestroySpatialGraphNodeBindingMSFTDelegate xrDestroySpatialGraphNodeBindingMSFT_ptr;
		public static XrResult xrDestroySpatialGraphNodeBindingMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding)
			=> xrDestroySpatialGraphNodeBindingMSFT_ptr(nodeBinding);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialGraphNodeBindingPropertiesMSFTDelegate(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties);
		private static xrGetSpatialGraphNodeBindingPropertiesMSFTDelegate xrGetSpatialGraphNodeBindingPropertiesMSFT_ptr;
		public static XrResult xrGetSpatialGraphNodeBindingPropertiesMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties)
			=> xrGetSpatialGraphNodeBindingPropertiesMSFT_ptr(nodeBinding, getInfo, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateHandTrackerEXTDelegate(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker);
		private static xrCreateHandTrackerEXTDelegate xrCreateHandTrackerEXT_ptr;
		public static XrResult xrCreateHandTrackerEXT(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker)
			=> xrCreateHandTrackerEXT_ptr(session, createInfo, handTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyHandTrackerEXTDelegate(XrHandTrackerEXT handTracker);
		private static xrDestroyHandTrackerEXTDelegate xrDestroyHandTrackerEXT_ptr;
		public static XrResult xrDestroyHandTrackerEXT(XrHandTrackerEXT handTracker)
			=> xrDestroyHandTrackerEXT_ptr(handTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateHandJointsEXTDelegate(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations);
		private static xrLocateHandJointsEXTDelegate xrLocateHandJointsEXT_ptr;
		public static XrResult xrLocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations)
			=> xrLocateHandJointsEXT_ptr(handTracker, locateInfo, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateHandMeshSpaceMSFTDelegate(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space);
		private static xrCreateHandMeshSpaceMSFTDelegate xrCreateHandMeshSpaceMSFT_ptr;
		public static XrResult xrCreateHandMeshSpaceMSFT(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space)
			=> xrCreateHandMeshSpaceMSFT_ptr(handTracker, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUpdateHandMeshMSFTDelegate(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh);
		private static xrUpdateHandMeshMSFTDelegate xrUpdateHandMeshMSFT_ptr;
		public static XrResult xrUpdateHandMeshMSFT(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh)
			=> xrUpdateHandMeshMSFT_ptr(handTracker, updateInfo, handMesh);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetControllerModelKeyMSFTDelegate(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState);
		private static xrGetControllerModelKeyMSFTDelegate xrGetControllerModelKeyMSFT_ptr;
		public static XrResult xrGetControllerModelKeyMSFT(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState)
			=> xrGetControllerModelKeyMSFT_ptr(session, topLevelUserPath, controllerModelKeyState);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLoadControllerModelMSFTDelegate(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrLoadControllerModelMSFTDelegate xrLoadControllerModelMSFT_ptr;
		public static XrResult xrLoadControllerModelMSFT(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrLoadControllerModelMSFT_ptr(session, modelKey, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetControllerModelPropertiesMSFTDelegate(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties);
		private static xrGetControllerModelPropertiesMSFTDelegate xrGetControllerModelPropertiesMSFT_ptr;
		public static XrResult xrGetControllerModelPropertiesMSFT(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties)
			=> xrGetControllerModelPropertiesMSFT_ptr(session, modelKey, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetControllerModelStateMSFTDelegate(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state);
		private static xrGetControllerModelStateMSFTDelegate xrGetControllerModelStateMSFT_ptr;
		public static XrResult xrGetControllerModelStateMSFT(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state)
			=> xrGetControllerModelStateMSFT_ptr(session, modelKey, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFTDelegate(XrSession session, IntPtr perceptionAnchor, XrSpatialAnchorMSFT* anchor);
		private static xrCreateSpatialAnchorFromPerceptionAnchorMSFTDelegate xrCreateSpatialAnchorFromPerceptionAnchorMSFT_ptr;
		public static XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, IntPtr perceptionAnchor, XrSpatialAnchorMSFT* anchor)
			=> xrCreateSpatialAnchorFromPerceptionAnchorMSFT_ptr(session, perceptionAnchor, anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFTDelegate(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr perceptionAnchor);
		private static xrTryGetPerceptionAnchorFromSpatialAnchorMSFTDelegate xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_ptr;
		public static XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr perceptionAnchor)
			=> xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_ptr(session, anchor, perceptionAnchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateReprojectionModesMSFTDelegate(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes);
		private static xrEnumerateReprojectionModesMSFTDelegate xrEnumerateReprojectionModesMSFT_ptr;
		public static XrResult xrEnumerateReprojectionModesMSFT(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes)
			=> xrEnumerateReprojectionModesMSFT_ptr(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, modes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUpdateSwapchainFBDelegate(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
		private static xrUpdateSwapchainFBDelegate xrUpdateSwapchainFB_ptr;
		public static XrResult xrUpdateSwapchainFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
			=> xrUpdateSwapchainFB_ptr(swapchain, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSwapchainStateFBDelegate(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
		private static xrGetSwapchainStateFBDelegate xrGetSwapchainStateFB_ptr;
		public static XrResult xrGetSwapchainStateFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
			=> xrGetSwapchainStateFB_ptr(swapchain, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateBodyTrackerFBDelegate(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker);
		private static xrCreateBodyTrackerFBDelegate xrCreateBodyTrackerFB_ptr;
		public static XrResult xrCreateBodyTrackerFB(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker)
			=> xrCreateBodyTrackerFB_ptr(session, createInfo, bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyBodyTrackerFBDelegate(XrBodyTrackerFB bodyTracker);
		private static xrDestroyBodyTrackerFBDelegate xrDestroyBodyTrackerFB_ptr;
		public static XrResult xrDestroyBodyTrackerFB(XrBodyTrackerFB bodyTracker)
			=> xrDestroyBodyTrackerFB_ptr(bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateBodyJointsFBDelegate(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations);
		private static xrLocateBodyJointsFBDelegate xrLocateBodyJointsFB_ptr;
		public static XrResult xrLocateBodyJointsFB(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations)
			=> xrLocateBodyJointsFB_ptr(bodyTracker, locateInfo, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetBodySkeletonFBDelegate(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton);
		private static xrGetBodySkeletonFBDelegate xrGetBodySkeletonFB_ptr;
		public static XrResult xrGetBodySkeletonFB(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton)
			=> xrGetBodySkeletonFB_ptr(bodyTracker, skeleton);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrInitializeLoaderKHRDelegate(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo);
		private static xrInitializeLoaderKHRDelegate xrInitializeLoaderKHR_ptr;
		public static XrResult xrInitializeLoaderKHR(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo)
			=> xrInitializeLoaderKHR_ptr(loaderInitInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateVulkanInstanceKHRDelegate(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, IntPtr vulkanInstance, IntPtr vulkanResult);
		private static xrCreateVulkanInstanceKHRDelegate xrCreateVulkanInstanceKHR_ptr;
		public static XrResult xrCreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, IntPtr vulkanInstance, IntPtr vulkanResult)
			=> xrCreateVulkanInstanceKHR_ptr(instance, createInfo, vulkanInstance, vulkanResult);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateVulkanDeviceKHRDelegate(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, IntPtr vulkanDevice, IntPtr vulkanResult);
		private static xrCreateVulkanDeviceKHRDelegate xrCreateVulkanDeviceKHR_ptr;
		public static XrResult xrCreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, IntPtr vulkanDevice, IntPtr vulkanResult)
			=> xrCreateVulkanDeviceKHR_ptr(instance, createInfo, vulkanDevice, vulkanResult);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVulkanGraphicsDevice2KHRDelegate(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, IntPtr vulkanPhysicalDevice);
		private static xrGetVulkanGraphicsDevice2KHRDelegate xrGetVulkanGraphicsDevice2KHR_ptr;
		public static XrResult xrGetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, IntPtr vulkanPhysicalDevice)
			=> xrGetVulkanGraphicsDevice2KHR_ptr(instance, getInfo, vulkanPhysicalDevice);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSceneComputeFeaturesMSFTDelegate(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features);
		private static xrEnumerateSceneComputeFeaturesMSFTDelegate xrEnumerateSceneComputeFeaturesMSFT_ptr;
		public static XrResult xrEnumerateSceneComputeFeaturesMSFT(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features)
			=> xrEnumerateSceneComputeFeaturesMSFT_ptr(instance, systemId, featureCapacityInput, featureCountOutput, features);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSceneObserverMSFTDelegate(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver);
		private static xrCreateSceneObserverMSFTDelegate xrCreateSceneObserverMSFT_ptr;
		public static XrResult xrCreateSceneObserverMSFT(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver)
			=> xrCreateSceneObserverMSFT_ptr(session, createInfo, sceneObserver);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySceneObserverMSFTDelegate(XrSceneObserverMSFT sceneObserver);
		private static xrDestroySceneObserverMSFTDelegate xrDestroySceneObserverMSFT_ptr;
		public static XrResult xrDestroySceneObserverMSFT(XrSceneObserverMSFT sceneObserver)
			=> xrDestroySceneObserverMSFT_ptr(sceneObserver);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSceneMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene);
		private static xrCreateSceneMSFTDelegate xrCreateSceneMSFT_ptr;
		public static XrResult xrCreateSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene)
			=> xrCreateSceneMSFT_ptr(sceneObserver, createInfo, scene);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySceneMSFTDelegate(XrSceneMSFT scene);
		private static xrDestroySceneMSFTDelegate xrDestroySceneMSFT_ptr;
		public static XrResult xrDestroySceneMSFT(XrSceneMSFT scene)
			=> xrDestroySceneMSFT_ptr(scene);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrComputeNewSceneMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo);
		private static xrComputeNewSceneMSFTDelegate xrComputeNewSceneMSFT_ptr;
		public static XrResult xrComputeNewSceneMSFT(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo)
			=> xrComputeNewSceneMSFT_ptr(sceneObserver, computeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSceneComputeStateMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state);
		private static xrGetSceneComputeStateMSFTDelegate xrGetSceneComputeStateMSFT_ptr;
		public static XrResult xrGetSceneComputeStateMSFT(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state)
			=> xrGetSceneComputeStateMSFT_ptr(sceneObserver, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSceneComponentsMSFTDelegate(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components);
		private static xrGetSceneComponentsMSFTDelegate xrGetSceneComponentsMSFT_ptr;
		public static XrResult xrGetSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components)
			=> xrGetSceneComponentsMSFT_ptr(scene, getInfo, components);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateSceneComponentsMSFTDelegate(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations);
		private static xrLocateSceneComponentsMSFTDelegate xrLocateSceneComponentsMSFT_ptr;
		public static XrResult xrLocateSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations)
			=> xrLocateSceneComponentsMSFT_ptr(scene, locateInfo, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSceneMeshBuffersMSFTDelegate(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers);
		private static xrGetSceneMeshBuffersMSFTDelegate xrGetSceneMeshBuffersMSFT_ptr;
		public static XrResult xrGetSceneMeshBuffersMSFT(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers)
			=> xrGetSceneMeshBuffersMSFT_ptr(scene, getInfo, buffers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDeserializeSceneMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo);
		private static xrDeserializeSceneMSFTDelegate xrDeserializeSceneMSFT_ptr;
		public static XrResult xrDeserializeSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo)
			=> xrDeserializeSceneMSFT_ptr(sceneObserver, deserializeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSerializedSceneFragmentDataMSFTDelegate(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer);
		private static xrGetSerializedSceneFragmentDataMSFTDelegate xrGetSerializedSceneFragmentDataMSFT_ptr;
		public static XrResult xrGetSerializedSceneFragmentDataMSFT(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer)
			=> xrGetSerializedSceneFragmentDataMSFT_ptr(scene, getInfo, countInput, readOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateDisplayRefreshRatesFBDelegate(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates);
		private static xrEnumerateDisplayRefreshRatesFBDelegate xrEnumerateDisplayRefreshRatesFB_ptr;
		public static XrResult xrEnumerateDisplayRefreshRatesFB(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates)
			=> xrEnumerateDisplayRefreshRatesFB_ptr(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, displayRefreshRates);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetDisplayRefreshRateFBDelegate(XrSession session, float* displayRefreshRate);
		private static xrGetDisplayRefreshRateFBDelegate xrGetDisplayRefreshRateFB_ptr;
		public static XrResult xrGetDisplayRefreshRateFB(XrSession session, float* displayRefreshRate)
			=> xrGetDisplayRefreshRateFB_ptr(session, displayRefreshRate);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestDisplayRefreshRateFBDelegate(XrSession session, float displayRefreshRate);
		private static xrRequestDisplayRefreshRateFBDelegate xrRequestDisplayRefreshRateFB_ptr;
		public static XrResult xrRequestDisplayRefreshRateFB(XrSession session, float displayRefreshRate)
			=> xrRequestDisplayRefreshRateFB_ptr(session, displayRefreshRate);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateViveTrackerPathsHTCXDelegate(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths);
		private static xrEnumerateViveTrackerPathsHTCXDelegate xrEnumerateViveTrackerPathsHTCX_ptr;
		public static XrResult xrEnumerateViveTrackerPathsHTCX(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths)
			=> xrEnumerateViveTrackerPathsHTCX_ptr(instance, pathCapacityInput, pathCountOutput, paths);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateFacialTrackerHTCDelegate(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker);
		private static xrCreateFacialTrackerHTCDelegate xrCreateFacialTrackerHTC_ptr;
		public static XrResult xrCreateFacialTrackerHTC(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker)
			=> xrCreateFacialTrackerHTC_ptr(session, createInfo, facialTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyFacialTrackerHTCDelegate(XrFacialTrackerHTC facialTracker);
		private static xrDestroyFacialTrackerHTCDelegate xrDestroyFacialTrackerHTC_ptr;
		public static XrResult xrDestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker)
			=> xrDestroyFacialTrackerHTC_ptr(facialTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetFacialExpressionsHTCDelegate(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions);
		private static xrGetFacialExpressionsHTCDelegate xrGetFacialExpressionsHTC_ptr;
		public static XrResult xrGetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions)
			=> xrGetFacialExpressionsHTC_ptr(facialTracker, facialExpressions);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateColorSpacesFBDelegate(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces);
		private static xrEnumerateColorSpacesFBDelegate xrEnumerateColorSpacesFB_ptr;
		public static XrResult xrEnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces)
			=> xrEnumerateColorSpacesFB_ptr(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetColorSpaceFBDelegate(XrSession session, XrColorSpaceFB colorSpace);
		private static xrSetColorSpaceFBDelegate xrSetColorSpaceFB_ptr;
		public static XrResult xrSetColorSpaceFB(XrSession session, XrColorSpaceFB colorSpace)
			=> xrSetColorSpaceFB_ptr(session, colorSpace);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetHandMeshFBDelegate(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh);
		private static xrGetHandMeshFBDelegate xrGetHandMeshFB_ptr;
		public static XrResult xrGetHandMeshFB(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh)
			=> xrGetHandMeshFB_ptr(handTracker, mesh);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorFBDelegate(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId);
		private static xrCreateSpatialAnchorFBDelegate xrCreateSpatialAnchorFB_ptr;
		public static XrResult xrCreateSpatialAnchorFB(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId)
			=> xrCreateSpatialAnchorFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceUuidFBDelegate(XrSpace space, XrUuid* uuid);
		private static xrGetSpaceUuidFBDelegate xrGetSpaceUuidFB_ptr;
		public static XrResult xrGetSpaceUuidFB(XrSpace space, XrUuid* uuid)
			=> xrGetSpaceUuidFB_ptr(space, uuid);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSpaceSupportedComponentsFBDelegate(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes);
		private static xrEnumerateSpaceSupportedComponentsFBDelegate xrEnumerateSpaceSupportedComponentsFB_ptr;
		public static XrResult xrEnumerateSpaceSupportedComponentsFB(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes)
			=> xrEnumerateSpaceSupportedComponentsFB_ptr(space, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetSpaceComponentStatusFBDelegate(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId);
		private static xrSetSpaceComponentStatusFBDelegate xrSetSpaceComponentStatusFB_ptr;
		public static XrResult xrSetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId)
			=> xrSetSpaceComponentStatusFB_ptr(space, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceComponentStatusFBDelegate(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status);
		private static xrGetSpaceComponentStatusFBDelegate xrGetSpaceComponentStatusFB_ptr;
		public static XrResult xrGetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status)
			=> xrGetSpaceComponentStatusFB_ptr(space, componentType, status);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateFoveationProfileFBDelegate(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile);
		private static xrCreateFoveationProfileFBDelegate xrCreateFoveationProfileFB_ptr;
		public static XrResult xrCreateFoveationProfileFB(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile)
			=> xrCreateFoveationProfileFB_ptr(session, createInfo, profile);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyFoveationProfileFBDelegate(XrFoveationProfileFB profile);
		private static xrDestroyFoveationProfileFBDelegate xrDestroyFoveationProfileFB_ptr;
		public static XrResult xrDestroyFoveationProfileFB(XrFoveationProfileFB profile)
			=> xrDestroyFoveationProfileFB_ptr(profile);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySystemTrackedKeyboardFBDelegate(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard);
		private static xrQuerySystemTrackedKeyboardFBDelegate xrQuerySystemTrackedKeyboardFB_ptr;
		public static XrResult xrQuerySystemTrackedKeyboardFB(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard)
			=> xrQuerySystemTrackedKeyboardFB_ptr(session, queryInfo, keyboard);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateKeyboardSpaceFBDelegate(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace);
		private static xrCreateKeyboardSpaceFBDelegate xrCreateKeyboardSpaceFB_ptr;
		public static XrResult xrCreateKeyboardSpaceFB(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace)
			=> xrCreateKeyboardSpaceFB_ptr(session, createInfo, keyboardSpace);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateTriangleMeshFBDelegate(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh);
		private static xrCreateTriangleMeshFBDelegate xrCreateTriangleMeshFB_ptr;
		public static XrResult xrCreateTriangleMeshFB(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh)
			=> xrCreateTriangleMeshFB_ptr(session, createInfo, outTriangleMesh);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyTriangleMeshFBDelegate(XrTriangleMeshFB mesh);
		private static xrDestroyTriangleMeshFBDelegate xrDestroyTriangleMeshFB_ptr;
		public static XrResult xrDestroyTriangleMeshFB(XrTriangleMeshFB mesh)
			=> xrDestroyTriangleMeshFB_ptr(mesh);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTriangleMeshGetVertexBufferFBDelegate(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer);
		private static xrTriangleMeshGetVertexBufferFBDelegate xrTriangleMeshGetVertexBufferFB_ptr;
		public static XrResult xrTriangleMeshGetVertexBufferFB(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer)
			=> xrTriangleMeshGetVertexBufferFB_ptr(mesh, outVertexBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTriangleMeshGetIndexBufferFBDelegate(XrTriangleMeshFB mesh, uint** outIndexBuffer);
		private static xrTriangleMeshGetIndexBufferFBDelegate xrTriangleMeshGetIndexBufferFB_ptr;
		public static XrResult xrTriangleMeshGetIndexBufferFB(XrTriangleMeshFB mesh, uint** outIndexBuffer)
			=> xrTriangleMeshGetIndexBufferFB_ptr(mesh, outIndexBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTriangleMeshBeginUpdateFBDelegate(XrTriangleMeshFB mesh);
		private static xrTriangleMeshBeginUpdateFBDelegate xrTriangleMeshBeginUpdateFB_ptr;
		public static XrResult xrTriangleMeshBeginUpdateFB(XrTriangleMeshFB mesh)
			=> xrTriangleMeshBeginUpdateFB_ptr(mesh);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTriangleMeshEndUpdateFBDelegate(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount);
		private static xrTriangleMeshEndUpdateFBDelegate xrTriangleMeshEndUpdateFB_ptr;
		public static XrResult xrTriangleMeshEndUpdateFB(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount)
			=> xrTriangleMeshEndUpdateFB_ptr(mesh, vertexCount, triangleCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTriangleMeshBeginVertexBufferUpdateFBDelegate(XrTriangleMeshFB mesh, uint* outVertexCount);
		private static xrTriangleMeshBeginVertexBufferUpdateFBDelegate xrTriangleMeshBeginVertexBufferUpdateFB_ptr;
		public static XrResult xrTriangleMeshBeginVertexBufferUpdateFB(XrTriangleMeshFB mesh, uint* outVertexCount)
			=> xrTriangleMeshBeginVertexBufferUpdateFB_ptr(mesh, outVertexCount);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrTriangleMeshEndVertexBufferUpdateFBDelegate(XrTriangleMeshFB mesh);
		private static xrTriangleMeshEndVertexBufferUpdateFBDelegate xrTriangleMeshEndVertexBufferUpdateFB_ptr;
		public static XrResult xrTriangleMeshEndVertexBufferUpdateFB(XrTriangleMeshFB mesh)
			=> xrTriangleMeshEndVertexBufferUpdateFB_ptr(mesh);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreatePassthroughFBDelegate(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough);
		private static xrCreatePassthroughFBDelegate xrCreatePassthroughFB_ptr;
		public static XrResult xrCreatePassthroughFB(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough)
			=> xrCreatePassthroughFB_ptr(session, createInfo, outPassthrough);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyPassthroughFBDelegate(XrPassthroughFB passthrough);
		private static xrDestroyPassthroughFBDelegate xrDestroyPassthroughFB_ptr;
		public static XrResult xrDestroyPassthroughFB(XrPassthroughFB passthrough)
			=> xrDestroyPassthroughFB_ptr(passthrough);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPassthroughStartFBDelegate(XrPassthroughFB passthrough);
		private static xrPassthroughStartFBDelegate xrPassthroughStartFB_ptr;
		public static XrResult xrPassthroughStartFB(XrPassthroughFB passthrough)
			=> xrPassthroughStartFB_ptr(passthrough);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPassthroughPauseFBDelegate(XrPassthroughFB passthrough);
		private static xrPassthroughPauseFBDelegate xrPassthroughPauseFB_ptr;
		public static XrResult xrPassthroughPauseFB(XrPassthroughFB passthrough)
			=> xrPassthroughPauseFB_ptr(passthrough);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreatePassthroughLayerFBDelegate(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer);
		private static xrCreatePassthroughLayerFBDelegate xrCreatePassthroughLayerFB_ptr;
		public static XrResult xrCreatePassthroughLayerFB(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer)
			=> xrCreatePassthroughLayerFB_ptr(session, createInfo, outLayer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyPassthroughLayerFBDelegate(XrPassthroughLayerFB layer);
		private static xrDestroyPassthroughLayerFBDelegate xrDestroyPassthroughLayerFB_ptr;
		public static XrResult xrDestroyPassthroughLayerFB(XrPassthroughLayerFB layer)
			=> xrDestroyPassthroughLayerFB_ptr(layer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPassthroughLayerPauseFBDelegate(XrPassthroughLayerFB layer);
		private static xrPassthroughLayerPauseFBDelegate xrPassthroughLayerPauseFB_ptr;
		public static XrResult xrPassthroughLayerPauseFB(XrPassthroughLayerFB layer)
			=> xrPassthroughLayerPauseFB_ptr(layer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPassthroughLayerResumeFBDelegate(XrPassthroughLayerFB layer);
		private static xrPassthroughLayerResumeFBDelegate xrPassthroughLayerResumeFB_ptr;
		public static XrResult xrPassthroughLayerResumeFB(XrPassthroughLayerFB layer)
			=> xrPassthroughLayerResumeFB_ptr(layer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPassthroughLayerSetStyleFBDelegate(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style);
		private static xrPassthroughLayerSetStyleFBDelegate xrPassthroughLayerSetStyleFB_ptr;
		public static XrResult xrPassthroughLayerSetStyleFB(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style)
			=> xrPassthroughLayerSetStyleFB_ptr(layer, style);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateGeometryInstanceFBDelegate(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance);
		private static xrCreateGeometryInstanceFBDelegate xrCreateGeometryInstanceFB_ptr;
		public static XrResult xrCreateGeometryInstanceFB(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance)
			=> xrCreateGeometryInstanceFB_ptr(session, createInfo, outGeometryInstance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyGeometryInstanceFBDelegate(XrGeometryInstanceFB instance);
		private static xrDestroyGeometryInstanceFBDelegate xrDestroyGeometryInstanceFB_ptr;
		public static XrResult xrDestroyGeometryInstanceFB(XrGeometryInstanceFB instance)
			=> xrDestroyGeometryInstanceFB_ptr(instance);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGeometryInstanceSetTransformFBDelegate(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation);
		private static xrGeometryInstanceSetTransformFBDelegate xrGeometryInstanceSetTransformFB_ptr;
		public static XrResult xrGeometryInstanceSetTransformFB(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation)
			=> xrGeometryInstanceSetTransformFB_ptr(instance, transformation);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateRenderModelPathsFBDelegate(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths);
		private static xrEnumerateRenderModelPathsFBDelegate xrEnumerateRenderModelPathsFB_ptr;
		public static XrResult xrEnumerateRenderModelPathsFB(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths)
			=> xrEnumerateRenderModelPathsFB_ptr(session, pathCapacityInput, pathCountOutput, paths);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRenderModelPropertiesFBDelegate(XrSession session, ulong path, XrRenderModelPropertiesFB* properties);
		private static xrGetRenderModelPropertiesFBDelegate xrGetRenderModelPropertiesFB_ptr;
		public static XrResult xrGetRenderModelPropertiesFB(XrSession session, ulong path, XrRenderModelPropertiesFB* properties)
			=> xrGetRenderModelPropertiesFB_ptr(session, path, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLoadRenderModelFBDelegate(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer);
		private static xrLoadRenderModelFBDelegate xrLoadRenderModelFB_ptr;
		public static XrResult xrLoadRenderModelFB(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer)
			=> xrLoadRenderModelFB_ptr(session, info, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetEnvironmentDepthEstimationVARJODelegate(XrSession session, XrBool32 enabled);
		private static xrSetEnvironmentDepthEstimationVARJODelegate xrSetEnvironmentDepthEstimationVARJO_ptr;
		public static XrResult xrSetEnvironmentDepthEstimationVARJO(XrSession session, XrBool32 enabled)
			=> xrSetEnvironmentDepthEstimationVARJO_ptr(session, enabled);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetMarkerTrackingVARJODelegate(XrSession session, XrBool32 enabled);
		private static xrSetMarkerTrackingVARJODelegate xrSetMarkerTrackingVARJO_ptr;
		public static XrResult xrSetMarkerTrackingVARJO(XrSession session, XrBool32 enabled)
			=> xrSetMarkerTrackingVARJO_ptr(session, enabled);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetMarkerTrackingTimeoutVARJODelegate(XrSession session, ulong markerId, long timeout);
		private static xrSetMarkerTrackingTimeoutVARJODelegate xrSetMarkerTrackingTimeoutVARJO_ptr;
		public static XrResult xrSetMarkerTrackingTimeoutVARJO(XrSession session, ulong markerId, long timeout)
			=> xrSetMarkerTrackingTimeoutVARJO_ptr(session, markerId, timeout);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetMarkerTrackingPredictionVARJODelegate(XrSession session, ulong markerId, XrBool32 enable);
		private static xrSetMarkerTrackingPredictionVARJODelegate xrSetMarkerTrackingPredictionVARJO_ptr;
		public static XrResult xrSetMarkerTrackingPredictionVARJO(XrSession session, ulong markerId, XrBool32 enable)
			=> xrSetMarkerTrackingPredictionVARJO_ptr(session, markerId, enable);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkerSizeVARJODelegate(XrSession session, ulong markerId, XrExtent2Df* size);
		private static xrGetMarkerSizeVARJODelegate xrGetMarkerSizeVARJO_ptr;
		public static XrResult xrGetMarkerSizeVARJO(XrSession session, ulong markerId, XrExtent2Df* size)
			=> xrGetMarkerSizeVARJO_ptr(session, markerId, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateMarkerSpaceVARJODelegate(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space);
		private static xrCreateMarkerSpaceVARJODelegate xrCreateMarkerSpaceVARJO_ptr;
		public static XrResult xrCreateMarkerSpaceVARJO(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space)
			=> xrCreateMarkerSpaceVARJO_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetViewOffsetVARJODelegate(XrSession session, float offset);
		private static xrSetViewOffsetVARJODelegate xrSetViewOffsetVARJO_ptr;
		public static XrResult xrSetViewOffsetVARJO(XrSession session, float offset)
			=> xrSetViewOffsetVARJO_ptr(session, offset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpaceFromCoordinateFrameUIDMLDelegate(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space);
		private static xrCreateSpaceFromCoordinateFrameUIDMLDelegate xrCreateSpaceFromCoordinateFrameUIDML_ptr;
		public static XrResult xrCreateSpaceFromCoordinateFrameUIDML(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space)
			=> xrCreateSpaceFromCoordinateFrameUIDML_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateMarkerDetectorMLDelegate(XrSession session, XrMarkerDetectorCreateInfoML* createInfo, XrMarkerDetectorML* markerDetector);
		private static xrCreateMarkerDetectorMLDelegate xrCreateMarkerDetectorML_ptr;
		public static XrResult xrCreateMarkerDetectorML(XrSession session, XrMarkerDetectorCreateInfoML* createInfo, XrMarkerDetectorML* markerDetector)
			=> xrCreateMarkerDetectorML_ptr(session, createInfo, markerDetector);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyMarkerDetectorMLDelegate(XrMarkerDetectorML markerDetector);
		private static xrDestroyMarkerDetectorMLDelegate xrDestroyMarkerDetectorML_ptr;
		public static XrResult xrDestroyMarkerDetectorML(XrMarkerDetectorML markerDetector)
			=> xrDestroyMarkerDetectorML_ptr(markerDetector);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSnapshotMarkerDetectorMLDelegate(XrMarkerDetectorML markerDetector, XrMarkerDetectorSnapshotInfoML* snapshotInfo);
		private static xrSnapshotMarkerDetectorMLDelegate xrSnapshotMarkerDetectorML_ptr;
		public static XrResult xrSnapshotMarkerDetectorML(XrMarkerDetectorML markerDetector, XrMarkerDetectorSnapshotInfoML* snapshotInfo)
			=> xrSnapshotMarkerDetectorML_ptr(markerDetector, snapshotInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkerDetectorStateMLDelegate(XrMarkerDetectorML markerDetector, XrMarkerDetectorStateML* state);
		private static xrGetMarkerDetectorStateMLDelegate xrGetMarkerDetectorStateML_ptr;
		public static XrResult xrGetMarkerDetectorStateML(XrMarkerDetectorML markerDetector, XrMarkerDetectorStateML* state)
			=> xrGetMarkerDetectorStateML_ptr(markerDetector, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkersMLDelegate(XrMarkerDetectorML markerDetector, uint markerCapacityInput, uint* markerCountOutput, ulong* markers);
		private static xrGetMarkersMLDelegate xrGetMarkersML_ptr;
		public static XrResult xrGetMarkersML(XrMarkerDetectorML markerDetector, uint markerCapacityInput, uint* markerCountOutput, ulong* markers)
			=> xrGetMarkersML_ptr(markerDetector, markerCapacityInput, markerCountOutput, markers);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkerReprojectionErrorMLDelegate(XrMarkerDetectorML markerDetector, ulong marker, float* reprojectionErrorMeters);
		private static xrGetMarkerReprojectionErrorMLDelegate xrGetMarkerReprojectionErrorML_ptr;
		public static XrResult xrGetMarkerReprojectionErrorML(XrMarkerDetectorML markerDetector, ulong marker, float* reprojectionErrorMeters)
			=> xrGetMarkerReprojectionErrorML_ptr(markerDetector, marker, reprojectionErrorMeters);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkerLengthMLDelegate(XrMarkerDetectorML markerDetector, ulong marker, float* meters);
		private static xrGetMarkerLengthMLDelegate xrGetMarkerLengthML_ptr;
		public static XrResult xrGetMarkerLengthML(XrMarkerDetectorML markerDetector, ulong marker, float* meters)
			=> xrGetMarkerLengthML_ptr(markerDetector, marker, meters);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkerNumberMLDelegate(XrMarkerDetectorML markerDetector, ulong marker, ulong* number);
		private static xrGetMarkerNumberMLDelegate xrGetMarkerNumberML_ptr;
		public static XrResult xrGetMarkerNumberML(XrMarkerDetectorML markerDetector, ulong marker, ulong* number)
			=> xrGetMarkerNumberML_ptr(markerDetector, marker, number);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetMarkerStringMLDelegate(XrMarkerDetectorML markerDetector, ulong marker, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetMarkerStringMLDelegate xrGetMarkerStringML_ptr;
		public static XrResult xrGetMarkerStringML(XrMarkerDetectorML markerDetector, ulong marker, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetMarkerStringML_ptr(markerDetector, marker, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateMarkerSpaceMLDelegate(XrSession session, XrMarkerSpaceCreateInfoML* createInfo, XrSpace* space);
		private static xrCreateMarkerSpaceMLDelegate xrCreateMarkerSpaceML_ptr;
		public static XrResult xrCreateMarkerSpaceML(XrSession session, XrMarkerSpaceCreateInfoML* createInfo, XrSpace* space)
			=> xrCreateMarkerSpaceML_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnableLocalizationEventsMLDelegate(XrSession session, XrLocalizationEnableEventsInfoML info);
		private static xrEnableLocalizationEventsMLDelegate xrEnableLocalizationEventsML_ptr;
		public static XrResult xrEnableLocalizationEventsML(XrSession session, XrLocalizationEnableEventsInfoML info)
			=> xrEnableLocalizationEventsML_ptr(session, info);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQueryLocalizationMapsMLDelegate(XrSession session, XrLocalizationMapQueryInfoBaseHeaderML* queryInfo, uint mapCapacityInput, uint mapCountOutput, XrLocalizationMapML* maps);
		private static xrQueryLocalizationMapsMLDelegate xrQueryLocalizationMapsML_ptr;
		public static XrResult xrQueryLocalizationMapsML(XrSession session, XrLocalizationMapQueryInfoBaseHeaderML* queryInfo, uint mapCapacityInput, uint mapCountOutput, XrLocalizationMapML* maps)
			=> xrQueryLocalizationMapsML_ptr(session, queryInfo, mapCapacityInput, mapCountOutput, maps);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestMapLocalizationMLDelegate(XrSession session, XrMapLocalizationRequestInfoML* requestInfo);
		private static xrRequestMapLocalizationMLDelegate xrRequestMapLocalizationML_ptr;
		public static XrResult xrRequestMapLocalizationML(XrSession session, XrMapLocalizationRequestInfoML* requestInfo)
			=> xrRequestMapLocalizationML_ptr(session, requestInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrImportLocalizationMapMLDelegate(XrSession session, XrLocalizationMapImportInfoML* importInfo, XrUuid* mapUuid);
		private static xrImportLocalizationMapMLDelegate xrImportLocalizationMapML_ptr;
		public static XrResult xrImportLocalizationMapML(XrSession session, XrLocalizationMapImportInfoML* importInfo, XrUuid* mapUuid)
			=> xrImportLocalizationMapML_ptr(session, importInfo, mapUuid);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateExportedLocalizationMapMLDelegate(XrSession session, XrUuid* mapUuid, XrExportedLocalizationMapML* map);
		private static xrCreateExportedLocalizationMapMLDelegate xrCreateExportedLocalizationMapML_ptr;
		public static XrResult xrCreateExportedLocalizationMapML(XrSession session, XrUuid* mapUuid, XrExportedLocalizationMapML* map)
			=> xrCreateExportedLocalizationMapML_ptr(session, mapUuid, map);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyExportedLocalizationMapMLDelegate(XrExportedLocalizationMapML map);
		private static xrDestroyExportedLocalizationMapMLDelegate xrDestroyExportedLocalizationMapML_ptr;
		public static XrResult xrDestroyExportedLocalizationMapML(XrExportedLocalizationMapML map)
			=> xrDestroyExportedLocalizationMapML_ptr(map);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetExportedLocalizationMapDataMLDelegate(XrExportedLocalizationMapML map, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetExportedLocalizationMapDataMLDelegate xrGetExportedLocalizationMapDataML_ptr;
		public static XrResult xrGetExportedLocalizationMapDataML(XrExportedLocalizationMapML map, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetExportedLocalizationMapDataML_ptr(map, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorsAsyncMLDelegate(XrSession session, XrSpatialAnchorsCreateInfoBaseHeaderML* createInfo, ulong* future);
		private static xrCreateSpatialAnchorsAsyncMLDelegate xrCreateSpatialAnchorsAsyncML_ptr;
		public static XrResult xrCreateSpatialAnchorsAsyncML(XrSession session, XrSpatialAnchorsCreateInfoBaseHeaderML* createInfo, ulong* future)
			=> xrCreateSpatialAnchorsAsyncML_ptr(session, createInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorsCompleteMLDelegate(XrSession session, ulong future, XrCreateSpatialAnchorsCompletionML* completion);
		private static xrCreateSpatialAnchorsCompleteMLDelegate xrCreateSpatialAnchorsCompleteML_ptr;
		public static XrResult xrCreateSpatialAnchorsCompleteML(XrSession session, ulong future, XrCreateSpatialAnchorsCompletionML* completion)
			=> xrCreateSpatialAnchorsCompleteML_ptr(session, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialAnchorStateMLDelegate(XrSpace anchor, XrSpatialAnchorStateML* state);
		private static xrGetSpatialAnchorStateMLDelegate xrGetSpatialAnchorStateML_ptr;
		public static XrResult xrGetSpatialAnchorStateML(XrSpace anchor, XrSpatialAnchorStateML* state)
			=> xrGetSpatialAnchorStateML_ptr(anchor, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorsStorageMLDelegate(XrSession session, XrSpatialAnchorsCreateStorageInfoML* createInfo, XrSpatialAnchorsStorageML* storage);
		private static xrCreateSpatialAnchorsStorageMLDelegate xrCreateSpatialAnchorsStorageML_ptr;
		public static XrResult xrCreateSpatialAnchorsStorageML(XrSession session, XrSpatialAnchorsCreateStorageInfoML* createInfo, XrSpatialAnchorsStorageML* storage)
			=> xrCreateSpatialAnchorsStorageML_ptr(session, createInfo, storage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialAnchorsStorageMLDelegate(XrSpatialAnchorsStorageML storage);
		private static xrDestroySpatialAnchorsStorageMLDelegate xrDestroySpatialAnchorsStorageML_ptr;
		public static XrResult xrDestroySpatialAnchorsStorageML(XrSpatialAnchorsStorageML storage)
			=> xrDestroySpatialAnchorsStorageML_ptr(storage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySpatialAnchorsAsyncMLDelegate(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsQueryInfoBaseHeaderML* queryInfo, ulong* future);
		private static xrQuerySpatialAnchorsAsyncMLDelegate xrQuerySpatialAnchorsAsyncML_ptr;
		public static XrResult xrQuerySpatialAnchorsAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsQueryInfoBaseHeaderML* queryInfo, ulong* future)
			=> xrQuerySpatialAnchorsAsyncML_ptr(storage, queryInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySpatialAnchorsCompleteMLDelegate(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsQueryCompletionML* completion);
		private static xrQuerySpatialAnchorsCompleteMLDelegate xrQuerySpatialAnchorsCompleteML_ptr;
		public static XrResult xrQuerySpatialAnchorsCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsQueryCompletionML* completion)
			=> xrQuerySpatialAnchorsCompleteML_ptr(storage, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPublishSpatialAnchorsAsyncMLDelegate(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsPublishInfoML* publishInfo, ulong* future);
		private static xrPublishSpatialAnchorsAsyncMLDelegate xrPublishSpatialAnchorsAsyncML_ptr;
		public static XrResult xrPublishSpatialAnchorsAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsPublishInfoML* publishInfo, ulong* future)
			=> xrPublishSpatialAnchorsAsyncML_ptr(storage, publishInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPublishSpatialAnchorsCompleteMLDelegate(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsPublishCompletionML* completion);
		private static xrPublishSpatialAnchorsCompleteMLDelegate xrPublishSpatialAnchorsCompleteML_ptr;
		public static XrResult xrPublishSpatialAnchorsCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsPublishCompletionML* completion)
			=> xrPublishSpatialAnchorsCompleteML_ptr(storage, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDeleteSpatialAnchorsAsyncMLDelegate(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsDeleteInfoML* deleteInfo, ulong* future);
		private static xrDeleteSpatialAnchorsAsyncMLDelegate xrDeleteSpatialAnchorsAsyncML_ptr;
		public static XrResult xrDeleteSpatialAnchorsAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsDeleteInfoML* deleteInfo, ulong* future)
			=> xrDeleteSpatialAnchorsAsyncML_ptr(storage, deleteInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDeleteSpatialAnchorsCompleteMLDelegate(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsDeleteCompletionML* completion);
		private static xrDeleteSpatialAnchorsCompleteMLDelegate xrDeleteSpatialAnchorsCompleteML_ptr;
		public static XrResult xrDeleteSpatialAnchorsCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsDeleteCompletionML* completion)
			=> xrDeleteSpatialAnchorsCompleteML_ptr(storage, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUpdateSpatialAnchorsExpirationAsyncMLDelegate(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsUpdateExpirationInfoML* updateInfo, ulong* future);
		private static xrUpdateSpatialAnchorsExpirationAsyncMLDelegate xrUpdateSpatialAnchorsExpirationAsyncML_ptr;
		public static XrResult xrUpdateSpatialAnchorsExpirationAsyncML(XrSpatialAnchorsStorageML storage, XrSpatialAnchorsUpdateExpirationInfoML* updateInfo, ulong* future)
			=> xrUpdateSpatialAnchorsExpirationAsyncML_ptr(storage, updateInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUpdateSpatialAnchorsExpirationCompleteMLDelegate(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsUpdateExpirationCompletionML* completion);
		private static xrUpdateSpatialAnchorsExpirationCompleteMLDelegate xrUpdateSpatialAnchorsExpirationCompleteML_ptr;
		public static XrResult xrUpdateSpatialAnchorsExpirationCompleteML(XrSpatialAnchorsStorageML storage, ulong future, XrSpatialAnchorsUpdateExpirationCompletionML* completion)
			=> xrUpdateSpatialAnchorsExpirationCompleteML_ptr(storage, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnableUserCalibrationEventsMLDelegate(XrInstance instance, XrUserCalibrationEnableEventsInfoML* enableInfo);
		private static xrEnableUserCalibrationEventsMLDelegate xrEnableUserCalibrationEventsML_ptr;
		public static XrResult xrEnableUserCalibrationEventsML(XrInstance instance, XrUserCalibrationEnableEventsInfoML* enableInfo)
			=> xrEnableUserCalibrationEventsML_ptr(instance, enableInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorStoreConnectionMSFTDelegate(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore);
		private static xrCreateSpatialAnchorStoreConnectionMSFTDelegate xrCreateSpatialAnchorStoreConnectionMSFT_ptr;
		public static XrResult xrCreateSpatialAnchorStoreConnectionMSFT(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore)
			=> xrCreateSpatialAnchorStoreConnectionMSFT_ptr(session, spatialAnchorStore);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialAnchorStoreConnectionMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
		private static xrDestroySpatialAnchorStoreConnectionMSFTDelegate xrDestroySpatialAnchorStoreConnectionMSFT_ptr;
		public static XrResult xrDestroySpatialAnchorStoreConnectionMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
			=> xrDestroySpatialAnchorStoreConnectionMSFT_ptr(spatialAnchorStore);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPersistSpatialAnchorMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo);
		private static xrPersistSpatialAnchorMSFTDelegate xrPersistSpatialAnchorMSFT_ptr;
		public static XrResult xrPersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo)
			=> xrPersistSpatialAnchorMSFT_ptr(spatialAnchorStore, spatialAnchorPersistenceInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumeratePersistedSpatialAnchorNamesMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNameCapacityInput, uint* spatialAnchorNameCountOutput, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorNames);
		private static xrEnumeratePersistedSpatialAnchorNamesMSFTDelegate xrEnumeratePersistedSpatialAnchorNamesMSFT_ptr;
		public static XrResult xrEnumeratePersistedSpatialAnchorNamesMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNameCapacityInput, uint* spatialAnchorNameCountOutput, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorNames)
			=> xrEnumeratePersistedSpatialAnchorNamesMSFT_ptr(spatialAnchorStore, spatialAnchorNameCapacityInput, spatialAnchorNameCountOutput, spatialAnchorNames);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorFromPersistedNameMSFTDelegate(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor);
		private static xrCreateSpatialAnchorFromPersistedNameMSFTDelegate xrCreateSpatialAnchorFromPersistedNameMSFT_ptr;
		public static XrResult xrCreateSpatialAnchorFromPersistedNameMSFT(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor)
			=> xrCreateSpatialAnchorFromPersistedNameMSFT_ptr(session, spatialAnchorCreateInfo, spatialAnchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnpersistSpatialAnchorMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName);
		private static xrUnpersistSpatialAnchorMSFTDelegate xrUnpersistSpatialAnchorMSFT_ptr;
		public static XrResult xrUnpersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName)
			=> xrUnpersistSpatialAnchorMSFT_ptr(spatialAnchorStore, spatialAnchorPersistenceName);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrClearSpatialAnchorStoreMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
		private static xrClearSpatialAnchorStoreMSFTDelegate xrClearSpatialAnchorStoreMSFT_ptr;
		public static XrResult xrClearSpatialAnchorStoreMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
			=> xrClearSpatialAnchorStoreMSFT_ptr(spatialAnchorStore);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSceneMarkerRawDataMSFTDelegate(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetSceneMarkerRawDataMSFTDelegate xrGetSceneMarkerRawDataMSFT_ptr;
		public static XrResult xrGetSceneMarkerRawDataMSFT(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetSceneMarkerRawDataMSFT_ptr(scene, markerId, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSceneMarkerDecodedStringMSFTDelegate(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetSceneMarkerDecodedStringMSFTDelegate xrGetSceneMarkerDecodedStringMSFT_ptr;
		public static XrResult xrGetSceneMarkerDecodedStringMSFT(XrSceneMSFT scene, XrUuidMSFT* markerId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetSceneMarkerDecodedStringMSFT_ptr(scene, markerId, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStructureTypeToString2KHRDelegate(XrInstance instance, XrStructureType value, byte buffer);
		private static xrStructureTypeToString2KHRDelegate xrStructureTypeToString2KHR_ptr;
		public static XrResult xrStructureTypeToString2KHR(XrInstance instance, XrStructureType value, byte buffer)
			=> xrStructureTypeToString2KHR_ptr(instance, value, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySpacesFBDelegate(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId);
		private static xrQuerySpacesFBDelegate xrQuerySpacesFB_ptr;
		public static XrResult xrQuerySpacesFB(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId)
			=> xrQuerySpacesFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRetrieveSpaceQueryResultsFBDelegate(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results);
		private static xrRetrieveSpaceQueryResultsFBDelegate xrRetrieveSpaceQueryResultsFB_ptr;
		public static XrResult xrRetrieveSpaceQueryResultsFB(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results)
			=> xrRetrieveSpaceQueryResultsFB_ptr(session, requestId, results);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSaveSpaceFBDelegate(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId);
		private static xrSaveSpaceFBDelegate xrSaveSpaceFB_ptr;
		public static XrResult xrSaveSpaceFB(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId)
			=> xrSaveSpaceFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEraseSpaceFBDelegate(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId);
		private static xrEraseSpaceFBDelegate xrEraseSpaceFB_ptr;
		public static XrResult xrEraseSpaceFB(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId)
			=> xrEraseSpaceFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetAudioOutputDeviceGuidOculusDelegate(XrInstance instance, string buffer);
		private static xrGetAudioOutputDeviceGuidOculusDelegate xrGetAudioOutputDeviceGuidOculus_ptr;
		public static XrResult xrGetAudioOutputDeviceGuidOculus(XrInstance instance, string buffer)
			=> xrGetAudioOutputDeviceGuidOculus_ptr(instance, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetAudioInputDeviceGuidOculusDelegate(XrInstance instance, string buffer);
		private static xrGetAudioInputDeviceGuidOculusDelegate xrGetAudioInputDeviceGuidOculus_ptr;
		public static XrResult xrGetAudioInputDeviceGuidOculus(XrInstance instance, string buffer)
			=> xrGetAudioInputDeviceGuidOculus_ptr(instance, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrShareSpacesFBDelegate(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId);
		private static xrShareSpacesFBDelegate xrShareSpacesFB_ptr;
		public static XrResult xrShareSpacesFB(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId)
			=> xrShareSpacesFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceBoundingBox2DFBDelegate(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput);
		private static xrGetSpaceBoundingBox2DFBDelegate xrGetSpaceBoundingBox2DFB_ptr;
		public static XrResult xrGetSpaceBoundingBox2DFB(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput)
			=> xrGetSpaceBoundingBox2DFB_ptr(session, space, boundingBox2DOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceBoundingBox3DFBDelegate(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput);
		private static xrGetSpaceBoundingBox3DFBDelegate xrGetSpaceBoundingBox3DFB_ptr;
		public static XrResult xrGetSpaceBoundingBox3DFB(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput)
			=> xrGetSpaceBoundingBox3DFB_ptr(session, space, boundingBox3DOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceSemanticLabelsFBDelegate(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput);
		private static xrGetSpaceSemanticLabelsFBDelegate xrGetSpaceSemanticLabelsFB_ptr;
		public static XrResult xrGetSpaceSemanticLabelsFB(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput)
			=> xrGetSpaceSemanticLabelsFB_ptr(session, space, semanticLabelsOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceBoundary2DFBDelegate(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput);
		private static xrGetSpaceBoundary2DFBDelegate xrGetSpaceBoundary2DFB_ptr;
		public static XrResult xrGetSpaceBoundary2DFB(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput)
			=> xrGetSpaceBoundary2DFB_ptr(session, space, boundary2DOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceRoomLayoutFBDelegate(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput);
		private static xrGetSpaceRoomLayoutFBDelegate xrGetSpaceRoomLayoutFB_ptr;
		public static XrResult xrGetSpaceRoomLayoutFB(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput)
			=> xrGetSpaceRoomLayoutFB_ptr(session, space, roomLayoutOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetDigitalLensControlALMALENCEDelegate(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl);
		private static xrSetDigitalLensControlALMALENCEDelegate xrSetDigitalLensControlALMALENCE_ptr;
		public static XrResult xrSetDigitalLensControlALMALENCE(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl)
			=> xrSetDigitalLensControlALMALENCE_ptr(session, digitalLensControl);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestSceneCaptureFBDelegate(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId);
		private static xrRequestSceneCaptureFBDelegate xrRequestSceneCaptureFB_ptr;
		public static XrResult xrRequestSceneCaptureFB(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId)
			=> xrRequestSceneCaptureFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceContainerFBDelegate(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput);
		private static xrGetSpaceContainerFBDelegate xrGetSpaceContainerFB_ptr;
		public static XrResult xrGetSpaceContainerFB(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput)
			=> xrGetSpaceContainerFB_ptr(session, space, spaceContainerOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetFoveationEyeTrackedStateMETADelegate(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState);
		private static xrGetFoveationEyeTrackedStateMETADelegate xrGetFoveationEyeTrackedStateMETA_ptr;
		public static XrResult xrGetFoveationEyeTrackedStateMETA(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState)
			=> xrGetFoveationEyeTrackedStateMETA_ptr(session, foveationState);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateFaceTrackerFBDelegate(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker);
		private static xrCreateFaceTrackerFBDelegate xrCreateFaceTrackerFB_ptr;
		public static XrResult xrCreateFaceTrackerFB(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker)
			=> xrCreateFaceTrackerFB_ptr(session, createInfo, faceTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyFaceTrackerFBDelegate(XrFaceTrackerFB faceTracker);
		private static xrDestroyFaceTrackerFBDelegate xrDestroyFaceTrackerFB_ptr;
		public static XrResult xrDestroyFaceTrackerFB(XrFaceTrackerFB faceTracker)
			=> xrDestroyFaceTrackerFB_ptr(faceTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetFaceExpressionWeightsFBDelegate(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights);
		private static xrGetFaceExpressionWeightsFBDelegate xrGetFaceExpressionWeightsFB_ptr;
		public static XrResult xrGetFaceExpressionWeightsFB(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights)
			=> xrGetFaceExpressionWeightsFB_ptr(faceTracker, expressionInfo, expressionWeights);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateEyeTrackerFBDelegate(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker);
		private static xrCreateEyeTrackerFBDelegate xrCreateEyeTrackerFB_ptr;
		public static XrResult xrCreateEyeTrackerFB(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker)
			=> xrCreateEyeTrackerFB_ptr(session, createInfo, eyeTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyEyeTrackerFBDelegate(XrEyeTrackerFB eyeTracker);
		private static xrDestroyEyeTrackerFBDelegate xrDestroyEyeTrackerFB_ptr;
		public static XrResult xrDestroyEyeTrackerFB(XrEyeTrackerFB eyeTracker)
			=> xrDestroyEyeTrackerFB_ptr(eyeTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetEyeGazesFBDelegate(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes);
		private static xrGetEyeGazesFBDelegate xrGetEyeGazesFB_ptr;
		public static XrResult xrGetEyeGazesFB(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes)
			=> xrGetEyeGazesFB_ptr(eyeTracker, gazeInfo, eyeGazes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPassthroughLayerSetKeyboardHandsIntensityFBDelegate(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity);
		private static xrPassthroughLayerSetKeyboardHandsIntensityFBDelegate xrPassthroughLayerSetKeyboardHandsIntensityFB_ptr;
		public static XrResult xrPassthroughLayerSetKeyboardHandsIntensityFB(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity)
			=> xrPassthroughLayerSetKeyboardHandsIntensityFB_ptr(layer, intensity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetDeviceSampleRateFBDelegate(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate);
		private static xrGetDeviceSampleRateFBDelegate xrGetDeviceSampleRateFB_ptr;
		public static XrResult xrGetDeviceSampleRateFB(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate)
			=> xrGetDeviceSampleRateFB_ptr(session, hapticActionInfo, deviceSampleRate);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetPassthroughPreferencesMETADelegate(XrSession session, XrPassthroughPreferencesMETA* preferences);
		private static xrGetPassthroughPreferencesMETADelegate xrGetPassthroughPreferencesMETA_ptr;
		public static XrResult xrGetPassthroughPreferencesMETA(XrSession session, XrPassthroughPreferencesMETA* preferences)
			=> xrGetPassthroughPreferencesMETA_ptr(session, preferences);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateVirtualKeyboardMETADelegate(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard);
		private static xrCreateVirtualKeyboardMETADelegate xrCreateVirtualKeyboardMETA_ptr;
		public static XrResult xrCreateVirtualKeyboardMETA(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard)
			=> xrCreateVirtualKeyboardMETA_ptr(session, createInfo, keyboard);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyVirtualKeyboardMETADelegate(XrVirtualKeyboardMETA keyboard);
		private static xrDestroyVirtualKeyboardMETADelegate xrDestroyVirtualKeyboardMETA_ptr;
		public static XrResult xrDestroyVirtualKeyboardMETA(XrVirtualKeyboardMETA keyboard)
			=> xrDestroyVirtualKeyboardMETA_ptr(keyboard);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateVirtualKeyboardSpaceMETADelegate(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace);
		private static xrCreateVirtualKeyboardSpaceMETADelegate xrCreateVirtualKeyboardSpaceMETA_ptr;
		public static XrResult xrCreateVirtualKeyboardSpaceMETA(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace)
			=> xrCreateVirtualKeyboardSpaceMETA_ptr(session, keyboard, createInfo, keyboardSpace);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSuggestVirtualKeyboardLocationMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo);
		private static xrSuggestVirtualKeyboardLocationMETADelegate xrSuggestVirtualKeyboardLocationMETA_ptr;
		public static XrResult xrSuggestVirtualKeyboardLocationMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo)
			=> xrSuggestVirtualKeyboardLocationMETA_ptr(keyboard, locationInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVirtualKeyboardScaleMETADelegate(XrVirtualKeyboardMETA keyboard, float* scale);
		private static xrGetVirtualKeyboardScaleMETADelegate xrGetVirtualKeyboardScaleMETA_ptr;
		public static XrResult xrGetVirtualKeyboardScaleMETA(XrVirtualKeyboardMETA keyboard, float* scale)
			=> xrGetVirtualKeyboardScaleMETA_ptr(keyboard, scale);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetVirtualKeyboardModelVisibilityMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility);
		private static xrSetVirtualKeyboardModelVisibilityMETADelegate xrSetVirtualKeyboardModelVisibilityMETA_ptr;
		public static XrResult xrSetVirtualKeyboardModelVisibilityMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility)
			=> xrSetVirtualKeyboardModelVisibilityMETA_ptr(keyboard, modelVisibility);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVirtualKeyboardModelAnimationStatesMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates);
		private static xrGetVirtualKeyboardModelAnimationStatesMETADelegate xrGetVirtualKeyboardModelAnimationStatesMETA_ptr;
		public static XrResult xrGetVirtualKeyboardModelAnimationStatesMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates)
			=> xrGetVirtualKeyboardModelAnimationStatesMETA_ptr(keyboard, animationStates);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVirtualKeyboardDirtyTexturesMETADelegate(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds);
		private static xrGetVirtualKeyboardDirtyTexturesMETADelegate xrGetVirtualKeyboardDirtyTexturesMETA_ptr;
		public static XrResult xrGetVirtualKeyboardDirtyTexturesMETA(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds)
			=> xrGetVirtualKeyboardDirtyTexturesMETA_ptr(keyboard, textureIdCapacityInput, textureIdCountOutput, textureIds);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetVirtualKeyboardTextureDataMETADelegate(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData);
		private static xrGetVirtualKeyboardTextureDataMETADelegate xrGetVirtualKeyboardTextureDataMETA_ptr;
		public static XrResult xrGetVirtualKeyboardTextureDataMETA(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData)
			=> xrGetVirtualKeyboardTextureDataMETA_ptr(keyboard, textureId, textureData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSendVirtualKeyboardInputMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose);
		private static xrSendVirtualKeyboardInputMETADelegate xrSendVirtualKeyboardInputMETA_ptr;
		public static XrResult xrSendVirtualKeyboardInputMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose)
			=> xrSendVirtualKeyboardInputMETA_ptr(keyboard, info, interactorRootPose);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrChangeVirtualKeyboardTextContextMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo);
		private static xrChangeVirtualKeyboardTextContextMETADelegate xrChangeVirtualKeyboardTextContextMETA_ptr;
		public static XrResult xrChangeVirtualKeyboardTextContextMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo)
			=> xrChangeVirtualKeyboardTextContextMETA_ptr(keyboard, changeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateExternalCamerasOCULUSDelegate(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras);
		private static xrEnumerateExternalCamerasOCULUSDelegate xrEnumerateExternalCamerasOCULUS_ptr;
		public static XrResult xrEnumerateExternalCamerasOCULUS(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras)
			=> xrEnumerateExternalCamerasOCULUS_ptr(session, cameraCapacityInput, cameraCountOutput, cameras);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumeratePerformanceMetricsCounterPathsMETADelegate(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths);
		private static xrEnumeratePerformanceMetricsCounterPathsMETADelegate xrEnumeratePerformanceMetricsCounterPathsMETA_ptr;
		public static XrResult xrEnumeratePerformanceMetricsCounterPathsMETA(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths)
			=> xrEnumeratePerformanceMetricsCounterPathsMETA_ptr(instance, counterPathCapacityInput, counterPathCountOutput, counterPaths);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetPerformanceMetricsStateMETADelegate(XrSession session, XrPerformanceMetricsStateMETA* state);
		private static xrSetPerformanceMetricsStateMETADelegate xrSetPerformanceMetricsStateMETA_ptr;
		public static XrResult xrSetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
			=> xrSetPerformanceMetricsStateMETA_ptr(session, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetPerformanceMetricsStateMETADelegate(XrSession session, XrPerformanceMetricsStateMETA* state);
		private static xrGetPerformanceMetricsStateMETADelegate xrGetPerformanceMetricsStateMETA_ptr;
		public static XrResult xrGetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
			=> xrGetPerformanceMetricsStateMETA_ptr(session, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQueryPerformanceMetricsCounterMETADelegate(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter);
		private static xrQueryPerformanceMetricsCounterMETADelegate xrQueryPerformanceMetricsCounterMETA_ptr;
		public static XrResult xrQueryPerformanceMetricsCounterMETA(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter)
			=> xrQueryPerformanceMetricsCounterMETA_ptr(session, counterPath, counter);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSaveSpaceListFBDelegate(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId);
		private static xrSaveSpaceListFBDelegate xrSaveSpaceListFB_ptr;
		public static XrResult xrSaveSpaceListFB(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId)
			=> xrSaveSpaceListFB_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpaceUserFBDelegate(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user);
		private static xrCreateSpaceUserFBDelegate xrCreateSpaceUserFB_ptr;
		public static XrResult xrCreateSpaceUserFB(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user)
			=> xrCreateSpaceUserFB_ptr(session, info, user);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceUserIdFBDelegate(XrSpaceUserFB user, ulong* userId);
		private static xrGetSpaceUserIdFBDelegate xrGetSpaceUserIdFB_ptr;
		public static XrResult xrGetSpaceUserIdFB(XrSpaceUserFB user, ulong* userId)
			=> xrGetSpaceUserIdFB_ptr(user, userId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpaceUserFBDelegate(XrSpaceUserFB user);
		private static xrDestroySpaceUserFBDelegate xrDestroySpaceUserFB_ptr;
		public static XrResult xrDestroySpaceUserFB(XrSpaceUserFB user)
			=> xrDestroySpaceUserFB_ptr(user);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDiscoverSpacesMETADelegate(XrSession session, XrSpaceDiscoveryInfoMETA* info, ulong* requestId);
		private static xrDiscoverSpacesMETADelegate xrDiscoverSpacesMETA_ptr;
		public static XrResult xrDiscoverSpacesMETA(XrSession session, XrSpaceDiscoveryInfoMETA* info, ulong* requestId)
			=> xrDiscoverSpacesMETA_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRetrieveSpaceDiscoveryResultsMETADelegate(XrSession session, ulong requestId, XrSpaceDiscoveryResultsMETA* results);
		private static xrRetrieveSpaceDiscoveryResultsMETADelegate xrRetrieveSpaceDiscoveryResultsMETA_ptr;
		public static XrResult xrRetrieveSpaceDiscoveryResultsMETA(XrSession session, ulong requestId, XrSpaceDiscoveryResultsMETA* results)
			=> xrRetrieveSpaceDiscoveryResultsMETA_ptr(session, requestId, results);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRecommendedLayerResolutionMETADelegate(XrSession session, XrRecommendedLayerResolutionGetInfoMETA* info, XrRecommendedLayerResolutionMETA* resolution);
		private static xrGetRecommendedLayerResolutionMETADelegate xrGetRecommendedLayerResolutionMETA_ptr;
		public static XrResult xrGetRecommendedLayerResolutionMETA(XrSession session, XrRecommendedLayerResolutionGetInfoMETA* info, XrRecommendedLayerResolutionMETA* resolution)
			=> xrGetRecommendedLayerResolutionMETA_ptr(session, info, resolution);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSaveSpacesMETADelegate(XrSession session, XrSpacesSaveInfoMETA* info, ulong* requestId);
		private static xrSaveSpacesMETADelegate xrSaveSpacesMETA_ptr;
		public static XrResult xrSaveSpacesMETA(XrSession session, XrSpacesSaveInfoMETA* info, ulong* requestId)
			=> xrSaveSpacesMETA_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEraseSpacesMETADelegate(XrSession session, XrSpacesEraseInfoMETA* info, ulong* requestId);
		private static xrEraseSpacesMETADelegate xrEraseSpacesMETA_ptr;
		public static XrResult xrEraseSpacesMETA(XrSession session, XrSpacesEraseInfoMETA* info, ulong* requestId)
			=> xrEraseSpacesMETA_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreatePassthroughColorLutMETADelegate(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut);
		private static xrCreatePassthroughColorLutMETADelegate xrCreatePassthroughColorLutMETA_ptr;
		public static XrResult xrCreatePassthroughColorLutMETA(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut)
			=> xrCreatePassthroughColorLutMETA_ptr(passthrough, createInfo, colorLut);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyPassthroughColorLutMETADelegate(XrPassthroughColorLutMETA colorLut);
		private static xrDestroyPassthroughColorLutMETADelegate xrDestroyPassthroughColorLutMETA_ptr;
		public static XrResult xrDestroyPassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut)
			=> xrDestroyPassthroughColorLutMETA_ptr(colorLut);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUpdatePassthroughColorLutMETADelegate(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo);
		private static xrUpdatePassthroughColorLutMETADelegate xrUpdatePassthroughColorLutMETA_ptr;
		public static XrResult xrUpdatePassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo)
			=> xrUpdatePassthroughColorLutMETA_ptr(colorLut, updateInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpaceTriangleMeshMETADelegate(XrSpace space, XrSpaceTriangleMeshGetInfoMETA* getInfo, XrSpaceTriangleMeshMETA* triangleMeshOutput);
		private static xrGetSpaceTriangleMeshMETADelegate xrGetSpaceTriangleMeshMETA_ptr;
		public static XrResult xrGetSpaceTriangleMeshMETA(XrSpace space, XrSpaceTriangleMeshGetInfoMETA* getInfo, XrSpaceTriangleMeshMETA* triangleMeshOutput)
			=> xrGetSpaceTriangleMeshMETA_ptr(space, getInfo, triangleMeshOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSuggestBodyTrackingCalibrationOverrideMETADelegate(XrBodyTrackerFB bodyTracker, XrBodyTrackingCalibrationInfoMETA* calibrationInfo);
		private static xrSuggestBodyTrackingCalibrationOverrideMETADelegate xrSuggestBodyTrackingCalibrationOverrideMETA_ptr;
		public static XrResult xrSuggestBodyTrackingCalibrationOverrideMETA(XrBodyTrackerFB bodyTracker, XrBodyTrackingCalibrationInfoMETA* calibrationInfo)
			=> xrSuggestBodyTrackingCalibrationOverrideMETA_ptr(bodyTracker, calibrationInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrResetBodyTrackingCalibrationMETADelegate(XrBodyTrackerFB bodyTracker);
		private static xrResetBodyTrackingCalibrationMETADelegate xrResetBodyTrackingCalibrationMETA_ptr;
		public static XrResult xrResetBodyTrackingCalibrationMETA(XrBodyTrackerFB bodyTracker)
			=> xrResetBodyTrackingCalibrationMETA_ptr(bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateFaceTracker2FBDelegate(XrSession session, XrFaceTrackerCreateInfo2FB* createInfo, XrFaceTracker2FB* faceTracker);
		private static xrCreateFaceTracker2FBDelegate xrCreateFaceTracker2FB_ptr;
		public static XrResult xrCreateFaceTracker2FB(XrSession session, XrFaceTrackerCreateInfo2FB* createInfo, XrFaceTracker2FB* faceTracker)
			=> xrCreateFaceTracker2FB_ptr(session, createInfo, faceTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyFaceTracker2FBDelegate(XrFaceTracker2FB faceTracker);
		private static xrDestroyFaceTracker2FBDelegate xrDestroyFaceTracker2FB_ptr;
		public static XrResult xrDestroyFaceTracker2FB(XrFaceTracker2FB faceTracker)
			=> xrDestroyFaceTracker2FB_ptr(faceTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetFaceExpressionWeights2FBDelegate(XrFaceTracker2FB faceTracker, XrFaceExpressionInfo2FB* expressionInfo, XrFaceExpressionWeights2FB* expressionWeights);
		private static xrGetFaceExpressionWeights2FBDelegate xrGetFaceExpressionWeights2FB_ptr;
		public static XrResult xrGetFaceExpressionWeights2FB(XrFaceTracker2FB faceTracker, XrFaceExpressionInfo2FB* expressionInfo, XrFaceExpressionWeights2FB* expressionWeights)
			=> xrGetFaceExpressionWeights2FB_ptr(faceTracker, expressionInfo, expressionWeights);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrShareSpacesMETADelegate(XrSession session, XrShareSpacesInfoMETA* info, ulong* requestId);
		private static xrShareSpacesMETADelegate xrShareSpacesMETA_ptr;
		public static XrResult xrShareSpacesMETA(XrSession session, XrShareSpacesInfoMETA* info, ulong* requestId)
			=> xrShareSpacesMETA_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateEnvironmentDepthProviderMETADelegate(XrSession session, XrEnvironmentDepthProviderCreateInfoMETA* createInfo, XrEnvironmentDepthProviderMETA* environmentDepthProvider);
		private static xrCreateEnvironmentDepthProviderMETADelegate xrCreateEnvironmentDepthProviderMETA_ptr;
		public static XrResult xrCreateEnvironmentDepthProviderMETA(XrSession session, XrEnvironmentDepthProviderCreateInfoMETA* createInfo, XrEnvironmentDepthProviderMETA* environmentDepthProvider)
			=> xrCreateEnvironmentDepthProviderMETA_ptr(session, createInfo, environmentDepthProvider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyEnvironmentDepthProviderMETADelegate(XrEnvironmentDepthProviderMETA environmentDepthProvider);
		private static xrDestroyEnvironmentDepthProviderMETADelegate xrDestroyEnvironmentDepthProviderMETA_ptr;
		public static XrResult xrDestroyEnvironmentDepthProviderMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider)
			=> xrDestroyEnvironmentDepthProviderMETA_ptr(environmentDepthProvider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStartEnvironmentDepthProviderMETADelegate(XrEnvironmentDepthProviderMETA environmentDepthProvider);
		private static xrStartEnvironmentDepthProviderMETADelegate xrStartEnvironmentDepthProviderMETA_ptr;
		public static XrResult xrStartEnvironmentDepthProviderMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider)
			=> xrStartEnvironmentDepthProviderMETA_ptr(environmentDepthProvider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStopEnvironmentDepthProviderMETADelegate(XrEnvironmentDepthProviderMETA environmentDepthProvider);
		private static xrStopEnvironmentDepthProviderMETADelegate xrStopEnvironmentDepthProviderMETA_ptr;
		public static XrResult xrStopEnvironmentDepthProviderMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider)
			=> xrStopEnvironmentDepthProviderMETA_ptr(environmentDepthProvider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateEnvironmentDepthSwapchainMETADelegate(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthSwapchainCreateInfoMETA* createInfo, XrEnvironmentDepthSwapchainMETA* swapchain);
		private static xrCreateEnvironmentDepthSwapchainMETADelegate xrCreateEnvironmentDepthSwapchainMETA_ptr;
		public static XrResult xrCreateEnvironmentDepthSwapchainMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthSwapchainCreateInfoMETA* createInfo, XrEnvironmentDepthSwapchainMETA* swapchain)
			=> xrCreateEnvironmentDepthSwapchainMETA_ptr(environmentDepthProvider, createInfo, swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyEnvironmentDepthSwapchainMETADelegate(XrEnvironmentDepthSwapchainMETA swapchain);
		private static xrDestroyEnvironmentDepthSwapchainMETADelegate xrDestroyEnvironmentDepthSwapchainMETA_ptr;
		public static XrResult xrDestroyEnvironmentDepthSwapchainMETA(XrEnvironmentDepthSwapchainMETA swapchain)
			=> xrDestroyEnvironmentDepthSwapchainMETA_ptr(swapchain);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateEnvironmentDepthSwapchainImagesMETADelegate(XrEnvironmentDepthSwapchainMETA swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images);
		private static xrEnumerateEnvironmentDepthSwapchainImagesMETADelegate xrEnumerateEnvironmentDepthSwapchainImagesMETA_ptr;
		public static XrResult xrEnumerateEnvironmentDepthSwapchainImagesMETA(XrEnvironmentDepthSwapchainMETA swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
			=> xrEnumerateEnvironmentDepthSwapchainImagesMETA_ptr(swapchain, imageCapacityInput, imageCountOutput, images);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetEnvironmentDepthSwapchainStateMETADelegate(XrEnvironmentDepthSwapchainMETA swapchain, XrEnvironmentDepthSwapchainStateMETA* state);
		private static xrGetEnvironmentDepthSwapchainStateMETADelegate xrGetEnvironmentDepthSwapchainStateMETA_ptr;
		public static XrResult xrGetEnvironmentDepthSwapchainStateMETA(XrEnvironmentDepthSwapchainMETA swapchain, XrEnvironmentDepthSwapchainStateMETA* state)
			=> xrGetEnvironmentDepthSwapchainStateMETA_ptr(swapchain, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrAcquireEnvironmentDepthImageMETADelegate(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthImageAcquireInfoMETA* acquireInfo, XrEnvironmentDepthImageMETA* environmentDepthImage);
		private static xrAcquireEnvironmentDepthImageMETADelegate xrAcquireEnvironmentDepthImageMETA_ptr;
		public static XrResult xrAcquireEnvironmentDepthImageMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthImageAcquireInfoMETA* acquireInfo, XrEnvironmentDepthImageMETA* environmentDepthImage)
			=> xrAcquireEnvironmentDepthImageMETA_ptr(environmentDepthProvider, acquireInfo, environmentDepthImage);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetEnvironmentDepthHandRemovalMETADelegate(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthHandRemovalSetInfoMETA* setInfo);
		private static xrSetEnvironmentDepthHandRemovalMETADelegate xrSetEnvironmentDepthHandRemovalMETA_ptr;
		public static XrResult xrSetEnvironmentDepthHandRemovalMETA(XrEnvironmentDepthProviderMETA environmentDepthProvider, XrEnvironmentDepthHandRemovalSetInfoMETA* setInfo)
			=> xrSetEnvironmentDepthHandRemovalMETA_ptr(environmentDepthProvider, setInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateRenderModelEXTDelegate(XrSession session, XrRenderModelCreateInfoEXT* createInfo, XrRenderModelEXT* renderModel);
		private static xrCreateRenderModelEXTDelegate xrCreateRenderModelEXT_ptr;
		public static XrResult xrCreateRenderModelEXT(XrSession session, XrRenderModelCreateInfoEXT* createInfo, XrRenderModelEXT* renderModel)
			=> xrCreateRenderModelEXT_ptr(session, createInfo, renderModel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyRenderModelEXTDelegate(XrRenderModelEXT renderModel);
		private static xrDestroyRenderModelEXTDelegate xrDestroyRenderModelEXT_ptr;
		public static XrResult xrDestroyRenderModelEXT(XrRenderModelEXT renderModel)
			=> xrDestroyRenderModelEXT_ptr(renderModel);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRenderModelPropertiesEXTDelegate(XrRenderModelEXT renderModel, XrRenderModelPropertiesGetInfoEXT* getInfo, XrRenderModelPropertiesEXT* properties);
		private static xrGetRenderModelPropertiesEXTDelegate xrGetRenderModelPropertiesEXT_ptr;
		public static XrResult xrGetRenderModelPropertiesEXT(XrRenderModelEXT renderModel, XrRenderModelPropertiesGetInfoEXT* getInfo, XrRenderModelPropertiesEXT* properties)
			=> xrGetRenderModelPropertiesEXT_ptr(renderModel, getInfo, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateRenderModelSpaceEXTDelegate(XrSession session, XrRenderModelSpaceCreateInfoEXT* createInfo, XrSpace* space);
		private static xrCreateRenderModelSpaceEXTDelegate xrCreateRenderModelSpaceEXT_ptr;
		public static XrResult xrCreateRenderModelSpaceEXT(XrSession session, XrRenderModelSpaceCreateInfoEXT* createInfo, XrSpace* space)
			=> xrCreateRenderModelSpaceEXT_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateRenderModelAssetEXTDelegate(XrSession session, XrRenderModelAssetCreateInfoEXT* createInfo, XrRenderModelAssetEXT* asset);
		private static xrCreateRenderModelAssetEXTDelegate xrCreateRenderModelAssetEXT_ptr;
		public static XrResult xrCreateRenderModelAssetEXT(XrSession session, XrRenderModelAssetCreateInfoEXT* createInfo, XrRenderModelAssetEXT* asset)
			=> xrCreateRenderModelAssetEXT_ptr(session, createInfo, asset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyRenderModelAssetEXTDelegate(XrRenderModelAssetEXT asset);
		private static xrDestroyRenderModelAssetEXTDelegate xrDestroyRenderModelAssetEXT_ptr;
		public static XrResult xrDestroyRenderModelAssetEXT(XrRenderModelAssetEXT asset)
			=> xrDestroyRenderModelAssetEXT_ptr(asset);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRenderModelAssetDataEXTDelegate(XrRenderModelAssetEXT asset, XrRenderModelAssetDataGetInfoEXT* getInfo, XrRenderModelAssetDataEXT* buffer);
		private static xrGetRenderModelAssetDataEXTDelegate xrGetRenderModelAssetDataEXT_ptr;
		public static XrResult xrGetRenderModelAssetDataEXT(XrRenderModelAssetEXT asset, XrRenderModelAssetDataGetInfoEXT* getInfo, XrRenderModelAssetDataEXT* buffer)
			=> xrGetRenderModelAssetDataEXT_ptr(asset, getInfo, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRenderModelAssetPropertiesEXTDelegate(XrRenderModelAssetEXT asset, XrRenderModelAssetPropertiesGetInfoEXT* getInfo, XrRenderModelAssetPropertiesEXT* properties);
		private static xrGetRenderModelAssetPropertiesEXTDelegate xrGetRenderModelAssetPropertiesEXT_ptr;
		public static XrResult xrGetRenderModelAssetPropertiesEXT(XrRenderModelAssetEXT asset, XrRenderModelAssetPropertiesGetInfoEXT* getInfo, XrRenderModelAssetPropertiesEXT* properties)
			=> xrGetRenderModelAssetPropertiesEXT_ptr(asset, getInfo, properties);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRenderModelStateEXTDelegate(XrRenderModelEXT renderModel, XrRenderModelStateGetInfoEXT* getInfo, XrRenderModelStateEXT* state);
		private static xrGetRenderModelStateEXTDelegate xrGetRenderModelStateEXT_ptr;
		public static XrResult xrGetRenderModelStateEXT(XrRenderModelEXT renderModel, XrRenderModelStateGetInfoEXT* getInfo, XrRenderModelStateEXT* state)
			=> xrGetRenderModelStateEXT_ptr(renderModel, getInfo, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateInteractionRenderModelIdsEXTDelegate(XrSession session, XrInteractionRenderModelIdsEnumerateInfoEXT* getInfo, uint renderModelIdCapacityInput, uint* renderModelIdCountOutput, ulong* renderModelIds);
		private static xrEnumerateInteractionRenderModelIdsEXTDelegate xrEnumerateInteractionRenderModelIdsEXT_ptr;
		public static XrResult xrEnumerateInteractionRenderModelIdsEXT(XrSession session, XrInteractionRenderModelIdsEnumerateInfoEXT* getInfo, uint renderModelIdCapacityInput, uint* renderModelIdCountOutput, ulong* renderModelIds)
			=> xrEnumerateInteractionRenderModelIdsEXT_ptr(session, getInfo, renderModelIdCapacityInput, renderModelIdCountOutput, renderModelIds);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateRenderModelSubactionPathsEXTDelegate(XrRenderModelEXT renderModel, XrInteractionRenderModelSubactionPathInfoEXT* info, uint pathCapacityInput, uint* pathCountOutput, ulong* paths);
		private static xrEnumerateRenderModelSubactionPathsEXTDelegate xrEnumerateRenderModelSubactionPathsEXT_ptr;
		public static XrResult xrEnumerateRenderModelSubactionPathsEXT(XrRenderModelEXT renderModel, XrInteractionRenderModelSubactionPathInfoEXT* info, uint pathCapacityInput, uint* pathCountOutput, ulong* paths)
			=> xrEnumerateRenderModelSubactionPathsEXT_ptr(renderModel, info, pathCapacityInput, pathCountOutput, paths);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetRenderModelPoseTopLevelUserPathEXTDelegate(XrRenderModelEXT renderModel, XrInteractionRenderModelTopLevelUserPathGetInfoEXT* info, ulong* topLevelUserPath);
		private static xrGetRenderModelPoseTopLevelUserPathEXTDelegate xrGetRenderModelPoseTopLevelUserPathEXT_ptr;
		public static XrResult xrGetRenderModelPoseTopLevelUserPathEXT(XrRenderModelEXT renderModel, XrInteractionRenderModelTopLevelUserPathGetInfoEXT* info, ulong* topLevelUserPath)
			=> xrGetRenderModelPoseTopLevelUserPathEXT_ptr(renderModel, info, topLevelUserPath);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetTrackingOptimizationSettingsHintQCOMDelegate(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint);
		private static xrSetTrackingOptimizationSettingsHintQCOMDelegate xrSetTrackingOptimizationSettingsHintQCOM_ptr;
		public static XrResult xrSetTrackingOptimizationSettingsHintQCOM(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint)
			=> xrSetTrackingOptimizationSettingsHintQCOM_ptr(session, domain, hint);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreatePassthroughHTCDelegate(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough);
		private static xrCreatePassthroughHTCDelegate xrCreatePassthroughHTC_ptr;
		public static XrResult xrCreatePassthroughHTC(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough)
			=> xrCreatePassthroughHTC_ptr(session, createInfo, passthrough);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyPassthroughHTCDelegate(XrPassthroughHTC passthrough);
		private static xrDestroyPassthroughHTCDelegate xrDestroyPassthroughHTC_ptr;
		public static XrResult xrDestroyPassthroughHTC(XrPassthroughHTC passthrough)
			=> xrDestroyPassthroughHTC_ptr(passthrough);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrApplyFoveationHTCDelegate(XrSession session, XrFoveationApplyInfoHTC* applyInfo);
		private static xrApplyFoveationHTCDelegate xrApplyFoveationHTC_ptr;
		public static XrResult xrApplyFoveationHTC(XrSession session, XrFoveationApplyInfoHTC* applyInfo)
			=> xrApplyFoveationHTC_ptr(session, applyInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorHTCDelegate(XrSession session, XrSpatialAnchorCreateInfoHTC* createInfo, XrSpace* anchor);
		private static xrCreateSpatialAnchorHTCDelegate xrCreateSpatialAnchorHTC_ptr;
		public static XrResult xrCreateSpatialAnchorHTC(XrSession session, XrSpatialAnchorCreateInfoHTC* createInfo, XrSpace* anchor)
			=> xrCreateSpatialAnchorHTC_ptr(session, createInfo, anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialAnchorNameHTCDelegate(XrSpace anchor, XrSpatialAnchorNameHTC* name);
		private static xrGetSpatialAnchorNameHTCDelegate xrGetSpatialAnchorNameHTC_ptr;
		public static XrResult xrGetSpatialAnchorNameHTC(XrSpace anchor, XrSpatialAnchorNameHTC* name)
			=> xrGetSpatialAnchorNameHTC_ptr(anchor, name);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateBodyTrackerHTCDelegate(XrSession session, XrBodyTrackerCreateInfoHTC* createInfo, XrBodyTrackerHTC* bodyTracker);
		private static xrCreateBodyTrackerHTCDelegate xrCreateBodyTrackerHTC_ptr;
		public static XrResult xrCreateBodyTrackerHTC(XrSession session, XrBodyTrackerCreateInfoHTC* createInfo, XrBodyTrackerHTC* bodyTracker)
			=> xrCreateBodyTrackerHTC_ptr(session, createInfo, bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyBodyTrackerHTCDelegate(XrBodyTrackerHTC bodyTracker);
		private static xrDestroyBodyTrackerHTCDelegate xrDestroyBodyTrackerHTC_ptr;
		public static XrResult xrDestroyBodyTrackerHTC(XrBodyTrackerHTC bodyTracker)
			=> xrDestroyBodyTrackerHTC_ptr(bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateBodyJointsHTCDelegate(XrBodyTrackerHTC bodyTracker, XrBodyJointsLocateInfoHTC* locateInfo, XrBodyJointLocationsHTC* locations);
		private static xrLocateBodyJointsHTCDelegate xrLocateBodyJointsHTC_ptr;
		public static XrResult xrLocateBodyJointsHTC(XrBodyTrackerHTC bodyTracker, XrBodyJointsLocateInfoHTC* locateInfo, XrBodyJointLocationsHTC* locations)
			=> xrLocateBodyJointsHTC_ptr(bodyTracker, locateInfo, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetBodySkeletonHTCDelegate(XrBodyTrackerHTC bodyTracker, XrSpace baseSpace, uint skeletonGenerationId, XrBodySkeletonHTC* skeleton);
		private static xrGetBodySkeletonHTCDelegate xrGetBodySkeletonHTC_ptr;
		public static XrResult xrGetBodySkeletonHTC(XrBodyTrackerHTC bodyTracker, XrSpace baseSpace, uint skeletonGenerationId, XrBodySkeletonHTC* skeleton)
			=> xrGetBodySkeletonHTC_ptr(bodyTracker, baseSpace, skeletonGenerationId, skeleton);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrApplyForceFeedbackCurlMNDXDelegate(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations);
		private static xrApplyForceFeedbackCurlMNDXDelegate xrApplyForceFeedbackCurlMNDX_ptr;
		public static XrResult xrApplyForceFeedbackCurlMNDX(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations)
			=> xrApplyForceFeedbackCurlMNDX_ptr(handTracker, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateBodyTrackerBDDelegate(XrSession session, XrBodyTrackerCreateInfoBD* createInfo, XrBodyTrackerBD* bodyTracker);
		private static xrCreateBodyTrackerBDDelegate xrCreateBodyTrackerBD_ptr;
		public static XrResult xrCreateBodyTrackerBD(XrSession session, XrBodyTrackerCreateInfoBD* createInfo, XrBodyTrackerBD* bodyTracker)
			=> xrCreateBodyTrackerBD_ptr(session, createInfo, bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyBodyTrackerBDDelegate(XrBodyTrackerBD bodyTracker);
		private static xrDestroyBodyTrackerBDDelegate xrDestroyBodyTrackerBD_ptr;
		public static XrResult xrDestroyBodyTrackerBD(XrBodyTrackerBD bodyTracker)
			=> xrDestroyBodyTrackerBD_ptr(bodyTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrLocateBodyJointsBDDelegate(XrBodyTrackerBD bodyTracker, XrBodyJointsLocateInfoBD* locateInfo, XrBodyJointLocationsBD* locations);
		private static xrLocateBodyJointsBDDelegate xrLocateBodyJointsBD_ptr;
		public static XrResult xrLocateBodyJointsBD(XrBodyTrackerBD bodyTracker, XrBodyJointsLocateInfoBD* locateInfo, XrBodyJointLocationsBD* locations)
			=> xrLocateBodyJointsBD_ptr(bodyTracker, locateInfo, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSpatialEntityComponentTypesBDDelegate(XrSenseDataSnapshotBD snapshot, ulong entityId, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpatialEntityComponentTypeBD* componentTypes);
		private static xrEnumerateSpatialEntityComponentTypesBDDelegate xrEnumerateSpatialEntityComponentTypesBD_ptr;
		public static XrResult xrEnumerateSpatialEntityComponentTypesBD(XrSenseDataSnapshotBD snapshot, ulong entityId, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpatialEntityComponentTypeBD* componentTypes)
			=> xrEnumerateSpatialEntityComponentTypesBD_ptr(snapshot, entityId, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialEntityUuidBDDelegate(XrSenseDataSnapshotBD snapshot, ulong entityId, XrUuid* uuid);
		private static xrGetSpatialEntityUuidBDDelegate xrGetSpatialEntityUuidBD_ptr;
		public static XrResult xrGetSpatialEntityUuidBD(XrSenseDataSnapshotBD snapshot, ulong entityId, XrUuid* uuid)
			=> xrGetSpatialEntityUuidBD_ptr(snapshot, entityId, uuid);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialEntityComponentDataBDDelegate(XrSenseDataSnapshotBD snapshot, XrSpatialEntityComponentGetInfoBD* getInfo, XrSpatialEntityComponentDataBaseHeaderBD* componentData);
		private static xrGetSpatialEntityComponentDataBDDelegate xrGetSpatialEntityComponentDataBD_ptr;
		public static XrResult xrGetSpatialEntityComponentDataBD(XrSenseDataSnapshotBD snapshot, XrSpatialEntityComponentGetInfoBD* getInfo, XrSpatialEntityComponentDataBaseHeaderBD* componentData)
			=> xrGetSpatialEntityComponentDataBD_ptr(snapshot, getInfo, componentData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSenseDataProviderBDDelegate(XrSession session, XrSenseDataProviderCreateInfoBD* createInfo, XrSenseDataProviderBD* provider);
		private static xrCreateSenseDataProviderBDDelegate xrCreateSenseDataProviderBD_ptr;
		public static XrResult xrCreateSenseDataProviderBD(XrSession session, XrSenseDataProviderCreateInfoBD* createInfo, XrSenseDataProviderBD* provider)
			=> xrCreateSenseDataProviderBD_ptr(session, createInfo, provider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStartSenseDataProviderAsyncBDDelegate(XrSenseDataProviderBD provider, XrSenseDataProviderStartInfoBD* startInfo, ulong* future);
		private static xrStartSenseDataProviderAsyncBDDelegate xrStartSenseDataProviderAsyncBD_ptr;
		public static XrResult xrStartSenseDataProviderAsyncBD(XrSenseDataProviderBD provider, XrSenseDataProviderStartInfoBD* startInfo, ulong* future)
			=> xrStartSenseDataProviderAsyncBD_ptr(provider, startInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStartSenseDataProviderCompleteBDDelegate(XrSession session, ulong future, XrFutureCompletionEXT* completion);
		private static xrStartSenseDataProviderCompleteBDDelegate xrStartSenseDataProviderCompleteBD_ptr;
		public static XrResult xrStartSenseDataProviderCompleteBD(XrSession session, ulong future, XrFutureCompletionEXT* completion)
			=> xrStartSenseDataProviderCompleteBD_ptr(session, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSenseDataProviderStateBDDelegate(XrSenseDataProviderBD provider, XrSenseDataProviderStateBD* state);
		private static xrGetSenseDataProviderStateBDDelegate xrGetSenseDataProviderStateBD_ptr;
		public static XrResult xrGetSenseDataProviderStateBD(XrSenseDataProviderBD provider, XrSenseDataProviderStateBD* state)
			=> xrGetSenseDataProviderStateBD_ptr(provider, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySenseDataAsyncBDDelegate(XrSenseDataProviderBD provider, XrSenseDataQueryInfoBD* queryInfo, ulong* future);
		private static xrQuerySenseDataAsyncBDDelegate xrQuerySenseDataAsyncBD_ptr;
		public static XrResult xrQuerySenseDataAsyncBD(XrSenseDataProviderBD provider, XrSenseDataQueryInfoBD* queryInfo, ulong* future)
			=> xrQuerySenseDataAsyncBD_ptr(provider, queryInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySenseDataCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrSenseDataQueryCompletionBD* completion);
		private static xrQuerySenseDataCompleteBDDelegate xrQuerySenseDataCompleteBD_ptr;
		public static XrResult xrQuerySenseDataCompleteBD(XrSenseDataProviderBD provider, ulong future, XrSenseDataQueryCompletionBD* completion)
			=> xrQuerySenseDataCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySenseDataSnapshotBDDelegate(XrSenseDataSnapshotBD snapshot);
		private static xrDestroySenseDataSnapshotBDDelegate xrDestroySenseDataSnapshotBD_ptr;
		public static XrResult xrDestroySenseDataSnapshotBD(XrSenseDataSnapshotBD snapshot)
			=> xrDestroySenseDataSnapshotBD_ptr(snapshot);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetQueriedSenseDataBDDelegate(XrSenseDataSnapshotBD snapshot, XrQueriedSenseDataGetInfoBD* getInfo, XrQueriedSenseDataBD* queriedSenseData);
		private static xrGetQueriedSenseDataBDDelegate xrGetQueriedSenseDataBD_ptr;
		public static XrResult xrGetQueriedSenseDataBD(XrSenseDataSnapshotBD snapshot, XrQueriedSenseDataGetInfoBD* getInfo, XrQueriedSenseDataBD* queriedSenseData)
			=> xrGetQueriedSenseDataBD_ptr(snapshot, getInfo, queriedSenseData);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStopSenseDataProviderBDDelegate(XrSenseDataProviderBD provider);
		private static xrStopSenseDataProviderBDDelegate xrStopSenseDataProviderBD_ptr;
		public static XrResult xrStopSenseDataProviderBD(XrSenseDataProviderBD provider)
			=> xrStopSenseDataProviderBD_ptr(provider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySenseDataProviderBDDelegate(XrSenseDataProviderBD provider);
		private static xrDestroySenseDataProviderBDDelegate xrDestroySenseDataProviderBD_ptr;
		public static XrResult xrDestroySenseDataProviderBD(XrSenseDataProviderBD provider)
			=> xrDestroySenseDataProviderBD_ptr(provider);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialEntityAnchorBDDelegate(XrSenseDataProviderBD provider, XrSpatialEntityAnchorCreateInfoBD* createInfo, XrAnchorBD* anchor);
		private static xrCreateSpatialEntityAnchorBDDelegate xrCreateSpatialEntityAnchorBD_ptr;
		public static XrResult xrCreateSpatialEntityAnchorBD(XrSenseDataProviderBD provider, XrSpatialEntityAnchorCreateInfoBD* createInfo, XrAnchorBD* anchor)
			=> xrCreateSpatialEntityAnchorBD_ptr(provider, createInfo, anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyAnchorBDDelegate(XrAnchorBD anchor);
		private static xrDestroyAnchorBDDelegate xrDestroyAnchorBD_ptr;
		public static XrResult xrDestroyAnchorBD(XrAnchorBD anchor)
			=> xrDestroyAnchorBD_ptr(anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetAnchorUuidBDDelegate(XrAnchorBD anchor, XrUuid* uuid);
		private static xrGetAnchorUuidBDDelegate xrGetAnchorUuidBD_ptr;
		public static XrResult xrGetAnchorUuidBD(XrAnchorBD anchor, XrUuid* uuid)
			=> xrGetAnchorUuidBD_ptr(anchor, uuid);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateAnchorSpaceBDDelegate(XrSession session, XrAnchorSpaceCreateInfoBD* createInfo, XrSpace* space);
		private static xrCreateAnchorSpaceBDDelegate xrCreateAnchorSpaceBD_ptr;
		public static XrResult xrCreateAnchorSpaceBD(XrSession session, XrAnchorSpaceCreateInfoBD* createInfo, XrSpace* space)
			=> xrCreateAnchorSpaceBD_ptr(session, createInfo, space);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorAsyncBDDelegate(XrSenseDataProviderBD provider, XrSpatialAnchorCreateInfoBD* info, ulong* future);
		private static xrCreateSpatialAnchorAsyncBDDelegate xrCreateSpatialAnchorAsyncBD_ptr;
		public static XrResult xrCreateSpatialAnchorAsyncBD(XrSenseDataProviderBD provider, XrSpatialAnchorCreateInfoBD* info, ulong* future)
			=> xrCreateSpatialAnchorAsyncBD_ptr(provider, info, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrSpatialAnchorCreateCompletionBD* completion);
		private static xrCreateSpatialAnchorCompleteBDDelegate xrCreateSpatialAnchorCompleteBD_ptr;
		public static XrResult xrCreateSpatialAnchorCompleteBD(XrSenseDataProviderBD provider, ulong future, XrSpatialAnchorCreateCompletionBD* completion)
			=> xrCreateSpatialAnchorCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPersistSpatialAnchorAsyncBDDelegate(XrSenseDataProviderBD provider, XrSpatialAnchorPersistInfoBD* info, ulong* future);
		private static xrPersistSpatialAnchorAsyncBDDelegate xrPersistSpatialAnchorAsyncBD_ptr;
		public static XrResult xrPersistSpatialAnchorAsyncBD(XrSenseDataProviderBD provider, XrSpatialAnchorPersistInfoBD* info, ulong* future)
			=> xrPersistSpatialAnchorAsyncBD_ptr(provider, info, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPersistSpatialAnchorCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion);
		private static xrPersistSpatialAnchorCompleteBDDelegate xrPersistSpatialAnchorCompleteBD_ptr;
		public static XrResult xrPersistSpatialAnchorCompleteBD(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion)
			=> xrPersistSpatialAnchorCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnpersistSpatialAnchorAsyncBDDelegate(XrSenseDataProviderBD provider, XrSpatialAnchorUnpersistInfoBD* info, ulong* future);
		private static xrUnpersistSpatialAnchorAsyncBDDelegate xrUnpersistSpatialAnchorAsyncBD_ptr;
		public static XrResult xrUnpersistSpatialAnchorAsyncBD(XrSenseDataProviderBD provider, XrSpatialAnchorUnpersistInfoBD* info, ulong* future)
			=> xrUnpersistSpatialAnchorAsyncBD_ptr(provider, info, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnpersistSpatialAnchorCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion);
		private static xrUnpersistSpatialAnchorCompleteBDDelegate xrUnpersistSpatialAnchorCompleteBD_ptr;
		public static XrResult xrUnpersistSpatialAnchorCompleteBD(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion)
			=> xrUnpersistSpatialAnchorCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrShareSpatialAnchorAsyncBDDelegate(XrSenseDataProviderBD provider, XrSpatialAnchorShareInfoBD* info, ulong* future);
		private static xrShareSpatialAnchorAsyncBDDelegate xrShareSpatialAnchorAsyncBD_ptr;
		public static XrResult xrShareSpatialAnchorAsyncBD(XrSenseDataProviderBD provider, XrSpatialAnchorShareInfoBD* info, ulong* future)
			=> xrShareSpatialAnchorAsyncBD_ptr(provider, info, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrShareSpatialAnchorCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion);
		private static xrShareSpatialAnchorCompleteBDDelegate xrShareSpatialAnchorCompleteBD_ptr;
		public static XrResult xrShareSpatialAnchorCompleteBD(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion)
			=> xrShareSpatialAnchorCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDownloadSharedSpatialAnchorAsyncBDDelegate(XrSenseDataProviderBD provider, XrSharedSpatialAnchorDownloadInfoBD* info, ulong* future);
		private static xrDownloadSharedSpatialAnchorAsyncBDDelegate xrDownloadSharedSpatialAnchorAsyncBD_ptr;
		public static XrResult xrDownloadSharedSpatialAnchorAsyncBD(XrSenseDataProviderBD provider, XrSharedSpatialAnchorDownloadInfoBD* info, ulong* future)
			=> xrDownloadSharedSpatialAnchorAsyncBD_ptr(provider, info, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDownloadSharedSpatialAnchorCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion);
		private static xrDownloadSharedSpatialAnchorCompleteBDDelegate xrDownloadSharedSpatialAnchorCompleteBD_ptr;
		public static XrResult xrDownloadSharedSpatialAnchorCompleteBD(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion)
			=> xrDownloadSharedSpatialAnchorCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCaptureSceneAsyncBDDelegate(XrSenseDataProviderBD provider, XrSceneCaptureInfoBD* info, ulong* future);
		private static xrCaptureSceneAsyncBDDelegate xrCaptureSceneAsyncBD_ptr;
		public static XrResult xrCaptureSceneAsyncBD(XrSenseDataProviderBD provider, XrSceneCaptureInfoBD* info, ulong* future)
			=> xrCaptureSceneAsyncBD_ptr(provider, info, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCaptureSceneCompleteBDDelegate(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion);
		private static xrCaptureSceneCompleteBDDelegate xrCaptureSceneCompleteBD_ptr;
		public static XrResult xrCaptureSceneCompleteBD(XrSenseDataProviderBD provider, ulong future, XrFutureCompletionEXT* completion)
			=> xrCaptureSceneCompleteBD_ptr(provider, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreatePlaneDetectorEXTDelegate(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector);
		private static xrCreatePlaneDetectorEXTDelegate xrCreatePlaneDetectorEXT_ptr;
		public static XrResult xrCreatePlaneDetectorEXT(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector)
			=> xrCreatePlaneDetectorEXT_ptr(session, createInfo, planeDetector);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyPlaneDetectorEXTDelegate(XrPlaneDetectorEXT planeDetector);
		private static xrDestroyPlaneDetectorEXTDelegate xrDestroyPlaneDetectorEXT_ptr;
		public static XrResult xrDestroyPlaneDetectorEXT(XrPlaneDetectorEXT planeDetector)
			=> xrDestroyPlaneDetectorEXT_ptr(planeDetector);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrBeginPlaneDetectionEXTDelegate(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo);
		private static xrBeginPlaneDetectionEXTDelegate xrBeginPlaneDetectionEXT_ptr;
		public static XrResult xrBeginPlaneDetectionEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo)
			=> xrBeginPlaneDetectionEXT_ptr(planeDetector, beginInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetPlaneDetectionStateEXTDelegate(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state);
		private static xrGetPlaneDetectionStateEXTDelegate xrGetPlaneDetectionStateEXT_ptr;
		public static XrResult xrGetPlaneDetectionStateEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state)
			=> xrGetPlaneDetectionStateEXT_ptr(planeDetector, state);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetPlaneDetectionsEXTDelegate(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations);
		private static xrGetPlaneDetectionsEXTDelegate xrGetPlaneDetectionsEXT_ptr;
		public static XrResult xrGetPlaneDetectionsEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations)
			=> xrGetPlaneDetectionsEXT_ptr(planeDetector, info, locations);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetPlanePolygonBufferEXTDelegate(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer);
		private static xrGetPlanePolygonBufferEXTDelegate xrGetPlanePolygonBufferEXT_ptr;
		public static XrResult xrGetPlanePolygonBufferEXT(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer)
			=> xrGetPlanePolygonBufferEXT_ptr(planeDetector, planeId, polygonBufferIndex, polygonBuffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSupportedTrackableTypesANDROIDDelegate(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes);
		private static xrEnumerateSupportedTrackableTypesANDROIDDelegate xrEnumerateSupportedTrackableTypesANDROID_ptr;
		public static XrResult xrEnumerateSupportedTrackableTypesANDROID(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes)
			=> xrEnumerateSupportedTrackableTypesANDROID_ptr(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, trackableTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSupportedAnchorTrackableTypesANDROIDDelegate(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes);
		private static xrEnumerateSupportedAnchorTrackableTypesANDROIDDelegate xrEnumerateSupportedAnchorTrackableTypesANDROID_ptr;
		public static XrResult xrEnumerateSupportedAnchorTrackableTypesANDROID(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes)
			=> xrEnumerateSupportedAnchorTrackableTypesANDROID_ptr(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, trackableTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateTrackableTrackerANDROIDDelegate(XrSession session, XrTrackableTrackerCreateInfoANDROID* createInfo, XrTrackableTrackerANDROID* trackableTracker);
		private static xrCreateTrackableTrackerANDROIDDelegate xrCreateTrackableTrackerANDROID_ptr;
		public static XrResult xrCreateTrackableTrackerANDROID(XrSession session, XrTrackableTrackerCreateInfoANDROID* createInfo, XrTrackableTrackerANDROID* trackableTracker)
			=> xrCreateTrackableTrackerANDROID_ptr(session, createInfo, trackableTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyTrackableTrackerANDROIDDelegate(XrTrackableTrackerANDROID trackableTracker);
		private static xrDestroyTrackableTrackerANDROIDDelegate xrDestroyTrackableTrackerANDROID_ptr;
		public static XrResult xrDestroyTrackableTrackerANDROID(XrTrackableTrackerANDROID trackableTracker)
			=> xrDestroyTrackableTrackerANDROID_ptr(trackableTracker);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetAllTrackablesANDROIDDelegate(XrTrackableTrackerANDROID trackableTracker, uint trackableCapacityInput, uint* trackableCountOutput, ulong* trackables);
		private static xrGetAllTrackablesANDROIDDelegate xrGetAllTrackablesANDROID_ptr;
		public static XrResult xrGetAllTrackablesANDROID(XrTrackableTrackerANDROID trackableTracker, uint trackableCapacityInput, uint* trackableCountOutput, ulong* trackables)
			=> xrGetAllTrackablesANDROID_ptr(trackableTracker, trackableCapacityInput, trackableCountOutput, trackables);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetTrackablePlaneANDROIDDelegate(XrTrackableTrackerANDROID trackableTracker, XrTrackableGetInfoANDROID* getInfo, XrTrackablePlaneANDROID* planeOutput);
		private static xrGetTrackablePlaneANDROIDDelegate xrGetTrackablePlaneANDROID_ptr;
		public static XrResult xrGetTrackablePlaneANDROID(XrTrackableTrackerANDROID trackableTracker, XrTrackableGetInfoANDROID* getInfo, XrTrackablePlaneANDROID* planeOutput)
			=> xrGetTrackablePlaneANDROID_ptr(trackableTracker, getInfo, planeOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateAnchorSpaceANDROIDDelegate(XrSession session, XrAnchorSpaceCreateInfoANDROID* createInfo, XrSpace* anchorOutput);
		private static xrCreateAnchorSpaceANDROIDDelegate xrCreateAnchorSpaceANDROID_ptr;
		public static XrResult xrCreateAnchorSpaceANDROID(XrSession session, XrAnchorSpaceCreateInfoANDROID* createInfo, XrSpace* anchorOutput)
			=> xrCreateAnchorSpaceANDROID_ptr(session, createInfo, anchorOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSupportedPersistenceAnchorTypesANDROIDDelegate(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes);
		private static xrEnumerateSupportedPersistenceAnchorTypesANDROIDDelegate xrEnumerateSupportedPersistenceAnchorTypesANDROID_ptr;
		public static XrResult xrEnumerateSupportedPersistenceAnchorTypesANDROID(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes)
			=> xrEnumerateSupportedPersistenceAnchorTypesANDROID_ptr(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, trackableTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateDeviceAnchorPersistenceANDROIDDelegate(XrSession session, XrDeviceAnchorPersistenceCreateInfoANDROID* createInfo, XrDeviceAnchorPersistenceANDROID* outHandle);
		private static xrCreateDeviceAnchorPersistenceANDROIDDelegate xrCreateDeviceAnchorPersistenceANDROID_ptr;
		public static XrResult xrCreateDeviceAnchorPersistenceANDROID(XrSession session, XrDeviceAnchorPersistenceCreateInfoANDROID* createInfo, XrDeviceAnchorPersistenceANDROID* outHandle)
			=> xrCreateDeviceAnchorPersistenceANDROID_ptr(session, createInfo, outHandle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyDeviceAnchorPersistenceANDROIDDelegate(XrDeviceAnchorPersistenceANDROID handle);
		private static xrDestroyDeviceAnchorPersistenceANDROIDDelegate xrDestroyDeviceAnchorPersistenceANDROID_ptr;
		public static XrResult xrDestroyDeviceAnchorPersistenceANDROID(XrDeviceAnchorPersistenceANDROID handle)
			=> xrDestroyDeviceAnchorPersistenceANDROID_ptr(handle);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPersistAnchorANDROIDDelegate(XrDeviceAnchorPersistenceANDROID handle, XrPersistedAnchorSpaceInfoANDROID* persistedInfo, XrUuid* anchorIdOutput);
		private static xrPersistAnchorANDROIDDelegate xrPersistAnchorANDROID_ptr;
		public static XrResult xrPersistAnchorANDROID(XrDeviceAnchorPersistenceANDROID handle, XrPersistedAnchorSpaceInfoANDROID* persistedInfo, XrUuid* anchorIdOutput)
			=> xrPersistAnchorANDROID_ptr(handle, persistedInfo, anchorIdOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetAnchorPersistStateANDROIDDelegate(XrDeviceAnchorPersistenceANDROID handle, XrUuid* anchorId, XrAnchorPersistStateANDROID* persistState);
		private static xrGetAnchorPersistStateANDROIDDelegate xrGetAnchorPersistStateANDROID_ptr;
		public static XrResult xrGetAnchorPersistStateANDROID(XrDeviceAnchorPersistenceANDROID handle, XrUuid* anchorId, XrAnchorPersistStateANDROID* persistState)
			=> xrGetAnchorPersistStateANDROID_ptr(handle, anchorId, persistState);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreatePersistedAnchorSpaceANDROIDDelegate(XrDeviceAnchorPersistenceANDROID handle, XrPersistedAnchorSpaceCreateInfoANDROID* createInfo, XrSpace* anchorOutput);
		private static xrCreatePersistedAnchorSpaceANDROIDDelegate xrCreatePersistedAnchorSpaceANDROID_ptr;
		public static XrResult xrCreatePersistedAnchorSpaceANDROID(XrDeviceAnchorPersistenceANDROID handle, XrPersistedAnchorSpaceCreateInfoANDROID* createInfo, XrSpace* anchorOutput)
			=> xrCreatePersistedAnchorSpaceANDROID_ptr(handle, createInfo, anchorOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumeratePersistedAnchorsANDROIDDelegate(XrDeviceAnchorPersistenceANDROID handle, uint anchorIdCapacityInput, uint* anchorIdCountOutput, XrUuid* anchorIds);
		private static xrEnumeratePersistedAnchorsANDROIDDelegate xrEnumeratePersistedAnchorsANDROID_ptr;
		public static XrResult xrEnumeratePersistedAnchorsANDROID(XrDeviceAnchorPersistenceANDROID handle, uint anchorIdCapacityInput, uint* anchorIdCountOutput, XrUuid* anchorIds)
			=> xrEnumeratePersistedAnchorsANDROID_ptr(handle, anchorIdCapacityInput, anchorIdCountOutput, anchorIds);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnpersistAnchorANDROIDDelegate(XrDeviceAnchorPersistenceANDROID handle, XrUuid* anchorId);
		private static xrUnpersistAnchorANDROIDDelegate xrUnpersistAnchorANDROID_ptr;
		public static XrResult xrUnpersistAnchorANDROID(XrDeviceAnchorPersistenceANDROID handle, XrUuid* anchorId)
			=> xrUnpersistAnchorANDROID_ptr(handle, anchorId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetPassthroughCameraStateANDROIDDelegate(XrSession session, XrPassthroughCameraStateGetInfoANDROID* getInfo, XrPassthroughCameraStateANDROID* cameraStateOutput);
		private static xrGetPassthroughCameraStateANDROIDDelegate xrGetPassthroughCameraStateANDROID_ptr;
		public static XrResult xrGetPassthroughCameraStateANDROID(XrSession session, XrPassthroughCameraStateGetInfoANDROID* getInfo, XrPassthroughCameraStateANDROID* cameraStateOutput)
			=> xrGetPassthroughCameraStateANDROID_ptr(session, getInfo, cameraStateOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateRaycastSupportedTrackableTypesANDROIDDelegate(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes);
		private static xrEnumerateRaycastSupportedTrackableTypesANDROIDDelegate xrEnumerateRaycastSupportedTrackableTypesANDROID_ptr;
		public static XrResult xrEnumerateRaycastSupportedTrackableTypesANDROID(XrInstance instance, ulong systemId, uint trackableTypeCapacityInput, uint* trackableTypeCountOutput, XrTrackableTypeANDROID* trackableTypes)
			=> xrEnumerateRaycastSupportedTrackableTypesANDROID_ptr(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, trackableTypes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRaycastANDROIDDelegate(XrSession session, XrRaycastInfoANDROID* rayInfo, XrRaycastHitResultsANDROID* results);
		private static xrRaycastANDROIDDelegate xrRaycastANDROID_ptr;
		public static XrResult xrRaycastANDROID(XrSession session, XrRaycastInfoANDROID* rayInfo, XrRaycastHitResultsANDROID* results)
			=> xrRaycastANDROID_ptr(session, rayInfo, results);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetTrackableObjectANDROIDDelegate(XrTrackableTrackerANDROID tracker, XrTrackableGetInfoANDROID* getInfo, XrTrackableObjectANDROID* objectOutput);
		private static xrGetTrackableObjectANDROIDDelegate xrGetTrackableObjectANDROID_ptr;
		public static XrResult xrGetTrackableObjectANDROID(XrTrackableTrackerANDROID tracker, XrTrackableGetInfoANDROID* getInfo, XrTrackableObjectANDROID* objectOutput)
			=> xrGetTrackableObjectANDROID_ptr(tracker, getInfo, objectOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPollFutureEXTDelegate(XrInstance instance, XrFuturePollInfoEXT* pollInfo, XrFuturePollResultEXT* pollResult);
		private static xrPollFutureEXTDelegate xrPollFutureEXT_ptr;
		public static XrResult xrPollFutureEXT(XrInstance instance, XrFuturePollInfoEXT* pollInfo, XrFuturePollResultEXT* pollResult)
			=> xrPollFutureEXT_ptr(instance, pollInfo, pollResult);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCancelFutureEXTDelegate(XrInstance instance, XrFutureCancelInfoEXT* cancelInfo);
		private static xrCancelFutureEXTDelegate xrCancelFutureEXT_ptr;
		public static XrResult xrCancelFutureEXT(XrInstance instance, XrFutureCancelInfoEXT* cancelInfo)
			=> xrCancelFutureEXT_ptr(instance, cancelInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetSystemNotificationsMLDelegate(XrInstance instance, XrSystemNotificationsSetInfoML* info);
		private static xrSetSystemNotificationsMLDelegate xrSetSystemNotificationsML_ptr;
		public static XrResult xrSetSystemNotificationsML(XrInstance instance, XrSystemNotificationsSetInfoML* info)
			=> xrSetSystemNotificationsML_ptr(instance, info);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateWorldMeshDetectorMLDelegate(XrSession session, XrWorldMeshDetectorCreateInfoML* createInfo, XrWorldMeshDetectorML* detector);
		private static xrCreateWorldMeshDetectorMLDelegate xrCreateWorldMeshDetectorML_ptr;
		public static XrResult xrCreateWorldMeshDetectorML(XrSession session, XrWorldMeshDetectorCreateInfoML* createInfo, XrWorldMeshDetectorML* detector)
			=> xrCreateWorldMeshDetectorML_ptr(session, createInfo, detector);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyWorldMeshDetectorMLDelegate(XrWorldMeshDetectorML detector);
		private static xrDestroyWorldMeshDetectorMLDelegate xrDestroyWorldMeshDetectorML_ptr;
		public static XrResult xrDestroyWorldMeshDetectorML(XrWorldMeshDetectorML detector)
			=> xrDestroyWorldMeshDetectorML_ptr(detector);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestWorldMeshStateAsyncMLDelegate(XrWorldMeshDetectorML detector, XrWorldMeshStateRequestInfoML* stateRequest, ulong* future);
		private static xrRequestWorldMeshStateAsyncMLDelegate xrRequestWorldMeshStateAsyncML_ptr;
		public static XrResult xrRequestWorldMeshStateAsyncML(XrWorldMeshDetectorML detector, XrWorldMeshStateRequestInfoML* stateRequest, ulong* future)
			=> xrRequestWorldMeshStateAsyncML_ptr(detector, stateRequest, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestWorldMeshStateCompleteMLDelegate(XrWorldMeshDetectorML detector, ulong future, XrWorldMeshStateRequestCompletionML* completion);
		private static xrRequestWorldMeshStateCompleteMLDelegate xrRequestWorldMeshStateCompleteML_ptr;
		public static XrResult xrRequestWorldMeshStateCompleteML(XrWorldMeshDetectorML detector, ulong future, XrWorldMeshStateRequestCompletionML* completion)
			=> xrRequestWorldMeshStateCompleteML_ptr(detector, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetWorldMeshBufferRecommendSizeMLDelegate(XrWorldMeshDetectorML detector, XrWorldMeshBufferRecommendedSizeInfoML* sizeInfo, XrWorldMeshBufferSizeML* size);
		private static xrGetWorldMeshBufferRecommendSizeMLDelegate xrGetWorldMeshBufferRecommendSizeML_ptr;
		public static XrResult xrGetWorldMeshBufferRecommendSizeML(XrWorldMeshDetectorML detector, XrWorldMeshBufferRecommendedSizeInfoML* sizeInfo, XrWorldMeshBufferSizeML* size)
			=> xrGetWorldMeshBufferRecommendSizeML_ptr(detector, sizeInfo, size);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrAllocateWorldMeshBufferMLDelegate(XrWorldMeshDetectorML detector, XrWorldMeshBufferSizeML* size, XrWorldMeshBufferML* buffer);
		private static xrAllocateWorldMeshBufferMLDelegate xrAllocateWorldMeshBufferML_ptr;
		public static XrResult xrAllocateWorldMeshBufferML(XrWorldMeshDetectorML detector, XrWorldMeshBufferSizeML* size, XrWorldMeshBufferML* buffer)
			=> xrAllocateWorldMeshBufferML_ptr(detector, size, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrFreeWorldMeshBufferMLDelegate(XrWorldMeshDetectorML detector, XrWorldMeshBufferML* buffer);
		private static xrFreeWorldMeshBufferMLDelegate xrFreeWorldMeshBufferML_ptr;
		public static XrResult xrFreeWorldMeshBufferML(XrWorldMeshDetectorML detector, XrWorldMeshBufferML* buffer)
			=> xrFreeWorldMeshBufferML_ptr(detector, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestWorldMeshAsyncMLDelegate(XrWorldMeshDetectorML detector, XrWorldMeshGetInfoML* getInfo, XrWorldMeshBufferML* buffer, ulong* future);
		private static xrRequestWorldMeshAsyncMLDelegate xrRequestWorldMeshAsyncML_ptr;
		public static XrResult xrRequestWorldMeshAsyncML(XrWorldMeshDetectorML detector, XrWorldMeshGetInfoML* getInfo, XrWorldMeshBufferML* buffer, ulong* future)
			=> xrRequestWorldMeshAsyncML_ptr(detector, getInfo, buffer, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrRequestWorldMeshCompleteMLDelegate(XrWorldMeshDetectorML detector, XrWorldMeshRequestCompletionInfoML* completionInfo, ulong future, XrWorldMeshRequestCompletionML* completion);
		private static xrRequestWorldMeshCompleteMLDelegate xrRequestWorldMeshCompleteML_ptr;
		public static XrResult xrRequestWorldMeshCompleteML(XrWorldMeshDetectorML detector, XrWorldMeshRequestCompletionInfoML* completionInfo, ulong future, XrWorldMeshRequestCompletionML* completion)
			=> xrRequestWorldMeshCompleteML_ptr(detector, completionInfo, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateFacialExpressionClientMLDelegate(XrSession session, XrFacialExpressionClientCreateInfoML* createInfo, XrFacialExpressionClientML* facialExpressionClient);
		private static xrCreateFacialExpressionClientMLDelegate xrCreateFacialExpressionClientML_ptr;
		public static XrResult xrCreateFacialExpressionClientML(XrSession session, XrFacialExpressionClientCreateInfoML* createInfo, XrFacialExpressionClientML* facialExpressionClient)
			=> xrCreateFacialExpressionClientML_ptr(session, createInfo, facialExpressionClient);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroyFacialExpressionClientMLDelegate(XrFacialExpressionClientML facialExpressionClient);
		private static xrDestroyFacialExpressionClientMLDelegate xrDestroyFacialExpressionClientML_ptr;
		public static XrResult xrDestroyFacialExpressionClientML(XrFacialExpressionClientML facialExpressionClient)
			=> xrDestroyFacialExpressionClientML_ptr(facialExpressionClient);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetFacialExpressionBlendShapePropertiesMLDelegate(XrFacialExpressionClientML facialExpressionClient, XrFacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, uint blendShapeCount, XrFacialExpressionBlendShapePropertiesML* blendShapes);
		private static xrGetFacialExpressionBlendShapePropertiesMLDelegate xrGetFacialExpressionBlendShapePropertiesML_ptr;
		public static XrResult xrGetFacialExpressionBlendShapePropertiesML(XrFacialExpressionClientML facialExpressionClient, XrFacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, uint blendShapeCount, XrFacialExpressionBlendShapePropertiesML* blendShapes)
			=> xrGetFacialExpressionBlendShapePropertiesML_ptr(facialExpressionClient, blendShapeGetInfo, blendShapeCount, blendShapes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrResumeSimultaneousHandsAndControllersTrackingMETADelegate(XrSession session, XrSimultaneousHandsAndControllersTrackingResumeInfoMETA* resumeInfo);
		private static xrResumeSimultaneousHandsAndControllersTrackingMETADelegate xrResumeSimultaneousHandsAndControllersTrackingMETA_ptr;
		public static XrResult xrResumeSimultaneousHandsAndControllersTrackingMETA(XrSession session, XrSimultaneousHandsAndControllersTrackingResumeInfoMETA* resumeInfo)
			=> xrResumeSimultaneousHandsAndControllersTrackingMETA_ptr(session, resumeInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPauseSimultaneousHandsAndControllersTrackingMETADelegate(XrSession session, XrSimultaneousHandsAndControllersTrackingPauseInfoMETA* pauseInfo);
		private static xrPauseSimultaneousHandsAndControllersTrackingMETADelegate xrPauseSimultaneousHandsAndControllersTrackingMETA_ptr;
		public static XrResult xrPauseSimultaneousHandsAndControllersTrackingMETA(XrSession session, XrSimultaneousHandsAndControllersTrackingPauseInfoMETA* pauseInfo)
			=> xrPauseSimultaneousHandsAndControllersTrackingMETA_ptr(session, pauseInfo);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStartColocationDiscoveryMETADelegate(XrSession session, XrColocationDiscoveryStartInfoMETA* info, ulong* discoveryRequestId);
		private static xrStartColocationDiscoveryMETADelegate xrStartColocationDiscoveryMETA_ptr;
		public static XrResult xrStartColocationDiscoveryMETA(XrSession session, XrColocationDiscoveryStartInfoMETA* info, ulong* discoveryRequestId)
			=> xrStartColocationDiscoveryMETA_ptr(session, info, discoveryRequestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStopColocationDiscoveryMETADelegate(XrSession session, XrColocationDiscoveryStopInfoMETA* info, ulong* requestId);
		private static xrStopColocationDiscoveryMETADelegate xrStopColocationDiscoveryMETA_ptr;
		public static XrResult xrStopColocationDiscoveryMETA(XrSession session, XrColocationDiscoveryStopInfoMETA* info, ulong* requestId)
			=> xrStopColocationDiscoveryMETA_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStartColocationAdvertisementMETADelegate(XrSession session, XrColocationAdvertisementStartInfoMETA* info, ulong* advertisementRequestId);
		private static xrStartColocationAdvertisementMETADelegate xrStartColocationAdvertisementMETA_ptr;
		public static XrResult xrStartColocationAdvertisementMETA(XrSession session, XrColocationAdvertisementStartInfoMETA* info, ulong* advertisementRequestId)
			=> xrStartColocationAdvertisementMETA_ptr(session, info, advertisementRequestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrStopColocationAdvertisementMETADelegate(XrSession session, XrColocationAdvertisementStopInfoMETA* info, ulong* requestId);
		private static xrStopColocationAdvertisementMETADelegate xrStopColocationAdvertisementMETA_ptr;
		public static XrResult xrStopColocationAdvertisementMETA(XrSession session, XrColocationAdvertisementStopInfoMETA* info, ulong* requestId)
			=> xrStopColocationAdvertisementMETA_ptr(session, info, requestId);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrShareAnchorANDROIDDelegate(XrSession session, XrAnchorSharingInfoANDROID* sharingInfo, XrAnchorSharingTokenANDROID* anchorToken);
		private static xrShareAnchorANDROIDDelegate xrShareAnchorANDROID_ptr;
		public static XrResult xrShareAnchorANDROID(XrSession session, XrAnchorSharingInfoANDROID* sharingInfo, XrAnchorSharingTokenANDROID* anchorToken)
			=> xrShareAnchorANDROID_ptr(session, sharingInfo, anchorToken);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnshareAnchorANDROIDDelegate(XrSession session, XrSpace anchor);
		private static xrUnshareAnchorANDROIDDelegate xrUnshareAnchorANDROID_ptr;
		public static XrResult xrUnshareAnchorANDROID(XrSession session, XrSpace anchor)
			=> xrUnshareAnchorANDROID_ptr(session, anchor);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetTrackableMarkerANDROIDDelegate(XrTrackableTrackerANDROID tracker, XrTrackableGetInfoANDROID* getInfo, XrTrackableMarkerANDROID* markerOutput);
		private static xrGetTrackableMarkerANDROIDDelegate xrGetTrackableMarkerANDROID_ptr;
		public static XrResult xrGetTrackableMarkerANDROID(XrTrackableTrackerANDROID tracker, XrTrackableGetInfoANDROID* getInfo, XrTrackableMarkerANDROID* markerOutput)
			=> xrGetTrackableMarkerANDROID_ptr(tracker, getInfo, markerOutput);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSpatialCapabilitiesEXTDelegate(XrInstance instance, ulong systemId, uint capabilityCapacityInput, uint* capabilityCountOutput, XrSpatialCapabilityEXT* capabilities);
		private static xrEnumerateSpatialCapabilitiesEXTDelegate xrEnumerateSpatialCapabilitiesEXT_ptr;
		public static XrResult xrEnumerateSpatialCapabilitiesEXT(XrInstance instance, ulong systemId, uint capabilityCapacityInput, uint* capabilityCountOutput, XrSpatialCapabilityEXT* capabilities)
			=> xrEnumerateSpatialCapabilitiesEXT_ptr(instance, systemId, capabilityCapacityInput, capabilityCountOutput, capabilities);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSpatialCapabilityComponentTypesEXTDelegate(XrInstance instance, ulong systemId, XrSpatialCapabilityEXT capability, XrSpatialCapabilityComponentTypesEXT* capabilityComponents);
		private static xrEnumerateSpatialCapabilityComponentTypesEXTDelegate xrEnumerateSpatialCapabilityComponentTypesEXT_ptr;
		public static XrResult xrEnumerateSpatialCapabilityComponentTypesEXT(XrInstance instance, ulong systemId, XrSpatialCapabilityEXT capability, XrSpatialCapabilityComponentTypesEXT* capabilityComponents)
			=> xrEnumerateSpatialCapabilityComponentTypesEXT_ptr(instance, systemId, capability, capabilityComponents);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSpatialCapabilityFeaturesEXTDelegate(XrInstance instance, ulong systemId, XrSpatialCapabilityEXT capability, uint capabilityFeatureCapacityInput, uint* capabilityFeatureCountOutput, XrSpatialCapabilityFeatureEXT* capabilityFeatures);
		private static xrEnumerateSpatialCapabilityFeaturesEXTDelegate xrEnumerateSpatialCapabilityFeaturesEXT_ptr;
		public static XrResult xrEnumerateSpatialCapabilityFeaturesEXT(XrInstance instance, ulong systemId, XrSpatialCapabilityEXT capability, uint capabilityFeatureCapacityInput, uint* capabilityFeatureCountOutput, XrSpatialCapabilityFeatureEXT* capabilityFeatures)
			=> xrEnumerateSpatialCapabilityFeaturesEXT_ptr(instance, systemId, capability, capabilityFeatureCapacityInput, capabilityFeatureCountOutput, capabilityFeatures);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialContextAsyncEXTDelegate(XrSession session, XrSpatialContextCreateInfoEXT* createInfo, ulong* future);
		private static xrCreateSpatialContextAsyncEXTDelegate xrCreateSpatialContextAsyncEXT_ptr;
		public static XrResult xrCreateSpatialContextAsyncEXT(XrSession session, XrSpatialContextCreateInfoEXT* createInfo, ulong* future)
			=> xrCreateSpatialContextAsyncEXT_ptr(session, createInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialContextCompleteEXTDelegate(XrSession session, ulong future, XrCreateSpatialContextCompletionEXT* completion);
		private static xrCreateSpatialContextCompleteEXTDelegate xrCreateSpatialContextCompleteEXT_ptr;
		public static XrResult xrCreateSpatialContextCompleteEXT(XrSession session, ulong future, XrCreateSpatialContextCompletionEXT* completion)
			=> xrCreateSpatialContextCompleteEXT_ptr(session, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialContextEXTDelegate(XrSpatialContextEXT spatialContext);
		private static xrDestroySpatialContextEXTDelegate xrDestroySpatialContextEXT_ptr;
		public static XrResult xrDestroySpatialContextEXT(XrSpatialContextEXT spatialContext)
			=> xrDestroySpatialContextEXT_ptr(spatialContext);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialDiscoverySnapshotAsyncEXTDelegate(XrSpatialContextEXT spatialContext, XrSpatialDiscoverySnapshotCreateInfoEXT* createInfo, ulong* future);
		private static xrCreateSpatialDiscoverySnapshotAsyncEXTDelegate xrCreateSpatialDiscoverySnapshotAsyncEXT_ptr;
		public static XrResult xrCreateSpatialDiscoverySnapshotAsyncEXT(XrSpatialContextEXT spatialContext, XrSpatialDiscoverySnapshotCreateInfoEXT* createInfo, ulong* future)
			=> xrCreateSpatialDiscoverySnapshotAsyncEXT_ptr(spatialContext, createInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialDiscoverySnapshotCompleteEXTDelegate(XrSpatialContextEXT spatialContext, XrCreateSpatialDiscoverySnapshotCompletionInfoEXT* createSnapshotCompletionInfo, XrCreateSpatialDiscoverySnapshotCompletionEXT* completion);
		private static xrCreateSpatialDiscoverySnapshotCompleteEXTDelegate xrCreateSpatialDiscoverySnapshotCompleteEXT_ptr;
		public static XrResult xrCreateSpatialDiscoverySnapshotCompleteEXT(XrSpatialContextEXT spatialContext, XrCreateSpatialDiscoverySnapshotCompletionInfoEXT* createSnapshotCompletionInfo, XrCreateSpatialDiscoverySnapshotCompletionEXT* completion)
			=> xrCreateSpatialDiscoverySnapshotCompleteEXT_ptr(spatialContext, createSnapshotCompletionInfo, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrQuerySpatialComponentDataEXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialComponentDataQueryConditionEXT* queryCondition, XrSpatialComponentDataQueryResultEXT* queryResult);
		private static xrQuerySpatialComponentDataEXTDelegate xrQuerySpatialComponentDataEXT_ptr;
		public static XrResult xrQuerySpatialComponentDataEXT(XrSpatialSnapshotEXT snapshot, XrSpatialComponentDataQueryConditionEXT* queryCondition, XrSpatialComponentDataQueryResultEXT* queryResult)
			=> xrQuerySpatialComponentDataEXT_ptr(snapshot, queryCondition, queryResult);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialSnapshotEXTDelegate(XrSpatialSnapshotEXT snapshot);
		private static xrDestroySpatialSnapshotEXTDelegate xrDestroySpatialSnapshotEXT_ptr;
		public static XrResult xrDestroySpatialSnapshotEXT(XrSpatialSnapshotEXT snapshot)
			=> xrDestroySpatialSnapshotEXT_ptr(snapshot);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialEntityFromIdEXTDelegate(XrSpatialContextEXT spatialContext, XrSpatialEntityFromIdCreateInfoEXT* createInfo, XrSpatialEntityEXT* spatialEntity);
		private static xrCreateSpatialEntityFromIdEXTDelegate xrCreateSpatialEntityFromIdEXT_ptr;
		public static XrResult xrCreateSpatialEntityFromIdEXT(XrSpatialContextEXT spatialContext, XrSpatialEntityFromIdCreateInfoEXT* createInfo, XrSpatialEntityEXT* spatialEntity)
			=> xrCreateSpatialEntityFromIdEXT_ptr(spatialContext, createInfo, spatialEntity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialEntityEXTDelegate(XrSpatialEntityEXT spatialEntity);
		private static xrDestroySpatialEntityEXTDelegate xrDestroySpatialEntityEXT_ptr;
		public static XrResult xrDestroySpatialEntityEXT(XrSpatialEntityEXT spatialEntity)
			=> xrDestroySpatialEntityEXT_ptr(spatialEntity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialUpdateSnapshotEXTDelegate(XrSpatialContextEXT spatialContext, XrSpatialUpdateSnapshotCreateInfoEXT* createInfo, XrSpatialSnapshotEXT* snapshot);
		private static xrCreateSpatialUpdateSnapshotEXTDelegate xrCreateSpatialUpdateSnapshotEXT_ptr;
		public static XrResult xrCreateSpatialUpdateSnapshotEXT(XrSpatialContextEXT spatialContext, XrSpatialUpdateSnapshotCreateInfoEXT* createInfo, XrSpatialSnapshotEXT* snapshot)
			=> xrCreateSpatialUpdateSnapshotEXT_ptr(spatialContext, createInfo, snapshot);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferStringEXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetSpatialBufferStringEXTDelegate xrGetSpatialBufferStringEXT_ptr;
		public static XrResult xrGetSpatialBufferStringEXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetSpatialBufferStringEXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferUint8EXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
		private static xrGetSpatialBufferUint8EXTDelegate xrGetSpatialBufferUint8EXT_ptr;
		public static XrResult xrGetSpatialBufferUint8EXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
			=> xrGetSpatialBufferUint8EXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferUint16EXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, ushort* buffer);
		private static xrGetSpatialBufferUint16EXTDelegate xrGetSpatialBufferUint16EXT_ptr;
		public static XrResult xrGetSpatialBufferUint16EXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, ushort* buffer)
			=> xrGetSpatialBufferUint16EXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferUint32EXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, uint* buffer);
		private static xrGetSpatialBufferUint32EXTDelegate xrGetSpatialBufferUint32EXT_ptr;
		public static XrResult xrGetSpatialBufferUint32EXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, uint* buffer)
			=> xrGetSpatialBufferUint32EXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferFloatEXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, float* buffer);
		private static xrGetSpatialBufferFloatEXTDelegate xrGetSpatialBufferFloatEXT_ptr;
		public static XrResult xrGetSpatialBufferFloatEXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, float* buffer)
			=> xrGetSpatialBufferFloatEXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferVector2fEXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, XrVector2f* buffer);
		private static xrGetSpatialBufferVector2fEXTDelegate xrGetSpatialBufferVector2fEXT_ptr;
		public static XrResult xrGetSpatialBufferVector2fEXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, XrVector2f* buffer)
			=> xrGetSpatialBufferVector2fEXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrGetSpatialBufferVector3fEXTDelegate(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, XrVector3f* buffer);
		private static xrGetSpatialBufferVector3fEXTDelegate xrGetSpatialBufferVector3fEXT_ptr;
		public static XrResult xrGetSpatialBufferVector3fEXT(XrSpatialSnapshotEXT snapshot, XrSpatialBufferGetInfoEXT* info, uint bufferCapacityInput, uint* bufferCountOutput, XrVector3f* buffer)
			=> xrGetSpatialBufferVector3fEXT_ptr(snapshot, info, bufferCapacityInput, bufferCountOutput, buffer);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialAnchorEXTDelegate(XrSpatialContextEXT spatialContext, XrSpatialAnchorCreateInfoEXT* createInfo, ulong* anchorEntityId, XrSpatialEntityEXT* anchorEntity);
		private static xrCreateSpatialAnchorEXTDelegate xrCreateSpatialAnchorEXT_ptr;
		public static XrResult xrCreateSpatialAnchorEXT(XrSpatialContextEXT spatialContext, XrSpatialAnchorCreateInfoEXT* createInfo, ulong* anchorEntityId, XrSpatialEntityEXT* anchorEntity)
			=> xrCreateSpatialAnchorEXT_ptr(spatialContext, createInfo, anchorEntityId, anchorEntity);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrEnumerateSpatialPersistenceScopesEXTDelegate(XrInstance instance, ulong systemId, uint persistenceScopeCapacityInput, uint* persistenceScopeCountOutput, XrSpatialPersistenceScopeEXT* persistenceScopes);
		private static xrEnumerateSpatialPersistenceScopesEXTDelegate xrEnumerateSpatialPersistenceScopesEXT_ptr;
		public static XrResult xrEnumerateSpatialPersistenceScopesEXT(XrInstance instance, ulong systemId, uint persistenceScopeCapacityInput, uint* persistenceScopeCountOutput, XrSpatialPersistenceScopeEXT* persistenceScopes)
			=> xrEnumerateSpatialPersistenceScopesEXT_ptr(instance, systemId, persistenceScopeCapacityInput, persistenceScopeCountOutput, persistenceScopes);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialPersistenceContextAsyncEXTDelegate(XrSession session, XrSpatialPersistenceContextCreateInfoEXT* createInfo, ulong* future);
		private static xrCreateSpatialPersistenceContextAsyncEXTDelegate xrCreateSpatialPersistenceContextAsyncEXT_ptr;
		public static XrResult xrCreateSpatialPersistenceContextAsyncEXT(XrSession session, XrSpatialPersistenceContextCreateInfoEXT* createInfo, ulong* future)
			=> xrCreateSpatialPersistenceContextAsyncEXT_ptr(session, createInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrCreateSpatialPersistenceContextCompleteEXTDelegate(XrSession session, ulong future, XrCreateSpatialPersistenceContextCompletionEXT* completion);
		private static xrCreateSpatialPersistenceContextCompleteEXTDelegate xrCreateSpatialPersistenceContextCompleteEXT_ptr;
		public static XrResult xrCreateSpatialPersistenceContextCompleteEXT(XrSession session, ulong future, XrCreateSpatialPersistenceContextCompletionEXT* completion)
			=> xrCreateSpatialPersistenceContextCompleteEXT_ptr(session, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrDestroySpatialPersistenceContextEXTDelegate(XrSpatialPersistenceContextEXT persistenceContext);
		private static xrDestroySpatialPersistenceContextEXTDelegate xrDestroySpatialPersistenceContextEXT_ptr;
		public static XrResult xrDestroySpatialPersistenceContextEXT(XrSpatialPersistenceContextEXT persistenceContext)
			=> xrDestroySpatialPersistenceContextEXT_ptr(persistenceContext);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPersistSpatialEntityAsyncEXTDelegate(XrSpatialPersistenceContextEXT persistenceContext, XrSpatialEntityPersistInfoEXT* persistInfo, ulong* future);
		private static xrPersistSpatialEntityAsyncEXTDelegate xrPersistSpatialEntityAsyncEXT_ptr;
		public static XrResult xrPersistSpatialEntityAsyncEXT(XrSpatialPersistenceContextEXT persistenceContext, XrSpatialEntityPersistInfoEXT* persistInfo, ulong* future)
			=> xrPersistSpatialEntityAsyncEXT_ptr(persistenceContext, persistInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrPersistSpatialEntityCompleteEXTDelegate(XrSpatialPersistenceContextEXT persistenceContext, ulong future, XrPersistSpatialEntityCompletionEXT* completion);
		private static xrPersistSpatialEntityCompleteEXTDelegate xrPersistSpatialEntityCompleteEXT_ptr;
		public static XrResult xrPersistSpatialEntityCompleteEXT(XrSpatialPersistenceContextEXT persistenceContext, ulong future, XrPersistSpatialEntityCompletionEXT* completion)
			=> xrPersistSpatialEntityCompleteEXT_ptr(persistenceContext, future, completion);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnpersistSpatialEntityAsyncEXTDelegate(XrSpatialPersistenceContextEXT persistenceContext, XrSpatialEntityUnpersistInfoEXT* unpersistInfo, ulong* future);
		private static xrUnpersistSpatialEntityAsyncEXTDelegate xrUnpersistSpatialEntityAsyncEXT_ptr;
		public static XrResult xrUnpersistSpatialEntityAsyncEXT(XrSpatialPersistenceContextEXT persistenceContext, XrSpatialEntityUnpersistInfoEXT* unpersistInfo, ulong* future)
			=> xrUnpersistSpatialEntityAsyncEXT_ptr(persistenceContext, unpersistInfo, future);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrUnpersistSpatialEntityCompleteEXTDelegate(XrSpatialPersistenceContextEXT persistenceContext, ulong future, XrUnpersistSpatialEntityCompletionEXT* completion);
		private static xrUnpersistSpatialEntityCompleteEXTDelegate xrUnpersistSpatialEntityCompleteEXT_ptr;
		public static XrResult xrUnpersistSpatialEntityCompleteEXT(XrSpatialPersistenceContextEXT persistenceContext, ulong future, XrUnpersistSpatialEntityCompletionEXT* completion)
			=> xrUnpersistSpatialEntityCompleteEXT_ptr(persistenceContext, future, completion);

		public static void LoadFunctionPointers(XrInstance instance = default)
		{
			if (instance != default)
			{
				nativeLib.instance = instance;
			}

			nativeLib.LoadFunction("xrGetInstanceProcAddr",  out xrGetInstanceProcAddr_ptr);
			nativeLib.LoadFunction("xrEnumerateApiLayerProperties",  out xrEnumerateApiLayerProperties_ptr);
			nativeLib.LoadFunction("xrEnumerateInstanceExtensionProperties",  out xrEnumerateInstanceExtensionProperties_ptr);
			nativeLib.LoadFunction("xrCreateInstance",  out xrCreateInstance_ptr);
			nativeLib.LoadFunction("xrDestroyInstance",  out xrDestroyInstance_ptr);
			nativeLib.LoadFunction("xrGetInstanceProperties",  out xrGetInstanceProperties_ptr);
			nativeLib.LoadFunction("xrPollEvent",  out xrPollEvent_ptr);
			nativeLib.LoadFunction("xrResultToString",  out xrResultToString_ptr);
			nativeLib.LoadFunction("xrStructureTypeToString",  out xrStructureTypeToString_ptr);
			nativeLib.LoadFunction("xrGetSystem",  out xrGetSystem_ptr);
			nativeLib.LoadFunction("xrGetSystemProperties",  out xrGetSystemProperties_ptr);
			nativeLib.LoadFunction("xrEnumerateEnvironmentBlendModes",  out xrEnumerateEnvironmentBlendModes_ptr);
			nativeLib.LoadFunction("xrCreateSession",  out xrCreateSession_ptr);
			nativeLib.LoadFunction("xrDestroySession",  out xrDestroySession_ptr);
			nativeLib.LoadFunction("xrEnumerateReferenceSpaces",  out xrEnumerateReferenceSpaces_ptr);
			nativeLib.LoadFunction("xrCreateReferenceSpace",  out xrCreateReferenceSpace_ptr);
			nativeLib.LoadFunction("xrGetReferenceSpaceBoundsRect",  out xrGetReferenceSpaceBoundsRect_ptr);
			nativeLib.LoadFunction("xrCreateActionSpace",  out xrCreateActionSpace_ptr);
			nativeLib.LoadFunction("xrLocateSpace",  out xrLocateSpace_ptr);
			nativeLib.LoadFunction("xrDestroySpace",  out xrDestroySpace_ptr);
			nativeLib.LoadFunction("xrEnumerateViewConfigurations",  out xrEnumerateViewConfigurations_ptr);
			nativeLib.LoadFunction("xrGetViewConfigurationProperties",  out xrGetViewConfigurationProperties_ptr);
			nativeLib.LoadFunction("xrEnumerateViewConfigurationViews",  out xrEnumerateViewConfigurationViews_ptr);
			nativeLib.LoadFunction("xrEnumerateSwapchainFormats",  out xrEnumerateSwapchainFormats_ptr);
			nativeLib.LoadFunction("xrCreateSwapchain",  out xrCreateSwapchain_ptr);
			nativeLib.LoadFunction("xrDestroySwapchain",  out xrDestroySwapchain_ptr);
			nativeLib.LoadFunction("xrEnumerateSwapchainImages",  out xrEnumerateSwapchainImages_ptr);
			nativeLib.LoadFunction("xrAcquireSwapchainImage",  out xrAcquireSwapchainImage_ptr);
			nativeLib.LoadFunction("xrWaitSwapchainImage",  out xrWaitSwapchainImage_ptr);
			nativeLib.LoadFunction("xrReleaseSwapchainImage",  out xrReleaseSwapchainImage_ptr);
			nativeLib.LoadFunction("xrBeginSession",  out xrBeginSession_ptr);
			nativeLib.LoadFunction("xrEndSession",  out xrEndSession_ptr);
			nativeLib.LoadFunction("xrRequestExitSession",  out xrRequestExitSession_ptr);
			nativeLib.LoadFunction("xrWaitFrame",  out xrWaitFrame_ptr);
			nativeLib.LoadFunction("xrBeginFrame",  out xrBeginFrame_ptr);
			nativeLib.LoadFunction("xrEndFrame",  out xrEndFrame_ptr);
			nativeLib.LoadFunction("xrLocateViews",  out xrLocateViews_ptr);
			nativeLib.LoadFunction("xrStringToPath",  out xrStringToPath_ptr);
			nativeLib.LoadFunction("xrPathToString",  out xrPathToString_ptr);
			nativeLib.LoadFunction("xrCreateActionSet",  out xrCreateActionSet_ptr);
			nativeLib.LoadFunction("xrDestroyActionSet",  out xrDestroyActionSet_ptr);
			nativeLib.LoadFunction("xrCreateAction",  out xrCreateAction_ptr);
			nativeLib.LoadFunction("xrDestroyAction",  out xrDestroyAction_ptr);
			nativeLib.LoadFunction("xrSuggestInteractionProfileBindings",  out xrSuggestInteractionProfileBindings_ptr);
			nativeLib.LoadFunction("xrAttachSessionActionSets",  out xrAttachSessionActionSets_ptr);
			nativeLib.LoadFunction("xrGetCurrentInteractionProfile",  out xrGetCurrentInteractionProfile_ptr);
			nativeLib.LoadFunction("xrGetActionStateBoolean",  out xrGetActionStateBoolean_ptr);
			nativeLib.LoadFunction("xrGetActionStateFloat",  out xrGetActionStateFloat_ptr);
			nativeLib.LoadFunction("xrGetActionStateVector2f",  out xrGetActionStateVector2f_ptr);
			nativeLib.LoadFunction("xrGetActionStatePose",  out xrGetActionStatePose_ptr);
			nativeLib.LoadFunction("xrSyncActions",  out xrSyncActions_ptr);
			nativeLib.LoadFunction("xrEnumerateBoundSourcesForAction",  out xrEnumerateBoundSourcesForAction_ptr);
			nativeLib.LoadFunction("xrGetInputSourceLocalizedName",  out xrGetInputSourceLocalizedName_ptr);
			nativeLib.LoadFunction("xrApplyHapticFeedback",  out xrApplyHapticFeedback_ptr);
			nativeLib.LoadFunction("xrStopHapticFeedback",  out xrStopHapticFeedback_ptr);
			nativeLib.LoadFunction("xrCreateApiLayerInstance",  out xrCreateApiLayerInstance_ptr);
			nativeLib.LoadFunction("xrNegotiateLoaderRuntimeInterface",  out xrNegotiateLoaderRuntimeInterface_ptr);
			nativeLib.LoadFunction("xrNegotiateLoaderApiLayerInterface",  out xrNegotiateLoaderApiLayerInterface_ptr);
			nativeLib.LoadFunction("xrLocateSpaces",  out xrLocateSpaces_ptr);
			nativeLib.LoadFunction("xrSetAndroidApplicationThreadKHR",  out xrSetAndroidApplicationThreadKHR_ptr);
			nativeLib.LoadFunction("xrCreateSwapchainAndroidSurfaceKHR",  out xrCreateSwapchainAndroidSurfaceKHR_ptr);
			nativeLib.LoadFunction("xrPerfSettingsSetPerformanceLevelEXT",  out xrPerfSettingsSetPerformanceLevelEXT_ptr);
			nativeLib.LoadFunction("xrThermalGetTemperatureTrendEXT",  out xrThermalGetTemperatureTrendEXT_ptr);
			nativeLib.LoadFunction("xrSetDebugUtilsObjectNameEXT",  out xrSetDebugUtilsObjectNameEXT_ptr);
			nativeLib.LoadFunction("xrCreateDebugUtilsMessengerEXT",  out xrCreateDebugUtilsMessengerEXT_ptr);
			nativeLib.LoadFunction("xrDestroyDebugUtilsMessengerEXT",  out xrDestroyDebugUtilsMessengerEXT_ptr);
			nativeLib.LoadFunction("xrSubmitDebugUtilsMessageEXT",  out xrSubmitDebugUtilsMessageEXT_ptr);
			nativeLib.LoadFunction("xrSessionBeginDebugUtilsLabelRegionEXT",  out xrSessionBeginDebugUtilsLabelRegionEXT_ptr);
			nativeLib.LoadFunction("xrSessionEndDebugUtilsLabelRegionEXT",  out xrSessionEndDebugUtilsLabelRegionEXT_ptr);
			nativeLib.LoadFunction("xrSessionInsertDebugUtilsLabelEXT",  out xrSessionInsertDebugUtilsLabelEXT_ptr);
			nativeLib.LoadFunction("xrGetOpenGLGraphicsRequirementsKHR",  out xrGetOpenGLGraphicsRequirementsKHR_ptr);
			nativeLib.LoadFunction("xrGetOpenGLESGraphicsRequirementsKHR",  out xrGetOpenGLESGraphicsRequirementsKHR_ptr);
			nativeLib.LoadFunction("xrGetVulkanInstanceExtensionsKHR",  out xrGetVulkanInstanceExtensionsKHR_ptr);
			nativeLib.LoadFunction("xrGetVulkanDeviceExtensionsKHR",  out xrGetVulkanDeviceExtensionsKHR_ptr);
			nativeLib.LoadFunction("xrGetVulkanGraphicsDeviceKHR",  out xrGetVulkanGraphicsDeviceKHR_ptr);
			nativeLib.LoadFunction("xrGetVulkanGraphicsRequirementsKHR",  out xrGetVulkanGraphicsRequirementsKHR_ptr);
			nativeLib.LoadFunction("xrGetD3D11GraphicsRequirementsKHR",  out xrGetD3D11GraphicsRequirementsKHR_ptr);
			nativeLib.LoadFunction("xrGetD3D12GraphicsRequirementsKHR",  out xrGetD3D12GraphicsRequirementsKHR_ptr);
			nativeLib.LoadFunction("xrGetMetalGraphicsRequirementsKHR",  out xrGetMetalGraphicsRequirementsKHR_ptr);
			nativeLib.LoadFunction("xrGetVisibilityMaskKHR",  out xrGetVisibilityMaskKHR_ptr);
			nativeLib.LoadFunction("xrConvertWin32PerformanceCounterToTimeKHR",  out xrConvertWin32PerformanceCounterToTimeKHR_ptr);
			nativeLib.LoadFunction("xrConvertTimeToWin32PerformanceCounterKHR",  out xrConvertTimeToWin32PerformanceCounterKHR_ptr);
			nativeLib.LoadFunction("xrConvertTimespecTimeToTimeKHR",  out xrConvertTimespecTimeToTimeKHR_ptr);
			nativeLib.LoadFunction("xrConvertTimeToTimespecTimeKHR",  out xrConvertTimeToTimespecTimeKHR_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorMSFT",  out xrCreateSpatialAnchorMSFT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorSpaceMSFT",  out xrCreateSpatialAnchorSpaceMSFT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialAnchorMSFT",  out xrDestroySpatialAnchorMSFT_ptr);
			nativeLib.LoadFunction("xrSetInputDeviceActiveEXT",  out xrSetInputDeviceActiveEXT_ptr);
			nativeLib.LoadFunction("xrSetInputDeviceStateBoolEXT",  out xrSetInputDeviceStateBoolEXT_ptr);
			nativeLib.LoadFunction("xrSetInputDeviceStateFloatEXT",  out xrSetInputDeviceStateFloatEXT_ptr);
			nativeLib.LoadFunction("xrSetInputDeviceStateVector2fEXT",  out xrSetInputDeviceStateVector2fEXT_ptr);
			nativeLib.LoadFunction("xrSetInputDeviceLocationEXT",  out xrSetInputDeviceLocationEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialGraphNodeSpaceMSFT",  out xrCreateSpatialGraphNodeSpaceMSFT_ptr);
			nativeLib.LoadFunction("xrTryCreateSpatialGraphStaticNodeBindingMSFT",  out xrTryCreateSpatialGraphStaticNodeBindingMSFT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialGraphNodeBindingMSFT",  out xrDestroySpatialGraphNodeBindingMSFT_ptr);
			nativeLib.LoadFunction("xrGetSpatialGraphNodeBindingPropertiesMSFT",  out xrGetSpatialGraphNodeBindingPropertiesMSFT_ptr);
			nativeLib.LoadFunction("xrCreateHandTrackerEXT",  out xrCreateHandTrackerEXT_ptr);
			nativeLib.LoadFunction("xrDestroyHandTrackerEXT",  out xrDestroyHandTrackerEXT_ptr);
			nativeLib.LoadFunction("xrLocateHandJointsEXT",  out xrLocateHandJointsEXT_ptr);
			nativeLib.LoadFunction("xrCreateHandMeshSpaceMSFT",  out xrCreateHandMeshSpaceMSFT_ptr);
			nativeLib.LoadFunction("xrUpdateHandMeshMSFT",  out xrUpdateHandMeshMSFT_ptr);
			nativeLib.LoadFunction("xrGetControllerModelKeyMSFT",  out xrGetControllerModelKeyMSFT_ptr);
			nativeLib.LoadFunction("xrLoadControllerModelMSFT",  out xrLoadControllerModelMSFT_ptr);
			nativeLib.LoadFunction("xrGetControllerModelPropertiesMSFT",  out xrGetControllerModelPropertiesMSFT_ptr);
			nativeLib.LoadFunction("xrGetControllerModelStateMSFT",  out xrGetControllerModelStateMSFT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorFromPerceptionAnchorMSFT",  out xrCreateSpatialAnchorFromPerceptionAnchorMSFT_ptr);
			nativeLib.LoadFunction("xrTryGetPerceptionAnchorFromSpatialAnchorMSFT",  out xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_ptr);
			nativeLib.LoadFunction("xrEnumerateReprojectionModesMSFT",  out xrEnumerateReprojectionModesMSFT_ptr);
			nativeLib.LoadFunction("xrUpdateSwapchainFB",  out xrUpdateSwapchainFB_ptr);
			nativeLib.LoadFunction("xrGetSwapchainStateFB",  out xrGetSwapchainStateFB_ptr);
			nativeLib.LoadFunction("xrCreateBodyTrackerFB",  out xrCreateBodyTrackerFB_ptr);
			nativeLib.LoadFunction("xrDestroyBodyTrackerFB",  out xrDestroyBodyTrackerFB_ptr);
			nativeLib.LoadFunction("xrLocateBodyJointsFB",  out xrLocateBodyJointsFB_ptr);
			nativeLib.LoadFunction("xrGetBodySkeletonFB",  out xrGetBodySkeletonFB_ptr);
			nativeLib.LoadFunction("xrInitializeLoaderKHR",  out xrInitializeLoaderKHR_ptr);
			nativeLib.LoadFunction("xrCreateVulkanInstanceKHR",  out xrCreateVulkanInstanceKHR_ptr);
			nativeLib.LoadFunction("xrCreateVulkanDeviceKHR",  out xrCreateVulkanDeviceKHR_ptr);
			nativeLib.LoadFunction("xrGetVulkanGraphicsDevice2KHR",  out xrGetVulkanGraphicsDevice2KHR_ptr);
			nativeLib.LoadFunction("xrEnumerateSceneComputeFeaturesMSFT",  out xrEnumerateSceneComputeFeaturesMSFT_ptr);
			nativeLib.LoadFunction("xrCreateSceneObserverMSFT",  out xrCreateSceneObserverMSFT_ptr);
			nativeLib.LoadFunction("xrDestroySceneObserverMSFT",  out xrDestroySceneObserverMSFT_ptr);
			nativeLib.LoadFunction("xrCreateSceneMSFT",  out xrCreateSceneMSFT_ptr);
			nativeLib.LoadFunction("xrDestroySceneMSFT",  out xrDestroySceneMSFT_ptr);
			nativeLib.LoadFunction("xrComputeNewSceneMSFT",  out xrComputeNewSceneMSFT_ptr);
			nativeLib.LoadFunction("xrGetSceneComputeStateMSFT",  out xrGetSceneComputeStateMSFT_ptr);
			nativeLib.LoadFunction("xrGetSceneComponentsMSFT",  out xrGetSceneComponentsMSFT_ptr);
			nativeLib.LoadFunction("xrLocateSceneComponentsMSFT",  out xrLocateSceneComponentsMSFT_ptr);
			nativeLib.LoadFunction("xrGetSceneMeshBuffersMSFT",  out xrGetSceneMeshBuffersMSFT_ptr);
			nativeLib.LoadFunction("xrDeserializeSceneMSFT",  out xrDeserializeSceneMSFT_ptr);
			nativeLib.LoadFunction("xrGetSerializedSceneFragmentDataMSFT",  out xrGetSerializedSceneFragmentDataMSFT_ptr);
			nativeLib.LoadFunction("xrEnumerateDisplayRefreshRatesFB",  out xrEnumerateDisplayRefreshRatesFB_ptr);
			nativeLib.LoadFunction("xrGetDisplayRefreshRateFB",  out xrGetDisplayRefreshRateFB_ptr);
			nativeLib.LoadFunction("xrRequestDisplayRefreshRateFB",  out xrRequestDisplayRefreshRateFB_ptr);
			nativeLib.LoadFunction("xrEnumerateViveTrackerPathsHTCX",  out xrEnumerateViveTrackerPathsHTCX_ptr);
			nativeLib.LoadFunction("xrCreateFacialTrackerHTC",  out xrCreateFacialTrackerHTC_ptr);
			nativeLib.LoadFunction("xrDestroyFacialTrackerHTC",  out xrDestroyFacialTrackerHTC_ptr);
			nativeLib.LoadFunction("xrGetFacialExpressionsHTC",  out xrGetFacialExpressionsHTC_ptr);
			nativeLib.LoadFunction("xrEnumerateColorSpacesFB",  out xrEnumerateColorSpacesFB_ptr);
			nativeLib.LoadFunction("xrSetColorSpaceFB",  out xrSetColorSpaceFB_ptr);
			nativeLib.LoadFunction("xrGetHandMeshFB",  out xrGetHandMeshFB_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorFB",  out xrCreateSpatialAnchorFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceUuidFB",  out xrGetSpaceUuidFB_ptr);
			nativeLib.LoadFunction("xrEnumerateSpaceSupportedComponentsFB",  out xrEnumerateSpaceSupportedComponentsFB_ptr);
			nativeLib.LoadFunction("xrSetSpaceComponentStatusFB",  out xrSetSpaceComponentStatusFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceComponentStatusFB",  out xrGetSpaceComponentStatusFB_ptr);
			nativeLib.LoadFunction("xrCreateFoveationProfileFB",  out xrCreateFoveationProfileFB_ptr);
			nativeLib.LoadFunction("xrDestroyFoveationProfileFB",  out xrDestroyFoveationProfileFB_ptr);
			nativeLib.LoadFunction("xrQuerySystemTrackedKeyboardFB",  out xrQuerySystemTrackedKeyboardFB_ptr);
			nativeLib.LoadFunction("xrCreateKeyboardSpaceFB",  out xrCreateKeyboardSpaceFB_ptr);
			nativeLib.LoadFunction("xrCreateTriangleMeshFB",  out xrCreateTriangleMeshFB_ptr);
			nativeLib.LoadFunction("xrDestroyTriangleMeshFB",  out xrDestroyTriangleMeshFB_ptr);
			nativeLib.LoadFunction("xrTriangleMeshGetVertexBufferFB",  out xrTriangleMeshGetVertexBufferFB_ptr);
			nativeLib.LoadFunction("xrTriangleMeshGetIndexBufferFB",  out xrTriangleMeshGetIndexBufferFB_ptr);
			nativeLib.LoadFunction("xrTriangleMeshBeginUpdateFB",  out xrTriangleMeshBeginUpdateFB_ptr);
			nativeLib.LoadFunction("xrTriangleMeshEndUpdateFB",  out xrTriangleMeshEndUpdateFB_ptr);
			nativeLib.LoadFunction("xrTriangleMeshBeginVertexBufferUpdateFB",  out xrTriangleMeshBeginVertexBufferUpdateFB_ptr);
			nativeLib.LoadFunction("xrTriangleMeshEndVertexBufferUpdateFB",  out xrTriangleMeshEndVertexBufferUpdateFB_ptr);
			nativeLib.LoadFunction("xrCreatePassthroughFB",  out xrCreatePassthroughFB_ptr);
			nativeLib.LoadFunction("xrDestroyPassthroughFB",  out xrDestroyPassthroughFB_ptr);
			nativeLib.LoadFunction("xrPassthroughStartFB",  out xrPassthroughStartFB_ptr);
			nativeLib.LoadFunction("xrPassthroughPauseFB",  out xrPassthroughPauseFB_ptr);
			nativeLib.LoadFunction("xrCreatePassthroughLayerFB",  out xrCreatePassthroughLayerFB_ptr);
			nativeLib.LoadFunction("xrDestroyPassthroughLayerFB",  out xrDestroyPassthroughLayerFB_ptr);
			nativeLib.LoadFunction("xrPassthroughLayerPauseFB",  out xrPassthroughLayerPauseFB_ptr);
			nativeLib.LoadFunction("xrPassthroughLayerResumeFB",  out xrPassthroughLayerResumeFB_ptr);
			nativeLib.LoadFunction("xrPassthroughLayerSetStyleFB",  out xrPassthroughLayerSetStyleFB_ptr);
			nativeLib.LoadFunction("xrCreateGeometryInstanceFB",  out xrCreateGeometryInstanceFB_ptr);
			nativeLib.LoadFunction("xrDestroyGeometryInstanceFB",  out xrDestroyGeometryInstanceFB_ptr);
			nativeLib.LoadFunction("xrGeometryInstanceSetTransformFB",  out xrGeometryInstanceSetTransformFB_ptr);
			nativeLib.LoadFunction("xrEnumerateRenderModelPathsFB",  out xrEnumerateRenderModelPathsFB_ptr);
			nativeLib.LoadFunction("xrGetRenderModelPropertiesFB",  out xrGetRenderModelPropertiesFB_ptr);
			nativeLib.LoadFunction("xrLoadRenderModelFB",  out xrLoadRenderModelFB_ptr);
			nativeLib.LoadFunction("xrSetEnvironmentDepthEstimationVARJO",  out xrSetEnvironmentDepthEstimationVARJO_ptr);
			nativeLib.LoadFunction("xrSetMarkerTrackingVARJO",  out xrSetMarkerTrackingVARJO_ptr);
			nativeLib.LoadFunction("xrSetMarkerTrackingTimeoutVARJO",  out xrSetMarkerTrackingTimeoutVARJO_ptr);
			nativeLib.LoadFunction("xrSetMarkerTrackingPredictionVARJO",  out xrSetMarkerTrackingPredictionVARJO_ptr);
			nativeLib.LoadFunction("xrGetMarkerSizeVARJO",  out xrGetMarkerSizeVARJO_ptr);
			nativeLib.LoadFunction("xrCreateMarkerSpaceVARJO",  out xrCreateMarkerSpaceVARJO_ptr);
			nativeLib.LoadFunction("xrSetViewOffsetVARJO",  out xrSetViewOffsetVARJO_ptr);
			nativeLib.LoadFunction("xrCreateSpaceFromCoordinateFrameUIDML",  out xrCreateSpaceFromCoordinateFrameUIDML_ptr);
			nativeLib.LoadFunction("xrCreateMarkerDetectorML",  out xrCreateMarkerDetectorML_ptr);
			nativeLib.LoadFunction("xrDestroyMarkerDetectorML",  out xrDestroyMarkerDetectorML_ptr);
			nativeLib.LoadFunction("xrSnapshotMarkerDetectorML",  out xrSnapshotMarkerDetectorML_ptr);
			nativeLib.LoadFunction("xrGetMarkerDetectorStateML",  out xrGetMarkerDetectorStateML_ptr);
			nativeLib.LoadFunction("xrGetMarkersML",  out xrGetMarkersML_ptr);
			nativeLib.LoadFunction("xrGetMarkerReprojectionErrorML",  out xrGetMarkerReprojectionErrorML_ptr);
			nativeLib.LoadFunction("xrGetMarkerLengthML",  out xrGetMarkerLengthML_ptr);
			nativeLib.LoadFunction("xrGetMarkerNumberML",  out xrGetMarkerNumberML_ptr);
			nativeLib.LoadFunction("xrGetMarkerStringML",  out xrGetMarkerStringML_ptr);
			nativeLib.LoadFunction("xrCreateMarkerSpaceML",  out xrCreateMarkerSpaceML_ptr);
			nativeLib.LoadFunction("xrEnableLocalizationEventsML",  out xrEnableLocalizationEventsML_ptr);
			nativeLib.LoadFunction("xrQueryLocalizationMapsML",  out xrQueryLocalizationMapsML_ptr);
			nativeLib.LoadFunction("xrRequestMapLocalizationML",  out xrRequestMapLocalizationML_ptr);
			nativeLib.LoadFunction("xrImportLocalizationMapML",  out xrImportLocalizationMapML_ptr);
			nativeLib.LoadFunction("xrCreateExportedLocalizationMapML",  out xrCreateExportedLocalizationMapML_ptr);
			nativeLib.LoadFunction("xrDestroyExportedLocalizationMapML",  out xrDestroyExportedLocalizationMapML_ptr);
			nativeLib.LoadFunction("xrGetExportedLocalizationMapDataML",  out xrGetExportedLocalizationMapDataML_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorsAsyncML",  out xrCreateSpatialAnchorsAsyncML_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorsCompleteML",  out xrCreateSpatialAnchorsCompleteML_ptr);
			nativeLib.LoadFunction("xrGetSpatialAnchorStateML",  out xrGetSpatialAnchorStateML_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorsStorageML",  out xrCreateSpatialAnchorsStorageML_ptr);
			nativeLib.LoadFunction("xrDestroySpatialAnchorsStorageML",  out xrDestroySpatialAnchorsStorageML_ptr);
			nativeLib.LoadFunction("xrQuerySpatialAnchorsAsyncML",  out xrQuerySpatialAnchorsAsyncML_ptr);
			nativeLib.LoadFunction("xrQuerySpatialAnchorsCompleteML",  out xrQuerySpatialAnchorsCompleteML_ptr);
			nativeLib.LoadFunction("xrPublishSpatialAnchorsAsyncML",  out xrPublishSpatialAnchorsAsyncML_ptr);
			nativeLib.LoadFunction("xrPublishSpatialAnchorsCompleteML",  out xrPublishSpatialAnchorsCompleteML_ptr);
			nativeLib.LoadFunction("xrDeleteSpatialAnchorsAsyncML",  out xrDeleteSpatialAnchorsAsyncML_ptr);
			nativeLib.LoadFunction("xrDeleteSpatialAnchorsCompleteML",  out xrDeleteSpatialAnchorsCompleteML_ptr);
			nativeLib.LoadFunction("xrUpdateSpatialAnchorsExpirationAsyncML",  out xrUpdateSpatialAnchorsExpirationAsyncML_ptr);
			nativeLib.LoadFunction("xrUpdateSpatialAnchorsExpirationCompleteML",  out xrUpdateSpatialAnchorsExpirationCompleteML_ptr);
			nativeLib.LoadFunction("xrEnableUserCalibrationEventsML",  out xrEnableUserCalibrationEventsML_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorStoreConnectionMSFT",  out xrCreateSpatialAnchorStoreConnectionMSFT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialAnchorStoreConnectionMSFT",  out xrDestroySpatialAnchorStoreConnectionMSFT_ptr);
			nativeLib.LoadFunction("xrPersistSpatialAnchorMSFT",  out xrPersistSpatialAnchorMSFT_ptr);
			nativeLib.LoadFunction("xrEnumeratePersistedSpatialAnchorNamesMSFT",  out xrEnumeratePersistedSpatialAnchorNamesMSFT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorFromPersistedNameMSFT",  out xrCreateSpatialAnchorFromPersistedNameMSFT_ptr);
			nativeLib.LoadFunction("xrUnpersistSpatialAnchorMSFT",  out xrUnpersistSpatialAnchorMSFT_ptr);
			nativeLib.LoadFunction("xrClearSpatialAnchorStoreMSFT",  out xrClearSpatialAnchorStoreMSFT_ptr);
			nativeLib.LoadFunction("xrGetSceneMarkerRawDataMSFT",  out xrGetSceneMarkerRawDataMSFT_ptr);
			nativeLib.LoadFunction("xrGetSceneMarkerDecodedStringMSFT",  out xrGetSceneMarkerDecodedStringMSFT_ptr);
			nativeLib.LoadFunction("xrStructureTypeToString2KHR",  out xrStructureTypeToString2KHR_ptr);
			nativeLib.LoadFunction("xrQuerySpacesFB",  out xrQuerySpacesFB_ptr);
			nativeLib.LoadFunction("xrRetrieveSpaceQueryResultsFB",  out xrRetrieveSpaceQueryResultsFB_ptr);
			nativeLib.LoadFunction("xrSaveSpaceFB",  out xrSaveSpaceFB_ptr);
			nativeLib.LoadFunction("xrEraseSpaceFB",  out xrEraseSpaceFB_ptr);
			nativeLib.LoadFunction("xrGetAudioOutputDeviceGuidOculus",  out xrGetAudioOutputDeviceGuidOculus_ptr);
			nativeLib.LoadFunction("xrGetAudioInputDeviceGuidOculus",  out xrGetAudioInputDeviceGuidOculus_ptr);
			nativeLib.LoadFunction("xrShareSpacesFB",  out xrShareSpacesFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceBoundingBox2DFB",  out xrGetSpaceBoundingBox2DFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceBoundingBox3DFB",  out xrGetSpaceBoundingBox3DFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceSemanticLabelsFB",  out xrGetSpaceSemanticLabelsFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceBoundary2DFB",  out xrGetSpaceBoundary2DFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceRoomLayoutFB",  out xrGetSpaceRoomLayoutFB_ptr);
			nativeLib.LoadFunction("xrSetDigitalLensControlALMALENCE",  out xrSetDigitalLensControlALMALENCE_ptr);
			nativeLib.LoadFunction("xrRequestSceneCaptureFB",  out xrRequestSceneCaptureFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceContainerFB",  out xrGetSpaceContainerFB_ptr);
			nativeLib.LoadFunction("xrGetFoveationEyeTrackedStateMETA",  out xrGetFoveationEyeTrackedStateMETA_ptr);
			nativeLib.LoadFunction("xrCreateFaceTrackerFB",  out xrCreateFaceTrackerFB_ptr);
			nativeLib.LoadFunction("xrDestroyFaceTrackerFB",  out xrDestroyFaceTrackerFB_ptr);
			nativeLib.LoadFunction("xrGetFaceExpressionWeightsFB",  out xrGetFaceExpressionWeightsFB_ptr);
			nativeLib.LoadFunction("xrCreateEyeTrackerFB",  out xrCreateEyeTrackerFB_ptr);
			nativeLib.LoadFunction("xrDestroyEyeTrackerFB",  out xrDestroyEyeTrackerFB_ptr);
			nativeLib.LoadFunction("xrGetEyeGazesFB",  out xrGetEyeGazesFB_ptr);
			nativeLib.LoadFunction("xrPassthroughLayerSetKeyboardHandsIntensityFB",  out xrPassthroughLayerSetKeyboardHandsIntensityFB_ptr);
			nativeLib.LoadFunction("xrGetDeviceSampleRateFB",  out xrGetDeviceSampleRateFB_ptr);
			nativeLib.LoadFunction("xrGetPassthroughPreferencesMETA",  out xrGetPassthroughPreferencesMETA_ptr);
			nativeLib.LoadFunction("xrCreateVirtualKeyboardMETA",  out xrCreateVirtualKeyboardMETA_ptr);
			nativeLib.LoadFunction("xrDestroyVirtualKeyboardMETA",  out xrDestroyVirtualKeyboardMETA_ptr);
			nativeLib.LoadFunction("xrCreateVirtualKeyboardSpaceMETA",  out xrCreateVirtualKeyboardSpaceMETA_ptr);
			nativeLib.LoadFunction("xrSuggestVirtualKeyboardLocationMETA",  out xrSuggestVirtualKeyboardLocationMETA_ptr);
			nativeLib.LoadFunction("xrGetVirtualKeyboardScaleMETA",  out xrGetVirtualKeyboardScaleMETA_ptr);
			nativeLib.LoadFunction("xrSetVirtualKeyboardModelVisibilityMETA",  out xrSetVirtualKeyboardModelVisibilityMETA_ptr);
			nativeLib.LoadFunction("xrGetVirtualKeyboardModelAnimationStatesMETA",  out xrGetVirtualKeyboardModelAnimationStatesMETA_ptr);
			nativeLib.LoadFunction("xrGetVirtualKeyboardDirtyTexturesMETA",  out xrGetVirtualKeyboardDirtyTexturesMETA_ptr);
			nativeLib.LoadFunction("xrGetVirtualKeyboardTextureDataMETA",  out xrGetVirtualKeyboardTextureDataMETA_ptr);
			nativeLib.LoadFunction("xrSendVirtualKeyboardInputMETA",  out xrSendVirtualKeyboardInputMETA_ptr);
			nativeLib.LoadFunction("xrChangeVirtualKeyboardTextContextMETA",  out xrChangeVirtualKeyboardTextContextMETA_ptr);
			nativeLib.LoadFunction("xrEnumerateExternalCamerasOCULUS",  out xrEnumerateExternalCamerasOCULUS_ptr);
			nativeLib.LoadFunction("xrEnumeratePerformanceMetricsCounterPathsMETA",  out xrEnumeratePerformanceMetricsCounterPathsMETA_ptr);
			nativeLib.LoadFunction("xrSetPerformanceMetricsStateMETA",  out xrSetPerformanceMetricsStateMETA_ptr);
			nativeLib.LoadFunction("xrGetPerformanceMetricsStateMETA",  out xrGetPerformanceMetricsStateMETA_ptr);
			nativeLib.LoadFunction("xrQueryPerformanceMetricsCounterMETA",  out xrQueryPerformanceMetricsCounterMETA_ptr);
			nativeLib.LoadFunction("xrSaveSpaceListFB",  out xrSaveSpaceListFB_ptr);
			nativeLib.LoadFunction("xrCreateSpaceUserFB",  out xrCreateSpaceUserFB_ptr);
			nativeLib.LoadFunction("xrGetSpaceUserIdFB",  out xrGetSpaceUserIdFB_ptr);
			nativeLib.LoadFunction("xrDestroySpaceUserFB",  out xrDestroySpaceUserFB_ptr);
			nativeLib.LoadFunction("xrDiscoverSpacesMETA",  out xrDiscoverSpacesMETA_ptr);
			nativeLib.LoadFunction("xrRetrieveSpaceDiscoveryResultsMETA",  out xrRetrieveSpaceDiscoveryResultsMETA_ptr);
			nativeLib.LoadFunction("xrGetRecommendedLayerResolutionMETA",  out xrGetRecommendedLayerResolutionMETA_ptr);
			nativeLib.LoadFunction("xrSaveSpacesMETA",  out xrSaveSpacesMETA_ptr);
			nativeLib.LoadFunction("xrEraseSpacesMETA",  out xrEraseSpacesMETA_ptr);
			nativeLib.LoadFunction("xrCreatePassthroughColorLutMETA",  out xrCreatePassthroughColorLutMETA_ptr);
			nativeLib.LoadFunction("xrDestroyPassthroughColorLutMETA",  out xrDestroyPassthroughColorLutMETA_ptr);
			nativeLib.LoadFunction("xrUpdatePassthroughColorLutMETA",  out xrUpdatePassthroughColorLutMETA_ptr);
			nativeLib.LoadFunction("xrGetSpaceTriangleMeshMETA",  out xrGetSpaceTriangleMeshMETA_ptr);
			nativeLib.LoadFunction("xrSuggestBodyTrackingCalibrationOverrideMETA",  out xrSuggestBodyTrackingCalibrationOverrideMETA_ptr);
			nativeLib.LoadFunction("xrResetBodyTrackingCalibrationMETA",  out xrResetBodyTrackingCalibrationMETA_ptr);
			nativeLib.LoadFunction("xrCreateFaceTracker2FB",  out xrCreateFaceTracker2FB_ptr);
			nativeLib.LoadFunction("xrDestroyFaceTracker2FB",  out xrDestroyFaceTracker2FB_ptr);
			nativeLib.LoadFunction("xrGetFaceExpressionWeights2FB",  out xrGetFaceExpressionWeights2FB_ptr);
			nativeLib.LoadFunction("xrShareSpacesMETA",  out xrShareSpacesMETA_ptr);
			nativeLib.LoadFunction("xrCreateEnvironmentDepthProviderMETA",  out xrCreateEnvironmentDepthProviderMETA_ptr);
			nativeLib.LoadFunction("xrDestroyEnvironmentDepthProviderMETA",  out xrDestroyEnvironmentDepthProviderMETA_ptr);
			nativeLib.LoadFunction("xrStartEnvironmentDepthProviderMETA",  out xrStartEnvironmentDepthProviderMETA_ptr);
			nativeLib.LoadFunction("xrStopEnvironmentDepthProviderMETA",  out xrStopEnvironmentDepthProviderMETA_ptr);
			nativeLib.LoadFunction("xrCreateEnvironmentDepthSwapchainMETA",  out xrCreateEnvironmentDepthSwapchainMETA_ptr);
			nativeLib.LoadFunction("xrDestroyEnvironmentDepthSwapchainMETA",  out xrDestroyEnvironmentDepthSwapchainMETA_ptr);
			nativeLib.LoadFunction("xrEnumerateEnvironmentDepthSwapchainImagesMETA",  out xrEnumerateEnvironmentDepthSwapchainImagesMETA_ptr);
			nativeLib.LoadFunction("xrGetEnvironmentDepthSwapchainStateMETA",  out xrGetEnvironmentDepthSwapchainStateMETA_ptr);
			nativeLib.LoadFunction("xrAcquireEnvironmentDepthImageMETA",  out xrAcquireEnvironmentDepthImageMETA_ptr);
			nativeLib.LoadFunction("xrSetEnvironmentDepthHandRemovalMETA",  out xrSetEnvironmentDepthHandRemovalMETA_ptr);
			nativeLib.LoadFunction("xrCreateRenderModelEXT",  out xrCreateRenderModelEXT_ptr);
			nativeLib.LoadFunction("xrDestroyRenderModelEXT",  out xrDestroyRenderModelEXT_ptr);
			nativeLib.LoadFunction("xrGetRenderModelPropertiesEXT",  out xrGetRenderModelPropertiesEXT_ptr);
			nativeLib.LoadFunction("xrCreateRenderModelSpaceEXT",  out xrCreateRenderModelSpaceEXT_ptr);
			nativeLib.LoadFunction("xrCreateRenderModelAssetEXT",  out xrCreateRenderModelAssetEXT_ptr);
			nativeLib.LoadFunction("xrDestroyRenderModelAssetEXT",  out xrDestroyRenderModelAssetEXT_ptr);
			nativeLib.LoadFunction("xrGetRenderModelAssetDataEXT",  out xrGetRenderModelAssetDataEXT_ptr);
			nativeLib.LoadFunction("xrGetRenderModelAssetPropertiesEXT",  out xrGetRenderModelAssetPropertiesEXT_ptr);
			nativeLib.LoadFunction("xrGetRenderModelStateEXT",  out xrGetRenderModelStateEXT_ptr);
			nativeLib.LoadFunction("xrEnumerateInteractionRenderModelIdsEXT",  out xrEnumerateInteractionRenderModelIdsEXT_ptr);
			nativeLib.LoadFunction("xrEnumerateRenderModelSubactionPathsEXT",  out xrEnumerateRenderModelSubactionPathsEXT_ptr);
			nativeLib.LoadFunction("xrGetRenderModelPoseTopLevelUserPathEXT",  out xrGetRenderModelPoseTopLevelUserPathEXT_ptr);
			nativeLib.LoadFunction("xrSetTrackingOptimizationSettingsHintQCOM",  out xrSetTrackingOptimizationSettingsHintQCOM_ptr);
			nativeLib.LoadFunction("xrCreatePassthroughHTC",  out xrCreatePassthroughHTC_ptr);
			nativeLib.LoadFunction("xrDestroyPassthroughHTC",  out xrDestroyPassthroughHTC_ptr);
			nativeLib.LoadFunction("xrApplyFoveationHTC",  out xrApplyFoveationHTC_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorHTC",  out xrCreateSpatialAnchorHTC_ptr);
			nativeLib.LoadFunction("xrGetSpatialAnchorNameHTC",  out xrGetSpatialAnchorNameHTC_ptr);
			nativeLib.LoadFunction("xrCreateBodyTrackerHTC",  out xrCreateBodyTrackerHTC_ptr);
			nativeLib.LoadFunction("xrDestroyBodyTrackerHTC",  out xrDestroyBodyTrackerHTC_ptr);
			nativeLib.LoadFunction("xrLocateBodyJointsHTC",  out xrLocateBodyJointsHTC_ptr);
			nativeLib.LoadFunction("xrGetBodySkeletonHTC",  out xrGetBodySkeletonHTC_ptr);
			nativeLib.LoadFunction("xrApplyForceFeedbackCurlMNDX",  out xrApplyForceFeedbackCurlMNDX_ptr);
			nativeLib.LoadFunction("xrCreateBodyTrackerBD",  out xrCreateBodyTrackerBD_ptr);
			nativeLib.LoadFunction("xrDestroyBodyTrackerBD",  out xrDestroyBodyTrackerBD_ptr);
			nativeLib.LoadFunction("xrLocateBodyJointsBD",  out xrLocateBodyJointsBD_ptr);
			nativeLib.LoadFunction("xrEnumerateSpatialEntityComponentTypesBD",  out xrEnumerateSpatialEntityComponentTypesBD_ptr);
			nativeLib.LoadFunction("xrGetSpatialEntityUuidBD",  out xrGetSpatialEntityUuidBD_ptr);
			nativeLib.LoadFunction("xrGetSpatialEntityComponentDataBD",  out xrGetSpatialEntityComponentDataBD_ptr);
			nativeLib.LoadFunction("xrCreateSenseDataProviderBD",  out xrCreateSenseDataProviderBD_ptr);
			nativeLib.LoadFunction("xrStartSenseDataProviderAsyncBD",  out xrStartSenseDataProviderAsyncBD_ptr);
			nativeLib.LoadFunction("xrStartSenseDataProviderCompleteBD",  out xrStartSenseDataProviderCompleteBD_ptr);
			nativeLib.LoadFunction("xrGetSenseDataProviderStateBD",  out xrGetSenseDataProviderStateBD_ptr);
			nativeLib.LoadFunction("xrQuerySenseDataAsyncBD",  out xrQuerySenseDataAsyncBD_ptr);
			nativeLib.LoadFunction("xrQuerySenseDataCompleteBD",  out xrQuerySenseDataCompleteBD_ptr);
			nativeLib.LoadFunction("xrDestroySenseDataSnapshotBD",  out xrDestroySenseDataSnapshotBD_ptr);
			nativeLib.LoadFunction("xrGetQueriedSenseDataBD",  out xrGetQueriedSenseDataBD_ptr);
			nativeLib.LoadFunction("xrStopSenseDataProviderBD",  out xrStopSenseDataProviderBD_ptr);
			nativeLib.LoadFunction("xrDestroySenseDataProviderBD",  out xrDestroySenseDataProviderBD_ptr);
			nativeLib.LoadFunction("xrCreateSpatialEntityAnchorBD",  out xrCreateSpatialEntityAnchorBD_ptr);
			nativeLib.LoadFunction("xrDestroyAnchorBD",  out xrDestroyAnchorBD_ptr);
			nativeLib.LoadFunction("xrGetAnchorUuidBD",  out xrGetAnchorUuidBD_ptr);
			nativeLib.LoadFunction("xrCreateAnchorSpaceBD",  out xrCreateAnchorSpaceBD_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorAsyncBD",  out xrCreateSpatialAnchorAsyncBD_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorCompleteBD",  out xrCreateSpatialAnchorCompleteBD_ptr);
			nativeLib.LoadFunction("xrPersistSpatialAnchorAsyncBD",  out xrPersistSpatialAnchorAsyncBD_ptr);
			nativeLib.LoadFunction("xrPersistSpatialAnchorCompleteBD",  out xrPersistSpatialAnchorCompleteBD_ptr);
			nativeLib.LoadFunction("xrUnpersistSpatialAnchorAsyncBD",  out xrUnpersistSpatialAnchorAsyncBD_ptr);
			nativeLib.LoadFunction("xrUnpersistSpatialAnchorCompleteBD",  out xrUnpersistSpatialAnchorCompleteBD_ptr);
			nativeLib.LoadFunction("xrShareSpatialAnchorAsyncBD",  out xrShareSpatialAnchorAsyncBD_ptr);
			nativeLib.LoadFunction("xrShareSpatialAnchorCompleteBD",  out xrShareSpatialAnchorCompleteBD_ptr);
			nativeLib.LoadFunction("xrDownloadSharedSpatialAnchorAsyncBD",  out xrDownloadSharedSpatialAnchorAsyncBD_ptr);
			nativeLib.LoadFunction("xrDownloadSharedSpatialAnchorCompleteBD",  out xrDownloadSharedSpatialAnchorCompleteBD_ptr);
			nativeLib.LoadFunction("xrCaptureSceneAsyncBD",  out xrCaptureSceneAsyncBD_ptr);
			nativeLib.LoadFunction("xrCaptureSceneCompleteBD",  out xrCaptureSceneCompleteBD_ptr);
			nativeLib.LoadFunction("xrCreatePlaneDetectorEXT",  out xrCreatePlaneDetectorEXT_ptr);
			nativeLib.LoadFunction("xrDestroyPlaneDetectorEXT",  out xrDestroyPlaneDetectorEXT_ptr);
			nativeLib.LoadFunction("xrBeginPlaneDetectionEXT",  out xrBeginPlaneDetectionEXT_ptr);
			nativeLib.LoadFunction("xrGetPlaneDetectionStateEXT",  out xrGetPlaneDetectionStateEXT_ptr);
			nativeLib.LoadFunction("xrGetPlaneDetectionsEXT",  out xrGetPlaneDetectionsEXT_ptr);
			nativeLib.LoadFunction("xrGetPlanePolygonBufferEXT",  out xrGetPlanePolygonBufferEXT_ptr);
			nativeLib.LoadFunction("xrEnumerateSupportedTrackableTypesANDROID",  out xrEnumerateSupportedTrackableTypesANDROID_ptr);
			nativeLib.LoadFunction("xrEnumerateSupportedAnchorTrackableTypesANDROID",  out xrEnumerateSupportedAnchorTrackableTypesANDROID_ptr);
			nativeLib.LoadFunction("xrCreateTrackableTrackerANDROID",  out xrCreateTrackableTrackerANDROID_ptr);
			nativeLib.LoadFunction("xrDestroyTrackableTrackerANDROID",  out xrDestroyTrackableTrackerANDROID_ptr);
			nativeLib.LoadFunction("xrGetAllTrackablesANDROID",  out xrGetAllTrackablesANDROID_ptr);
			nativeLib.LoadFunction("xrGetTrackablePlaneANDROID",  out xrGetTrackablePlaneANDROID_ptr);
			nativeLib.LoadFunction("xrCreateAnchorSpaceANDROID",  out xrCreateAnchorSpaceANDROID_ptr);
			nativeLib.LoadFunction("xrEnumerateSupportedPersistenceAnchorTypesANDROID",  out xrEnumerateSupportedPersistenceAnchorTypesANDROID_ptr);
			nativeLib.LoadFunction("xrCreateDeviceAnchorPersistenceANDROID",  out xrCreateDeviceAnchorPersistenceANDROID_ptr);
			nativeLib.LoadFunction("xrDestroyDeviceAnchorPersistenceANDROID",  out xrDestroyDeviceAnchorPersistenceANDROID_ptr);
			nativeLib.LoadFunction("xrPersistAnchorANDROID",  out xrPersistAnchorANDROID_ptr);
			nativeLib.LoadFunction("xrGetAnchorPersistStateANDROID",  out xrGetAnchorPersistStateANDROID_ptr);
			nativeLib.LoadFunction("xrCreatePersistedAnchorSpaceANDROID",  out xrCreatePersistedAnchorSpaceANDROID_ptr);
			nativeLib.LoadFunction("xrEnumeratePersistedAnchorsANDROID",  out xrEnumeratePersistedAnchorsANDROID_ptr);
			nativeLib.LoadFunction("xrUnpersistAnchorANDROID",  out xrUnpersistAnchorANDROID_ptr);
			nativeLib.LoadFunction("xrGetPassthroughCameraStateANDROID",  out xrGetPassthroughCameraStateANDROID_ptr);
			nativeLib.LoadFunction("xrEnumerateRaycastSupportedTrackableTypesANDROID",  out xrEnumerateRaycastSupportedTrackableTypesANDROID_ptr);
			nativeLib.LoadFunction("xrRaycastANDROID",  out xrRaycastANDROID_ptr);
			nativeLib.LoadFunction("xrGetTrackableObjectANDROID",  out xrGetTrackableObjectANDROID_ptr);
			nativeLib.LoadFunction("xrPollFutureEXT",  out xrPollFutureEXT_ptr);
			nativeLib.LoadFunction("xrCancelFutureEXT",  out xrCancelFutureEXT_ptr);
			nativeLib.LoadFunction("xrSetSystemNotificationsML",  out xrSetSystemNotificationsML_ptr);
			nativeLib.LoadFunction("xrCreateWorldMeshDetectorML",  out xrCreateWorldMeshDetectorML_ptr);
			nativeLib.LoadFunction("xrDestroyWorldMeshDetectorML",  out xrDestroyWorldMeshDetectorML_ptr);
			nativeLib.LoadFunction("xrRequestWorldMeshStateAsyncML",  out xrRequestWorldMeshStateAsyncML_ptr);
			nativeLib.LoadFunction("xrRequestWorldMeshStateCompleteML",  out xrRequestWorldMeshStateCompleteML_ptr);
			nativeLib.LoadFunction("xrGetWorldMeshBufferRecommendSizeML",  out xrGetWorldMeshBufferRecommendSizeML_ptr);
			nativeLib.LoadFunction("xrAllocateWorldMeshBufferML",  out xrAllocateWorldMeshBufferML_ptr);
			nativeLib.LoadFunction("xrFreeWorldMeshBufferML",  out xrFreeWorldMeshBufferML_ptr);
			nativeLib.LoadFunction("xrRequestWorldMeshAsyncML",  out xrRequestWorldMeshAsyncML_ptr);
			nativeLib.LoadFunction("xrRequestWorldMeshCompleteML",  out xrRequestWorldMeshCompleteML_ptr);
			nativeLib.LoadFunction("xrCreateFacialExpressionClientML",  out xrCreateFacialExpressionClientML_ptr);
			nativeLib.LoadFunction("xrDestroyFacialExpressionClientML",  out xrDestroyFacialExpressionClientML_ptr);
			nativeLib.LoadFunction("xrGetFacialExpressionBlendShapePropertiesML",  out xrGetFacialExpressionBlendShapePropertiesML_ptr);
			nativeLib.LoadFunction("xrResumeSimultaneousHandsAndControllersTrackingMETA",  out xrResumeSimultaneousHandsAndControllersTrackingMETA_ptr);
			nativeLib.LoadFunction("xrPauseSimultaneousHandsAndControllersTrackingMETA",  out xrPauseSimultaneousHandsAndControllersTrackingMETA_ptr);
			nativeLib.LoadFunction("xrStartColocationDiscoveryMETA",  out xrStartColocationDiscoveryMETA_ptr);
			nativeLib.LoadFunction("xrStopColocationDiscoveryMETA",  out xrStopColocationDiscoveryMETA_ptr);
			nativeLib.LoadFunction("xrStartColocationAdvertisementMETA",  out xrStartColocationAdvertisementMETA_ptr);
			nativeLib.LoadFunction("xrStopColocationAdvertisementMETA",  out xrStopColocationAdvertisementMETA_ptr);
			nativeLib.LoadFunction("xrShareAnchorANDROID",  out xrShareAnchorANDROID_ptr);
			nativeLib.LoadFunction("xrUnshareAnchorANDROID",  out xrUnshareAnchorANDROID_ptr);
			nativeLib.LoadFunction("xrGetTrackableMarkerANDROID",  out xrGetTrackableMarkerANDROID_ptr);
			nativeLib.LoadFunction("xrEnumerateSpatialCapabilitiesEXT",  out xrEnumerateSpatialCapabilitiesEXT_ptr);
			nativeLib.LoadFunction("xrEnumerateSpatialCapabilityComponentTypesEXT",  out xrEnumerateSpatialCapabilityComponentTypesEXT_ptr);
			nativeLib.LoadFunction("xrEnumerateSpatialCapabilityFeaturesEXT",  out xrEnumerateSpatialCapabilityFeaturesEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialContextAsyncEXT",  out xrCreateSpatialContextAsyncEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialContextCompleteEXT",  out xrCreateSpatialContextCompleteEXT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialContextEXT",  out xrDestroySpatialContextEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialDiscoverySnapshotAsyncEXT",  out xrCreateSpatialDiscoverySnapshotAsyncEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialDiscoverySnapshotCompleteEXT",  out xrCreateSpatialDiscoverySnapshotCompleteEXT_ptr);
			nativeLib.LoadFunction("xrQuerySpatialComponentDataEXT",  out xrQuerySpatialComponentDataEXT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialSnapshotEXT",  out xrDestroySpatialSnapshotEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialEntityFromIdEXT",  out xrCreateSpatialEntityFromIdEXT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialEntityEXT",  out xrDestroySpatialEntityEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialUpdateSnapshotEXT",  out xrCreateSpatialUpdateSnapshotEXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferStringEXT",  out xrGetSpatialBufferStringEXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferUint8EXT",  out xrGetSpatialBufferUint8EXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferUint16EXT",  out xrGetSpatialBufferUint16EXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferUint32EXT",  out xrGetSpatialBufferUint32EXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferFloatEXT",  out xrGetSpatialBufferFloatEXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferVector2fEXT",  out xrGetSpatialBufferVector2fEXT_ptr);
			nativeLib.LoadFunction("xrGetSpatialBufferVector3fEXT",  out xrGetSpatialBufferVector3fEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialAnchorEXT",  out xrCreateSpatialAnchorEXT_ptr);
			nativeLib.LoadFunction("xrEnumerateSpatialPersistenceScopesEXT",  out xrEnumerateSpatialPersistenceScopesEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialPersistenceContextAsyncEXT",  out xrCreateSpatialPersistenceContextAsyncEXT_ptr);
			nativeLib.LoadFunction("xrCreateSpatialPersistenceContextCompleteEXT",  out xrCreateSpatialPersistenceContextCompleteEXT_ptr);
			nativeLib.LoadFunction("xrDestroySpatialPersistenceContextEXT",  out xrDestroySpatialPersistenceContextEXT_ptr);
			nativeLib.LoadFunction("xrPersistSpatialEntityAsyncEXT",  out xrPersistSpatialEntityAsyncEXT_ptr);
			nativeLib.LoadFunction("xrPersistSpatialEntityCompleteEXT",  out xrPersistSpatialEntityCompleteEXT_ptr);
			nativeLib.LoadFunction("xrUnpersistSpatialEntityAsyncEXT",  out xrUnpersistSpatialEntityAsyncEXT_ptr);
			nativeLib.LoadFunction("xrUnpersistSpatialEntityCompleteEXT",  out xrUnpersistSpatialEntityCompleteEXT_ptr);
		}
	}
}
