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

namespace CleverTapSDK {
	[Protocol (Name = "CleverTapFeatureFlagsDelegate", WrapperType = typeof (CleverTapFeatureFlagsDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CtFeatureFlagsUpdated", Selector = "ctFeatureFlagsUpdated")]
	public interface ICleverTapFeatureFlagsDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class CleverTapFeatureFlagsDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CtFeatureFlagsUpdated (this ICleverTapFeatureFlagsDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("ctFeatureFlagsUpdated"));
		}
		
	}
	
	internal sealed class CleverTapFeatureFlagsDelegateWrapper : BaseWrapper, ICleverTapFeatureFlagsDelegate {
		[Preserve (Conditional = true)]
		public CleverTapFeatureFlagsDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapFeatureFlagsDelegate", false)]
	[Model]
	public unsafe partial class CleverTapFeatureFlagsDelegate : NSObject, ICleverTapFeatureFlagsDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapFeatureFlagsDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapFeatureFlagsDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapFeatureFlagsDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("ctFeatureFlagsUpdated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CtFeatureFlagsUpdated ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CleverTapFeatureFlagsDelegate */
}
