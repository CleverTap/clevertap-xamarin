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
	[Protocol (Name = "CleverTapInAppNotificationDelegate", WrapperType = typeof (CleverTapInAppNotificationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowInAppNotificationWithExtras", Selector = "shouldShowInAppNotificationWithExtras:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InAppNotificationDismissedWithExtras", Selector = "inAppNotificationDismissedWithExtras:andActionExtras:", ParameterType = new Type [] { typeof (NSDictionary), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InAppNotificationButtonTappedWithCustomExtras", Selector = "inAppNotificationButtonTappedWithCustomExtras:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	public interface ICleverTapInAppNotificationDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class CleverTapInAppNotificationDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowInAppNotificationWithExtras (this ICleverTapInAppNotificationDelegate This, NSDictionary extras)
		{
			if (extras == null)
				throw new ArgumentNullException ("extras");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("shouldShowInAppNotificationWithExtras:"), extras.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InAppNotificationDismissedWithExtras (this ICleverTapInAppNotificationDelegate This, NSDictionary extras, NSDictionary actionExtras)
		{
			if (extras == null)
				throw new ArgumentNullException ("extras");
			if (actionExtras == null)
				throw new ArgumentNullException ("actionExtras");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("inAppNotificationDismissedWithExtras:andActionExtras:"), extras.Handle, actionExtras.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InAppNotificationButtonTappedWithCustomExtras (this ICleverTapInAppNotificationDelegate This, NSDictionary customExtras)
		{
			if (customExtras == null)
				throw new ArgumentNullException ("customExtras");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inAppNotificationButtonTappedWithCustomExtras:"), customExtras.Handle);
		}
		
	}
	
	internal sealed class CleverTapInAppNotificationDelegateWrapper : BaseWrapper, ICleverTapInAppNotificationDelegate {
		[Preserve (Conditional = true)]
		public CleverTapInAppNotificationDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapInAppNotificationDelegate", false)]
	[Model]
	public unsafe partial class CleverTapInAppNotificationDelegate : NSObject, ICleverTapInAppNotificationDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapInAppNotificationDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapInAppNotificationDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapInAppNotificationDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("inAppNotificationButtonTappedWithCustomExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InAppNotificationButtonTappedWithCustomExtras (NSDictionary customExtras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("inAppNotificationDismissedWithExtras:andActionExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InAppNotificationDismissedWithExtras (NSDictionary extras, NSDictionary actionExtras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("shouldShowInAppNotificationWithExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowInAppNotificationWithExtras (NSDictionary extras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CleverTapInAppNotificationDelegate */
}
