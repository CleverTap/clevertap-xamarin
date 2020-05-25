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
	[Register("CTUtils", true)]
	public unsafe partial class CTUtils : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTUtils");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTUtils () : base (NSObjectFlag.Empty)
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
		protected CTUtils (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTUtils (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("deviceTokenStringFromData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string DeviceTokenStringFromData (NSData tokenData)
		{
			if (tokenData == null)
				throw new ArgumentNullException ("tokenData");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("deviceTokenStringFromData:"), tokenData.Handle));
		}
		
		[Export ("dictionaryToJsonString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string DictionaryToJsonString (NSDictionary dict)
		{
			if (dict == null)
				throw new ArgumentNullException ("dict");
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dictionaryToJsonString:"), dict.Handle));
		}
		
		[Export ("doesString:startWith:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DoesString (string s, string prefix)
		{
			if (s == null)
				throw new ArgumentNullException ("s");
			if (prefix == null)
				throw new ArgumentNullException ("prefix");
			var nss = NSString.CreateNative (s);
			var nsprefix = NSString.CreateNative (prefix);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("doesString:startWith:"), nss, nsprefix);
			NSString.ReleaseNative (nss);
			NSString.ReleaseNative (nsprefix);
			
			return ret;
		}
		
		[Export ("toTwoPlaces:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double ToTwoPlaces (double x)
		{
			return global::ApiDefinition.Messaging.Double_objc_msgSend_Double (class_ptr, Selector.GetHandle ("toTwoPlaces:"), x);
		}
		
		[Export ("urlEncodeString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UrlEncodeString (string s)
		{
			if (s == null)
				throw new ArgumentNullException ("s");
			var nss = NSString.CreateNative (s);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("urlEncodeString:"), nss));
			NSString.ReleaseNative (nss);
			
			return ret;
		}
		
	} /* class CTUtils */
}
