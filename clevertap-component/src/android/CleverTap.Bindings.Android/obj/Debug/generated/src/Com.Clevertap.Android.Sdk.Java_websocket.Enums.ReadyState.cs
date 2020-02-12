using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/enums/ReadyState", DoNotGenerateAcw=true)]
	public sealed partial class ReadyState : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']/field[@name='CLOSED']"
		[Register ("CLOSED")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState Closed {
			get {
				const string __id = "CLOSED.Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']/field[@name='CLOSING']"
		[Register ("CLOSING")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState Closing {
			get {
				const string __id = "CLOSING.Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']/field[@name='NOT_YET_CONNECTED']"
		[Register ("NOT_YET_CONNECTED")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState NotYetConnected {
			get {
				const string __id = "NOT_YET_CONNECTED.Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']/field[@name='OPEN']"
		[Register ("OPEN")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState Open {
			get {
				const string __id = "OPEN.Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/enums/ReadyState", typeof (ReadyState));
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

		internal ReadyState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='ReadyState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState));
			} finally {
			}
		}

	}
}
