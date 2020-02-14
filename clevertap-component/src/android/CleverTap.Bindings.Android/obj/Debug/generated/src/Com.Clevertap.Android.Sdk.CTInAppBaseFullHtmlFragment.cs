using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", DoNotGenerateAcw=true)]
	public abstract partial class CTInAppBaseFullHtmlFragment : global::Com.Clevertap.Android.Sdk.CTInAppBaseFullFragment {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment']/field[@name='webView']"
		[Register ("webView")]
		protected global::Com.Clevertap.Android.Sdk.CTInAppWebView WebView {
			get {
				const string __id = "webView.Lcom/clevertap/android/sdk/CTInAppWebView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppWebView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "webView.Lcom/clevertap/android/sdk/CTInAppWebView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment.InAppWebViewClient']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment$InAppWebViewClient", DoNotGenerateAcw=true)]
		public partial class InAppWebViewClient : global::Android.Webkit.WebViewClient {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment$InAppWebViewClient", typeof (InAppWebViewClient));
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

			protected InAppWebViewClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", typeof (CTInAppBaseFullHtmlFragment));
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

		protected CTInAppBaseFullHtmlFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment']/constructor[@name='CTInAppBaseFullHtmlFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInAppBaseFullHtmlFragment ()
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

		static Delegate cb_getLayoutParamsForCloseButton;
#pragma warning disable 0169
		static Delegate GetGetLayoutParamsForCloseButtonHandler ()
		{
			if (cb_getLayoutParamsForCloseButton == null)
				cb_getLayoutParamsForCloseButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayoutParamsForCloseButton);
			return cb_getLayoutParamsForCloseButton;
		}

		static IntPtr n_GetLayoutParamsForCloseButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInAppBaseFullHtmlFragment __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBaseFullHtmlFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LayoutParamsForCloseButton);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Widget.RelativeLayout.LayoutParams LayoutParamsForCloseButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFullHtmlFragment']/method[@name='getLayoutParamsForCloseButton' and count(parameter)=0]"
			[Register ("getLayoutParamsForCloseButton", "()Landroid/widget/RelativeLayout$LayoutParams;", "GetGetLayoutParamsForCloseButtonHandler")]
			get {
				const string __id = "getLayoutParamsForCloseButton.()Landroid/widget/RelativeLayout$LayoutParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", DoNotGenerateAcw=true)]
	internal partial class CTInAppBaseFullHtmlFragmentInvoker : CTInAppBaseFullHtmlFragment {

		public CTInAppBaseFullHtmlFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFullHtmlFragment", typeof (CTInAppBaseFullHtmlFragmentInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
