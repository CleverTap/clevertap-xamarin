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
	[Protocol (Name = "CleverTapURLDelegate", WrapperType = typeof (CleverTapURLDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ForChannel", Selector = "shouldHandleCleverTapURL:forChannel:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (CleverTapSDK.CleverTapChannel) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICleverTapURLDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("shouldHandleCleverTapURL:forChannel:")]
		[Preserve (Conditional = true)]
		bool ForChannel (NSUrl? url, CleverTapChannel channel);
	}
	internal unsafe sealed class CleverTapURLDelegateWrapper : BaseWrapper, ICleverTapURLDelegate {
		[Preserve (Conditional = true)]
		public CleverTapURLDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("shouldHandleCleverTapURL:forChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ForChannel (NSUrl? url, CleverTapChannel channel)
		{
			var url__handle__ = url.GetHandle ();
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_int (this.Handle, Selector.GetHandle ("shouldHandleCleverTapURL:forChannel:"), url__handle__, (int)channel);
			return ret != 0;
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapURLDelegate", false)]
	[Model]
	public unsafe abstract partial class CleverTapURLDelegate : NSObject, ICleverTapURLDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CleverTapURLDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapURLDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapURLDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("shouldHandleCleverTapURL:forChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ForChannel (NSUrl? url, CleverTapChannel channel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CleverTapURLDelegate */
}
