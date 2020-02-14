using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Drafts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/drafts/Draft_6455", DoNotGenerateAcw=true)]
	public partial class Draft_6455 : global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/drafts/Draft_6455", typeof (Draft_6455));
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

		protected Draft_6455 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/constructor[@name='Draft_6455' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Draft_6455 ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/constructor[@name='Draft_6455' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.extensions.IExtension']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;)V", "")]
		public unsafe Draft_6455 (global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension inputExtension)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inputExtension == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inputExtension).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/constructor[@name='Draft_6455' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.extensions.IExtension&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe Draft_6455 (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> inputExtensions)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_inputExtensions = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension>.ToLocalJniHandle (inputExtensions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputExtensions);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputExtensions);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/constructor[@name='Draft_6455' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.extensions.IExtension&gt;'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;I)V", "")]
		public unsafe Draft_6455 (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> inputExtensions, int inputMaxFrameSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_inputExtensions = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension>.ToLocalJniHandle (inputExtensions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputExtensions);
				__args [1] = new JniArgumentValue (inputMaxFrameSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputExtensions);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/constructor[@name='Draft_6455' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.extensions.IExtension&gt;'] and parameter[2][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.protocols.IProtocol&gt;']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe Draft_6455 (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> inputExtensions, global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> inputProtocols)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_inputExtensions = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension>.ToLocalJniHandle (inputExtensions);
			IntPtr native_inputProtocols = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol>.ToLocalJniHandle (inputProtocols);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_inputExtensions);
				__args [1] = new JniArgumentValue (native_inputProtocols);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputExtensions);
				JNIEnv.DeleteLocalRef (native_inputProtocols);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/constructor[@name='Draft_6455' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.extensions.IExtension&gt;'] and parameter[2][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.protocols.IProtocol&gt;'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;I)V", "")]
		public unsafe Draft_6455 (global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> inputExtensions, global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> inputProtocols, int inputMaxFrameSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_inputExtensions = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension>.ToLocalJniHandle (inputExtensions);
			IntPtr native_inputProtocols = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol>.ToLocalJniHandle (inputProtocols);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_inputExtensions);
				__args [1] = new JniArgumentValue (native_inputProtocols);
				__args [2] = new JniArgumentValue (inputMaxFrameSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputExtensions);
				JNIEnv.DeleteLocalRef (native_inputProtocols);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloseHandshakeType);
		}
