using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/SSLSocketChannel2", DoNotGenerateAcw=true)]
	public partial class SSLSocketChannel2 : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel, global::Java.Nio.Channels.IByteChannel {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='bufferallocations']"
		[Register ("bufferallocations")]
		protected int Bufferallocations {
			get {
				const string __id = "bufferallocations.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bufferallocations.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='emptybuffer']"
		[Register ("emptybuffer")]
		protected static global::Java.Nio.ByteBuffer Emptybuffer {
			get {
				const string __id = "emptybuffer.Ljava/nio/ByteBuffer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "emptybuffer.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='exec']"
		[Register ("exec")]
		protected global::Java.Util.Concurrent.IExecutorService Exec {
			get {
				const string __id = "exec.Ljava/util/concurrent/ExecutorService;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "exec.Ljava/util/concurrent/ExecutorService;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='inCrypt']"
		[Register ("inCrypt")]
		protected global::Java.Nio.ByteBuffer InCrypt {
			get {
				const string __id = "inCrypt.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inCrypt.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='inData']"
		[Register ("inData")]
		protected global::Java.Nio.ByteBuffer InData {
			get {
				const string __id = "inData.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inData.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='outCrypt']"
		[Register ("outCrypt")]
		protected global::Java.Nio.ByteBuffer OutCrypt {
			get {
				const string __id = "outCrypt.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outCrypt.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='readEngineResult']"
		[Register ("readEngineResult")]
		protected global::Javax.Net.Ssl.SSLEngineResult ReadEngineResult {
			get {
				const string __id = "readEngineResult.Ljavax/net/ssl/SSLEngineResult;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngineResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "readEngineResult.Ljavax/net/ssl/SSLEngineResult;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='selectionKey']"
		[Register ("selectionKey")]
		protected global::Java.Nio.Channels.SelectionKey SelectionKey {
			get {
				const string __id = "selectionKey.Ljava/nio/channels/SelectionKey;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.SelectionKey> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "selectionKey.Ljava/nio/channels/SelectionKey;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='socketChannel']"
		[Register ("socketChannel")]
		protected global::Java.Nio.Channels.SocketChannel SocketChannel {
			get {
				const string __id = "socketChannel.Ljava/nio/channels/SocketChannel;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.SocketChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "socketChannel.Ljava/nio/channels/SocketChannel;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='sslEngine']"
		[Register ("sslEngine")]
		protected global::Javax.Net.Ssl.SSLEngine SslEngine {
			get {
				const string __id = "sslEngine.Ljavax/net/ssl/SSLEngine;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngine> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sslEngine.Ljavax/net/ssl/SSLEngine;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='tasks']"
		[Register ("tasks")]
		protected global::System.Collections.IList Tasks {
			get {
				const string __id = "tasks.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "tasks.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/field[@name='writeEngineResult']"
		[Register ("writeEngineResult")]
		protected global::Javax.Net.Ssl.SSLEngineResult WriteEngineResult {
			get {
				const string __id = "writeEngineResult.Ljavax/net/ssl/SSLEngineResult;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLEngineResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "writeEngineResult.Ljavax/net/ssl/SSLEngineResult;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/SSLSocketChannel2", typeof (SSLSocketChannel2));
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

		protected SSLSocketChannel2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/constructor[@name='SSLSocketChannel2' and count(parameter)=4 and parameter[1][@type='java.nio.channels.SocketChannel'] and parameter[2][@type='javax.net.ssl.SSLEngine'] and parameter[3][@type='java.util.concurrent.ExecutorService'] and parameter[4][@type='java.nio.channels.SelectionKey']]"
		[Register (".ctor", "(Ljava/nio/channels/SocketChannel;Ljavax/net/ssl/SSLEngine;Ljava/util/concurrent/ExecutorService;Ljava/nio/channels/SelectionKey;)V", "")]
		public unsafe SSLSocketChannel2 (global::Java.Nio.Channels.SocketChannel channel, global::Javax.Net.Ssl.SSLEngine sslEngine, global::Java.Util.Concurrent.IExecutorService exec, global::Java.Nio.Channels.SelectionKey key)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/nio/channels/SocketChannel;Ljavax/net/ssl/SSLEngine;Ljava/util/concurrent/ExecutorService;Ljava/nio/channels/SelectionKey;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
				__args [1] = new JniArgumentValue ((sslEngine == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sslEngine).Handle);
				__args [2] = new JniArgumentValue ((exec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exec).Handle);
				__args [3] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isBlocking;
#pragma warning disable 0169
		static Delegate GetIsBlockingHandler ()
		{
			if (cb_isBlocking == null)
				cb_isBlocking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlocking);
			return cb_isBlocking;
		}

		static bool n_IsBlocking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBlocking;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBlocking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='isBlocking' and count(parameter)=0]"
			[Register ("isBlocking", "()Z", "GetIsBlockingHandler")]
			get {
				const string __id = "isBlocking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isInboundDone;
#pragma warning disable 0169
		static Delegate GetIsInboundDoneHandler ()
		{
			if (cb_isInboundDone == null)
				cb_isInboundDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInboundDone);
			return cb_isInboundDone;
		}

		static bool n_IsInboundDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInboundDone;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInboundDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='isInboundDone' and count(parameter)=0]"
			[Register ("isInboundDone", "()Z", "GetIsInboundDoneHandler")]
			get {
				const string __id = "isInboundDone.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNeedRead;
#pragma warning disable 0169
		static Delegate GetIsNeedReadHandler ()
		{
			if (cb_isNeedRead == null)
				cb_isNeedRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedRead);
			return cb_isNeedRead;
		}

		static bool n_IsNeedRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedRead;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='isNeedRead' and count(parameter)=0]"
			[Register ("isNeedRead", "()Z", "GetIsNeedReadHandler")]
			get {
				const string __id = "isNeedRead.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isNeedWrite;
#pragma warning disable 0169
		static Delegate GetIsNeedWriteHandler ()
		{
			if (cb_isNeedWrite == null)
				cb_isNeedWrite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedWrite);
			return cb_isNeedWrite;
		}

		static bool n_IsNeedWrite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedWrite;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedWrite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='isNeedWrite' and count(parameter)=0]"
			[Register ("isNeedWrite", "()Z", "GetIsNeedWriteHandler")]
			get {
				const string __id = "isNeedWrite.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				const string __id = "isOpen.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_configureBlocking_Z;
#pragma warning disable 0169
		static Delegate GetConfigureBlocking_ZHandler ()
		{
			if (cb_configureBlocking_Z == null)
				cb_configureBlocking_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ConfigureBlocking_Z);
			return cb_configureBlocking_Z;
		}

		static IntPtr n_ConfigureBlocking_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConfigureBlocking (b));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='configureBlocking' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;", "GetConfigureBlocking_ZHandler")]
		public virtual unsafe global::Java.Nio.Channels.SelectableChannel ConfigureBlocking (bool b)
		{
			const string __id = "configureBlocking.(Z)Ljava/nio/channels/SelectableChannel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.SelectableChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connect_Ljava_net_SocketAddress_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_net_SocketAddress_Handler ()
		{
			if (cb_connect_Ljava_net_SocketAddress_ == null)
				cb_connect_Ljava_net_SocketAddress_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_net_SocketAddress_);
			return cb_connect_Ljava_net_SocketAddress_;
		}

		static bool n_Connect_Ljava_net_SocketAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.SocketAddress remote = global::Java.Lang.Object.GetObject<global::Java.Net.SocketAddress> (native_remote, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (remote);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='java.net.SocketAddress']]"
		[Register ("connect", "(Ljava/net/SocketAddress;)Z", "GetConnect_Ljava_net_SocketAddress_Handler")]
		public virtual unsafe bool Connect (global::Java.Net.SocketAddress remote)
		{
			const string __id = "connect.(Ljava/net/SocketAddress;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((remote == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remote).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_consumeDelegatedTasks;
#pragma warning disable 0169
		static Delegate GetConsumeDelegatedTasksHandler ()
		{
			if (cb_consumeDelegatedTasks == null)
				cb_consumeDelegatedTasks = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConsumeDelegatedTasks);
			return cb_consumeDelegatedTasks;
		}

		static void n_ConsumeDelegatedTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeDelegatedTasks ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='consumeDelegatedTasks' and count(parameter)=0]"
		[Register ("consumeDelegatedTasks", "()V", "GetConsumeDelegatedTasksHandler")]
		protected virtual unsafe void ConsumeDelegatedTasks ()
		{
			const string __id = "consumeDelegatedTasks.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_createBuffers_Ljavax_net_ssl_SSLSession_;
#pragma warning disable 0169
		static Delegate GetCreateBuffers_Ljavax_net_ssl_SSLSession_Handler ()
		{
			if (cb_createBuffers_Ljavax_net_ssl_SSLSession_ == null)
				cb_createBuffers_Ljavax_net_ssl_SSLSession_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateBuffers_Ljavax_net_ssl_SSLSession_);
			return cb_createBuffers_Ljavax_net_ssl_SSLSession_;
		}

		static void n_CreateBuffers_Ljavax_net_ssl_SSLSession_ (IntPtr jnienv, IntPtr native__this, IntPtr native_session)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.ISSLSession session = (global::Javax.Net.Ssl.ISSLSession)global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.ISSLSession> (native_session, JniHandleOwnership.DoNotTransfer);
			__this.CreateBuffers (session);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='createBuffers' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSession']]"
		[Register ("createBuffers", "(Ljavax/net/ssl/SSLSession;)V", "GetCreateBuffers_Ljavax_net_ssl_SSLSession_Handler")]
		protected virtual unsafe void CreateBuffers (global::Javax.Net.Ssl.ISSLSession session)
		{
			const string __id = "createBuffers.(Ljavax/net/ssl/SSLSession;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_finishConnect;
#pragma warning disable 0169
		static Delegate GetFinishConnectHandler ()
		{
			if (cb_finishConnect == null)
				cb_finishConnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_FinishConnect);
			return cb_finishConnect;
		}

		static bool n_FinishConnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinishConnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='finishConnect' and count(parameter)=0]"
		[Register ("finishConnect", "()Z", "GetFinishConnectHandler")]
		public virtual unsafe bool FinishConnect ()
		{
			const string __id = "finishConnect.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static int n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)I", "GetRead_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Read (global::Java.Nio.ByteBuffer dst)
		{
			const string __id = "read.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_readMore_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadMore_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_readMore_Ljava_nio_ByteBuffer_ == null)
				cb_readMore_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadMore_Ljava_nio_ByteBuffer_);
			return cb_readMore_Ljava_nio_ByteBuffer_;
		}

		static int n_ReadMore_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadMore (dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='readMore' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readMore", "(Ljava/nio/ByteBuffer;)I", "GetReadMore_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int ReadMore (global::Java.Nio.ByteBuffer dst)
		{
			const string __id = "readMore.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_socket;
#pragma warning disable 0169
		static Delegate GetSocketHandler ()
		{
			if (cb_socket == null)
				cb_socket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Socket);
			return cb_socket;
		}

		static IntPtr n_Socket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='socket' and count(parameter)=0]"
		[Register ("socket", "()Ljava/net/Socket;", "GetSocketHandler")]
		public virtual unsafe global::Java.Net.Socket Socket ()
		{
			const string __id = "socket.()Ljava/net/Socket;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static int n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer src = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_src, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Write (src);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)I", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Write (global::Java.Nio.ByteBuffer src)
		{
			const string __id = "write.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeMore;
#pragma warning disable 0169
		static Delegate GetWriteMoreHandler ()
		{
			if (cb_writeMore == null)
				cb_writeMore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteMore);
			return cb_writeMore;
		}

		static void n_WriteMore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteMore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel2']/method[@name='writeMore' and count(parameter)=0]"
		[Register ("writeMore", "()V", "GetWriteMoreHandler")]
		public virtual unsafe void WriteMore ()
		{
			const string __id = "writeMore.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
