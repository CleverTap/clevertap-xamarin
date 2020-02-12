using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Protocols {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/interface[@name='IProtocol']"
	[Register ("com/clevertap/android/sdk/java_websocket/protocols/IProtocol", "", "Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocolInvoker")]
	public partial interface IProtocol : IJavaObject, IJavaPeerable {

		string ProvidedProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/interface[@name='IProtocol']/method[@name='getProvidedProtocol' and count(parameter)=0]"
			[Register ("getProvidedProtocol", "()Ljava/lang/String;", "GetGetProvidedProtocolHandler:Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocolInvoker, CleverTap.Bindings.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/interface[@name='IProtocol']/method[@name='acceptProvidedProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptProvidedProtocol", "(Ljava/lang/String;)Z", "GetAcceptProvidedProtocol_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocolInvoker, CleverTap.Bindings.Android")]
		bool AcceptProvidedProtocol (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/interface[@name='IProtocol']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/protocols/IProtocol;", "GetCopyInstanceHandler:Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocolInvoker, CleverTap.Bindings.Android")]
		global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol CopyInstance ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/interface[@name='IProtocol']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler:Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocolInvoker, CleverTap.Bindings.Android")]
		string ToString ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/protocols/IProtocol", DoNotGenerateAcw=true)]
	internal partial class IProtocolInvoker : global::Java.Lang.Object, IProtocol {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/protocols/IProtocol", typeof (IProtocolInvoker));

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

		public static IProtocol GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProtocol> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.protocols.IProtocol"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProtocolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getProvidedProtocol;
#pragma warning disable 0169
		static Delegate GetGetProvidedProtocolHandler ()
		{
			if (cb_getProvidedProtocol == null)
				cb_getProvidedProtocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProvidedProtocol);
			return cb_getProvidedProtocol;
		}

		static IntPtr n_GetProvidedProtocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProvidedProtocol);
		}
#pragma warning restore 0169

		IntPtr id_getProvidedProtocol;
		public unsafe string ProvidedProtocol {
			get {
				if (id_getProvidedProtocol == IntPtr.Zero)
					id_getProvidedProtocol = JNIEnv.GetMethodID (class_ref, "getProvidedProtocol", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProvidedProtocol), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_acceptProvidedProtocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcceptProvidedProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_acceptProvidedProtocol_Ljava_lang_String_ == null)
				cb_acceptProvidedProtocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcceptProvidedProtocol_Ljava_lang_String_);
			return cb_acceptProvidedProtocol_Ljava_lang_String_;
		}

		static bool n_AcceptProvidedProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptProvidedProtocol (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_acceptProvidedProtocol_Ljava_lang_String_;
		public unsafe bool AcceptProvidedProtocol (string p0)
		{
			if (id_acceptProvidedProtocol_Ljava_lang_String_ == IntPtr.Zero)
				id_acceptProvidedProtocol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acceptProvidedProtocol", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_acceptProvidedProtocol_Ljava_lang_String_, __args);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyInstance ());
		}
#pragma warning restore 0169

		IntPtr id_copyInstance;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol CopyInstance ()
		{
			if (id_copyInstance == IntPtr.Zero)
				id_copyInstance = JNIEnv.GetMethodID (class_ref, "copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/protocols/IProtocol;");
			return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copyInstance), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
