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
	}
	internal sealed class CTEventBuilderWrapper : BaseWrapper, ICTEventBuilder {
		[Preserve (Conditional = true)]
		public CTEventBuilderWrapper (IntPtr handle, bool owns)
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
		static readonly IntPtr class_ptr = Class.GetHandle ("CTEventBuilder");
		public override IntPtr ClassHandle { get { return class_ptr; } }
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

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTEventBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTEventBuilder (IntPtr handle) : base (handle)
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
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("build:completionHandler:"), nseventName, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nseventName);
			block_ptr_completion->CleanupBlock ();
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
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("build:withEventActions:completionHandler:"), nseventName, eventActions__handle__, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nseventName);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildChargedEventWithDetails:andItems:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildChargedEventWithDetails (NSDictionary chargeDetails, NSObject[]? items, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var chargeDetails__handle__ = chargeDetails!.GetNonNullHandle (nameof (chargeDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nsa_items = items is null ? null : NSArray.FromNSObjects (items);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildChargedEventWithDetails:andItems:completionHandler:"), chargeDetails__handle__, nsa_items.GetHandle (), (IntPtr) block_ptr_completion);
			if (nsa_items != null)
				nsa_items.Dispose ();
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildDisplayViewStateEvent (bool clicked, CleverTapDisplayUnit displayUnit, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var displayUnit__handle__ = displayUnit!.GetNonNullHandle (nameof (displayUnit));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:"), clicked, displayUnit__handle__, @params__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildGeofenceStateEvent (bool entered, NSDictionary geofenceDetails, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var geofenceDetails__handle__ = geofenceDetails!.GetNonNullHandle (nameof (geofenceDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:"), entered, geofenceDetails__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildInAppNotificationStateEvent (bool clicked, CTInAppNotification notification, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:"), clicked, notification__handle__, @params__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildInboxMessageStateEvent (bool clicked, CleverTapInboxMessage message, NSDictionary? @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			var @params__handle__ = @params.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:"), clicked, message__handle__, @params__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildPushNotificationEvent:forNotification:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildPushNotificationEvent (bool clicked, NSDictionary notification, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildPushNotificationEvent:forNotification:completionHandler:"), clicked, notification__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("buildSignedCallEvent:forCallDetails:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildSignedCallEvent (int eventRawValue, NSDictionary callDetails, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSDictionary, NSArray<CTValidationResult>> completion)
		{
			var callDetails__handle__ = callDetails!.GetNonNullHandle (nameof (callDetails));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_int_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildSignedCallEvent:forCallDetails:completionHandler:"), eventRawValue, callDetails__handle__, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
	} /* class CTEventBuilder */
}
