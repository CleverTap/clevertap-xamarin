using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='PushType']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/PushType", DoNotGenerateAcw=true)]
	public sealed partial class PushType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='PushType']/field[@name='FCM']"
		[Register ("FCM")]
		public static global::Com.Clevertap.Android.Sdk.PushType Fcm {
			get {
				const string __id = "FCM.Lcom/clevertap/android/sdk/PushType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.PushType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/PushType", typeof (PushType));
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

		internal PushType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='PushType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/PushType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.PushType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/PushType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.PushType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='PushType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/PushType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.PushType[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/PushType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.PushType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.PushType));
			} finally {
			}
		}

	}
}
