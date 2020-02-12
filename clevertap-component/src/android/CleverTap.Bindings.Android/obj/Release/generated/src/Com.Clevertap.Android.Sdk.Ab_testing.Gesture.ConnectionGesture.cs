using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Ab_testing.Gesture {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.gesture']/class[@name='ConnectionGesture']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture", DoNotGenerateAcw=true)]
	public partial class ConnectionGesture : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.gesture']/interface[@name='ConnectionGesture.OnGestureListener']"
		[Register ("com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture$OnGestureListener", "", "Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture/IOnGestureListenerInvoker")]
		public partial interface IOnGestureListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.gesture']/interface[@name='ConnectionGesture.OnGestureListener']/method[@name='onGesture' and count(parameter)=0]"
			[Register ("onGesture", "()V", "GetOnGestureHandler:Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture/IOnGestureListenerInvoker, CleverTap.Bindings.Android")]
			void OnGesture ();

		}

		[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture$OnGestureListener", DoNotGenerateAcw=true)]
		internal partial class IOnGestureListenerInvoker : global::Java.Lang.Object, IOnGestureListener {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture$OnGestureListener", typeof (IOnGestureListenerInvoker));

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

			public static IOnGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.ab_testing.gesture.ConnectionGesture.OnGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onGesture;
#pragma warning disable 0169
			static Delegate GetOnGestureHandler ()
			{
				if (cb_onGesture == null)
					cb_onGesture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGesture);
				return cb_onGesture;
			}

			static void n_OnGesture (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture.IOnGestureListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture.IOnGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnGesture ();
			}
#pragma warning restore 0169

			IntPtr id_onGesture;
			public unsafe void OnGesture ()
			{
				if (id_onGesture == IntPtr.Zero)
					id_onGesture = JNIEnv.GetMethodID (class_ref, "onGesture", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGesture);
			}

		}

		[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture_OnGestureListenerImplementor")]
		internal sealed partial class IOnGestureListenerImplementor : global::Java.Lang.Object, IOnGestureListener {

			object sender;

			public IOnGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture_OnGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnGesture ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnGestureListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture", typeof (ConnectionGesture));
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

		protected ConnectionGesture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.gesture']/class[@name='ConnectionGesture']/constructor[@name='ConnectionGesture' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.ab_testing.gesture.ConnectionGesture.OnGestureListener']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture$OnGestureListener;)V", "")]
		public unsafe ConnectionGesture (global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture.IOnGestureListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/ab_testing/gesture/ConnectionGesture$OnGestureListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
#pragma warning disable 0169
		static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler ()
		{
			if (cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
				cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAccuracyChanged_Landroid_hardware_Sensor_I);
			return cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_sensor, int native_accuracy)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Sensor sensor = global::Java.Lang.Object.GetObject<global::Android.Hardware.Sensor> (native_sensor, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorStatus accuracy = (global::Android.Hardware.SensorStatus) native_accuracy;
			__this.OnAccuracyChanged (sensor, accuracy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.gesture']/class[@name='ConnectionGesture']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public virtual unsafe void OnAccuracyChanged (global::Android.Hardware.Sensor sensor, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus accuracy)
		{
			const string __id = "onAccuracyChanged.(Landroid/hardware/Sensor;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sensor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sensor).Handle);
				__args [1] = new JniArgumentValue ((int) accuracy);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
#pragma warning disable 0169
		static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler ()
		{
			if (cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
				cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSensorChanged_Landroid_hardware_SensorEvent_);
			return cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		static void n_OnSensorChanged_Landroid_hardware_SensorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorEvent e = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnSensorChanged (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.gesture']/class[@name='ConnectionGesture']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public virtual unsafe void OnSensorChanged (global::Android.Hardware.SensorEvent e)
		{
			const string __id = "onSensorChanged.(Landroid/hardware/SensorEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
