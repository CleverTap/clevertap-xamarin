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
	[Register("CTUtils", true)]
	public unsafe partial class CTUtils : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTUtils");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTUtils () : base (NSObjectFlag.Empty)
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
		protected CTUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTUtils (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("deviceTokenStringFromData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string DeviceTokenStringFromData (NSData tokenData)
		{
			var tokenData__handle__ = tokenData!.GetNonNullHandle (nameof (tokenData));
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deviceTokenStringFromData:"), tokenData__handle__))!;
		}
		[Export ("dictionaryToJsonString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string DictionaryToJsonString (NSDictionary dict)
		{
			var dict__handle__ = dict!.GetNonNullHandle (nameof (dict));
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dictionaryToJsonString:"), dict__handle__))!;
		}
		[Export ("doesString:startWith:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DoesString (string s, string prefix)
		{
			if (s is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (s));
			if (prefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prefix));
			var nss = CFString.CreateNative (s);
			var nsprefix = CFString.CreateNative (prefix);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("doesString:startWith:"), nss, nsprefix);
			CFString.ReleaseNative (nss);
			CFString.ReleaseNative (nsprefix);
			return ret!;
		}
		[Export ("toTwoPlaces:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double ToTwoPlaces (double x)
		{
			return global::ApiDefinition.Messaging.Double_objc_msgSend_Double (class_ptr, Selector.GetHandle ("toTwoPlaces:"), x);
		}
		[Export ("urlEncodeString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UrlEncodeString (string s)
		{
			if (s is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (s));
			var nss = CFString.CreateNative (s);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("urlEncodeString:"), nss))!;
			CFString.ReleaseNative (nss);
			return ret!;
		}
	} /* class CTUtils */
}
