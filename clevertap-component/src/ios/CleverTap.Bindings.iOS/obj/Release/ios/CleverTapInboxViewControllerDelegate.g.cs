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
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AtIndex", Selector = "messageDidSelect:atIndex:withButtonIndex:", ParameterType = new Type [] { typeof (CleverTapSDK.CleverTapInboxMessage), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false })]
	public interface ICleverTapInboxViewControllerDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("messageDidSelect:atIndex:withButtonIndex:")]
		[Preserve (Conditional = true)]
		void AtIndex (CleverTapInboxMessage message, int index, int buttonIndex);
		
	}
	
	internal sealed class CleverTapInboxViewControllerDelegateWrapper : BaseWrapper, ICleverTapInboxViewControllerDelegate {
		[Preserve (Conditional = true)]
		public CleverTapInboxViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("messageDidSelect:atIndex:withButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AtIndex (CleverTapInboxMessage message, int index, int buttonIndex)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_int_int (this.Handle, Selector.GetHandle ("messageDidSelect:atIndex:withButtonIndex:"), message.Handle, index, buttonIndex);
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CleverTapInboxViewControllerDelegate", false)]
	[Model]
	public unsafe abstract partial class CleverTapInboxViewControllerDelegate : NSObject, ICleverTapInboxViewControllerDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CleverTapInboxViewControllerDelegate () : base (NSObjectFlag.Empty)
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

		[Export ("messageDidSelect:atIndex:withButtonIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void AtIndex (CleverTapInboxMessage message, int index, int buttonIndex);
	} /* class CleverTapInboxViewControllerDelegate */
}