#pragma warning restore 0169

		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType CloseHandshakeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='getCloseHandshakeType' and count(parameter)=0]"
			[Register ("getCloseHandshakeType", "()Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;", "GetGetCloseHandshakeTypeHandler")]
			get {
				const string __id = "getCloseHandshakeType.()Lcom/clevertap/android/sdk/java_websocket/enums/CloseHandshakeType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.CloseHandshakeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtension;
#pragma warning disable 0169
		static Delegate GetGetExtensionHandler ()
		{
			if (cb_getExtension == null)
				cb_getExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtension);
			return cb_getExtension;
		}

		static IntPtr n_GetExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extension);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension Extension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='getExtension' and count(parameter)=0]"
			[Register ("getExtension", "()Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;", "GetGetExtensionHandler")]
			get {
				const string __id = "getExtension.()Lcom/clevertap/android/sdk/java_websocket/extensions/IExtension;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKnownExtensions;
#pragma warning disable 0169
		static Delegate GetGetKnownExtensionsHandler ()
		{
			if (cb_getKnownExtensions == null)
				cb_getKnownExtensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKnownExtensions);
			return cb_getKnownExtensions;
		}

		static IntPtr n_GetKnownExtensions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension>.ToLocalJniHandle (__this.KnownExtensions);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension> KnownExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='getKnownExtensions' and count(parameter)=0]"
			[Register ("getKnownExtensions", "()Ljava/util/List;", "GetGetKnownExtensionsHandler")]
			get {
				const string __id = "getKnownExtensions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.IExtension>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKnownProtocols;
#pragma warning disable 0169
		static Delegate GetGetKnownProtocolsHandler ()
		{
			if (cb_getKnownProtocols == null)
				cb_getKnownProtocols = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKnownProtocols);
			return cb_getKnownProtocols;
		}

		static IntPtr n_GetKnownProtocols (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol>.ToLocalJniHandle (__this.KnownProtocols);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> KnownProtocols {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='getKnownProtocols' and count(parameter)=0]"
			[Register ("getKnownProtocols", "()Ljava/util/List;", "GetGetKnownProtocolsHandler")]
			get {
				const string __id = "getKnownProtocols.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxFrameSize;
#pragma warning disable 0169
		static Delegate GetGetMaxFrameSizeHandler ()
		{
			if (cb_getMaxFrameSize == null)
				cb_getMaxFrameSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxFrameSize);
			return cb_getMaxFrameSize;
		}

		static int n_GetMaxFrameSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxFrameSize;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxFrameSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='getMaxFrameSize' and count(parameter)=0]"
			[Register ("getMaxFrameSize", "()I", "GetGetMaxFrameSizeHandler")]
			get {
				const string __id = "getMaxFrameSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProtocol;
#pragma warning disable 0169
		static Delegate GetGetProtocolHandler ()
		{
			if (cb_getProtocol == null)
				cb_getProtocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProtocol);
			return cb_getProtocol;
		}

		static IntPtr n_GetProtocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Protocol);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol Protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='getProtocol' and count(parameter)=0]"
			[Register ("getProtocol", "()Lcom/clevertap/android/sdk/java_websocket/protocols/IProtocol;", "GetGetProtocolHandler")]
			get {
				const string __id = "getProtocol.()Lcom/clevertap/android/sdk/java_websocket/protocols/IProtocol;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Protocols.IProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_AcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_response)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake response = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (native_response, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcceptHandshakeAsClient (request, response));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='acceptHandshakeAsClient' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("acceptHandshakeAsClient", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "GetAcceptHandshakeAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState AcceptHandshakeAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake response)
		{
			const string __id = "acceptHandshakeAsClient.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
#pragma warning disable 0169
		static Delegate GetAcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler ()
		{
			if (cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ == null)
				cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_);
			return cb_acceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_;
		}

		static IntPtr n_AcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AcceptHandshakeAsServer (handshakedata));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='acceptHandshakeAsServer' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake']]"
		[Register ("acceptHandshakeAsServer", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;", "GetAcceptHandshakeAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState AcceptHandshakeAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake handshakedata)
		{
			const string __id = "acceptHandshakeAsServer.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/enums/HandshakeState;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.HandshakeState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='copyInstance' and count(parameter)=0]"
		[Register ("copyInstance", "()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;", "GetCopyInstanceHandler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft CopyInstance ()
		{
			const string __id = "copyInstance.()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetCreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_createBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static IntPtr n_CreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_framedata)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata framedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_framedata, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBinaryFrame (framedata));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='createBinaryFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("createBinaryFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)Ljava/nio/ByteBuffer;", "GetCreateBinaryFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public override unsafe global::Java.Nio.ByteBuffer CreateBinaryFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata framedata)
		{
			const string __id = "createBinaryFrame.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((framedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framedata).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createFrames_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetCreateFrames_Ljava_lang_String_ZHandler ()
		{
			if (cb_createFrames_Ljava_lang_String_Z == null)
				cb_createFrames_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_CreateFrames_Ljava_lang_String_Z);
			return cb_createFrames_Ljava_lang_String_Z;
		}

		static IntPtr n_CreateFrames_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_text, bool mask)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.CreateFrames (text, mask));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='createFrames' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("createFrames", "(Ljava/lang/String;Z)Ljava/util/List;", "GetCreateFrames_Ljava_lang_String_ZHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> CreateFrames (string text, bool mask)
		{
			const string __id = "createFrames.(Ljava/lang/String;Z)Ljava/util/List;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (mask);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_createFrames_Ljava_nio_ByteBuffer_Z;
#pragma warning disable 0169
		static Delegate GetCreateFrames_Ljava_nio_ByteBuffer_ZHandler ()
		{
			if (cb_createFrames_Ljava_nio_ByteBuffer_Z == null)
				cb_createFrames_Ljava_nio_ByteBuffer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_CreateFrames_Ljava_nio_ByteBuffer_Z);
			return cb_createFrames_Ljava_nio_ByteBuffer_Z;
		}

		static IntPtr n_CreateFrames_Ljava_nio_ByteBuffer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_binary, bool mask)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer binary = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_binary, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.CreateFrames (binary, mask));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='createFrames' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='boolean']]"
		[Register ("createFrames", "(Ljava/nio/ByteBuffer;Z)Ljava/util/List;", "GetCreateFrames_Ljava_nio_ByteBuffer_ZHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> CreateFrames (global::Java.Nio.ByteBuffer binary, bool mask)
		{
			const string __id = "createFrames.(Ljava/nio/ByteBuffer;Z)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((binary == null) ? IntPtr.Zero : ((global::Java.Lang.Object) binary).Handle);
				__args [1] = new JniArgumentValue (mask);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_PostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder request = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder> (native_request, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostProcessHandshakeRequestAsClient (request));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='postProcessHandshakeRequestAsClient' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshakeBuilder']]"
		[Register ("postProcessHandshakeRequestAsClient", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;", "GetPostProcessHandshakeRequestAsClient_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder PostProcessHandshakeRequestAsClient (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder request)
		{
			const string __id = "postProcessHandshakeRequestAsClient.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_;
#pragma warning disable 0169
		static Delegate GetPostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_Handler ()
		{
			if (cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_ == null)
				cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_);
			return cb_postProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_;
		}

		static IntPtr n_PostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request, IntPtr native_response)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake> (native_request, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder response = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder> (native_response, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PostProcessHandshakeResponseAsServer (request, response));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='postProcessHandshakeResponseAsServer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshakeBuilder']]"
		[Register ("postProcessHandshakeResponseAsServer", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;", "GetPostProcessHandshakeResponseAsServer_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshakeBuilder_Handler")]
		public override unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder PostProcessHandshakeResponseAsServer (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshake request, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshakeBuilder response)
		{
			const string __id = "postProcessHandshakeResponseAsServer.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;)Lcom/clevertap/android/sdk/java_websocket/handshake/HandshakeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_processFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_ProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webSocketImpl, IntPtr native_frame)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl webSocketImpl = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (native_webSocketImpl, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata frame = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_frame, JniHandleOwnership.DoNotTransfer);
			__this.ProcessFrame (webSocketImpl, frame);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='processFrame' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketImpl'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("processFrame", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetProcessFrame_Lcom_clevertap_android_sdk_java_websocket_WebSocketImpl_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public override unsafe void ProcessFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl webSocketImpl, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata frame)
		{
			const string __id = "processFrame.(Lcom/clevertap/android/sdk/java_websocket/WebSocketImpl;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((webSocketImpl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webSocketImpl).Handle);
				__args [1] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public override unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		static IntPtr n_TranslateFrame_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft_6455> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (__this.TranslateFrame (buffer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.drafts']/class[@name='Draft_6455']/method[@name='translateFrame' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("translateFrame", "(Ljava/nio/ByteBuffer;)Ljava/util/List;", "GetTranslateFrame_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> TranslateFrame (global::Java.Nio.ByteBuffer buffer)
		{
			const string __id = "translateFrame.(Ljava/nio/ByteBuffer;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
