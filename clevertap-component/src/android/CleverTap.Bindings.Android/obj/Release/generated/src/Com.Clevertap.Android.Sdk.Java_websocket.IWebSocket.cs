using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']"
	[Register ("com/clevertap/android/sdk/java_websocket/WebSocket", "", "Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker")]
	public partial interface IWebSocket : IJavaObject, IJavaPeerable {

		global::Java.Lang.Object Attachment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='getAttachment' and count(parameter)=0]"
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			[Register ("getAttachment", "()Ljava/lang/Object;", "GetGetAttachmentHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='setAttachment' and count(parameter)=1 and parameter[1][@type='T']]"
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			[Register ("setAttachment", "(Ljava/lang/Object;)V", "GetSetAttachment_Ljava_lang_Object_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] set;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft Draft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='getDraft' and count(parameter)=0]"
			[Register ("getDraft", "()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;", "GetGetDraftHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		bool HasBufferedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='hasBufferedData' and count(parameter)=0]"
			[Register ("hasBufferedData", "()Z", "GetHasBufferedDataHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsClosing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='isClosing' and count(parameter)=0]"
			[Register ("isClosing", "()Z", "GetIsClosingHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsFlushAndClose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='isFlushAndClose' and count(parameter)=0]"
			[Register ("isFlushAndClose", "()Z", "GetIsFlushAndCloseHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		global::Java.Net.InetSocketAddress LocalSocketAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='getLocalSocketAddress' and count(parameter)=0]"
			[Register ("getLocalSocketAddress", "()Ljava/net/InetSocketAddress;", "GetGetLocalSocketAddressHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState ReadyState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='getReadyState' and count(parameter)=0]"
			[Register ("getReadyState", "()Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;", "GetGetReadyStateHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		global::Java.Net.InetSocketAddress RemoteSocketAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='getRemoteSocketAddress' and count(parameter)=0]"
			[Register ("getRemoteSocketAddress", "()Ljava/net/InetSocketAddress;", "GetGetRemoteSocketAddressHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		string ResourceDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='getResourceDescriptor' and count(parameter)=0]"
			[Register ("getResourceDescriptor", "()Ljava/lang/String;", "GetGetResourceDescriptorHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='close' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("close", "(I)V", "GetClose_IHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void Close (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("close", "(ILjava/lang/String;)V", "GetClose_ILjava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void Close (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='closeConnection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("closeConnection", "(ILjava/lang/String;)V", "GetCloseConnection_ILjava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void CloseConnection (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("send", "([B)V", "GetSend_arrayBHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void Send (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void Send (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("send", "(Ljava/nio/ByteBuffer;)V", "GetSend_Ljava_nio_ByteBuffer_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void Send (global::Java.Nio.ByteBuffer p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='sendFragmentedFrame' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='boolean']]"
		[Register ("sendFragmentedFrame", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;Ljava/nio/ByteBuffer;Z)V", "GetSendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_ZHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void SendFragmentedFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode p0, global::Java.Nio.ByteBuffer p1, bool p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='sendFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("sendFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetSendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void SendFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='sendFrame' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.clevertap.android.sdk.java_websocket.framing.Framedata&gt;']]"
		[Register ("sendFrame", "(Ljava/util/Collection;)V", "GetSendFrame_Ljava_util_Collection_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void SendFrame (global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocket']/method[@name='sendPing' and count(parameter)=0]"
		[Register ("sendPing", "()V", "GetSendPingHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketInvoker, CleverTap.Bindings.Android")]
		void SendPing ();

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WebSocket", DoNotGenerateAcw=true)]
	internal partial class IWebSocketInvoker : global::Java.Lang.Object, IWebSocket {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WebSocket", typeof (IWebSocketInvoker));

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

		public static IWebSocket GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocket> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.WebSocket"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAttachment;
#pragma warning disable 0169
		static Delegate GetGetAttachmentHandler ()
		{
			if (cb_getAttachment == null)
				cb_getAttachment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachment);
			return cb_getAttachment;
		}

		static IntPtr n_GetAttachment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attachment);
		}
#pragma warning restore 0169

		static Delegate cb_setAttachment_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetAttachment_Ljava_lang_Object_Handler ()
		{
			if (cb_setAttachment_Ljava_lang_Object_ == null)
				cb_setAttachment_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttachment_Ljava_lang_Object_);
			return cb_setAttachment_Ljava_lang_Object_;
		}

		static void n_SetAttachment_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Attachment = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAttachment;
		IntPtr id_setAttachment_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Attachment {
			get {
				if (id_getAttachment == IntPtr.Zero)
					id_getAttachment = JNIEnv.GetMethodID (class_ref, "getAttachment", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttachment), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAttachment_Ljava_lang_Object_ == IntPtr.Zero)
					id_setAttachment_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setAttachment", "(Ljava/lang/Object;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttachment_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getDraft;
#pragma warning disable 0169
		static Delegate GetGetDraftHandler ()
		{
			if (cb_getDraft == null)
				cb_getDraft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDraft);
			return cb_getDraft;
		}

		static IntPtr n_GetDraft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Draft);
		}
#pragma warning restore 0169

		IntPtr id_getDraft;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft Draft {
			get {
				if (id_getDraft == IntPtr.Zero)
					id_getDraft = JNIEnv.GetMethodID (class_ref, "getDraft", "()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;");
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDraft), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasBufferedData;
#pragma warning disable 0169
		static Delegate GetHasBufferedDataHandler ()
		{
			if (cb_hasBufferedData == null)
				cb_hasBufferedData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBufferedData);
			return cb_hasBufferedData;
		}

		static bool n_HasBufferedData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBufferedData;
		}
#pragma warning restore 0169

		IntPtr id_hasBufferedData;
		public unsafe bool HasBufferedData {
			get {
				if (id_hasBufferedData == IntPtr.Zero)
					id_hasBufferedData = JNIEnv.GetMethodID (class_ref, "hasBufferedData", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBufferedData);
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		IntPtr id_isClosed;
		public unsafe bool IsClosed {
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
			}
		}

		static Delegate cb_isClosing;
#pragma warning disable 0169
		static Delegate GetIsClosingHandler ()
		{
			if (cb_isClosing == null)
				cb_isClosing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosing);
			return cb_isClosing;
		}

		static bool n_IsClosing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosing;
		}
#pragma warning restore 0169

		IntPtr id_isClosing;
		public unsafe bool IsClosing {
			get {
				if (id_isClosing == IntPtr.Zero)
					id_isClosing = JNIEnv.GetMethodID (class_ref, "isClosing", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosing);
			}
		}

		static Delegate cb_isFlushAndClose;
#pragma warning disable 0169
		static Delegate GetIsFlushAndCloseHandler ()
		{
			if (cb_isFlushAndClose == null)
				cb_isFlushAndClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFlushAndClose);
			return cb_isFlushAndClose;
		}

		static bool n_IsFlushAndClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFlushAndClose;
		}
#pragma warning restore 0169

		IntPtr id_isFlushAndClose;
		public unsafe bool IsFlushAndClose {
			get {
				if (id_isFlushAndClose == IntPtr.Zero)
					id_isFlushAndClose = JNIEnv.GetMethodID (class_ref, "isFlushAndClose", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFlushAndClose);
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		IntPtr id_isOpen;
		public unsafe bool IsOpen {
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
			}
		}

		static Delegate cb_getLocalSocketAddress;
#pragma warning disable 0169
		static Delegate GetGetLocalSocketAddressHandler ()
		{
			if (cb_getLocalSocketAddress == null)
				cb_getLocalSocketAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalSocketAddress);
			return cb_getLocalSocketAddress;
		}

		static IntPtr n_GetLocalSocketAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalSocketAddress);
		}
#pragma warning restore 0169

		IntPtr id_getLocalSocketAddress;
		public unsafe global::Java.Net.InetSocketAddress LocalSocketAddress {
			get {
				if (id_getLocalSocketAddress == IntPtr.Zero)
					id_getLocalSocketAddress = JNIEnv.GetMethodID (class_ref, "getLocalSocketAddress", "()Ljava/net/InetSocketAddress;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalSocketAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReadyState;
#pragma warning disable 0169
		static Delegate GetGetReadyStateHandler ()
		{
			if (cb_getReadyState == null)
				cb_getReadyState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReadyState);
			return cb_getReadyState;
		}

		static IntPtr n_GetReadyState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadyState);
		}
#pragma warning restore 0169

		IntPtr id_getReadyState;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState ReadyState {
			get {
				if (id_getReadyState == IntPtr.Zero)
					id_getReadyState = JNIEnv.GetMethodID (class_ref, "getReadyState", "()Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;");
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReadyState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRemoteSocketAddress;
#pragma warning disable 0169
		static Delegate GetGetRemoteSocketAddressHandler ()
		{
			if (cb_getRemoteSocketAddress == null)
				cb_getRemoteSocketAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoteSocketAddress);
			return cb_getRemoteSocketAddress;
		}

		static IntPtr n_GetRemoteSocketAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoteSocketAddress);
		}
#pragma warning restore 0169

		IntPtr id_getRemoteSocketAddress;
		public unsafe global::Java.Net.InetSocketAddress RemoteSocketAddress {
			get {
				if (id_getRemoteSocketAddress == IntPtr.Zero)
					id_getRemoteSocketAddress = JNIEnv.GetMethodID (class_ref, "getRemoteSocketAddress", "()Ljava/net/InetSocketAddress;");
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemoteSocketAddress), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceDescriptor);
		}
#pragma warning restore 0169

		IntPtr id_getResourceDescriptor;
		public unsafe string ResourceDescriptor {
			get {
				if (id_getResourceDescriptor == IntPtr.Zero)
					id_getResourceDescriptor = JNIEnv.GetMethodID (class_ref, "getResourceDescriptor", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceDescriptor), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_close_I;
#pragma warning disable 0169
		static Delegate GetClose_IHandler ()
		{
			if (cb_close_I == null)
				cb_close_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Close_I);
			return cb_close_I;
		}

		static void n_Close_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		IntPtr id_close_I;
		public unsafe void Close (int p0)
		{
			if (id_close_I == IntPtr.Zero)
				id_close_I = JNIEnv.GetMethodID (class_ref, "close", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_I, __args);
		}

		static Delegate cb_close_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClose_ILjava_lang_String_Handler ()
		{
			if (cb_close_ILjava_lang_String_ == null)
				cb_close_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Close_ILjava_lang_String_);
			return cb_close_ILjava_lang_String_;
		}

		static void n_Close_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_close_ILjava_lang_String_;
		public unsafe void Close (int p0, string p1)
		{
			if (id_close_ILjava_lang_String_ == IntPtr.Zero)
				id_close_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "close", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_closeConnection_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCloseConnection_ILjava_lang_String_Handler ()
		{
			if (cb_closeConnection_ILjava_lang_String_ == null)
				cb_closeConnection_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_CloseConnection_ILjava_lang_String_);
			return cb_closeConnection_ILjava_lang_String_;
		}

		static void n_CloseConnection_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_closeConnection_ILjava_lang_String_;
		public unsafe void CloseConnection (int p0, string p1)
		{
			if (id_closeConnection_ILjava_lang_String_ == IntPtr.Zero)
				id_closeConnection_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "closeConnection", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeConnection_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_send_arrayB;
#pragma warning disable 0169
		static Delegate GetSend_arrayBHandler ()
		{
			if (cb_send_arrayB == null)
				cb_send_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_arrayB);
			return cb_send_arrayB;
		}

		static void n_Send_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_send_arrayB;
		public unsafe void Send (byte[] p0)
		{
			if (id_send_arrayB == IntPtr.Zero)
				id_send_arrayB = JNIEnv.GetMethodID (class_ref, "send", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_send_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_lang_String_Handler ()
		{
			if (cb_send_Ljava_lang_String_ == null)
				cb_send_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_lang_String_);
			return cb_send_Ljava_lang_String_;
		}

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_lang_String_;
		public unsafe void Send (string p0)
		{
			if (id_send_Ljava_lang_String_ == IntPtr.Zero)
				id_send_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_send_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_send_Ljava_nio_ByteBuffer_ == null)
				cb_send_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_nio_ByteBuffer_);
			return cb_send_Ljava_nio_ByteBuffer_;
		}

		static void n_Send_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		IntPtr id_send_Ljava_nio_ByteBuffer_;
		public unsafe void Send (global::Java.Nio.ByteBuffer p0)
		{
			if (id_send_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_send_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "send", "(Ljava/nio/ByteBuffer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Ljava_nio_ByteBuffer_, __args);
		}

		static Delegate cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
#pragma warning disable 0169
		static Delegate GetSendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_ZHandler ()
		{
			if (cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z == null)
				cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z);
			return cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
		}

		static void n_SendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p1 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendFragmentedFrame (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
		public unsafe void SendFragmentedFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode p0, global::Java.Nio.ByteBuffer p1, bool p2)
		{
			if (id_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z == IntPtr.Zero)
				id_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z = JNIEnv.GetMethodID (class_ref, "sendFragmentedFrame", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;Ljava/nio/ByteBuffer;Z)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z, __args);
		}

		static Delegate cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetSendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_SendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendFrame (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		public unsafe void SendFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata p0)
		{
			if (id_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == IntPtr.Zero)
				id_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNIEnv.GetMethodID (class_ref, "sendFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_, __args);
		}

		static Delegate cb_sendFrame_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSendFrame_Ljava_util_Collection_Handler ()
		{
			if (cb_sendFrame_Ljava_util_Collection_ == null)
				cb_sendFrame_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFrame_Ljava_util_Collection_);
			return cb_sendFrame_Ljava_util_Collection_;
		}

		static void n_SendFrame_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendFrame (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendFrame_Ljava_util_Collection_;
		public unsafe void SendFrame (global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> p0)
		{
			if (id_sendFrame_Ljava_util_Collection_ == IntPtr.Zero)
				id_sendFrame_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "sendFrame", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFrame_Ljava_util_Collection_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendPing;
#pragma warning disable 0169
		static Delegate GetSendPingHandler ()
		{
			if (cb_sendPing == null)
				cb_sendPing = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendPing);
			return cb_sendPing;
		}

		static void n_SendPing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendPing ();
		}
#pragma warning restore 0169

		IntPtr id_sendPing;
		public unsafe void SendPing ()
		{
			if (id_sendPing == IntPtr.Zero)
				id_sendPing = JNIEnv.GetMethodID (class_ref, "sendPing", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPing);
		}

	}

}
