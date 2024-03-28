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
	[Protocol (Name = "CTValidator", WrapperType = typeof (CTValidatorWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanEventName", Selector = "cleanEventName:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanObjectKey", Selector = "cleanObjectKey:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanMultiValuePropertyKey", Selector = "cleanMultiValuePropertyKey:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanMultiValuePropertyValue", Selector = "cleanMultiValuePropertyValue:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanMultiValuePropertyArray", Selector = "cleanMultiValuePropertyArray:forKey:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (NSObject[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanObjectValue", Selector = "cleanObjectValue:context:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (NSObject), typeof (CleverTapSDK.CTValidatorContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IsRestrictedEventName", Selector = "isRestrictedEventName:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IsDiscaredEventName", Selector = "isDiscaredEventName:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetDiscardedEvents", Selector = "setDiscardedEvents:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IsValidCleverTapId", Selector = "isValidCleverTapId:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface ICTValidator : INativeObject, IDisposable
	{
	}
	internal unsafe sealed class CTValidatorWrapper : BaseWrapper, ICTValidator {
		[Preserve (Conditional = true)]
		public CTValidatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTValidator", true)]
	public unsafe partial class CTValidator : NSObject, ICTValidator {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTValidator");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTValidator () : base (NSObjectFlag.Empty)
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
		protected CTValidator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTValidator (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cleanEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanEventName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanEventName:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cleanMultiValuePropertyArray:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyArray (NSObject[] multi, string key)
		{
			if (multi is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multi));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsa_multi = NSArray.FromNSObjects (multi);
			var nskey = CFString.CreateNative (key);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyArray:forKey:"), nsa_multi.Handle, nskey))!;
			nsa_multi.Dispose ();
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("cleanMultiValuePropertyKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyKey (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyKey:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cleanMultiValuePropertyValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyValue (string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyValue:"), nsvalue))!;
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
		[Export ("cleanObjectKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanObjectKey (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanObjectKey:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cleanObjectValue:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanObjectValue (NSObject o, CTValidatorContext context)
		{
			var o__handle__ = o!.GetNonNullHandle (nameof (o));
			return  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (class_ptr, Selector.GetHandle ("cleanObjectValue:context:"), o__handle__, (int)context))!;
		}
		[Export ("isDiscaredEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDiscaredEventName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isDiscaredEventName:"), nsname);
			CFString.ReleaseNative (nsname);
			return ret != 0;
		}
		[Export ("isRestrictedEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRestrictedEventName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isRestrictedEventName:"), nsname);
			CFString.ReleaseNative (nsname);
			return ret != 0;
		}
		[Export ("isValidCleverTapId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCleverTapId (string cleverTapID)
		{
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isValidCleverTapId:"), nscleverTapID);
			CFString.ReleaseNative (nscleverTapID);
			return ret != 0;
		}
		[Export ("setDiscardedEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDiscardedEvents (NSObject[] events)
		{
			if (events is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (events));
			var nsa_events = NSArray.FromNSObjects (events);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setDiscardedEvents:"), nsa_events.Handle);
			nsa_events.Dispose ();
		}
	} /* class CTValidator */
}
