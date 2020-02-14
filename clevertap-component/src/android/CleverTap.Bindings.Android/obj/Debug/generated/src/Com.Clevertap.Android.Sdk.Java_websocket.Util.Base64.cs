using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/util/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/field[@name='DO_BREAK_LINES']"
		[Register ("DO_BREAK_LINES")]
		public const int DoBreakLines = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/field[@name='ENCODE']"
		[Register ("ENCODE")]
		public const int Encode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/field[@name='GZIP']"
		[Register ("GZIP")]
		public const int Gzip = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/field[@name='NO_OPTIONS']"
		[Register ("NO_OPTIONS")]
		public const int NoOptions = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/field[@name='ORDERED']"
		[Register ("ORDERED")]
		public const int Ordered = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/field[@name='URL_SAFE']"
		[Register ("URL_SAFE")]
		public const int UrlSafe = (int) 16;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64.OutputStream']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/util/Base64$OutputStream", DoNotGenerateAcw=true)]
		public partial class OutputStream : global::Java.IO.FilterOutputStream {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/util/Base64$OutputStream", typeof (OutputStream));
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

			protected OutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64.OutputStream']/constructor[@name='Base64.OutputStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
			public unsafe OutputStream (global::System.IO.Stream @out)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/OutputStream;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native__out);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native__out);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64.OutputStream']/constructor[@name='Base64.OutputStream' and count(parameter)=2 and parameter[1][@type='java.io.OutputStream'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/io/OutputStream;I)V", "")]
			public unsafe OutputStream (global::System.IO.Stream @out, int options)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/OutputStream;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native__out);
					__args [1] = new JniArgumentValue (options);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native__out);
				}
			}

			static Delegate cb_flushBase64;
#pragma warning disable 0169
			static Delegate GetFlushBase64Handler ()
			{
				if (cb_flushBase64 == null)
					cb_flushBase64 = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlushBase64);
				return cb_flushBase64;
			}

			static void n_FlushBase64 (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Clevertap.Android.Sdk.Java_websocket.Util.Base64.OutputStream __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Util.Base64.OutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FlushBase64 ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64.OutputStream']/method[@name='flushBase64' and count(parameter)=0]"
			[Register ("flushBase64", "()V", "GetFlushBase64Handler")]
			public virtual unsafe void FlushBase64 ()
			{
				const string __id = "flushBase64.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/util/Base64", typeof (Base64));
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

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] source)
		{
			const string __id = "encodeBytes.([B)Ljava/lang/String;";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_source);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeBytes", "([BIII)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] source, int off, int len, int options)
		{
			const string __id = "encodeBytes.([BIII)Ljava/lang/String;";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				__args [3] = new JniArgumentValue (options);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.util']/class[@name='Base64']/method[@name='encodeBytesToBytes' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeBytesToBytes", "([BIII)[B", "")]
		public static unsafe byte[] EncodeBytesToBytes (byte[] source, int off, int len, int options)
		{
			const string __id = "encodeBytesToBytes.([BIII)[B";
			IntPtr native_source = JNIEnv.NewArray (source);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (off);
				__args [2] = new JniArgumentValue (len);
				__args [3] = new JniArgumentValue (options);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (source != null) {
					JNIEnv.CopyArray (native_source, source);
					JNIEnv.DeleteLocalRef (native_source);
				}
			}
		}

	}
}
