using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppNotification", DoNotGenerateAcw=true)]
	public partial class CTInAppNotification : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']/field[@name='listener']"
		[Register ("listener")]
		public global::Com.Clevertap.Android.Sdk.CTInAppNotification.ICTInAppNotificationListener Listener {
			get {
				const string __id = "listener.Lcom/clevertap/android/sdk/CTInAppNotification$CTInAppNotificationListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification.ICTInAppNotificationListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listener.Lcom/clevertap/android/sdk/CTInAppNotification$CTInAppNotificationListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInAppNotification.CTInAppNotificationListener']"
		[Register ("com/clevertap/android/sdk/CTInAppNotification$CTInAppNotificationListener", "", "Com.Clevertap.Android.Sdk.CTInAppNotification/ICTInAppNotificationListenerInvoker")]
		public partial interface ICTInAppNotificationListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInAppNotification.CTInAppNotificationListener']/method[@name='notificationReady' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTInAppNotification']]"
			[Register ("notificationReady", "(Lcom/clevertap/android/sdk/CTInAppNotification;)V", "GetNotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_Handler:Com.Clevertap.Android.Sdk.CTInAppNotification/ICTInAppNotificationListenerInvoker, CleverTap.Bindings.Android")]
			void NotificationReady (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0);

		}

		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppNotification$CTInAppNotificationListener", DoNotGenerateAcw=true)]
		internal partial class ICTInAppNotificationListenerInvoker : global::Java.Lang.Object, ICTInAppNotificationListener {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppNotification$CTInAppNotificationListener", typeof (ICTInAppNotificationListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICTInAppNotificationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICTInAppNotificationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.CTInAppNotification.CTInAppNotificationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICTInAppNotificationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_;
#pragma warning disable 0169
			static Delegate GetNotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_Handler ()
			{
				if (cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ == null)
					cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_);
				return cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_;
			}

			static void n_NotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Clevertap.Android.Sdk.CTInAppNotification.ICTInAppNotificationListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification.ICTInAppNotificationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInAppNotification p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NotificationReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_;
			public unsafe void NotificationReady (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0)
			{
				if (id_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ == IntPtr.Zero)
					id_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ = JNIEnv.GetMethodID (class_ref, "notificationReady", "(Lcom/clevertap/android/sdk/CTInAppNotification;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_, __args);
			}

		}

		// event args for com.clevertap.android.sdk.CTInAppNotification.CTInAppNotificationListener.notificationReady
		public partial class CTInAppNotificationEventArgs : global::System.EventArgs {

			public CTInAppNotificationEventArgs (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0)
			{
				this.p0 = p0;
			}

			global::Com.Clevertap.Android.Sdk.CTInAppNotification p0;
			public global::Com.Clevertap.Android.Sdk.CTInAppNotification P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/CTInAppNotification_CTInAppNotificationListenerImplementor")]
		internal sealed partial class ICTInAppNotificationListenerImplementor : global::Java.Lang.Object, ICTInAppNotificationListener {

			object sender;

			public ICTInAppNotificationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/CTInAppNotification_CTInAppNotificationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CTInAppNotificationEventArgs> Handler;
#pragma warning restore 0649

			public void NotificationReady (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new CTInAppNotificationEventArgs (p0));
			}

			internal static bool __IsEmpty (ICTInAppNotificationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppNotification", typeof (CTInAppNotification));
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

		protected CTInAppNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getActionExtras;
#pragma warning disable 0169
		static Delegate GetGetActionExtrasHandler ()
		{
			if (cb_getActionExtras == null)
				cb_getActionExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionExtras);
			return cb_getActionExtras;
		}

		static IntPtr n_GetActionExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActionExtras);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject ActionExtras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']/method[@name='getActionExtras' and count(parameter)=0]"
			[Register ("getActionExtras", "()Lorg/json/JSONObject;", "GetGetActionExtrasHandler")]
			get {
				const string __id = "getActionExtras.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInAppType;
#pragma warning disable 0169
		static Delegate GetGetInAppTypeHandler ()
		{
			if (cb_getInAppType == null)
				cb_getInAppType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInAppType);
			return cb_getInAppType;
		}

		static IntPtr n_GetInAppType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InAppType);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Enum InAppType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']/method[@name='getInAppType' and count(parameter)=0]"
			[Register ("getInAppType", "()Ljava/lang/Enum;", "GetGetInAppTypeHandler")]
			get {
				const string __id = "getInAppType.()Ljava/lang/Enum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.CTInAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Clevertap.Android.Sdk.CTInAppNotification __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppNotification']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
