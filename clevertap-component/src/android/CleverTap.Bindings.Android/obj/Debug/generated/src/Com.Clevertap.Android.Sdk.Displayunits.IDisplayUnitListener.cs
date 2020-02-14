using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Displayunits {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/interface[@name='DisplayUnitListener']"
	[Register ("com/clevertap/android/sdk/displayunits/DisplayUnitListener", "", "Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerInvoker")]
	public partial interface IDisplayUnitListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits']/interface[@name='DisplayUnitListener']/method[@name='onDisplayUnitsLoaded' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.clevertap.android.sdk.displayunits.model.CleverTapDisplayUnit&gt;']]"
		[Register ("onDisplayUnitsLoaded", "(Ljava/util/ArrayList;)V", "GetOnDisplayUnitsLoaded_Ljava_util_ArrayList_Handler:Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerInvoker, CleverTap.Bindings.Android")]
		void OnDisplayUnitsLoaded (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/displayunits/DisplayUnitListener", DoNotGenerateAcw=true)]
	internal partial class IDisplayUnitListenerInvoker : global::Java.Lang.Object, IDisplayUnitListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/displayunits/DisplayUnitListener", typeof (IDisplayUnitListenerInvoker));

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

		public static IDisplayUnitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDisplayUnitListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.displayunits.DisplayUnitListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDisplayUnitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDisplayUnitsLoaded_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnDisplayUnitsLoaded_Ljava_util_ArrayList_Handler ()
		{
			if (cb_onDisplayUnitsLoaded_Ljava_util_ArrayList_ == null)
				cb_onDisplayUnitsLoaded_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDisplayUnitsLoaded_Ljava_util_ArrayList_);
			return cb_onDisplayUnitsLoaded_Ljava_util_ArrayList_;
		}

		static void n_OnDisplayUnitsLoaded_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisplayUnitsLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDisplayUnitsLoaded_Ljava_util_ArrayList_;
		public unsafe void OnDisplayUnitsLoaded (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> p0)
		{
			if (id_onDisplayUnitsLoaded_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_onDisplayUnitsLoaded_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "onDisplayUnitsLoaded", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisplayUnitsLoaded_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.clevertap.android.sdk.displayunits.DisplayUnitListener.onDisplayUnitsLoaded
	public partial class DisplayUnitEventArgs : global::System.EventArgs {

		public DisplayUnitEventArgs (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> p0;
		public global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/displayunits/DisplayUnitListenerImplementor")]
	internal sealed partial class IDisplayUnitListenerImplementor : global::Java.Lang.Object, IDisplayUnitListener {

		object sender;

		public IDisplayUnitListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/displayunits/DisplayUnitListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DisplayUnitEventArgs> Handler;
#pragma warning restore 0649

		public void OnDisplayUnitsLoaded (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnit> p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DisplayUnitEventArgs (p0));
		}

		internal static bool __IsEmpty (IDisplayUnitListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
