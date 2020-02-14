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
	[Protocol (Name = "CTInAppNotificationDisplayDelegate", WrapperType = typeof (CTInAppNotificationDisplayDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleNotificationCTA", Selector = "handleNotificationCTA:forNotification:fromViewController:withExtras:", ParameterType = new Type [] { typeof (NSUrl), typeof (CleverTapSDK.CTInAppNotification), typeof (CleverTapSDK.CTInAppDisplayViewController), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotificationDidDismiss", Selector = "notificationDidDismiss:fromViewController:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification), typeof (CleverTapSDK.CTInAppDisplayViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotificationDidShow", Selector = "notificationDidShow:fromViewController:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification), typeof (CleverTapSDK.CTInAppDisplayViewController) }, ParameterByRef = new bool [] { false, false })]
	public interface ICTInAppNotificationDisplayDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("handleNotificationCTA:forNotification:fromViewController:withExtras:")]
		[Preserve (Conditional = true)]
		void HandleNotificationCTA (NSUrl ctaURL, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras);
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("notificationDidDismiss:fromViewController:")]
		[Preserve (Conditional = true)]
		void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller);
		
	}
	
	public static partial class CTInAppNotificationDisplayDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NotificationDidShow (this ICTInAppNotificationDisplayDelegate This, CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("notificationDidShow:fromViewController:"), notification.Handle, controller.Handle);
		}
		
	}
	
	internal sealed class CTInAppNotificationDisplayDelegateWrapper : BaseWrapper, ICTInAppNotificationDisplayDelegate {
		[Preserve (Conditional = true)]
		public CTInAppNotificationDisplayDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("handleNotificationCTA:forNotification:fromViewController:withExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleNotificationCTA (NSUrl ctaURL, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras)
		{
			if (ctaURL == null)
				throw new ArgumentNullException ("ctaURL");
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (extras == null)
				throw new ArgumentNullException ("extras");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleNotificationCTA:forNotification:fromViewController:withExtras:"), ctaURL.Handle, notification.Handle, controller.Handle, extras.Handle);
		}
		
		[Export ("notificationDidDismiss:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("notificationDidDismiss:fromViewController:"), notification.Handle, controller.Handle);
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTInAppNotificationDisplayDelegate", false)]
	[Model]
	public unsafe abstract partial class CTInAppNotificationDisplayDelegate : NSObject, ICTInAppNotificationDisplayDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CTInAppNotificationDisplayDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTInAppNotificationDisplayDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTInAppNotificationDisplayDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("handleNotificationCTA:forNotification:fromViewController:withExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void HandleNotificationCTA (NSUrl ctaURL, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras);
		[Export ("notificationDidDismiss:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller);
		[Export ("notificationDidShow:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotificationDidShow (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CTInAppNotificationDisplayDelegate */
}
