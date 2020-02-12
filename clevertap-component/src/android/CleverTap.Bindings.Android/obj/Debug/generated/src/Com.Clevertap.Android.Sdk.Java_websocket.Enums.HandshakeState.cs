using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='HandshakeState']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/enums/HandshakeState", DoNotGenerateAcw=true)]
	public sealed partial class HandshakeState : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='HandshakeState']/field[@name='MATCHED']"
		[Register ("MATCHED")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState Matched {
			get {
				const string __id = "MATCHED.Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='HandshakeState']/field[@name='NOT_MATCHED']"
		[Register ("NOT_MATCHED")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState NotMatched {
			get {
				const string __id = "NOT_MATCHED.Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/enums/HandshakeState", typeof (HandshakeState));
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

		internal HandshakeState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='HandshakeState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='HandshakeState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState));
			} finally {
			}
		}

	}
}
