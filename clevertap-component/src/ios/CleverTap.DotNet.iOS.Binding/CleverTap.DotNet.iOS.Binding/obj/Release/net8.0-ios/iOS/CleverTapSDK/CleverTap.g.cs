//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace CleverTapSDK {
	[Preserve]
	[Protocol (Name = "CleverTap", WrapperType = typeof (CleverTapWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SharedInstance", Selector = "sharedInstance", ReturnType = typeof (CleverTapSDK.CleverTap))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SharedInstanceWithCleverTapID", Selector = "sharedInstanceWithCleverTapID:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "AutoIntegrate", Selector = "autoIntegrate", ReturnType = typeof (CleverTapSDK.CleverTap))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "AutoIntegrateWithCleverTapID", Selector = "autoIntegrateWithCleverTapID:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "InstanceWithConfig", Selector = "instanceWithConfig:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInstanceConfig) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "InstanceWithConfig", Selector = "instanceWithConfig:andCleverTapID:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInstanceConfig), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetGlobalInstance", Selector = "getGlobalInstance:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "ChangeCredentialsWithAccountID", Selector = "changeCredentialsWithAccountID:andToken:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "ChangeCredentialsWithAccountID", Selector = "changeCredentialsWithAccountID:token:region:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:andToken:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:token:region:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotifyApplicationLaunchedWithOptions", Selector = "notifyApplicationLaunchedWithOptions:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "EnablePersonalization", Selector = "enablePersonalization")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "DisablePersonalization", Selector = "disablePersonalization")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetLocation", Selector = "setLocation:", ParameterType = new Type [] { typeof (CLLocationCoordinate2D) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetLocationWithSuccess", Selector = "getLocationWithSuccess:andError:", ParameterType = new Type [] { typeof (global::System.Action<global::CoreLocation.CLLocationCoordinate2D>), typeof (global::System.Action<NSString>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0), typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnUserLogin", Selector = "onUserLogin:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnUserLogin", Selector = "onUserLogin:withCleverTapID:", ParameterType = new Type [] { typeof (NSDictionary), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetOptOut", Selector = "setOptOut:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetOffline", Selector = "setOffline:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EnableDeviceNetworkInfoReporting", Selector = "enableDeviceNetworkInfoReporting:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfilePush", Selector = "profilePush:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileRemoveValueForKey", Selector = "profileRemoveValueForKey:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileSetMultiValues", Selector = "profileSetMultiValues:forKey:", ParameterType = new Type [] { typeof (String[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileAddMultiValue", Selector = "profileAddMultiValue:forKey:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileAddMultiValues", Selector = "profileAddMultiValues:forKey:", ParameterType = new Type [] { typeof (String[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileRemoveMultiValue", Selector = "profileRemoveMultiValue:forKey:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileRemoveMultiValues", Selector = "profileRemoveMultiValues:forKey:", ParameterType = new Type [] { typeof (String[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileIncrementValueBy", Selector = "profileIncrementValueBy:forKey:", ParameterType = new Type [] { typeof (NSNumber), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDecrementValueBy", Selector = "profileDecrementValueBy:forKey:", ParameterType = new Type [] { typeof (NSNumber), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileGet", Selector = "profileGet:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordEvent", Selector = "recordEvent:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordEvent", Selector = "recordEvent:withProps:", ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordChargedEventWithDetails", Selector = "recordChargedEventWithDetails:andItems:", ParameterType = new Type [] { typeof (NSDictionary), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordErrorWithMessage", Selector = "recordErrorWithMessage:andErrorCode:", ParameterType = new Type [] { typeof (string), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordScreenView", Selector = "recordScreenView:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordNotificationViewedEventWithData", Selector = "recordNotificationViewedEventWithData:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordNotificationClickedEventWithData", Selector = "recordNotificationClickedEventWithData:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetFirstTime", Selector = "eventGetFirstTime:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetLastTime", Selector = "eventGetLastTime:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetOccurrences", Selector = "eventGetOccurrences:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetDetail", Selector = "eventGetDetail:", ReturnType = typeof (CleverTapSDK.CleverTapEventDetail), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSyncDelegate", Selector = "setSyncDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapSyncDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPushNotificationDelegate", Selector = "setPushNotificationDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapPushNotificationDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetInAppNotificationDelegate", Selector = "setInAppNotificationDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInAppNotificationDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetUrlDelegate", Selector = "setUrlDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapURLDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPushToken", Selector = "setPushToken:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPushTokenAsString", Selector = "setPushTokenAsString:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleNotificationWithData", Selector = "handleNotificationWithData:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleNotificationWithData", Selector = "handleNotificationWithData:openDeepLinksInForeground:", ParameterType = new Type [] { typeof (NSObject), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "HandlePushNotification", Selector = "handlePushNotification:openDeepLinksInForeground:", ParameterType = new Type [] { typeof (NSDictionary), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsCleverTapNotification", Selector = "isCleverTapNotification:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowInAppNotificationIfAny", Selector = "showInAppNotificationIfAny")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleOpenURL", Selector = "handleOpenURL:sourceApplication:", ParameterType = new Type [] { typeof (NSUrl), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "HandleOpenURL", Selector = "handleOpenURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PushInstallReferrerSource", Selector = "pushInstallReferrerSource:medium:campaign:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetDebugLevel", Selector = "setDebugLevel:", ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLibrary", Selector = "setLibrary:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLocationForGeofences", Selector = "setLocationForGeofences:withPluginVersion:", ParameterType = new Type [] { typeof (CLLocationCoordinate2D), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToRegisterForGeofencesWithError", Selector = "didFailToRegisterForGeofencesWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordGeofenceEnteredEvent", Selector = "recordGeofenceEnteredEvent:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordGeofenceExitedEvent", Selector = "recordGeofenceExitedEvent:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordSignedCallEvent", Selector = "recordSignedCallEvent:forCallDetails:", ParameterType = new Type [] { typeof (int), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSignedCallVersion", Selector = "setSignedCallVersion:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetDomainDelegate", Selector = "setDomainDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapDomainDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IsValidCleverTapId", Selector = "isValidCleverTapId:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Config", Selector = "config", PropertyType = typeof (CleverTapSDK.CleverTapInstanceConfig), GetterSelector = "config", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SignedCallDomain", Selector = "signedCallDomain", PropertyType = typeof (string), GetterSelector = "signedCallDomain", SetterSelector = "setSignedCallDomain:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProfileGetCleverTapID", Selector = "profileGetCleverTapID", PropertyType = typeof (string), GetterSelector = "profileGetCleverTapID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountID", Selector = "getAccountID", PropertyType = typeof (string), GetterSelector = "getAccountID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProfileGetCleverTapAttributionIdentifier", Selector = "profileGetCleverTapAttributionIdentifier", PropertyType = typeof (string), GetterSelector = "profileGetCleverTapAttributionIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetEventHistory", Selector = "userGetEventHistory", PropertyType = typeof (NSDictionary), GetterSelector = "userGetEventHistory", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SessionGetTimeElapsed", Selector = "sessionGetTimeElapsed", PropertyType = typeof (double), GetterSelector = "sessionGetTimeElapsed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SessionGetUTMDetails", Selector = "sessionGetUTMDetails", PropertyType = typeof (CleverTapSDK.CleverTapUTMDetail), GetterSelector = "sessionGetUTMDetails", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetTotalVisits", Selector = "userGetTotalVisits", PropertyType = typeof (int), GetterSelector = "userGetTotalVisits", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetScreenCount", Selector = "userGetScreenCount", PropertyType = typeof (int), GetterSelector = "userGetScreenCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetPreviousVisitTime", Selector = "userGetPreviousVisitTime", PropertyType = typeof (double), GetterSelector = "userGetPreviousVisitTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "DebugLevel", Selector = "getDebugLevel", PropertyType = typeof (CleverTapSDK.CleverTapLogLevel), GetterSelector = "getDebugLevel", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DomainString", Selector = "getDomainString", PropertyType = typeof (string), GetterSelector = "getDomainString", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICleverTap : INativeObject, IDisposable
	{
	}
	[Preserve]
	public unsafe static partial class CleverTap_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NotifyApplicationLaunchedWithOptions (this ICleverTap This, NSObject launchOptions)
		{
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnUserLogin (this ICleverTap This, NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("onUserLogin:"), properties__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnUserLogin (this ICleverTap This, NSDictionary properties, string cleverTapID)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
			CFString.ReleaseNative (nscleverTapID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetOptOut (this ICleverTap This, bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setOptOut:"), enabled ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetOffline (this ICleverTap This, bool offline)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setOffline:"), offline ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableDeviceNetworkInfoReporting (this ICleverTap This, bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("enableDeviceNetworkInfoReporting:"), enabled ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfilePush (this ICleverTap This, NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profilePush:"), properties__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileRemoveValueForKey (this ICleverTap This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileSetMultiValues (this ICleverTap This, string[] values, string key)
		{
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_values = NSArray.FromStrings (values);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			nsa_values.Dispose ();
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileAddMultiValue (this ICleverTap This, string value, string key)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsvalue = CFString.CreateNative (value);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileAddMultiValues (this ICleverTap This, string[] values, string key)
		{
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_values = NSArray.FromStrings (values);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			nsa_values.Dispose ();
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileRemoveMultiValue (this ICleverTap This, string value, string key)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsvalue = CFString.CreateNative (value);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileRemoveMultiValues (this ICleverTap This, string[] values, string key)
		{
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_values = NSArray.FromStrings (values);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			nsa_values.Dispose ();
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileIncrementValueBy (this ICleverTap This, NSNumber value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileIncrementValueBy:forKey:"), value__handle__, nskey);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDecrementValueBy (this ICleverTap This, NSNumber value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileDecrementValueBy:forKey:"), value__handle__, nskey);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? ProfileGet (this ICleverTap This, string propertyName)
		{
			if (propertyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (propertyName));
			var nspropertyName = CFString.CreateNative (propertyName);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profileGet:"), nspropertyName))!;
			CFString.ReleaseNative (nspropertyName);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordEvent (this ICleverTap This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("recordEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordEvent (this ICleverTap This, string @event, NSDictionary properties)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			var nsevent = CFString.CreateNative (@event);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			CFString.ReleaseNative (nsevent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordChargedEventWithDetails (this ICleverTap This, NSDictionary chargeDetails, NSObject[] items)
		{
			var chargeDetails__handle__ = chargeDetails!.GetNonNullHandle (nameof (chargeDetails));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var nsa_items = NSArray.FromNSObjects (items);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails__handle__, nsa_items.Handle);
			nsa_items.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordErrorWithMessage (this ICleverTap This, string message, int code)
		{
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_int (This.Handle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			CFString.ReleaseNative (nsmessage);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordScreenView (this ICleverTap This, string screenName)
		{
			if (screenName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (screenName));
			var nsscreenName = CFString.CreateNative (screenName);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			CFString.ReleaseNative (nsscreenName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordNotificationViewedEventWithData (this ICleverTap This, NSObject notificationData)
		{
			var notificationData__handle__ = notificationData!.GetNonNullHandle (nameof (notificationData));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordNotificationClickedEventWithData (this ICleverTap This, NSObject notificationData)
		{
			var notificationData__handle__ = notificationData!.GetNonNullHandle (nameof (notificationData));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("recordNotificationClickedEventWithData:"), notificationData__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double EventGetFirstTime (this ICleverTap This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double EventGetLastTime (this ICleverTap This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int EventGetOccurrences (this ICleverTap This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapEventDetail? EventGetDetail (this ICleverTap This, string? @event)
		{
			var nsevent = CFString.CreateNative (@event);
			CleverTapEventDetail? ret;
			ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("eventGetDetail:"), nsevent))!;
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSyncDelegate (this ICleverTap This, CleverTapSyncDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPushNotificationDelegate (this ICleverTap This, CleverTapPushNotificationDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPushNotificationDelegate:"), @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInAppNotificationDelegate (this ICleverTap This, CleverTapInAppNotificationDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUrlDelegate (this ICleverTap This, CleverTapURLDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setUrlDelegate:"), @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPushToken (this ICleverTap This, NSData pushToken)
		{
			var pushToken__handle__ = pushToken!.GetNonNullHandle (nameof (pushToken));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPushToken:"), pushToken__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPushTokenAsString (this ICleverTap This, string pushTokenString)
		{
			if (pushTokenString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pushTokenString));
			var nspushTokenString = CFString.CreateNative (pushTokenString);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			CFString.ReleaseNative (nspushTokenString);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleNotificationWithData (this ICleverTap This, NSObject data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handleNotificationWithData:"), data__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleNotificationWithData (this ICleverTap This, NSObject data, bool openInForeground)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data__handle__, openInForeground ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCleverTapNotification (this ICleverTap This, NSDictionary payload)
		{
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowInAppNotificationIfAny (this ICleverTap This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("showInAppNotificationIfAny"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleOpenURL (this ICleverTap This, NSUrl url, string? sourceApplication)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nssourceApplication = CFString.CreateNative (sourceApplication);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			CFString.ReleaseNative (nssourceApplication);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PushInstallReferrerSource (this ICleverTap This, string? source, string? medium, string? campaign)
		{
			var nssource = CFString.CreateNative (source);
			var nsmedium = CFString.CreateNative (medium);
			var nscampaign = CFString.CreateNative (campaign);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			CFString.ReleaseNative (nssource);
			CFString.ReleaseNative (nsmedium);
			CFString.ReleaseNative (nscampaign);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLibrary (this ICleverTap This, string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLibrary:"), nsname);
			CFString.ReleaseNative (nsname);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLocationForGeofences (this ICleverTap This, global::CoreLocation.CLLocationCoordinate2D location, string? version)
		{
			var nsversion = CFString.CreateNative (version);
			global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_NativeHandle (This.Handle, Selector.GetHandle ("setLocationForGeofences:withPluginVersion:"), location, nsversion);
			CFString.ReleaseNative (nsversion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFailToRegisterForGeofencesWithError (this ICleverTap This, NSError? error)
		{
			var error__handle__ = error.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didFailToRegisterForGeofencesWithError:"), error__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordGeofenceEnteredEvent (this ICleverTap This, NSDictionary geofenceDetails)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("recordGeofenceEnteredEvent:"), geofenceDetails__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordGeofenceExitedEvent (this ICleverTap This, NSDictionary geofenceDetails)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("recordGeofenceExitedEvent:"), geofenceDetails__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordSignedCallEvent (this ICleverTap This, int eventRawValue, NSDictionary calldetails)
		{
			var calldetails__handle__ = calldetails!.GetNonNullHandle (nameof (calldetails));
			global::ApiDefinition.Messaging.void_objc_msgSend_int_NativeHandle (This.Handle, Selector.GetHandle ("recordSignedCallEvent:forCallDetails:"), eventRawValue, calldetails__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSignedCallVersion (this ICleverTap This, string? version)
		{
			var nsversion = CFString.CreateNative (version);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSignedCallVersion:"), nsversion);
			CFString.ReleaseNative (nsversion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDomainDelegate (this ICleverTap This, CleverTapDomainDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDomainDelegate:"), @delegate__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInstanceConfig GetConfig (this ICleverTap This)
		{
			return  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("config")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSignedCallDomain (this ICleverTap This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("signedCallDomain")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSignedCallDomain (this ICleverTap This, string value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setSignedCallDomain:"), nsvalue);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetProfileGetCleverTapID (this ICleverTap This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("profileGetCleverTapID")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountID (this ICleverTap This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("getAccountID")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetProfileGetCleverTapAttributionIdentifier (this ICleverTap This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetUserGetEventHistory (this ICleverTap This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("userGetEventHistory")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetSessionGetTimeElapsed (this ICleverTap This)
		{
			return global::ApiDefinition.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("sessionGetTimeElapsed"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapUTMDetail GetSessionGetUTMDetails (this ICleverTap This)
		{
			return  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sessionGetUTMDetails")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetUserGetTotalVisits (this ICleverTap This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("userGetTotalVisits"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetUserGetScreenCount (this ICleverTap This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("userGetScreenCount"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetUserGetPreviousVisitTime (this ICleverTap This)
		{
			return global::ApiDefinition.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("userGetPreviousVisitTime"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDomainString (this ICleverTap This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("getDomainString")))!;
		}
	}
	[Preserve]
	internal unsafe sealed class CleverTapWrapper : BaseWrapper, ICleverTap {
		[Preserve (Conditional = true)]
		public CleverTapWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CleverTap", true)]
	[Preserve]
	public unsafe partial class CleverTap : NSObject, ICleverTap {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CleverTap");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTap () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTap (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTap (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("autoIntegrate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? AutoIntegrate ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("autoIntegrate")))!;
		}
		[Export ("autoIntegrateWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? AutoIntegrateWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			CleverTap? ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("autoIntegrateWithCleverTapID:"), nscleverTapID))!;
			CFString.ReleaseNative (nscleverTapID);
			return ret!;
		}
		[Export ("changeCredentialsWithAccountID:andToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeCredentialsWithAccountID (string accountID, string token)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("changeCredentialsWithAccountID:andToken:"), nsaccountID, nstoken);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
		}
		[Export ("changeCredentialsWithAccountID:token:region:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeCredentialsWithAccountID (string accountID, string token, string region)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (region is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (region));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsregion = CFString.CreateNative (region);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("changeCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsregion);
		}
		[Export ("didFailToRegisterForGeofencesWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFailToRegisterForGeofencesWithError (NSError? error)
		{
			var error__handle__ = error.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didFailToRegisterForGeofencesWithError:"), error__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("didFailToRegisterForGeofencesWithError:"), error__handle__);
			}
		}
		[Export ("disablePersonalization")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisablePersonalization ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("disablePersonalization"));
		}
		[Export ("enableDeviceNetworkInfoReporting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnableDeviceNetworkInfoReporting (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableDeviceNetworkInfoReporting:"), enabled ? (byte) 1 : (byte) 0);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableDeviceNetworkInfoReporting:"), enabled ? (byte) 1 : (byte) 0);
			}
		}
		[Export ("enablePersonalization")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnablePersonalization ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("enablePersonalization"));
		}
		[Export ("eventGetDetail:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapEventDetail? EventGetDetail (string? @event)
		{
			var nsevent = CFString.CreateNative (@event);
			CleverTapEventDetail? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("eventGetDetail:"), nsevent))!;
			} else {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("eventGetDetail:"), nsevent))!;
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("eventGetFirstTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EventGetFirstTime (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("eventGetLastTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EventGetLastTime (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("eventGetOccurrences:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int EventGetOccurrences (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("getGlobalInstance:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? GetGlobalInstance (string accountId)
		{
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			var nsaccountId = CFString.CreateNative (accountId);
			CleverTap? ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getGlobalInstance:"), nsaccountId))!;
			CFString.ReleaseNative (nsaccountId);
			return ret!;
		}
		[Export ("getLocationWithSuccess:andError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetLocationWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::CoreLocation.CLLocationCoordinate2D> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSString>? error)
		{
			if (success is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (success));
			using var block_success = Trampolines.SDActionArity1V0.CreateBlock (success);
			BlockLiteral *block_ptr_success = &block_success;
			using var block_error = Trampolines.SDActionArity1V1.CreateNullableBlock (error);
			BlockLiteral *block_ptr_error = null;
			if (error is not null)
				block_ptr_error = &block_error;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("getLocationWithSuccess:andError:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_error);
		}
		[Export ("handleNotificationWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationWithData (NSObject data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("handleNotificationWithData:"), data__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("handleNotificationWithData:"), data__handle__);
			}
		}
		[Export ("handleNotificationWithData:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationWithData (NSObject data, bool openInForeground)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data__handle__, openInForeground ? (byte) 1 : (byte) 0);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_bool (this.SuperHandle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data__handle__, openInForeground ? (byte) 1 : (byte) 0);
			}
		}
		[Export ("handleOpenURL:sourceApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleOpenURL (NSUrl url, string? sourceApplication)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nssourceApplication = CFString.CreateNative (sourceApplication);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			}
			CFString.ReleaseNative (nssourceApplication);
		}
		[Export ("handleOpenURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleOpenURL (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("handleOpenURL:"), url__handle__);
		}
		[Export ("handlePushNotification:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandlePushNotification (NSDictionary notification, bool openInForeground)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("handlePushNotification:openDeepLinksInForeground:"), notification__handle__, openInForeground ? (byte) 1 : (byte) 0);
		}
		[Export ("instanceWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("instanceWithConfig:"), config__handle__))!;
		}
		[Export ("instanceWithConfig:andCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config, string cleverTapID)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			CleverTap? ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("instanceWithConfig:andCleverTapID:"), config__handle__, nscleverTapID))!;
			CFString.ReleaseNative (nscleverTapID);
			return ret!;
		}
		[Export ("isCleverTapNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCleverTapNotification (NSDictionary payload)
		{
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			}
			return ret != 0;
		}
		[Export ("isValidCleverTapId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCleverTapId (string? cleverTapID)
		{
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isValidCleverTapId:"), nscleverTapID);
			CFString.ReleaseNative (nscleverTapID);
			return ret != 0;
		}
		[Export ("notifyApplicationLaunchedWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotifyApplicationLaunchedWithOptions (NSObject launchOptions)
		{
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions__handle__);
			}
		}
		[Export ("onUserLogin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUserLogin (NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("onUserLogin:"), properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("onUserLogin:"), properties__handle__);
			}
		}
		[Export ("onUserLogin:withCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUserLogin (NSDictionary properties, string cleverTapID)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
			}
			CFString.ReleaseNative (nscleverTapID);
		}
		[Export ("profileAddMultiValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileAddMultiValue (string value, string key)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsvalue = CFString.CreateNative (value);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			}
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nskey);
		}
		[Export ("profileAddMultiValues:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileAddMultiValues (string[] values, string key)
		{
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_values = NSArray.FromStrings (values);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			}
			nsa_values.Dispose ();
			CFString.ReleaseNative (nskey);
		}
		[Export ("profileDecrementValueBy:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDecrementValueBy (NSNumber value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileDecrementValueBy:forKey:"), value__handle__, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileDecrementValueBy:forKey:"), value__handle__, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("profileGet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ProfileGet (string propertyName)
		{
			if (propertyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (propertyName));
			var nspropertyName = CFString.CreateNative (propertyName);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("profileGet:"), nspropertyName))!;
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileGet:"), nspropertyName))!;
			}
			CFString.ReleaseNative (nspropertyName);
			return ret!;
		}
		[Export ("profileIncrementValueBy:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileIncrementValueBy (NSNumber value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileIncrementValueBy:forKey:"), value__handle__, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileIncrementValueBy:forKey:"), value__handle__, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("profilePush:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePush (NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("profilePush:"), properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("profilePush:"), properties__handle__);
			}
		}
		[Export ("profileRemoveMultiValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveMultiValue (string value, string key)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsvalue = CFString.CreateNative (value);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			}
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nskey);
		}
		[Export ("profileRemoveMultiValues:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveMultiValues (string[] values, string key)
		{
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_values = NSArray.FromStrings (values);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			}
			nsa_values.Dispose ();
			CFString.ReleaseNative (nskey);
		}
		[Export ("profileRemoveValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveValueForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("profileSetMultiValues:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileSetMultiValues (string[] values, string key)
		{
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_values = NSArray.FromStrings (values);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			}
			nsa_values.Dispose ();
			CFString.ReleaseNative (nskey);
		}
		[Export ("pushInstallReferrerSource:medium:campaign:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushInstallReferrerSource (string? source, string? medium, string? campaign)
		{
			var nssource = CFString.CreateNative (source);
			var nsmedium = CFString.CreateNative (medium);
			var nscampaign = CFString.CreateNative (campaign);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			}
			CFString.ReleaseNative (nssource);
			CFString.ReleaseNative (nsmedium);
			CFString.ReleaseNative (nscampaign);
		}
		[Export ("recordChargedEventWithDetails:andItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordChargedEventWithDetails (NSDictionary chargeDetails, NSObject[] items)
		{
			var chargeDetails__handle__ = chargeDetails!.GetNonNullHandle (nameof (chargeDetails));
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var nsa_items = NSArray.FromNSObjects (items);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails__handle__, nsa_items.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails__handle__, nsa_items.Handle);
			}
			nsa_items.Dispose ();
		}
		[Export ("recordErrorWithMessage:andErrorCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordErrorWithMessage (string message, int code)
		{
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_int (this.Handle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_int (this.SuperHandle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			}
			CFString.ReleaseNative (nsmessage);
		}
		[Export ("recordEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordEvent (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recordEvent:"), nsevent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordEvent:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
		}
		[Export ("recordEvent:withProps:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordEvent (string @event, NSDictionary properties)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			var nsevent = CFString.CreateNative (@event);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			}
			CFString.ReleaseNative (nsevent);
		}
		[Export ("recordGeofenceEnteredEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordGeofenceEnteredEvent (NSDictionary geofenceDetails)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recordGeofenceEnteredEvent:"), geofenceDetails__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordGeofenceEnteredEvent:"), geofenceDetails__handle__);
			}
		}
		[Export ("recordGeofenceExitedEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordGeofenceExitedEvent (NSDictionary geofenceDetails)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recordGeofenceExitedEvent:"), geofenceDetails__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordGeofenceExitedEvent:"), geofenceDetails__handle__);
			}
		}
		[Export ("recordNotificationClickedEventWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordNotificationClickedEventWithData (NSObject notificationData)
		{
			var notificationData__handle__ = notificationData!.GetNonNullHandle (nameof (notificationData));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recordNotificationClickedEventWithData:"), notificationData__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordNotificationClickedEventWithData:"), notificationData__handle__);
			}
		}
		[Export ("recordNotificationViewedEventWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordNotificationViewedEventWithData (NSObject notificationData)
		{
			var notificationData__handle__ = notificationData!.GetNonNullHandle (nameof (notificationData));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData__handle__);
			}
		}
		[Export ("recordScreenView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordScreenView (string screenName)
		{
			if (screenName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (screenName));
			var nsscreenName = CFString.CreateNative (screenName);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			}
			CFString.ReleaseNative (nsscreenName);
		}
		[Export ("recordSignedCallEvent:forCallDetails:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordSignedCallEvent (int eventRawValue, NSDictionary calldetails)
		{
			var calldetails__handle__ = calldetails!.GetNonNullHandle (nameof (calldetails));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_NativeHandle (this.Handle, Selector.GetHandle ("recordSignedCallEvent:forCallDetails:"), eventRawValue, calldetails__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_NativeHandle (this.SuperHandle, Selector.GetHandle ("recordSignedCallEvent:forCallDetails:"), eventRawValue, calldetails__handle__);
			}
		}
		[Export ("setCredentialsWithAccountID:andToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (string accountID, string token)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:andToken:"), nsaccountID, nstoken);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
		}
		[Export ("setCredentialsWithAccountID:token:region:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (string accountID, string token, string region)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (region is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (region));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsregion = CFString.CreateNative (region);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsregion);
		}
		[Export ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (string accountID, string token, string proxyDomain, string spikyProxyDomain)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (proxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (proxyDomain));
			if (spikyProxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spikyProxyDomain));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsproxyDomain = CFString.CreateNative (proxyDomain);
			var nsspikyProxyDomain = CFString.CreateNative (spikyProxyDomain);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:"), nsaccountID, nstoken, nsproxyDomain, nsspikyProxyDomain);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsproxyDomain);
			CFString.ReleaseNative (nsspikyProxyDomain);
		}
		[Export ("setDebugLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDebugLevel (int level)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setDebugLevel:"), level);
		}
		[Export ("setDomainDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDomainDelegate (CleverTapDomainDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDomainDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setDomainDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setInAppNotificationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInAppNotificationDelegate (CleverTapInAppNotificationDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setLibrary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLibrary (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLibrary:"), nsname);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setLibrary:"), nsname);
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("setLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLocation (global::CoreLocation.CLLocationCoordinate2D location)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D (class_ptr, Selector.GetHandle ("setLocation:"), location);
		}
		[Export ("setLocationForGeofences:withPluginVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocationForGeofences (global::CoreLocation.CLLocationCoordinate2D location, string? version)
		{
			var nsversion = CFString.CreateNative (version);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_NativeHandle (this.Handle, Selector.GetHandle ("setLocationForGeofences:withPluginVersion:"), location, nsversion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_NativeHandle (this.SuperHandle, Selector.GetHandle ("setLocationForGeofences:withPluginVersion:"), location, nsversion);
			}
			CFString.ReleaseNative (nsversion);
		}
		[Export ("setOffline:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOffline (bool offline)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOffline:"), offline ? (byte) 1 : (byte) 0);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOffline:"), offline ? (byte) 1 : (byte) 0);
			}
		}
		[Export ("setOptOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOptOut (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOptOut:"), enabled ? (byte) 1 : (byte) 0);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOptOut:"), enabled ? (byte) 1 : (byte) 0);
			}
		}
		[Export ("setPushNotificationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushNotificationDelegate (CleverTapPushNotificationDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPushNotificationDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPushNotificationDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setPushToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushToken (NSData pushToken)
		{
			var pushToken__handle__ = pushToken!.GetNonNullHandle (nameof (pushToken));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPushToken:"), pushToken__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPushToken:"), pushToken__handle__);
			}
		}
		[Export ("setPushTokenAsString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushTokenAsString (string pushTokenString)
		{
			if (pushTokenString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pushTokenString));
			var nspushTokenString = CFString.CreateNative (pushTokenString);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			}
			CFString.ReleaseNative (nspushTokenString);
		}
		[Export ("setSignedCallVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSignedCallVersion (string? version)
		{
			var nsversion = CFString.CreateNative (version);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSignedCallVersion:"), nsversion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSignedCallVersion:"), nsversion);
			}
			CFString.ReleaseNative (nsversion);
		}
		[Export ("setSyncDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSyncDelegate (CleverTapSyncDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setUrlDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetUrlDelegate (CleverTapURLDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUrlDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUrlDelegate:"), @delegate__handle__);
			}
		}
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? SharedInstance ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
		}
		[Export ("sharedInstanceWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? SharedInstanceWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			CleverTap? ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sharedInstanceWithCleverTapID:"), nscleverTapID))!;
			CFString.ReleaseNative (nscleverTapID);
			return ret!;
		}
		[Export ("showInAppNotificationIfAny")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowInAppNotificationIfAny ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("showInAppNotificationIfAny"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showInAppNotificationIfAny"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccountID {
			[Export ("getAccountID")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getAccountID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAccountID")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapInstanceConfig Config {
			[Export ("config", ArgumentSemantic.Retain)]
			get {
				CleverTapInstanceConfig? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("config")))!;
				} else {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("config")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapLogLevel DebugLevel {
			[Export ("getDebugLevel")]
			get {
				return (CleverTapLogLevel) global::ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("getDebugLevel"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? DomainString {
			[Export ("getDomainString")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getDomainString")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDomainString")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ProfileGetCleverTapAttributionIdentifier {
			[Export ("profileGetCleverTapAttributionIdentifier")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ProfileGetCleverTapID {
			[Export ("profileGetCleverTapID")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("profileGetCleverTapID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileGetCleverTapID")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double SessionGetTimeElapsed {
			[Export ("sessionGetTimeElapsed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("sessionGetTimeElapsed"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionGetTimeElapsed"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapUTMDetail? SessionGetUTMDetails {
			[Export ("sessionGetUTMDetails")]
			get {
				CleverTapUTMDetail? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sessionGetUTMDetails")))!;
				} else {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionGetUTMDetails")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SignedCallDomain {
			[Export ("signedCallDomain", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("signedCallDomain")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signedCallDomain")))!;
				}
			}
			[Export ("setSignedCallDomain:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSignedCallDomain:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSignedCallDomain:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? UserGetEventHistory {
			[Export ("userGetEventHistory")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userGetEventHistory")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetEventHistory")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double UserGetPreviousVisitTime {
			[Export ("userGetPreviousVisitTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("userGetPreviousVisitTime"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetPreviousVisitTime"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int UserGetScreenCount {
			[Export ("userGetScreenCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("userGetScreenCount"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetScreenCount"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int UserGetTotalVisits {
			[Export ("userGetTotalVisits")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("userGetTotalVisits"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetTotalVisits"));
				}
			}
		}
	} /* class CleverTap */
}
