using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTBackgroundJobService']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTBackgroundJobService", DoNotGenerateAcw=true)]
	public partial class CTBackgroundJobService : global::Android.App.Job.JobService {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTBackgroundJobService", typeof (CTBackgroundJobService));
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

		protected CTBackgroundJobService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTBackgroundJobService']/constructor[@name='CTBackgroundJobService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTBackgroundJobService ()
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

		static Delegate cb_onStartJob_Landroid_app_job_JobParameters_;
#pragma warning disable 0169
		static Delegate GetOnStartJob_Landroid_app_job_JobParameters_Handler ()
		{
			if (cb_onStartJob_Landroid_app_job_JobParameters_ == null)
				cb_onStartJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnStartJob_Landroid_app_job_JobParameters_);
			return cb_onStartJob_Landroid_app_job_JobParameters_;
		}

		static bool n_OnStartJob_Landroid_app_job_JobParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::Com.Clevertap.Android.Sdk.CTBackgroundJobService __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTBackgroundJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Job.JobParameters @params = global::Java.Lang.Object.GetObject<global::Android.App.Job.JobParameters> (native__params, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStartJob (@params);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTBackgroundJobService']/method[@name='onStartJob' and count(parameter)=1 and parameter[1][@type='android.app.job.JobParameters']]"
		[Register ("onStartJob", "(Landroid/app/job/JobParameters;)Z", "GetOnStartJob_Landroid_app_job_JobParameters_Handler")]
		public override unsafe bool OnStartJob (global::Android.App.Job.JobParameters @params)
		{
			const string __id = "onStartJob.(Landroid/app/job/JobParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onStopJob_Landroid_app_job_JobParameters_;
#pragma warning disable 0169
		static Delegate GetOnStopJob_Landroid_app_job_JobParameters_Handler ()
		{
			if (cb_onStopJob_Landroid_app_job_JobParameters_ == null)
				cb_onStopJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnStopJob_Landroid_app_job_JobParameters_);
			return cb_onStopJob_Landroid_app_job_JobParameters_;
		}

		static bool n_OnStopJob_Landroid_app_job_JobParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::Com.Clevertap.Android.Sdk.CTBackgroundJobService __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTBackgroundJobService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Job.JobParameters @params = global::Java.Lang.Object.GetObject<global::Android.App.Job.JobParameters> (native__params, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStopJob (@params);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTBackgroundJobService']/method[@name='onStopJob' and count(parameter)=1 and parameter[1][@type='android.app.job.JobParameters']]"
		[Register ("onStopJob", "(Landroid/app/job/JobParameters;)Z", "GetOnStopJob_Landroid_app_job_JobParameters_Handler")]
		public override unsafe bool OnStopJob (global::Android.App.Job.JobParameters @params)
		{
			const string __id = "onStopJob.(Landroid/app/job/JobParameters;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
