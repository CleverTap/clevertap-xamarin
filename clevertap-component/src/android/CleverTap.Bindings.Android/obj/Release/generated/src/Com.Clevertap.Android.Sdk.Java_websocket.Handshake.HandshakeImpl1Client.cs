using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Handshake {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Client']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/handshake/HandshakeImpl1Client", DoNotGenerateAcw=true)]
	public partial class HandshakeImpl1Client : global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakedataImpl1, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/handshake/HandshakeImpl1Client", typeof (HandshakeImpl1Client));
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

		protected HandshakeImpl1Client (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Client']/constructor[@name='HandshakeImpl1Client' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HandshakeImpl1Client ()
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

		static Delegate cb_getResourceDescriptor;
#pragma warning disable 0169
		static Delegate GetGetResourceDescriptorHandler ()
		{
			if (cb_getResourceDescriptor == null)
				cb_getResourceDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceDescriptor);
			return cb_getResourceDescriptor;
		}

		static IntPtr n_GetResourceDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Client __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Client> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetResourceDescriptor ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Client']/method[@name='getResourceDescriptor' and count(parameter)=0]"
		[Register ("getResourceDescriptor", "()Ljava/lang/String;", "GetGetResourceDescriptorHandler")]
		public virtual unsafe string GetResourceDescriptor ()
		{
			const string __id = "getResourceDescriptor.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setResourceDescriptor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResourceDescriptor_Ljava_lang_String_Handler ()
		{
			if (cb_setResourceDescriptor_Ljava_lang_String_ == null)
				cb_setResourceDescriptor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceDescriptor_Ljava_lang_String_);
			return cb_setResourceDescriptor_Ljava_lang_String_;
		}

		static void n_SetResourceDescriptor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resourceDescriptor)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Client __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.HandshakeImpl1Client> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string resourceDescriptor = JNIEnv.GetString (native_resourceDescriptor, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceDescriptor (resourceDescriptor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.handshake']/class[@name='HandshakeImpl1Client']/method[@name='setResourceDescriptor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResourceDescriptor", "(Ljava/lang/String;)V", "GetSetResourceDescriptor_Ljava_lang_String_Handler")]
		public virtual unsafe void SetResourceDescriptor (string resourceDescriptor)
		{
			const string __id = "setResourceDescriptor.(Ljava/lang/String;)V";
			IntPtr native_resourceDescriptor = JNIEnv.NewString (resourceDescriptor);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_resourceDescriptor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_resourceDescriptor);
			}
		}

	}
}
