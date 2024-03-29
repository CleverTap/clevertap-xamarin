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
	[Protocol (Name = "CTUIUtils", WrapperType = typeof (CTUIUtilsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetImageForName", Selector = "getImageForName:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Ct_colorWithHexString", Selector = "ct_colorWithHexString:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Ct_colorWithHexString", Selector = "ct_colorWithHexString:withAlpha:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (string), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Bundle", Selector = "bundle", PropertyType = typeof (NSBundle), GetterSelector = "bundle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "SharedApplication", Selector = "getSharedApplication", PropertyType = typeof (UIApplication), GetterSelector = "getSharedApplication", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "KeyWindow", Selector = "getKeyWindow", PropertyType = typeof (UIWindow), GetterSelector = "getKeyWindow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "IsDeviceOrientationLandscape", Selector = "isDeviceOrientationLandscape", PropertyType = typeof (bool), GetterSelector = "isDeviceOrientationLandscape", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "IsUserInterfaceIdiomPad", Selector = "isUserInterfaceIdiomPad", PropertyType = typeof (bool), GetterSelector = "isUserInterfaceIdiomPad", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "LeftMargin", Selector = "getLeftMargin", PropertyType = typeof (NFloat), GetterSelector = "getLeftMargin", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICTUIUtils : INativeObject, IDisposable
	{
	}
	internal unsafe sealed class CTUIUtilsWrapper : BaseWrapper, ICTUIUtils {
		[Preserve (Conditional = true)]
		public CTUIUtilsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTUIUtils", true)]
	public unsafe partial class CTUIUtils : NSObject, ICTUIUtils {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTUIUtils");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTUIUtils () : base (NSObjectFlag.Empty)
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
		protected CTUIUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTUIUtils (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("ct_colorWithHexString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::UIKit.UIColor? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("ct_colorWithHexString:"), nsstring))!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[Export ("ct_colorWithHexString:withAlpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString (string @string, nfloat alpha)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::UIKit.UIColor? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("ct_colorWithHexString:withAlpha:"), nsstring, alpha))!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[Export ("getImageForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage GetImageForName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getImageForName:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle Bundle {
			[Export ("bundle")]
			get {
				NSBundle? ret;
				ret =  Runtime.GetNSObject<NSBundle> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("bundle")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDeviceOrientationLandscape {
			[Export ("isDeviceOrientationLandscape")]
			get {
				byte ret;
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isDeviceOrientationLandscape"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUserInterfaceIdiomPad {
			[Export ("isUserInterfaceIdiomPad")]
			get {
				byte ret;
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isUserInterfaceIdiomPad"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIWindow? KeyWindow {
			[Export ("getKeyWindow")]
			get {
				global::UIKit.UIWindow? ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getKeyWindow")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat LeftMargin {
			[Export ("getLeftMargin")]
			get {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("getLeftMargin"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIApplication? SharedApplication {
			[Export ("getSharedApplication")]
			get {
				global::UIKit.UIApplication? ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIApplication> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getSharedApplication")))!;
				return ret!;
			}
		}
	} /* class CTUIUtils */
}
