using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Handshake {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Server']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/handshake/HandshakeImpl1Server", DoNotGenerateAcw=true)]
	public partial class HandshakeImpl1Server : global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/handshake/HandshakeImpl1Server", typeof (HandshakeImpl1Server));
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

		protected HandshakeImpl1Server (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Server']/constructor[@name='HandshakeImpl1Server' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandshakeImpl1Server ()
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHttpStatus ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Server']/method[@name='getHttpStatus' and count(parameter)=0]"
		[Register ("getHttpStatus", "()S", "GetGetHttpStatusHandler")]
		public virtual unsafe short GetHttpStatus ()
		{
			const string __id = "getHttpStatus.()S";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
				return __rm;
			} finally {
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetHttpStatusMessage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Server']/method[@name='getHttpStatusMessage' and count(parameter)=0]"
		[Register ("getHttpStatusMessage", "()Ljava/lang/String;", "GetGetHttpStatusMessageHandler")]
		public virtual unsafe string GetHttpStatusMessage ()
		{
			const string __id = "getHttpStatusMessage.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHttpStatus_S;
#pragma warning disable 0169
		static Delegate GetSetHttpStatus_SHandler ()
		{
			if (cb_setHttpStatus_S == null)
				cb_setHttpStatus_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetHttpStatus_S);
			return cb_setHttpStatus_S;
		}

		static void n_SetHttpStatus_S (IntPtr jnienv, IntPtr native__this, short status)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHttpStatus (status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Server']/method[@name='setHttpStatus' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setHttpStatus", "(S)V", "GetSetHttpStatus_SHandler")]
		public virtual unsafe void SetHttpStatus (short status)
		{
			const string __id = "setHttpStatus.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (status);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHttpStatusMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHttpStatusMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setHttpStatusMessage_Ljava_lang_String_ == null)
				cb_setHttpStatusMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHttpStatusMessage_Ljava_lang_String_);
			return cb_setHttpStatusMessage_Ljava_lang_String_;
		}

		static void n_SetHttpStatusMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Server> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.SetHttpStatusMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Server']/method[@name='setHttpStatusMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHttpStatusMessage", "(Ljava/lang/String;)V", "GetSetHttpStatusMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHttpStatusMessage (string message)
		{
			const string __id = "setHttpStatusMessage.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
