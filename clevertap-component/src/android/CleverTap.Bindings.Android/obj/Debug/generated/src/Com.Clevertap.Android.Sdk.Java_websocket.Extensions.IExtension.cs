using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Extensions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']"
	[Register ("com/clevertap/android/sdk/java_websocket/extensions/IExtension", "", "Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker")]
	public partial interface IExtension : IJavaObject, IJavaPeerable {

		string ProvidedExtensionAsClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='getProvidedExtensionAsClient' and count(parameter)=0]"
			[Register ("getProvidedExtensionAsClient", "()Ljava/lang/String;", "GetGetProvidedExtensionAsClientHandler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")] get;
		}

		string ProvidedExtensionAsServer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='getProvidedExtensionAsServer' and count(parameter)=0]"
			[Register ("getProvidedExtensionAsServer", "()Ljava/lang/String;", "GetGetProvidedExtensionAsServerHandler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='acceptProvidedExtensionAsClient' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptProvidedExtensionAsClient", "(Ljava/lang/String;)Z", "GetAcceptProvidedExtensionAsClient_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		bool AcceptProvidedExtensionAsClient (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='acceptProvidedExtensionAsServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptProvidedExtensionAsServer", "(Ljava/lang/String;)Z", "GetAcceptProvidedExtensionAsServer_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		bool AcceptProvidedExtensionAsServer (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;", "GetCopyInstanceHandler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension CopyInstance ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='decodeFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("decodeFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetDecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		void DecodeFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='encodeFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("encodeFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetEncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		void EncodeFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='isFrameValid' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("isFrameValid", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetIsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		void IsFrameValid (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		void Reset ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/interface[@name='IExtension']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtensionInvoker, CleverTap.Bindings.Android")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/extensions/IExtension", DoNotGenerateAcw=true)]
	internal partial class IExtensionInvoker : global::Java.Lang.Object, IExtension {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/extensions/IExtension", typeof (IExtensionInvoker));

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

		public static IExtension GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExtension> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.extensions.IExtension"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExtensionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getProvidedExtensionAsClient;
#pragma warning disable 0169
		static Delegate GetGetProvidedExtensionAsClientHandler ()
		{
			if (cb_getProvidedExtensionAsClient == null)
				cb_getProvidedExtensionAsClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvidedExtensionAsClient);
			return cb_getProvidedExtensionAsClient;
		}

		static IntPtr n_GetProvidedExtensionAsClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProvidedExtensionAsClient);
		}
#pragma warning restore 0169

		IntPtr id_getProvidedExtensionAsClient;
		public unsafe string ProvidedExtensionAsClient {
			get {
				if (id_getProvidedExtensionAsClient == IntPtr.Zero)
					id_getProvidedExtensionAsClient = JNIEnv.GetMethodID (class_ref, "getProvidedExtensionAsClient", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvidedExtensionAsClient), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProvidedExtensionAsServer;
#pragma warning disable 0169
		static Delegate GetGetProvidedExtensionAsServerHandler ()
		{
			if (cb_getProvidedExtensionAsServer == null)
				cb_getProvidedExtensionAsServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvidedExtensionAsServer);
			return cb_getProvidedExtensionAsServer;
		}

		static IntPtr n_GetProvidedExtensionAsServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProvidedExtensionAsServer);
		}
#pragma warning restore 0169

		IntPtr id_getProvidedExtensionAsServer;
		public unsafe string ProvidedExtensionAsServer {
			get {
				if (id_getProvidedExtensionAsServer == IntPtr.Zero)
					id_getProvidedExtensionAsServer = JNIEnv.GetMethodID (class_ref, "getProvidedExtensionAsServer", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvidedExtensionAsServer), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_acceptProvidedExtensionAsClient_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcceptProvidedExtensionAsClient_Ljava_lang_String_Handler ()
		{
			if (cb_acceptProvidedExtensionAsClient_Ljava_lang_String_ == null)
				cb_acceptProvidedExtensionAsClient_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcceptProvidedExtensionAsClient_Ljava_lang_String_);
			return cb_acceptProvidedExtensionAsClient_Ljava_lang_String_;
		}

		static bool n_AcceptProvidedExtensionAsClient_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptProvidedExtensionAsClient (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acceptProvidedExtensionAsClient_Ljava_lang_String_;
		public unsafe bool AcceptProvidedExtensionAsClient (string p0)
		{
			if (id_acceptProvidedExtensionAsClient_Ljava_lang_String_ == IntPtr.Zero)
				id_acceptProvidedExtensionAsClient_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acceptProvidedExtensionAsClient", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_acceptProvidedExtensionAsClient_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_acceptProvidedExtensionAsServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcceptProvidedExtensionAsServer_Ljava_lang_String_Handler ()
		{
			if (cb_acceptProvidedExtensionAsServer_Ljava_lang_String_ == null)
				cb_acceptProvidedExtensionAsServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcceptProvidedExtensionAsServer_Ljava_lang_String_);
			return cb_acceptProvidedExtensionAsServer_Ljava_lang_String_;
		}

		static bool n_AcceptProvidedExtensionAsServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptProvidedExtensionAsServer (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acceptProvidedExtensionAsServer_Ljava_lang_String_;
		public unsafe bool AcceptProvidedExtensionAsServer (string p0)
		{
			if (id_acceptProvidedExtensionAsServer_Ljava_lang_String_ == IntPtr.Zero)
				id_acceptProvidedExtensionAsServer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acceptProvidedExtensionAsServer", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_acceptProvidedExtensionAsServer_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_copyInstance;
#pragma warning disable 0169
		static Delegate GetCopyInstanceHandler ()
		{
			if (cb_copyInstance == null)
				cb_copyInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CopyInstance);
			return cb_copyInstance;
		}

		static IntPtr n_CopyInstance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyInstance ());
		}
#pragma warning restore 0169

		IntPtr id_copyInstance;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension CopyInstance ()
		{
			if (id_copyInstance == IntPtr.Zero)
				id_copyInstance = JNIEnv.GetMethodID (class_ref, "copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;");
			return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copyInstance), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_DecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DecodeFrame (p0);
		}
#pragma warning restore 0169

		IntPtr id_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void DecodeFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0)
		{
			if (id_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "decodeFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

		static Delegate cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetEncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_EncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncodeFrame (p0);
		}
#pragma warning restore 0169

		IntPtr id_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void EncodeFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0)
		{
			if (id_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "encodeFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

		static Delegate cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetIsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_IsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_IsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IsFrameValid (p0);
		}
#pragma warning restore 0169

		IntPtr id_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void IsFrameValid (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0)
		{
			if (id_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "isFrameValid", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		IntPtr id_reset;
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
