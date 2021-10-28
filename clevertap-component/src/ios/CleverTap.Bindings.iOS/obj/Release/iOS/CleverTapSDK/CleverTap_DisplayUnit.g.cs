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
	public unsafe static partial class CleverTap_DisplayUnit  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTap");
		
		[Export ("getDisplayUnitForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapDisplayUnit? GetDisplayUnitForID (this CleverTap This, string unitID)
		{
			if (unitID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (unitID));
			var nsunitID = NSString.CreateNative (unitID);
			
			CleverTapDisplayUnit ret;
			ret =  Runtime.GetNSObject<CleverTapDisplayUnit> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getDisplayUnitForID:"), nsunitID));
			NSString.ReleaseNative (nsunitID);
			
			return ret!;
		}
		
		[Export ("recordDisplayUnitClickedEventForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordDisplayUnitClickedEventForID (this CleverTap This, string unitID)
		{
			if (unitID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (unitID));
			var nsunitID = NSString.CreateNative (unitID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordDisplayUnitClickedEventForID:"), nsunitID);
			NSString.ReleaseNative (nsunitID);
			
		}
		
		[Export ("recordDisplayUnitViewedEventForID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordDisplayUnitViewedEventForID (this CleverTap This, string unitID)
		{
			if (unitID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (unitID));
			var nsunitID = NSString.CreateNative (unitID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("recordDisplayUnitViewedEventForID:"), nsunitID);
			NSString.ReleaseNative (nsunitID);
			
		}
		
		[Export ("setDisplayUnitDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDisplayUnitDelegate (this CleverTap This, CleverTapDisplayUnitDelegate @delegate)
		{
			var @delegate__handle__ = @delegate.GetNonNullHandle (nameof (@delegate));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDisplayUnitDelegate:"), @delegate__handle__);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapDisplayUnit[] AllDisplayUnits {
			[Export ("getAllDisplayUnits")]
			get {
				CleverTapDisplayUnit[] ret;
				ret = NSArray.ArrayFromHandle<CleverTapDisplayUnit>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getAllDisplayUnits")));
				return ret!;
			}
			
		}
		
	} /* class CleverTap_DisplayUnit */
}
