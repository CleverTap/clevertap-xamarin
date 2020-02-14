using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='GifHeaderParser']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/GifHeaderParser", DoNotGenerateAcw=true)]
	public partial class GifHeaderParser : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/GifHeaderParser", typeof (GifHeaderParser));
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

		protected GifHeaderParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isAnimated;
#pragma warning disable 0169
		static Delegate GetIsAnimatedHandler ()
		{
			if (cb_isAnimated == null)
				cb_isAnimated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimated);
			return cb_isAnimated;
		}

		static bool n_IsAnimated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimated;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAnimated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='GifHeaderParser']/method[@name='isAnimated' and count(parameter)=0]"
			[Register ("isAnimated", "()Z", "GetIsAnimatedHandler")]
			get {
				const string __id = "isAnimated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='GifHeaderParser']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetData_arrayBHandler ()
		{
			if (cb_setData_arrayB == null)
				cb_setData_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_arrayB);
			return cb_setData_arrayB;
		}

		static IntPtr n_SetData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Clevertap.Android.Sdk.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetData (data));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='GifHeaderParser']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setData", "([B)Ljava/lang/Object;", "GetSetData_arrayBHandler")]
		public virtual unsafe global::Java.Lang.Object SetData (byte[] data)
		{
			const string __id = "setData.([B)Ljava/lang/Object;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_setData_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_setData_Ljava_nio_ByteBuffer_ == null)
				cb_setData_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_nio_ByteBuffer_);
			return cb_setData_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_SetData_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Clevertap.Android.Sdk.GifHeaderParser __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifHeaderParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetData (data));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='GifHeaderParser']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("setData", "(Ljava/nio/ByteBuffer;)Ljava/lang/Object;", "GetSetData_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Java.Lang.Object SetData (global::Java.Nio.ByteBuffer data)
		{
			const string __id = "setData.(Ljava/nio/ByteBuffer;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
