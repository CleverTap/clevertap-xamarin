using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/AbstractWebSocket", DoNotGenerateAcw=true)]
	public abstract partial class AbstractWebSocket : global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/AbstractWebSocket", typeof (AbstractWebSocket));
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

		protected AbstractWebSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/constructor[@name='AbstractWebSocket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractWebSocket ()
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

		static Delegate cb_getConnectionLostTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectionLostTimeoutHandler ()
		{
			if (cb_getConnectionLostTimeout == null)
				cb_getConnectionLostTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectionLostTimeout);
			return cb_getConnectionLostTimeout;
		}

		static int n_GetConnectionLostTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectionLostTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectionLostTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectionLostTimeout_IHandler ()
		{
			if (cb_setConnectionLostTimeout_I == null)
				cb_setConnectionLostTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectionLostTimeout_I);
			return cb_setConnectionLostTimeout_I;
		}

		static void n_SetConnectionLostTimeout_I (IntPtr jnienv, IntPtr native__this, int connectionLostTimeout)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLostTimeout = connectionLostTimeout;
		}
#pragma warning restore 0169

		public virtual unsafe int ConnectionLostTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='getConnectionLostTimeout' and count(parameter)=0]"
			[Register ("getConnectionLostTimeout", "()I", "GetGetConnectionLostTimeoutHandler")]
			get {
				const string __id = "getConnectionLostTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='setConnectionLostTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectionLostTimeout", "(I)V", "GetSetConnectionLostTimeout_IHandler")]
			set {
				const string __id = "setConnectionLostTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnections;
#pragma warning disable 0169
		static Delegate GetGetConnectionsHandler ()
		{
			if (cb_getConnections == null)
				cb_getConnections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnections);
			return cb_getConnections;
		}

		static IntPtr n_GetConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket>.ToLocalJniHandle (__this.Connections);
		}
#pragma warning restore 0169

		protected abstract global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> Connections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='getConnections' and count(parameter)=0]"
			[Register ("getConnections", "()Ljava/util/Collection;", "GetGetConnectionsHandler")] get;
		}

		static Delegate cb_isReuseAddr;
#pragma warning disable 0169
		static Delegate GetIsReuseAddrHandler ()
		{
			if (cb_isReuseAddr == null)
				cb_isReuseAddr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReuseAddr);
			return cb_isReuseAddr;
		}

		static bool n_IsReuseAddr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReuseAddr;
		}
#pragma warning restore 0169

		static Delegate cb_setReuseAddr_Z;
#pragma warning disable 0169
		static Delegate GetSetReuseAddr_ZHandler ()
		{
			if (cb_setReuseAddr_Z == null)
				cb_setReuseAddr_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReuseAddr_Z);
			return cb_setReuseAddr_Z;
		}

		static void n_SetReuseAddr_Z (IntPtr jnienv, IntPtr native__this, bool reuseAddr)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReuseAddr = reuseAddr;
		}
#pragma warning restore 0169

		public virtual unsafe bool ReuseAddr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='isReuseAddr' and count(parameter)=0]"
			[Register ("isReuseAddr", "()Z", "GetIsReuseAddrHandler")]
			get {
				const string __id = "isReuseAddr.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='setReuseAddr' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReuseAddr", "(Z)V", "GetSetReuseAddr_ZHandler")]
			set {
				const string __id = "setReuseAddr.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTcpNoDelay;
#pragma warning disable 0169
		static Delegate GetIsTcpNoDelayHandler ()
		{
			if (cb_isTcpNoDelay == null)
				cb_isTcpNoDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTcpNoDelay);
			return cb_isTcpNoDelay;
		}

		static bool n_IsTcpNoDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TcpNoDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setTcpNoDelay_Z;
#pragma warning disable 0169
		static Delegate GetSetTcpNoDelay_ZHandler ()
		{
			if (cb_setTcpNoDelay_Z == null)
				cb_setTcpNoDelay_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTcpNoDelay_Z);
			return cb_setTcpNoDelay_Z;
		}

		static void n_SetTcpNoDelay_Z (IntPtr jnienv, IntPtr native__this, bool tcpNoDelay)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TcpNoDelay = tcpNoDelay;
		}
#pragma warning restore 0169

		public virtual unsafe bool TcpNoDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='isTcpNoDelay' and count(parameter)=0]"
			[Register ("isTcpNoDelay", "()Z", "GetIsTcpNoDelayHandler")]
			get {
				const string __id = "isTcpNoDelay.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='setTcpNoDelay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTcpNoDelay", "(Z)V", "GetSetTcpNoDelay_ZHandler")]
			set {
				const string __id = "setTcpNoDelay.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_startConnectionLostTimer;
#pragma warning disable 0169
		static Delegate GetStartConnectionLostTimerHandler ()
		{
			if (cb_startConnectionLostTimer == null)
				cb_startConnectionLostTimer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartConnectionLostTimer);
			return cb_startConnectionLostTimer;
		}

		static void n_StartConnectionLostTimer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartConnectionLostTimer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='startConnectionLostTimer' and count(parameter)=0]"
		[Register ("startConnectionLostTimer", "()V", "GetStartConnectionLostTimerHandler")]
		protected virtual unsafe void StartConnectionLostTimer ()
		{
			const string __id = "startConnectionLostTimer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopConnectionLostTimer;
#pragma warning disable 0169
		static Delegate GetStopConnectionLostTimerHandler ()
		{
			if (cb_stopConnectionLostTimer == null)
				cb_stopConnectionLostTimer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopConnectionLostTimer);
			return cb_stopConnectionLostTimer;
		}

		static void n_StopConnectionLostTimer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopConnectionLostTimer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='stopConnectionLostTimer' and count(parameter)=0]"
		[Register ("stopConnectionLostTimer", "()V", "GetStopConnectionLostTimerHandler")]
		protected virtual unsafe void StopConnectionLostTimer ()
		{
			const string __id = "stopConnectionLostTimer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/AbstractWebSocket", DoNotGenerateAcw=true)]
	internal partial class AbstractWebSocketInvoker : AbstractWebSocket {

		public AbstractWebSocketInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/AbstractWebSocket", typeof (AbstractWebSocketInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> Connections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='AbstractWebSocket']/method[@name='getConnections' and count(parameter)=0]"
			[Register ("getConnections", "()Ljava/util/Collection;", "GetGetConnectionsHandler")]
			get {
				const string __id = "getConnections.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
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
