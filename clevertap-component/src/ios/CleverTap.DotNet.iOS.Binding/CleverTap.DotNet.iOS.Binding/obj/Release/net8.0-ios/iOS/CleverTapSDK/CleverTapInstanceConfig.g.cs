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
	[Protocol (Name = "CleverTapInstanceConfig", WrapperType = typeof (CleverTapInstanceConfigWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountId", Selector = "accountId", PropertyType = typeof (string), GetterSelector = "accountId", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountToken", Selector = "accountToken", PropertyType = typeof (string), GetterSelector = "accountToken", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AccountRegion", Selector = "accountRegion", PropertyType = typeof (string), GetterSelector = "accountRegion", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProxyDomain", Selector = "proxyDomain", PropertyType = typeof (string), GetterSelector = "proxyDomain", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SpikyProxyDomain", Selector = "spikyProxyDomain", PropertyType = typeof (string), GetterSelector = "spikyProxyDomain", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AnalyticsOnly", Selector = "analyticsOnly", PropertyType = typeof (bool), GetterSelector = "analyticsOnly", SetterSelector = "setAnalyticsOnly:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisableAppLaunchedEvent", Selector = "disableAppLaunchedEvent", PropertyType = typeof (bool), GetterSelector = "disableAppLaunchedEvent", SetterSelector = "setDisableAppLaunchedEvent:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EnablePersonalization", Selector = "enablePersonalization", PropertyType = typeof (bool), GetterSelector = "enablePersonalization", SetterSelector = "setEnablePersonalization:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "UseCustomCleverTapId", Selector = "useCustomCleverTapId", PropertyType = typeof (bool), GetterSelector = "useCustomCleverTapId", SetterSelector = "setUseCustomCleverTapId:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisableIDFV", Selector = "disableIDFV", PropertyType = typeof (bool), GetterSelector = "disableIDFV", SetterSelector = "setDisableIDFV:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "LogLevel", Selector = "logLevel", PropertyType = typeof (CleverTapSDK.CleverTapLogLevel), GetterSelector = "logLevel", SetterSelector = "setLogLevel:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IdentityKeys", Selector = "identityKeys", PropertyType = typeof (NSObject[]), GetterSelector = "identityKeys", SetterSelector = "setIdentityKeys:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ICleverTapInstanceConfig : INativeObject, IDisposable
	{
	}
	public unsafe static partial class CleverTapInstanceConfig_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountId (this ICleverTapInstanceConfig This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accountId")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountToken (this ICleverTapInstanceConfig This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accountToken")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetAccountRegion (this ICleverTapInstanceConfig This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accountRegion")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetProxyDomain (this ICleverTapInstanceConfig This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("proxyDomain")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSpikyProxyDomain (this ICleverTapInstanceConfig This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("spikyProxyDomain")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAnalyticsOnly (this ICleverTapInstanceConfig This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("analyticsOnly"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetAnalyticsOnly (this ICleverTapInstanceConfig This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAnalyticsOnly:"), value ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisableAppLaunchedEvent (this ICleverTapInstanceConfig This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("disableAppLaunchedEvent"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDisableAppLaunchedEvent (this ICleverTapInstanceConfig This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDisableAppLaunchedEvent:"), value ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetEnablePersonalization (this ICleverTapInstanceConfig This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("enablePersonalization"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetEnablePersonalization (this ICleverTapInstanceConfig This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setEnablePersonalization:"), value ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetUseCustomCleverTapId (this ICleverTapInstanceConfig This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("useCustomCleverTapId"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUseCustomCleverTapId (this ICleverTapInstanceConfig This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setUseCustomCleverTapId:"), value ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisableIDFV (this ICleverTapInstanceConfig This)
		{
			byte ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("disableIDFV"));
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDisableIDFV (this ICleverTapInstanceConfig This, bool value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setDisableIDFV:"), value ? (byte) 1 : (byte) 0);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapLogLevel GetLogLevel (this ICleverTapInstanceConfig This)
		{
			return (CleverTapLogLevel) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("logLevel"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLogLevel (this ICleverTapInstanceConfig This, CleverTapLogLevel value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setLogLevel:"), (int)value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject[] GetIdentityKeys (this ICleverTapInstanceConfig This)
		{
			return CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("identityKeys")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetIdentityKeys (this ICleverTapInstanceConfig This, NSObject[] value)
		{
			var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setIdentityKeys:"), nsa_value.GetHandle ());
			if (nsa_value is not null)
				nsa_value.Dispose ();
		}
	}
	internal unsafe sealed class CleverTapInstanceConfigWrapper : BaseWrapper, ICleverTapInstanceConfig {
		[Preserve (Conditional = true)]
		public CleverTapInstanceConfigWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CleverTapInstanceConfig", true)]
	public unsafe partial class CleverTapInstanceConfig : NSObject, ICleverTapInstanceConfig {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CleverTapInstanceConfig");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CleverTapInstanceConfig (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CleverTapInstanceConfig (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAccountId:accountToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CleverTapInstanceConfig (string accountId, string accountToken)
			: base (NSObjectFlag.Empty)
		{
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			if (accountToken is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountToken));
			var nsaccountId = CFString.CreateNative (accountId);
			var nsaccountToken = CFString.CreateNative (accountToken);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAccountId:accountToken:"), nsaccountId, nsaccountToken), "initWithAccountId:accountToken:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAccountId:accountToken:"), nsaccountId, nsaccountToken), "initWithAccountId:accountToken:");
			}
			CFString.ReleaseNative (nsaccountId);
			CFString.ReleaseNative (nsaccountToken);
		}
		[Export ("initWithAccountId:accountToken:accountRegion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CleverTapInstanceConfig (string accountId, string accountToken, string accountRegion)
			: base (NSObjectFlag.Empty)
		{
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			if (accountToken is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountToken));
			if (accountRegion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountRegion));
			var nsaccountId = CFString.CreateNative (accountId);
			var nsaccountToken = CFString.CreateNative (accountToken);
			var nsaccountRegion = CFString.CreateNative (accountRegion);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAccountId:accountToken:accountRegion:"), nsaccountId, nsaccountToken, nsaccountRegion), "initWithAccountId:accountToken:accountRegion:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAccountId:accountToken:accountRegion:"), nsaccountId, nsaccountToken, nsaccountRegion), "initWithAccountId:accountToken:accountRegion:");
			}
			CFString.ReleaseNative (nsaccountId);
			CFString.ReleaseNative (nsaccountToken);
			CFString.ReleaseNative (nsaccountRegion);
		}
		[Export ("initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CleverTapInstanceConfig (string accountId, string accountToken, string proxyDomain, string spikyProxyDomain)
			: base (NSObjectFlag.Empty)
		{
			if (accountId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountId));
			if (accountToken is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (accountToken));
			if (proxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (proxyDomain));
			if (spikyProxyDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spikyProxyDomain));
			var nsaccountId = CFString.CreateNative (accountId);
			var nsaccountToken = CFString.CreateNative (accountToken);
			var nsproxyDomain = CFString.CreateNative (proxyDomain);
			var nsspikyProxyDomain = CFString.CreateNative (spikyProxyDomain);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:"), nsaccountId, nsaccountToken, nsproxyDomain, nsspikyProxyDomain), "initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:"), nsaccountId, nsaccountToken, nsproxyDomain, nsspikyProxyDomain), "initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:");
			}
			CFString.ReleaseNative (nsaccountId);
			CFString.ReleaseNative (nsaccountToken);
			CFString.ReleaseNative (nsproxyDomain);
			CFString.ReleaseNative (nsspikyProxyDomain);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccountId {
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
		public virtual string AccountToken {
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
		public virtual bool AnalyticsOnly {
			[Export ("analyticsOnly")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("analyticsOnly"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("analyticsOnly"));
				}
				return ret != 0;
			}
			[Export ("setAnalyticsOnly:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAnalyticsOnly:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAnalyticsOnly:"), value ? (byte) 1 : (byte) 0);
				}
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
			[Export ("setDisableAppLaunchedEvent:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisableAppLaunchedEvent:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisableAppLaunchedEvent:"), value ? (byte) 1 : (byte) 0);
				}
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
			[Export ("setDisableIDFV:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisableIDFV:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisableIDFV:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnablePersonalization {
			[Export ("enablePersonalization")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enablePersonalization"));
				} else {
					ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enablePersonalization"));
				}
				return ret != 0;
			}
			[Export ("setEnablePersonalization:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnablePersonalization:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnablePersonalization:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? IdentityKeys {
			[Export ("identityKeys", ArgumentSemantic.Retain)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identityKeys")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("identityKeys")))!;
				}
				return ret!;
			}
			[Export ("setIdentityKeys:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIdentityKeys:"), nsa_value.GetHandle ());
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setIdentityKeys:"), nsa_value.GetHandle ());
				}
				if (nsa_value is not null)
					nsa_value.Dispose ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapLogLevel LogLevel {
			[Export ("logLevel", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (CleverTapLogLevel) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("logLevel"));
				} else {
					return (CleverTapLogLevel) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("logLevel"));
				}
			}
			[Export ("setLogLevel:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLogLevel:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setLogLevel:"), (int)value);
				}
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
			[Export ("setUseCustomCleverTapId:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUseCustomCleverTapId:"), value ? (byte) 1 : (byte) 0);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUseCustomCleverTapId:"), value ? (byte) 1 : (byte) 0);
				}
			}
		}
	} /* class CleverTapInstanceConfig */
}
