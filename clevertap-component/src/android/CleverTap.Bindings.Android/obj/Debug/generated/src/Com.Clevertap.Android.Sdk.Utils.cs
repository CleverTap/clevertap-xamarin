using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/Utils", DoNotGenerateAcw=true)]
	public sealed partial class Utils : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/Utils", typeof (Utils));
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

		internal Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='Utils']/method[@name='optionalStringKey' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register ("optionalStringKey", "(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string OptionalStringKey (global::Org.Json.JSONObject o, string k)
		{
			const string __id = "optionalStringKey.(Lorg/json/JSONObject;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_k = JNIEnv.NewString (k);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				__args [1] = new JniArgumentValue (native_k);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_k);
			}
		}

	}
}
