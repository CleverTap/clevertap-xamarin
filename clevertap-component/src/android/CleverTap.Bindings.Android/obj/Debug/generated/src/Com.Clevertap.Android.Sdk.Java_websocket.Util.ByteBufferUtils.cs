using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='ByteBufferUtils']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/util/ByteBufferUtils", DoNotGenerateAcw=true)]
	public partial class ByteBufferUtils : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/util/ByteBufferUtils", typeof (ByteBufferUtils));
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

		protected ByteBufferUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Java.Nio.ByteBuffer EmptyByteBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='ByteBufferUtils']/method[@name='getEmptyByteBuffer' and count(parameter)=0]"
			[Register ("getEmptyByteBuffer", "()Ljava/nio/ByteBuffer;", "")]
			get {
				const string __id = "getEmptyByteBuffer.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='ByteBufferUtils']/method[@name='transferByteBuffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("transferByteBuffer", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int TransferByteBuffer (global::Java.Nio.ByteBuffer source, global::Java.Nio.ByteBuffer dest)
		{
			const string __id = "transferByteBuffer.(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
