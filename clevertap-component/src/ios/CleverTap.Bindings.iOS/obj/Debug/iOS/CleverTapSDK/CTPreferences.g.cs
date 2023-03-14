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
	[Register("CTPreferences", true)]
	public unsafe partial class CTPreferences : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTPreferences");
		public override IntPtr ClassHandle { get { return class_ptr; } }
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

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTPreferences (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTPreferences (IntPtr handle) : base (handle)
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
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("archiveObject:forFileName:"), @object__handle__, nsfileName);
			CFString.ReleaseNative (nsfileName);
			return ret!;
		}
		[Export ("getIntForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetIntForKey (string key, nint resetValue)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			nint ret;
			ret = (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getIntForKey:withResetValue:"), nskey, (IntPtr) resetValue);
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
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getObjectForKey:"), nskey))!;
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
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getStringForKey:withResetValue:"), nskey, nsresetValue))!;
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("putInt:forKey:"), (IntPtr) resetValue, nskey);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("putObject:forKey:"), @object__handle__, nskey);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("putString:forKey:"), nsresetValue, nskey);
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
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("removeObjectForKey:"), nskey);
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
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("storageKeyWithSuffix:config:"), nssuffix, config__handle__))!;
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
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:ofType:removeFile:"), nsfilename, cls.Handle, remove))!;
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
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:ofTypes:removeFile:"), nsfilename, classes__handle__, remove))!;
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
	} /* class CTPreferences */
}
