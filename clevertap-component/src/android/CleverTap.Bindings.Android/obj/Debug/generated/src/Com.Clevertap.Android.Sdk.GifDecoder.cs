using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='GifDecoder']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/GifDecoder", DoNotGenerateAcw=true)]
	public partial class GifDecoder : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']"
		[Register ("com/clevertap/android/sdk/GifDecoder$BitmapProvider", "", "Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker")]
		public partial interface IBitmapProvider : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']/method[@name='obtain' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap.Config']]"
			[Register ("obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetObtain_IILandroid_graphics_Bitmap_Config_Handler:Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker, CleverTap.Bindings.Android")]
			global::Android.Graphics.Bitmap Obtain (int p0, int p1, global::Android.Graphics.Bitmap.Config p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']/method[@name='obtainByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("obtainByteArray", "(I)[B", "GetObtainByteArray_IHandler:Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker, CleverTap.Bindings.Android")]
			byte[] ObtainByteArray (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']/method[@name='obtainIntArray' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("obtainIntArray", "(I)[I", "GetObtainIntArray_IHandler:Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker, CleverTap.Bindings.Android")]
			int[] ObtainIntArray (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("release", "(Landroid/graphics/Bitmap;)V", "GetRelease_Landroid_graphics_Bitmap_Handler:Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker, CleverTap.Bindings.Android")]
			void Release (global::Android.Graphics.Bitmap p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("release", "([B)V", "GetRelease_arrayBHandler:Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker, CleverTap.Bindings.Android")]
			void Release (byte[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='GifDecoder.BitmapProvider']/method[@name='release' and count(parameter)=1 and parameter[1][@type='int[]']]"
			[Register ("release", "([I)V", "GetRelease_arrayIHandler:Com.Clevertap.Android.Sdk.GifDecoder/IBitmapProviderInvoker, CleverTap.Bindings.Android")]
			void Release (int[] p0);

		}

		[global::Android.Runtime.Register ("com/clevertap/android/sdk/GifDecoder$BitmapProvider", DoNotGenerateAcw=true)]
		internal partial class IBitmapProviderInvoker : global::Java.Lang.Object, IBitmapProvider {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/GifDecoder$BitmapProvider", typeof (IBitmapProviderInvoker));

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

			public static IBitmapProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBitmapProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.GifDecoder.BitmapProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBitmapProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_obtain_IILandroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
			static Delegate GetObtain_IILandroid_graphics_Bitmap_Config_Handler ()
			{
				if (cb_obtain_IILandroid_graphics_Bitmap_Config_ == null)
					cb_obtain_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_Obtain_IILandroid_graphics_Bitmap_Config_);
				return cb_obtain_IILandroid_graphics_Bitmap_Config_;
			}

			static IntPtr n_Obtain_IILandroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap.Config p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Obtain (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_obtain_IILandroid_graphics_Bitmap_Config_;
			public unsafe global::Android.Graphics.Bitmap Obtain (int p0, int p1, global::Android.Graphics.Bitmap.Config p2)
			{
				if (id_obtain_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
					id_obtain_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID (class_ref, "obtain", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtain_IILandroid_graphics_Bitmap_Config_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_obtainByteArray_I;
#pragma warning disable 0169
			static Delegate GetObtainByteArray_IHandler ()
			{
				if (cb_obtainByteArray_I == null)
					cb_obtainByteArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ObtainByteArray_I);
				return cb_obtainByteArray_I;
			}

			static IntPtr n_ObtainByteArray_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.ObtainByteArray (p0));
			}
#pragma warning restore 0169

			IntPtr id_obtainByteArray_I;
			public unsafe byte[] ObtainByteArray (int p0)
			{
				if (id_obtainByteArray_I == IntPtr.Zero)
					id_obtainByteArray_I = JNIEnv.GetMethodID (class_ref, "obtainByteArray", "(I)[B");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainByteArray_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			}

			static Delegate cb_obtainIntArray_I;
#pragma warning disable 0169
			static Delegate GetObtainIntArray_IHandler ()
			{
				if (cb_obtainIntArray_I == null)
					cb_obtainIntArray_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ObtainIntArray_I);
				return cb_obtainIntArray_I;
			}

			static IntPtr n_ObtainIntArray_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.ObtainIntArray (p0));
			}
#pragma warning restore 0169

			IntPtr id_obtainIntArray_I;
			public unsafe int[] ObtainIntArray (int p0)
			{
				if (id_obtainIntArray_I == IntPtr.Zero)
					id_obtainIntArray_I = JNIEnv.GetMethodID (class_ref, "obtainIntArray", "(I)[I");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainIntArray_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			}

			static Delegate cb_release_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetRelease_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_release_Landroid_graphics_Bitmap_ == null)
					cb_release_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Landroid_graphics_Bitmap_);
				return cb_release_Landroid_graphics_Bitmap_;
			}

			static void n_Release_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Release (p0);
			}
#pragma warning restore 0169

			IntPtr id_release_Landroid_graphics_Bitmap_;
			public unsafe void Release (global::Android.Graphics.Bitmap p0)
			{
				if (id_release_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_release_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "release", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_Landroid_graphics_Bitmap_, __args);
			}

			static Delegate cb_release_arrayB;
#pragma warning disable 0169
			static Delegate GetRelease_arrayBHandler ()
			{
				if (cb_release_arrayB == null)
					cb_release_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_arrayB);
				return cb_release_arrayB;
			}

			static void n_Release_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Release (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_release_arrayB;
			public unsafe void Release (byte[] p0)
			{
				if (id_release_arrayB == IntPtr.Zero)
					id_release_arrayB = JNIEnv.GetMethodID (class_ref, "release", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_arrayB, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
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

			static void n_Release_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.GifDecoder.IBitmapProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.Release (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_release_arrayI;
			public unsafe void Release (int[] p0)
			{
				if (id_release_arrayI == IntPtr.Zero)
					id_release_arrayI = JNIEnv.GetMethodID (class_ref, "release", "([I)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_arrayI, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/GifDecoder", typeof (GifDecoder));
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

		protected GifDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
