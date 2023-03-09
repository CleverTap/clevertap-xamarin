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
	[Register("CleverTap", true)]
	public unsafe partial class CleverTap : NSObject {
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
		public static CleverTap? AutoIntegrate ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("autoIntegrate")))!;
		}
		[Export ("autoIntegrateWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? AutoIntegrateWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			CleverTap? ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("autoIntegrateWithCleverTapID:"), nscleverTapID))!;
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("changeCredentialsWithAccountID:andToken:"), nsaccountID, nstoken);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("changeCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didFailToRegisterForGeofencesWithError:"), error__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didFailToRegisterForGeofencesWithError:"), error__handle__);
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
		public virtual CleverTapEventDetail? EventGetDetail (string? @event)
		{
			var nsevent = CFString.CreateNative (@event);
			CleverTapEventDetail? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetDetail:"), nsevent))!;
			} else {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetDetail:"), nsevent))!;
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
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
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
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
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
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
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
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getGlobalInstance:"), nsaccountId))!;
			CFString.ReleaseNative (nsaccountId);
			return ret!;
		}
		[Export ("getLocationWithSuccess:andError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetLocationWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::CoreLocation.CLLocationCoordinate2D> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSString>? error)
		{
			if (success is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (success));
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, success);
			BlockLiteral *block_ptr_error;
			BlockLiteral block_error;
			if (error is null){
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
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handleNotificationWithData:"), data__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handleNotificationWithData:"), data__handle__);
			}
		}
		[Export ("handleNotificationWithData:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationWithData (NSObject data, bool openInForeground)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data__handle__, openInForeground);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("handleNotificationWithData:openDeepLinksInForeground:"), data__handle__, openInForeground);
			}
		}
		[Export ("handleOpenURL:sourceApplication:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleOpenURL (NSUrl url, string? sourceApplication)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var nssourceApplication = CFString.CreateNative (sourceApplication);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			}
			CFString.ReleaseNative (nssourceApplication);
		}
		[Export ("handleOpenURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleOpenURL (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleOpenURL:"), url__handle__);
		}
		[Export ("handlePushNotification:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandlePushNotification (NSDictionary notification, bool openInForeground)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("handlePushNotification:openDeepLinksInForeground:"), notification__handle__, openInForeground);
		}
		[Export ("instanceWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("instanceWithConfig:"), config__handle__))!;
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
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("instanceWithConfig:andCleverTapID:"), config__handle__, nscleverTapID))!;
			CFString.ReleaseNative (nscleverTapID);
			return ret!;
		}
		[Export ("isCleverTapNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCleverTapNotification (NSDictionary payload)
		{
			var payload__handle__ = payload!.GetNonNullHandle (nameof (payload));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			}
		}
		[Export ("isValidCleverTapId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCleverTapId (string? cleverTapID)
		{
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isValidCleverTapId:"), nscleverTapID);
			CFString.ReleaseNative (nscleverTapID);
			return ret!;
		}
		[Export ("notifyApplicationLaunchedWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotifyApplicationLaunchedWithOptions (NSObject launchOptions)
		{
			var launchOptions__handle__ = launchOptions!.GetNonNullHandle (nameof (launchOptions));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("notifyApplicationLaunchedWithOptions:"), launchOptions__handle__);
			}
		}
		[Export ("onUserLogin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUserLogin (NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onUserLogin:"), properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("onUserLogin:"), properties__handle__);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileAddMultiValue:forKey:"), nsvalue, nskey);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileAddMultiValues:forKey:"), nsa_values.Handle, nskey);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileDecrementValueBy:forKey:"), value__handle__, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileDecrementValueBy:forKey:"), value__handle__, nskey);
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
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profileGet:"), nspropertyName))!;
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profileGet:"), nspropertyName))!;
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileIncrementValueBy:forKey:"), value__handle__, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileIncrementValueBy:forKey:"), value__handle__, nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("profilePush:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePush (NSDictionary properties)
		{
			var properties__handle__ = properties!.GetNonNullHandle (nameof (properties));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePush:"), properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePush:"), properties__handle__);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileRemoveMultiValue:forKey:"), nsvalue, nskey);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileRemoveMultiValues:forKey:"), nsa_values.Handle, nskey);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profileRemoveValueForKey:"), nskey);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("profileSetMultiValues:forKey:"), nsa_values.Handle, nskey);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("pushInstallReferrerSource:medium:campaign:"), nssource, nsmedium, nscampaign);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails__handle__, nsa_items.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordChargedEventWithDetails:andItems:"), chargeDetails__handle__, nsa_items.Handle);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("recordErrorWithMessage:andErrorCode:"), nsmessage, code);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordEvent:"), nsevent);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordEvent:"), nsevent);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			}
			CFString.ReleaseNative (nsevent);
		}
		[Export ("recordGeofenceEnteredEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordGeofenceEnteredEvent (NSDictionary geofenceDetails)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordGeofenceEnteredEvent:"), geofenceDetails__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordGeofenceEnteredEvent:"), geofenceDetails__handle__);
			}
		}
		[Export ("recordGeofenceExitedEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordGeofenceExitedEvent (NSDictionary geofenceDetails)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordGeofenceExitedEvent:"), geofenceDetails__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordGeofenceExitedEvent:"), geofenceDetails__handle__);
			}
		}
		[Export ("recordNotificationClickedEventWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordNotificationClickedEventWithData (NSObject notificationData)
		{
			var notificationData__handle__ = notificationData!.GetNonNullHandle (nameof (notificationData));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordNotificationClickedEventWithData:"), notificationData__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordNotificationClickedEventWithData:"), notificationData__handle__);
			}
		}
		[Export ("recordNotificationViewedEventWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordNotificationViewedEventWithData (NSObject notificationData)
		{
			var notificationData__handle__ = notificationData!.GetNonNullHandle (nameof (notificationData));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordNotificationViewedEventWithData:"), notificationData__handle__);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("recordScreenView:"), nsscreenName);
			}
			CFString.ReleaseNative (nsscreenName);
		}
		[Export ("recordSignedCallEvent:forCallDetails:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordSignedCallEvent (int eventRawValue, NSDictionary calldetails)
		{
			var calldetails__handle__ = calldetails!.GetNonNullHandle (nameof (calldetails));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, Selector.GetHandle ("recordSignedCallEvent:forCallDetails:"), eventRawValue, calldetails__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, Selector.GetHandle ("recordSignedCallEvent:forCallDetails:"), eventRawValue, calldetails__handle__);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:andToken:"), nsaccountID, nstoken);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:"), nsaccountID, nstoken, nsproxyDomain, nsspikyProxyDomain);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDomainDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDomainDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setInAppNotificationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInAppNotificationDelegate (CleverTapInAppNotificationDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInAppNotificationDelegate:"), @delegate__handle__);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLibrary:"), nsname);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLibrary:"), nsname);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_CLLocationCoordinate2D_IntPtr (this.Handle, Selector.GetHandle ("setLocationForGeofences:withPluginVersion:"), location, nsversion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (this.SuperHandle, Selector.GetHandle ("setLocationForGeofences:withPluginVersion:"), location, nsversion);
			}
			CFString.ReleaseNative (nsversion);
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
		[Export ("setPushNotificationDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushNotificationDelegate (CleverTapPushNotificationDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPushNotificationDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPushNotificationDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setPushToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPushToken (NSData pushToken)
		{
			var pushToken__handle__ = pushToken!.GetNonNullHandle (nameof (pushToken));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPushToken:"), pushToken__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPushToken:"), pushToken__handle__);
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPushTokenAsString:"), nspushTokenString);
			}
			CFString.ReleaseNative (nspushTokenString);
		}
		[Export ("setSignedCallVersion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSignedCallVersion (string? version)
		{
			var nsversion = CFString.CreateNative (version);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSignedCallVersion:"), nsversion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSignedCallVersion:"), nsversion);
			}
			CFString.ReleaseNative (nsversion);
		}
		[Export ("setSyncDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSyncDelegate (CleverTapSyncDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
			}
		}
		[Export ("setUrlDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetUrlDelegate (CleverTapURLDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUrlDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUrlDelegate:"), @delegate__handle__);
			}
		}
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? SharedInstance ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
		}
		[Export ("sharedInstanceWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? SharedInstanceWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			CleverTap? ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sharedInstanceWithCleverTapID:"), nscleverTapID))!;
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
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAccountID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAccountID")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapInstanceConfig Config {
			[Export ("config", ArgumentSemantic.Retain)]
			get {
				CleverTapInstanceConfig? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("config")))!;
				} else {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("config")))!;
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
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDomainString")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDomainString")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ProfileGetCleverTapAttributionIdentifier {
			[Export ("profileGetCleverTapAttributionIdentifier")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileGetCleverTapAttributionIdentifier")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ProfileGetCleverTapID {
			[Export ("profileGetCleverTapID")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("profileGetCleverTapID")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("profileGetCleverTapID")))!;
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
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sessionGetUTMDetails")))!;
				} else {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionGetUTMDetails")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SignedCallDomain {
			[Export ("signedCallDomain", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("signedCallDomain")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signedCallDomain")))!;
				}
			}
			[Export ("setSignedCallDomain:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSignedCallDomain:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSignedCallDomain:"), nsvalue);
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
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userGetEventHistory")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetEventHistory")))!;
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
