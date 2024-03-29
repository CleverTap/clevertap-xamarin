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
namespace ApiDefinition {
	static partial class Messaging {
		internal const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";
		static internal System.Reflection.Assembly this_assembly = typeof (Messaging).Assembly;
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend (IntPtr receiever, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper (IntPtr receiever, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend_IntPtr (IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiever, IntPtr selector, IntPtr arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_bool_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, byte arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_bool_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, byte arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_bool_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, byte arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_bool_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, byte arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_int_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, int arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_int_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, int arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_bool (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, byte arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, nint arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, nint arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static int int_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static int int_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static sbyte SByte_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static sbyte SByte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static float float_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static float float_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4, NativeHandle arg5);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static UIntPtr UIntPtr_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static uint UInt32_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static uint UInt32_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static double Double_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static double Double_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static int int_objc_msgSend_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static int int_objc_msgSendSuper_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle_IntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, nint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle_IntPtr (IntPtr receiver, IntPtr selector, NativeHandle arg1, nint arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_IntPtr_NativeHandle (IntPtr receiver, IntPtr selector, nint arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_IntPtr_NativeHandle (IntPtr receiver, IntPtr selector, nint arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, byte arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nfloat nfloat_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nfloat nfloat_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_nfloat (IntPtr receiver, IntPtr selector, NativeHandle arg1, nfloat arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (IntPtr receiver, IntPtr selector, NativeHandle arg1, nfloat arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static double Double_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static double Double_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_int_NativeHandle (IntPtr receiver, IntPtr selector, int arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_int_NativeHandle (IntPtr receiver, IntPtr selector, int arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static double Double_objc_msgSend (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static double Double_objc_msgSendSuper (IntPtr receiver, IntPtr selector);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_CLLocationCoordinate2D_NativeHandle (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_CLLocationCoordinate2D_NativeHandle (IntPtr receiver, IntPtr selector, global::CoreLocation.CLLocationCoordinate2D arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_int_NativeHandle (IntPtr receiver, IntPtr selector, int arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_int_NativeHandle (IntPtr receiver, IntPtr selector, int arg1, NativeHandle arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_UIntPtr (IntPtr receiver, IntPtr selector, nuint arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_bool (IntPtr receiver, IntPtr selector, NativeHandle arg1, byte arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static void void_objc_msgSend_NativeHandle_int_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static void void_objc_msgSendSuper_NativeHandle_int_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2, int arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static nint IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static nint IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle arg3, NativeHandle arg4);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_int (IntPtr receiver, IntPtr selector, NativeHandle arg1, int arg2);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static byte bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle* arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static byte bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle* arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle* arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public unsafe extern static NativeHandle NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (IntPtr receiver, IntPtr selector, NativeHandle arg1, NativeHandle arg2, NativeHandle* arg3);
	}
}
