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
	[Register("CTLocalDataStore", true)]
	public unsafe partial class CTLocalDataStore : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTLocalDataStore");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
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
		protected internal CTLocalDataStore (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithConfig:andProfileValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CTLocalDataStore (CleverTapInstanceConfig config, NSDictionary profileValues)
			: base (NSObjectFlag.Empty)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			if (profileValues == null)
				throw new ArgumentNullException ("profileValues");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithConfig:andProfileValues:"), config.Handle, profileValues.Handle), "initWithConfig:andProfileValues:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithConfig:andProfileValues:"), config.Handle, profileValues.Handle), "initWithConfig:andProfileValues:");
			}
		}
		
		[Export ("addDataSyncFlag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddDataSyncFlag (NSMutableDictionary @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDataSyncFlag:"), @event.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDataSyncFlag:"), @event.Handle);
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
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			CleverTapEventDetail ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getEventDetail:"), nsevent));
			} else {
				ret =  Runtime.GetNSObject<CleverTapEventDetail> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getEventDetail:"), nsevent));
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("getFirstTimeForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetFirstTimeForEvent (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getFirstTimeForEvent:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getFirstTimeForEvent:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("getLastTimeForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetLastTimeForEvent (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			double ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getLastTimeForEvent:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.Double_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getLastTimeForEvent:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("getOccurrencesForEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int GetOccurrencesForEvent (string @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			var nsevent = NSString.CreateNative (@event);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getOccurrencesForEvent:"), nsevent);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getOccurrencesForEvent:"), nsevent);
			}
			NSString.ReleaseNative (nsevent);
			
			return ret;
		}
		
		[Export ("getProfileFieldForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetProfileFieldForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSObject ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getProfileFieldForKey:"), nskey));
			} else {
				ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getProfileFieldForKey:"), nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("persistEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PersistEvent (NSDictionary @event)
		{
			if (@event == null)
				throw new ArgumentNullException ("@event");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("persistEvent:"), @event.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("persistEvent:"), @event.Handle);
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
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeProfileFieldForKey:"), nskey);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeProfileFieldForKey:"), nskey);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("removeProfileFieldsWithKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveProfileFieldsWithKeys (NSObject[] keys)
		{
			if (keys == null)
				throw new ArgumentNullException ("keys");
			var nsa_keys = NSArray.FromNSObjects (keys);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeProfileFieldsWithKeys:"), nsa_keys.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeProfileFieldsWithKeys:"), nsa_keys.Handle);
			}
			nsa_keys.Dispose ();
			
		}
		
		[Export ("setProfileFieldWithKey:andValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProfileFieldWithKey (string key, NSObject value)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nskey = NSString.CreateNative (key);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setProfileFieldWithKey:andValue:"), nskey, value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setProfileFieldWithKey:andValue:"), nskey, value.Handle);
			}
			NSString.ReleaseNative (nskey);
			
		}
		
		[Export ("setProfileFields:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetProfileFields (NSDictionary fields)
		{
			if (fields == null)
				throw new ArgumentNullException ("fields");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProfileFields:"), fields.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProfileFields:"), fields.Handle);
			}
		}
		
		[Export ("syncWithRemoteData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary SyncWithRemoteData (NSDictionary responseData)
		{
			if (responseData == null)
				throw new ArgumentNullException ("responseData");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("syncWithRemoteData:"), responseData.Handle));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("syncWithRemoteData:"), responseData.Handle));
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary EventHistory {
			[Export ("getEventHistory")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getEventHistory")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEventHistory")));
				}
				return ret;
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GenerateBaseProfile {
			[Export ("generateBaseProfile")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("generateBaseProfile")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("generateBaseProfile")));
				}
				return ret;
			}
			
		}
		
	} /* class CTLocalDataStore */
}
