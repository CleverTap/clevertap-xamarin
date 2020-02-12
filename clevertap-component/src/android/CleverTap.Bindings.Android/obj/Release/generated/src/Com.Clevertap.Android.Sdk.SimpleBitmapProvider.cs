using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/SimpleBitmapProvider", DoNotGenerateAcw=true)]
	public partial class SimpleBitmapProvider : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/SimpleBitmapProvider", typeof (SimpleBitmapProvider));
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

		protected SimpleBitmapProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/constructor[@name='SimpleBitmapProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleBitmapProvider ()
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

		static Delegate cb_obtain_IILandroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
		static Delegate GetObtain_IILandroid_graphics_Bitmap_Config_Handler ()
		{
			if (cb_obtain_IILandroid_graphics_Bitmap_Config_ == null)
				cb_obtain_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Obtain_IILandroid_graphics_Bitmap_Config_);
			return cb_obtain_IILandroid_graphics_Bitmap_Config_;
		}

		static IntPtr n_Obtain_IILandroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config config = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Obtain (width, height, config));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/method[@name='obtain' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
		[Register ("obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetObtain_IILandroid_graphics_Bitmap_Config_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap Obtain (int width, int height, global::Android.Graphics.Bitmap.Config config)
		{
			const string __id = "obtain.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_obtainByteArray_I;
#pragma warning disable 0169
		static Delegate GetObtainByteArray_IHandler ()
		{
			if (cb_obtainByteArray_I == null)
				cb_obtainByteArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ObtainByteArray_I);
			return cb_obtainByteArray_I;
		}

		static IntPtr n_ObtainByteArray_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ObtainByteArray (size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/method[@name='obtainByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("obtainByteArray", "(I)[B", "GetObtainByteArray_IHandler")]
		public virtual unsafe byte[] ObtainByteArray (int size)
		{
			const string __id = "obtainByteArray.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_obtainIntArray_I;
#pragma warning disable 0169
		static Delegate GetObtainIntArray_IHandler ()
		{
			if (cb_obtainIntArray_I == null)
				cb_obtainIntArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ObtainIntArray_I);
			return cb_obtainIntArray_I;
		}

		static IntPtr n_ObtainIntArray_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ObtainIntArray (size));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/method[@name='obtainIntArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("obtainIntArray", "(I)[I", "GetObtainIntArray_IHandler")]
		public virtual unsafe int[] ObtainIntArray (int size)
		{
			const string __id = "obtainIntArray.(I)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_release_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetRelease_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_release_Landroid_graphics_Bitmap_ == null)
				cb_release_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Landroid_graphics_Bitmap_);
			return cb_release_Landroid_graphics_Bitmap_;
		}

		static void n_Release_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.Release (bitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("release", "(Landroid/graphics/Bitmap;)V", "GetRelease_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void Release (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "release.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_release_arrayB;
#pragma warning disable 0169
		static Delegate GetRelease_arrayBHandler ()
		{
			if (cb_release_arrayB == null)
				cb_release_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_arrayB);
			return cb_release_arrayB;
		}

		static void n_Release_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Release (bytes);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("release", "([B)V", "GetRelease_arrayBHandler")]
		public virtual unsafe void Release (byte[] bytes)
		{
			const string __id = "release.([B)V";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_release_arrayI;
#pragma warning disable 0169
		static Delegate GetRelease_arrayIHandler ()
		{
			if (cb_release_arrayI == null)
				cb_release_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_arrayI);
			return cb_release_arrayI;
		}

		static void n_Release_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.SimpleBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[]) JNIEnv.GetArray (native_array, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.Release (array);
			if (array != null)
				JNIEnv.CopyArray (array, native_array);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='SimpleBitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("release", "([I)V", "GetRelease_arrayIHandler")]
		public virtual unsafe void Release (int[] array)
		{
			const string __id = "release.([I)V";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

	}
}
