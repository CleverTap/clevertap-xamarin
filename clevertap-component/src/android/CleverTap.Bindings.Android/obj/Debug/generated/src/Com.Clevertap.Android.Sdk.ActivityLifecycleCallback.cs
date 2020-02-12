using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='ActivityLifecycleCallback']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/ActivityLifecycleCallback", DoNotGenerateAcw=true)]
	public sealed partial class ActivityLifecycleCallback : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ActivityLifecycleCallback", typeof (ActivityLifecycleCallback));
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

		internal ActivityLifecycleCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='ActivityLifecycleCallback']/constructor[@name='ActivityLifecycleCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActivityLifecycleCallback ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='ActivityLifecycleCallback']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("register", "(Landroid/app/Application;)V", "")]
		public static unsafe void Register (global::Android.App.Application application)
		{
			const string __id = "register.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='ActivityLifecycleCallback']/method[@name='register' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
		[Register ("register", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
		public static unsafe void Register (global::Android.App.Application application, string cleverTapID)
		{
			const string __id = "register.(Landroid/app/Application;Ljava/lang/String;)V";
			IntPtr native_cleverTapID = JNIEnv.NewString (cleverTapID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [1] = new JniArgumentValue (native_cleverTapID);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cleverTapID);
			}
		}

	}
}
