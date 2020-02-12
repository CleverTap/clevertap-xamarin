using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInboxListener']"
	[Register ("com/clevertap/android/sdk/CTInboxListener", "", "Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker")]
	public partial interface ICTInboxListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInboxListener']/method[@name='inboxDidInitialize' and count(parameter)=0]"
		[Register ("inboxDidInitialize", "()V", "GetInboxDidInitializeHandler:Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker, CleverTap.Bindings.Android")]
		void InboxDidInitialize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTInboxListener']/method[@name='inboxMessagesDidUpdate' and count(parameter)=0]"
		[Register ("inboxMessagesDidUpdate", "()V", "GetInboxMessagesDidUpdateHandler:Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker, CleverTap.Bindings.Android")]
		void InboxMessagesDidUpdate ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxListener", DoNotGenerateAcw=true)]
	internal partial class ICTInboxListenerInvoker : global::Java.Lang.Object, ICTInboxListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxListener", typeof (ICTInboxListenerInvoker));

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

		public static ICTInboxListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICTInboxListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.CTInboxListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICTInboxListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_inboxDidInitialize;
#pragma warning disable 0169
		static Delegate GetInboxDidInitializeHandler ()
		{
			if (cb_inboxDidInitialize == null)
				cb_inboxDidInitialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InboxDidInitialize);
			return cb_inboxDidInitialize;
		}

		static void n_InboxDidInitialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.ICTInboxListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTInboxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InboxDidInitialize ();
		}
#pragma warning restore 0169

		IntPtr id_inboxDidInitialize;
		public unsafe void InboxDidInitialize ()
		{
			if (id_inboxDidInitialize == IntPtr.Zero)
				id_inboxDidInitialize = JNIEnv.GetMethodID (class_ref, "inboxDidInitialize", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inboxDidInitialize);
		}

		static Delegate cb_inboxMessagesDidUpdate;
#pragma warning disable 0169
		static Delegate GetInboxMessagesDidUpdateHandler ()
		{
			if (cb_inboxMessagesDidUpdate == null)
				cb_inboxMessagesDidUpdate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InboxMessagesDidUpdate);
			return cb_inboxMessagesDidUpdate;
		}

		static void n_InboxMessagesDidUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.ICTInboxListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTInboxListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InboxMessagesDidUpdate ();
		}
#pragma warning restore 0169

		IntPtr id_inboxMessagesDidUpdate;
		public unsafe void InboxMessagesDidUpdate ()
		{
			if (id_inboxMessagesDidUpdate == IntPtr.Zero)
				id_inboxMessagesDidUpdate = JNIEnv.GetMethodID (class_ref, "inboxMessagesDidUpdate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inboxMessagesDidUpdate);
		}

	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/CTInboxListenerImplementor")]
	internal sealed partial class ICTInboxListenerImplementor : global::Java.Lang.Object, ICTInboxListener {

		object sender;

		public ICTInboxListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/CTInboxListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler InboxDidInitializeHandler;
#pragma warning restore 0649

		public void InboxDidInitialize ()
		{
			var __h = InboxDidInitializeHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler InboxMessagesDidUpdateHandler;
#pragma warning restore 0649

		public void InboxMessagesDidUpdate ()
		{
			var __h = InboxMessagesDidUpdateHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICTInboxListenerImplementor value)
		{
			return value.InboxDidInitializeHandler == null && value.InboxMessagesDidUpdateHandler == null;
		}
	}

}
