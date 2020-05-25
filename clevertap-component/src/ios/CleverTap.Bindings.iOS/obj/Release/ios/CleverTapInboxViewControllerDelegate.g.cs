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
	[Protocol (Name = "CleverTapInboxViewControllerDelegate", WrapperType = typeof (CleverTapInboxViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageDidSelect", Selector = "messageDidSelect:atIndex:withButtonIndex:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInboxMessage), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageButtonTappedWithCustomExtras", Selector = "messageButtonTappedWithCustomExtras:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	public interface ICleverTapInboxViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class CleverTapInboxViewControllerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MessageDidSelect (this ICleverTapInboxViewControllerDelegate This, CleverTapInboxMessage message, int index, int buttonIndex)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_int (This.Handle, Selector.GetHandle ("messageDidSelect:atIndex:withButtonIndex:"), message.Handle, index, buttonIndex);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MessageButtonTappedWithCustomExtras (this ICleverTapInboxViewControllerDelegate This, NSDictionary customExtras)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("messageButtonTappedWithCustomExtras:"), customExtras == null ? IntPtr.Zero : customExtras.Handle);
		}
		
	}
	
	internal sealed class CleverTapInboxViewControllerDelegateWrapper : BaseWrapper, ICleverTapInboxViewControllerDelegate {
		[Preserve (Conditional = true)]
		public CleverTapInboxViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapInboxViewControllerDelegate", false)]
	[Model]
	public unsafe partial class CleverTapInboxViewControllerDelegate : NSObject, ICleverTapInboxViewControllerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapInboxViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapInboxViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapInboxViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("messageButtonTappedWithCustomExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageButtonTappedWithCustomExtras (NSDictionary customExtras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("messageDidSelect:atIndex:withButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MessageDidSelect (CleverTapInboxMessage message, int index, int buttonIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CleverTapInboxViewControllerDelegate */
}
