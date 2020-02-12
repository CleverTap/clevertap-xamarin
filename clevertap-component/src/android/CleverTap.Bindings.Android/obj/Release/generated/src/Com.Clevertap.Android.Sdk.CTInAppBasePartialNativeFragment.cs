using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBasePartialNativeFragment']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBasePartialNativeFragment", DoNotGenerateAcw=true)]
	public abstract partial class CTInAppBasePartialNativeFragment : global::Com.Clevertap.Android.Sdk.CTInAppBasePartialFragment, global::Android.Views.View.IOnLongClickListener, global::Android.Views.View.IOnTouchListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBasePartialNativeFragment", typeof (CTInAppBasePartialNativeFragment));
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

		protected CTInAppBasePartialNativeFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBasePartialNativeFragment']/constructor[@name='CTInAppBasePartialNativeFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInAppBasePartialNativeFragment ()
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

		static Delegate cb_onLongClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnLongClick_Landroid_view_View_Handler ()
		{
			if (cb_onLongClick_Landroid_view_View_ == null)
				cb_onLongClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnLongClick_Landroid_view_View_);
			return cb_onLongClick_Landroid_view_View_;
		}

		static bool n_OnLongClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::Com.Clevertap.Android.Sdk.CTInAppBasePartialNativeFragment __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBasePartialNativeFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongClick (v);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBasePartialNativeFragment']/method[@name='onLongClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onLongClick", "(Landroid/view/View;)Z", "GetOnLongClick_Landroid_view_View_Handler")]
		public virtual unsafe bool OnLongClick (global::Android.Views.View v)
		{
			const string __id = "onLongClick.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.CTInAppBasePartialNativeFragment __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBasePartialNativeFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (v, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBasePartialNativeFragment']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View v, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouch.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBasePartialNativeFragment", DoNotGenerateAcw=true)]
	internal partial class CTInAppBasePartialNativeFragmentInvoker : CTInAppBasePartialNativeFragment {

		public CTInAppBasePartialNativeFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBasePartialNativeFragment", typeof (CTInAppBasePartialNativeFragmentInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
