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
			if (@object == null)
				throw new ArgumentNullException ("@object");
			if (fileName == null)
				throw new ArgumentNullException ("fileName");
			var nsfileName = NSString.CreateNative (fileName);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("archiveObject:forFileName:"), @object.Handle, nsfileName);
			NSString.ReleaseNative (nsfileName);
			
			return ret;
		}
		
		[Export ("getIntForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetIntForKey (string key, nint resetValue)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			nint ret;
			ret = global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr_nint (class_ptr, Selector.GetHandle ("getIntForKey:withResetValue:"), nskey, resetValue);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("getObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetObjectForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getObjectForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("getStringForKey:withResetValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetStringForKey (string key, string resetValue)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (resetValue == null)
				throw new ArgumentNullException ("resetValue");
			var nskey = NSString.CreateNative (key);
			var nsresetValue = NSString.CreateNative (resetValue);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getStringForKey:withResetValue:"), nskey, nsresetValue));
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsresetValue);
			
			return ret;
		}
		
		[Export ("putInt:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutInt (nint resetValue, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_nint_IntPtr (class_ptr, Selector.GetHandle ("putInt:forKey:"), resetValue, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("putObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutObject (NSObject @object, string key)
		{
			if (@object == null)
				throw new ArgumentNullException ("@object");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("putObject:forKey:"), @object.Handle, nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("putString:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PutString (string resetValue, string key)
		{
			if (resetValue == null)
				throw new ArgumentNullException ("resetValue");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsresetValue = NSString.CreateNative (resetValue);
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("putString:forKey:"), nsresetValue, nskey);
			NSString.ReleaseNative (nsresetValue);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("removeObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveObjectForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("removeObjectForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("unarchiveFromFile:removeFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject UnarchiveFromFile (string filePath, bool remove)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			
			NSObject ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("unarchiveFromFile:removeFile:"), nsfilePath, remove));
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
	} /* class CTPreferences */
}
