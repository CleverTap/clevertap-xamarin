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
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace CleverTapSDK {
	[Protocol (Name = "CTLoginInfoProvider", WrapperType = typeof (CTLoginInfoProviderWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CacheGUID", Selector = "cacheGUID:forKey:andIdentifier:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCachedGUIDs", Selector = "setCachedGUIDs:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetGUIDforKey", Selector = "getGUIDforKey:andIdentifier:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetCachedIdentities", Selector = "setCachedIdentities:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveValueFromCachedGUIDForKey", Selector = "removeValueFromCachedGUIDForKey:andGuid:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DeviceIsMultiUser", Selector = "deviceIsMultiUser", PropertyType = typeof (bool), GetterSelector = "deviceIsMultiUser", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CachedGUIDs", Selector = "getCachedGUIDs", PropertyType = typeof (NSDictionary), GetterSelector = "getCachedGUIDs", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CachedIdentities", Selector = "getCachedIdentities", PropertyType = typeof (string), GetterSelector = "getCachedIdentities", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsAnonymousDevice", Selector = "isAnonymousDevice", PropertyType = typeof (bool), GetterSelector = "isAnonymousDevice", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsLegacyProfileLoggedIn", Selector = "isLegacyProfileLoggedIn", PropertyType = typeof (bool), GetterSelector = "isLegacyProfileLoggedIn", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICTLoginInfoProvider : INativeObject, IDisposable
	{
	}
	public static partial class CTLoginInfoProvider_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CacheGUID (this ICTLoginInfoProvider This, string guid, string key, string identifier)
		{
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsguid = CFString.CreateNative (guid);
			var nskey = CFString.CreateNative (key);
			var nsidentifier = CFString.CreateNative (identifier);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("cacheGUID:forKey:andIdentifier:"), nsguid, nskey, nsidentifier);
			CFString.ReleaseNative (nsguid);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsidentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCachedGUIDs (this ICTLoginInfoProvider This, NSDictionary cache)
		{
			var cache__handle__ = cache!.GetNonNullHandle (nameof (cache));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCachedGUIDs:"), cache__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetGUIDforKey (this ICTLoginInfoProvider This, string key, string identifier)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nskey = CFString.CreateNative (key);
			var nsidentifier = CFString.CreateNative (identifier);
			string? ret;
			ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("getGUIDforKey:andIdentifier:"), nskey, nsidentifier))!;
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetCachedIdentities (this ICTLoginInfoProvider This, string cache)
		{
			if (cache is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cache));
			var nscache = CFString.CreateNative (cache);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCachedIdentities:"), nscache);
			CFString.ReleaseNative (nscache);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveValueFromCachedGUIDForKey (this ICTLoginInfoProvider This, string key, string guid)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nskey = CFString.CreateNative (key);
			var nsguid = CFString.CreateNative (guid);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("removeValueFromCachedGUIDForKey:andGuid:"), nskey, nsguid);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsguid);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDeviceIsMultiUser (this ICTLoginInfoProvider This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("deviceIsMultiUser"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetCachedGUIDs (this ICTLoginInfoProvider This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getCachedGUIDs")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetCachedIdentities (this ICTLoginInfoProvider This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getCachedIdentities")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsAnonymousDevice (this ICTLoginInfoProvider This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAnonymousDevice"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsLegacyProfileLoggedIn (this ICTLoginInfoProvider This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isLegacyProfileLoggedIn"));
		}
	}
	internal sealed class CTLoginInfoProviderWrapper : BaseWrapper, ICTLoginInfoProvider {
		[Preserve (Conditional = true)]
		public CTLoginInfoProviderWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTLoginInfoProvider", true)]
	public unsafe partial class CTLoginInfoProvider : NSObject, ICTLoginInfoProvider {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTLoginInfoProvider");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTLoginInfoProvider () : base (NSObjectFlag.Empty)
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
		protected CTLoginInfoProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTLoginInfoProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDeviceInfo:config:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTLoginInfoProvider (CTDeviceInfo deviceInfo, CleverTapInstanceConfig config)
			: base (NSObjectFlag.Empty)
		{
			var deviceInfo__handle__ = deviceInfo!.GetNonNullHandle (nameof (deviceInfo));
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithDeviceInfo:config:"), deviceInfo__handle__, config__handle__), "initWithDeviceInfo:config:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDeviceInfo:config:"), deviceInfo__handle__, config__handle__), "initWithDeviceInfo:config:");
			}
		}
		[Export ("cacheGUID:forKey:andIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CacheGUID (string guid, string key, string identifier)
		{
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsguid = CFString.CreateNative (guid);
			var nskey = CFString.CreateNative (key);
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cacheGUID:forKey:andIdentifier:"), nsguid, nskey, nsidentifier);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cacheGUID:forKey:andIdentifier:"), nsguid, nskey, nsidentifier);
			}
			CFString.ReleaseNative (nsguid);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("getGUIDforKey:andIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetGUIDforKey (string key, string identifier)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nskey = CFString.CreateNative (key);
			var nsidentifier = CFString.CreateNative (identifier);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getGUIDforKey:andIdentifier:"), nskey, nsidentifier))!;
			} else {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getGUIDforKey:andIdentifier:"), nskey, nsidentifier))!;
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("removeValueFromCachedGUIDForKey:andGuid:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveValueFromCachedGUIDForKey (string key, string guid)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (guid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (guid));
			var nskey = CFString.CreateNative (key);
			var nsguid = CFString.CreateNative (guid);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeValueFromCachedGUIDForKey:andGuid:"), nskey, nsguid);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeValueFromCachedGUIDForKey:andGuid:"), nskey, nsguid);
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsguid);
		}
		[Export ("setCachedGUIDs:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCachedGUIDs (NSDictionary cache)
		{
			var cache__handle__ = cache!.GetNonNullHandle (nameof (cache));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCachedGUIDs:"), cache__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCachedGUIDs:"), cache__handle__);
			}
		}
		[Export ("setCachedIdentities:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCachedIdentities (string cache)
		{
			if (cache is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (cache));
			var nscache = CFString.CreateNative (cache);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCachedIdentities:"), nscache);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCachedIdentities:"), nscache);
			}
			CFString.ReleaseNative (nscache);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary CachedGUIDs {
			[Export ("getCachedGUIDs")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCachedGUIDs")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCachedGUIDs")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CachedIdentities {
			[Export ("getCachedIdentities")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCachedIdentities")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCachedIdentities")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DeviceIsMultiUser {
			[Export ("deviceIsMultiUser")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("deviceIsMultiUser"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceIsMultiUser"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnonymousDevice {
			[Export ("isAnonymousDevice")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnonymousDevice"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAnonymousDevice"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLegacyProfileLoggedIn {
			[Export ("isLegacyProfileLoggedIn")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isLegacyProfileLoggedIn"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isLegacyProfileLoggedIn"));
				}
			}
		}
	} /* class CTLoginInfoProvider */
}
