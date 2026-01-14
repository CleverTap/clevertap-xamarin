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
		[global::Foundation.RequiredMember]
		[Export ("handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleNotificationCTA (NSUrl ctaURL, NSDictionary buttonCustomExtras, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleNotificationCTA (ICTInAppNotificationDisplayDelegate This, NSUrl ctaURL, NSDictionary buttonCustomExtras, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[global::Foundation.RequiredMember]
		[Export ("notificationDidDismiss:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotificationDidDismiss (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NotificationDidDismiss (ICTInAppNotificationDisplayDelegate This, CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[global::Foundation.OptionalMember]
		[Export ("notificationDidShow:fromViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NotificationDidShow (CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			_NotificationDidShow (this, notification, controller);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NotificationDidShow (ICTInAppNotificationDisplayDelegate This, CTInAppNotification notification, CTInAppDisplayViewController controller)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("notificationDidShow:fromViewController:"), notification__handle__, controller__handle__);
		}
		[DynamicDependencyAttribute ("HandleNotificationCTA(Foundation.NSUrl,Foundation.NSDictionary,CleverTapSDK.CTInAppNotification,CleverTapSDK.CTInAppDisplayViewController,Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("NotificationDidDismiss(CleverTapSDK.CTInAppNotification,CleverTapSDK.CTInAppDisplayViewController)")]
		[DynamicDependencyAttribute ("NotificationDidShow(CleverTapSDK.CTInAppNotification,CleverTapSDK.CTInAppDisplayViewController)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICTInAppNotificationDisplayDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ICTInAppNotificationDisplayDelegate" /> interface to support all the methods from the CTInAppNotificationDisplayDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICTInAppNotificationDisplayDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CTInAppNotificationDisplayDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
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
		/// <summary>Creates a new <see cref="CTInAppNotificationDisplayDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CTInAppNotificationDisplayDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, initWithFrame, frame);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTInAppNotificationDisplayDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
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
