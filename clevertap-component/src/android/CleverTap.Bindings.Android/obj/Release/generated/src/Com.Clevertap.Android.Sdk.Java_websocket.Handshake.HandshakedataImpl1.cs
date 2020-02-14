using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Handshake {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/handshake/HandshakedataImpl1", DoNotGenerateAcw=true)]
	public partial class HandshakedataImpl1 : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/handshake/HandshakedataImpl1", typeof (HandshakedataImpl1));
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

		protected HandshakedataImpl1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/constructor[@name='HandshakedataImpl1' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandshakedataImpl1 ()
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

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetContent ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/method[@name='getContent' and count(parameter)=0]"
		[Register ("getContent", "()[B", "GetGetContentHandler")]
		public virtual unsafe byte[] GetContent ()
		{
			const string __id = "getContent.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getFieldValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFieldValue_Ljava_lang_String_Handler ()
		{
			if (cb_getFieldValue_Ljava_lang_String_ == null)
				cb_getFieldValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFieldValue_Ljava_lang_String_);
			return cb_getFieldValue_Ljava_lang_String_;
		}

		static IntPtr n_GetFieldValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFieldValue (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/method[@name='getFieldValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFieldValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetFieldValue_Ljava_lang_String_Handler")]
		public virtual unsafe string GetFieldValue (string name)
		{
			const string __id = "getFieldValue.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_hasFieldValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasFieldValue_Ljava_lang_String_Handler ()
		{
			if (cb_hasFieldValue_Ljava_lang_String_ == null)
				cb_hasFieldValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasFieldValue_Ljava_lang_String_);
			return cb_hasFieldValue_Ljava_lang_String_;
		}

		static bool n_HasFieldValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasFieldValue (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/method[@name='hasFieldValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasFieldValue", "(Ljava/lang/String;)Z", "GetHasFieldValue_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasFieldValue (string name)
		{
			const string __id = "hasFieldValue.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_iterateHttpFields;
#pragma warning disable 0169
		static Delegate GetIterateHttpFieldsHandler ()
		{
			if (cb_iterateHttpFields == null)
				cb_iterateHttpFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IterateHttpFields);
			return cb_iterateHttpFields;
		}

		static IntPtr n_IterateHttpFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IterateHttpFields ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/method[@name='iterateHttpFields' and count(parameter)=0]"
		[Register ("iterateHttpFields", "()Ljava/util/Iterator;", "GetIterateHttpFieldsHandler")]
		public virtual unsafe global::Java.Util.IIterator IterateHttpFields ()
		{
			const string __id = "iterateHttpFields.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_value)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Put (name, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Put (string name, string value)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setContent_arrayB;
#pragma warning disable 0169
		static Delegate GetSetContent_arrayBHandler ()
		{
			if (cb_setContent_arrayB == null)
				cb_setContent_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_arrayB);
			return cb_setContent_arrayB;
		}

		static void n_SetContent_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_content)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] content = (byte[]) JNIEnv.GetArray (native_content, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetContent (content);
			if (content != null)
				JNIEnv.CopyArray (content, native_content);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakedataImpl1']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setContent", "([B)V", "GetSetContent_arrayBHandler")]
		public virtual unsafe void SetContent (byte[] content)
		{
			const string __id = "setContent.([B)V";
			IntPtr native_content = JNIEnv.NewArray (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_content);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (content != null) {
					JNIEnv.CopyArray (native_content, content);
					JNIEnv.DeleteLocalRef (native_content);
				}
			}
		}

	}
}
