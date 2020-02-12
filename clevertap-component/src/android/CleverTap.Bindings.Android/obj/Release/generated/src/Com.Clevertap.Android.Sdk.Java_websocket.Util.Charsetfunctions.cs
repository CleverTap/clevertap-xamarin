using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/util/Charsetfunctions", DoNotGenerateAcw=true)]
	public partial class Charsetfunctions : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/util/Charsetfunctions", typeof (Charsetfunctions));
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

		protected Charsetfunctions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='asciiBytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("asciiBytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] AsciiBytes (string s)
		{
			const string __id = "asciiBytes.(Ljava/lang/String;)[B";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='isValidUTF8' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("isValidUTF8", "(Ljava/nio/ByteBuffer;)Z", "")]
		public static unsafe bool IsValidUTF8 (global::Java.Nio.ByteBuffer data)
		{
			const string __id = "isValidUTF8.(Ljava/nio/ByteBuffer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='isValidUTF8' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("isValidUTF8", "(Ljava/nio/ByteBuffer;I)Z", "")]
		public static unsafe bool IsValidUTF8 (global::Java.Nio.ByteBuffer data, int off)
		{
			const string __id = "isValidUTF8.(Ljava/nio/ByteBuffer;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (off);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='stringAscii' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("stringAscii", "([B)Ljava/lang/String;", "")]
		public static unsafe string StringAscii (byte[] bytes)
		{
			const string __id = "stringAscii.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='stringAscii' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("stringAscii", "([BII)Ljava/lang/String;", "")]
		public static unsafe string StringAscii (byte[] bytes, int offset, int length)
		{
			const string __id = "stringAscii.([BII)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bytes);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='stringUtf8' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("stringUtf8", "([B)Ljava/lang/String;", "")]
		public static unsafe string StringUtf8 (byte[] bytes)
		{
			const string __id = "stringUtf8.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='stringUtf8' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("stringUtf8", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "")]
		public static unsafe string StringUtf8 (global::Java.Nio.ByteBuffer bytes)
		{
			const string __id = "stringUtf8.(Ljava/nio/ByteBuffer;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Charsetfunctions']/method[@name='utf8Bytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("utf8Bytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Utf8Bytes (string s)
		{
			const string __id = "utf8Bytes.(Ljava/lang/String;)[B";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
