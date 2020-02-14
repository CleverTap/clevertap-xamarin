using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WebSocketImpl", DoNotGenerateAcw=true)]
	public partial class WebSocketImpl : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/field[@name='DEFAULT_PORT']"
		[Register ("DEFAULT_PORT")]
		public const int DefaultPort = (int) 80;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/field[@name='DEFAULT_WSS_PORT']"
		[Register ("DEFAULT_WSS_PORT")]
		public const int DefaultWssPort = (int) 443;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/field[@name='RCVBUF']"
		[Register ("RCVBUF")]
		public const int Rcvbuf = (int) 16384;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/field[@name='inQueue']"
		[Register ("inQueue")]
		public global::Java.Util.Concurrent.IBlockingQueue InQueue {
			get {
				const string __id = "inQueue.Ljava/util/concurrent/BlockingQueue;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IBlockingQueue> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "inQueue.Ljava/util/concurrent/BlockingQueue;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/field[@name='outQueue']"
		[Register ("outQueue")]
		public global::Java.Util.Concurrent.IBlockingQueue OutQueue {
			get {
				const string __id = "outQueue.Ljava/util/concurrent/BlockingQueue;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IBlockingQueue> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "outQueue.Ljava/util/concurrent/BlockingQueue;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WebSocketImpl", typeof (WebSocketImpl));
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

		protected WebSocketImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/constructor[@name='WebSocketImpl' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketListener'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketListener;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;)V", "")]
		public unsafe WebSocketImpl (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener listener, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft draft)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/java_websocket/WebSocketListener;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue ((draft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draft).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/constructor[@name='WebSocketImpl' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketListener'] and parameter[2][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.drafts.Draft&gt;']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketListener;Ljava/util/List;)V", "")]
		public unsafe WebSocketImpl (global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener listener, global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> drafts)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/java_websocket/WebSocketListener;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_drafts = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft>.ToLocalJniHandle (drafts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [1] = new JniArgumentValue (native_drafts);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_drafts);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object attachment = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_attachment, JniHandleOwnership.DoNotTransfer);
			__this.Attachment = attachment;
		}
#pragma warning restore 0169

		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object Attachment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getAttachment' and count(parameter)=0]"
			[Register ("getAttachment", "()Ljava/lang/Object;", "GetGetAttachmentHandler")]
			get {
				const string __id = "getAttachment.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='setAttachment' and count(parameter)=1 and parameter[1][@type='T']]"
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

		static Delegate cb_getChannel;
#pragma warning disable 0169
		static Delegate GetGetChannelHandler ()
		{
			if (cb_getChannel == null)
				cb_getChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannel);
			return cb_getChannel;
		}

		static IntPtr n_GetChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Channel);
		}
#pragma warning restore 0169

		static Delegate cb_setChannel_Ljava_nio_channels_ByteChannel_;
#pragma warning disable 0169
		static Delegate GetSetChannel_Ljava_nio_channels_ByteChannel_Handler ()
		{
			if (cb_setChannel_Ljava_nio_channels_ByteChannel_ == null)
				cb_setChannel_Ljava_nio_channels_ByteChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannel_Ljava_nio_channels_ByteChannel_);
			return cb_setChannel_Ljava_nio_channels_ByteChannel_;
		}

		static void n_SetChannel_Ljava_nio_channels_ByteChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Channels.IByteChannel channel = (global::Java.Nio.Channels.IByteChannel)global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.IByteChannel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.Channel = channel;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.Channels.IByteChannel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Ljava/nio/channels/ByteChannel;", "GetGetChannelHandler")]
			get {
				const string __id = "getChannel.()Ljava/nio/channels/ByteChannel;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.IByteChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='setChannel' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ByteChannel']]"
			[Register ("setChannel", "(Ljava/nio/channels/ByteChannel;)V", "GetSetChannel_Ljava_nio_channels_ByteChannel_Handler")]
			set {
				const string __id = "setChannel.(Ljava/nio/channels/ByteChannel;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Draft);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft Draft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getDraft' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBufferedData;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasBufferedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='hasBufferedData' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='isClosed' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClosing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='isClosing' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFlushAndClose;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFlushAndClose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='isFlushAndClose' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='isOpen' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalSocketAddress);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetSocketAddress LocalSocketAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getLocalSocketAddress' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadyState);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.ReadyState ReadyState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getReadyState' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoteSocketAddress);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetSocketAddress RemoteSocketAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getRemoteSocketAddress' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceDescriptor);
		}
#pragma warning restore 0169

		public virtual unsafe string ResourceDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getResourceDescriptor' and count(parameter)=0]"
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

		static Delegate cb_getSelectionKey;
#pragma warning disable 0169
		static Delegate GetGetSelectionKeyHandler ()
		{
			if (cb_getSelectionKey == null)
				cb_getSelectionKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectionKey);
			return cb_getSelectionKey;
		}

		static IntPtr n_GetSelectionKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionKey);
		}
