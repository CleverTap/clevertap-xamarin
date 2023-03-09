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
	[Protocol (Name = "CTValidationResultStack", WrapperType = typeof (CTValidationResultStackWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PushValidationResults", Selector = "pushValidationResults:", ParameterType = new Type [] { typeof (CleverTapSDK.CTValidationResult[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PushValidationResult", Selector = "pushValidationResult:", ParameterType = new Type [] { typeof (CleverTapSDK.CTValidationResult) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PopValidationResult", Selector = "popValidationResult", PropertyType = typeof (CleverTapSDK.CTValidationResult), GetterSelector = "popValidationResult", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICTValidationResultStack : INativeObject, IDisposable
	{
	}
	public static partial class CTValidationResultStack_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PushValidationResults (this ICTValidationResultStack This, CTValidationResult[] results)
		{
			if (results is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (results));
			var nsa_results = NSArray.FromNSObjects (results);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("pushValidationResults:"), nsa_results.Handle);
			nsa_results.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PushValidationResult (this ICTValidationResultStack This, CTValidationResult vr)
		{
			var vr__handle__ = vr!.GetNonNullHandle (nameof (vr));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("pushValidationResult:"), vr__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult GetPopValidationResult (this ICTValidationResultStack This)
		{
			return  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("popValidationResult")))!;
		}
	}
	internal sealed class CTValidationResultStackWrapper : BaseWrapper, ICTValidationResultStack {
		[Preserve (Conditional = true)]
		public CTValidationResultStackWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTValidationResultStack", true)]
	public unsafe partial class CTValidationResultStack : NSObject, ICTValidationResultStack {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTValidationResultStack");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTValidationResultStack () : base (NSObjectFlag.Empty)
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
		protected CTValidationResultStack (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTValidationResultStack (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTValidationResultStack (CleverTapInstanceConfig config)
			: base (NSObjectFlag.Empty)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:"), config__handle__), "initWithConfig:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:"), config__handle__), "initWithConfig:");
			}
		}
		[Export ("pushValidationResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushValidationResult (CTValidationResult vr)
		{
			var vr__handle__ = vr!.GetNonNullHandle (nameof (vr));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pushValidationResult:"), vr__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pushValidationResult:"), vr__handle__);
			}
		}
		[Export ("pushValidationResults:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PushValidationResults (CTValidationResult[] results)
		{
			if (results is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (results));
			var nsa_results = NSArray.FromNSObjects (results);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pushValidationResults:"), nsa_results.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pushValidationResults:"), nsa_results.Handle);
			}
			nsa_results.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CTValidationResult PopValidationResult {
			[Export ("popValidationResult")]
			get {
				CTValidationResult? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("popValidationResult")))!;
				} else {
					ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("popValidationResult")))!;
				}
				return ret!;
			}
		}
	} /* class CTValidationResultStack */
}
