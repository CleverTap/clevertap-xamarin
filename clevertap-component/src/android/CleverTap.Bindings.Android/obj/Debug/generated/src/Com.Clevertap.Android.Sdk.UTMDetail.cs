using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/UTMDetail", DoNotGenerateAcw=true)]
	public partial class UTMDetail : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/UTMDetail", typeof (UTMDetail));
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

		protected UTMDetail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/constructor[@name='UTMDetail' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTMDetail ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCampaign;
#pragma warning disable 0169
		static Delegate GetGetCampaignHandler ()
		{
			if (cb_getCampaign == null)
				cb_getCampaign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaign);
			return cb_getCampaign;
		}

		static IntPtr n_GetCampaign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.UTMDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Campaign);
		}
#pragma warning restore 0169

		static Delegate cb_setCampaign_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCampaign_Ljava_lang_String_Handler ()
		{
			if (cb_setCampaign_Ljava_lang_String_ == null)
				cb_setCampaign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCampaign_Ljava_lang_String_);
			return cb_setCampaign_Ljava_lang_String_;
		}

		static void n_SetCampaign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_campaign)
		{
			global::Com.Clevertap.Android.Sdk.UTMDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string campaign = JNIEnv.GetString (native_campaign, JniHandleOwnership.DoNotTransfer);
			__this.Campaign = campaign;
		}
#pragma warning restore 0169

		public virtual unsafe string Campaign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/method[@name='getCampaign' and count(parameter)=0]"
			[Register ("getCampaign", "()Ljava/lang/String;", "GetGetCampaignHandler")]
			get {
				const string __id = "getCampaign.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/method[@name='setCampaign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCampaign", "(Ljava/lang/String;)V", "GetSetCampaign_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCampaign.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMedium;
#pragma warning disable 0169
		static Delegate GetGetMediumHandler ()
		{
			if (cb_getMedium == null)
				cb_getMedium = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMedium);
			return cb_getMedium;
		}

		static IntPtr n_GetMedium (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.UTMDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Medium);
		}
#pragma warning restore 0169

		static Delegate cb_setMedium_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMedium_Ljava_lang_String_Handler ()
		{
			if (cb_setMedium_Ljava_lang_String_ == null)
				cb_setMedium_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMedium_Ljava_lang_String_);
			return cb_setMedium_Ljava_lang_String_;
		}

		static void n_SetMedium_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_medium)
		{
			global::Com.Clevertap.Android.Sdk.UTMDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string medium = JNIEnv.GetString (native_medium, JniHandleOwnership.DoNotTransfer);
			__this.Medium = medium;
		}
#pragma warning restore 0169

		public virtual unsafe string Medium {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/method[@name='getMedium' and count(parameter)=0]"
			[Register ("getMedium", "()Ljava/lang/String;", "GetGetMediumHandler")]
			get {
				const string __id = "getMedium.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/method[@name='setMedium' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMedium", "(Ljava/lang/String;)V", "GetSetMedium_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMedium.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.UTMDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Source);
		}
#pragma warning restore 0169

		static Delegate cb_setSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSource_Ljava_lang_String_Handler ()
		{
			if (cb_setSource_Ljava_lang_String_ == null)
				cb_setSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSource_Ljava_lang_String_);
			return cb_setSource_Ljava_lang_String_;
		}

		static void n_SetSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Com.Clevertap.Android.Sdk.UTMDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			__this.Source = source;
		}
#pragma warning restore 0169

		public virtual unsafe string Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Ljava/lang/String;", "GetGetSourceHandler")]
			get {
				const string __id = "getSource.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='UTMDetail']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSource", "(Ljava/lang/String;)V", "GetSetSource_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSource.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
