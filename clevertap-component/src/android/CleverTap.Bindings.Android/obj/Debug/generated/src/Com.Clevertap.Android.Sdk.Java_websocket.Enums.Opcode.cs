using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Enums {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/enums/Opcode", DoNotGenerateAcw=true)]
	public sealed partial class Opcode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/field[@name='BINARY']"
		[Register ("BINARY")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Binary {
			get {
				const string __id = "BINARY.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/field[@name='CLOSING']"
		[Register ("CLOSING")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Closing {
			get {
				const string __id = "CLOSING.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/field[@name='CONTINUOUS']"
		[Register ("CONTINUOUS")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Continuous {
			get {
				const string __id = "CONTINUOUS.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/field[@name='PING']"
		[Register ("PING")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Ping {
			get {
				const string __id = "PING.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/field[@name='PONG']"
		[Register ("PONG")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Pong {
			get {
				const string __id = "PONG.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Text {
			get {
				const string __id = "TEXT.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/enums/Opcode", typeof (Opcode));
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

		internal Opcode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.enums']/class[@name='Opcode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode));
			} finally {
			}
		}

	}
}
