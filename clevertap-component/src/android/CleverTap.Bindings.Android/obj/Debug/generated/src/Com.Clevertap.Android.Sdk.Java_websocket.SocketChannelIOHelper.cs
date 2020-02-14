using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SocketChannelIOHelper']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/SocketChannelIOHelper", DoNotGenerateAcw=true)]
	public partial class SocketChannelIOHelper : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/SocketChannelIOHelper", typeof (SocketChannelIOHelper));
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

		protected SocketChannelIOHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SocketChannelIOHelper']/method[@name='batch' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketImpl'] and parameter[2][@type='java.nio.channels.ByteChannel']]"
		[Register ("batch", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Ljava/nio/channels/ByteChannel;)Z", "")]
		public static unsafe bool Batch (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl ws, global::Java.Nio.Channels.IByteChannel sockchannel)
		{
			const string __id = "batch.(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Ljava/nio/channels/ByteChannel;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ws == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ws).Handle);
				__args [1] = new JniArgumentValue ((sockchannel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sockchannel).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SocketChannelIOHelper']/method[@name='read' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.WebSocketImpl'] and parameter[3][@type='java.nio.channels.ByteChannel']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Ljava/nio/channels/ByteChannel;)Z", "")]
		public static unsafe bool Read (global::Java.Nio.ByteBuffer buf, global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl ws, global::Java.Nio.Channels.IByteChannel channel)
		{
			const string __id = "read.(Ljava/nio/ByteBuffer;Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Ljava/nio/channels/ByteChannel;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				__args [1] = new JniArgumentValue ((ws == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ws).Handle);
				__args [2] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='SocketChannelIOHelper']/method[@name='readMore' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.WebSocketImpl'] and parameter[3][@type='com.clevertap.android.sdk.java_websocket.WrappedByteChannel']]"
		[Register ("readMore", "(Ljava/nio/ByteBuffer;Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/WrappedByteChannel;)Z", "")]
		public static unsafe bool ReadMore (global::Java.Nio.ByteBuffer buf, global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl ws, global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel channel)
		{
			const string __id = "readMore.(Ljava/nio/ByteBuffer;Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/WrappedByteChannel;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				__args [1] = new JniArgumentValue ((ws == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ws).Handle);
				__args [2] = new JniArgumentValue ((channel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) channel).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
