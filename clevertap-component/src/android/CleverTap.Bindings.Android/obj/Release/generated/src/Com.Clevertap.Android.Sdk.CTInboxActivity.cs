using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxActivity']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxActivity", DoNotGenerateAcw=true)]
	public partial class CTInboxActivity : global::Android.Support.V4.App.FragmentActivity, global::Com.Clevertap.Android.Sdk.CTInboxListViewFragment.IInboxListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInboxActivity.InboxActivityListener']"
		[Register ("com/clevertap/android/sdk/CTInboxActivity$InboxActivityListener", "", "Com.Clevertap.Android.Sdk.CTInboxActivity/IInboxActivityListenerInvoker")]
		public partial interface IInboxActivityListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInboxActivity.InboxActivityListener']/method[@name='messageDidClick' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.CTInboxActivity'] and parameter[2][@type='com.clevertap.android.sdk.CTInboxMessage'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("messageDidClick", "(Lcom/clevertap/android/sdk/CTInboxActivity;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;Ljava/util/HashMap;)V", "GetMessageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_Handler:Com.Clevertap.Android.Sdk.CTInboxActivity/IInboxActivityListenerInvoker, CleverTap.Bindings.Android")]
			void MessageDidClick (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2, global::System.Collections.Generic.IDictionary<string, string> p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInboxActivity.InboxActivityListener']/method[@name='messageDidShow' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.CTInboxActivity'] and parameter[2][@type='com.clevertap.android.sdk.CTInboxMessage'] and parameter[3][@type='android.os.Bundle']]"
			[Register ("messageDidShow", "(Lcom/clevertap/android/sdk/CTInboxActivity;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;)V", "GetMessageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Handler:Com.Clevertap.Android.Sdk.CTInboxActivity/IInboxActivityListenerInvoker, CleverTap.Bindings.Android")]
			void MessageDidShow (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2);

		}

		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxActivity$InboxActivityListener", DoNotGenerateAcw=true)]
		internal partial class IInboxActivityListenerInvoker : global::Java.Lang.Object, IInboxActivityListener {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxActivity$InboxActivityListener", typeof (IInboxActivityListenerInvoker));

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

			public static IInboxActivityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInboxActivityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.CTInboxActivity.InboxActivityListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInboxActivityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_;
#pragma warning disable 0169
			static Delegate GetMessageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_Handler ()
			{
				if (cb_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ == null)
					cb_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_);
				return cb_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_;
			}

			static void n_MessageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Clevertap.Android.Sdk.CTInboxActivity.IInboxActivityListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity.IInboxActivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInboxActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInboxMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.MessageDidClick (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_;
			public unsafe void MessageDidClick (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2, global::System.Collections.Generic.IDictionary<string, string> p3)
			{
				if (id_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ == IntPtr.Zero)
					id_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "messageDidClick", "(Lcom/clevertap/android/sdk/CTInboxActivity;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;Ljava/util/HashMap;)V");
				IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_, __args);
				JNIEnv.DeleteLocalRef (native_p3);
			}

			static Delegate cb_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetMessageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Handler ()
			{
				if (cb_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ == null)
					cb_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_);
				return cb_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_;
			}

			static void n_MessageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Clevertap.Android.Sdk.CTInboxActivity.IInboxActivityListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity.IInboxActivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInboxActivity p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.CTInboxMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.MessageDidShow (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_;
			public unsafe void MessageDidShow (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2)
			{
				if (id_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ == IntPtr.Zero)
					id_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "messageDidShow", "(Lcom/clevertap/android/sdk/CTInboxActivity;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_, __args);
			}

		}

		// event args for com.clevertap.android.sdk.CTInboxActivity.InboxActivityListener.messageDidClick
		public partial class MessageDidClickEventArgs : global::System.EventArgs {

			public MessageDidClickEventArgs (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2, global::System.Collections.Generic.IDictionary<string, string> p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Com.Clevertap.Android.Sdk.CTInboxActivity p0;
			public global::Com.Clevertap.Android.Sdk.CTInboxActivity P0 {
				get { return p0; }
			}

			global::Com.Clevertap.Android.Sdk.CTInboxMessage p1;
			public global::Com.Clevertap.Android.Sdk.CTInboxMessage P1 {
				get { return p1; }
			}

			global::Android.OS.Bundle p2;
			public global::Android.OS.Bundle P2 {
				get { return p2; }
			}

			global::System.Collections.Generic.IDictionary<string, string> p3;
			public global::System.Collections.Generic.IDictionary<string, string> P3 {
				get { return p3; }
			}
		}

		// event args for com.clevertap.android.sdk.CTInboxActivity.InboxActivityListener.messageDidShow
		public partial class MessageDidShowEventArgs : global::System.EventArgs {

			public MessageDidShowEventArgs (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Clevertap.Android.Sdk.CTInboxActivity p0;
			public global::Com.Clevertap.Android.Sdk.CTInboxActivity P0 {
				get { return p0; }
			}

			global::Com.Clevertap.Android.Sdk.CTInboxMessage p1;
			public global::Com.Clevertap.Android.Sdk.CTInboxMessage P1 {
				get { return p1; }
			}

			global::Android.OS.Bundle p2;
			public global::Android.OS.Bundle P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/CTInboxActivity_InboxActivityListenerImplementor")]
		internal sealed partial class IInboxActivityListenerImplementor : global::Java.Lang.Object, IInboxActivityListener {

			object sender;

			public IInboxActivityListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/CTInboxActivity_InboxActivityListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MessageDidClickEventArgs> MessageDidClickHandler;
#pragma warning restore 0649

			public void MessageDidClick (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2, global::System.Collections.Generic.IDictionary<string, string> p3)
			{
				var __h = MessageDidClickHandler;
				if (__h != null)
					__h (sender, new MessageDidClickEventArgs (p0, p1, p2, p3));
			}
#pragma warning disable 0649
			public EventHandler<MessageDidShowEventArgs> MessageDidShowHandler;
#pragma warning restore 0649

			public void MessageDidShow (global::Com.Clevertap.Android.Sdk.CTInboxActivity p0, global::Com.Clevertap.Android.Sdk.CTInboxMessage p1, global::Android.OS.Bundle p2)
			{
				var __h = MessageDidShowHandler;
				if (__h != null)
					__h (sender, new MessageDidShowEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IInboxActivityListenerImplementor value)
			{
				return value.MessageDidClickHandler == null && value.MessageDidShowHandler == null;
			}
		}


		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxActivity", typeof (CTInboxActivity));
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

		protected CTInboxActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxActivity']/constructor[@name='CTInboxActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInboxActivity ()
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

		static Delegate cb_messageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetMessageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_Handler ()
		{
			if (cb_messageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ == null)
				cb_messageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_);
			return cb_messageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_;
		}

		static void n_MessageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseContext, IntPtr native_inboxMessage, IntPtr native_data, IntPtr native_keyValue)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxActivity __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context baseContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_baseContext, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInboxMessage inboxMessage = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (native_inboxMessage, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle data = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_data, JniHandleOwnership.DoNotTransfer);
			var keyValue = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_keyValue, JniHandleOwnership.DoNotTransfer);
			__this.MessageDidClick (baseContext, inboxMessage, data, keyValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxActivity']/method[@name='messageDidClick' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CTInboxMessage'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("messageDidClick", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;Ljava/util/HashMap;)V", "GetMessageDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_Handler")]
		public virtual unsafe void MessageDidClick (global::Android.Content.Context baseContext, global::Com.Clevertap.Android.Sdk.CTInboxMessage inboxMessage, global::Android.OS.Bundle data, global::System.Collections.Generic.IDictionary<string, string> keyValue)
		{
			const string __id = "messageDidClick.(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;Ljava/util/HashMap;)V";
			IntPtr native_keyValue = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((baseContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseContext).Handle);
				__args [1] = new JniArgumentValue ((inboxMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inboxMessage).Handle);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [3] = new JniArgumentValue (native_keyValue);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyValue);
			}
		}

		static Delegate cb_messageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetMessageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Handler ()
		{
			if (cb_messageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ == null)
				cb_messageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_);
			return cb_messageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_;
		}

		static void n_MessageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseContext, IntPtr native_inboxMessage, IntPtr native_data)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxActivity __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context baseContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_baseContext, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInboxMessage inboxMessage = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (native_inboxMessage, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle data = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.MessageDidShow (baseContext, inboxMessage, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxActivity']/method[@name='messageDidShow' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CTInboxMessage'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("messageDidShow", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;)V", "GetMessageDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Handler")]
		public virtual unsafe void MessageDidShow (global::Android.Content.Context baseContext, global::Com.Clevertap.Android.Sdk.CTInboxMessage inboxMessage, global::Android.OS.Bundle data)
		{
			const string __id = "messageDidShow.(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((baseContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseContext).Handle);
				__args [1] = new JniArgumentValue ((inboxMessage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inboxMessage).Handle);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_savedInstanceState)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxActivity __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (savedInstanceState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle savedInstanceState)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((savedInstanceState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) savedInstanceState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
