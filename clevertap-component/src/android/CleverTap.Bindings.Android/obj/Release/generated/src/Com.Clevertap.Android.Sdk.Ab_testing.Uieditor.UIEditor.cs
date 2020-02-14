using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Ab_testing.Uieditor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/uieditor/UIEditor", DoNotGenerateAcw=true)]
	public partial class UIEditor : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor.ActivitySet']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/uieditor/UIEditor$ActivitySet", DoNotGenerateAcw=true)]
		public partial class ActivitySet : global::Java.Lang.Object {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/uieditor/UIEditor$ActivitySet", typeof (ActivitySet));
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

			protected ActivitySet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/uieditor/UIEditor", typeof (UIEditor));
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

		protected UIEditor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/constructor[@name='UIEditor' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CleverTapInstanceConfig']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;)V", "")]
		public unsafe UIEditor (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetAddActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_addActivity_Landroid_app_Activity_ == null)
				cb_addActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddActivity_Landroid_app_Activity_);
			return cb_addActivity_Landroid_app_Activity_;
		}

		static void n_AddActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.AddActivity (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/method[@name='addActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("addActivity", "(Landroid/app/Activity;)V", "GetAddActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe void AddActivity (global::Android.App.Activity activity)
		{
			const string __id = "addActivity.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_applyVariants_Ljava_util_Set_Z;
#pragma warning disable 0169
		static Delegate GetApplyVariants_Ljava_util_Set_ZHandler ()
		{
			if (cb_applyVariants_Ljava_util_Set_Z == null)
				cb_applyVariants_Ljava_util_Set_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ApplyVariants_Ljava_util_Set_Z);
			return cb_applyVariants_Ljava_util_Set_Z;
		}

		static void n_ApplyVariants_Ljava_util_Set_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_variants, bool isEditorSession)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var variants = global::Android.Runtime.JavaSet<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant>.FromJniHandle (native_variants, JniHandleOwnership.DoNotTransfer);
			__this.ApplyVariants (variants, isEditorSession);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/method[@name='applyVariants' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;com.clevertap.android.sdk.ab_testing.models.CTABVariant&gt;'] and parameter[2][@type='boolean']]"
		[Register ("applyVariants", "(Ljava/util/Set;Z)V", "GetApplyVariants_Ljava_util_Set_ZHandler")]
		public virtual unsafe void ApplyVariants (global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> variants, bool isEditorSession)
		{
			const string __id = "applyVariants.(Ljava/util/Set;Z)V";
			IntPtr native_variants = global::Android.Runtime.JavaSet<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant>.ToLocalJniHandle (variants);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_variants);
				__args [1] = new JniArgumentValue (isEditorSession);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_variants);
			}
		}

		static Delegate cb_loadSnapshotConfig_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetLoadSnapshotConfig_Lorg_json_JSONObject_Handler ()
		{
			if (cb_loadSnapshotConfig_Lorg_json_JSONObject_ == null)
				cb_loadSnapshotConfig_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LoadSnapshotConfig_Lorg_json_JSONObject_);
			return cb_loadSnapshotConfig_Lorg_json_JSONObject_;
		}

		static bool n_LoadSnapshotConfig_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject data = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_data, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LoadSnapshotConfig (data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/method[@name='loadSnapshotConfig' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("loadSnapshotConfig", "(Lorg/json/JSONObject;)Z", "GetLoadSnapshotConfig_Lorg_json_JSONObject_Handler")]
		public virtual unsafe bool LoadSnapshotConfig (global::Org.Json.JSONObject data)
		{
			const string __id = "loadSnapshotConfig.(Lorg/json/JSONObject;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetRemoveActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_removeActivity_Landroid_app_Activity_ == null)
				cb_removeActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveActivity_Landroid_app_Activity_);
			return cb_removeActivity_Landroid_app_Activity_;
		}

		static void n_RemoveActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.RemoveActivity (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/method[@name='removeActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("removeActivity", "(Landroid/app/Activity;)V", "GetRemoveActivity_Landroid_app_Activity_Handler")]
		public virtual unsafe void RemoveActivity (global::Android.App.Activity activity)
		{
			const string __id = "removeActivity.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopVariants;
#pragma warning disable 0169
		static Delegate GetStopVariantsHandler ()
		{
			if (cb_stopVariants == null)
				cb_stopVariants = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopVariants);
			return cb_stopVariants;
		}

		static void n_StopVariants (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopVariants ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/method[@name='stopVariants' and count(parameter)=0]"
		[Register ("stopVariants", "()V", "GetStopVariantsHandler")]
		public virtual unsafe void StopVariants ()
		{
			const string __id = "stopVariants.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeSnapshot_Ljava_io_OutputStream_;
#pragma warning disable 0169
		static Delegate GetWriteSnapshot_Ljava_io_OutputStream_Handler ()
		{
			if (cb_writeSnapshot_Ljava_io_OutputStream_ == null)
				cb_writeSnapshot_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteSnapshot_Ljava_io_OutputStream_);
			return cb_writeSnapshot_Ljava_io_OutputStream_;
		}

		static void n_WriteSnapshot_Ljava_io_OutputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Uieditor.UIEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream @out = global::Android.Runtime.OutputStreamInvoker.FromJniHandle (native__out, JniHandleOwnership.DoNotTransfer);
			__this.WriteSnapshot (@out);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.uieditor']/class[@name='UIEditor']/method[@name='writeSnapshot' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("writeSnapshot", "(Ljava/io/OutputStream;)V", "GetWriteSnapshot_Ljava_io_OutputStream_Handler")]
		public virtual unsafe void WriteSnapshot (global::System.IO.Stream @out)
		{
			const string __id = "writeSnapshot.(Ljava/io/OutputStream;)V";
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__out);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

	}
}
