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
	[Protocol (Name = "CTUriHelper", WrapperType = typeof (CTUriHelperWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetUrchinFromUri", Selector = "getUrchinFromUri:withSourceApp:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetQueryParameters", Selector = "getQueryParameters:andDecode:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (NSUrl), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICTUriHelper : INativeObject, IDisposable
	{
	}
	internal unsafe sealed class CTUriHelperWrapper : BaseWrapper, ICTUriHelper {
		[Preserve (Conditional = true)]
		public CTUriHelperWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTUriHelper", true)]
	public unsafe partial class CTUriHelper : NSObject, ICTUriHelper {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTUriHelper");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTUriHelper () : base (NSObjectFlag.Empty)
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
		protected CTUriHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTUriHelper (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getQueryParameters:andDecode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetQueryParameters (NSUrl url, bool decode)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("getQueryParameters:andDecode:"), url__handle__, decode ? (byte) 1 : (byte) 0))!;
		}
		[Export ("getUrchinFromUri:withSourceApp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetUrchinFromUri (string uri, string sourceApp)
		{
			if (uri is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (uri));
			if (sourceApp is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceApp));
			var nsuri = CFString.CreateNative (uri);
			var nssourceApp = CFString.CreateNative (sourceApp);
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("getUrchinFromUri:withSourceApp:"), nsuri, nssourceApp))!;
			CFString.ReleaseNative (nsuri);
			CFString.ReleaseNative (nssourceApp);
			return ret!;
		}
	} /* class CTUriHelper */
}
