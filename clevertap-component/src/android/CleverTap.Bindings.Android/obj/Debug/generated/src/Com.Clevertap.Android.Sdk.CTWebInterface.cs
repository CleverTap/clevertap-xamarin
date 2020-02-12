using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTWebInterface", DoNotGenerateAcw=true)]
	public partial class CTWebInterface : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTWebInterface", typeof (CTWebInterface));
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

		protected CTWebInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/constructor[@name='CTWebInterface' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CleverTapAPI']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/CleverTapAPI;)V", "")]
		public unsafe CTWebInterface (global::Com.Clevertap.Android.Sdk.CleverTapAPI instance)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/CleverTapAPI;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddMultiValueForKey (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='addMultiValueForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMultiValueForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddMultiValueForKey (string key, string value)
		{
			const string __id = "addMultiValueForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_addMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_addMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string values = JNIEnv.GetString (native_values, JniHandleOwnership.DoNotTransfer);
			__this.AddMultiValuesForKey (key, values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='addMultiValuesForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMultiValuesForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddMultiValuesForKey (string key, string values)
		{
			const string __id = "addMultiValuesForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = JNIEnv.NewString (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		static Delegate cb_pushEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPushEvent_Ljava_lang_String_Handler ()
		{
			if (cb_pushEvent_Ljava_lang_String_ == null)
				cb_pushEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushEvent_Ljava_lang_String_);
			return cb_pushEvent_Ljava_lang_String_;
		}

		static void n_PushEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventName)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventName = JNIEnv.GetString (native_eventName, JniHandleOwnership.DoNotTransfer);
			__this.PushEvent (eventName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='pushEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("pushEvent", "(Ljava/lang/String;)V", "GetPushEvent_Ljava_lang_String_Handler")]
		public virtual unsafe void PushEvent (string eventName)
		{
			const string __id = "pushEvent.(Ljava/lang/String;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
			}
		}

		static Delegate cb_pushEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPushEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_pushEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_pushEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PushEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_pushEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PushEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventName, IntPtr native_eventActions)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventName = JNIEnv.GetString (native_eventName, JniHandleOwnership.DoNotTransfer);
			string eventActions = JNIEnv.GetString (native_eventActions, JniHandleOwnership.DoNotTransfer);
			__this.PushEvent (eventName, eventActions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='pushEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("pushEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPushEvent_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PushEvent (string eventName, string eventActions)
		{
			const string __id = "pushEvent.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native_eventActions = JNIEnv.NewString (eventActions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native_eventActions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native_eventActions);
			}
		}

		static Delegate cb_pushProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPushProfile_Ljava_lang_String_Handler ()
		{
			if (cb_pushProfile_Ljava_lang_String_ == null)
				cb_pushProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushProfile_Ljava_lang_String_);
			return cb_pushProfile_Ljava_lang_String_;
		}

		static void n_PushProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_profile)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string profile = JNIEnv.GetString (native_profile, JniHandleOwnership.DoNotTransfer);
			__this.PushProfile (profile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='pushProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("pushProfile", "(Ljava/lang/String;)V", "GetPushProfile_Ljava_lang_String_Handler")]
		public virtual unsafe void PushProfile (string profile)
		{
			const string __id = "pushProfile.(Ljava/lang/String;)V";
			IntPtr native_profile = JNIEnv.NewString (profile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_profile);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_profile);
			}
		}

		static Delegate cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultiValueForKey (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='removeMultiValueForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMultiValueForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMultiValueForKey (string key, string value)
		{
			const string __id = "removeMultiValueForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string values = JNIEnv.GetString (native_values, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultiValuesForKey (key, values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='removeMultiValuesForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMultiValuesForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveMultiValuesForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMultiValuesForKey (string key, string values)
		{
			const string __id = "removeMultiValuesForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = JNIEnv.NewString (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		static Delegate cb_removeValueForKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveValueForKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeValueForKey_Ljava_lang_String_ == null)
				cb_removeValueForKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveValueForKey_Ljava_lang_String_);
			return cb_removeValueForKey_Ljava_lang_String_;
		}

		static void n_RemoveValueForKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.RemoveValueForKey (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='removeValueForKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeValueForKey", "(Ljava/lang/String;)V", "GetRemoveValueForKey_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveValueForKey (string key)
		{
			const string __id = "removeValueForKey.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_setMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMultiValueForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_setMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			global::Com.Clevertap.Android.Sdk.CTWebInterface __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTWebInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string values = JNIEnv.GetString (native_values, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiValueForKey (key, values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTWebInterface']/method[@name='setMultiValueForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setMultiValueForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMultiValueForKey (string key, string values)
		{
			const string __id = "setMultiValueForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = JNIEnv.NewString (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

	}
}
