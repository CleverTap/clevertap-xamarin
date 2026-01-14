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
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static T? CreateInstance<T> (CleverTapInstanceConfig config, NSDictionary profileValues, CTDeviceInfo deviceInfo) where T: NSObject, ICTLocalDataStore
		{
			var config__handle__ = config!.GetNonNullHandle (nameof (config));
			var profileValues__handle__ = profileValues!.GetNonNullHandle (nameof (profileValues));
			var deviceInfo__handle__ = deviceInfo!.GetNonNullHandle (nameof (deviceInfo));
			IntPtr __handle__;
			__handle__ = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (__handle__, Selector.GetHandle ("initWithConfig:profileValues:andDeviceInfo:"), config__handle__, profileValues__handle__, deviceInfo__handle__);
			return  global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
		}
		[global::Foundation.OptionalMember]
		[Export ("persistEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PersistEvent (NSDictionary @event)
		{
			_PersistEvent (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PersistEvent (ICTLocalDataStore This, NSDictionary @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("persistEvent:"), @event__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("addDataSyncFlag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddDataSyncFlag (NSMutableDictionary @event)
		{
			_AddDataSyncFlag (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddDataSyncFlag (ICTLocalDataStore This, NSMutableDictionary @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addDataSyncFlag:"), @event__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("syncWithRemoteData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary SyncWithRemoteData (NSDictionary responseData)
		{
			return _SyncWithRemoteData (this, responseData);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _SyncWithRemoteData (ICTLocalDataStore This, NSDictionary responseData)
		{
			var responseData__handle__ = responseData!.GetNonNullHandle (nameof (responseData));
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("syncWithRemoteData:"), responseData__handle__))!;
		}
		[global::Foundation.OptionalMember]
		[Export ("getFirstTimeForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetFirstTimeForEvent (string @event)
		{
			return _GetFirstTimeForEvent (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetFirstTimeForEvent (ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getFirstTimeForEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("getLastTimeForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetLastTimeForEvent (string @event)
		{
			return _GetLastTimeForEvent (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLastTimeForEvent (ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			double ret;
			ret = global::ApiDefinition.Messaging.Double_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getLastTimeForEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("getOccurrencesForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int GetOccurrencesForEvent (string @event)
		{
			return _GetOccurrencesForEvent (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static int _GetOccurrencesForEvent (ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getOccurrencesForEvent:"), nsevent);
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("getEventDetail:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CleverTapEventDetail GetEventDetail (string @event)
		{
			return _GetEventDetail (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CleverTapEventDetail _GetEventDetail (ICTLocalDataStore This, string @event)
		{
			if (@event is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@event));
			var nsevent = CFString.CreateNative (@event);
			CleverTapEventDetail? ret;
			ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getEventDetail:"), nsevent))!;
			CFString.ReleaseNative (nsevent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("setProfileFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProfileFields (NSDictionary fields)
		{
			_SetProfileFields (this, fields);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetProfileFields (ICTLocalDataStore This, NSDictionary fields)
		{
			var fields__handle__ = fields!.GetNonNullHandle (nameof (fields));
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setProfileFields:"), fields__handle__);
		}
		[global::Foundation.OptionalMember]
		[Export ("setProfileFieldWithKey:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProfileFieldWithKey (string key, NSObject value)
		{
			_SetProfileFieldWithKey (this, key, value);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetProfileFieldWithKey (ICTLocalDataStore This, string key, NSObject value)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setProfileFieldWithKey:andValue:"), nskey, value__handle__);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.OptionalMember]
		[Export ("removeProfileFieldsWithKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveProfileFieldsWithKeys (NSObject[] keys)
		{
			_RemoveProfileFieldsWithKeys (this, keys);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveProfileFieldsWithKeys (ICTLocalDataStore This, NSObject[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			var nsa_keys = NSArray.FromNSObjects (keys);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeProfileFieldsWithKeys:"), nsa_keys.Handle);
			nsa_keys.Dispose ();
		}
		[global::Foundation.OptionalMember]
		[Export ("removeProfileFieldForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveProfileFieldForKey (string key)
		{
			_RemoveProfileFieldForKey (this, key);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveProfileFieldForKey (ICTLocalDataStore This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeProfileFieldForKey:"), nskey);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.OptionalMember]
		[Export ("getProfileFieldForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetProfileFieldForKey (string key)
		{
			return _GetProfileFieldForKey (this, key);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetProfileFieldForKey (ICTLocalDataStore This, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("getProfileFieldForKey:"), nskey))!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("persistLocalProfileIfRequired")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PersistLocalProfileIfRequired ()
		{
			_PersistLocalProfileIfRequired (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PersistLocalProfileIfRequired (ICTLocalDataStore This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("persistLocalProfileIfRequired"));
		}
		[global::Foundation.OptionalMember]
		[Export ("changeUser")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeUser ()
		{
			_ChangeUser (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ChangeUser (ICTLocalDataStore This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("changeUser"));
		}
		[DynamicDependencyAttribute ("AddDataSyncFlag(Foundation.NSMutableDictionary)")]
		[DynamicDependencyAttribute ("ChangeUser()")]
		[DynamicDependencyAttribute ("EventHistory")]
		[DynamicDependencyAttribute ("GenerateBaseProfile")]
		[DynamicDependencyAttribute ("GetEventDetail(System.String)")]
		[DynamicDependencyAttribute ("GetFirstTimeForEvent(System.String)")]
		[DynamicDependencyAttribute ("GetLastTimeForEvent(System.String)")]
		[DynamicDependencyAttribute ("GetOccurrencesForEvent(System.String)")]
		[DynamicDependencyAttribute ("GetProfileFieldForKey(System.String)")]
		[DynamicDependencyAttribute ("PersistEvent(Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("PersistLocalProfileIfRequired()")]
		[DynamicDependencyAttribute ("RemoveProfileFieldForKey(System.String)")]
		[DynamicDependencyAttribute ("RemoveProfileFieldsWithKeys(Foundation.NSObject[])")]
		[DynamicDependencyAttribute ("SetProfileFields(Foundation.NSDictionary)")]
		[DynamicDependencyAttribute ("SetProfileFieldWithKey(System.String,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SyncWithRemoteData(Foundation.NSDictionary)")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICTLocalDataStore ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSDictionary EventHistory {
			[Export ("getEventHistory")]
			get {
				return _GetEventHistory (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetEventHistory (ICTLocalDataStore This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("getEventHistory")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual NSDictionary GenerateBaseProfile {
			[Export ("generateBaseProfile")]
			get {
				return _GetGenerateBaseProfile (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetGenerateBaseProfile (ICTLocalDataStore This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("generateBaseProfile")))!;
		}
	}
	/// <summary>Extension methods to the <see cref="ICTLocalDataStore" /> interface to support all the methods from the CTLocalDataStore protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICTLocalDataStore" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CTLocalDataStore protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
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
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CTLocalDataStore" /> with default values.</summary>
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

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (this.SuperHandle, initWithFrame, frame);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CTLocalDataStore (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
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
