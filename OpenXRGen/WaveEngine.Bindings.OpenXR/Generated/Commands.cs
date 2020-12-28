using System;
using System.Runtime.InteropServices;

namespace WaveEngine.Bindings.OpenXR
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
		private delegate XrResult xrEnumerateColorSpacesFBDelegate(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces);
		private static xrEnumerateColorSpacesFBDelegate xrEnumerateColorSpacesFB_ptr;
		public static XrResult xrEnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces)
			=> xrEnumerateColorSpacesFB_ptr(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);

		[UnmanagedFunctionPointer(CallConv)]
		private delegate XrResult xrSetColorSpaceFBDelegate(XrSession session, XrColorSpaceFB colorspace);
		private static xrSetColorSpaceFBDelegate xrSetColorSpaceFB_ptr;
		public static XrResult xrSetColorSpaceFB(XrSession session, XrColorSpaceFB colorspace)
			=> xrSetColorSpaceFB_ptr(session, colorspace);

		public static void LoadFuncionPointers()
		{
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
			nativeLib.LoadFunction("xrInitializeLoaderKHR",  out xrInitializeLoaderKHR_ptr);
			nativeLib.LoadFunction("xrCreateVulkanInstanceKHR",  out xrCreateVulkanInstanceKHR_ptr);
			nativeLib.LoadFunction("xrCreateVulkanDeviceKHR",  out xrCreateVulkanDeviceKHR_ptr);
			nativeLib.LoadFunction("xrGetVulkanGraphicsDevice2KHR",  out xrGetVulkanGraphicsDevice2KHR_ptr);
			nativeLib.LoadFunction("xrEnumerateDisplayRefreshRatesFB",  out xrEnumerateDisplayRefreshRatesFB_ptr);
			nativeLib.LoadFunction("xrGetDisplayRefreshRateFB",  out xrGetDisplayRefreshRateFB_ptr);
			nativeLib.LoadFunction("xrRequestDisplayRefreshRateFB",  out xrRequestDisplayRefreshRateFB_ptr);
			nativeLib.LoadFunction("xrEnumerateColorSpacesFB",  out xrEnumerateColorSpacesFB_ptr);
			nativeLib.LoadFunction("xrSetColorSpaceFB",  out xrSetColorSpaceFB_ptr);
		}
	}
}
