using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTExperimentsListener']"
	[Register ("com/clevertap/android/sdk/CTExperimentsListener", "", "Com.Clevertap.Android.Sdk.ICTExperimentsListenerInvoker")]
	public partial interface ICTExperimentsListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CTExperimentsListener']/method[@name='CTExperimentsUpdated' and count(parameter)=0]"
		[Register ("CTExperimentsUpdated", "()V", "GetCTExperimentsUpdatedHandler:Com.Clevertap.Android.Sdk.ICTExperimentsListenerInvoker, CleverTap.Bindings.Android")]
		void CTExperimentsUpdated ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTExperimentsListener", DoNotGenerateAcw=true)]
	internal partial class ICTExperimentsListenerInvoker : global::Java.Lang.Object, ICTExperimentsListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTExperimentsListener", typeof (ICTExperimentsListenerInvoker));

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

		public static ICTExperimentsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICTExperimentsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.CTExperimentsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICTExperimentsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_CTExperimentsUpdated;
#pragma warning disable 0169
		static Delegate GetCTExperimentsUpdatedHandler ()
		{
			if (cb_CTExperimentsUpdated == null)
				cb_CTExperimentsUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CTExperimentsUpdated);
			return cb_CTExperimentsUpdated;
		}

		static void n_CTExperimentsUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.ICTExperimentsListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTExperimentsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CTExperimentsUpdated ();
		}
#pragma warning restore 0169

		IntPtr id_CTExperimentsUpdated;
		public unsafe void CTExperimentsUpdated ()
		{
			if (id_CTExperimentsUpdated == IntPtr.Zero)
				id_CTExperimentsUpdated = JNIEnv.GetMethodID (class_ref, "CTExperimentsUpdated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_CTExperimentsUpdated);
		}

	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/CTExperimentsListenerImplementor")]
	internal sealed partial class ICTExperimentsListenerImplementor : global::Java.Lang.Object, ICTExperimentsListener {

		object sender;

		public ICTExperimentsListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/CTExperimentsListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void CTExperimentsUpdated ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICTExperimentsListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
