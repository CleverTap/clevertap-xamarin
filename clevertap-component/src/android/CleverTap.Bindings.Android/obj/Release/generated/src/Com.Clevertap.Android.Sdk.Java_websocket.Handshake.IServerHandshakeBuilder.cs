using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Handshake {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/interface[@name='ServerHandshakeBuilder']"
	[Register ("com/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder", "", "Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilderInvoker")]
	public partial interface IServerHandshakeBuilder : global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/interface[@name='ServerHandshakeBuilder']/method[@name='setHttpStatus' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setHttpStatus", "(S)V", "GetSetHttpStatus_SHandler:Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilderInvoker, CleverTap.Bindings.Android")]
		void SetHttpStatus (short p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/interface[@name='ServerHandshakeBuilder']/method[@name='setHttpStatusMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHttpStatusMessage", "(Ljava/lang/String;)V", "GetSetHttpStatusMessage_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilderInvoker, CleverTap.Bindings.Android")]
		void SetHttpStatusMessage (string p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder", DoNotGenerateAcw=true)]
	internal partial class IServerHandshakeBuilderInvoker : global::Java.Lang.Object, IServerHandshakeBuilder {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder", typeof (IServerHandshakeBuilderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IServerHandshakeBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServerHandshakeBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.handshake.ServerHandshakeBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServerHandshakeBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setHttpStatus_S;
#pragma warning disable 0169
		static Delegate GetSetHttpStatus_SHandler ()
		{
			if (cb_setHttpStatus_S == null)
				cb_setHttpStatus_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetHttpStatus_S);
			return cb_setHttpStatus_S;
		}

		static void n_SetHttpStatus_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHttpStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_setHttpStatus_S;
		public unsafe void SetHttpStatus (short p0)
		{
			if (id_setHttpStatus_S == IntPtr.Zero)
				id_setHttpStatus_S = JNIEnv.GetMethodID (class_ref, "setHttpStatus", "(S)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHttpStatus_S, __args);
		}

		static Delegate cb_setHttpStatusMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHttpStatusMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setHttpStatusMessage_Ljava_lang_String_ == null)
				cb_setHttpStatusMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHttpStatusMessage_Ljava_lang_String_);
			return cb_setHttpStatusMessage_Ljava_lang_String_;
		}

		static void n_SetHttpStatusMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHttpStatusMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_setHttpStatusMessage_Ljava_lang_String_;
		public unsafe void SetHttpStatusMessage (string p0)
		{
			if (id_setHttpStatusMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setHttpStatusMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHttpStatusMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHttpStatusMessage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setContent_arrayB;
#pragma warning disable 0169
		static Delegate GetSetContent_arrayBHandler ()
		{
			if (cb_setContent_arrayB == null)
				cb_setContent_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_arrayB);
			return cb_setContent_arrayB;
		}

		static void n_SetContent_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetContent (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setContent_arrayB;
		public unsafe void SetContent (byte[] p0)
		{
			if (id_setContent_arrayB == IntPtr.Zero)
				id_setContent_arrayB = JNIEnv.GetMethodID (class_ref, "setContent", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContent_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetContent ());
		}
#pragma warning restore 0169

		IntPtr id_getContent;
		public unsafe byte[] GetContent ()
		{
			if (id_getContent == IntPtr.Zero)
				id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_getFieldValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFieldValue_Ljava_lang_String_Handler ()
		{
			if (cb_getFieldValue_Ljava_lang_String_ == null)
				cb_getFieldValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFieldValue_Ljava_lang_String_);
			return cb_getFieldValue_Ljava_lang_String_;
		}

		static IntPtr n_GetFieldValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFieldValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFieldValue_Ljava_lang_String_;
		public unsafe string GetFieldValue (string p0)
		{
			if (id_getFieldValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getFieldValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFieldValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFieldValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_hasFieldValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasFieldValue_Ljava_lang_String_Handler ()
		{
			if (cb_hasFieldValue_Ljava_lang_String_ == null)
				cb_hasFieldValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasFieldValue_Ljava_lang_String_);
			return cb_hasFieldValue_Ljava_lang_String_;
		}

		static bool n_HasFieldValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasFieldValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_hasFieldValue_Ljava_lang_String_;
		public unsafe bool HasFieldValue (string p0)
		{
			if (id_hasFieldValue_Ljava_lang_String_ == IntPtr.Zero)
				id_hasFieldValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasFieldValue", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFieldValue_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IterateHttpFields ());
		}
#pragma warning restore 0169

		IntPtr id_iterateHttpFields;
		public unsafe global::Java.Util.IIterator IterateHttpFields ()
		{
			if (id_iterateHttpFields == IntPtr.Zero)
				id_iterateHttpFields = JNIEnv.GetMethodID (class_ref, "iterateHttpFields", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterateHttpFields), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getHttpStatus;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusHandler ()
		{
			if (cb_getHttpStatus == null)
				cb_getHttpStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetHttpStatus);
			return cb_getHttpStatus;
		}

		static short n_GetHttpStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHttpStatus ();
		}
#pragma warning restore 0169

		IntPtr id_getHttpStatus;
		public unsafe short GetHttpStatus ()
		{
			if (id_getHttpStatus == IntPtr.Zero)
				id_getHttpStatus = JNIEnv.GetMethodID (class_ref, "getHttpStatus", "()S");
			return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getHttpStatus);
		}

		static Delegate cb_getHttpStatusMessage;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusMessageHandler ()
		{
			if (cb_getHttpStatusMessage == null)
				cb_getHttpStatusMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHttpStatusMessage);
			return cb_getHttpStatusMessage;
		}

		static IntPtr n_GetHttpStatusMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetHttpStatusMessage ());
		}
#pragma warning restore 0169

		IntPtr id_getHttpStatusMessage;
		public unsafe string GetHttpStatusMessage ()
		{
			if (id_getHttpStatusMessage == IntPtr.Zero)
				id_getHttpStatusMessage = JNIEnv.GetMethodID (class_ref, "getHttpStatusMessage", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHttpStatusMessage), JniHandleOwnership.TransferLocalRef);
		}

	}

}
