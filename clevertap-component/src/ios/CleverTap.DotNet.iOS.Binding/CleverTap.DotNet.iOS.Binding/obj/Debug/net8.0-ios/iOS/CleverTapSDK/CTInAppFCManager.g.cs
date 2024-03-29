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
	[Protocol (Name = "CTInAppFCManager", WrapperType = typeof (CTInAppFCManagerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CheckUpdateDailyLimits", Selector = "checkUpdateDailyLimits")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanShow", Selector = "canShow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "didDismiss:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResetSession", Selector = "resetSession")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeUserWithGuid", Selector = "changeUserWithGuid:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShow", Selector = "didShow:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateLimitsPerDay", Selector = "updateLimitsPerDay:andPerSession:", ParameterType = new Type [] { typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AttachToHeader", Selector = "attachToHeader:", ParameterType = new Type [] { typeof (NSMutableDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProcessResponse", Selector = "processResponse:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasLifetimeCapacityMaxedOut", Selector = "hasLifetimeCapacityMaxedOut:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasDailyCapacityMaxedOut", Selector = "hasDailyCapacityMaxedOut:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	public partial interface ICTInAppFCManager : INativeObject, IDisposable
	{
	}
	public unsafe static partial class CTInAppFCManager_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CheckUpdateDailyLimits (this ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("checkUpdateDailyLimits"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanShow (this ICTInAppFCManager This, CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canShow:"), inapp__handle__);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this ICTInAppFCManager This, CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didDismiss:"), inapp__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetSession (this ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetSession"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeUserWithGuid (this ICTInAppFCManager This, string guid)
		{
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nsguid = CFString.CreateNative (guid);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("changeUserWithGuid:"), nsguid);
			CFString.ReleaseNative (nsguid);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShow (this ICTInAppFCManager This, CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didShow:"), inapp__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateLimitsPerDay (this ICTInAppFCManager This, int perDay, int perSession)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_int (This.Handle, Selector.GetHandle ("updateLimitsPerDay:andPerSession:"), perDay, perSession);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AttachToHeader (this ICTInAppFCManager This, NSMutableDictionary header)
		{
			var header__handle__ = header!.GetNonNullHandle (nameof (header));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("attachToHeader:"), header__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProcessResponse (this ICTInAppFCManager This, NSDictionary response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("processResponse:"), response__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasLifetimeCapacityMaxedOut (this ICTInAppFCManager This, CTInAppNotification dictionary)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary__handle__);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasDailyCapacityMaxedOut (this ICTInAppFCManager This, CTInAppNotification dictionary)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary__handle__);
			return ret != 0;
		}
	}
	internal unsafe sealed class CTInAppFCManagerWrapper : BaseWrapper, ICTInAppFCManager {
		[Preserve (Conditional = true)]
		public CTInAppFCManagerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTInAppFCManager", true)]
	public unsafe partial class CTInAppFCManager : NSObject, ICTInAppFCManager {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTInAppFCManager");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTInAppFCManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTInAppFCManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTInAppFCManager (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:guid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTInAppFCManager (CleverTapInstanceConfig config, string guid)
			: base (NSObjectFlag.Empty)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nsguid = CFString.CreateNative (guid);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithConfig:guid:"), config__handle__, nsguid), "initWithConfig:guid:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithConfig:guid:"), config__handle__, nsguid), "initWithConfig:guid:");
			}
			CFString.ReleaseNative (nsguid);
		}
		[Export ("attachToHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AttachToHeader (NSMutableDictionary header)
		{
			var header__handle__ = header!.GetNonNullHandle (nameof (header));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("attachToHeader:"), header__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("attachToHeader:"), header__handle__);
			}
		}
		[Export ("canShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanShow (CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("canShow:"), inapp__handle__);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("canShow:"), inapp__handle__);
			}
			return ret != 0;
		}
		[Export ("changeUserWithGuid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeUserWithGuid (string guid)
		{
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nsguid = CFString.CreateNative (guid);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("changeUserWithGuid:"), nsguid);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("changeUserWithGuid:"), nsguid);
			}
			CFString.ReleaseNative (nsguid);
		}
		[Export ("checkUpdateDailyLimits")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckUpdateDailyLimits ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("checkUpdateDailyLimits"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("checkUpdateDailyLimits"));
			}
		}
		[Export ("didDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didDismiss:"), inapp__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("didDismiss:"), inapp__handle__);
			}
		}
		[Export ("didShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShow (CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didShow:"), inapp__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("didShow:"), inapp__handle__);
			}
		}
		[Export ("hasDailyCapacityMaxedOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDailyCapacityMaxedOut (CTInAppNotification dictionary)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary__handle__);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary__handle__);
			}
			return ret != 0;
		}
		[Export ("hasLifetimeCapacityMaxedOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasLifetimeCapacityMaxedOut (CTInAppNotification dictionary)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary__handle__);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary__handle__);
			}
			return ret != 0;
		}
		[Export ("processResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessResponse (NSDictionary response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("processResponse:"), response__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("processResponse:"), response__handle__);
			}
		}
		[Export ("resetSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetSession ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetSession"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetSession"));
			}
		}
		[Export ("updateLimitsPerDay:andPerSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateLimitsPerDay (int perDay, int perSession)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("updateLimitsPerDay:andPerSession:"), perDay, perSession);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("updateLimitsPerDay:andPerSession:"), perDay, perSession);
			}
		}
	} /* class CTInAppFCManager */
}
