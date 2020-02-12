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
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
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

namespace CleverTapSDK {
	[Protocol (Name = "CleverTap", WrapperType = typeof (CleverTapWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SharedInstance", Selector = "sharedInstance", ReturnType = typeof (CleverTapSDK.CleverTap))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SharedInstanceWithCleverTapID", Selector = "sharedInstanceWithCleverTapID:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "AutoIntegrate", Selector = "autoIntegrate", ReturnType = typeof (CleverTapSDK.CleverTap))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "AutoIntegrateWithCleverTapID", Selector = "autoIntegrateWithCleverTapID:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "InstanceWithConfig", Selector = "instanceWithConfig:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInstanceConfig) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "InstanceWithConfig", Selector = "instanceWithConfig:andCleverTapID:", ReturnType = typeof (CleverTapSDK.CleverTap), ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInstanceConfig), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "ChangeCredentialsWithAccountID", Selector = "changeCredentialsWithAccountID:andToken:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "ChangeCredentialsWithAccountID", Selector = "changeCredentialsWithAccountID:token:region:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:andToken:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:token:region:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotifyApplicationLaunchedWithOptions", Selector = "notifyApplicationLaunchedWithOptions:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "EnablePersonalization", Selector = "enablePersonalization")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "DisablePersonalization", Selector = "disablePersonalization")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetLocation", Selector = "setLocation:", ParameterType = new Type [] { typeof (CLLocationCoordinate2D) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetLocationWithSuccess", Selector = "getLocationWithSuccess:andError:", ParameterType = new Type [] { typeof (global::System.Action<global::CoreLocation.CLLocationCoordinate2D>), typeof (global::System.Action<NSString>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0), typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
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
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfilePushGraphUser", Selector = "profilePushGraphUser:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfilePushGooglePlusUser", Selector = "profilePushGooglePlusUser:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileGet", Selector = "profileGet:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordEvent", Selector = "recordEvent:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordEvent", Selector = "recordEvent:withProps:", ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordChargedEventWithDetails", Selector = "recordChargedEventWithDetails:andItems:", ParameterType = new Type [] { typeof (NSDictionary), typeof (NSObject[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordErrorWithMessage", Selector = "recordErrorWithMessage:andErrorCode:", ParameterType = new Type [] { typeof (string), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordScreenView", Selector = "recordScreenView:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordNotificationViewedEventWithData", Selector = "recordNotificationViewedEventWithData:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetFirstTime", Selector = "eventGetFirstTime:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetLastTime", Selector = "eventGetLastTime:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetOccurrences", Selector = "eventGetOccurrences:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EventGetDetail", Selector = "eventGetDetail:", ReturnType = typeof (CleverTapSDK.CleverTapEventDetail), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetSyncDelegate", Selector = "setSyncDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapSyncDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetInAppNotificationDelegate", Selector = "setInAppNotificationDelegate:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInAppNotificationDelegate) }, ParameterByRef = new bool [] { false })]
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
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Config", Selector = "config", PropertyType = typeof (CleverTapSDK.CleverTapInstanceConfig), GetterSelector = "config", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProfileGetCleverTapID", Selector = "profileGetCleverTapID", PropertyType = typeof (string), GetterSelector = "profileGetCleverTapID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProfileGetCleverTapAttributionIdentifier", Selector = "profileGetCleverTapAttributionIdentifier", PropertyType = typeof (string), GetterSelector = "profileGetCleverTapAttributionIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetEventHistory", Selector = "userGetEventHistory", PropertyType = typeof (NSDictionary), GetterSelector = "userGetEventHistory", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SessionGetTimeElapsed", Selector = "sessionGetTimeElapsed", PropertyType = typeof (double), GetterSelector = "sessionGetTimeElapsed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SessionGetUTMDetails", Selector = "sessionGetUTMDetails", PropertyType = typeof (CleverTapSDK.CleverTapUTMDetail), GetterSelector = "sessionGetUTMDetails", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetTotalVisits", Selector = "userGetTotalVisits", PropertyType = typeof (int), GetterSelector = "userGetTotalVisits", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetScreenCount", Selector = "userGetScreenCount", PropertyType = typeof (int), GetterSelector = "userGetScreenCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserGetPreviousVisitTime", Selector = "userGetPreviousVisitTime", PropertyType = typeof (double), GetterSelector = "userGetPreviousVisitTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "DebugLevel", Selector = "getDebugLevel", PropertyType = typeof (CleverTapSDK.CleverTapLogLevel), GetterSelector = "getDebugLevel", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICleverTap : INativeObject, IDisposable
	{
	}
	
	public static partial class CleverTap_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NotifyApplicationLaunchedWithOptions (this ICleverTap This, NSObject launchOptions)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnUserLogin (this ICleverTap This, NSDictionary properties)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onUserLogin:"), properties.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnUserLogin (this ICleverTap This, NSDictionary properties, string cleverTapID)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (cleverTapID == null)
				throw new ArgumentNullException ("cleverTapID");
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties.Handle, nscleverTapID);
			NSString.ReleaseNative (nscleverTapID);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetOptOut (this ICleverTap This, bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setOptOut:"), enabled);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetOffline (this ICleverTap This, bool offline)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setOffline:"), offline);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EnableDeviceNetworkInfoReporting (this ICleverTap This, bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("enableDeviceNetworkInfoReporting:"), enabled);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfilePush (this ICleverTap This, NSDictionary properties)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profilePush:"), properties.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileRemoveValueForKey (this ICleverTap This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileSetMultiValues (this ICleverTap This, string[] values, string key)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileAddMultiValue (this ICleverTap This, string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileAddMultiValues (this ICleverTap This, string[] values, string key)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileRemoveMultiValue (this ICleverTap This, string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileRemoveMultiValues (this ICleverTap This, string[] values, string key)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfilePushGraphUser (this ICleverTap This, NSObject fbGraphUser)
		{
			if (fbGraphUser == null)
				throw new ArgumentNullException ("fbGraphUser");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profilePushGraphUser:"), fbGraphUser.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfilePushGooglePlusUser (this ICleverTap This, NSObject googleUser)
		{
			if (googleUser == null)
				throw new ArgumentNullException ("googleUser");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profilePushGooglePlusUser:"), googleUser.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ProfileGet (this ICleverTap This, string propertyName)
		{
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profileGet:"), nspropertyName));
			NSString.ReleaseNative (nspropertyName);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordEvent (this ICleverTap This, string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordEvent:"), nsevent);
			NSString.ReleaseNative (nsevent);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordEvent (this ICleverTap This, string @event, NSDictionary properties)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nsevent = NSString.CreateNative (@event);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties.Handle);
			NSString.ReleaseNative (nsevent);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordChargedEventWithDetails (this ICleverTap This, NSDictionary chargeDetails, NSObject[] items)
		{
			if (chargeDetails == null)
				throw new ArgumentNullException ("chargeDetails");
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsa_items = NSArray.FromNSObjects (items);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails.Handle, nsa_items.Handle);
			nsa_items.Dispose ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordErrorWithMessage (this ICleverTap This, string message, int code)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordScreenView (this ICleverTap This, string screenName)
		{
			if (screenName == null)
				throw new ArgumentNullException ("screenName");
			var nsscreenName = NSString.CreateNative (screenName);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			NSString.ReleaseNative (nsscreenName);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordNotificationViewedEventWithData (this ICleverTap This, NSObject notificationData)
		{
			if (notificationData == null)
				throw new ArgumentNullException ("notificationData");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double EventGetFirstTime (this ICleverTap This, string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double EventGetLastTime (this ICleverTap This, string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int EventGetOccurrences (this ICleverTap This, string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapEventDetail EventGetDetail (this ICleverTap This, string @event)
		{
			var nsevent = NSString.CreateNative (@event);
			
			CleverTapEventDetail ret;
			ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("eventGetDetail:"), nsevent));
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetSyncDelegate (this ICleverTap This, CleverTapSyncDelegate @delegate)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSyncDelegate:"), @delegate == null ? IntPtr.Zero : @delegate.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInAppNotificationDelegate (this ICleverTap This, CleverTapInAppNotificationDelegate @delegate)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate == null ? IntPtr.Zero : @delegate.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPushToken (this ICleverTap This, NSData pushToken)
		{
			if (pushToken == null)
				throw new ArgumentNullException ("pushToken");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPushToken:"), pushToken.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetPushTokenAsString (this ICleverTap This, string pushTokenString)
		{
			if (pushTokenString == null)
				throw new ArgumentNullException ("pushTokenString");
			var nspushTokenString = NSString.CreateNative (pushTokenString);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			NSString.ReleaseNative (nspushTokenString);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleNotificationWithData (this ICleverTap This, NSObject data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("handleNotificationWithData:"), data.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleNotificationWithData (this ICleverTap This, NSObject data, bool openInForeground)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data.Handle, openInForeground);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCleverTapNotification (this ICleverTap This, NSDictionary payload)
		{
			if (payload == null)
				throw new ArgumentNullException ("payload");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isCleverTapNotification:"), payload.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowInAppNotificationIfAny (this ICleverTap This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("showInAppNotificationIfAny"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleOpenURL (this ICleverTap This, NSUrl url, string sourceApplication)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url.Handle, nssourceApplication);
			NSString.ReleaseNative (nssourceApplication);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PushInstallReferrerSource (this ICleverTap This, string source, string medium, string campaign)
		{
			var nssource = NSString.CreateNative (source);
			var nsmedium = NSString.CreateNative (medium);
			var nscampaign = NSString.CreateNative (campaign);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			NSString.ReleaseNative (nssource);
			NSString.ReleaseNative (nsmedium);
			NSString.ReleaseNative (nscampaign);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapInstanceConfig GetConfig (this ICleverTap This)
		{
			return  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("config")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetProfileGetCleverTapID (this ICleverTap This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("profileGetCleverTapID")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetProfileGetCleverTapAttributionIdentifier (this ICleverTap This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetUserGetEventHistory (this ICleverTap This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("userGetEventHistory")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetSessionGetTimeElapsed (this ICleverTap This)
		{
			return global::ApiDefinition.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("sessionGetTimeElapsed"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapUTMDetail GetSessionGetUTMDetails (this ICleverTap This)
		{
			return  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sessionGetUTMDetails")));
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
		
	}
	
	internal sealed class CleverTapWrapper : BaseWrapper, ICleverTap {
		[Preserve (Conditional = true)]
		public CleverTapWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CleverTap", true)]
	public unsafe partial class CleverTap : NSObject, ICleverTap {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTap");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
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
		protected internal CleverTap (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("autoIntegrate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap AutoIntegrate ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("autoIntegrate")));
		}
		
		[Export ("autoIntegrateWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap AutoIntegrateWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID == null)
				throw new ArgumentNullException ("cleverTapID");
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			CleverTap ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("autoIntegrateWithCleverTapID:"), nscleverTapID));
			NSString.ReleaseNative (nscleverTapID);
			
			return ret;
		}
		
		[Export ("changeCredentialsWithAccountID:andToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeCredentialsWithAccountID (string accountID, string token)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (token == null)
				throw new ArgumentNullException ("token");
			var nsaccountID = NSString.CreateNative (accountID);
			var nstoken = NSString.CreateNative (token);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("changeCredentialsWithAccountID:andToken:"), nsaccountID, nstoken);
			NSString.ReleaseNative (nsaccountID);
			NSString.ReleaseNative (nstoken);
			
		}
		
		[Export ("changeCredentialsWithAccountID:token:region:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeCredentialsWithAccountID (string accountID, string token, string region)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (token == null)
				throw new ArgumentNullException ("token");
			if (region == null)
				throw new ArgumentNullException ("region");
			var nsaccountID = NSString.CreateNative (accountID);
			var nstoken = NSString.CreateNative (token);
			var nsregion = NSString.CreateNative (region);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("changeCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			NSString.ReleaseNative (nsaccountID);
			NSString.ReleaseNative (nstoken);
			NSString.ReleaseNative (nsregion);
			
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
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableDeviceNetworkInfoReporting:"), enabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableDeviceNetworkInfoReporting:"), enabled);
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
		public virtual CleverTapEventDetail EventGetDetail (string @event)
		{
			var nsevent = NSString.CreateNative (@event);
			
			CleverTapEventDetail ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetDetail:"), nsevent));
			} else {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetDetail:"), nsevent));
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("eventGetFirstTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EventGetFirstTime (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("eventGetLastTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EventGetLastTime (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("eventGetOccurrences:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int EventGetOccurrences (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("getLocationWithSuccess:andError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetLocationWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::CoreLocation.CLLocationCoordinate2D> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSString> error)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, success);
			BlockLiteral *block_ptr_error;
			BlockLiteral block_error;
			if (error == null){
				block_ptr_error = null;
			} else {
				block_error = new BlockLiteral ();
				block_ptr_error = &block_error;
				block_error.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, error);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getLocationWithSuccess:andError:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_error);
			block_ptr_success->CleanupBlock ();
			if (block_ptr_error != null)
				block_ptr_error->CleanupBlock ();
			
		}
		
		[Export ("handleNotificationWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationWithData (NSObject data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handleNotificationWithData:"), data.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handleNotificationWithData:"), data.Handle);
			}
		}
		
		[Export ("handleNotificationWithData:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationWithData (NSObject data, bool openInForeground)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data.Handle, openInForeground);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data.Handle, openInForeground);
			}
		}
		
		[Export ("handleOpenURL:sourceApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleOpenURL (NSUrl url, string sourceApplication)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url.Handle, nssourceApplication);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url.Handle, nssourceApplication);
			}
			NSString.ReleaseNative (nssourceApplication);
			
		}
		
		[Export ("handleOpenURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleOpenURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleOpenURL:"), url.Handle);
		}
		
		[Export ("handlePushNotification:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandlePushNotification (NSDictionary notification, bool openInForeground)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("handlePushNotification:openDeepLinksInForeground:"), notification.Handle, openInForeground);
		}
		
		[Export ("instanceWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("instanceWithConfig:"), config.Handle));
		}
		
		[Export ("instanceWithConfig:andCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config, string cleverTapID)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			if (cleverTapID == null)
				throw new ArgumentNullException ("cleverTapID");
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			CleverTap ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("instanceWithConfig:andCleverTapID:"), config.Handle, nscleverTapID));
			NSString.ReleaseNative (nscleverTapID);
			
			return ret;
		}
		
		[Export ("isCleverTapNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCleverTapNotification (NSDictionary payload)
		{
			if (payload == null)
				throw new ArgumentNullException ("payload");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isCleverTapNotification:"), payload.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isCleverTapNotification:"), payload.Handle);
			}
		}
		
		[Export ("notifyApplicationLaunchedWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotifyApplicationLaunchedWithOptions (NSObject launchOptions)
		{
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions.Handle);
			}
		}
		
		[Export ("onUserLogin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUserLogin (NSDictionary properties)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onUserLogin:"), properties.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("onUserLogin:"), properties.Handle);
			}
		}
		
		[Export ("onUserLogin:withCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUserLogin (NSDictionary properties, string cleverTapID)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (cleverTapID == null)
				throw new ArgumentNullException ("cleverTapID");
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties.Handle, nscleverTapID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties.Handle, nscleverTapID);
			}
			NSString.ReleaseNative (nscleverTapID);
			
		}
		
		[Export ("profileAddMultiValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileAddMultiValue (string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			}
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("profileAddMultiValues:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileAddMultiValues (string[] values, string key)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			}
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("profileGet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ProfileGet (string propertyName)
		{
			if (propertyName == null)
				throw new ArgumentNullException ("propertyName");
			var nspropertyName = NSString.CreateNative (propertyName);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profileGet:"), nspropertyName));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profileGet:"), nspropertyName));
			}
			NSString.ReleaseNative (nspropertyName);
			
			return ret;
		}
		
		[Export ("profilePush:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePush (NSDictionary properties)
		{
			if (properties == null)
				throw new ArgumentNullException ("properties");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePush:"), properties.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePush:"), properties.Handle);
			}
		}
		
		[Export ("profilePushGooglePlusUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePushGooglePlusUser (NSObject googleUser)
		{
			if (googleUser == null)
				throw new ArgumentNullException ("googleUser");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePushGooglePlusUser:"), googleUser.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePushGooglePlusUser:"), googleUser.Handle);
			}
		}
		
		[Export ("profilePushGraphUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePushGraphUser (NSObject fbGraphUser)
		{
			if (fbGraphUser == null)
				throw new ArgumentNullException ("fbGraphUser");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePushGraphUser:"), fbGraphUser.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePushGraphUser:"), fbGraphUser.Handle);
			}
		}
		
		[Export ("profileRemoveMultiValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveMultiValue (string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			}
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("profileRemoveMultiValues:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveMultiValues (string[] values, string key)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			}
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("profileRemoveValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveValueForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("profileSetMultiValues:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileSetMultiValues (string[] values, string key)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			}
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("pushInstallReferrerSource:medium:campaign:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushInstallReferrerSource (string source, string medium, string campaign)
		{
			var nssource = NSString.CreateNative (source);
			var nsmedium = NSString.CreateNative (medium);
			var nscampaign = NSString.CreateNative (campaign);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			}
			NSString.ReleaseNative (nssource);
			NSString.ReleaseNative (nsmedium);
			NSString.ReleaseNative (nscampaign);
			
		}
		
		[Export ("recordChargedEventWithDetails:andItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordChargedEventWithDetails (NSDictionary chargeDetails, NSObject[] items)
		{
			if (chargeDetails == null)
				throw new ArgumentNullException ("chargeDetails");
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsa_items = NSArray.FromNSObjects (items);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails.Handle, nsa_items.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails.Handle, nsa_items.Handle);
			}
			nsa_items.Dispose ();
			
		}
		
		[Export ("recordErrorWithMessage:andErrorCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordErrorWithMessage (string message, int code)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			}
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("recordEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordEvent (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordEvent:"), nsevent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordEvent:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
		}
		
		[Export ("recordEvent:withProps:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordEvent (string @event, NSDictionary properties)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nsevent = NSString.CreateNative (@event);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties.Handle);
			}
			NSString.ReleaseNative (nsevent);
			
		}
		
		[Export ("recordNotificationViewedEventWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordNotificationViewedEventWithData (NSObject notificationData)
		{
			if (notificationData == null)
				throw new ArgumentNullException ("notificationData");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData.Handle);
			}
		}
		
		[Export ("recordScreenView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordScreenView (string screenName)
		{
			if (screenName == null)
				throw new ArgumentNullException ("screenName");
			var nsscreenName = NSString.CreateNative (screenName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			}
			NSString.ReleaseNative (nsscreenName);
			
		}
		
		[Export ("setCredentialsWithAccountID:andToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (string accountID, string token)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (token == null)
				throw new ArgumentNullException ("token");
			var nsaccountID = NSString.CreateNative (accountID);
			var nstoken = NSString.CreateNative (token);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:andToken:"), nsaccountID, nstoken);
			NSString.ReleaseNative (nsaccountID);
			NSString.ReleaseNative (nstoken);
			
		}
		
		[Export ("setCredentialsWithAccountID:token:region:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (string accountID, string token, string region)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (token == null)
				throw new ArgumentNullException ("token");
			if (region == null)
				throw new ArgumentNullException ("region");
			var nsaccountID = NSString.CreateNative (accountID);
			var nstoken = NSString.CreateNative (token);
			var nsregion = NSString.CreateNative (region);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			NSString.ReleaseNative (nsaccountID);
			NSString.ReleaseNative (nstoken);
			NSString.ReleaseNative (nsregion);
			
		}
		
		[Export ("setDebugLevel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDebugLevel (int level)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (class_ptr, Selector.GetHandle ("setDebugLevel:"), level);
		}
		
		[Export ("setInAppNotificationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInAppNotificationDelegate (CleverTapInAppNotificationDelegate @delegate)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate == null ? IntPtr.Zero : @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate == null ? IntPtr.Zero : @delegate.Handle);
			}
		}
		
		[Export ("setLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLocation (global::CoreLocation.CLLocationCoordinate2D location)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D (class_ptr, Selector.GetHandle ("setLocation:"), location);
		}
		
		[Export ("setOffline:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOffline (bool offline)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOffline:"), offline);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOffline:"), offline);
			}
		}
		
		[Export ("setOptOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOptOut (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOptOut:"), enabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOptOut:"), enabled);
			}
		}
		
		[Export ("setPushToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushToken (NSData pushToken)
		{
			if (pushToken == null)
				throw new ArgumentNullException ("pushToken");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPushToken:"), pushToken.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPushToken:"), pushToken.Handle);
			}
		}
		
		[Export ("setPushTokenAsString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushTokenAsString (string pushTokenString)
		{
			if (pushTokenString == null)
				throw new ArgumentNullException ("pushTokenString");
			var nspushTokenString = NSString.CreateNative (pushTokenString);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			}
			NSString.ReleaseNative (nspushTokenString);
			
		}
		
		[Export ("setSyncDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSyncDelegate (CleverTapSyncDelegate @delegate)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSyncDelegate:"), @delegate == null ? IntPtr.Zero : @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSyncDelegate:"), @delegate == null ? IntPtr.Zero : @delegate.Handle);
			}
		}
		
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap SharedInstance ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
		}
		
		[Export ("sharedInstanceWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap SharedInstanceWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID == null)
				throw new ArgumentNullException ("cleverTapID");
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			CleverTap ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sharedInstanceWithCleverTapID:"), nscleverTapID));
			NSString.ReleaseNative (nscleverTapID);
			
			return ret;
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
		public virtual CleverTapInstanceConfig Config {
			[Export ("config", ArgumentSemantic.Retain)]
			get {
				CleverTapInstanceConfig ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("config")));
				} else {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("config")));
				}
				return ret;
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
		public virtual string ProfileGetCleverTapAttributionIdentifier {
			[Export ("profileGetCleverTapAttributionIdentifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ProfileGetCleverTapID {
			[Export ("profileGetCleverTapID")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("profileGetCleverTapID")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileGetCleverTapID")));
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
		public virtual CleverTapUTMDetail SessionGetUTMDetails {
			[Export ("sessionGetUTMDetails")]
			get {
				CleverTapUTMDetail ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sessionGetUTMDetails")));
				} else {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionGetUTMDetails")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary UserGetEventHistory {
			[Export ("userGetEventHistory")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userGetEventHistory")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetEventHistory")));
				}
				return ret;
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
