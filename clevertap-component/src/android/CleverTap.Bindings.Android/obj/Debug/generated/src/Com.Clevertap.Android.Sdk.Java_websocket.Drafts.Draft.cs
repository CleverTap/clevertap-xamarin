using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Drafts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/drafts/Draft", DoNotGenerateAcw=true)]
	public abstract partial class Draft : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/field[@name='continuousFrameType']"
		[Register ("continuousFrameType")]
		protected global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode ContinuousFrameType {
			get {
				const string __id = "continuousFrameType.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "continuousFrameType.Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/drafts/Draft", typeof (Draft));
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

		protected Draft (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/constructor[@name='Draft' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Draft ()
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

		static Delegate cb_getCloseHandshakeType;
#pragma warning disable 0169
		static Delegate GetGetCloseHandshakeTypeHandler ()
		{
			if (cb_getCloseHandshakeType == null)
				cb_getCloseHandshakeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCloseHandshakeType);
			return cb_getCloseHandshakeType;
		}

		static IntPtr n_GetCloseHandshakeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloseHandshakeType);
		}
#pragma warning restore 0169

		public abstract global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType CloseHandshakeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='getCloseHandshakeType' and count(parameter)=0]"
			[Register ("getCloseHandshakeType", "()Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;", "GetGetCloseHandshakeTypeHandler")] get;
		}

		static Delegate cb_getRole;
#pragma warning disable 0169
		static Delegate GetGetRoleHandler ()
		{
			if (cb_getRole == null)
				cb_getRole = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRole);
			return cb_getRole;
		}

		static IntPtr n_GetRole (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Role);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role Role {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='getRole' and count(parameter)=0]"
			[Register ("getRole", "()Lcom/clevertap/android/sdk/java_websocket/enums/Role;", "GetGetRoleHandler")]
			get {
				const string __id = "getRole.()Lcom/clevertap/android/sdk/java_websocket/enums/Role;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
#pragma warning disable 0169
		static Delegate GetAcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler ()
		{
			if (cb_acceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ == null)
				cb_acceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_);
			return cb_acceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
		}

		static IntPtr n_AcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcceptHandshakeAsClient (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='acceptHandshakeAsClient' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("acceptHandshakeAsClient", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "GetAcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler")]
		public abstract global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState AcceptHandshakeAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p1);

		static Delegate cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
#pragma warning disable 0169
		static Delegate GetAcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler ()
		{
			if (cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == null)
				cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_);
			return cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		}

		static IntPtr n_AcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcceptHandshakeAsServer (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='acceptHandshakeAsServer' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("acceptHandshakeAsServer", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "GetAcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler")]
		public abstract global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState AcceptHandshakeAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0);

		static Delegate cb_basicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
