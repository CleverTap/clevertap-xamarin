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
		[global::Foundation.OptionalMember]
		[Export ("cleanEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanEventName<T> (string name) where T: NSObject, ICTValidator
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsname = CFString.CreateNative (name);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanEventName:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("cleanObjectKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanObjectKey<T> (string name) where T: NSObject, ICTValidator
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsname = CFString.CreateNative (name);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanObjectKey:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("cleanMultiValuePropertyKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyKey<T> (string name) where T: NSObject, ICTValidator
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsname = CFString.CreateNative (name);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyKey:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("cleanMultiValuePropertyValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyValue<T> (string value) where T: NSObject, ICTValidator
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsvalue = CFString.CreateNative (value);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyValue:"), nsvalue))!;
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("cleanMultiValuePropertyArray:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyArray<T> (NSObject[] multi, string key) where T: NSObject, ICTValidator
		{
			if (multi is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multi));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsa_multi = NSArray.FromNSObjects (multi);
			var nskey = CFString.CreateNative (key);
			CTValidationResult? ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyArray:forKey:"), nsa_multi.Handle, nskey))!;
			nsa_multi.Dispose ();
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("cleanObjectValue:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanObjectValue<T> (NSObject o, CTValidatorContext context) where T: NSObject, ICTValidator
		{
			var o__handle__ = o!.GetNonNullHandle (nameof (o));
			var class_ptr = Class.GetHandle (typeof (T));
			return  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_int (class_ptr, Selector.GetHandle ("cleanObjectValue:context:"), o__handle__, (int)context))!;
		}
		[global::Foundation.OptionalMember]
		[Export ("isRestrictedEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRestrictedEventName<T> (string name) where T: NSObject, ICTValidator
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsname = CFString.CreateNative (name);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isRestrictedEventName:"), nsname);
			CFString.ReleaseNative (nsname);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("isDiscaredEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDiscaredEventName<T> (string name) where T: NSObject, ICTValidator
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsname = CFString.CreateNative (name);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isDiscaredEventName:"), nsname);
			CFString.ReleaseNative (nsname);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("setDiscardedEvents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDiscardedEvents<T> (NSObject[] events) where T: NSObject, ICTValidator
		{
			if (events is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (events));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsa_events = NSArray.FromNSObjects (events);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setDiscardedEvents:"), nsa_events.Handle);
			nsa_events.Dispose ();
		}
		[global::Foundation.OptionalMember]
		[Export ("isValidCleverTapId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCleverTapId<T> (string cleverTapID) where T: NSObject, ICTValidator
		{
			if (cleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cleverTapID));
			var class_ptr = Class.GetHandle (typeof (T));
			var nscleverTapID = CFString.CreateNative (cleverTapID);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("isValidCleverTapId:"), nscleverTapID);
			CFString.ReleaseNative (nscleverTapID);
			return ret != 0;
		}
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
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CTValidator" /> with default values.</summary>
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
		protected CTValidator (NSObjectFlag t) : base (t)
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
