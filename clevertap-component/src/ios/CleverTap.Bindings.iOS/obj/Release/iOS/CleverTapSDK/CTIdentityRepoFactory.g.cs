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
	[Protocol (Name = "CTIdentityRepoFactory", WrapperType = typeof (CTIdentityRepoFactoryWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetRepoForConfig", Selector = "getRepoForConfig:deviceInfo:validationResultStack:", ReturnType = typeof (CleverTapSDK.CTIdentityRepo), ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInstanceConfig), typeof (CleverTapSDK.CTDeviceInfo), typeof (CleverTapSDK.CTValidationResultStack) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ICTIdentityRepoFactory : INativeObject, IDisposable
	{
	}
	internal sealed class CTIdentityRepoFactoryWrapper : BaseWrapper, ICTIdentityRepoFactory {
		[Preserve (Conditional = true)]
		public CTIdentityRepoFactoryWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTIdentityRepoFactory", true)]
	public unsafe partial class CTIdentityRepoFactory : NSObject, ICTIdentityRepoFactory {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTIdentityRepoFactory");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTIdentityRepoFactory () : base (NSObjectFlag.Empty)
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
		protected CTIdentityRepoFactory (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTIdentityRepoFactory (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getRepoForConfig:deviceInfo:validationResultStack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTIdentityRepo GetRepoForConfig (CleverTapInstanceConfig config, CTDeviceInfo deviceInfo, CTValidationResultStack validationResultStack)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var deviceInfo__handle__ = deviceInfo!.GetNonNullHandle (nameof (deviceInfo));
			var validationResultStack__handle__ = validationResultStack!.GetNonNullHandle (nameof (validationResultStack));
			return  Runtime.GetNSObject<CTIdentityRepo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getRepoForConfig:deviceInfo:validationResultStack:"), config__handle__, deviceInfo__handle__, validationResultStack__handle__))!;
		}
	} /* class CTIdentityRepoFactory */
}
