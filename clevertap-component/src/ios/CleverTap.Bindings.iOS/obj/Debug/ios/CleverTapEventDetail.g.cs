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
	[Register("CleverTapEventDetail", true)]
	public unsafe partial class CleverTapEventDetail : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTapEventDetail");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapEventDetail () : base (NSObjectFlag.Empty)
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
		protected CleverTapEventDetail (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapEventDetail (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Count {
			[Export ("count")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("count"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("count"));
				}
			}
			
			[Export ("setCount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setCount:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setCount:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string EventName {
			[Export ("eventName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("eventName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("eventName")));
				}
			}
			
			[Export ("setEventName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEventName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEventName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double FirstTime {
			[Export ("firstTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("firstTime"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firstTime"));
				}
			}
			
			[Export ("setFirstTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setFirstTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setFirstTime:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double LastTime {
			[Export ("lastTime")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastTime"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastTime"));
				}
			}
			
			[Export ("setLastTime:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLastTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLastTime:"), value);
				}
			}
		}
		
	} /* class CleverTapEventDetail */
}
