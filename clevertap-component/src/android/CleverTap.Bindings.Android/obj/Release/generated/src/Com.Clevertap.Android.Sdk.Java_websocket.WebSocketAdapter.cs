using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WebSocketAdapter", DoNotGenerateAcw=true)]
	public abstract partial class WebSocketAdapter : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WebSocketAdapter", typeof (WebSocketAdapter));
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

		protected WebSocketAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']/constructor[@name='WebSocketAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebSocketAdapter ()
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

		static Delegate cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler ()
		{
			if (cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ == null)
				cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_);
			return cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
		}

		static void n_OnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, IntPtr native_request, IntPtr native_response)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake response = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (native_response, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketHandshakeReceivedAsClient (conn, request, response);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']/method[@name='onWebsocketHandshakeReceivedAsClient' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[3][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("onWebsocketHandshakeReceivedAsClient", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V", "GetOnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler")]
		public virtual unsafe void OnWebsocketHandshakeReceivedAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake response)
		{
			const string __id = "onWebsocketHandshakeReceivedAsClient.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [2] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler ()
		{
			if (cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == null)
				cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_);
			return cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		}

		static IntPtr n_OnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, IntPtr native_draft, IntPtr native_request)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft draft = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (native_draft, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWebsocketHandshakeReceivedAsServer (conn, draft, request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']/method[@name='onWebsocketHandshakeReceivedAsServer' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft'] and parameter[3][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("onWebsocketHandshakeReceivedAsServer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;", "GetOnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder OnWebsocketHandshakeReceivedAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft draft, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request)
		{
			const string __id = "onWebsocketHandshakeReceivedAsServer.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((draft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draft).Handle);
				__args [2] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler ()
		{
			if (cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == null)
				cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_);
			return cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		}

		static void n_OnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, IntPtr native_request)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketHandshakeSentAsClient (conn, request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']/method[@name='onWebsocketHandshakeSentAsClient' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("onWebsocketHandshakeSentAsClient", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)V", "GetOnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler")]
		public virtual unsafe void OnWebsocketHandshakeSentAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request)
		{
			const string __id = "onWebsocketHandshakeSentAsClient.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_OnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, IntPtr native_f)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata f = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketPing (conn, f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']/method[@name='onWebsocketPing' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("onWebsocketPing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetOnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void OnWebsocketPing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata f)
		{
			const string __id = "onWebsocketPing.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_OnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, IntPtr native_f)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata f = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketPong (conn, f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketAdapter']/method[@name='onWebsocketPong' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("onWebsocketPong", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetOnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void OnWebsocketPong (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata f)
		{
			const string __id = "onWebsocketPong.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
#pragma warning disable 0169
		static Delegate GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler ()
		{
			if (cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == null)
				cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_);
			return cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		}

		static IntPtr n_GetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalSocketAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='getLocalSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getLocalSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public abstract global::Java.Net.InetSocketAddress GetLocalSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

		static Delegate cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
#pragma warning disable 0169
		static Delegate GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler ()
		{
			if (cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == null)
				cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_);
			return cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		}

		static IntPtr n_GetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRemoteSocketAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='getRemoteSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getRemoteSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public abstract global::Java.Net.InetSocketAddress GetRemoteSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

		static Delegate cb_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler ()
		{
			if (cb_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z == null)
				cb_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z);
			return cb_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
		}

		static void n_OnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, bool p3)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketClose (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketClose' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClose", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler")]
		public abstract void OnWebsocketClose (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3);

		static Delegate cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler ()
		{
			if (cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ == null)
				cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_);
			return cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_;
		}

		static void n_OnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketCloseInitiated (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketCloseInitiated' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onWebsocketCloseInitiated", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V", "GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler")]
		public abstract void OnWebsocketCloseInitiated (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2);

		static Delegate cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler ()
		{
			if (cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z == null)
				cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z);
			return cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
		}

		static void n_OnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, bool p3)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketClosing (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketClosing' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClosing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler")]
		public abstract void OnWebsocketClosing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3);

		static Delegate cb_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_Handler ()
		{
			if (cb_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_ == null)
				cb_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_);
			return cb_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_;
		}

		static void n_OnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketError (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketError' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onWebsocketError", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V", "GetOnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_Handler")]
		public abstract void OnWebsocketError (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Lang.Exception p1);

		static Delegate cb_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_Handler ()
		{
			if (cb_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_ == null)
				cb_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_);
			return cb_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_;
		}

		static void n_OnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketMessage' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("onWebsocketMessage", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V", "GetOnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_Handler")]
		public abstract void OnWebsocketMessage (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, string p1);

		static Delegate cb_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_ == null)
				cb_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_);
			return cb_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_;
		}

		static void n_OnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketMessageBuffer (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketMessageBuffer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("onWebsocketMessageBuffer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V", "GetOnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_Handler")]
		public abstract void OnWebsocketMessageBuffer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Nio.ByteBuffer p1);

		static Delegate cb_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler ()
		{
			if (cb_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ == null)
				cb_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_);
			return cb_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
		}

		static void n_OnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketOpen (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketOpen' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata']]"
		[Register ("onWebsocketOpen", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V", "GetOnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler")]
		public abstract void OnWebsocketOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1);

		static Delegate cb_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
#pragma warning disable 0169
		static Delegate GetOnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler ()
		{
			if (cb_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == null)
				cb_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_);
			return cb_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		}

		static void n_OnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnWriteDemand (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWriteDemand' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("onWriteDemand", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V", "GetOnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public abstract void OnWriteDemand (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WebSocketAdapter", DoNotGenerateAcw=true)]
	internal partial class WebSocketAdapterInvoker : WebSocketAdapter {

		public WebSocketAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WebSocketAdapter", typeof (WebSocketAdapterInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='getLocalSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getLocalSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public override unsafe global::Java.Net.InetSocketAddress GetLocalSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			const string __id = "getLocalSocketAddress.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='getRemoteSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getRemoteSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public override unsafe global::Java.Net.InetSocketAddress GetRemoteSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			const string __id = "getRemoteSocketAddress.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketClose' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClose", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler")]
		public override unsafe void OnWebsocketClose (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			const string __id = "onWebsocketClose.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketCloseInitiated' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onWebsocketCloseInitiated", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V", "GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler")]
		public override unsafe void OnWebsocketCloseInitiated (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2)
		{
			const string __id = "onWebsocketCloseInitiated.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketClosing' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClosing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler")]
		public override unsafe void OnWebsocketClosing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			const string __id = "onWebsocketClosing.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketError' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onWebsocketError", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V", "GetOnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_Handler")]
		public override unsafe void OnWebsocketError (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Lang.Exception p1)
		{
			const string __id = "onWebsocketError.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketMessage' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("onWebsocketMessage", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V", "GetOnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_Handler")]
		public override unsafe void OnWebsocketMessage (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, string p1)
		{
			const string __id = "onWebsocketMessage.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketMessageBuffer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("onWebsocketMessageBuffer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V", "GetOnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe void OnWebsocketMessageBuffer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Nio.ByteBuffer p1)
		{
			const string __id = "onWebsocketMessageBuffer.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketOpen' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata']]"
		[Register ("onWebsocketOpen", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V", "GetOnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler")]
		public override unsafe void OnWebsocketOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1)
		{
			const string __id = "onWebsocketOpen.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWriteDemand' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("onWriteDemand", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V", "GetOnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public override unsafe void OnWriteDemand (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			const string __id = "onWriteDemand.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
