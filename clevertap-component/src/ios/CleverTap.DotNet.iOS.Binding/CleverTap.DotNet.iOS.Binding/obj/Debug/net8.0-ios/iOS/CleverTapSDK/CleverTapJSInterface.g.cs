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
	[Protocol (Name = "CleverTapJSInterface", WrapperType = typeof (CleverTapJSInterfaceWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UserContentController", Selector = "userContentController", PropertyType = typeof (WebKit.WKUserContentController), GetterSelector = "userContentController", SetterSelector = "setUserContentController:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ICleverTapJSInterface : INativeObject, IDisposable, 
		WebKit.IWKScriptMessageHandler
	{
	}
	public unsafe static partial class CleverTapJSInterface_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::WebKit.WKUserContentController GetUserContentController (this ICleverTapJSInterface This)
		{
			return  Runtime.GetNSObject<global::WebKit.WKUserContentController> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("userContentController")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserContentController (this ICleverTapJSInterface This, global::WebKit.WKUserContentController value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setUserContentController:"), value__handle__);
		}
	}
	internal unsafe sealed class CleverTapJSInterfaceWrapper : BaseWrapper, ICleverTapJSInterface {
		[Preserve (Conditional = true)]
		public CleverTapJSInterfaceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public void DidReceiveScriptMessage (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CleverTapJSInterface", true)]
	public unsafe partial class CleverTapJSInterface : NSObject, ICleverTapJSInterface, global::WebKit.IWKScriptMessageHandler {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CleverTapJSInterface");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected internal CleverTapJSInterface (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CleverTapJSInterface (CleverTapInstanceConfig config)
			: base (NSObjectFlag.Empty)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithConfig:"), config__handle__), "initWithConfig:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithConfig:"), config__handle__), "initWithConfig:");
			}
		}
		[Export ("userContentController:didReceiveScriptMessage:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual void DidReceiveScriptMessage (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::WebKit.WKUserContentController UserContentController {
			[Export ("userContentController", ArgumentSemantic.Retain)]
			get {
				global::WebKit.WKUserContentController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::WebKit.WKUserContentController> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userContentController")))!;
				} else {
					ret =  Runtime.GetNSObject<global::WebKit.WKUserContentController> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userContentController")))!;
				}
				return ret!;
			}
			[Export ("setUserContentController:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserContentController:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUserContentController:"), value__handle__);
				}
			}
		}
	} /* class CleverTapJSInterface */
}
