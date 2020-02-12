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
	[Protocol (Name = "CTKnownProfileFields", WrapperType = typeof (CTKnownProfileFieldsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetStorageValueForField", Selector = "getStorageValueForField:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (CleverTapSDK.KnownField) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "GetKnownFieldIfPossibleForKey", Selector = "getKnownFieldIfPossibleForKey:", ReturnType = typeof (CleverTapSDK.KnownField), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface ICTKnownProfileFields : INativeObject, IDisposable
	{
	}
	
	internal sealed class CTKnownProfileFieldsWrapper : BaseWrapper, ICTKnownProfileFields {
		[Preserve (Conditional = true)]
		public CTKnownProfileFieldsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTKnownProfileFields", true)]
	public unsafe partial class CTKnownProfileFields : NSObject, ICTKnownProfileFields {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTKnownProfileFields");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTKnownProfileFields () : base (NSObjectFlag.Empty)
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
		protected CTKnownProfileFields (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTKnownProfileFields (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getKnownFieldIfPossibleForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static KnownField GetKnownFieldIfPossibleForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			KnownField ret;
			ret = (KnownField) global::ApiDefinition.Messaging.UInt64_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getKnownFieldIfPossibleForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("getStorageValueForField:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetStorageValueForField (KnownField field)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("getStorageValueForField:"), (UInt64)field));
		}
		
	} /* class CTKnownProfileFields */
}
