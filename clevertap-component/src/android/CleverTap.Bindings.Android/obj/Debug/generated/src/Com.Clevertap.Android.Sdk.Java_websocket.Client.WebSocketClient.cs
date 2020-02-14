using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/client/WebSocketClient", DoNotGenerateAcw=true)]
	public abstract partial class WebSocketClient : global::Com.Clevertap.Android.Sdk.Java_websocket.AbstractWebSocket, global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket, global::Java.Lang.IRunnable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/field[@name='uri']"
		[Register ("uri")]
		protected global::Java.Net.URI Uri {
			get {
				const string __id = "uri.Ljava/net/URI;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "uri.Ljava/net/URI;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/client/WebSocketClient", typeof (WebSocketClient));
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

		protected WebSocketClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/constructor[@name='WebSocketClient' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register (".ctor", "(Ljava/net/URI;)V", "")]
		public unsafe WebSocketClient (global::Java.Net.URI serverUri)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URI;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serverUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverUri).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/constructor[@name='WebSocketClient' and count(parameter)=2 and parameter[1][@type='java.net.URI'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft']]"
		[Register (".ctor", "(Ljava/net/URI;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;)V", "")]
		public unsafe WebSocketClient (global::Java.Net.URI serverUri, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft protocolDraft)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URI;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((serverUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverUri).Handle);
				__args [1] = new JniArgumentValue ((protocolDraft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocolDraft).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/constructor[@name='WebSocketClient' and count(parameter)=3 and parameter[1][@type='java.net.URI'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/net/URI;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Ljava/util/Map;)V", "")]
		public unsafe WebSocketClient (global::Java.Net.URI serverUri, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft protocolDraft, global::System.Collections.Generic.IDictionary<string, string> httpHeaders)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URI;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (httpHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((serverUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverUri).Handle);
				__args [1] = new JniArgumentValue ((protocolDraft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocolDraft).Handle);
				__args [2] = new JniArgumentValue (native_httpHeaders);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_httpHeaders);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/constructor[@name='WebSocketClient' and count(parameter)=4 and parameter[1][@type='java.net.URI'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/net/URI;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Ljava/util/Map;I)V", "")]
		public unsafe WebSocketClient (global::Java.Net.URI serverUri, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft protocolDraft, global::System.Collections.Generic.IDictionary<string, string> httpHeaders, int connectTimeout)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URI;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Ljava/util/Map;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (httpHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((serverUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverUri).Handle);
				__args [1] = new JniArgumentValue ((protocolDraft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocolDraft).Handle);
				__args [2] = new JniArgumentValue (native_httpHeaders);
				__args [3] = new JniArgumentValue (connectTimeout);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_httpHeaders);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/constructor[@name='WebSocketClient' and count(parameter)=2 and parameter[1][@type='java.net.URI'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/net/URI;Ljava/util/Map;)V", "")]
		public unsafe WebSocketClient (global::Java.Net.URI serverUri, global::System.Collections.Generic.IDictionary<string, string> httpHeaders)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URI;Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_httpHeaders = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (httpHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((serverUri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverUri).Handle);
				__args [1] = new JniArgumentValue (native_httpHeaders);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_httpHeaders);
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetAttachment_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attachment)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object attachment = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_attachment, JniHandleOwnership.DoNotTransfer);
			__this.Attachment = attachment;
		}
#pragma warning restore 0169

		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Attachment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getAttachment' and count(parameter)=0]"
			[Register ("getAttachment", "()Ljava/lang/Object;", "GetGetAttachmentHandler")]
			get {
				const string __id = "getAttachment.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='setAttachment' and count(parameter)=1 and parameter[1][@type='T']]"
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
			[Register ("setAttachment", "(Ljava/lang/Object;)V", "GetSetAttachment_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setAttachment.(Ljava/lang/Object;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConnection;
#pragma warning disable 0169
		static Delegate GetGetConnectionHandler ()
		{
			if (cb_getConnection == null)
				cb_getConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnection);
			return cb_getConnection;
		}

		static IntPtr n_GetConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connection);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Lcom/clevertap/android/sdk/java_websocket/WebSocket;", "GetGetConnectionHandler")]
			get {
				const string __id = "getConnection.()Lcom/clevertap/android/sdk/java_websocket/WebSocket;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnections;
#pragma warning disable 0169
		static Delegate GetGetConnectionsHandler ()
		{
			if (cb_getConnections == null)
				cb_getConnections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnections);
			return cb_getConnections;
		}

		static IntPtr n_GetConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket>.ToLocalJniHandle (__this.Connections);
		}
#pragma warning restore 0169

		protected override unsafe global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> Connections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getConnections' and count(parameter)=0]"
			[Register ("getConnections", "()Ljava/util/Collection;", "GetGetConnectionsHandler")]
			get {
				const string __id = "getConnections.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Draft);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft Draft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getDraft' and count(parameter)=0]"
			[Register ("getDraft", "()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;", "GetGetDraftHandler")]
			get {
				const string __id = "getDraft.()Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBufferedData;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBufferedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='hasBufferedData' and count(parameter)=0]"
			[Register ("hasBufferedData", "()Z", "GetHasBufferedDataHandler")]
			get {
				const string __id = "hasBufferedData.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				const string __id = "isClosed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClosing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='isClosing' and count(parameter)=0]"
			[Register ("isClosing", "()Z", "GetIsClosingHandler")]
			get {
				const string __id = "isClosing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFlushAndClose;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFlushAndClose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='isFlushAndClose' and count(parameter)=0]"
			[Register ("isFlushAndClose", "()Z", "GetIsFlushAndCloseHandler")]
			get {
				const string __id = "isFlushAndClose.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				const string __id = "isOpen.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalSocketAddress);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetSocketAddress LocalSocketAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getLocalSocketAddress' and count(parameter)=0]"
			[Register ("getLocalSocketAddress", "()Ljava/net/InetSocketAddress;", "GetGetLocalSocketAddressHandler")]
			get {
				const string __id = "getLocalSocketAddress.()Ljava/net/InetSocketAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadyState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState ReadyState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getReadyState' and count(parameter)=0]"
			[Register ("getReadyState", "()Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;", "GetGetReadyStateHandler")]
			get {
				const string __id = "getReadyState.()Lcom/clevertap/android/sdk/java_websocket/enums/ReadyState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoteSocketAddress);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetSocketAddress RemoteSocketAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getRemoteSocketAddress' and count(parameter)=0]"
			[Register ("getRemoteSocketAddress", "()Ljava/net/InetSocketAddress;", "GetGetRemoteSocketAddressHandler")]
			get {
				const string __id = "getRemoteSocketAddress.()Ljava/net/InetSocketAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceDescriptor);
		}
#pragma warning restore 0169

		public virtual unsafe string ResourceDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getResourceDescriptor' and count(parameter)=0]"
			[Register ("getResourceDescriptor", "()Ljava/lang/String;", "GetGetResourceDescriptorHandler")]
			get {
				const string __id = "getResourceDescriptor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSocket;
#pragma warning disable 0169
		static Delegate GetGetSocketHandler ()
		{
			if (cb_getSocket == null)
				cb_getSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocket);
			return cb_getSocket;
		}

		static IntPtr n_GetSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static Delegate cb_setSocket_Ljava_net_Socket_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetSocket_Ljava_net_Socket_Handler ()
		{
			if (cb_setSocket_Ljava_net_Socket_ == null)
				cb_setSocket_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSocket_Ljava_net_Socket_);
			return cb_setSocket_Ljava_net_Socket_;
		}

		[Obsolete]
		static void n_SetSocket_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socket)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket socket = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_socket, JniHandleOwnership.DoNotTransfer);
			__this.Socket = socket;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.Socket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Ljava/net/Socket;", "GetGetSocketHandler")]
			get {
				const string __id = "getSocket.()Ljava/net/Socket;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='setSocket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
			[Register ("setSocket", "(Ljava/net/Socket;)V", "GetSetSocket_Ljava_net_Socket_Handler")]
			set {
				const string __id = "setSocket.(Ljava/net/Socket;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getURI;
#pragma warning disable 0169
		static Delegate GetGetURIHandler ()
		{
			if (cb_getURI == null)
				cb_getURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURI);
			return cb_getURI;
		}

		static IntPtr n_GetURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.URI);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.URI URI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getURI' and count(parameter)=0]"
			[Register ("getURI", "()Ljava/net/URI;", "GetGetURIHandler")]
			get {
				const string __id = "getURI.()Ljava/net/URI;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_close_I;
#pragma warning disable 0169
		static Delegate GetClose_IHandler ()
		{
			if (cb_close_I == null)
				cb_close_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Close_I);
			return cb_close_I;
		}

		static void n_Close_I (IntPtr jnienv, IntPtr native__this, int code)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='close' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("close", "(I)V", "GetClose_IHandler")]
		public virtual unsafe void Close (int code)
		{
			const string __id = "close.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_close_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClose_ILjava_lang_String_Handler ()
		{
			if (cb_close_ILjava_lang_String_ == null)
				cb_close_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Close_ILjava_lang_String_);
			return cb_close_ILjava_lang_String_;
		}

		static void n_Close_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_message)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Close (code, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("close", "(ILjava/lang/String;)V", "GetClose_ILjava_lang_String_Handler")]
		public virtual unsafe void Close (int code, string message)
		{
			const string __id = "close.(ILjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_closeBlocking;
#pragma warning disable 0169
		static Delegate GetCloseBlockingHandler ()
		{
			if (cb_closeBlocking == null)
				cb_closeBlocking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseBlocking);
			return cb_closeBlocking;
		}

		static void n_CloseBlocking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseBlocking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='closeBlocking' and count(parameter)=0]"
		[Register ("closeBlocking", "()V", "GetCloseBlockingHandler")]
		public virtual unsafe void CloseBlocking ()
		{
			const string __id = "closeBlocking.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_closeConnection_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCloseConnection_ILjava_lang_String_Handler ()
		{
			if (cb_closeConnection_ILjava_lang_String_ == null)
				cb_closeConnection_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_CloseConnection_ILjava_lang_String_);
			return cb_closeConnection_ILjava_lang_String_;
		}

		static void n_CloseConnection_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_message)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection (code, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='closeConnection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("closeConnection", "(ILjava/lang/String;)V", "GetCloseConnection_ILjava_lang_String_Handler")]
		public virtual unsafe void CloseConnection (int code, string message)
		{
			const string __id = "closeConnection.(ILjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connectBlocking;
#pragma warning disable 0169
		static Delegate GetConnectBlockingHandler ()
		{
			if (cb_connectBlocking == null)
				cb_connectBlocking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ConnectBlocking);
			return cb_connectBlocking;
		}

		static bool n_ConnectBlocking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectBlocking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='connectBlocking' and count(parameter)=0]"
		[Register ("connectBlocking", "()Z", "GetConnectBlockingHandler")]
		public virtual unsafe bool ConnectBlocking ()
		{
			const string __id = "connectBlocking.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_connectBlocking_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetConnectBlocking_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_connectBlocking_JLjava_util_concurrent_TimeUnit_ == null)
				cb_connectBlocking_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, bool>) n_ConnectBlocking_JLjava_util_concurrent_TimeUnit_);
			return cb_connectBlocking_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_ConnectBlocking_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_timeUnit)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit timeUnit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_timeUnit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ConnectBlocking (timeout, timeUnit);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='connectBlocking' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("connectBlocking", "(JLjava/util/concurrent/TimeUnit;)Z", "GetConnectBlocking_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe bool ConnectBlocking (long timeout, global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			const string __id = "connectBlocking.(JLjava/util/concurrent/TimeUnit;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
#pragma warning disable 0169
		static Delegate GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler ()
		{
			if (cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == null)
				cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_);
			return cb_getLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		}

		static IntPtr n_GetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalSocketAddress (conn));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getLocalSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getLocalSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public override unsafe global::Java.Net.InetSocketAddress GetLocalSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn)
		{
			const string __id = "getLocalSocketAddress.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
#pragma warning disable 0169
		static Delegate GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler ()
		{
			if (cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ == null)
				cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_);
			return cb_getRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_;
		}

		static IntPtr n_GetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRemoteSocketAddress (conn));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='getRemoteSocketAddress' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("getRemoteSocketAddress", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;", "GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler")]
		public override unsafe global::Java.Net.InetSocketAddress GetRemoteSocketAddress (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn)
		{
			const string __id = "getRemoteSocketAddress.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.InetSocketAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onClose_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnClose_ILjava_lang_String_ZHandler ()
		{
			if (cb_onClose_ILjava_lang_String_Z == null)
				cb_onClose_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_OnClose_ILjava_lang_String_Z);
			return cb_onClose_ILjava_lang_String_Z;
		}

		static void n_OnClose_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnClose (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onClose' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("onClose", "(ILjava/lang/String;Z)V", "GetOnClose_ILjava_lang_String_ZHandler")]
		public abstract void OnClose (int p0, string p1, bool p2);

		static Delegate cb_onCloseInitiated_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCloseInitiated_ILjava_lang_String_Handler ()
		{
			if (cb_onCloseInitiated_ILjava_lang_String_ == null)
				cb_onCloseInitiated_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnCloseInitiated_ILjava_lang_String_);
			return cb_onCloseInitiated_ILjava_lang_String_;
		}

		static void n_OnCloseInitiated_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_reason)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseInitiated (code, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onCloseInitiated' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onCloseInitiated", "(ILjava/lang/String;)V", "GetOnCloseInitiated_ILjava_lang_String_Handler")]
		public virtual unsafe void OnCloseInitiated (int code, string reason)
		{
			const string __id = "onCloseInitiated.(ILjava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onClosing_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnClosing_ILjava_lang_String_ZHandler ()
		{
			if (cb_onClosing_ILjava_lang_String_Z == null)
				cb_onClosing_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_OnClosing_ILjava_lang_String_Z);
			return cb_onClosing_ILjava_lang_String_Z;
		}

		static void n_OnClosing_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_reason, bool remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnClosing (code, reason, remote);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onClosing' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("onClosing", "(ILjava/lang/String;Z)V", "GetOnClosing_ILjava_lang_String_ZHandler")]
		public virtual unsafe void OnClosing (int code, string reason, bool remote)
		{
			const string __id = "onClosing.(ILjava/lang/String;Z)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_reason);
				__args [2] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Exception_);
			return cb_onError_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler")]
		public abstract void OnError (global::Java.Lang.Exception p0);

		static Delegate cb_onMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Ljava_lang_String_Handler ()
		{
			if (cb_onMessage_Ljava_lang_String_ == null)
				cb_onMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Ljava_lang_String_);
			return cb_onMessage_Ljava_lang_String_;
		}

		static void n_OnMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessage", "(Ljava/lang/String;)V", "GetOnMessage_Ljava_lang_String_Handler")]
		public abstract void OnMessage (string p0);

		static Delegate cb_onMessage_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_onMessage_Ljava_nio_ByteBuffer_ == null)
				cb_onMessage_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Ljava_nio_ByteBuffer_);
			return cb_onMessage_Ljava_nio_ByteBuffer_;
		}

		static void n_OnMessage_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bytes = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bytes, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("onMessage", "(Ljava/nio/ByteBuffer;)V", "GetOnMessage_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void OnMessage (global::Java.Nio.ByteBuffer bytes)
		{
			const string __id = "onMessage.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler ()
		{
			if (cb_onOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ == null)
				cb_onOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_);
			return cb_onOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_;
		}

		static void n_OnOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p0 = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("onOpen", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V", "GetOnOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler")]
		public abstract void OnOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketClose' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClose", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "")]
		public override sealed unsafe void OnWebsocketClose (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, int code, string reason, bool remote)
		{
			const string __id = "onWebsocketClose.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_reason);
				__args [3] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler ()
		{
			if (cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ == null)
				cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_);
			return cb_onWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_;
		}

		static void n_OnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, int code, IntPtr native_reason)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketCloseInitiated (conn, code, reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketCloseInitiated' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onWebsocketCloseInitiated", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V", "GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler")]
		public override unsafe void OnWebsocketCloseInitiated (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, int code, string reason)
		{
			const string __id = "onWebsocketCloseInitiated.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		static Delegate cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler ()
		{
			if (cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z == null)
				cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z);
			return cb_onWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z;
		}

		static void n_OnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_conn, int code, IntPtr native_reason, bool remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn = (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (native_conn, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.OnWebsocketClosing (conn, code, reason, remote);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketClosing' and count(parameter)=4 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("onWebsocketClosing", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V", "GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler")]
		public override unsafe void OnWebsocketClosing (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, int code, string reason, bool remote)
		{
			const string __id = "onWebsocketClosing.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_reason);
				__args [3] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketError' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onWebsocketError", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V", "")]
		public override sealed unsafe void OnWebsocketError (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Java.Lang.Exception ex)
		{
			const string __id = "onWebsocketError.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketMessage' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.lang.String']]"
		[Register ("onWebsocketMessage", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V", "")]
		public override sealed unsafe void OnWebsocketMessage (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, string message)
		{
			const string __id = "onWebsocketMessage.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketMessageBuffer' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register ("onWebsocketMessageBuffer", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V", "")]
		public override sealed unsafe void OnWebsocketMessageBuffer (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Java.Nio.ByteBuffer blob)
		{
			const string __id = "onWebsocketMessageBuffer.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((blob == null) ? IntPtr.Zero : ((global::Java.Lang.Object) blob).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWebsocketOpen' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.handshake.Handshakedata']]"
		[Register ("onWebsocketOpen", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V", "")]
		public override sealed unsafe void OnWebsocketOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn, global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IHandshakedata handshake)
		{
			const string __id = "onWebsocketOpen.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [1] = new JniArgumentValue ((handshake == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshake).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onWriteDemand' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocket']]"
		[Register ("onWriteDemand", "(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V", "")]
		public override sealed unsafe void OnWriteDemand (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket conn)
		{
			const string __id = "onWriteDemand.(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reconnect;
#pragma warning disable 0169
		static Delegate GetReconnectHandler ()
		{
			if (cb_reconnect == null)
				cb_reconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reconnect);
			return cb_reconnect;
		}

		static void n_Reconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public virtual unsafe void Reconnect ()
		{
			const string __id = "reconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reconnectBlocking;
#pragma warning disable 0169
		static Delegate GetReconnectBlockingHandler ()
		{
			if (cb_reconnectBlocking == null)
				cb_reconnectBlocking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ReconnectBlocking);
			return cb_reconnectBlocking;
		}

		static bool n_ReconnectBlocking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReconnectBlocking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='reconnectBlocking' and count(parameter)=0]"
		[Register ("reconnectBlocking", "()Z", "GetReconnectBlockingHandler")]
		public virtual unsafe bool ReconnectBlocking ()
		{
			const string __id = "reconnectBlocking.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_send_arrayB;
#pragma warning disable 0169
		static Delegate GetSend_arrayBHandler ()
		{
			if (cb_send_arrayB == null)
				cb_send_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_arrayB);
			return cb_send_arrayB;
		}

		static void n_Send_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='send' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("send", "([B)V", "GetSend_arrayBHandler")]
		public virtual unsafe void Send (byte[] data)
		{
			const string __id = "send.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
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

		static void n_Send_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.Send (text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("send", "(Ljava/lang/String;)V", "GetSend_Ljava_lang_String_Handler")]
		public virtual unsafe void Send (string text)
		{
			const string __id = "send.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_send_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSend_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_send_Ljava_nio_ByteBuffer_ == null)
				cb_send_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Ljava_nio_ByteBuffer_);
			return cb_send_Ljava_nio_ByteBuffer_;
		}

		static void n_Send_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bytes = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bytes, JniHandleOwnership.DoNotTransfer);
			__this.Send (bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("send", "(Ljava/nio/ByteBuffer;)V", "GetSend_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Send (global::Java.Nio.ByteBuffer bytes)
		{
			const string __id = "send.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bytes).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
#pragma warning disable 0169
		static Delegate GetSendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_ZHandler ()
		{
			if (cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z == null)
				cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z);
			return cb_sendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z;
		}

		static void n_SendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_op, IntPtr native_buffer, bool fin)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode op = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (native_op, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.SendFragmentedFrame (op, buffer, fin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='sendFragmentedFrame' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='boolean']]"
		[Register ("sendFragmentedFrame", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;Ljava/nio/ByteBuffer;Z)V", "GetSendFragmentedFrame_Lcom_clevertap_android_sdk_java_websocket_enums_Opcode_Ljava_nio_ByteBuffer_ZHandler")]
		public virtual unsafe void SendFragmentedFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode op, global::Java.Nio.ByteBuffer buffer, bool fin)
		{
			const string __id = "sendFragmentedFrame.(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;Ljava/nio/ByteBuffer;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [2] = new JniArgumentValue (fin);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetSendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_sendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_SendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_framedata)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata framedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_framedata, JniHandleOwnership.DoNotTransfer);
			__this.SendFrame (framedata);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='sendFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("sendFrame", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetSendFrame_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void SendFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata framedata)
		{
			const string __id = "sendFrame.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((framedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framedata).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendFrame_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSendFrame_Ljava_util_Collection_Handler ()
		{
			if (cb_sendFrame_Ljava_util_Collection_ == null)
				cb_sendFrame_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFrame_Ljava_util_Collection_);
			return cb_sendFrame_Ljava_util_Collection_;
		}

		static void n_SendFrame_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frames)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frames = global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (native_frames, JniHandleOwnership.DoNotTransfer);
			__this.SendFrame (frames);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='sendFrame' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.clevertap.android.sdk.java_websocket.framing.Framedata&gt;']]"
		[Register ("sendFrame", "(Ljava/util/Collection;)V", "GetSendFrame_Ljava_util_Collection_Handler")]
		public virtual unsafe void SendFrame (global::System.Collections.Generic.ICollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> frames)
		{
			const string __id = "sendFrame.(Ljava/util/Collection;)V";
			IntPtr native_frames = global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.ToLocalJniHandle (frames);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_frames);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_frames);
			}
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendPing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='sendPing' and count(parameter)=0]"
		[Register ("sendPing", "()V", "GetSendPingHandler")]
		public virtual unsafe void SendPing ()
		{
			const string __id = "sendPing.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setProxy_Ljava_net_Proxy_;
#pragma warning disable 0169
		static Delegate GetSetProxy_Ljava_net_Proxy_Handler ()
		{
			if (cb_setProxy_Ljava_net_Proxy_ == null)
				cb_setProxy_Ljava_net_Proxy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProxy_Ljava_net_Proxy_);
			return cb_setProxy_Ljava_net_Proxy_;
		}

		static void n_SetProxy_Ljava_net_Proxy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proxy)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Proxy proxy = global::Java.Lang.Object.GetObject<global::Java.Net.Proxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			__this.SetProxy (proxy);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='setProxy' and count(parameter)=1 and parameter[1][@type='java.net.Proxy']]"
		[Register ("setProxy", "(Ljava/net/Proxy;)V", "GetSetProxy_Ljava_net_Proxy_Handler")]
		public virtual unsafe void SetProxy (global::Java.Net.Proxy proxy)
		{
			const string __id = "setProxy.(Ljava/net/Proxy;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((proxy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) proxy).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSocketFactory_Ljavax_net_SocketFactory_;
#pragma warning disable 0169
		static Delegate GetSetSocketFactory_Ljavax_net_SocketFactory_Handler ()
		{
			if (cb_setSocketFactory_Ljavax_net_SocketFactory_ == null)
				cb_setSocketFactory_Ljavax_net_SocketFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSocketFactory_Ljavax_net_SocketFactory_);
			return cb_setSocketFactory_Ljavax_net_SocketFactory_;
		}

		static void n_SetSocketFactory_Ljavax_net_SocketFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socketFactory)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Client.WebSocketClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.SocketFactory socketFactory = global::Java.Lang.Object.GetObject<global::Javax.Net.SocketFactory> (native_socketFactory, JniHandleOwnership.DoNotTransfer);
			__this.SetSocketFactory (socketFactory);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='setSocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.SocketFactory']]"
		[Register ("setSocketFactory", "(Ljavax/net/SocketFactory;)V", "GetSetSocketFactory_Ljavax_net_SocketFactory_Handler")]
		public virtual unsafe void SetSocketFactory (global::Javax.Net.SocketFactory socketFactory)
		{
			const string __id = "setSocketFactory.(Ljavax/net/SocketFactory;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socketFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socketFactory).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/client/WebSocketClient", DoNotGenerateAcw=true)]
	internal partial class WebSocketClientInvoker : WebSocketClient {

		public WebSocketClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/client/WebSocketClient", typeof (WebSocketClientInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onClose' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("onClose", "(ILjava/lang/String;Z)V", "GetOnClose_ILjava_lang_String_ZHandler")]
		public override unsafe void OnClose (int p0, string p1, bool p2)
		{
			const string __id = "onClose.(ILjava/lang/String;Z)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler")]
		public override unsafe void OnError (global::Java.Lang.Exception p0)
		{
			const string __id = "onError.(Ljava/lang/Exception;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessage", "(Ljava/lang/String;)V", "GetOnMessage_Ljava_lang_String_Handler")]
		public override unsafe void OnMessage (string p0)
		{
			const string __id = "onMessage.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.client']/class[@name='WebSocketClient']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake']]"
		[Register ("onOpen", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V", "GetOnOpen_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler")]
		public override unsafe void OnOpen (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IServerHandshake p0)
		{
			const string __id = "onOpen.(Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
