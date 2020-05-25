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
	public unsafe static partial class CleverTap_ABTesting  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CleverTap");
		
		[Export ("getArrayOfBoolVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] GetArrayOfBoolVariableWithName (this CleverTap This, string name, NSNumber[] defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			var nsa_defaultValue = NSArray.FromNSObjects (defaultValue);
			
			NSNumber[] ret;
			ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getArrayOfBoolVariableWithName:defaultValue:"), nsname, nsa_defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			nsa_defaultValue.Dispose ();
			
			return ret;
		}
		
		[Export ("getArrayOfDoubleVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] GetArrayOfDoubleVariableWithName (this CleverTap This, string name, NSNumber[] defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			var nsa_defaultValue = NSArray.FromNSObjects (defaultValue);
			
			NSNumber[] ret;
			ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getArrayOfDoubleVariableWithName:defaultValue:"), nsname, nsa_defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			nsa_defaultValue.Dispose ();
			
			return ret;
		}
		
		[Export ("getArrayOfIntegerVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] GetArrayOfIntegerVariableWithName (this CleverTap This, string name, NSNumber[] defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			var nsa_defaultValue = NSArray.FromNSObjects (defaultValue);
			
			NSNumber[] ret;
			ret = NSArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getArrayOfIntegerVariableWithName:defaultValue:"), nsname, nsa_defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			nsa_defaultValue.Dispose ();
			
			return ret;
		}
		
		[Export ("getArrayOfStringVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetArrayOfStringVariableWithName (this CleverTap This, string name, string[] defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			var nsa_defaultValue = NSArray.FromStrings (defaultValue);
			
			string[] ret;
			ret = NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getArrayOfStringVariableWithName:defaultValue:"), nsname, nsa_defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			nsa_defaultValue.Dispose ();
			
			return ret;
		}
		
		[Export ("getBoolVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetBoolVariableWithName (this CleverTap This, string name, bool defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("getBoolVariableWithName:defaultValue:"), nsname, defaultValue);
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getDictionaryOfBoolVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSNumber> GetDictionaryOfBoolVariableWithName (this CleverTap This, string name, NSDictionary<NSString, NSNumber> defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			
			NSDictionary<NSString, NSNumber> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSNumber>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getDictionaryOfBoolVariableWithName:defaultValue:"), nsname, defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getDictionaryOfDoubleVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSNumber> GetDictionaryOfDoubleVariableWithName (this CleverTap This, string name, NSDictionary<NSString, NSNumber> defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			
			NSDictionary<NSString, NSNumber> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSNumber>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getDictionaryOfDoubleVariableWithName:defaultValue:"), nsname, defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getDictionaryOfIntegerVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSNumber> GetDictionaryOfIntegerVariableWithName (this CleverTap This, string name, NSDictionary<NSString, NSNumber> defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			
			NSDictionary<NSString, NSNumber> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSNumber>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getDictionaryOfIntegerVariableWithName:defaultValue:"), nsname, defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getDictionaryOfStringVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSString> GetDictionaryOfStringVariableWithName (this CleverTap This, string name, NSDictionary<NSString, NSString> defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			
			NSDictionary<NSString, NSString> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSString>> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getDictionaryOfStringVariableWithName:defaultValue:"), nsname, defaultValue.Handle));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getDoubleVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetDoubleVariableWithName (this CleverTap This, string name, double defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr_Double (This.Handle, Selector.GetHandle ("getDoubleVariableWithName:defaultValue:"), nsname, defaultValue);
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getIntegerVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetIntegerVariableWithName (this CleverTap This, string name, int defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("getIntegerVariableWithName:defaultValue:"), nsname, defaultValue);
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("getStringVariableWithName:defaultValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetStringVariableWithName (this CleverTap This, string name, string defaultValue)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (defaultValue == null)
				throw new ArgumentNullException ("defaultValue");
			var nsname = NSString.CreateNative (name);
			var nsdefaultValue = NSString.CreateNative (defaultValue);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getStringVariableWithName:defaultValue:"), nsname, nsdefaultValue));
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsdefaultValue);
			
			return ret;
		}
		
		[Export ("registerArrayOfBoolVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterArrayOfBoolVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerArrayOfBoolVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerArrayOfDoubleVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterArrayOfDoubleVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerArrayOfDoubleVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerArrayOfIntegerVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterArrayOfIntegerVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerArrayOfIntegerVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerArrayOfStringVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterArrayOfStringVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerArrayOfStringVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerBoolVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterBoolVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerBoolVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerDictionaryOfBoolVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterDictionaryOfBoolVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerDictionaryOfBoolVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerDictionaryOfDoubleVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterDictionaryOfDoubleVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerDictionaryOfDoubleVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerDictionaryOfIntegerVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterDictionaryOfIntegerVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerDictionaryOfIntegerVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerDictionaryOfStringVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterDictionaryOfStringVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerDictionaryOfStringVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerDoubleVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterDoubleVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerDoubleVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerExperimentsUpdatedBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void RegisterExperimentsUpdatedBlock (this CleverTap This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCleverTapExperimentsUpdatedBlock))]CleverTapExperimentsUpdatedBlock block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlockUnsafe (Trampolines.SDCleverTapExperimentsUpdatedBlock.Handler, block);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerExperimentsUpdatedBlock:"), (IntPtr) block_ptr_block);
			block_ptr_block->CleanupBlock ();
			
		}
		
		[Export ("registerIntegerVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterIntegerVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerIntegerVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("registerStringVariableWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterStringVariableWithName (this CleverTap This, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerStringVariableWithName:"), nsname);
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("setUIEditorConnectionEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUIEditorConnectionEnabled (this CleverTap This, bool enabled)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setUIEditorConnectionEnabled:"), enabled);
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUIEditorConnectionEnabled {
			[Export ("isUIEditorConnectionEnabled")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("isUIEditorConnectionEnabled"));
			}
			
		}
		
	} /* class CleverTap_ABTesting */
}
