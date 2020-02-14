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
	public unsafe static partial class NSObject_CTSwizzle  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[Export ("ct_swizzleClassMethod:withClassMethod:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Ct_swizzleClassMethod (this NSObject This, Selector origSel_, Selector altSel_, out NSError error_)
		{
			if (origSel_ == null)
				throw new ArgumentNullException ("origSel_");
			if (altSel_ == null)
				throw new ArgumentNullException ("altSel_");
			IntPtr error_Value = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleClassMethod:withClassMethod:error:"), origSel_.Handle, altSel_.Handle, ref error_Value);
			error_ = Runtime.GetNSObject<NSError> (error_Value);
			
			return ret;
		}
		
		[Export ("ct_swizzleClassMethod:withBlock:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSInvocation Ct_swizzleClassMethod (this NSObject This, Selector origSel, NSObject block, out NSError error)
		{
			if (origSel == null)
				throw new ArgumentNullException ("origSel");
			if (block == null)
				throw new ArgumentNullException ("block");
			IntPtr errorValue = IntPtr.Zero;
			
			NSInvocation ret;
			ret =  Runtime.GetNSObject<NSInvocation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleClassMethod:withBlock:error:"), origSel.Handle, block.Handle, ref errorValue));
			error = Runtime.GetNSObject<NSError> (errorValue);
			
			return ret;
		}
		
		[Export ("ct_swizzleMethod:withMethod:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Ct_swizzleMethod (this NSObject This, Selector origSel_, Selector altSel_, out NSError error_)
		{
			if (origSel_ == null)
				throw new ArgumentNullException ("origSel_");
			if (altSel_ == null)
				throw new ArgumentNullException ("altSel_");
			IntPtr error_Value = IntPtr.Zero;
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleMethod:withMethod:error:"), origSel_.Handle, altSel_.Handle, ref error_Value);
			error_ = Runtime.GetNSObject<NSError> (error_Value);
			
			return ret;
		}
		
		[Export ("ct_swizzleMethod:withBlock:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSInvocation Ct_swizzleMethod (this NSObject This, Selector origSel, NSObject block, out NSError error)
		{
			if (origSel == null)
				throw new ArgumentNullException ("origSel");
			if (block == null)
				throw new ArgumentNullException ("block");
			IntPtr errorValue = IntPtr.Zero;
			
			NSInvocation ret;
			ret =  Runtime.GetNSObject<NSInvocation> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (class_ptr, Selector.GetHandle ("ct_swizzleMethod:withBlock:error:"), origSel.Handle, block.Handle, ref errorValue));
			error = Runtime.GetNSObject<NSError> (errorValue);
			
			return ret;
		}
		
	} /* class NSObject_CTSwizzle */
}
