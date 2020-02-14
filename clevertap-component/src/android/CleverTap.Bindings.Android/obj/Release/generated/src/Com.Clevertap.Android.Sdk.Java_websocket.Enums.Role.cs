using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Role']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/enums/Role", DoNotGenerateAcw=true)]
	public sealed partial class Role : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Role']/field[@name='CLIENT']"
		[Register ("CLIENT")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role Client {
			get {
				const string __id = "CLIENT.Lcom/clevertap/android/sdk/java_websocket/enums/Role;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Role']/field[@name='SERVER']"
		[Register ("SERVER")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role Server {
			get {
				const string __id = "SERVER.Lcom/clevertap/android/sdk/java_websocket/enums/Role;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/enums/Role", typeof (Role));
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

		internal Role (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Role']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/Role;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/Role;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Role']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/java_websocket/enums/Role;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/java_websocket/enums/Role;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role));
			} finally {
			}
		}

	}
}
