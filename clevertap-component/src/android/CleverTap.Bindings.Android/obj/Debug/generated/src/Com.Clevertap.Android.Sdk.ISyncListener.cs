using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='SyncListener']"
	[Register ("com/clevertap/android/sdk/SyncListener", "", "Com.Clevertap.Android.Sdk.ISyncListenerInvoker")]
	public partial interface ISyncListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='SyncListener']/method[@name='profileDataUpdated' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("profileDataUpdated", "(Lorg/json/JSONObject;)V", "GetProfileDataUpdated_Lorg_json_JSONObject_Handler:Com.Clevertap.Android.Sdk.ISyncListenerInvoker, CleverTap.Bindings.Android")]
		void ProfileDataUpdated (global::Org.Json.JSONObject p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='SyncListener']/method[@name='profileDidInitialize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("profileDidInitialize", "(Ljava/lang/String;)V", "GetProfileDidInitialize_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.ISyncListenerInvoker, CleverTap.Bindings.Android")]
		void ProfileDidInitialize (string p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/SyncListener", DoNotGenerateAcw=true)]
	internal partial class ISyncListenerInvoker : global::Java.Lang.Object, ISyncListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/SyncListener", typeof (ISyncListenerInvoker));

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

		public static ISyncListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISyncListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.SyncListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISyncListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_profileDataUpdated_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetProfileDataUpdated_Lorg_json_JSONObject_Handler ()
		{
			if (cb_profileDataUpdated_Lorg_json_JSONObject_ == null)
				cb_profileDataUpdated_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProfileDataUpdated_Lorg_json_JSONObject_);
			return cb_profileDataUpdated_Lorg_json_JSONObject_;
		}

		static void n_ProfileDataUpdated_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.ISyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ISyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProfileDataUpdated (p0);
		}
#pragma warning restore 0169

		IntPtr id_profileDataUpdated_Lorg_json_JSONObject_;
		public unsafe void ProfileDataUpdated (global::Org.Json.JSONObject p0)
		{
			if (id_profileDataUpdated_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_profileDataUpdated_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "profileDataUpdated", "(Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_profileDataUpdated_Lorg_json_JSONObject_, __args);
		}

		static Delegate cb_profileDidInitialize_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProfileDidInitialize_Ljava_lang_String_Handler ()
		{
			if (cb_profileDidInitialize_Ljava_lang_String_ == null)
				cb_profileDidInitialize_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProfileDidInitialize_Ljava_lang_String_);
			return cb_profileDidInitialize_Ljava_lang_String_;
		}

		static void n_ProfileDidInitialize_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.ISyncListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ISyncListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProfileDidInitialize (p0);
		}
#pragma warning restore 0169

		IntPtr id_profileDidInitialize_Ljava_lang_String_;
		public unsafe void ProfileDidInitialize (string p0)
		{
			if (id_profileDidInitialize_Ljava_lang_String_ == IntPtr.Zero)
				id_profileDidInitialize_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "profileDidInitialize", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_profileDidInitialize_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.clevertap.android.sdk.SyncListener.profileDataUpdated
	public partial class ProfileDataUpdatedEventArgs : global::System.EventArgs {

		public ProfileDataUpdatedEventArgs (global::Org.Json.JSONObject p0)
		{
			this.p0 = p0;
		}

		global::Org.Json.JSONObject p0;
		public global::Org.Json.JSONObject P0 {
			get { return p0; }
		}
	}

	// event args for com.clevertap.android.sdk.SyncListener.profileDidInitialize
	public partial class ProfileDidInitializeEventArgs : global::System.EventArgs {

		public ProfileDidInitializeEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/SyncListenerImplementor")]
	internal sealed partial class ISyncListenerImplementor : global::Java.Lang.Object, ISyncListener {

		object sender;

		public ISyncListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/SyncListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ProfileDataUpdatedEventArgs> ProfileDataUpdatedHandler;
#pragma warning restore 0649

		public void ProfileDataUpdated (global::Org.Json.JSONObject p0)
		{
			var __h = ProfileDataUpdatedHandler;
			if (__h != null)
				__h (sender, new ProfileDataUpdatedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ProfileDidInitializeEventArgs> ProfileDidInitializeHandler;
#pragma warning restore 0649

		public void ProfileDidInitialize (string p0)
		{
			var __h = ProfileDidInitializeHandler;
			if (__h != null)
				__h (sender, new ProfileDidInitializeEventArgs (p0));
		}

		internal static bool __IsEmpty (ISyncListenerImplementor value)
		{
			return value.ProfileDataUpdatedHandler == null && value.ProfileDidInitializeHandler == null;
		}
	}

}
