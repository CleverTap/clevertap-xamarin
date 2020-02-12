using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WrappedByteChannel']"
	[Register ("com/clevertap/android/sdk/java_websocket/WrappedByteChannel", "", "Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannelInvoker")]
	public partial interface IWrappedByteChannel : global::Java.Nio.Channels.IByteChannel {

		bool IsBlocking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WrappedByteChannel']/method[@name='isBlocking' and count(parameter)=0]"
			[Register ("isBlocking", "()Z", "GetIsBlockingHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannelInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsNeedRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WrappedByteChannel']/method[@name='isNeedRead' and count(parameter)=0]"
			[Register ("isNeedRead", "()Z", "GetIsNeedReadHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannelInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsNeedWrite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WrappedByteChannel']/method[@name='isNeedWrite' and count(parameter)=0]"
			[Register ("isNeedWrite", "()Z", "GetIsNeedWriteHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannelInvoker, CleverTap.Bindings.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WrappedByteChannel']/method[@name='readMore' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readMore", "(Ljava/nio/ByteBuffer;)I", "GetReadMore_Ljava_nio_ByteBuffer_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannelInvoker, CleverTap.Bindings.Android")]
		int ReadMore (global::Java.Nio.ByteBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WrappedByteChannel']/method[@name='writeMore' and count(parameter)=0]"
		[Register ("writeMore", "()V", "GetWriteMoreHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannelInvoker, CleverTap.Bindings.Android")]
		void WriteMore ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WrappedByteChannel", DoNotGenerateAcw=true)]
	internal partial class IWrappedByteChannelInvoker : global::Java.Lang.Object, IWrappedByteChannel {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WrappedByteChannel", typeof (IWrappedByteChannelInvoker));

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

		public static IWrappedByteChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWrappedByteChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.WrappedByteChannel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWrappedByteChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isBlocking;
#pragma warning disable 0169
		static Delegate GetIsBlockingHandler ()
		{
			if (cb_isBlocking == null)
				cb_isBlocking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlocking);
			return cb_isBlocking;
		}

		static bool n_IsBlocking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBlocking;
		}
#pragma warning restore 0169

		IntPtr id_isBlocking;
		public unsafe bool IsBlocking {
			get {
				if (id_isBlocking == IntPtr.Zero)
					id_isBlocking = JNIEnv.GetMethodID (class_ref, "isBlocking", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBlocking);
			}
		}

		static Delegate cb_isNeedRead;
#pragma warning disable 0169
		static Delegate GetIsNeedReadHandler ()
		{
			if (cb_isNeedRead == null)
				cb_isNeedRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedRead);
			return cb_isNeedRead;
		}

		static bool n_IsNeedRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedRead;
		}
#pragma warning restore 0169

		IntPtr id_isNeedRead;
		public unsafe bool IsNeedRead {
			get {
				if (id_isNeedRead == IntPtr.Zero)
					id_isNeedRead = JNIEnv.GetMethodID (class_ref, "isNeedRead", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNeedRead);
			}
		}

		static Delegate cb_isNeedWrite;
#pragma warning disable 0169
		static Delegate GetIsNeedWriteHandler ()
		{
			if (cb_isNeedWrite == null)
				cb_isNeedWrite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedWrite);
			return cb_isNeedWrite;
		}

		static bool n_IsNeedWrite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedWrite;
		}
#pragma warning restore 0169

		IntPtr id_isNeedWrite;
		public unsafe bool IsNeedWrite {
			get {
				if (id_isNeedWrite == IntPtr.Zero)
					id_isNeedWrite = JNIEnv.GetMethodID (class_ref, "isNeedWrite", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNeedWrite);
			}
		}

		static Delegate cb_readMore_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadMore_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_readMore_Ljava_nio_ByteBuffer_ == null)
				cb_readMore_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadMore_Ljava_nio_ByteBuffer_);
			return cb_readMore_Ljava_nio_ByteBuffer_;
		}

		static int n_ReadMore_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadMore (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readMore_Ljava_nio_ByteBuffer_;
		public unsafe int ReadMore (global::Java.Nio.ByteBuffer p0)
		{
			if (id_readMore_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readMore_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "readMore", "(Ljava/nio/ByteBuffer;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readMore_Ljava_nio_ByteBuffer_, __args);
			return __ret;
		}

		static Delegate cb_writeMore;
#pragma warning disable 0169
		static Delegate GetWriteMoreHandler ()
		{
			if (cb_writeMore == null)
				cb_writeMore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteMore);
			return cb_writeMore;
		}

		static void n_WriteMore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteMore ();
		}
#pragma warning restore 0169

		IntPtr id_writeMore;
		public unsafe void WriteMore ()
		{
			if (id_writeMore == IntPtr.Zero)
				id_writeMore = JNIEnv.GetMethodID (class_ref, "writeMore", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeMore);
		}

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static int n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (dst);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Ljava_nio_ByteBuffer_;
		public unsafe global::System.Int32 Read (global::Java.Nio.ByteBuffer dst)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
			return __ret;
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe global::System.Boolean IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static int n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWrappedByteChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer src = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_src, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Write (src);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_Ljava_nio_ByteBuffer_;
		public unsafe global::System.Int32 Write (global::Java.Nio.ByteBuffer src)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
			global::System.Int32 __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
			return __ret;
		}

	}

}
