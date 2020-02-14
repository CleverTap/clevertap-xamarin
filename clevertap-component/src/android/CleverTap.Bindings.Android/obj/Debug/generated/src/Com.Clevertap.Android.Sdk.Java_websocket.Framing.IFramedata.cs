using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Framing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']"
	[Register ("com/clevertap/android/sdk/java_websocket/framing/Framedata", "", "Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker")]
	public partial interface IFramedata : IJavaObject, IJavaPeerable {

		bool IsFin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='isFin' and count(parameter)=0]"
			[Register ("isFin", "()Z", "GetIsFinHandler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsRSV1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='isRSV1' and count(parameter)=0]"
			[Register ("isRSV1", "()Z", "GetIsRSV1Handler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsRSV2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='isRSV2' and count(parameter)=0]"
			[Register ("isRSV2", "()Z", "GetIsRSV2Handler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsRSV3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='isRSV3' and count(parameter)=0]"
			[Register ("isRSV3", "()Z", "GetIsRSV3Handler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Opcode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='getOpcode' and count(parameter)=0]"
			[Register ("getOpcode", "()Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;", "GetGetOpcodeHandler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		global::Java.Nio.ByteBuffer PayloadData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='getPayloadData' and count(parameter)=0]"
			[Register ("getPayloadData", "()Ljava/nio/ByteBuffer;", "GetGetPayloadDataHandler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		bool TransfereMasked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='getTransfereMasked' and count(parameter)=0]"
			[Register ("getTransfereMasked", "()Z", "GetGetTransfereMaskedHandler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/interface[@name='Framedata']/method[@name='append' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("append", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetAppend_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedataInvoker, CleverTap.Bindings.Android")]
		void Append (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/framing/Framedata", DoNotGenerateAcw=true)]
	internal partial class IFramedataInvoker : global::Java.Lang.Object, IFramedata {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/framing/Framedata", typeof (IFramedataInvoker));

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

		public static IFramedata GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFramedata> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.framing.Framedata"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFramedataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isFin;
#pragma warning disable 0169
		static Delegate GetIsFinHandler ()
		{
			if (cb_isFin == null)
				cb_isFin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFin);
			return cb_isFin;
		}

		static bool n_IsFin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFin;
		}
#pragma warning restore 0169

		IntPtr id_isFin;
		public unsafe bool IsFin {
			get {
				if (id_isFin == IntPtr.Zero)
					id_isFin = JNIEnv.GetMethodID (class_ref, "isFin", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFin);
			}
		}

		static Delegate cb_isRSV1;
#pragma warning disable 0169
		static Delegate GetIsRSV1Handler ()
		{
			if (cb_isRSV1 == null)
				cb_isRSV1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRSV1);
			return cb_isRSV1;
		}

		static bool n_IsRSV1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRSV1;
		}
#pragma warning restore 0169

		IntPtr id_isRSV1;
		public unsafe bool IsRSV1 {
			get {
				if (id_isRSV1 == IntPtr.Zero)
					id_isRSV1 = JNIEnv.GetMethodID (class_ref, "isRSV1", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRSV1);
			}
		}

		static Delegate cb_isRSV2;
#pragma warning disable 0169
		static Delegate GetIsRSV2Handler ()
		{
			if (cb_isRSV2 == null)
				cb_isRSV2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRSV2);
			return cb_isRSV2;
		}

		static bool n_IsRSV2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRSV2;
		}
#pragma warning restore 0169

		IntPtr id_isRSV2;
		public unsafe bool IsRSV2 {
			get {
				if (id_isRSV2 == IntPtr.Zero)
					id_isRSV2 = JNIEnv.GetMethodID (class_ref, "isRSV2", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRSV2);
			}
		}

		static Delegate cb_isRSV3;
#pragma warning disable 0169
		static Delegate GetIsRSV3Handler ()
		{
			if (cb_isRSV3 == null)
				cb_isRSV3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRSV3);
			return cb_isRSV3;
		}

		static bool n_IsRSV3 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRSV3;
		}
#pragma warning restore 0169

		IntPtr id_isRSV3;
		public unsafe bool IsRSV3 {
			get {
				if (id_isRSV3 == IntPtr.Zero)
					id_isRSV3 = JNIEnv.GetMethodID (class_ref, "isRSV3", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRSV3);
			}
		}

		static Delegate cb_getOpcode;
#pragma warning disable 0169
		static Delegate GetGetOpcodeHandler ()
		{
			if (cb_getOpcode == null)
				cb_getOpcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpcode);
			return cb_getOpcode;
		}

		static IntPtr n_GetOpcode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Opcode);
		}
#pragma warning restore 0169

		IntPtr id_getOpcode;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Opcode {
			get {
				if (id_getOpcode == IntPtr.Zero)
					id_getOpcode = JNIEnv.GetMethodID (class_ref, "getOpcode", "()Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;");
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpcode), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPayloadData;
#pragma warning disable 0169
		static Delegate GetGetPayloadDataHandler ()
		{
			if (cb_getPayloadData == null)
				cb_getPayloadData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadData);
			return cb_getPayloadData;
		}

		static IntPtr n_GetPayloadData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PayloadData);
		}
#pragma warning restore 0169

		IntPtr id_getPayloadData;
		public unsafe global::Java.Nio.ByteBuffer PayloadData {
			get {
				if (id_getPayloadData == IntPtr.Zero)
					id_getPayloadData = JNIEnv.GetMethodID (class_ref, "getPayloadData", "()Ljava/nio/ByteBuffer;");
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayloadData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTransfereMasked;
#pragma warning disable 0169
		static Delegate GetGetTransfereMaskedHandler ()
		{
			if (cb_getTransfereMasked == null)
				cb_getTransfereMasked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTransfereMasked);
			return cb_getTransfereMasked;
		}

		static bool n_GetTransfereMasked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransfereMasked;
		}
#pragma warning restore 0169

		IntPtr id_getTransfereMasked;
		public unsafe bool TransfereMasked {
			get {
				if (id_getTransfereMasked == IntPtr.Zero)
					id_getTransfereMasked = JNIEnv.GetMethodID (class_ref, "getTransfereMasked", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getTransfereMasked);
			}
		}

		static Delegate cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetAppend_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_Append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Append (p0);
		}
#pragma warning restore 0169

		IntPtr id_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void Append (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0)
		{
			if (id_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "append", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

	}

}
