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
	public unsafe static partial class CleverTap_InAppNotifications  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CleverTap");
		[Export ("discardInAppNotifications")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DiscardInAppNotifications (this CleverTap This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("discardInAppNotifications"));
		}
		[Export ("resumeInAppNotifications")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResumeInAppNotifications (this CleverTap This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resumeInAppNotifications"));
		}
		[Export ("suspendInAppNotifications")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SuspendInAppNotifications (this CleverTap This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("suspendInAppNotifications"));
		}
	} /* class CleverTap_InAppNotifications */
}
