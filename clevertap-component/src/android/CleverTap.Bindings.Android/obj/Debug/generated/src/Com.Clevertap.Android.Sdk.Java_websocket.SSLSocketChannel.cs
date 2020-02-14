using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/SSLSocketChannel", DoNotGenerateAcw=true)]
	public partial class SSLSocketChannel : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel, global::Java.Nio.Channels.IByteChannel {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/SSLSocketChannel", typeof (SSLSocketChannel));
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

		protected SSLSocketChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/constructor[@name='SSLSocketChannel' and count(parameter)=4 and parameter[1][@type='java.nio.channels.SocketChannel'] and parameter[2][@type='javax.net.ssl.SSLEngine'] and parameter[3][@type='java.util.concurrent.ExecutorService'] and parameter[4][@type='java.nio.channels.SelectionKey']]"
		[Register (".ctor", "(Ljava/nio/channels/SocketChannel;Ljavax/net/ssl/SSLEngine;Ljava/util/concurrent/ExecutorService;Ljava/nio/channels/SelectionKey;)V", "")]
		public unsafe SSLSocketChannel (global::Java.Nio.Channels.SocketChannel inputSocketChannel, global::Javax.Net.Ssl.SSLEngine inputEngine, global::Java.Util.Concurrent.IExecutorService inputExecutor, global::Java.Nio.Channels.SelectionKey key)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/nio/channels/SocketChannel;Ljavax/net/ssl/SSLEngine;Ljava/util/concurrent/ExecutorService;Ljava/nio/channels/SelectionKey;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((inputSocketChannel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputSocketChannel).Handle);
				__args [1] = new JniArgumentValue ((inputEngine == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputEngine).Handle);
				__args [2] = new JniArgumentValue ((inputExecutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputExecutor).Handle);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBlocking;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBlocking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='isBlocking' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedRead;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='isNeedRead' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedWrite;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeedWrite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='isNeedWrite' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='isOpen' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadMore (dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='readMore' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static int n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_output)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer output = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_output, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Write (output);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)I", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int Write (global::Java.Nio.ByteBuffer output)
		{
			const string __id = "write.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((output == null) ? IntPtr.Zero : ((global::Java.Lang.Object) output).Handle);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.SSLSocketChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteMore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SSLSocketChannel']/method[@name='writeMore' and count(parameter)=0]"
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