#pragma warning restore 0169

		static Delegate cb_setSelectionKey_Ljava_nio_channels_SelectionKey_;
#pragma warning disable 0169
		static Delegate GetSetSelectionKey_Ljava_nio_channels_SelectionKey_Handler ()
		{
			if (cb_setSelectionKey_Ljava_nio_channels_SelectionKey_ == null)
				cb_setSelectionKey_Ljava_nio_channels_SelectionKey_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectionKey_Ljava_nio_channels_SelectionKey_);
			return cb_setSelectionKey_Ljava_nio_channels_SelectionKey_;
		}

		static void n_SetSelectionKey_Ljava_nio_channels_SelectionKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Channels.SelectionKey key = global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.SelectionKey> (native_key, JniHandleOwnership.DoNotTransfer);
			__this.SelectionKey = key;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.Channels.SelectionKey SelectionKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getSelectionKey' and count(parameter)=0]"
			[Register ("getSelectionKey", "()Ljava/nio/channels/SelectionKey;", "GetGetSelectionKeyHandler")]
			get {
				const string __id = "getSelectionKey.()Ljava/nio/channels/SelectionKey;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.SelectionKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='setSelectionKey' and count(parameter)=1 and parameter[1][@type='java.nio.channels.SelectionKey']]"
			[Register ("setSelectionKey", "(Ljava/nio/channels/SelectionKey;)V", "GetSetSelectionKey_Ljava_nio_channels_SelectionKey_Handler")]
			set {
				const string __id = "setSelectionKey.(Ljava/nio/channels/SelectionKey;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWebSocketListener;
#pragma warning disable 0169
		static Delegate GetGetWebSocketListenerHandler ()
		{
			if (cb_getWebSocketListener == null)
				cb_getWebSocketListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebSocketListener);
			return cb_getWebSocketListener;
		}

		static IntPtr n_GetWebSocketListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WebSocketListener);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener WebSocketListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='getWebSocketListener' and count(parameter)=0]"
			[Register ("getWebSocketListener", "()Lcom/clevertap/android/sdk/java_websocket/WebSocketListener;", "GetGetWebSocketListenerHandler")]
			get {
				const string __id = "getWebSocketListener.()Lcom/clevertap/android/sdk/java_websocket/WebSocketListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_close_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_;
#pragma warning disable 0169
		static Delegate GetClose_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_Handler ()
		{
			if (cb_close_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_ == null)
				cb_close_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Close_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_);
			return cb_close_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_;
		}

		static void n_Close_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.InvalidDataException e = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.InvalidDataException> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Close (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='close' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.exceptions.InvalidDataException']]"
		[Register ("close", "(Lcom/clevertap/android/sdk/java_websocket/exceptions/InvalidDataException;)V", "GetClose_Lcom_clevertap_android_sdk_java_websocket_exceptions_InvalidDataException_Handler")]
		public virtual unsafe void Close (global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.InvalidDataException e)
		{
			const string __id = "close.(Lcom/clevertap/android/sdk/java_websocket/exceptions/InvalidDataException;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='close' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Close (code, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='close' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_close_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetClose_ILjava_lang_String_ZHandler ()
		{
			if (cb_close_ILjava_lang_String_Z == null)
				cb_close_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_Close_ILjava_lang_String_Z);
			return cb_close_ILjava_lang_String_Z;
		}

		static void n_Close_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_message, bool remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Close (code, message, remote);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='close' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("close", "(ILjava/lang/String;Z)V", "GetClose_ILjava_lang_String_ZHandler")]
		public virtual unsafe void Close (int code, string message, bool remote)
		{
			const string __id = "close.(ILjava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_closeConnection;
#pragma warning disable 0169
		static Delegate GetCloseConnectionHandler ()
		{
			if (cb_closeConnection == null)
				cb_closeConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseConnection);
			return cb_closeConnection;
		}

		static void n_CloseConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='closeConnection' and count(parameter)=0]"
		[Register ("closeConnection", "()V", "GetCloseConnectionHandler")]
		public virtual unsafe void CloseConnection ()
		{
			const string __id = "closeConnection.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_closeConnection_IZ;
#pragma warning disable 0169
		static Delegate GetCloseConnection_IZHandler ()
		{
			if (cb_closeConnection_IZ == null)
				cb_closeConnection_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_CloseConnection_IZ);
			return cb_closeConnection_IZ;
		}

		static void n_CloseConnection_IZ (IntPtr jnienv, IntPtr native__this, int code, bool remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection (code, remote);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='closeConnection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("closeConnection", "(IZ)V", "GetCloseConnection_IZHandler")]
		protected virtual unsafe void CloseConnection (int code, bool remote)
		{
			const string __id = "closeConnection.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection (code, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='closeConnection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_closeConnection_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetCloseConnection_ILjava_lang_String_ZHandler ()
		{
			if (cb_closeConnection_ILjava_lang_String_Z == null)
				cb_closeConnection_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_CloseConnection_ILjava_lang_String_Z);
			return cb_closeConnection_ILjava_lang_String_Z;
		}

		static void n_CloseConnection_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_message, bool remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.CloseConnection (code, message, remote);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='closeConnection' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("closeConnection", "(ILjava/lang/String;Z)V", "GetCloseConnection_ILjava_lang_String_ZHandler")]
		public virtual unsafe void CloseConnection (int code, string message, bool remote)
		{
			const string __id = "closeConnection.(ILjava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_decode_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDecode_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_decode_Ljava_nio_ByteBuffer_ == null)
				cb_decode_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Decode_Ljava_nio_ByteBuffer_);
			return cb_decode_Ljava_nio_ByteBuffer_;
		}

		static void n_Decode_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_socketBuffer)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer socketBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_socketBuffer, JniHandleOwnership.DoNotTransfer);
			__this.Decode (socketBuffer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("decode", "(Ljava/nio/ByteBuffer;)V", "GetDecode_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Decode (global::Java.Nio.ByteBuffer socketBuffer)
		{
			const string __id = "decode.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((socketBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) socketBuffer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_eot;
#pragma warning disable 0169
		static Delegate GetEotHandler ()
		{
			if (cb_eot == null)
				cb_eot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Eot);
			return cb_eot;
		}

		static void n_Eot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Eot ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='eot' and count(parameter)=0]"
		[Register ("eot", "()V", "GetEotHandler")]
		public virtual unsafe void Eot ()
		{
			const string __id = "eot.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flushAndClose_ILjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetFlushAndClose_ILjava_lang_String_ZHandler ()
		{
			if (cb_flushAndClose_ILjava_lang_String_Z == null)
				cb_flushAndClose_ILjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_FlushAndClose_ILjava_lang_String_Z);
			return cb_flushAndClose_ILjava_lang_String_Z;
		}

		static void n_FlushAndClose_ILjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_message, bool remote)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.FlushAndClose (code, message, remote);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='flushAndClose' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("flushAndClose", "(ILjava/lang/String;Z)V", "GetFlushAndClose_ILjava_lang_String_ZHandler")]
		public virtual unsafe void FlushAndClose (int code, string message, bool remote)
		{
			const string __id = "flushAndClose.(ILjava/lang/String;Z)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (remote);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
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

		static void n_Send_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Send (bytes);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("send", "([B)V", "GetSend_arrayBHandler")]
		public virtual unsafe void Send (byte[] bytes)
		{
			const string __id = "send.([B)V";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.Send (text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer bytes = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bytes, JniHandleOwnership.DoNotTransfer);
			__this.Send (bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='send' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode op = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (native_op, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.SendFragmentedFrame (op, buffer, fin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='sendFragmentedFrame' and count(parameter)=3 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='boolean']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata framedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_framedata, JniHandleOwnership.DoNotTransfer);
			__this.SendFrame (framedata);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='sendFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frames = global::Android.Runtime.JavaCollection<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata>.FromJniHandle (native_frames, JniHandleOwnership.DoNotTransfer);
			__this.SendFrame (frames);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='sendFrame' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.clevertap.android.sdk.java_websocket.framing.Framedata&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendPing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='sendPing' and count(parameter)=0]"
		[Register ("sendPing", "()V", "GetSendPingHandler")]
		public virtual unsafe void SendPing ()
		{
			const string __id = "sendPing.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_startHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_;
#pragma warning disable 0169
		static Delegate GetStartHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_Handler ()
		{
			if (cb_startHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ == null)
				cb_startHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_);
			return cb_startHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_;
		}

		static void n_StartHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handshakedata)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder handshakedata = (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder> (native_handshakedata, JniHandleOwnership.DoNotTransfer);
			__this.StartHandshake (handshakedata);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='startHandshake' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.handshake.ClientHandshakeBuilder']]"
		[Register ("startHandshake", "(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)V", "GetStartHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshakeBuilder_Handler")]
		public virtual unsafe void StartHandshake (global::Com.Clevertap.Android.Sdk.Java_websocket.Handshake.IClientHandshakeBuilder handshakedata)
		{
			const string __id = "startHandshake.(Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshakeBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handshakedata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handshakedata).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateLastPong;
#pragma warning disable 0169
		static Delegate GetUpdateLastPongHandler ()
		{
			if (cb_updateLastPong == null)
				cb_updateLastPong = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateLastPong);
			return cb_updateLastPong;
		}

		static void n_UpdateLastPong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLastPong ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/class[@name='WebSocketImpl']/method[@name='updateLastPong' and count(parameter)=0]"
		[Register ("updateLastPong", "()V", "GetUpdateLastPongHandler")]
		public virtual unsafe void UpdateLastPong ()
		{
			const string __id = "updateLastPong.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
