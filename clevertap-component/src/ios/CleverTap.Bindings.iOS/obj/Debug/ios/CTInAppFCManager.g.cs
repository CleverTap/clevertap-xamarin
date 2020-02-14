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
	[Protocol (Name = "CTInAppFCManager", WrapperType = typeof (CTInAppFCManagerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CheckUpdateDailyLimits", Selector = "checkUpdateDailyLimits")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanShow", Selector = "canShow:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDismiss", Selector = "didDismiss:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResetSession", Selector = "resetSession")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeUser", Selector = "changeUser")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShow", Selector = "didShow:", ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateLimitsPerDay", Selector = "updateLimitsPerDay:andPerSession:", ParameterType = new Type [] { typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AttachToHeader", Selector = "attachToHeader:", ParameterType = new Type [] { typeof (NSMutableDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProcessResponse", Selector = "processResponse:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasLifetimeCapacityMaxedOut", Selector = "hasLifetimeCapacityMaxedOut:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasDailyCapacityMaxedOut", Selector = "hasDailyCapacityMaxedOut:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CleverTapSDK.CTInAppNotification) }, ParameterByRef = new bool [] { false })]
	public interface ICTInAppFCManager : INativeObject, IDisposable
	{
	}
	
	public static partial class CTInAppFCManager_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CheckUpdateDailyLimits (this ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("checkUpdateDailyLimits"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanShow (this ICTInAppFCManager This, CTInAppNotification inapp)
		{
			if (inapp == null)
				throw new ArgumentNullException ("inapp");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("canShow:"), inapp.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDismiss (this ICTInAppFCManager This, CTInAppNotification inapp)
		{
			if (inapp == null)
				throw new ArgumentNullException ("inapp");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didDismiss:"), inapp.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetSession (this ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetSession"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeUser (this ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("changeUser"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidShow (this ICTInAppFCManager This, CTInAppNotification inapp)
		{
			if (inapp == null)
				throw new ArgumentNullException ("inapp");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didShow:"), inapp.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateLimitsPerDay (this ICTInAppFCManager This, int perDay, int perSession)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_int (This.Handle, Selector.GetHandle ("updateLimitsPerDay:andPerSession:"), perDay, perSession);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AttachToHeader (this ICTInAppFCManager This, NSMutableDictionary header)
		{
			if (header == null)
				throw new ArgumentNullException ("header");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("attachToHeader:"), header.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProcessResponse (this ICTInAppFCManager This, NSDictionary response)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("processResponse:"), response.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasLifetimeCapacityMaxedOut (this ICTInAppFCManager This, CTInAppNotification dictionary)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary.Handle);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasDailyCapacityMaxedOut (this ICTInAppFCManager This, CTInAppNotification dictionary)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary.Handle);
		}
		
	}
	
	internal sealed class CTInAppFCManagerWrapper : BaseWrapper, ICTInAppFCManager {
		[Preserve (Conditional = true)]
		public CTInAppFCManagerWrapper (IntPtr handle, bool owns)
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
		static readonly IntPtr class_ptr = Class.GetHandle ("CTInAppFCManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
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
		protected internal CTInAppFCManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTInAppFCManager (CleverTapInstanceConfig config)
			: base (NSObjectFlag.Empty)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:"), config.Handle), "initWithConfig:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:"), config.Handle), "initWithConfig:");
			}
		}
		
		[Export ("attachToHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AttachToHeader (NSMutableDictionary header)
		{
			if (header == null)
				throw new ArgumentNullException ("header");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("attachToHeader:"), header.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("attachToHeader:"), header.Handle);
			}
		}
		
		[Export ("canShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanShow (CTInAppNotification inapp)
		{
			if (inapp == null)
				throw new ArgumentNullException ("inapp");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("canShow:"), inapp.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("canShow:"), inapp.Handle);
			}
		}
		
		[Export ("changeUser")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeUser ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("changeUser"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("changeUser"));
			}
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
			if (inapp == null)
				throw new ArgumentNullException ("inapp");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didDismiss:"), inapp.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didDismiss:"), inapp.Handle);
			}
		}
		
		[Export ("didShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShow (CTInAppNotification inapp)
		{
			if (inapp == null)
				throw new ArgumentNullException ("inapp");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didShow:"), inapp.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didShow:"), inapp.Handle);
			}
		}
		
		[Export ("hasDailyCapacityMaxedOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDailyCapacityMaxedOut (CTInAppNotification dictionary)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary.Handle);
			}
		}
		
		[Export ("hasLifetimeCapacityMaxedOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasLifetimeCapacityMaxedOut (CTInAppNotification dictionary)
		{
			if (dictionary == null)
				throw new ArgumentNullException ("dictionary");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary.Handle);
			}
		}
		
		[Export ("processResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessResponse (NSDictionary response)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("processResponse:"), response.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("processResponse:"), response.Handle);
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
