using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Ab_testing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/interface[@name='CTABTestListener']"
	[Register ("com/clevertap/android/sdk/ab_testing/CTABTestListener", "", "Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListenerInvoker")]
	public partial interface ICTABTestListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/interface[@name='CTABTestListener']/method[@name='ABExperimentsUpdated' and count(parameter)=0]"
		[Register ("ABExperimentsUpdated", "()V", "GetABExperimentsUpdatedHandler:Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListenerInvoker, CleverTap.Bindings.Android")]
		void ABExperimentsUpdated ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/CTABTestListener", DoNotGenerateAcw=true)]
	internal partial class ICTABTestListenerInvoker : global::Java.Lang.Object, ICTABTestListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/CTABTestListener", typeof (ICTABTestListenerInvoker));

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

		public static ICTABTestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICTABTestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.ab_testing.CTABTestListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICTABTestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_ABExperimentsUpdated;
#pragma warning disable 0169
		static Delegate GetABExperimentsUpdatedHandler ()
		{
			if (cb_ABExperimentsUpdated == null)
				cb_ABExperimentsUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ABExperimentsUpdated);
			return cb_ABExperimentsUpdated;
		}

		static void n_ABExperimentsUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ABExperimentsUpdated ();
		}
#pragma warning restore 0169

		IntPtr id_ABExperimentsUpdated;
		public unsafe void ABExperimentsUpdated ()
		{
			if (id_ABExperimentsUpdated == IntPtr.Zero)
				id_ABExperimentsUpdated = JNIEnv.GetMethodID (class_ref, "ABExperimentsUpdated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ABExperimentsUpdated);
		}

	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/ab_testing/CTABTestListenerImplementor")]
	internal sealed partial class ICTABTestListenerImplementor : global::Java.Lang.Object, ICTABTestListener {

		object sender;

		public ICTABTestListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/ab_testing/CTABTestListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void ABExperimentsUpdated ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICTABTestListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
