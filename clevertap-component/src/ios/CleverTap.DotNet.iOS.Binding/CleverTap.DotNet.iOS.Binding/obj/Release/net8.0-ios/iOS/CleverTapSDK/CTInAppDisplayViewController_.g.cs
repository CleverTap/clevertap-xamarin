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
	public unsafe static partial class CTInAppDisplayViewController_  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTInAppDisplayViewController");
		[Export ("buttonTapped:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ButtonTapped (this CTInAppDisplayViewController This, global::UIKit.UIButton button)
		{
			var button__handle__ = button!.GetNonNullHandle (nameof (button));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("buttonTapped:"), button__handle__);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("hideFromWindow:"), animated ? (byte) 1 : (byte) 0);
		}
		[Export ("setupViewForButton:withData:withIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIButton SetupViewForButton (this CTInAppDisplayViewController This, global::UIKit.UIButton buttonView, CTNotificationButton button, nint index)
		{
			var buttonView__handle__ = buttonView!.GetNonNullHandle (nameof (buttonView));
			var button__handle__ = button!.GetNonNullHandle (nameof (button));
			return  Runtime.GetNSObject<global::UIKit.UIButton> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("setupViewForButton:withData:withIndex:"), buttonView__handle__, button__handle__, index))!;
		}
		[Export ("showFromWindow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowFromWindow (this CTInAppDisplayViewController This, bool animated)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("showFromWindow:"), animated ? (byte) 1 : (byte) 0);
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
				CTInAppNotification? ret;
				ret =  Runtime.GetNSObject<CTInAppNotification> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("notification")))!;
				return ret!;
			}
			[Export ("setNotification:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setNotification:"), value__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldPassThroughTouches {
			[Export ("shouldPassThroughTouches")]
			get {
				byte ret;
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("shouldPassThroughTouches"));
				return ret != 0;
			}
			[Export ("setShouldPassThroughTouches:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setShouldPassThroughTouches:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIWindow Window {
			[Export ("window", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIWindow? ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("window")))!;
				return ret!;
			}
			[Export ("setWindow:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setWindow:"), value__handle__);
			}
		}
	} /* class CTInAppDisplayViewController_ */
}
