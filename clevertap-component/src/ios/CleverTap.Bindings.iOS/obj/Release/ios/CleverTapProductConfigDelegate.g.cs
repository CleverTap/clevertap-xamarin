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
	[Protocol (Name = "CleverTapProductConfigDelegate", WrapperType = typeof (CleverTapProductConfigDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CtProductConfigFetched", Selector = "ctProductConfigFetched")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CtProductConfigActivated", Selector = "ctProductConfigActivated")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CtProductConfigInitialized", Selector = "ctProductConfigInitialized")]
	public interface ICleverTapProductConfigDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class CleverTapProductConfigDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CtProductConfigFetched (this ICleverTapProductConfigDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("ctProductConfigFetched"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CtProductConfigActivated (this ICleverTapProductConfigDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("ctProductConfigActivated"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CtProductConfigInitialized (this ICleverTapProductConfigDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("ctProductConfigInitialized"));
		}
		
	}
	
	internal sealed class CleverTapProductConfigDelegateWrapper : BaseWrapper, ICleverTapProductConfigDelegate {
		[Preserve (Conditional = true)]
		public CleverTapProductConfigDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapProductConfigDelegate", false)]
	[Model]
	public unsafe partial class CleverTapProductConfigDelegate : NSObject, ICleverTapProductConfigDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapProductConfigDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapProductConfigDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapProductConfigDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("ctProductConfigActivated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CtProductConfigActivated ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("ctProductConfigFetched")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CtProductConfigFetched ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("ctProductConfigInitialized")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CtProductConfigInitialized ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CleverTapProductConfigDelegate */
}
