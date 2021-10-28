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

#nullable enable

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
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("autoIntegrate")));
		}
		
		[Export ("autoIntegrateWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? AutoIntegrateWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			CleverTap ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("autoIntegrateWithCleverTapID:"), nscleverTapID));
			NSString.ReleaseNative (nscleverTapID);
			
			return ret!;
		}
		
		[Export ("changeCredentialsWithAccountID:andToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeCredentialsWithAccountID (string accountID, string token)
		{
			if (accountID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (region == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (region));
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
		public virtual CleverTapEventDetail? EventGetDetail (string? @event)
		{
			var nsevent = NSString.CreateNative (@event);
			
			CleverTapEventDetail ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetDetail:"), nsevent));
			} else {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetDetail:"), nsevent));
			}
			NSString.ReleaseNative (nsevent);
			
			return ret!;
		}
		
		[Export ("eventGetFirstTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EventGetFirstTime (string @event)
		{
			if (@event == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetFirstTime:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret!;
		}
		
		[Export ("eventGetLastTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EventGetLastTime (string @event)
		{
			if (@event == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetLastTime:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret!;
		}
		
		[Export ("eventGetOccurrences:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int EventGetOccurrences (string @event)
		{
			if (@event == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = NSString.CreateNative (@event);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("eventGetOccurrences:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret!;
		}
		
		[Export ("getLocationWithSuccess:andError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetLocationWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::CoreLocation.CLLocationCoordinate2D> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSString>? error)
		{
			if (success == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (success));
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
			var data__handle__ = data.GetNonNullHandle (nameof (data));
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
			var data__handle__ = data.GetNonNullHandle (nameof (data));
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
			var url__handle__ = url.GetNonNullHandle (nameof (url));
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleOpenURL:sourceApplication:"), url__handle__, nssourceApplication);
			}
			NSString.ReleaseNative (nssourceApplication);
			
		}
		
		[Export ("handleOpenURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleOpenURL (NSUrl url)
		{
			var url__handle__ = url.GetNonNullHandle (nameof (url));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("handleOpenURL:"), url__handle__);
		}
		
		[Export ("handlePushNotification:openDeepLinksInForeground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandlePushNotification (NSDictionary notification, bool openInForeground)
		{
			var notification__handle__ = notification.GetNonNullHandle (nameof (notification));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("handlePushNotification:openDeepLinksInForeground:"), notification__handle__, openInForeground);
		}
		
		[Export ("instanceWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config)
		{
			var config__handle__ = config.GetNonNullHandle (nameof (config));
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("instanceWithConfig:"), config__handle__));
		}
		
		[Export ("instanceWithConfig:andCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap InstanceWithConfig (CleverTapInstanceConfig config, string cleverTapID)
		{
			var config__handle__ = config.GetNonNullHandle (nameof (config));
			if (cleverTapID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			CleverTap ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("instanceWithConfig:andCleverTapID:"), config__handle__, nscleverTapID));
			NSString.ReleaseNative (nscleverTapID);
			
			return ret!;
		}
		
		[Export ("isCleverTapNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsCleverTapNotification (NSDictionary payload)
		{
			var payload__handle__ = payload.GetNonNullHandle (nameof (payload));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isCleverTapNotification:"), payload__handle__);
			}
		}
		
		[Export ("notifyApplicationLaunchedWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotifyApplicationLaunchedWithOptions (NSObject launchOptions)
		{
			var launchOptions__handle__ = launchOptions.GetNonNullHandle (nameof (launchOptions));
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
			var properties__handle__ = properties.GetNonNullHandle (nameof (properties));
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
			var properties__handle__ = properties.GetNonNullHandle (nameof (properties));
			if (cleverTapID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("onUserLogin:withCleverTapID:"), properties__handle__, nscleverTapID);
			}
			NSString.ReleaseNative (nscleverTapID);
			
		}
		
		[Export ("profileAddMultiValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileAddMultiValue (string value, string key)
		{
			if (value == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
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
		public virtual NSObject? ProfileGet (string propertyName)
		{
			if (propertyName == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (propertyName));
			var nspropertyName = NSString.CreateNative (propertyName);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profileGet:"), nspropertyName));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profileGet:"), nspropertyName));
			}
			NSString.ReleaseNative (nspropertyName);
			
			return ret!;
		}
		
		[Export ("profilePush:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePush (NSDictionary properties)
		{
			var properties__handle__ = properties.GetNonNullHandle (nameof (properties));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePush:"), properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePush:"), properties__handle__);
			}
		}
		
		[Export ("profilePushGooglePlusUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePushGooglePlusUser (NSObject googleUser)
		{
			var googleUser__handle__ = googleUser.GetNonNullHandle (nameof (googleUser));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePushGooglePlusUser:"), googleUser__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePushGooglePlusUser:"), googleUser__handle__);
			}
		}
		
		[Export ("profilePushGraphUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfilePushGraphUser (NSObject fbGraphUser)
		{
			var fbGraphUser__handle__ = fbGraphUser.GetNonNullHandle (nameof (fbGraphUser));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("profilePushGraphUser:"), fbGraphUser__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("profilePushGraphUser:"), fbGraphUser__handle__);
			}
		}
		
		[Export ("profileRemoveMultiValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileRemoveMultiValue (string value, string key)
		{
			if (value == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			if (key == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			if (key == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
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
		public virtual void PushInstallReferrerSource (string? source, string? medium, string? campaign)
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
			var chargeDetails__handle__ = chargeDetails.GetNonNullHandle (nameof (chargeDetails));
			if (items == null)
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
			if (message == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var properties__handle__ = properties.GetNonNullHandle (nameof (properties));
			var nsevent = NSString.CreateNative (@event);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("recordEvent:withProps:"), nsevent, properties__handle__);
			}
			NSString.ReleaseNative (nsevent);
			
		}
		
		[Export ("recordNotificationViewedEventWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordNotificationViewedEventWithData (NSObject notificationData)
		{
			var notificationData__handle__ = notificationData.GetNonNullHandle (nameof (notificationData));
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
			if (screenName == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (screenName));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
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
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (region == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (region));
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
			if (name == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = NSString.CreateNative (name);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLibrary:"), nsname);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLibrary:"), nsname);
			}
			NSString.ReleaseNative (nsname);
			
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
			var pushToken__handle__ = pushToken.GetNonNullHandle (nameof (pushToken));
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
			if (pushTokenString == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pushTokenString));
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
		public virtual void SetSyncDelegate (CleverTapSyncDelegate? @delegate)
		{
			var @delegate__handle__ = @delegate.GetHandle ();
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSyncDelegate:"), @delegate__handle__);
			}
		}
		
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? SharedInstance ()
		{
			return  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
		}
		
		[Export ("sharedInstanceWithCleverTapID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTap? SharedInstanceWithCleverTapID (string cleverTapID)
		{
			if (cleverTapID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			CleverTap ret;
			ret =  Runtime.GetNSObject<CleverTap> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("sharedInstanceWithCleverTapID:"), nscleverTapID));
			NSString.ReleaseNative (nscleverTapID);
			
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
		public virtual CleverTapInstanceConfig Config {
			[Export ("config", ArgumentSemantic.Retain)]
			get {
				CleverTapInstanceConfig ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("config")));
				} else {
					ret =  Runtime.GetNSObject<CleverTapInstanceConfig> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("config")));
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
		public virtual string? ProfileGetCleverTapAttributionIdentifier {
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
		public virtual string? ProfileGetCleverTapID {
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
		public virtual CleverTapUTMDetail? SessionGetUTMDetails {
			[Export ("sessionGetUTMDetails")]
			get {
				CleverTapUTMDetail ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sessionGetUTMDetails")));
				} else {
					ret =  Runtime.GetNSObject<CleverTapUTMDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionGetUTMDetails")));
				}
				return ret!;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? UserGetEventHistory {
			[Export ("userGetEventHistory")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userGetEventHistory")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userGetEventHistory")));
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
