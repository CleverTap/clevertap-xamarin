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
	[Protocol (Name = "CTPlistInfo", WrapperType = typeof (CTPlistInfoWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SharedInstance", Selector = "sharedInstance", ReturnType = typeof (CleverTapSDK.CTPlistInfo))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeCredentialsWithAccountID", Selector = "changeCredentialsWithAccountID:token:region:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountId", Selector = "accountId", PropertyType = typeof (string), GetterSelector = "accountId", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountToken", Selector = "accountToken", PropertyType = typeof (string), GetterSelector = "accountToken", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountRegion", Selector = "accountRegion", PropertyType = typeof (string), GetterSelector = "accountRegion", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RegisteredUrlSchemes", Selector = "registeredUrlSchemes", PropertyType = typeof (String[]), GetterSelector = "registeredUrlSchemes", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UseIDFA", Selector = "useIDFA", PropertyType = typeof (bool), GetterSelector = "useIDFA", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisableAppLaunchedEvent", Selector = "disableAppLaunchedEvent", PropertyType = typeof (bool), GetterSelector = "disableAppLaunchedEvent", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UseCustomCleverTapId", Selector = "useCustomCleverTapId", PropertyType = typeof (bool), GetterSelector = "useCustomCleverTapId", ArgumentSemantic = ArgumentSemantic.None)]
	public interface ICTPlistInfo : INativeObject, IDisposable
	{
	}
	
	public static partial class CTPlistInfo_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeCredentialsWithAccountID (this ICTPlistInfo This, string accountID, string token, string region)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (token == null)
				throw new ArgumentNullException ("token");
			var nsaccountID = NSString.CreateNative (accountID);
			var nstoken = NSString.CreateNative (token);
			var nsregion = NSString.CreateNative (region);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("changeCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			NSString.ReleaseNative (nsaccountID);
			NSString.ReleaseNative (nstoken);
			NSString.ReleaseNative (nsregion);
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountId (this ICTPlistInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accountId")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountToken (this ICTPlistInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accountToken")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountRegion (this ICTPlistInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accountRegion")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetRegisteredUrlSchemes (this ICTPlistInfo This)
		{
			return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("registeredUrlSchemes")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetUseIDFA (this ICTPlistInfo This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("useIDFA"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisableAppLaunchedEvent (this ICTPlistInfo This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("disableAppLaunchedEvent"));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetUseCustomCleverTapId (this ICTPlistInfo This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("useCustomCleverTapId"));
		}
		
	}
	
	internal sealed class CTPlistInfoWrapper : BaseWrapper, ICTPlistInfo {
		[Preserve (Conditional = true)]
		public CTPlistInfoWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTPlistInfo", true)]
	public unsafe partial class CTPlistInfo : NSObject, ICTPlistInfo {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTPlistInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTPlistInfo () : base (NSObjectFlag.Empty)
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
		protected CTPlistInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTPlistInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("changeCredentialsWithAccountID:token:region:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeCredentialsWithAccountID (string accountID, string token, string region)
		{
			if (accountID == null)
				throw new ArgumentNullException ("accountID");
			if (token == null)
				throw new ArgumentNullException ("token");
			var nsaccountID = NSString.CreateNative (accountID);
			var nstoken = NSString.CreateNative (token);
			var nsregion = NSString.CreateNative (region);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("changeCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("changeCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			}
			NSString.ReleaseNative (nsaccountID);
			NSString.ReleaseNative (nstoken);
			NSString.ReleaseNative (nsregion);
			
		}
		
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTPlistInfo SharedInstance ()
		{
			return  Runtime.GetNSObject<CTPlistInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountId {
			[Export ("accountId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accountId")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountId")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountRegion {
			[Export ("accountRegion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accountRegion")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountRegion")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountToken {
			[Export ("accountToken", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accountToken")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountToken")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisableAppLaunchedEvent {
			[Export ("disableAppLaunchedEvent")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disableAppLaunchedEvent"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableAppLaunchedEvent"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] RegisteredUrlSchemes {
			[Export ("registeredUrlSchemes", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("registeredUrlSchemes")));
				} else {
					return NSArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("registeredUrlSchemes")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UseCustomCleverTapId {
			[Export ("useCustomCleverTapId")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useCustomCleverTapId"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useCustomCleverTapId"));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UseIDFA {
			[Export ("useIDFA")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useIDFA"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useIDFA"));
				}
			}
			
		}
		
	} /* class CTPlistInfo */
}
