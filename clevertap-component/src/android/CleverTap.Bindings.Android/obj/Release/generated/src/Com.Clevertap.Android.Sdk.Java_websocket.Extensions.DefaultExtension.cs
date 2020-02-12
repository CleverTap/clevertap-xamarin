using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/extensions/DefaultExtension", DoNotGenerateAcw=true)]
	public partial class DefaultExtension : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/extensions/DefaultExtension", typeof (DefaultExtension));
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

		protected DefaultExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/constructor[@name='DefaultExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultExtension ()
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProvidedExtensionAsClient);
		}
#pragma warning restore 0169

		public virtual unsafe string ProvidedExtensionAsClient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='getProvidedExtensionAsClient' and count(parameter)=0]"
			[Register ("getProvidedExtensionAsClient", "()Ljava/lang/String;", "GetGetProvidedExtensionAsClientHandler")]
			get {
				const string __id = "getProvidedExtensionAsClient.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProvidedExtensionAsServer);
		}
#pragma warning restore 0169

		public virtual unsafe string ProvidedExtensionAsServer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='getProvidedExtensionAsServer' and count(parameter)=0]"
			[Register ("getProvidedExtensionAsServer", "()Ljava/lang/String;", "GetGetProvidedExtensionAsServerHandler")]
			get {
				const string __id = "getProvidedExtensionAsServer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static bool n_AcceptProvidedExtensionAsClient_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputExtension)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string inputExtension = JNIEnv.GetString (native_inputExtension, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptProvidedExtensionAsClient (inputExtension);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='acceptProvidedExtensionAsClient' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptProvidedExtensionAsClient", "(Ljava/lang/String;)Z", "GetAcceptProvidedExtensionAsClient_Ljava_lang_String_Handler")]
		public virtual unsafe bool AcceptProvidedExtensionAsClient (string inputExtension)
		{
			const string __id = "acceptProvidedExtensionAsClient.(Ljava/lang/String;)Z";
			IntPtr native_inputExtension = JNIEnv.NewString (inputExtension);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputExtension);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputExtension);
			}
		}

		static Delegate cb_acceptProvidedExtensionAsServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcceptProvidedExtensionAsServer_Ljava_lang_String_Handler ()
		{
			if (cb_acceptProvidedExtensionAsServer_Ljava_lang_String_ == null)
				cb_acceptProvidedExtensionAsServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcceptProvidedExtensionAsServer_Ljava_lang_String_);
			return cb_acceptProvidedExtensionAsServer_Ljava_lang_String_;
		}

		static bool n_AcceptProvidedExtensionAsServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputExtension)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string inputExtension = JNIEnv.GetString (native_inputExtension, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptProvidedExtensionAsServer (inputExtension);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='acceptProvidedExtensionAsServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptProvidedExtensionAsServer", "(Ljava/lang/String;)Z", "GetAcceptProvidedExtensionAsServer_Ljava_lang_String_Handler")]
		public virtual unsafe bool AcceptProvidedExtensionAsServer (string inputExtension)
		{
			const string __id = "acceptProvidedExtensionAsServer.(Ljava/lang/String;)Z";
			IntPtr native_inputExtension = JNIEnv.NewString (inputExtension);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputExtension);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputExtension);
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;", "GetCopyInstanceHandler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension CopyInstance ()
		{
			const string __id = "copyInstance.()Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetDecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_decodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_DecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFrame)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata inputFrame = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_inputFrame, JniHandleOwnership.DoNotTransfer);
			__this.DecodeFrame (inputFrame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='decodeFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("decodeFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetDecodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void DecodeFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata inputFrame)
		{
			const string __id = "decodeFrame.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputFrame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputFrame).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetEncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_encodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_EncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFrame)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata inputFrame = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_inputFrame, JniHandleOwnership.DoNotTransfer);
			__this.EncodeFrame (inputFrame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='encodeFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("encodeFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetEncodeFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void EncodeFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata inputFrame)
		{
			const string __id = "encodeFrame.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputFrame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputFrame).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetIsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_IsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_isFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_IsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputFrame)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata inputFrame = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_inputFrame, JniHandleOwnership.DoNotTransfer);
			__this.IsFrameValid (inputFrame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='isFrameValid' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("isFrameValid", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetIsFrameValid_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void IsFrameValid (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata inputFrame)
		{
			const string __id = "isFrameValid.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputFrame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputFrame).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='DefaultExtension']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
