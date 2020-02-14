using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Protocols {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/class[@name='Protocol']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/protocols/Protocol", DoNotGenerateAcw=true)]
	public partial class Protocol : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/protocols/Protocol", typeof (Protocol));
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

		protected Protocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/class[@name='Protocol']/constructor[@name='Protocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Protocol (string providedProtocol)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_providedProtocol = JNIEnv.NewString (providedProtocol);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_providedProtocol);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_providedProtocol);
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.Protocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.Protocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProvidedProtocol);
		}
#pragma warning restore 0169

		public virtual unsafe string ProvidedProtocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/class[@name='Protocol']/method[@name='getProvidedProtocol' and count(parameter)=0]"
			[Register ("getProvidedProtocol", "()Ljava/lang/String;", "GetGetProvidedProtocolHandler")]
			get {
				const string __id = "getProvidedProtocol.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static bool n_AcceptProvidedProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputProtocolHeader)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.Protocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.Protocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string inputProtocolHeader = JNIEnv.GetString (native_inputProtocolHeader, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcceptProvidedProtocol (inputProtocolHeader);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/class[@name='Protocol']/method[@name='acceptProvidedProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acceptProvidedProtocol", "(Ljava/lang/String;)Z", "GetAcceptProvidedProtocol_Ljava_lang_String_Handler")]
		public virtual unsafe bool AcceptProvidedProtocol (string inputProtocolHeader)
		{
			const string __id = "acceptProvidedProtocol.(Ljava/lang/String;)Z";
			IntPtr native_inputProtocolHeader = JNIEnv.NewString (inputProtocolHeader);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputProtocolHeader);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputProtocolHeader);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.Protocol __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.Protocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.protocols']/class[@name='Protocol']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/protocols/IProtocol;", "GetCopyInstanceHandler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol CopyInstance ()
		{
			const string __id = "copyInstance.()Lcom/clevertap/android/sdk/java_websocket/protocols/IProtocol;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
