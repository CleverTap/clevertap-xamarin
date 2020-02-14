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
	[Protocol (Name = "CTProfileBuilder", WrapperType = typeof (CTProfileBuilderWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Build", Selector = "build:completionHandler:", ParameterType = new Type [] { typeof (NSDictionary), typeof (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildGraphUser", Selector = "buildGraphUser:completionHandler:", ParameterType = new Type [] { typeof (NSObject), typeof (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildGooglePlusUser", Selector = "buildGooglePlusUser:completionHandler:", ParameterType = new Type [] { typeof (NSObject), typeof (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildRemoveValueForKey", Selector = "buildRemoveValueForKey:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (global::System.Action<NSDictionary, NSDictionary, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildSetMultiValues", Selector = "buildSetMultiValues:forKey:localDataStore:completionHandler:", ParameterType = new Type [] { typeof (String[]), typeof (string), typeof (CleverTapSDK.CTLocalDataStore), typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildAddMultiValue", Selector = "buildAddMultiValue:forKey:localDataStore:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (CleverTapSDK.CTLocalDataStore), typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildAddMultiValues", Selector = "buildAddMultiValues:forKey:localDataStore:completionHandler:", ParameterType = new Type [] { typeof (String[]), typeof (string), typeof (CleverTapSDK.CTLocalDataStore), typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildRemoveMultiValue", Selector = "buildRemoveMultiValue:forKey:localDataStore:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (CleverTapSDK.CTLocalDataStore), typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "BuildRemoveMultiValues", Selector = "buildRemoveMultiValues:forKey:localDataStore:completionHandler:", ParameterType = new Type [] { typeof (String[]), typeof (string), typeof (CleverTapSDK.CTLocalDataStore), typeof (global::System.Action<NSDictionary, NSArray, NSArray<global::CleverTapSDK.CTValidationResult>>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V1) })]
	public interface ICTProfileBuilder : INativeObject, IDisposable
	{
	}
	
	internal sealed class CTProfileBuilderWrapper : BaseWrapper, ICTProfileBuilder {
		[Preserve (Conditional = true)]
		public CTProfileBuilderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTProfileBuilder", true)]
	public unsafe partial class CTProfileBuilder : NSObject, ICTProfileBuilder {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTProfileBuilder");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTProfileBuilder () : base (NSObjectFlag.Empty)
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
		protected CTProfileBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTProfileBuilder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("build:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Build (NSDictionary profile, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion)
		{
			if (profile == null)
				throw new ArgumentNullException ("profile");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("build:completionHandler:"), profile.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildAddMultiValue:forKey:localDataStore:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildAddMultiValue (string value, string key, CTLocalDataStore dataStore, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (dataStore == null)
				throw new ArgumentNullException ("dataStore");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V1.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildAddMultiValue:forKey:localDataStore:completionHandler:"), nsvalue, nskey, dataStore.Handle, (IntPtr) block_ptr_completion);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildAddMultiValues:forKey:localDataStore:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildAddMultiValues (string[] values, string key, CTLocalDataStore dataStore, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (dataStore == null)
				throw new ArgumentNullException ("dataStore");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V1.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildAddMultiValues:forKey:localDataStore:completionHandler:"), nsa_values.Handle, nskey, dataStore.Handle, (IntPtr) block_ptr_completion);
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildGooglePlusUser:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildGooglePlusUser (NSObject googleUser, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion)
		{
			if (googleUser == null)
				throw new ArgumentNullException ("googleUser");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildGooglePlusUser:completionHandler:"), googleUser.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildGraphUser:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildGraphUser (NSObject graphUser, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion)
		{
			if (graphUser == null)
				throw new ArgumentNullException ("graphUser");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildGraphUser:completionHandler:"), graphUser.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildRemoveMultiValue:forKey:localDataStore:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildRemoveMultiValue (string value, string key, CTLocalDataStore dataStore, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (dataStore == null)
				throw new ArgumentNullException ("dataStore");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V1.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildRemoveMultiValue:forKey:localDataStore:completionHandler:"), nsvalue, nskey, dataStore.Handle, (IntPtr) block_ptr_completion);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildRemoveMultiValues:forKey:localDataStore:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildRemoveMultiValues (string[] values, string key, CTLocalDataStore dataStore, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (dataStore == null)
				throw new ArgumentNullException ("dataStore");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V1.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildRemoveMultiValues:forKey:localDataStore:completionHandler:"), nsa_values.Handle, nskey, dataStore.Handle, (IntPtr) block_ptr_completion);
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildRemoveValueForKey:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildRemoveValueForKey (string key, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildRemoveValueForKey:completionHandler:"), nskey, (IntPtr) block_ptr_completion);
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("buildSetMultiValues:forKey:localDataStore:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BuildSetMultiValues (string[] values, string key, CTLocalDataStore dataStore, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion)
		{
			if (values == null)
				throw new ArgumentNullException ("values");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (dataStore == null)
				throw new ArgumentNullException ("dataStore");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			var nsa_values = NSArray.FromStrings (values);
			var nskey = NSString.CreateNative (key);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V1.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("buildSetMultiValues:forKey:localDataStore:completionHandler:"), nsa_values.Handle, nskey, dataStore.Handle, (IntPtr) block_ptr_completion);
			nsa_values.Dispose ();
			NSString.ReleaseNative (nskey);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	} /* class CTProfileBuilder */
}
