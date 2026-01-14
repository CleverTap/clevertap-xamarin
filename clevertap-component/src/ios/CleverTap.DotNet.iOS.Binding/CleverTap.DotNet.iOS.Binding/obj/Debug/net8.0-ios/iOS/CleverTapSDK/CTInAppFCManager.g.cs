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
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> (CleverTapInstanceConfig config, string guid) where T: NSObject, ICTInAppFCManager
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nsguid = CFString.CreateNative (guid);
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (__handle__, Selector.GetHandle ("initWithConfig:guid:"), config__handle__, nsguid);
			ret =  global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			CFString.ReleaseNative (nsguid);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[Export ("checkUpdateDailyLimits")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CheckUpdateDailyLimits ()
		{
			_CheckUpdateDailyLimits (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CheckUpdateDailyLimits (ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("checkUpdateDailyLimits"));
		}
		[global::Foundation.OptionalMember]
		[Export ("canShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanShow (CTInAppNotification inapp)
		{
			return _CanShow (this, inapp);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CanShow (ICTInAppFCManager This, CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("canShow:"), inapp__handle__);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("didDismiss:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDismiss (CTInAppNotification inapp)
		{
			_DidDismiss (this, inapp);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDismiss (ICTInAppFCManager This, CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didDismiss:"), inapp__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("resetSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetSession ()
		{
			_ResetSession (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResetSession (ICTInAppFCManager This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetSession"));
		}
		[global::Foundation.OptionalMember]
		[Export ("changeUserWithGuid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeUserWithGuid (string guid)
		{
			_ChangeUserWithGuid (this, guid);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangeUserWithGuid (ICTInAppFCManager This, string guid)
		{
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nsguid = CFString.CreateNative (guid);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("changeUserWithGuid:"), nsguid);
			CFString.ReleaseNative (nsguid);
		}
		[global::Foundation.OptionalMember]
		[Export ("didShow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidShow (CTInAppNotification inapp)
		{
			_DidShow (this, inapp);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidShow (ICTInAppFCManager This, CTInAppNotification inapp)
		{
			var inapp__handle__ = inapp!.GetNonNullHandle (nameof (inapp));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didShow:"), inapp__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("updateLimitsPerDay:andPerSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateLimitsPerDay (int perDay, int perSession)
		{
			_UpdateLimitsPerDay (this, perDay, perSession);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateLimitsPerDay (ICTInAppFCManager This, int perDay, int perSession)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int_int (This.Handle, Selector.GetHandle ("updateLimitsPerDay:andPerSession:"), perDay, perSession);
		}
		[global::Foundation.OptionalMember]
		[Export ("attachToHeader:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AttachToHeader (NSMutableDictionary header)
		{
			_AttachToHeader (this, header);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AttachToHeader (ICTInAppFCManager This, NSMutableDictionary header)
		{
			var header__handle__ = header!.GetNonNullHandle (nameof (header));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("attachToHeader:"), header__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("processResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessResponse (NSDictionary response)
		{
			_ProcessResponse (this, response);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProcessResponse (ICTInAppFCManager This, NSDictionary response)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("processResponse:"), response__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("hasLifetimeCapacityMaxedOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasLifetimeCapacityMaxedOut (CTInAppNotification dictionary)
		{
			return _HasLifetimeCapacityMaxedOut (this, dictionary);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HasLifetimeCapacityMaxedOut (ICTInAppFCManager This, CTInAppNotification dictionary)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("hasLifetimeCapacityMaxedOut:"), dictionary__handle__);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("hasDailyCapacityMaxedOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDailyCapacityMaxedOut (CTInAppNotification dictionary)
		{
			return _HasDailyCapacityMaxedOut (this, dictionary);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HasDailyCapacityMaxedOut (ICTInAppFCManager This, CTInAppNotification dictionary)
		{
			var dictionary__handle__ = dictionary!.GetNonNullHandle (nameof (dictionary));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("hasDailyCapacityMaxedOut:"), dictionary__handle__);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AttachToHeader(Foundation.NSMutableDictionary)")]
		[DynamicDependencyAttribute ("CanShow(CleverTapSDK.CTInAppNotification)")]
		[DynamicDependencyAttribute ("ChangeUserWithGuid(System.String)")]
		[DynamicDependencyAttribute ("CheckUpdateDailyLimits()")]
		[DynamicDependencyAttribute ("DidDismiss(CleverTapSDK.CTInAppNotification)")]
		[DynamicDependencyAttribute ("DidShow(CleverTapSDK.CTInAppNotification)")]
		[DynamicDependencyAttribute ("HasDailyCapacityMaxedOut(CleverTapSDK.CTInAppNotification)")]
		[DynamicDependencyAttribute ("HasLifetimeCapacityMaxedOut(CleverTapSDK.CTInAppNotification)")]
		[DynamicDependencyAttribute ("ProcessResponse(Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("ResetSession()")]
		[DynamicDependencyAttribute ("UpdateLimitsPerDay(System.Int32,System.Int32)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICTInAppFCManager ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ICTInAppFCManager" /> interface to support all the methods from the CTInAppFCManager protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICTInAppFCManager" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CTInAppFCManager protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
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
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CTInAppFCManager" /> with default values.</summary>
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
		protected CTInAppFCManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
