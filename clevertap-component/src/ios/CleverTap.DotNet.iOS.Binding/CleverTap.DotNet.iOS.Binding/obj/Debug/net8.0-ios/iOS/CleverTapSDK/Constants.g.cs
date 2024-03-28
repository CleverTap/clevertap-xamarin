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
	public unsafe static partial class Constants  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleverTapGeofencesDidUpdateNotification;
		[Field ("CleverTapGeofencesDidUpdateNotification",  "__Internal")]
		public static NSString CleverTapGeofencesDidUpdateNotification {
			get {
				if (_CleverTapGeofencesDidUpdateNotification is null)
					_CleverTapGeofencesDidUpdateNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CleverTapGeofencesDidUpdateNotification")!;
				return _CleverTapGeofencesDidUpdateNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleverTapProfileDidChangeNotification;
		[Field ("CleverTapProfileDidChangeNotification",  "__Internal")]
		public static NSString CleverTapProfileDidChangeNotification {
			get {
				if (_CleverTapProfileDidChangeNotification is null)
					_CleverTapProfileDidChangeNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CleverTapProfileDidChangeNotification")!;
				return _CleverTapProfileDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CleverTapProfileDidInitializeNotification;
		[Field ("CleverTapProfileDidInitializeNotification",  "__Internal")]
		public static NSString CleverTapProfileDidInitializeNotification {
			get {
				if (_CleverTapProfileDidInitializeNotification is null)
					_CleverTapProfileDidInitializeNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "CleverTapProfileDidInitializeNotification")!;
				return _CleverTapProfileDidInitializeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _kCTApiDomain;
		[Field ("kCTApiDomain",  "__Internal")]
		public static NSString kCTApiDomain {
			get {
				if (_kCTApiDomain is null)
					_kCTApiDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "kCTApiDomain")!;
				return _kCTApiDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _kCTNotifViewedApiDomain;
		[Field ("kCTNotifViewedApiDomain",  "__Internal")]
		public static NSString kCTNotifViewedApiDomain {
			get {
				if (_kCTNotifViewedApiDomain is null)
					_kCTNotifViewedApiDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "kCTNotifViewedApiDomain")!;
				return _kCTNotifViewedApiDomain;
			}
		}
	} /* class Constants */
}
