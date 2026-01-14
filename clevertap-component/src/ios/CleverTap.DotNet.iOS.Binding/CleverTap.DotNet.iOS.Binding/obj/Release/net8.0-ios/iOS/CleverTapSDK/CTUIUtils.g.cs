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
	[Protocol (Name = "CTUIUtils", WrapperType = typeof (CTUIUtilsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetImageForName", Selector = "getImageForName:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Ct_colorWithHexString", Selector = "ct_colorWithHexString:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Ct_colorWithHexString", Selector = "ct_colorWithHexString:withAlpha:", ReturnType = typeof (UIColor), ParameterType = new Type [] { typeof (string), typeof (NFloat) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Bundle", Selector = "bundle", PropertyType = typeof (NSBundle), GetterSelector = "bundle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "SharedApplication", Selector = "getSharedApplication", PropertyType = typeof (UIApplication), GetterSelector = "getSharedApplication", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "KeyWindow", Selector = "getKeyWindow", PropertyType = typeof (UIWindow), GetterSelector = "getKeyWindow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "IsDeviceOrientationLandscape", Selector = "isDeviceOrientationLandscape", PropertyType = typeof (bool), GetterSelector = "isDeviceOrientationLandscape", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "IsUserInterfaceIdiomPad", Selector = "isUserInterfaceIdiomPad", PropertyType = typeof (bool), GetterSelector = "isUserInterfaceIdiomPad", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "LeftMargin", Selector = "getLeftMargin", PropertyType = typeof (NFloat), GetterSelector = "getLeftMargin", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICTUIUtils : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("getImageForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage GetImageForName<T> (string name) where T: NSObject, ICTUIUtils
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsname = CFString.CreateNative (name);
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getImageForName:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("ct_colorWithHexString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString<T> (string @string) where T: NSObject, ICTUIUtils
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsstring = CFString.CreateNative (@string);
			global::UIKit.UIColor? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("ct_colorWithHexString:"), nsstring))!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("ct_colorWithHexString:withAlpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString<T> (string @string, nfloat alpha) where T: NSObject, ICTUIUtils
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsstring = CFString.CreateNative (@string);
			global::UIKit.UIColor? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("ct_colorWithHexString:withAlpha:"), nsstring, alpha))!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle GetBundle<T> () where T: NSObject, ICTUIUtils
		{
			var class_ptr = Class.GetHandle (typeof (T));
			return  Runtime.GetNSObject<NSBundle> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("bundle")))!;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIApplication GetSharedApplication<T> () where T: NSObject, ICTUIUtils
		{
			var class_ptr = Class.GetHandle (typeof (T));
			return  Runtime.GetNSObject<global::UIKit.UIApplication> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getSharedApplication")))!;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIWindow GetKeyWindow<T> () where T: NSObject, ICTUIUtils
		{
			var class_ptr = Class.GetHandle (typeof (T));
			return  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getKeyWindow")))!;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsDeviceOrientationLandscape<T> () where T: NSObject, ICTUIUtils
		{
			var class_ptr = Class.GetHandle (typeof (T));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isDeviceOrientationLandscape"));
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsUserInterfaceIdiomPad<T> () where T: NSObject, ICTUIUtils
		{
			var class_ptr = Class.GetHandle (typeof (T));
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isUserInterfaceIdiomPad"));
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetLeftMargin<T> () where T: NSObject, ICTUIUtils
		{
			var class_ptr = Class.GetHandle (typeof (T));
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("getLeftMargin"));
		}
	}
	internal unsafe sealed class CTUIUtilsWrapper : BaseWrapper, ICTUIUtils {
		[Preserve (Conditional = true)]
		public CTUIUtilsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTUIUtils", true)]
	public unsafe partial class CTUIUtils : NSObject, ICTUIUtils {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTUIUtils");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CTUIUtils" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTUIUtils () : base (NSObjectFlag.Empty)
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
		protected CTUIUtils (NSObjectFlag t) : base (t)
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
		protected internal CTUIUtils (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("ct_colorWithHexString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::UIKit.UIColor? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("ct_colorWithHexString:"), nsstring))!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[Export ("ct_colorWithHexString:withAlpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIColor Ct_colorWithHexString (string @string, nfloat alpha)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			global::UIKit.UIColor? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("ct_colorWithHexString:withAlpha:"), nsstring, alpha))!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		[Export ("getImageForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIImage GetImageForName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::UIKit.UIImage? ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getImageForName:"), nsname))!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle Bundle {
			[Export ("bundle")]
			get {
				NSBundle? ret;
				ret =  Runtime.GetNSObject<NSBundle> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("bundle")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDeviceOrientationLandscape {
			[Export ("isDeviceOrientationLandscape")]
			get {
				byte ret;
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isDeviceOrientationLandscape"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUserInterfaceIdiomPad {
			[Export ("isUserInterfaceIdiomPad")]
			get {
				byte ret;
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isUserInterfaceIdiomPad"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIWindow? KeyWindow {
			[Export ("getKeyWindow")]
			get {
				global::UIKit.UIWindow? ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIWindow> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getKeyWindow")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat LeftMargin {
			[Export ("getLeftMargin")]
			get {
				return global::ApiDefinition.Messaging.nfloat_objc_msgSend (class_ptr, Selector.GetHandle ("getLeftMargin"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIApplication? SharedApplication {
			[Export ("getSharedApplication")]
			get {
				global::UIKit.UIApplication? ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIApplication> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("getSharedApplication")))!;
				return ret!;
			}
		}
	} /* class CTUIUtils */
}