#pragma warning disable 0169
		static Delegate GetBasicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler ()
		{
			if (cb_basicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ == null)
				cb_basicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_BasicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_);
			return cb_basicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
		}

		static bool n_BasicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BasicAccept (handshakedata);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='basicAccept' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata']]"
		[Register ("basicAccept", "(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)Z", "GetBasicAccept_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler")]
		protected virtual unsafe bool BasicAccept (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata)
		{
			const string __id = "basicAccept.(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkAlloc_I;
#pragma warning disable 0169
		static Delegate GetCheckAlloc_IHandler ()
		{
			if (cb_checkAlloc_I == null)
				cb_checkAlloc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_CheckAlloc_I);
			return cb_checkAlloc_I;
		}

		static int n_CheckAlloc_I (IntPtr jnienv, IntPtr native__this, int bytecount)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckAlloc (bytecount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='checkAlloc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkAlloc", "(I)I", "GetCheckAlloc_IHandler")]
		public virtual unsafe int CheckAlloc (int bytecount)
		{
			const string __id = "checkAlloc.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bytecount);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_continuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
#pragma warning disable 0169
		static Delegate GetContinuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_ZHandler ()
		{
			if (cb_continuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z == null)
				cb_continuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_ContinuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z);
			return cb_continuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
		}

		static IntPtr n_ContinuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_op, IntPtr native_buffer, bool fin)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode op = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (native_op, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.ContinuousFrame (op, buffer, fin));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='continuousFrame' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='boolean']]"
		[Register ("continuousFrame", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;Ljava/nio/ByteBuffer;Z)Ljava/util/List;", "GetContinuousFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> ContinuousFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode op, global::Java.Nio.ByteBuffer buffer, bool fin)
		{
			const string __id = "continuousFrame.(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;Ljava/nio/ByteBuffer;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [2] = new JniArgumentValue (fin);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;", "GetCopyInstanceHandler")]
		public abstract global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft CopyInstance ();

		static Delegate cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetCreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static IntPtr n_CreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBinaryFrame (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createBinaryFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("createBinaryFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)Ljava/nio/ByteBuffer;", "GetCreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public abstract global::Java.Nio.ByteBuffer CreateBinaryFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0);

		static Delegate cb_createFrames_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetCreateFrames_Ljava_lang_String_ZHandler ()
		{
			if (cb_createFrames_Ljava_lang_String_Z == null)
				cb_createFrames_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_CreateFrames_Ljava_lang_String_Z);
			return cb_createFrames_Ljava_lang_String_Z;
		}

		static IntPtr n_CreateFrames_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.CreateFrames (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createFrames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("createFrames", "(Ljava/lang/String;Z)Ljava/util/List;", "GetCreateFrames_Ljava_lang_String_ZHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> CreateFrames (string p0, bool p1);

		static Delegate cb_createFrames_Ljava_nio_ByteBuffer_Z;
#pragma warning disable 0169
		static Delegate GetCreateFrames_Ljava_nio_ByteBuffer_ZHandler ()
		{
			if (cb_createFrames_Ljava_nio_ByteBuffer_Z == null)
				cb_createFrames_Ljava_nio_ByteBuffer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_CreateFrames_Ljava_nio_ByteBuffer_Z);
			return cb_createFrames_Ljava_nio_ByteBuffer_Z;
		}

		static IntPtr n_CreateFrames_Ljava_nio_ByteBuffer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.CreateFrames (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createFrames' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='boolean']]"
		[Register ("createFrames", "(Ljava/nio/ByteBuffer;Z)Ljava/util/List;", "GetCreateFrames_Ljava_nio_ByteBuffer_ZHandler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> CreateFrames (global::Java.Nio.ByteBuffer p0, bool p1);

		static Delegate cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
#pragma warning disable 0169
		static Delegate GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler ()
		{
			if (cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ == null)
				cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_);
			return cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_;
		}

		static IntPtr n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (__this.CreateHandshake (handshakedata));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createHandshake' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata']]"
		[Register ("createHandshake", "(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)Ljava/util/List;", "GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> CreateHandshake (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata)
		{
			const string __id = "createHandshake.(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Z;
#pragma warning disable 0169
		static Delegate GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ZHandler ()
		{
			if (cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Z == null)
				cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Z);
			return cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Z;
		}

		static IntPtr n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata, bool withcontent)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (__this.CreateHandshake (handshakedata, withcontent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createHandshake' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata'] and parameter[2][@type='boolean']]"
		[Register ("createHandshake", "(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;Z)Ljava/util/List;", "GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> CreateHandshake (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata, bool withcontent)
		{
			const string __id = "createHandshake.(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				__args [1] = new JniArgumentValue (withcontent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Handler ()
		{
			if (cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ == null)
				cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_);
			return cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_;
		}

		[Obsolete]
		static IntPtr n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata, IntPtr native_ownrole)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role ownrole = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (native_ownrole, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (__this.CreateHandshake (handshakedata, ownrole));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createHandshake' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.enums.Role']]"
		[Obsolete (@"deprecated")]
		[Register ("createHandshake", "(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;Lcom/clevertap/android/sdk/java_websocket/enums/Role;)Ljava/util/List;", "GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> CreateHandshake (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata, global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role ownrole)
		{
			const string __id = "createHandshake.(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;Lcom/clevertap/android/sdk/java_websocket/enums/Role;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				__args [1] = new JniArgumentValue ((ownrole == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ownrole).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ZHandler ()
		{
			if (cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Z == null)
				cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Z);
			return cb_createHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Z;
		}

		[Obsolete]
		static IntPtr n_CreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata, IntPtr native_ownrole, bool withcontent)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role ownrole = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (native_ownrole, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (__this.CreateHandshake (handshakedata, ownrole, withcontent));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createHandshake' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.enums.Role'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("createHandshake", "(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;Lcom/clevertap/android/sdk/java_websocket/enums/Role;Z)Ljava/util/List;", "GetCreateHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> CreateHandshake (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshakedata, global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role ownrole, bool withcontent)
		{
			const string __id = "createHandshake.(Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;Lcom/clevertap/android/sdk/java_websocket/enums/Role;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				__args [1] = new JniArgumentValue ((ownrole == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ownrole).Handle);
				__args [2] = new JniArgumentValue (withcontent);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_postProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_;
#pragma warning disable 0169
		static Delegate GetPostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_Handler ()
		{
			if (cb_postProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ == null)
				cb_postProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_);
			return cb_postProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_;
		}

		static IntPtr n_PostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostProcessHandshakeRequestAsClient (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='postProcessHandshakeRequestAsClient' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshakeBuilder']]"
		[Register ("postProcessHandshakeRequestAsClient", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;", "GetPostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_Handler")]
		public abstract global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder PostProcessHandshakeRequestAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder p0);

		static Delegate cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_;
#pragma warning disable 0169
		static Delegate GetPostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_Handler ()
		{
			if (cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_ == null)
				cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_);
			return cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_;
		}

		static IntPtr n_PostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostProcessHandshakeResponseAsServer (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='postProcessHandshakeResponseAsServer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshakeBuilder']]"
		[Register ("postProcessHandshakeResponseAsServer", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;", "GetPostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_Handler")]
		public abstract global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder PostProcessHandshakeResponseAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder p1);

		static Delegate cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_ProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessFrame (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='processFrame' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketImpl'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("processFrame", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public abstract void ProcessFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='readLine' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readLine", "(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer ReadLine (global::Java.Nio.ByteBuffer buf)
		{
			const string __id = "readLine.(Ljava/nio/ByteBuffer;)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='readStringLine' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readStringLine", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "")]
		public static unsafe string ReadStringLine (global::Java.Nio.ByteBuffer buf)
		{
			const string __id = "readStringLine.(Ljava/nio/ByteBuffer;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public abstract void Reset ();

		static Delegate cb_setParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_;
#pragma warning disable 0169
		static Delegate GetSetParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Handler ()
		{
			if (cb_setParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ == null)
				cb_setParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_);
			return cb_setParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_;
		}

		static void n_SetParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_ (IntPtr jnienv, IntPtr native__this, IntPtr native_role)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role role = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role> (native_role, JniHandleOwnership.DoNotTransfer);
			__this.SetParseMode (role);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='setParseMode' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Role']]"
		[Register ("setParseMode", "(Lcom/clevertap/android/sdk/java_websocket/enums/Role;)V", "GetSetParseMode_Lcom_clevertap_android_sdk_java_websocket_enums_Role_Handler")]
		public virtual unsafe void SetParseMode (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role role)
		{
			const string __id = "setParseMode.(Lcom/clevertap/android/sdk/java_websocket/enums/Role;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((role == null) ? IntPtr.Zero : ((global::Java.Lang.Object) role).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_translateFrame_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetTranslateFrame_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_translateFrame_Ljava_nio_ByteBuffer_ == null)
				cb_translateFrame_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TranslateFrame_Ljava_nio_ByteBuffer_);
			return cb_translateFrame_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_TranslateFrame_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.TranslateFrame (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='translateFrame' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("translateFrame", "(Ljava/nio/ByteBuffer;)Ljava/util/List;", "GetTranslateFrame_Ljava_nio_ByteBuffer_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> TranslateFrame (global::Java.Nio.ByteBuffer p0);

		static Delegate cb_translateHandshake_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetTranslateHandshake_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_translateHandshake_Ljava_nio_ByteBuffer_ == null)
				cb_translateHandshake_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TranslateHandshake_Ljava_nio_ByteBuffer_);
			return cb_translateHandshake_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_TranslateHandshake_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TranslateHandshake (buf));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='translateHandshake' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("translateHandshake", "(Ljava/nio/ByteBuffer;)Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;", "GetTranslateHandshake_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata TranslateHandshake (global::Java.Nio.ByteBuffer buf)
		{
			const string __id = "translateHandshake.(Ljava/nio/ByteBuffer;)Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='translateHandshakeHttp' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.enums.Role']]"
		[Register ("translateHandshakeHttp", "(Ljava/nio/ByteBuffer;Lcom/clevertap/android/sdk/java_websocket/enums/Role;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder TranslateHandshakeHttp (global::Java.Nio.ByteBuffer buf, global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Role role)
		{
			const string __id = "translateHandshakeHttp.(Ljava/nio/ByteBuffer;Lcom/clevertap/android/sdk/java_websocket/enums/Role;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				__args [1] = new JniArgumentValue ((role == null) ? IntPtr.Zero : ((global::Java.Lang.Object) role).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/drafts/Draft", DoNotGenerateAcw=true)]
	internal partial class DraftInvoker : Draft {

		public DraftInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/drafts/Draft", typeof (DraftInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType CloseHandshakeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='getCloseHandshakeType' and count(parameter)=0]"
			[Register ("getCloseHandshakeType", "()Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;", "GetGetCloseHandshakeTypeHandler")]
			get {
				const string __id = "getCloseHandshakeType.()Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='acceptHandshakeAsClient' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("acceptHandshakeAsClient", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "GetAcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState AcceptHandshakeAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p1)
		{
			const string __id = "acceptHandshakeAsClient.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='acceptHandshakeAsServer' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("acceptHandshakeAsServer", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "GetAcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState AcceptHandshakeAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0)
		{
			const string __id = "acceptHandshakeAsServer.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;", "GetCopyInstanceHandler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft CopyInstance ()
		{
			const string __id = "copyInstance.()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createBinaryFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("createBinaryFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)Ljava/nio/ByteBuffer;", "GetCreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public override unsafe global::Java.Nio.ByteBuffer CreateBinaryFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0)
		{
			const string __id = "createBinaryFrame.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createFrames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("createFrames", "(Ljava/lang/String;Z)Ljava/util/List;", "GetCreateFrames_Ljava_lang_String_ZHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> CreateFrames (string p0, bool p1)
		{
			const string __id = "createFrames.(Ljava/lang/String;Z)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='createFrames' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='boolean']]"
		[Register ("createFrames", "(Ljava/nio/ByteBuffer;Z)Ljava/util/List;", "GetCreateFrames_Ljava_nio_ByteBuffer_ZHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> CreateFrames (global::Java.Nio.ByteBuffer p0, bool p1)
		{
			const string __id = "createFrames.(Ljava/nio/ByteBuffer;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='postProcessHandshakeRequestAsClient' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshakeBuilder']]"
		[Register ("postProcessHandshakeRequestAsClient", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;", "GetPostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder PostProcessHandshakeRequestAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder p0)
		{
			const string __id = "postProcessHandshakeRequestAsClient.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='postProcessHandshakeResponseAsServer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshakeBuilder']]"
		[Register ("postProcessHandshakeResponseAsServer", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;", "GetPostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder PostProcessHandshakeResponseAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder p1)
		{
			const string __id = "postProcessHandshakeResponseAsServer.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='processFrame' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketImpl'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("processFrame", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public override unsafe void ProcessFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p1)
		{
			const string __id = "processFrame.(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public override unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft']/method[@name='translateFrame' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("translateFrame", "(Ljava/nio/ByteBuffer;)Ljava/util/List;", "GetTranslateFrame_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> TranslateFrame (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "translateFrame.(Ljava/nio/ByteBuffer;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
