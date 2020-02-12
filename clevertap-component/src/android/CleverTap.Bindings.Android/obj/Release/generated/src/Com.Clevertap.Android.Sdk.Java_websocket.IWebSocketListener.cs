using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']"
	[Register ("com/clevertap/android/sdk/java_websocket/WebSocketListener", "", "Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker")]
	public partial interface IWebSocketListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='getLocalSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getLocalSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		global::Java.Net.InetSocketAddress GetLocalSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='getRemoteSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getRemoteSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		global::Java.Net.InetSocketAddress GetRemoteSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketClose' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClose", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketClose (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketCloseInitiated' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onWebsocketCloseInitiated", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V", "GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketCloseInitiated (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketClosing' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClosing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketClosing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketError' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onWebsocketError", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V", "GetOnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketError (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketHandshakeReceivedAsClient' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[3][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("onWebsocketHandshakeReceivedAsClient", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V", "GetOnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketHandshakeReceivedAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketHandshakeReceivedAsServer' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft'] and parameter[3][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("onWebsocketHandshakeReceivedAsServer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;", "GetOnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder OnWebsocketHandshakeReceivedAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketHandshakeSentAsClient' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("onWebsocketHandshakeSentAsClient", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)V", "GetOnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketHandshakeSentAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketMessage' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("onWebsocketMessage", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V", "GetOnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketMessage (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketMessageBuffer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("onWebsocketMessageBuffer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V", "GetOnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketMessageBuffer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Nio.ByteBuffer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketOpen' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata']]"
		[Register ("onWebsocketOpen", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V", "GetOnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketPing' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("onWebsocketPing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetOnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketPing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWebsocketPong' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("onWebsocketPong", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetOnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWebsocketPong (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketListener']/method[@name='onWriteDemand' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("onWriteDemand", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V", "GetOnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android")]
		void OnWriteDemand (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WebSocketListener", DoNotGenerateAcw=true)]
	internal partial class IWebSocketListenerInvoker : global::Java.Lang.Object, IWebSocketListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WebSocketListener", typeof (IWebSocketListenerInvoker));

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

		public static IWebSocketListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocketListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.WebSocketListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalSocketAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		public unsafe global::Java.Net.InetSocketAddress GetLocalSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			if (id_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == IntPtr.Zero)
				id_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNIEnv.GetMethodID (class_ref, "getLocalSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Java.Net.InetSocketAddress __ret = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRemoteSocketAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		public unsafe global::Java.Net.InetSocketAddress GetRemoteSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			if (id_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == IntPtr.Zero)
				id_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNIEnv.GetMethodID (class_ref, "getRemoteSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Java.Net.InetSocketAddress __ret = global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketClose (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
		public unsafe void OnWebsocketClose (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			if (id_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z == IntPtr.Zero)
				id_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onWebsocketClose", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketCloseInitiated (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_;
		public unsafe void OnWebsocketCloseInitiated (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2)
		{
			if (id_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ == IntPtr.Zero)
				id_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebsocketCloseInitiated", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketClosing (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
		public unsafe void OnWebsocketClosing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			if (id_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z == IntPtr.Zero)
				id_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onWebsocketClosing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_;
		public unsafe void OnWebsocketError (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Lang.Exception p1)
		{
			if (id_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onWebsocketError", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler ()
		{
			if (cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ == null)
				cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_);
			return cb_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
		}

		static void n_OnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p2 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketHandshakeReceivedAsClient (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
		public unsafe void OnWebsocketHandshakeReceivedAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p2)
		{
			if (id_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ == IntPtr.Zero)
				id_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ = JNIEnv.GetMethodID (class_ref, "onWebsocketHandshakeReceivedAsClient", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_, __args);
		}

		static Delegate cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler ()
		{
			if (cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == null)
				cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_);
			return cb_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		}

		static IntPtr n_OnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p2 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnWebsocketHandshakeReceivedAsServer (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder OnWebsocketHandshakeReceivedAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p2)
		{
			if (id_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == IntPtr.Zero)
				id_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNIEnv.GetMethodID (class_ref, "onWebsocketHandshakeReceivedAsServer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler ()
		{
			if (cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == null)
				cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_);
			return cb_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		}

		static void n_OnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketHandshakeSentAsClient (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		public unsafe void OnWebsocketHandshakeSentAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1)
		{
			if (id_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == IntPtr.Zero)
				id_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNIEnv.GetMethodID (class_ref, "onWebsocketHandshakeSentAsClient", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_, __args);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_;
		public unsafe void OnWebsocketMessage (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, string p1)
		{
			if (id_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_ == IntPtr.Zero)
				id_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onWebsocketMessage", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketMessageBuffer (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_;
		public unsafe void OnWebsocketMessageBuffer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Nio.ByteBuffer p1)
		{
			if (id_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "onWebsocketMessageBuffer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_, __args);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketOpen (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
		public unsafe void OnWebsocketOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1)
		{
			if (id_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ == IntPtr.Zero)
				id_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ = JNIEnv.GetMethodID (class_ref, "onWebsocketOpen", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_, __args);
		}

		static Delegate cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_OnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketPing (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void OnWebsocketPing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			if (id_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "onWebsocketPing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

		static Delegate cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_OnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketPong (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void OnWebsocketPong (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			if (id_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "onWebsocketPong", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnWriteDemand (p0);
		}
#pragma warning restore 0169

		IntPtr id_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		public unsafe void OnWriteDemand (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			if (id_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == IntPtr.Zero)
				id_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNIEnv.GetMethodID (class_ref, "onWriteDemand", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_, __args);
		}

	}

	public delegate global::Java.Net.InetSocketAddress WebSocketGetLocalSocketAddressHandler (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

	public delegate global::Java.Net.InetSocketAddress WebSocketGetRemoteSocketAddressHandler (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0);

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketClose
	public partial class WebsocketCloseEventArgs : global::System.EventArgs {

		public WebsocketCloseEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		bool p3;
		public bool P3 {
			get { return p3; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketCloseInitiated
	public partial class WebsocketCloseInitiatedEventArgs : global::System.EventArgs {

		public WebsocketCloseInitiatedEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketClosing
	public partial class WebsocketClosingEventArgs : global::System.EventArgs {

		public WebsocketClosingEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		bool p3;
		public bool P3 {
			get { return p3; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketError
	public partial class WebsocketErrorEventArgs : global::System.EventArgs {

		public WebsocketErrorEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Lang.Exception p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Java.Lang.Exception p1;
		public global::Java.Lang.Exception P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketHandshakeReceivedAsClient
	public partial class WebsocketHandshakeReceivedAsClientEventArgs : global::System.EventArgs {

		public WebsocketHandshakeReceivedAsClientEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake P1 {
			get { return p1; }
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p2;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake P2 {
			get { return p2; }
		}
	}

	public delegate global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder WebSocketOnWebsocketHandshakeReceivedAsServerHandler (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p2);

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketHandshakeSentAsClient
	public partial class WebsocketHandshakeSentAsClientEventArgs : global::System.EventArgs {

		public WebsocketHandshakeSentAsClientEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketMessage
	public partial class WebsocketMessageEventArgs : global::System.EventArgs {

		public WebsocketMessageEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketMessageBuffer
	public partial class WebsocketMessageBufferEventArgs : global::System.EventArgs {

		public WebsocketMessageBufferEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Nio.ByteBuffer p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Java.Nio.ByteBuffer p1;
		public global::Java.Nio.ByteBuffer P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketOpen
	public partial class WebsocketOpenEventArgs : global::System.EventArgs {

		public WebsocketOpenEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketPing
	public partial class WebsocketPingEventArgs : global::System.EventArgs {

		public WebsocketPingEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWebsocketPong
	public partial class WebsocketPongEventArgs : global::System.EventArgs {

		public WebsocketPongEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata P1 {
			get { return p1; }
		}
	}

	// event args for com.clevertap.android.sdk.java_websocket.WebSocketListener.onWriteDemand
	public partial class WriteDemandEventArgs : global::System.EventArgs {

		public WriteDemandEventArgs (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			this.p0 = p0;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0;
		public global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/java_websocket/WebSocketListenerImplementor")]
	internal sealed partial class IWebSocketListenerImplementor : global::Java.Lang.Object, IWebSocketListener {

		object sender;

		public IWebSocketListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/java_websocket/WebSocketListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public WebSocketGetLocalSocketAddressHandler GetLocalSocketAddressHandler;
#pragma warning restore 0649

		public Java.Net.InetSocketAddress GetLocalSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			var __h = GetLocalSocketAddressHandler;
			return __h != null ? __h (p0) : default (global::Java.Net.InetSocketAddress);
		}
#pragma warning disable 0649
		public WebSocketGetRemoteSocketAddressHandler GetRemoteSocketAddressHandler;
#pragma warning restore 0649

		public Java.Net.InetSocketAddress GetRemoteSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			var __h = GetRemoteSocketAddressHandler;
			return __h != null ? __h (p0) : default (global::Java.Net.InetSocketAddress);
		}
#pragma warning disable 0649
		public EventHandler<WebsocketCloseEventArgs> OnWebsocketCloseHandler;
#pragma warning restore 0649

		public void OnWebsocketClose (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			var __h = OnWebsocketCloseHandler;
			if (__h != null)
				__h (sender, new WebsocketCloseEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketCloseInitiatedEventArgs> OnWebsocketCloseInitiatedHandler;
#pragma warning restore 0649

		public void OnWebsocketCloseInitiated (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2)
		{
			var __h = OnWebsocketCloseInitiatedHandler;
			if (__h != null)
				__h (sender, new WebsocketCloseInitiatedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketClosingEventArgs> OnWebsocketClosingHandler;
#pragma warning restore 0649

		public void OnWebsocketClosing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, int p1, string p2, bool p3)
		{
			var __h = OnWebsocketClosingHandler;
			if (__h != null)
				__h (sender, new WebsocketClosingEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketErrorEventArgs> OnWebsocketErrorHandler;
#pragma warning restore 0649

		public void OnWebsocketError (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Lang.Exception p1)
		{
			var __h = OnWebsocketErrorHandler;
			if (__h != null)
				__h (sender, new WebsocketErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketHandshakeReceivedAsClientEventArgs> OnWebsocketHandshakeReceivedAsClientHandler;
#pragma warning restore 0649

		public void OnWebsocketHandshakeReceivedAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p2)
		{
			var __h = OnWebsocketHandshakeReceivedAsClientHandler;
			if (__h != null)
				__h (sender, new WebsocketHandshakeReceivedAsClientEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public WebSocketOnWebsocketHandshakeReceivedAsServerHandler OnWebsocketHandshakeReceivedAsServerHandler;
#pragma warning restore 0649

		public Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder OnWebsocketHandshakeReceivedAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p2)
		{
			var __h = OnWebsocketHandshakeReceivedAsServerHandler;
			return __h != null ? __h (p0, p1, p2) : default (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder);
		}
#pragma warning disable 0649
		public EventHandler<WebsocketHandshakeSentAsClientEventArgs> OnWebsocketHandshakeSentAsClientHandler;
#pragma warning restore 0649

		public void OnWebsocketHandshakeSentAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p1)
		{
			var __h = OnWebsocketHandshakeSentAsClientHandler;
			if (__h != null)
				__h (sender, new WebsocketHandshakeSentAsClientEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketMessageEventArgs> OnWebsocketMessageHandler;
#pragma warning restore 0649

		public void OnWebsocketMessage (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, string p1)
		{
			var __h = OnWebsocketMessageHandler;
			if (__h != null)
				__h (sender, new WebsocketMessageEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketMessageBufferEventArgs> OnWebsocketMessageBufferHandler;
#pragma warning restore 0649

		public void OnWebsocketMessageBuffer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Java.Nio.ByteBuffer p1)
		{
			var __h = OnWebsocketMessageBufferHandler;
			if (__h != null)
				__h (sender, new WebsocketMessageBufferEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketOpenEventArgs> OnWebsocketOpenHandler;
#pragma warning restore 0649

		public void OnWebsocketOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata p1)
		{
			var __h = OnWebsocketOpenHandler;
			if (__h != null)
				__h (sender, new WebsocketOpenEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketPingEventArgs> OnWebsocketPingHandler;
#pragma warning restore 0649

		public void OnWebsocketPing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			var __h = OnWebsocketPingHandler;
			if (__h != null)
				__h (sender, new WebsocketPingEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WebsocketPongEventArgs> OnWebsocketPongHandler;
#pragma warning restore 0649

		public void OnWebsocketPong (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			var __h = OnWebsocketPongHandler;
			if (__h != null)
				__h (sender, new WebsocketPongEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WriteDemandEventArgs> OnWriteDemandHandler;
#pragma warning restore 0649

		public void OnWriteDemand (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket p0)
		{
			var __h = OnWriteDemandHandler;
			if (__h != null)
				__h (sender, new WriteDemandEventArgs (p0));
		}

		internal static bool __IsEmpty (IWebSocketListenerImplementor value)
		{
			return value.GetLocalSocketAddressHandler == null && value.GetRemoteSocketAddressHandler == null && value.OnWebsocketCloseHandler == null && value.OnWebsocketCloseInitiatedHandler == null && value.OnWebsocketClosingHandler == null && value.OnWebsocketErrorHandler == null && value.OnWebsocketHandshakeReceivedAsClientHandler == null && value.OnWebsocketHandshakeReceivedAsServerHandler == null && value.OnWebsocketHandshakeSentAsClientHandler == null && value.OnWebsocketMessageHandler == null && value.OnWebsocketMessageBufferHandler == null && value.OnWebsocketOpenHandler == null && value.OnWebsocketPingHandler == null && value.OnWebsocketPongHandler == null && value.OnWriteDemandHandler == null;
		}
	}

}
