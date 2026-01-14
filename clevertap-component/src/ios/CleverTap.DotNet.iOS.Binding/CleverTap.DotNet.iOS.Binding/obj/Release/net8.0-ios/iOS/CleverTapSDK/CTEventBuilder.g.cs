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
	[Protocol (Name = "CTEventBuilder", WrapperType = typeof (CTEventBuilderWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Build", Selector = "build:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Build", Selector = "build:withEventActions:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildChargedEventWithDetails", Selector = "buildChargedEventWithDetails:andItems:completionHandler:", ParameterType = new Type [] { typeof (NSDictionary), typeof (NSObject[]), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildPushNotificationEvent", Selector = "buildPushNotificationEvent:forNotification:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildInAppNotificationStateEvent", Selector = "buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (CleverTapSDK.CTInAppNotification), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildInboxMessageStateEvent", Selector = "buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (CleverTapSDK.CleverTapInboxMessage), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildDisplayViewStateEvent", Selector = "buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (CleverTapSDK.CleverTapDisplayUnit), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildGeofenceStateEvent", Selector = "buildGeofenceStateEvent:forGeofenceDetails:completionHandler:", ParameterType = new Type [] { typeof (bool), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildSignedCallEvent", Selector = "buildSignedCallEvent:forCallDetails:completionHandler:", ParameterType = new Type [] { typeof (int), typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V0) })]
	public partial interface ICTEventBuilder : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("build:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Build<T> (string eventName, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			if (eventName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventName));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			var nseventName = CFString.CreateNative (eventName);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("build:completionHandler:"), nseventName, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nseventName);
		}
		[global::Foundation.OptionalMember]
		[Export ("build:withEventActions:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Build<T> (string eventName, NSDictionary? eventActions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			if (eventName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventName));
			var eventActions__handle__ = eventActions.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			var nseventName = CFString.CreateNative (eventName);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("build:withEventActions:completionHandler:"), nseventName, eventActions__handle__, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nseventName);
		}
		[global::Foundation.OptionalMember]
		[Export ("buildChargedEventWithDetails:andItems:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildChargedEventWithDetails<T> (NSDictionary chargeDetails, NSObject[]? items, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var chargeDetails__handle__ = chargeDetails!.GetNonNullHandle (nameof (chargeDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsa_items = items is null ? null : NSArray.FromNSObjects (items);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildChargedEventWithDetails:andItems:completionHandler:"), chargeDetails__handle__, nsa_items.GetHandle (), (IntPtr) block_ptr_completion);
			if (nsa_items is not null)
				nsa_items.Dispose ();
		}
		[global::Foundation.OptionalMember]
		[Export ("buildPushNotificationEvent:forNotification:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildPushNotificationEvent<T> (bool clicked, NSDictionary notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildPushNotificationEvent:forNotification:completionHandler:"), clicked ? (byte) 1 : (byte) 0, notification__handle__, (IntPtr) block_ptr_completion);
		}
		[global::Foundation.OptionalMember]
		[Export ("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildInAppNotificationStateEvent<T> (bool clicked, CTInAppNotification notification, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:"), clicked ? (byte) 1 : (byte) 0, notification__handle__, @params__handle__, (IntPtr) block_ptr_completion);
		}
		[global::Foundation.OptionalMember]
		[Export ("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildInboxMessageStateEvent<T> (bool clicked, CleverTapInboxMessage message, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:"), clicked ? (byte) 1 : (byte) 0, message__handle__, @params__handle__, (IntPtr) block_ptr_completion);
		}
		[global::Foundation.OptionalMember]
		[Export ("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildDisplayViewStateEvent<T> (bool clicked, CleverTapDisplayUnit displayUnit, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var displayUnit__handle__ = displayUnit!.GetNonNullHandle (nameof (displayUnit));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:"), clicked ? (byte) 1 : (byte) 0, displayUnit__handle__, @params__handle__, (IntPtr) block_ptr_completion);
		}
		[global::Foundation.OptionalMember]
		[Export ("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildGeofenceStateEvent<T> (bool entered, NSDictionary geofenceDetails, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:"), entered ? (byte) 1 : (byte) 0, geofenceDetails__handle__, (IntPtr) block_ptr_completion);
		}
		[global::Foundation.OptionalMember]
		[Export ("buildSignedCallEvent:forCallDetails:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildSignedCallEvent<T> (int eventRawValue, NSDictionary callDetails, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion) where T: NSObject, ICTEventBuilder
		{
			var callDetails__handle__ = callDetails!.GetNonNullHandle (nameof (callDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var class_ptr = Class.GetHandle (typeof (T));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_int_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildSignedCallEvent:forCallDetails:completionHandler:"), eventRawValue, callDetails__handle__, (IntPtr) block_ptr_completion);
		}
	}
	internal unsafe sealed class CTEventBuilderWrapper : BaseWrapper, ICTEventBuilder {
		[Preserve (Conditional = true)]
		public CTEventBuilderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTEventBuilder", true)]
	public unsafe partial class CTEventBuilder : NSObject, ICTEventBuilder {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTEventBuilder");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CTEventBuilder" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTEventBuilder () : base (NSObjectFlag.Empty)
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
		protected CTEventBuilder (NSObjectFlag t) : base (t)
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
		protected internal CTEventBuilder (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("build:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Build (string eventName, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			if (eventName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventName));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nseventName = CFString.CreateNative (eventName);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("build:completionHandler:"), nseventName, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nseventName);
		}
		[Export ("build:withEventActions:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Build (string eventName, NSDictionary? eventActions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			if (eventName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventName));
			var eventActions__handle__ = eventActions.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nseventName = CFString.CreateNative (eventName);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("build:withEventActions:completionHandler:"), nseventName, eventActions__handle__, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nseventName);
		}
		[Export ("buildChargedEventWithDetails:andItems:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildChargedEventWithDetails (NSDictionary chargeDetails, NSObject[]? items, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var chargeDetails__handle__ = chargeDetails!.GetNonNullHandle (nameof (chargeDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nsa_items = items is null ? null : NSArray.FromNSObjects (items);
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildChargedEventWithDetails:andItems:completionHandler:"), chargeDetails__handle__, nsa_items.GetHandle (), (IntPtr) block_ptr_completion);
			if (nsa_items is not null)
				nsa_items.Dispose ();
		}
		[Export ("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildDisplayViewStateEvent (bool clicked, CleverTapDisplayUnit displayUnit, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var displayUnit__handle__ = displayUnit!.GetNonNullHandle (nameof (displayUnit));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:"), clicked ? (byte) 1 : (byte) 0, displayUnit__handle__, @params__handle__, (IntPtr) block_ptr_completion);
		}
		[Export ("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildGeofenceStateEvent (bool entered, NSDictionary geofenceDetails, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:"), entered ? (byte) 1 : (byte) 0, geofenceDetails__handle__, (IntPtr) block_ptr_completion);
		}
		[Export ("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildInAppNotificationStateEvent (bool clicked, CTInAppNotification notification, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:"), clicked ? (byte) 1 : (byte) 0, notification__handle__, @params__handle__, (IntPtr) block_ptr_completion);
		}
		[Export ("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildInboxMessageStateEvent (bool clicked, CleverTapInboxMessage message, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:"), clicked ? (byte) 1 : (byte) 0, message__handle__, @params__handle__, (IntPtr) block_ptr_completion);
		}
		[Export ("buildPushNotificationEvent:forNotification:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildPushNotificationEvent (bool clicked, NSDictionary notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildPushNotificationEvent:forNotification:completionHandler:"), clicked ? (byte) 1 : (byte) 0, notification__handle__, (IntPtr) block_ptr_completion);
		}
		[Export ("buildSignedCallEvent:forCallDetails:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildSignedCallEvent (int eventRawValue, NSDictionary callDetails, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var callDetails__handle__ = callDetails!.GetNonNullHandle (nameof (callDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V0.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinition.Messaging.void_objc_msgSend_int_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("buildSignedCallEvent:forCallDetails:completionHandler:"), eventRawValue, callDetails__handle__, (IntPtr) block_ptr_completion);
		}
	} /* class CTEventBuilder */
}
