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
	[Protocol (Name = "CTValidator", WrapperType = typeof (CTValidatorWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanEventName", Selector = "cleanEventName:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanObjectKey", Selector = "cleanObjectKey:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanMultiValuePropertyKey", Selector = "cleanMultiValuePropertyKey:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanMultiValuePropertyValue", Selector = "cleanMultiValuePropertyValue:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanMultiValuePropertyArray", Selector = "cleanMultiValuePropertyArray:forKey:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (NSObject[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CleanObjectValue", Selector = "cleanObjectValue:context:", ReturnType = typeof (CleverTapSDK.CTValidationResult), ParameterType = new Type [] { typeof (NSObject), typeof (CleverTapSDK.CTValidatorContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IsRestrictedEventName", Selector = "isRestrictedEventName:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "IsValidCleverTapId", Selector = "isValidCleverTapId:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface ICTValidator : INativeObject, IDisposable
	{
	}
	
	internal sealed class CTValidatorWrapper : BaseWrapper, ICTValidator {
		[Preserve (Conditional = true)]
		public CTValidatorWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTValidator", true)]
	public unsafe partial class CTValidator : NSObject, ICTValidator {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTValidator");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTValidator () : base (NSObjectFlag.Empty)
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
		protected CTValidator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTValidator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cleanEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanEventName (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			CTValidationResult ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("cleanEventName:"), nsname));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("cleanMultiValuePropertyArray:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyArray (NSObject[] multi, string key)
		{
			if (multi == null)
				throw new ArgumentNullException ("multi");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsa_multi = NSArray.FromNSObjects (multi);
			var nskey = NSString.CreateNative (key);
			
			CTValidationResult ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyArray:forKey:"), nsa_multi.Handle, nskey));
			nsa_multi.Dispose ();
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("cleanMultiValuePropertyKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyKey (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			CTValidationResult ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyKey:"), nsname));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("cleanMultiValuePropertyValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanMultiValuePropertyValue (string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			CTValidationResult ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("cleanMultiValuePropertyValue:"), nsvalue));
			NSString.ReleaseNative (nsvalue);
			
			return ret;
		}
		
		[Export ("cleanObjectKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanObjectKey (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			CTValidationResult ret;
			ret =  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("cleanObjectKey:"), nsname));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("cleanObjectValue:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTValidationResult CleanObjectValue (NSObject o, CTValidatorContext context)
		{
			if (o == null)
				throw new ArgumentNullException ("o");
			return  Runtime.GetNSObject<CTValidationResult> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int (class_ptr, Selector.GetHandle ("cleanObjectValue:context:"), o.Handle, (int)context));
		}
		
		[Export ("isRestrictedEventName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRestrictedEventName (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isRestrictedEventName:"), nsname);
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("isValidCleverTapId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidCleverTapId (string cleverTapID)
		{
			if (cleverTapID == null)
				throw new ArgumentNullException ("cleverTapID");
			var nscleverTapID = NSString.CreateNative (cleverTapID);
			
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("isValidCleverTapId:"), nscleverTapID);
			NSString.ReleaseNative (nscleverTapID);
			
			return ret;
		}
		
	} /* class CTValidator */
}
