using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Displayunits {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/displayunits/CTDisplayUnitType", DoNotGenerateAcw=true)]
	public sealed partial class CTDisplayUnitType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/field[@name='CAROUSEL']"
		[Register ("CAROUSEL")]
		public static global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType Carousel {
			get {
				const string __id = "CAROUSEL.Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/field[@name='CAROUSEL_WITH_IMAGE']"
		[Register ("CAROUSEL_WITH_IMAGE")]
		public static global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType CarouselWithImage {
			get {
				const string __id = "CAROUSEL_WITH_IMAGE.Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/field[@name='CUSTOM_KEY_VALUE']"
		[Register ("CUSTOM_KEY_VALUE")]
		public static global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType CustomKeyValue {
			get {
				const string __id = "CUSTOM_KEY_VALUE.Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/field[@name='MESSAGE_WITH_ICON']"
		[Register ("MESSAGE_WITH_ICON")]
		public static global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType MessageWithIcon {
			get {
				const string __id = "MESSAGE_WITH_ICON.Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/field[@name='SIMPLE']"
		[Register ("SIMPLE")]
		public static global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType Simple {
			get {
				const string __id = "SIMPLE.Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/field[@name='SIMPLE_WITH_IMAGE']"
		[Register ("SIMPLE_WITH_IMAGE")]
		public static global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType SimpleWithImage {
			get {
				const string __id = "SIMPLE_WITH_IMAGE.Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/displayunits/CTDisplayUnitType", typeof (CTDisplayUnitType));
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

		internal CTDisplayUnitType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/method[@name='type' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("type", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType Type (string type)
		{
			const string __id = "type.(Ljava/lang/String;)Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_type);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/class[@name='CTDisplayUnitType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType[] Values ()
		{
			const string __id = "values.()[Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType));
			} finally {
			}
		}

	}
}
