using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Displayunits {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitController']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/displayunits/CTDisplayUnitController", DoNotGenerateAcw=true)]
	public partial class CTDisplayUnitController : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/displayunits/CTDisplayUnitController", typeof (CTDisplayUnitController));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected CTDisplayUnitController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitController']/constructor[@name='CTDisplayUnitController' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTDisplayUnitController ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAllDisplayUnits;
#pragma warning disable 0169
		static Delegate GetGetAllDisplayUnitsHandler ()
		{
			if (cb_getAllDisplayUnits == null)
				cb_getAllDisplayUnits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllDisplayUnits);
			return cb_getAllDisplayUnits;
		}

		static IntPtr n_GetAllDisplayUnits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit>.ToLocalJniHandle (__this.AllDisplayUnits);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> AllDisplayUnits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitController']/method[@name='getAllDisplayUnits' and count(parameter)=0]"
			[Register ("getAllDisplayUnits", "()Ljava/util/ArrayList;", "GetGetAllDisplayUnitsHandler")]
			get {
				const string __id = "getAllDisplayUnits.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayUnitForID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDisplayUnitForID_Ljava_lang_String_Handler ()
		{
			if (cb_getDisplayUnitForID_Ljava_lang_String_ == null)
				cb_getDisplayUnitForID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDisplayUnitForID_Ljava_lang_String_);
			return cb_getDisplayUnitForID_Ljava_lang_String_;
		}

		static IntPtr n_GetDisplayUnitForID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unitId)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string unitId = JNIEnv.GetString (native_unitId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDisplayUnitForID (unitId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitController']/method[@name='getDisplayUnitForID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDisplayUnitForID", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnit;", "GetGetDisplayUnitForID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit GetDisplayUnitForID (string unitId)
		{
			const string __id = "getDisplayUnitForID.(Ljava/lang/String;)Lcom/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnit;";
			IntPtr native_unitId = JNIEnv.NewString (unitId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_unitId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_unitId);
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitController']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateDisplayUnits_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetUpdateDisplayUnits_Lorg_json_JSONArray_Handler ()
		{
			if (cb_updateDisplayUnits_Lorg_json_JSONArray_ == null)
				cb_updateDisplayUnits_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDisplayUnits_Lorg_json_JSONArray_);
			return cb_updateDisplayUnits_Lorg_json_JSONArray_;
		}

		static IntPtr n_UpdateDisplayUnits_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_messages)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray messages = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_messages, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit>.ToLocalJniHandle (__this.UpdateDisplayUnits (messages));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitController']/method[@name='updateDisplayUnits' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("updateDisplayUnits", "(Lorg/json/JSONArray;)Ljava/util/ArrayList;", "GetUpdateDisplayUnits_Lorg_json_JSONArray_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> UpdateDisplayUnits (global::Org.Json.JSONArray messages)
		{
			const string __id = "updateDisplayUnits.(Lorg/json/JSONArray;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((messages == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messages).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
