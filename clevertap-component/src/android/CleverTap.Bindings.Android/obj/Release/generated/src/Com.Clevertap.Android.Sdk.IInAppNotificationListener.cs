using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='InAppNotificationListener']"
	[Register ("com/clevertap/android/sdk/InAppNotificationListener", "", "Com.Clevertap.Android.Sdk.IInAppNotificationListenerInvoker")]
	public partial interface IInAppNotificationListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='InAppNotificationListener']/method[@name='beforeShow' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("beforeShow", "(Ljava/util/Map;)Z", "GetBeforeShow_Ljava_util_Map_Handler:Com.Clevertap.Android.Sdk.IInAppNotificationListenerInvoker, CleverTap.Bindings.Android")]
		bool BeforeShow (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='InAppNotificationListener']/method[@name='onDismissed' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onDismissed", "(Ljava/util/Map;Ljava/util/Map;)V", "GetOnDismissed_Ljava_util_Map_Ljava_util_Map_Handler:Com.Clevertap.Android.Sdk.IInAppNotificationListenerInvoker, CleverTap.Bindings.Android")]
		void OnDismissed (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/InAppNotificationListener", DoNotGenerateAcw=true)]
	internal partial class IInAppNotificationListenerInvoker : global::Java.Lang.Object, IInAppNotificationListener {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/InAppNotificationListener", typeof (IInAppNotificationListenerInvoker));

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

		public static IInAppNotificationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInAppNotificationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.InAppNotificationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInAppNotificationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_beforeShow_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetBeforeShow_Ljava_util_Map_Handler ()
		{
			if (cb_beforeShow_Ljava_util_Map_ == null)
				cb_beforeShow_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_BeforeShow_Ljava_util_Map_);
			return cb_beforeShow_Ljava_util_Map_;
		}

		static bool n_BeforeShow_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.IInAppNotificationListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BeforeShow (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_beforeShow_Ljava_util_Map_;
		public unsafe bool BeforeShow (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_beforeShow_Ljava_util_Map_ == IntPtr.Zero)
				id_beforeShow_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "beforeShow", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_beforeShow_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_onDismissed_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnDismissed_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_onDismissed_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_onDismissed_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDismissed_Ljava_util_Map_Ljava_util_Map_);
			return cb_onDismissed_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_OnDismissed_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.IInAppNotificationListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDismissed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDismissed_Ljava_util_Map_Ljava_util_Map_;
		public unsafe void OnDismissed (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_onDismissed_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_onDismissed_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onDismissed", "(Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDismissed_Ljava_util_Map_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.clevertap.android.sdk.InAppNotificationListener.beforeShow
	public partial class BeforeShowEventArgs : global::System.EventArgs {

		public BeforeShowEventArgs (bool handled, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			this.handled = handled;
			this.p0 = p0;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> P0 {
			get { return p0; }
		}
	}

	// event args for com.clevertap.android.sdk.InAppNotificationListener.onDismissed
	public partial class DismissedEventArgs : global::System.EventArgs {

		public DismissedEventArgs (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> P0 {
			get { return p0; }
		}

		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1;
		public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/InAppNotificationListenerImplementor")]
	internal sealed partial class IInAppNotificationListenerImplementor : global::Java.Lang.Object, IInAppNotificationListener {

		object sender;

		public IInAppNotificationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/InAppNotificationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BeforeShowEventArgs> BeforeShowHandler;
#pragma warning restore 0649

		public bool BeforeShow (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			var __h = BeforeShowHandler;
			if (__h == null)
				return false;
			var __e = new BeforeShowEventArgs (true, p0);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<DismissedEventArgs> OnDismissedHandler;
#pragma warning restore 0649

		public void OnDismissed (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			var __h = OnDismissedHandler;
			if (__h != null)
				__h (sender, new DismissedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IInAppNotificationListenerImplementor value)
		{
			return value.BeforeShowHandler == null && value.OnDismissedHandler == null;
		}
	}

}
