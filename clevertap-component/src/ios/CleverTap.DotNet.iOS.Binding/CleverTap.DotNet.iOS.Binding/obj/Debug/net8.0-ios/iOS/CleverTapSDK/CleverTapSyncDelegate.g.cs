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
	[Protocol (Name = "CleverTapSyncDelegate", WrapperType = typeof (CleverTapSyncDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDidInitialize", Selector = "profileDidInitialize:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDidInitialize", Selector = "profileDidInitialize:forAccountId:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDataUpdated", Selector = "profileDataUpdated:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	public partial interface ICleverTapSyncDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("profileDidInitialize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDidInitialize (string CleverTapID)
		{
			_ProfileDidInitialize (this, CleverTapID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProfileDidInitialize (ICleverTapSyncDelegate This, string CleverTapID)
		{
			if (CleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (CleverTapID));
			var nsCleverTapID = CFString.CreateNative (CleverTapID);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profileDidInitialize:"), nsCleverTapID);
			CFString.ReleaseNative (nsCleverTapID);
		}
		[global::Foundation.OptionalMember]
		[Export ("profileDidInitialize:forAccountId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDidInitialize (string CleverTapID, string accountId)
		{
			_ProfileDidInitialize (this, CleverTapID, accountId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProfileDidInitialize (ICleverTapSyncDelegate This, string CleverTapID, string accountId)
		{
			if (CleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (CleverTapID));
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			var nsCleverTapID = CFString.CreateNative (CleverTapID);
			var nsaccountId = CFString.CreateNative (accountId);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileDidInitialize:forAccountId:"), nsCleverTapID, nsaccountId);
			CFString.ReleaseNative (nsCleverTapID);
			CFString.ReleaseNative (nsaccountId);
		}
		[global::Foundation.OptionalMember]
		[Export ("profileDataUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDataUpdated (NSDictionary updates)
		{
			_ProfileDataUpdated (this, updates);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProfileDataUpdated (ICleverTapSyncDelegate This, NSDictionary updates)
		{
			var updates__handle__ = updates!.GetNonNullHandle (nameof (updates));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profileDataUpdated:"), updates__handle__);
		}
		[DynamicDependencyAttribute ("ProfileDataUpdated(Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("ProfileDidInitialize(System.String,System.String)")]
		[DynamicDependencyAttribute ("ProfileDidInitialize(System.String)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICleverTapSyncDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	/// <summary>Extension methods to the <see cref="ICleverTapSyncDelegate" /> interface to support all the methods from the CleverTapSyncDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICleverTapSyncDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CleverTapSyncDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CleverTapSyncDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDidInitialize (this ICleverTapSyncDelegate This, string CleverTapID)
		{
			if (CleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (CleverTapID));
			var nsCleverTapID = CFString.CreateNative (CleverTapID);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profileDidInitialize:"), nsCleverTapID);
			CFString.ReleaseNative (nsCleverTapID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDidInitialize (this ICleverTapSyncDelegate This, string CleverTapID, string accountId)
		{
			if (CleverTapID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (CleverTapID));
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			var nsCleverTapID = CFString.CreateNative (CleverTapID);
			var nsaccountId = CFString.CreateNative (accountId);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("profileDidInitialize:forAccountId:"), nsCleverTapID, nsaccountId);
			CFString.ReleaseNative (nsCleverTapID);
			CFString.ReleaseNative (nsaccountId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDataUpdated (this ICleverTapSyncDelegate This, NSDictionary updates)
		{
			var updates__handle__ = updates!.GetNonNullHandle (nameof (updates));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("profileDataUpdated:"), updates__handle__);
		}
	}
	internal unsafe sealed class CleverTapSyncDelegateWrapper : BaseWrapper, ICleverTapSyncDelegate {
		[Preserve (Conditional = true)]
		public CleverTapSyncDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapSyncDelegate", false)]
	[Model]
	public unsafe partial class CleverTapSyncDelegate : NSObject, ICleverTapSyncDelegate {
		/// <summary>Creates a new <see cref="CleverTapSyncDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapSyncDelegate () : base (NSObjectFlag.Empty)
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
		protected CleverTapSyncDelegate (NSObjectFlag t) : base (t)
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
		protected internal CleverTapSyncDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("profileDataUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDataUpdated (NSDictionary updates)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("profileDidInitialize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDidInitialize (string CleverTapID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("profileDidInitialize:forAccountId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDidInitialize (string CleverTapID, string accountId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CleverTapSyncDelegate */
}
