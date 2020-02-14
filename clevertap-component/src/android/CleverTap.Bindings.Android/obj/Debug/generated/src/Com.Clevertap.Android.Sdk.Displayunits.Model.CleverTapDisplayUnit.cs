using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Displayunits.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnit", DoNotGenerateAcw=true)]
	public partial class CleverTapDisplayUnit : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnit", typeof (CleverTapDisplayUnit));
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

		protected CleverTapDisplayUnit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBgColor;
#pragma warning disable 0169
		static Delegate GetGetBgColorHandler ()
		{
			if (cb_getBgColor == null)
				cb_getBgColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBgColor);
			return cb_getBgColor;
		}

		static IntPtr n_GetBgColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BgColor);
		}
#pragma warning restore 0169

		public virtual unsafe string BgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getBgColor' and count(parameter)=0]"
			[Register ("getBgColor", "()Ljava/lang/String;", "GetGetBgColorHandler")]
			get {
				const string __id = "getBgColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContents;
#pragma warning disable 0169
		static Delegate GetGetContentsHandler ()
		{
			if (cb_getContents == null)
				cb_getContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContents);
			return cb_getContents;
		}

		static IntPtr n_GetContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent>.ToLocalJniHandle (__this.Contents);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> Contents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getContents' and count(parameter)=0]"
			[Register ("getContents", "()Ljava/util/ArrayList;", "GetGetContentsHandler")]
			get {
				const string __id = "getContents.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomExtras;
#pragma warning disable 0169
		static Delegate GetGetCustomExtrasHandler ()
		{
			if (cb_getCustomExtras == null)
				cb_getCustomExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomExtras);
			return cb_getCustomExtras;
		}

		static IntPtr n_GetCustomExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CustomExtras);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CustomExtras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getCustomExtras' and count(parameter)=0]"
			[Register ("getCustomExtras", "()Ljava/util/HashMap;", "GetGetCustomExtrasHandler")]
			get {
				const string __id = "getCustomExtras.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJsonObject;
#pragma warning disable 0169
		static Delegate GetGetJsonObjectHandler ()
		{
			if (cb_getJsonObject == null)
				cb_getJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonObject);
			return cb_getJsonObject;
		}

		static IntPtr n_GetJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JsonObject);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject JsonObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getJsonObject' and count(parameter)=0]"
			[Register ("getJsonObject", "()Lorg/json/JSONObject;", "GetGetJsonObjectHandler")]
			get {
				const string __id = "getJsonObject.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lcom/clevertap/android/sdk/displayunits/CTDisplayUnitType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.CTDisplayUnitType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnitID;
#pragma warning disable 0169
		static Delegate GetGetUnitIDHandler ()
		{
			if (cb_getUnitID == null)
				cb_getUnitID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnitID);
			return cb_getUnitID;
		}

		static IntPtr n_GetUnitID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UnitID);
		}
#pragma warning restore 0169

		public virtual unsafe string UnitID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getUnitID' and count(parameter)=0]"
			[Register ("getUnitID", "()Ljava/lang/String;", "GetGetUnitIDHandler")]
			get {
				const string __id = "getUnitID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWZRKFields;
#pragma warning disable 0169
		static Delegate GetGetWZRKFieldsHandler ()
		{
			if (cb_getWZRKFields == null)
				cb_getWZRKFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWZRKFields);
			return cb_getWZRKFields;
		}

		static IntPtr n_GetWZRKFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WZRKFields);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject WZRKFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='getWZRKFields' and count(parameter)=0]"
			[Register ("getWZRKFields", "()Lorg/json/JSONObject;", "GetGetWZRKFieldsHandler")]
			get {
				const string __id = "getWZRKFields.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='toDisplayUnit' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("toDisplayUnit", "(Lorg/json/JSONObject;)Lcom/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnit;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit ToDisplayUnit (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "toDisplayUnit.(Lorg/json/JSONObject;)Lcom/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnit;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_i)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel parcel = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_parcel, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags i = (global::Android.OS.ParcelableWriteFlags) native_i;
			__this.WriteToParcel (parcel, i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnit']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel parcel, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags i)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parcel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parcel).Handle);
				__args [1] = new JniArgumentValue ((int) i);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
