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
	[Protocol (Name = "CleverTapInAppNotificationDelegate", WrapperType = typeof (CleverTapInAppNotificationDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowInAppNotificationWithExtras", Selector = "shouldShowInAppNotificationWithExtras:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InAppNotificationDismissedWithExtras", Selector = "inAppNotificationDismissedWithExtras:andActionExtras:", ParameterType = new Type [] { typeof (NSDictionary), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InAppNotificationButtonTappedWithCustomExtras", Selector = "inAppNotificationButtonTappedWithCustomExtras:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	public partial interface ICleverTapInAppNotificationDelegate : INativeObject, IDisposable
	{
	}
	public static partial class CleverTapInAppNotificationDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowInAppNotificationWithExtras (this ICleverTapInAppNotificationDelegate This, NSDictionary extras)
		{
			var extras__handle__ = extras!.GetNonNullHandle (nameof (extras));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("shouldShowInAppNotificationWithExtras:"), extras__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InAppNotificationDismissedWithExtras (this ICleverTapInAppNotificationDelegate This, NSDictionary extras, NSDictionary actionExtras)
		{
			var extras__handle__ = extras!.GetNonNullHandle (nameof (extras));
			var actionExtras__handle__ = actionExtras!.GetNonNullHandle (nameof (actionExtras));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("inAppNotificationDismissedWithExtras:andActionExtras:"), extras__handle__, actionExtras__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InAppNotificationButtonTappedWithCustomExtras (this ICleverTapInAppNotificationDelegate This, NSDictionary customExtras)
		{
			var customExtras__handle__ = customExtras!.GetNonNullHandle (nameof (customExtras));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("inAppNotificationButtonTappedWithCustomExtras:"), customExtras__handle__);
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
