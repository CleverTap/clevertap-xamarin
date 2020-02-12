using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='LimitExceededException']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/exceptions/LimitExceededException", DoNotGenerateAcw=true)]
	public partial class LimitExceededException : global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.InvalidDataException {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/exceptions/LimitExceededException", typeof (LimitExceededException));
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

		protected LimitExceededException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='LimitExceededException']/constructor[@name='LimitExceededException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LimitExceededException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='LimitExceededException']/constructor[@name='LimitExceededException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LimitExceededException (int limit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='LimitExceededException']/constructor[@name='LimitExceededException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LimitExceededException (string s)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='LimitExceededException']/constructor[@name='LimitExceededException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe LimitExceededException (string s, int limit)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLimit);
			return cb_getLimit;
		}

		static int n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.LimitExceededException __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.LimitExceededException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Limit;
		}
#pragma warning restore 0169

		public virtual unsafe int Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='LimitExceededException']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()I", "GetGetLimitHandler")]
			get {
				const string __id = "getLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
