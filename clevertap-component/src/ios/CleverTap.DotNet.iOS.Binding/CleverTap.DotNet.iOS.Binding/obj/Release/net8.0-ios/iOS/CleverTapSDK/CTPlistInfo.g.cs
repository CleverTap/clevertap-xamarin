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
	[Protocol (Name = "CTPlistInfo", WrapperType = typeof (CTPlistInfoWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SharedInstance", Selector = "sharedInstance", ReturnType = typeof (CleverTapSDK.CTPlistInfo))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:token:region:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCredentialsWithAccountID", Selector = "setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountId", Selector = "accountId", PropertyType = typeof (string), GetterSelector = "accountId", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountToken", Selector = "accountToken", PropertyType = typeof (string), GetterSelector = "accountToken", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountRegion", Selector = "accountRegion", PropertyType = typeof (string), GetterSelector = "accountRegion", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProxyDomain", Selector = "proxyDomain", PropertyType = typeof (string), GetterSelector = "proxyDomain", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpikyProxyDomain", Selector = "spikyProxyDomain", PropertyType = typeof (string), GetterSelector = "spikyProxyDomain", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RegisteredUrlSchemes", Selector = "registeredUrlSchemes", PropertyType = typeof (String[]), GetterSelector = "registeredUrlSchemes", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisableAppLaunchedEvent", Selector = "disableAppLaunchedEvent", PropertyType = typeof (bool), GetterSelector = "disableAppLaunchedEvent", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UseCustomCleverTapId", Selector = "useCustomCleverTapId", PropertyType = typeof (bool), GetterSelector = "useCustomCleverTapId", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Beta", Selector = "beta", PropertyType = typeof (bool), GetterSelector = "beta", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisableIDFV", Selector = "disableIDFV", PropertyType = typeof (bool), GetterSelector = "disableIDFV", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICTPlistInfo : INativeObject, IDisposable
	{
	}
	public unsafe static partial class CTPlistInfo_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (this ICTPlistInfo This, string accountID, string token, string? region)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsregion = CFString.CreateNative (region);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsregion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCredentialsWithAccountID (this ICTPlistInfo This, string accountID, string token, string proxyDomain, string spikyProxyDomain)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (proxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (proxyDomain));
			if (spikyProxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spikyProxyDomain));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsproxyDomain = CFString.CreateNative (proxyDomain);
			var nsspikyProxyDomain = CFString.CreateNative (spikyProxyDomain);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:"), nsaccountID, nstoken, nsproxyDomain, nsspikyProxyDomain);
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsproxyDomain);
			CFString.ReleaseNative (nsspikyProxyDomain);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountId (this ICTPlistInfo This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accountId")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountToken (this ICTPlistInfo This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accountToken")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountRegion (this ICTPlistInfo This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accountRegion")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetProxyDomain (this ICTPlistInfo This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("proxyDomain")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSpikyProxyDomain (this ICTPlistInfo This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("spikyProxyDomain")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetRegisteredUrlSchemes (this ICTPlistInfo This)
		{
			return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("registeredUrlSchemes")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisableAppLaunchedEvent (this ICTPlistInfo This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("disableAppLaunchedEvent"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetUseCustomCleverTapId (this ICTPlistInfo This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("useCustomCleverTapId"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetBeta (this ICTPlistInfo This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("beta"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisableIDFV (this ICTPlistInfo This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("disableIDFV"));
			return ret != 0;
		}
	}
	internal unsafe sealed class CTPlistInfoWrapper : BaseWrapper, ICTPlistInfo {
		[Preserve (Conditional = true)]
		public CTPlistInfoWrapper (NativeHandle handle, bool owns)
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
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTPlistInfo");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected internal CTPlistInfo (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setCredentialsWithAccountID:token:region:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCredentialsWithAccountID (string accountID, string token, string? region)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsregion = CFString.CreateNative (region);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCredentialsWithAccountID:token:region:"), nsaccountID, nstoken, nsregion);
			}
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsregion);
		}
		[Export ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCredentialsWithAccountID (string accountID, string token, string proxyDomain, string spikyProxyDomain)
		{
			if (accountID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountID));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			if (proxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (proxyDomain));
			if (spikyProxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spikyProxyDomain));
			var nsaccountID = CFString.CreateNative (accountID);
			var nstoken = CFString.CreateNative (token);
			var nsproxyDomain = CFString.CreateNative (proxyDomain);
			var nsspikyProxyDomain = CFString.CreateNative (spikyProxyDomain);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:"), nsaccountID, nstoken, nsproxyDomain, nsspikyProxyDomain);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:"), nsaccountID, nstoken, nsproxyDomain, nsspikyProxyDomain);
			}
			CFString.ReleaseNative (nsaccountID);
			CFString.ReleaseNative (nstoken);
			CFString.ReleaseNative (nsproxyDomain);
			CFString.ReleaseNative (nsspikyProxyDomain);
		}
		[Export ("sharedInstance")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CTPlistInfo? SharedInstance ()
		{
			return  Runtime.GetNSObject<CTPlistInfo> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccountId {
			[Export ("accountId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accountId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountId")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccountRegion {
			[Export ("accountRegion", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accountRegion")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountRegion")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccountToken {
			[Export ("accountToken", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accountToken")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountToken")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Beta {
			[Export ("beta")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("beta"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beta"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisableAppLaunchedEvent {
			[Export ("disableAppLaunchedEvent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disableAppLaunchedEvent"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableAppLaunchedEvent"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisableIDFV {
			[Export ("disableIDFV")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disableIDFV"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableIDFV"));
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ProxyDomain {
			[Export ("proxyDomain", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("proxyDomain")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("proxyDomain")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? RegisteredUrlSchemes {
			[Export ("registeredUrlSchemes", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("registeredUrlSchemes")))!;
				} else {
					return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("registeredUrlSchemes")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SpikyProxyDomain {
			[Export ("spikyProxyDomain", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("spikyProxyDomain")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("spikyProxyDomain")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UseCustomCleverTapId {
			[Export ("useCustomCleverTapId")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("useCustomCleverTapId"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("useCustomCleverTapId"));
				}
				return ret != 0;
			}
		}
	} /* class CTPlistInfo */
}
