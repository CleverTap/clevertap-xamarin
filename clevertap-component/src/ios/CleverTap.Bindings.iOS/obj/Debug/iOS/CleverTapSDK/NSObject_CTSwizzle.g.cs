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
	public unsafe static partial class NSObject_CTSwizzle  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		[Export ("ct_swizzleClassMethod:withClassMethod:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Ct_swizzleClassMethod (this NSObject This, Selector origSel_, Selector altSel_, out NSError error_)
		{
			var origSel___handle__ = origSel_!.GetNonNullHandle (nameof (origSel_));
			var altSel___handle__ = altSel_!.GetNonNullHandle (nameof (altSel_));
			IntPtr error_Value = IntPtr.Zero;
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleClassMethod:withClassMethod:error:"), origSel_.Handle, altSel_.Handle, ref error_Value);
			error_ = Runtime.GetNSObject<NSError> (error_Value)!;
			return ret!;
		}
		[Export ("ct_swizzleClassMethod:withBlock:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSInvocation Ct_swizzleClassMethod (this NSObject This, Selector origSel, NSObject block, out NSError error)
		{
			var origSel__handle__ = origSel!.GetNonNullHandle (nameof (origSel));
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			IntPtr errorValue = IntPtr.Zero;
			NSInvocation? ret;
			ret =  Runtime.GetNSObject<NSInvocation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleClassMethod:withBlock:error:"), origSel.Handle, block__handle__, ref errorValue))!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("ct_swizzleMethod:withMethod:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Ct_swizzleMethod (this NSObject This, Selector origSel_, Selector altSel_, out NSError error_)
		{
			var origSel___handle__ = origSel_!.GetNonNullHandle (nameof (origSel_));
			var altSel___handle__ = altSel_!.GetNonNullHandle (nameof (altSel_));
			IntPtr error_Value = IntPtr.Zero;
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleMethod:withMethod:error:"), origSel_.Handle, altSel_.Handle, ref error_Value);
			error_ = Runtime.GetNSObject<NSError> (error_Value)!;
			return ret!;
		}
		[Export ("ct_swizzleMethod:withBlock:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSInvocation Ct_swizzleMethod (this NSObject This, Selector origSel, NSObject block, out NSError error)
		{
			var origSel__handle__ = origSel!.GetNonNullHandle (nameof (origSel));
			var block__handle__ = block!.GetNonNullHandle (nameof (block));
			IntPtr errorValue = IntPtr.Zero;
			NSInvocation? ret;
			ret =  Runtime.GetNSObject<NSInvocation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleMethod:withBlock:error:"), origSel.Handle, block__handle__, ref errorValue))!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	} /* class NSObject_CTSwizzle */
}
