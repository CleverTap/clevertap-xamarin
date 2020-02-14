using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='InvalidEncodingException']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/exceptions/InvalidEncodingException", DoNotGenerateAcw=true)]
	public partial class InvalidEncodingException : global::Java.Lang.RuntimeException {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/exceptions/InvalidEncodingException", typeof (InvalidEncodingException));
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

		protected InvalidEncodingException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='InvalidEncodingException']/constructor[@name='InvalidEncodingException' and count(parameter)=1 and parameter[1][@type='java.io.UnsupportedEncodingException']]"
		[Register (".ctor", "(Ljava/io/UnsupportedEncodingException;)V", "")]
		public unsafe InvalidEncodingException (global::Java.IO.UnsupportedEncodingException encodingException)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/UnsupportedEncodingException;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((encodingException == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) encodingException).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEncodingException;
#pragma warning disable 0169
		static Delegate GetGetEncodingExceptionHandler ()
		{
			if (cb_getEncodingException == null)
				cb_getEncodingException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncodingException);
			return cb_getEncodingException;
		}

		static IntPtr n_GetEncodingException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.InvalidEncodingException __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.InvalidEncodingException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EncodingException);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.UnsupportedEncodingException EncodingException {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='InvalidEncodingException']/method[@name='getEncodingException' and count(parameter)=0]"
			[Register ("getEncodingException", "()Ljava/io/UnsupportedEncodingException;", "GetGetEncodingExceptionHandler")]
			get {
				const string __id = "getEncodingException.()Ljava/io/UnsupportedEncodingException;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.UnsupportedEncodingException> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
