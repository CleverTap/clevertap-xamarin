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
	[Protocol (Name = "CleverTapDisplayUnitDelegate", WrapperType = typeof (CleverTapDisplayUnitDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayUnitsUpdated", Selector = "displayUnitsUpdated:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapDisplayUnit[]) }, ParameterByRef = new bool [] { false })]
	public partial interface ICleverTapDisplayUnitDelegate : INativeObject, IDisposable
	{
	}
	public static partial class CleverTapDisplayUnitDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisplayUnitsUpdated (this ICleverTapDisplayUnitDelegate This, CleverTapDisplayUnit[] displayUnits)
		{
			if (displayUnits is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (displayUnits));
			var nsa_displayUnits = NSArray.FromNSObjects (displayUnits);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("displayUnitsUpdated:"), nsa_displayUnits.Handle);
			nsa_displayUnits.Dispose ();
		}
	}
	internal sealed class CleverTapDisplayUnitDelegateWrapper : BaseWrapper, ICleverTapDisplayUnitDelegate {
		[Preserve (Conditional = true)]
		public CleverTapDisplayUnitDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapDisplayUnitDelegate", false)]
	[Model]
	public unsafe partial class CleverTapDisplayUnitDelegate : NSObject, ICleverTapDisplayUnitDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapDisplayUnitDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapDisplayUnitDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapDisplayUnitDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("displayUnitsUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayUnitsUpdated (CleverTapDisplayUnit[] displayUnits)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CleverTapDisplayUnitDelegate */
}
