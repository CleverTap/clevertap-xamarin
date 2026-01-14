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
	[Protocol (Name = "CTPreferences", WrapperType = typeof (CTPreferencesWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetIntForKey", Selector = "getIntForKey:withResetValue:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (string), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PutInt", Selector = "putInt:forKey:", ParameterType = new Type [] { typeof (IntPtr), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetStringForKey", Selector = "getStringForKey:withResetValue:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PutString", Selector = "putString:forKey:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetObjectForKey", Selector = "getObjectForKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "PutObject", Selector = "putObject:forKey:", ParameterType = new Type [] { typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "RemoveObjectForKey", Selector = "removeObjectForKey:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "UnarchiveFromFile", Selector = "unarchiveFromFile:ofType:removeFile:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string), typeof (Class), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "UnarchiveFromFile", Selector = "unarchiveFromFile:ofTypes:removeFile:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string), typeof (global::Foundation.NSSet<Class>), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "ArchiveObject", Selector = "archiveObject:forFileName:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "StorageKeyWithSuffix", Selector = "storageKeyWithSuffix:config:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string), typeof (CleverTapSDK.CleverTapInstanceConfig) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICTPreferences : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("getIntForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetIntForKey<T> (string key, nint resetValue) where T: NSObject, ICTPreferences
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nskey = CFString.CreateNative (key);
			nint ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("getIntForKey:withResetValue:"), nskey, resetValue);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("putInt:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutInt<T> (nint resetValue, string key) where T: NSObject, ICTPreferences
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("putInt:forKey:"), resetValue, nskey);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.OptionalMember]
		[Export ("getStringForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetStringForKey<T> (string key, string? resetValue) where T: NSObject, ICTPreferences
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nskey = CFString.CreateNative (key);
			var nsresetValue = CFString.CreateNative (resetValue);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("getStringForKey:withResetValue:"), nskey, nsresetValue))!;
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsresetValue);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("putString:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutString<T> (string resetValue, string key) where T: NSObject, ICTPreferences
		{
			if (resetValue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resetValue));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsresetValue = CFString.CreateNative (resetValue);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("putString:forKey:"), nsresetValue, nskey);
			CFString.ReleaseNative (nsresetValue);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.OptionalMember]
		[Export ("getObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetObjectForKey<T> (string key) where T: NSObject, ICTPreferences
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getObjectForKey:"), nskey))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("putObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutObject<T> (NSObject @object, string key) where T: NSObject, ICTPreferences
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("putObject:forKey:"), @object__handle__, nskey);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.OptionalMember]
		[Export ("removeObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveObjectForKey<T> (string key) where T: NSObject, ICTPreferences
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var class_ptr = Class.GetHandle (typeof (T));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeObjectForKey:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.OptionalMember]
		[Export ("unarchiveFromFile:ofType:removeFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject UnarchiveFromFile<T> (string filename, Class cls, bool remove) where T: NSObject, ICTPreferences
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var cls__handle__ = cls!.GetNonNullHandle (nameof (cls));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsfilename = CFString.CreateNative (filename);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:ofType:removeFile:"), nsfilename, cls.Handle, remove ? (byte) 1 : (byte) 0))!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("unarchiveFromFile:ofTypes:removeFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject UnarchiveFromFile<T> (string filename, NSSet<Class> classes, bool remove) where T: NSObject, ICTPreferences
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var classes__handle__ = classes!.GetNonNullHandle (nameof (classes));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsfilename = CFString.CreateNative (filename);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:ofTypes:removeFile:"), nsfilename, classes__handle__, remove ? (byte) 1 : (byte) 0))!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("archiveObject:forFileName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ArchiveObject<T> (NSObject @object, string fileName) where T: NSObject, ICTPreferences
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var class_ptr = Class.GetHandle (typeof (T));
			var nsfileName = CFString.CreateNative (fileName);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("archiveObject:forFileName:"), @object__handle__, nsfileName);
			CFString.ReleaseNative (nsfileName);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("storageKeyWithSuffix:config:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StorageKeyWithSuffix<T> (string suffix, CleverTapInstanceConfig config) where T: NSObject, ICTPreferences
		{
			if (suffix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suffix));
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var class_ptr = Class.GetHandle (typeof (T));
			var nssuffix = CFString.CreateNative (suffix);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("storageKeyWithSuffix:config:"), nssuffix, config__handle__))!;
			CFString.ReleaseNative (nssuffix);
			return ret!;
		}
	}
	internal unsafe sealed class CTPreferencesWrapper : BaseWrapper, ICTPreferences {
		[Preserve (Conditional = true)]
		public CTPreferencesWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTPreferences", true)]
	public unsafe partial class CTPreferences : NSObject, ICTPreferences {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTPreferences");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CTPreferences" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTPreferences () : base (NSObjectFlag.Empty)
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
		protected CTPreferences (NSObjectFlag t) : base (t)
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
		protected internal CTPreferences (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("archiveObject:forFileName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ArchiveObject (NSObject @object, string fileName)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var nsfileName = CFString.CreateNative (fileName);
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("archiveObject:forFileName:"), @object__handle__, nsfileName);
			CFString.ReleaseNative (nsfileName);
			return ret != 0;
		}
		[Export ("getIntForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetIntForKey (string key, nint resetValue)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			nint ret;
			ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("getIntForKey:withResetValue:"), nskey, resetValue);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("getObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetObjectForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("getObjectForKey:"), nskey))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("getStringForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetStringForKey (string key, string? resetValue)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			var nsresetValue = CFString.CreateNative (resetValue);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("getStringForKey:withResetValue:"), nskey, nsresetValue))!;
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsresetValue);
			return ret!;
		}
		[Export ("putInt:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutInt (nint resetValue, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("putInt:forKey:"), resetValue, nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("putObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutObject (NSObject @object, string key)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("putObject:forKey:"), @object__handle__, nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("putString:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutString (string resetValue, string key)
		{
			if (resetValue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resetValue));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nsresetValue = CFString.CreateNative (resetValue);
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("putString:forKey:"), nsresetValue, nskey);
			CFString.ReleaseNative (nsresetValue);
			CFString.ReleaseNative (nskey);
		}
		[Export ("removeObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveObjectForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removeObjectForKey:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[Export ("storageKeyWithSuffix:config:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string StorageKeyWithSuffix (string suffix, CleverTapInstanceConfig config)
		{
			if (suffix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suffix));
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var nssuffix = CFString.CreateNative (suffix);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("storageKeyWithSuffix:config:"), nssuffix, config__handle__))!;
			CFString.ReleaseNative (nssuffix);
			return ret!;
		}
		[Export ("unarchiveFromFile:ofType:removeFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject UnarchiveFromFile (string filename, Class cls, bool remove)
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var cls__handle__ = cls!.GetNonNullHandle (nameof (cls));
			var nsfilename = CFString.CreateNative (filename);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:ofType:removeFile:"), nsfilename, cls.Handle, remove ? (byte) 1 : (byte) 0))!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		[Export ("unarchiveFromFile:ofTypes:removeFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject UnarchiveFromFile (string filename, NSSet<Class> classes, bool remove)
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var classes__handle__ = classes!.GetNonNullHandle (nameof (classes));
			var nsfilename = CFString.CreateNative (filename);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:ofTypes:removeFile:"), nsfilename, classes__handle__, remove ? (byte) 1 : (byte) 0))!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
	} /* class CTPreferences */
}
