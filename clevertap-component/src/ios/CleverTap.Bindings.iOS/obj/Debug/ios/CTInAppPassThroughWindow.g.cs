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
	[Register("CTInAppPassThroughWindow", true)]
	public unsafe partial class CTInAppPassThroughWindow : global::UIKit.UIWindow {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTInAppPassThroughWindow");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTInAppPassThroughWindow () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CTInAppPassThroughWindow (NSCoder coder) : base (NSObjectFlag.Empty)
		{

			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTInAppPassThroughWindow (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTInAppPassThroughWindow (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		public partial class CTInAppPassThroughWindowAppearance : global::UIKit.UIWindow.UIWindowAppearance {
			protected internal CTInAppPassThroughWindowAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new CTInAppPassThroughWindowAppearance Appearance {
			get { return new CTInAppPassThroughWindowAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new CTInAppPassThroughWindowAppearance GetAppearance<T> () where T: CTInAppPassThroughWindow {
			return new CTInAppPassThroughWindowAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new CTInAppPassThroughWindowAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new CTInAppPassThroughWindowAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new CTInAppPassThroughWindowAppearance GetAppearance (UITraitCollection traits) {
			return new CTInAppPassThroughWindowAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new CTInAppPassThroughWindowAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new CTInAppPassThroughWindowAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new CTInAppPassThroughWindowAppearance GetAppearance<T> (UITraitCollection traits) where T: CTInAppPassThroughWindow {
			return new CTInAppPassThroughWindowAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new CTInAppPassThroughWindowAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: CTInAppPassThroughWindow{
			return new CTInAppPassThroughWindowAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class CTInAppPassThroughWindow */
}
