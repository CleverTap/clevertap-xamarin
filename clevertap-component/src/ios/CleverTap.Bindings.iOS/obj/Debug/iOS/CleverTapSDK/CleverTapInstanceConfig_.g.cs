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
	public unsafe static partial class CleverTapInstanceConfig_  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTapInstanceConfig");
		[Export ("dataArchiveFileNameWithAccountId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string DataArchiveFileNameWithAccountId (this CleverTapInstanceConfig This, string accountId)
		{
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			var nsaccountId = CFString.CreateNative (accountId);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dataArchiveFileNameWithAccountId:"), nsaccountId))!;
			CFString.ReleaseNative (nsaccountId);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool Beta {
			[Export ("beta")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("beta"));
			}
			[Export ("setBeta:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setBeta:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCreatedPostAppLaunched {
			[Export ("isCreatedPostAppLaunched")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isCreatedPostAppLaunched"));
			}
			[Export ("setIsCreatedPostAppLaunched:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setIsCreatedPostAppLaunched:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDefaultInstance {
			[Export ("isDefaultInstance")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isDefaultInstance"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string QueueLabel {
			[Export ("queueLabel", ArgumentSemantic.Retain)]
			get {
				return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("queueLabel")))!;
			}
		}
	} /* class CleverTapInstanceConfig_ */
}
