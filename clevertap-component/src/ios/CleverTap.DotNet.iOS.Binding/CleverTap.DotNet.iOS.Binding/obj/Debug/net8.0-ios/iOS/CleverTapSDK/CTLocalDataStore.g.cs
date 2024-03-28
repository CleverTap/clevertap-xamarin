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
	[Protocol (Name = "CTLocalDataStore", WrapperType = typeof (CTLocalDataStoreWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PersistEvent", Selector = "persistEvent:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddDataSyncFlag", Selector = "addDataSyncFlag:", ParameterType = new Type [] { typeof (NSMutableDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SyncWithRemoteData", Selector = "syncWithRemoteData:", ReturnType = typeof (NSDictionary), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFirstTimeForEvent", Selector = "getFirstTimeForEvent:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLastTimeForEvent", Selector = "getLastTimeForEvent:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOccurrencesForEvent", Selector = "getOccurrencesForEvent:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetEventDetail", Selector = "getEventDetail:", ReturnType = typeof (CleverTapSDK.CleverTapEventDetail), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetProfileFields", Selector = "setProfileFields:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetProfileFieldWithKey", Selector = "setProfileFieldWithKey:andValue:", ParameterType = new Type [] { typeof (string), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveProfileFieldsWithKeys", Selector = "removeProfileFieldsWithKeys:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveProfileFieldForKey", Selector = "removeProfileFieldForKey:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetProfileFieldForKey", Selector = "getProfileFieldForKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PersistLocalProfileIfRequired", Selector = "persistLocalProfileIfRequired")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChangeUser", Selector = "changeUser")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EventHistory", Selector = "getEventHistory", PropertyType = typeof (NSDictionary), GetterSelector = "getEventHistory", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "GenerateBaseProfile", Selector = "generateBaseProfile", PropertyType = typeof (NSDictionary), GetterSelector = "generateBaseProfile", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICTLocalDataStore : INativeObject, IDisposable
	{
	}
	public unsafe static partial class CTLocalDataStore_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PersistEvent (this ICTLocalDataStore This, NSDictionary @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("persistEvent:"), @event__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddDataSyncFlag (this ICTLocalDataStore This, NSMutableDictionary @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addDataSyncFlag:"), @event__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary SyncWithRemoteData (this ICTLocalDataStore This, NSDictionary responseData)
		{
			var responseData__handle__ = responseData!.GetNonNullHandle (nameof (responseData));
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("syncWithRemoteData:"), responseData__handle__))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetFirstTimeForEvent (this ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getFirstTimeForEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double GetLastTimeForEvent (this ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getLastTimeForEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int GetOccurrencesForEvent (this ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getOccurrencesForEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CleverTapEventDetail GetEventDetail (this ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			CleverTapEventDetail? ret;
			ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getEventDetail:"), nsevent))!;
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetProfileFields (this ICTLocalDataStore This, NSDictionary fields)
		{
			var fields__handle__ = fields!.GetNonNullHandle (nameof (fields));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setProfileFields:"), fields__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetProfileFieldWithKey (this ICTLocalDataStore This, string key, NSObject value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setProfileFieldWithKey:andValue:"), nskey, value__handle__);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveProfileFieldsWithKeys (this ICTLocalDataStore This, NSObject[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromNSObjects (keys);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeProfileFieldsWithKeys:"), nsa_keys.Handle);
			nsa_keys.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveProfileFieldForKey (this ICTLocalDataStore This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeProfileFieldForKey:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetProfileFieldForKey (this ICTLocalDataStore This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getProfileFieldForKey:"), nskey))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PersistLocalProfileIfRequired (this ICTLocalDataStore This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("persistLocalProfileIfRequired"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ChangeUser (this ICTLocalDataStore This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("changeUser"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetEventHistory (this ICTLocalDataStore This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("getEventHistory")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary GetGenerateBaseProfile (this ICTLocalDataStore This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("generateBaseProfile")))!;
		}
	}
	internal unsafe sealed class CTLocalDataStoreWrapper : BaseWrapper, ICTLocalDataStore {
		[Preserve (Conditional = true)]
		public CTLocalDataStoreWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace CleverTapSDK {
	[Protocol()]
	[Register("CTLocalDataStore", true)]
	public unsafe partial class CTLocalDataStore : NSObject, ICTLocalDataStore {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CTLocalDataStore");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTLocalDataStore () : base (NSObjectFlag.Empty)
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
		protected CTLocalDataStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CTLocalDataStore (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:profileValues:andDeviceInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTLocalDataStore (CleverTapInstanceConfig config, NSDictionary profileValues, CTDeviceInfo deviceInfo)
			: base (NSObjectFlag.Empty)
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var profileValues__handle__ = profileValues!.GetNonNullHandle (nameof (profileValues));
			var deviceInfo__handle__ = deviceInfo!.GetNonNullHandle (nameof (deviceInfo));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithConfig:profileValues:andDeviceInfo:"), config__handle__, profileValues__handle__, deviceInfo__handle__), "initWithConfig:profileValues:andDeviceInfo:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithConfig:profileValues:andDeviceInfo:"), config__handle__, profileValues__handle__, deviceInfo__handle__), "initWithConfig:profileValues:andDeviceInfo:");
			}
		}
		[Export ("addDataSyncFlag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddDataSyncFlag (NSMutableDictionary @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addDataSyncFlag:"), @event__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("addDataSyncFlag:"), @event__handle__);
			}
		}
		[Export ("changeUser")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeUser ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("changeUser"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("changeUser"));
			}
		}
		[Export ("getEventDetail:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapEventDetail GetEventDetail (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			CleverTapEventDetail? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getEventDetail:"), nsevent))!;
			} else {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getEventDetail:"), nsevent))!;
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("getFirstTimeForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetFirstTimeForEvent (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getFirstTimeForEvent:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getFirstTimeForEvent:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("getLastTimeForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetLastTimeForEvent (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getLastTimeForEvent:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getLastTimeForEvent:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("getOccurrencesForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int GetOccurrencesForEvent (string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getOccurrencesForEvent:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getOccurrencesForEvent:"), nsevent);
			}
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[Export ("getProfileFieldForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetProfileFieldForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("getProfileFieldForKey:"), nskey))!;
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("getProfileFieldForKey:"), nskey))!;
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("persistEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PersistEvent (NSDictionary @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("persistEvent:"), @event__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("persistEvent:"), @event__handle__);
			}
		}
		[Export ("persistLocalProfileIfRequired")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PersistLocalProfileIfRequired ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("persistLocalProfileIfRequired"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("persistLocalProfileIfRequired"));
			}
		}
		[Export ("removeProfileFieldForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveProfileFieldForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeProfileFieldForKey:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("removeProfileFieldForKey:"), nskey);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("removeProfileFieldsWithKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveProfileFieldsWithKeys (NSObject[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromNSObjects (keys);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeProfileFieldsWithKeys:"), nsa_keys.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("removeProfileFieldsWithKeys:"), nsa_keys.Handle);
			}
			nsa_keys.Dispose ();
		}
		[Export ("setProfileFieldWithKey:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProfileFieldWithKey (string key, NSObject value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setProfileFieldWithKey:andValue:"), nskey, value__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (this.SuperHandle, Selector.GetHandle ("setProfileFieldWithKey:andValue:"), nskey, value__handle__);
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("setProfileFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProfileFields (NSDictionary fields)
		{
			var fields__handle__ = fields!.GetNonNullHandle (nameof (fields));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setProfileFields:"), fields__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setProfileFields:"), fields__handle__);
			}
		}
		[Export ("syncWithRemoteData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary SyncWithRemoteData (NSDictionary responseData)
		{
			var responseData__handle__ = responseData!.GetNonNullHandle (nameof (responseData));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("syncWithRemoteData:"), responseData__handle__))!;
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("syncWithRemoteData:"), responseData__handle__))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary EventHistory {
			[Export ("getEventHistory")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("getEventHistory")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEventHistory")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GenerateBaseProfile {
			[Export ("generateBaseProfile")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("generateBaseProfile")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("generateBaseProfile")))!;
				}
				return ret!;
			}
		}
	} /* class CTLocalDataStore */
}
