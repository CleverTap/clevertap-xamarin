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
	public unsafe static partial class CTInAppDisplayViewController_  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTInAppDisplayViewController");
		
		[Export ("buttonTapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ButtonTapped (this CTInAppDisplayViewController This, global::UIKit.UIButton button)
		{
			if (button == null)
				throw new ArgumentNullException ("button");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("buttonTapped:"), button.Handle);
		}
		
		[Export ("handleButtonClickFromIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleButtonClickFromIndex (this CTInAppDisplayViewController This, int index)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("handleButtonClickFromIndex:"), index);
		}
		
		[Export ("handleImageTapGesture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleImageTapGesture (this CTInAppDisplayViewController This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("handleImageTapGesture"));
		}
		
		[Export ("hideFromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HideFromWindow (this CTInAppDisplayViewController This, bool animated)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("hideFromWindow:"), animated);
		}
		
		[Export ("setupViewForButton:withData:withIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIButton SetupViewForButton (this CTInAppDisplayViewController This, global::UIKit.UIButton buttonView, CTNotificationButton button, nint index)
		{
			if (buttonView == null)
				throw new ArgumentNullException ("buttonView");
			if (button == null)
				throw new ArgumentNullException ("button");
			return  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint (This.Handle, Selector.GetHandle ("setupViewForButton:withData:withIndex:"), buttonView.Handle, button.Handle, index));
		}
		
		[Export ("showFromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowFromWindow (this CTInAppDisplayViewController This, bool animated)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("showFromWindow:"), animated);
		}
		
		[Export ("tappedDismiss")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TappedDismiss (this CTInAppDisplayViewController This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("tappedDismiss"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTInAppNotification Notification {
			[Export ("notification", ArgumentSemantic.Retain)]
			get {
				CTInAppNotification ret;
				ret =  Runtime.GetNSObject<CTInAppNotification> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("notification")));
				return ret;
			}
			
			[Export ("setNotification:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setNotification:"), value.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPassThroughTouches {
			[Export ("shouldPassThroughTouches")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("shouldPassThroughTouches"));
			}
			
			[Export ("setShouldPassThroughTouches:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setShouldPassThroughTouches:"), value);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIWindow Window {
			[Export ("window", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIWindow ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("window")));
				return ret;
			}
			
			[Export ("setWindow:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setWindow:"), value.Handle);
			}
		}
		
	} /* class CTInAppDisplayViewController_ */
}
