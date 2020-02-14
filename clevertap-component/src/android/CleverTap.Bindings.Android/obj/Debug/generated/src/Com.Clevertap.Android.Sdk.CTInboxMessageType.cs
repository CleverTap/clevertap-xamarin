using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxMessageType", DoNotGenerateAcw=true)]
	public sealed partial class CTInboxMessageType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']/field[@name='CarouselImageMessage']"
		[Register ("CarouselImageMessage")]
		public static global::Com.Clevertap.Android.Sdk.CTInboxMessageType CarouselImageMessage {
			get {
				const string __id = "CarouselImageMessage.Lcom/clevertap/android/sdk/CTInboxMessageType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']/field[@name='CarouselMessage']"
		[Register ("CarouselMessage")]
		public static global::Com.Clevertap.Android.Sdk.CTInboxMessageType CarouselMessage {
			get {
				const string __id = "CarouselMessage.Lcom/clevertap/android/sdk/CTInboxMessageType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']/field[@name='IconMessage']"
		[Register ("IconMessage")]
		public static global::Com.Clevertap.Android.Sdk.CTInboxMessageType IconMessage {
			get {
				const string __id = "IconMessage.Lcom/clevertap/android/sdk/CTInboxMessageType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']/field[@name='SimpleMessage']"
		[Register ("SimpleMessage")]
		public static global::Com.Clevertap.Android.Sdk.CTInboxMessageType SimpleMessage {
			get {
				const string __id = "SimpleMessage.Lcom/clevertap/android/sdk/CTInboxMessageType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxMessageType", typeof (CTInboxMessageType));
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

		internal CTInboxMessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
		public static unsafe global::Java.Lang.Enum ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/CTInboxMessageType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CTInboxMessageType[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/CTInboxMessageType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.CTInboxMessageType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.CTInboxMessageType));
			} finally {
			}
		}

	}
}
