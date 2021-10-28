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

#nullable enable

namespace CleverTapSDK {
	[Protocol (Name = "CleverTapSyncDelegate", WrapperType = typeof (CleverTapSyncDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDidInitialize", Selector = "profileDidInitialize:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDidInitialize", Selector = "profileDidInitialize:forAccountId:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProfileDataUpdated", Selector = "profileDataUpdated:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	public partial interface ICleverTapSyncDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class CleverTapSyncDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDidInitialize (this ICleverTapSyncDelegate This, string CleverTapID)
		{
			if (CleverTapID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (CleverTapID));
			var nsCleverTapID = NSString.CreateNative (CleverTapID);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profileDidInitialize:"), nsCleverTapID);
			NSString.ReleaseNative (nsCleverTapID);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDidInitialize (this ICleverTapSyncDelegate This, string CleverTapID, string accountId)
		{
			if (CleverTapID == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (CleverTapID));
			if (accountId == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			var nsCleverTapID = NSString.CreateNative (CleverTapID);
			var nsaccountId = NSString.CreateNative (accountId);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("profileDidInitialize:forAccountId:"), nsCleverTapID, nsaccountId);
			NSString.ReleaseNative (nsCleverTapID);
			NSString.ReleaseNative (nsaccountId);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProfileDataUpdated (this ICleverTapSyncDelegate This, NSDictionary updates)
		{
			var updates__handle__ = updates.GetNonNullHandle (nameof (updates));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("profileDataUpdated:"), updates__handle__);
		}
		
	}
	
	internal sealed class CleverTapSyncDelegateWrapper : BaseWrapper, ICleverTapSyncDelegate {
		[Preserve (Conditional = true)]
		public CleverTapSyncDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("ApiDefinition__CleverTapSDK_CleverTapSyncDelegate", false)]
	[Model]
	public unsafe partial class CleverTapSyncDelegate : NSObject, ICleverTapSyncDelegate {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CleverTapSyncDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapSyncDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapSyncDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("profileDataUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDataUpdated (NSDictionary updates)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("profileDidInitialize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDidInitialize (string CleverTapID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("profileDidInitialize:forAccountId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProfileDidInitialize (string CleverTapID, string accountId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CleverTapSyncDelegate */
}
