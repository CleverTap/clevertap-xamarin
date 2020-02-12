using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='CloseHandshakeType']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType", DoNotGenerateAcw=true)]
	public sealed partial class CloseHandshakeType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='CloseHandshakeType']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType None {
			get {
				const string __id = "NONE.Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='CloseHandshakeType']/field[@name='ONEWAY']"
		[Register ("ONEWAY")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType Oneway {
			get {
				const string __id = "ONEWAY.Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='CloseHandshakeType']/field[@name='TWOWAY']"
		[Register ("TWOWAY")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType Twoway {
			get {
				const string __id = "TWOWAY.Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType", typeof (CloseHandshakeType));
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

		internal CloseHandshakeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='CloseHandshakeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='CloseHandshakeType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType));
			} finally {
			}
		}

	}
}
