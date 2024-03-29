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
	[Protocol (Name = "CTInAppNotificationDisplayDelegate", WrapperType = typeof (CTInAppNotificationDisplayDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleNotificationCTA", Selector = "handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:", ParameterType = new Type [] { typeof (NSUrl), typeof (NSDictionary), typeof (CleverTapSDK.CTInAppNotification), typeof (CleverTapSDK.CTInAppDisplayViewController), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotificationDidDismiss", Selector = "notificationDidDismiss:fromViewController:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification), typeof (CleverTapSDK.CTInAppDisplayViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotificationDidShow", Selector = "notificationDidShow:fromViewController:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification), typeof (CleverTapSDK.CTInAppDisplayViewController) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICTInAppNotificationDisplayDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:")]
		[Preserve (Conditional = true)]
		void HandleNotificationCTA (NSUrl ctaURL, NSDictionary buttonCustomExtras, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("notificationDidDismiss:fromViewController:")]
		[Preserve (Conditional = true)]
		void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller);
	}
	public unsafe static partial class CTInAppNotificationDisplayDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NotificationDidShow (this ICTInAppNotificationDisplayDelegate This, CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("notificationDidShow:fromViewController:"), notification__handle__, controller__handle__);
		}
	}
	internal unsafe sealed class CTInAppNotificationDisplayDelegateWrapper : BaseWrapper, ICTInAppNotificationDisplayDelegate {
		[Preserve (Conditional = true)]
		public CTInAppNotificationDisplayDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleNotificationCTA (NSUrl ctaURL, NSDictionary buttonCustomExtras, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras)
		{
			var ctaURL__handle__ = ctaURL!.GetNonNullHandle (nameof (ctaURL));
			var buttonCustomExtras__handle__ = buttonCustomExtras!.GetNonNullHandle (nameof (buttonCustomExtras));
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var extras__handle__ = extras!.GetNonNullHandle (nameof (extras));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:"), ctaURL__handle__, buttonCustomExtras__handle__, notification__handle__, controller__handle__, extras__handle__);
		}
		[Export ("notificationDidDismiss:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("notificationDidDismiss:fromViewController:"), notification__handle__, controller__handle__);
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CTInAppNotificationDisplayDelegate", false)]
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
		protected internal CTInAppNotificationDisplayDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationCTA (NSUrl ctaURL, NSDictionary buttonCustomExtras, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("notificationDidDismiss:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("notificationDidShow:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotificationDidShow (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CTInAppNotificationDisplayDelegate */
}
