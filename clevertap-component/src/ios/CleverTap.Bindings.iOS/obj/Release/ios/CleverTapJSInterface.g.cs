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
	[Protocol (Name = "CleverTapJSInterface", WrapperType = typeof (CleverTapJSInterfaceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserContentController", Selector = "userContentController", PropertyType = typeof (WebKit.WKUserContentController), GetterSelector = "userContentController", SetterSelector = "setUserContentController:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public interface ICleverTapJSInterface : INativeObject, IDisposable, 
		WebKit.IWKScriptMessageHandler
		
	{
	}
	
	public static partial class CleverTapJSInterface_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::WebKit.WKUserContentController GetUserContentController (this ICleverTapJSInterface This)
		{
			return  Runtime.GetNSObject<global::WebKit.WKUserContentController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("userContentController")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserContentController (this ICleverTapJSInterface This, global::WebKit.WKUserContentController value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUserContentController:"), value.Handle);
		}
		
	}
	
	internal sealed class CleverTapJSInterfaceWrapper : BaseWrapper, ICleverTapJSInterface {
		[Preserve (Conditional = true)]
		public CleverTapJSInterfaceWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public void DidReceiveScriptMessage (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			if (userContentController == null)
				throw new ArgumentNullException ("userContentController");
			if (message == null)
				throw new ArgumentNullException ("message");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController.Handle, message.Handle);
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CleverTapJSInterface", true)]
	public unsafe partial class CleverTapJSInterface : NSObject, ICleverTapJSInterface, global::WebKit.IWKScriptMessageHandler {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTapJSInterface");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapJSInterface () : base (NSObjectFlag.Empty)
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
		protected CleverTapJSInterface (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapJSInterface (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CleverTapJSInterface (CleverTapInstanceConfig config)
			: base (NSObjectFlag.Empty)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:"), config.Handle), "initWithConfig:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:"), config.Handle), "initWithConfig:");
			}
		}
		
		[Export ("userContentController:didReceiveScriptMessage:")]
		[Introduced (PlatformName.MacOSX, 10,10, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual void DidReceiveScriptMessage (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			if (userContentController == null)
				throw new ArgumentNullException ("userContentController");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController.Handle, message.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController.Handle, message.Handle);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::WebKit.WKUserContentController UserContentController {
			[Export ("userContentController", ArgumentSemantic.Retain)]
			get {
				global::WebKit.WKUserContentController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::WebKit.WKUserContentController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userContentController")));
				} else {
					ret =  Runtime.GetNSObject<global::WebKit.WKUserContentController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userContentController")));
				}
				return ret;
			}
			
			[Export ("setUserContentController:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserContentController:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserContentController:"), value.Handle);
				}
			}
		}
		
	} /* class CleverTapJSInterface */
}
