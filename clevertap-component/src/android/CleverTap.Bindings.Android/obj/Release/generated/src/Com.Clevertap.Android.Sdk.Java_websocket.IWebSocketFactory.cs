using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketFactory']"
	[Register ("com/clevertap/android/sdk/java_websocket/WebSocketFactory", "", "Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactoryInvoker")]
	public partial interface IWebSocketFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketFactory']/method[@name='createWebSocket' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketAdapter'] and parameter[2][@type='com.clevertap.android.sdk.java_websocket.drafts.Draft']]"
		[Register ("createWebSocket", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketAdapter;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;)Lcom/clevertap/android/sdk/java_websocket/WebSocket;", "GetCreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactoryInvoker, CleverTap.Bindings.Android")]
		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket CreateWebSocket (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket']/interface[@name='WebSocketFactory']/method[@name='createWebSocket' and count(parameter)=2 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.WebSocketAdapter'] and parameter[2][@type='java.util.List&lt;com.clevertap.android.sdk.java_websocket.drafts.Draft&gt;']]"
		[Register ("createWebSocket", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketAdapter;Ljava/util/List;)Lcom/clevertap/android/sdk/java_websocket/WebSocket;", "GetCreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactoryInvoker, CleverTap.Bindings.Android")]
		global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket CreateWebSocket (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter p0, global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> p1);

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/WebSocketFactory", DoNotGenerateAcw=true)]
	internal partial class IWebSocketFactoryInvoker : global::Java.Lang.Object, IWebSocketFactory {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/WebSocketFactory", typeof (IWebSocketFactoryInvoker));

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

		public static IWebSocketFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebSocketFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.java_websocket.WebSocketFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebSocketFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_;
#pragma warning disable 0169
		static Delegate GetCreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Handler ()
		{
			if (cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_ == null)
				cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_);
			return cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_;
		}

		static IntPtr n_CreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateWebSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket CreateWebSocket (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter p0, global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft p1)
		{
			if (id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_ == IntPtr.Zero)
				id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_ = JNIEnv.GetMethodID (class_ref, "createWebSocket", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketAdapter;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;)Lcom/clevertap/android/sdk/java_websocket/WebSocket;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __ret = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_Handler ()
		{
			if (cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_ == null)
				cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_);
			return cb_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_;
		}

		static IntPtr n_CreateWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter p0 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateWebSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_;
		public unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket CreateWebSocket (global::Com.Clevertap.Android.Sdk.Java_websocket.WebSocketAdapter p0, global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft> p1)
		{
			if (id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_ == IntPtr.Zero)
				id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "createWebSocket", "(Lcom/clevertap/android/sdk/java_websocket/WebSocketAdapter;Ljava/util/List;)Lcom/clevertap/android/sdk/java_websocket/WebSocket;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Java_websocket.Drafts.Draft>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket __ret = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.IWebSocket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createWebSocket_Lcom_clevertap_android_sdk_java_websocket_WebSocketAdapter_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
