using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFragment']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFragment", DoNotGenerateAcw=true)]
	public abstract partial class CTInAppBaseFragment : global::Android.App.Fragment {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFragment.CTInAppNativeButtonClickListener']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFragment$CTInAppNativeButtonClickListener", DoNotGenerateAcw=true)]
		public partial class CTInAppNativeButtonClickListener : global::Java.Lang.Object, global::Android.Views.View.IOnClickListener {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFragment$CTInAppNativeButtonClickListener", typeof (CTInAppNativeButtonClickListener));
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

			protected CTInAppNativeButtonClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.CTInAppNativeButtonClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.CTInAppNativeButtonClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (view);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFragment.CTInAppNativeButtonClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
			public virtual unsafe void OnClick (global::Android.Views.View view)
			{
				const string __id = "onClick.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInAppBaseFragment.InAppListener']"
		[Register ("com/clevertap/android/sdk/CTInAppBaseFragment$InAppListener", "", "Com.Clevertap.Android.Sdk.CTInAppBaseFragment/IInAppListenerInvoker")]
		public partial interface IInAppListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInAppBaseFragment.InAppListener']/method[@name='inAppNotificationDidClick' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.CTInAppNotification'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("inAppNotificationDidClick", "(Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;Ljava/util/HashMap;)V", "GetInAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_Handler:Com.Clevertap.Android.Sdk.CTInAppBaseFragment/IInAppListenerInvoker, CleverTap.Bindings.Android")]
			void InAppNotificationDidClick (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1, global::System.Collections.Generic.IDictionary<string, string> p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInAppBaseFragment.InAppListener']/method[@name='inAppNotificationDidDismiss' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CTInAppNotification'] and parameter[3][@type='android.os.Bundle']]"
			[Register ("inAppNotificationDidDismiss", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V", "GetInAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler:Com.Clevertap.Android.Sdk.CTInAppBaseFragment/IInAppListenerInvoker, CleverTap.Bindings.Android")]
			void InAppNotificationDidDismiss (global::Android.Content.Context p0, global::Com.Clevertap.Android.Sdk.CTInAppNotification p1, global::Android.OS.Bundle p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInAppBaseFragment.InAppListener']/method[@name='inAppNotificationDidShow' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.CTInAppNotification'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("inAppNotificationDidShow", "(Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V", "GetInAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler:Com.Clevertap.Android.Sdk.CTInAppBaseFragment/IInAppListenerInvoker, CleverTap.Bindings.Android")]
			void InAppNotificationDidShow (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1);

		}

		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFragment$InAppListener", DoNotGenerateAcw=true)]
		internal partial class IInAppListenerInvoker : global::Java.Lang.Object, IInAppListener {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFragment$InAppListener", typeof (IInAppListenerInvoker));

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

			public static IInAppListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInAppListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.CTInAppBaseFragment.InAppListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInAppListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_;
#pragma warning disable 0169
			static Delegate GetInAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_Handler ()
			{
				if (cb_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ == null)
					cb_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_);
				return cb_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_;
			}

			static void n_InAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInAppNotification p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.InAppNotificationDidClick (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_;
			public unsafe void InAppNotificationDidClick (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1, global::System.Collections.Generic.IDictionary<string, string> p2)
			{
				if (id_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ == IntPtr.Zero)
					id_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "inAppNotificationDidClick", "(Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;Ljava/util/HashMap;)V");
				IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppNotificationDidClick_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetInAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler ()
			{
				if (cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ == null)
					cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_);
				return cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
			}

			static void n_InAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInAppNotification p1 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.InAppNotificationDidDismiss (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
			public unsafe void InAppNotificationDidDismiss (global::Android.Content.Context p0, global::Com.Clevertap.Android.Sdk.CTInAppNotification p1, global::Android.OS.Bundle p2)
			{
				if (id_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ == IntPtr.Zero)
					id_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "inAppNotificationDidDismiss", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_, __args);
			}

			static Delegate cb_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetInAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler ()
			{
				if (cb_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ == null)
					cb_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_);
				return cb_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
			}

			static void n_InAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInAppNotification p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.InAppNotificationDidShow (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
			public unsafe void InAppNotificationDidShow (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1)
			{
				if (id_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ == IntPtr.Zero)
					id_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "inAppNotificationDidShow", "(Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inAppNotificationDidShow_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_, __args);
			}

		}

		// event args for com.clevertap.android.sdk.CTInAppBaseFragment.InAppListener.inAppNotificationDidClick
		public partial class InAppNotificationDidClickEventArgs : global::System.EventArgs {

			public InAppNotificationDidClickEventArgs (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1, global::System.Collections.Generic.IDictionary<string, string> p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Clevertap.Android.Sdk.CTInAppNotification p0;
			public global::Com.Clevertap.Android.Sdk.CTInAppNotification P0 {
				get { return p0; }
			}

			global::Android.OS.Bundle p1;
			public global::Android.OS.Bundle P1 {
				get { return p1; }
			}

			global::System.Collections.Generic.IDictionary<string, string> p2;
			public global::System.Collections.Generic.IDictionary<string, string> P2 {
				get { return p2; }
			}
		}

		// event args for com.clevertap.android.sdk.CTInAppBaseFragment.InAppListener.inAppNotificationDidDismiss
		public partial class InAppNotificationDidDismissEventArgs : global::System.EventArgs {

			public InAppNotificationDidDismissEventArgs (global::Android.Content.Context p0, global::Com.Clevertap.Android.Sdk.CTInAppNotification p1, global::Android.OS.Bundle p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Android.Content.Context p0;
			public global::Android.Content.Context P0 {
				get { return p0; }
			}

			global::Com.Clevertap.Android.Sdk.CTInAppNotification p1;
			public global::Com.Clevertap.Android.Sdk.CTInAppNotification P1 {
				get { return p1; }
			}

			global::Android.OS.Bundle p2;
			public global::Android.OS.Bundle P2 {
				get { return p2; }
			}
		}

		// event args for com.clevertap.android.sdk.CTInAppBaseFragment.InAppListener.inAppNotificationDidShow
		public partial class InAppNotificationDidShowEventArgs : global::System.EventArgs {

			public InAppNotificationDidShowEventArgs (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Clevertap.Android.Sdk.CTInAppNotification p0;
			public global::Com.Clevertap.Android.Sdk.CTInAppNotification P0 {
				get { return p0; }
			}

			global::Android.OS.Bundle p1;
			public global::Android.OS.Bundle P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/CTInAppBaseFragment_InAppListenerImplementor")]
		internal sealed partial class IInAppListenerImplementor : global::Java.Lang.Object, IInAppListener {

			object sender;

			public IInAppListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/CTInAppBaseFragment_InAppListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InAppNotificationDidClickEventArgs> InAppNotificationDidClickHandler;
#pragma warning restore 0649

			public void InAppNotificationDidClick (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1, global::System.Collections.Generic.IDictionary<string, string> p2)
			{
				var __h = InAppNotificationDidClickHandler;
				if (__h != null)
					__h (sender, new InAppNotificationDidClickEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<InAppNotificationDidDismissEventArgs> InAppNotificationDidDismissHandler;
#pragma warning restore 0649

			public void InAppNotificationDidDismiss (global::Android.Content.Context p0, global::Com.Clevertap.Android.Sdk.CTInAppNotification p1, global::Android.OS.Bundle p2)
			{
				var __h = InAppNotificationDidDismissHandler;
				if (__h != null)
					__h (sender, new InAppNotificationDidDismissEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<InAppNotificationDidShowEventArgs> InAppNotificationDidShowHandler;
#pragma warning restore 0649

			public void InAppNotificationDidShow (global::Com.Clevertap.Android.Sdk.CTInAppNotification p0, global::Android.OS.Bundle p1)
			{
				var __h = InAppNotificationDidShowHandler;
				if (__h != null)
					__h (sender, new InAppNotificationDidShowEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IInAppListenerImplementor value)
			{
				return value.InAppNotificationDidClickHandler == null && value.InAppNotificationDidDismissHandler == null && value.InAppNotificationDidShowHandler == null;
			}
		}


		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFragment", typeof (CTInAppBaseFragment));
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

		protected CTInAppBaseFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInAppBaseFragment']/constructor[@name='CTInAppBaseFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInAppBaseFragment ()
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

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInAppBaseFragment", DoNotGenerateAcw=true)]
	internal partial class CTInAppBaseFragmentInvoker : CTInAppBaseFragment {

		public CTInAppBaseFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInAppBaseFragment", typeof (CTInAppBaseFragmentInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
