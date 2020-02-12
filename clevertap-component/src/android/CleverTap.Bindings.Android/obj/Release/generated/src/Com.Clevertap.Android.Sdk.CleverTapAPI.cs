using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CleverTapAPI", DoNotGenerateAcw=true)]
	public partial class CleverTapAPI : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.CTInAppBaseFragment.IInAppListener, global::Com.Clevertap.Android.Sdk.CTInAppNotification.ICTInAppNotificationListener, global::Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/field[@name='NOTIFICATION_TAG']"
		[Register ("NOTIFICATION_TAG")]
		public const string NotificationTag = (string) "wzrk_pn";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CleverTapAPI.DevicePushTokenRefreshListener']"
		[Register ("com/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener", "", "Com.Clevertap.Android.Sdk.CleverTapAPI/IDevicePushTokenRefreshListenerInvoker")]
		public partial interface IDevicePushTokenRefreshListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/interface[@name='CleverTapAPI.DevicePushTokenRefreshListener']/method[@name='devicePushTokenDidRefresh' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.clevertap.android.sdk.PushType']]"
			[Register ("devicePushTokenDidRefresh", "(Ljava/lang/String;Lcom/clevertap/android/sdk/PushType;)V", "GetDevicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_Handler:Com.Clevertap.Android.Sdk.CleverTapAPI/IDevicePushTokenRefreshListenerInvoker, CleverTap.Bindings.Android")]
			void DevicePushTokenDidRefresh (string p0, global::Com.Clevertap.Android.Sdk.PushType p1);

		}

		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener", DoNotGenerateAcw=true)]
		internal partial class IDevicePushTokenRefreshListenerInvoker : global::Java.Lang.Object, IDevicePushTokenRefreshListener {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener", typeof (IDevicePushTokenRefreshListenerInvoker));

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

			public static IDevicePushTokenRefreshListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDevicePushTokenRefreshListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.clevertap.android.sdk.CleverTapAPI.DevicePushTokenRefreshListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDevicePushTokenRefreshListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_;
#pragma warning disable 0169
			static Delegate GetDevicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_Handler ()
			{
				if (cb_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_ == null)
					cb_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DevicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_);
				return cb_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_;
			}

			static void n_DevicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Clevertap.Android.Sdk.PushType p1 = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.PushType> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.DevicePushTokenDidRefresh (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_;
			public unsafe void DevicePushTokenDidRefresh (string p0, global::Com.Clevertap.Android.Sdk.PushType p1)
			{
				if (id_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_ == IntPtr.Zero)
					id_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_ = JNIEnv.GetMethodID (class_ref, "devicePushTokenDidRefresh", "(Ljava/lang/String;Lcom/clevertap/android/sdk/PushType;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_devicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.clevertap.android.sdk.CleverTapAPI.DevicePushTokenRefreshListener.devicePushTokenDidRefresh
		public partial class DevicePushTokenRefreshEventArgs : global::System.EventArgs {

			public DevicePushTokenRefreshEventArgs (string p0, global::Com.Clevertap.Android.Sdk.PushType p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Com.Clevertap.Android.Sdk.PushType p1;
			public global::Com.Clevertap.Android.Sdk.PushType P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/clevertap/android/sdk/CleverTapAPI_DevicePushTokenRefreshListenerImplementor")]
		internal sealed partial class IDevicePushTokenRefreshListenerImplementor : global::Java.Lang.Object, IDevicePushTokenRefreshListener {

			object sender;

			public IDevicePushTokenRefreshListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/clevertap/android/sdk/CleverTapAPI_DevicePushTokenRefreshListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DevicePushTokenRefreshEventArgs> Handler;
#pragma warning restore 0649

			public void DevicePushTokenDidRefresh (string p0, global::Com.Clevertap.Android.Sdk.PushType p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DevicePushTokenRefreshEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDevicePushTokenRefreshListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/CleverTapAPI$LogLevel", DoNotGenerateAcw=true)]
		public sealed partial class LogLevel : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel Debug {
				get {
					const string __id = "DEBUG.Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel Info {
				get {
					const string __id = "INFO.Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']/field[@name='OFF']"
			[Register ("OFF")]
			public static global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel Off {
				get {
					const string __id = "OFF.Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CleverTapAPI$LogLevel", typeof (LogLevel));
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

			internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']/method[@name='intValue' and count(parameter)=0]"
			[Register ("intValue", "()I", "")]
			public unsafe int IntValue ()
			{
				const string __id = "intValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;", "")]
			public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI.LogLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;", "")]
			public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel[] Values ()
			{
				const string __id = "values.()[Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel));
				} finally {
				}
			}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CleverTapAPI", typeof (CleverTapAPI));
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

		protected CleverTapAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllInboxMessages;
#pragma warning disable 0169
		static Delegate GetGetAllInboxMessagesHandler ()
		{
			if (cb_getAllInboxMessages == null)
				cb_getAllInboxMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllInboxMessages);
			return cb_getAllInboxMessages;
		}

		static IntPtr n_GetAllInboxMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.CTInboxMessage>.ToLocalJniHandle (__this.AllInboxMessages);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.CTInboxMessage> AllInboxMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getAllInboxMessages' and count(parameter)=0]"
			[Register ("getAllInboxMessages", "()Ljava/util/ArrayList;", "GetGetAllInboxMessagesHandler")]
			get {
				const string __id = "getAllInboxMessages.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.CTInboxMessage>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCTExperimentsListener;
#pragma warning disable 0169
		static Delegate GetGetCTExperimentsListenerHandler ()
		{
			if (cb_getCTExperimentsListener == null)
				cb_getCTExperimentsListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCTExperimentsListener);
			return cb_getCTExperimentsListener;
		}

		static IntPtr n_GetCTExperimentsListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CTExperimentsListener);
		}
#pragma warning restore 0169

		static Delegate cb_setCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_;
#pragma warning disable 0169
		static Delegate GetSetCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_Handler ()
		{
			if (cb_setCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_ == null)
				cb_setCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_);
			return cb_setCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_;
		}

		static void n_SetCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_experimentsListener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.ICTExperimentsListener experimentsListener = (global::Com.Clevertap.Android.Sdk.ICTExperimentsListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTExperimentsListener> (native_experimentsListener, JniHandleOwnership.DoNotTransfer);
			__this.CTExperimentsListener = experimentsListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.ICTExperimentsListener CTExperimentsListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getCTExperimentsListener' and count(parameter)=0]"
			[Register ("getCTExperimentsListener", "()Lcom/clevertap/android/sdk/CTExperimentsListener;", "GetGetCTExperimentsListenerHandler")]
			get {
				const string __id = "getCTExperimentsListener.()Lcom/clevertap/android/sdk/CTExperimentsListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTExperimentsListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setCTExperimentsListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTExperimentsListener']]"
			[Register ("setCTExperimentsListener", "(Lcom/clevertap/android/sdk/CTExperimentsListener;)V", "GetSetCTExperimentsListener_Lcom_clevertap_android_sdk_CTExperimentsListener_Handler")]
			set {
				const string __id = "setCTExperimentsListener.(Lcom/clevertap/android/sdk/CTExperimentsListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCTNotificationInboxListener;
#pragma warning disable 0169
		static Delegate GetGetCTNotificationInboxListenerHandler ()
		{
			if (cb_getCTNotificationInboxListener == null)
				cb_getCTNotificationInboxListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCTNotificationInboxListener);
			return cb_getCTNotificationInboxListener;
		}

		static IntPtr n_GetCTNotificationInboxListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CTNotificationInboxListener);
		}
#pragma warning restore 0169

		static Delegate cb_setCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_;
#pragma warning disable 0169
		static Delegate GetSetCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_Handler ()
		{
			if (cb_setCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_ == null)
				cb_setCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_);
			return cb_setCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_;
		}

		static void n_SetCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notificationInboxListener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.ICTInboxListener notificationInboxListener = (global::Com.Clevertap.Android.Sdk.ICTInboxListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTInboxListener> (native_notificationInboxListener, JniHandleOwnership.DoNotTransfer);
			__this.CTNotificationInboxListener = notificationInboxListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.ICTInboxListener CTNotificationInboxListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getCTNotificationInboxListener' and count(parameter)=0]"
			[Register ("getCTNotificationInboxListener", "()Lcom/clevertap/android/sdk/CTInboxListener;", "GetGetCTNotificationInboxListenerHandler")]
			get {
				const string __id = "getCTNotificationInboxListener.()Lcom/clevertap/android/sdk/CTInboxListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ICTInboxListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setCTNotificationInboxListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTInboxListener']]"
			[Register ("setCTNotificationInboxListener", "(Lcom/clevertap/android/sdk/CTInboxListener;)V", "GetSetCTNotificationInboxListener_Lcom_clevertap_android_sdk_CTInboxListener_Handler")]
			set {
				const string __id = "setCTNotificationInboxListener.(Lcom/clevertap/android/sdk/CTInboxListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCleverTapAttributionIdentifier;
#pragma warning disable 0169
		static Delegate GetGetCleverTapAttributionIdentifierHandler ()
		{
			if (cb_getCleverTapAttributionIdentifier == null)
				cb_getCleverTapAttributionIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCleverTapAttributionIdentifier);
			return cb_getCleverTapAttributionIdentifier;
		}

		static IntPtr n_GetCleverTapAttributionIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CleverTapAttributionIdentifier);
		}
#pragma warning restore 0169

		public virtual unsafe string CleverTapAttributionIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getCleverTapAttributionIdentifier' and count(parameter)=0]"
			[Register ("getCleverTapAttributionIdentifier", "()Ljava/lang/String;", "GetGetCleverTapAttributionIdentifierHandler")]
			get {
				const string __id = "getCleverTapAttributionIdentifier.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCleverTapID;
#pragma warning disable 0169
		static Delegate GetGetCleverTapIDHandler ()
		{
			if (cb_getCleverTapID == null)
				cb_getCleverTapID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCleverTapID);
			return cb_getCleverTapID;
		}

		static IntPtr n_GetCleverTapID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CleverTapID);
		}
#pragma warning restore 0169

		public virtual unsafe string CleverTapID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getCleverTapID' and count(parameter)=0]"
			[Register ("getCleverTapID", "()Ljava/lang/String;", "GetGetCleverTapIDHandler")]
			get {
				const string __id = "getCleverTapID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int DebugLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDebugLevel' and count(parameter)=0]"
			[Register ("getDebugLevel", "()I", "")]
			get {
				const string __id = "getDebugLevel.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDebugLevel", "(I)V", "")]
			set {
				const string __id = "setDebugLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceInfo;
#pragma warning disable 0169
		static Delegate GetGetDeviceInfoHandler ()
		{
			if (cb_getDeviceInfo == null)
				cb_getDeviceInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceInfo);
			return cb_getDeviceInfo;
		}

		static IntPtr n_GetDeviceInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.DeviceInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> DeviceInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDeviceInfo' and count(parameter)=0]"
			[Register ("getDeviceInfo", "()Ljava/util/Map;", "GetGetDeviceInfoHandler")]
			get {
				const string __id = "getDeviceInfo.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDevicePushTokenRefreshListener;
#pragma warning disable 0169
		static Delegate GetGetDevicePushTokenRefreshListenerHandler ()
		{
			if (cb_getDevicePushTokenRefreshListener == null)
				cb_getDevicePushTokenRefreshListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevicePushTokenRefreshListener);
			return cb_getDevicePushTokenRefreshListener;
		}

		static IntPtr n_GetDevicePushTokenRefreshListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DevicePushTokenRefreshListener);
		}
#pragma warning restore 0169

		static Delegate cb_setDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_;
#pragma warning disable 0169
		static Delegate GetSetDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_Handler ()
		{
			if (cb_setDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_ == null)
				cb_setDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_);
			return cb_setDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_;
		}

		static void n_SetDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenRefreshListener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener tokenRefreshListener = (global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener> (native_tokenRefreshListener, JniHandleOwnership.DoNotTransfer);
			__this.DevicePushTokenRefreshListener = tokenRefreshListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener DevicePushTokenRefreshListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDevicePushTokenRefreshListener' and count(parameter)=0]"
			[Register ("getDevicePushTokenRefreshListener", "()Lcom/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener;", "GetGetDevicePushTokenRefreshListenerHandler")]
			get {
				const string __id = "getDevicePushTokenRefreshListener.()Lcom/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setDevicePushTokenRefreshListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CleverTapAPI.DevicePushTokenRefreshListener']]"
			[Register ("setDevicePushTokenRefreshListener", "(Lcom/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener;)V", "GetSetDevicePushTokenRefreshListener_Lcom_clevertap_android_sdk_CleverTapAPI_DevicePushTokenRefreshListener_Handler")]
			set {
				const string __id = "setDevicePushTokenRefreshListener.(Lcom/clevertap/android/sdk/CleverTapAPI$DevicePushTokenRefreshListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHistory;
#pragma warning disable 0169
		static Delegate GetGetHistoryHandler ()
		{
			if (cb_getHistory == null)
				cb_getHistory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHistory);
			return cb_getHistory;
		}

		static IntPtr n_GetHistory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Clevertap.Android.Sdk.EventDetail>.ToLocalJniHandle (__this.History);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Clevertap.Android.Sdk.EventDetail> History {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getHistory' and count(parameter)=0]"
			[Register ("getHistory", "()Ljava/util/Map;", "GetGetHistoryHandler")]
			get {
				const string __id = "getHistory.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Com.Clevertap.Android.Sdk.EventDetail>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInAppNotificationListener;
#pragma warning disable 0169
		static Delegate GetGetInAppNotificationListenerHandler ()
		{
			if (cb_getInAppNotificationListener == null)
				cb_getInAppNotificationListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInAppNotificationListener);
			return cb_getInAppNotificationListener;
		}

		static IntPtr n_GetInAppNotificationListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InAppNotificationListener);
		}
#pragma warning restore 0169

		static Delegate cb_setInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_;
#pragma warning disable 0169
		static Delegate GetSetInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_Handler ()
		{
			if (cb_setInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_ == null)
				cb_setInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_);
			return cb_setInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_;
		}

		static void n_SetInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppNotificationListener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.IInAppNotificationListener inAppNotificationListener = (global::Com.Clevertap.Android.Sdk.IInAppNotificationListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener> (native_inAppNotificationListener, JniHandleOwnership.DoNotTransfer);
			__this.InAppNotificationListener = inAppNotificationListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.IInAppNotificationListener InAppNotificationListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getInAppNotificationListener' and count(parameter)=0]"
			[Register ("getInAppNotificationListener", "()Lcom/clevertap/android/sdk/InAppNotificationListener;", "GetGetInAppNotificationListenerHandler")]
			get {
				const string __id = "getInAppNotificationListener.()Lcom/clevertap/android/sdk/InAppNotificationListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setInAppNotificationListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.InAppNotificationListener']]"
			[Register ("setInAppNotificationListener", "(Lcom/clevertap/android/sdk/InAppNotificationListener;)V", "GetSetInAppNotificationListener_Lcom_clevertap_android_sdk_InAppNotificationListener_Handler")]
			set {
				const string __id = "setInAppNotificationListener.(Lcom/clevertap/android/sdk/InAppNotificationListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInboxMessageCount;
#pragma warning disable 0169
		static Delegate GetGetInboxMessageCountHandler ()
		{
			if (cb_getInboxMessageCount == null)
				cb_getInboxMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInboxMessageCount);
			return cb_getInboxMessageCount;
		}

		static int n_GetInboxMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InboxMessageCount;
		}
#pragma warning restore 0169

		public virtual unsafe int InboxMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getInboxMessageCount' and count(parameter)=0]"
			[Register ("getInboxMessageCount", "()I", "GetGetInboxMessageCountHandler")]
			get {
				const string __id = "getInboxMessageCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInboxMessageUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetInboxMessageUnreadCountHandler ()
		{
			if (cb_getInboxMessageUnreadCount == null)
				cb_getInboxMessageUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInboxMessageUnreadCount);
			return cb_getInboxMessageUnreadCount;
		}

		static int n_GetInboxMessageUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InboxMessageUnreadCount;
		}
#pragma warning restore 0169

		public virtual unsafe int InboxMessageUnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getInboxMessageUnreadCount' and count(parameter)=0]"
			[Register ("getInboxMessageUnreadCount", "()I", "GetGetInboxMessageUnreadCountHandler")]
			get {
				const string __id = "getInboxMessageUnreadCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			__this.Location = location;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				const string __id = "getLocation.()Landroid/location/Location;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
			set {
				const string __id = "setLocation.(Landroid/location/Location;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousVisitTime;
#pragma warning disable 0169
		static Delegate GetGetPreviousVisitTimeHandler ()
		{
			if (cb_getPreviousVisitTime == null)
				cb_getPreviousVisitTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreviousVisitTime);
			return cb_getPreviousVisitTime;
		}

		static int n_GetPreviousVisitTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousVisitTime;
		}
#pragma warning restore 0169

		public virtual unsafe int PreviousVisitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getPreviousVisitTime' and count(parameter)=0]"
			[Register ("getPreviousVisitTime", "()I", "GetGetPreviousVisitTimeHandler")]
			get {
				const string __id = "getPreviousVisitTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScreenCount;
#pragma warning disable 0169
		static Delegate GetGetScreenCountHandler ()
		{
			if (cb_getScreenCount == null)
				cb_getScreenCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScreenCount);
			return cb_getScreenCount;
		}

		static int n_GetScreenCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScreenCount;
		}
#pragma warning restore 0169

		public virtual unsafe int ScreenCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getScreenCount' and count(parameter)=0]"
			[Register ("getScreenCount", "()I", "GetGetScreenCountHandler")]
			get {
				const string __id = "getScreenCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSyncListener;
#pragma warning disable 0169
		static Delegate GetGetSyncListenerHandler ()
		{
			if (cb_getSyncListener == null)
				cb_getSyncListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSyncListener);
			return cb_getSyncListener;
		}

		static IntPtr n_GetSyncListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SyncListener);
		}
#pragma warning restore 0169

		static Delegate cb_setSyncListener_Lcom_clevertap_android_sdk_SyncListener_;
#pragma warning disable 0169
		static Delegate GetSetSyncListener_Lcom_clevertap_android_sdk_SyncListener_Handler ()
		{
			if (cb_setSyncListener_Lcom_clevertap_android_sdk_SyncListener_ == null)
				cb_setSyncListener_Lcom_clevertap_android_sdk_SyncListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSyncListener_Lcom_clevertap_android_sdk_SyncListener_);
			return cb_setSyncListener_Lcom_clevertap_android_sdk_SyncListener_;
		}

		static void n_SetSyncListener_Lcom_clevertap_android_sdk_SyncListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_syncListener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.ISyncListener syncListener = (global::Com.Clevertap.Android.Sdk.ISyncListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ISyncListener> (native_syncListener, JniHandleOwnership.DoNotTransfer);
			__this.SyncListener = syncListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.ISyncListener SyncListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getSyncListener' and count(parameter)=0]"
			[Register ("getSyncListener", "()Lcom/clevertap/android/sdk/SyncListener;", "GetGetSyncListenerHandler")]
			get {
				const string __id = "getSyncListener.()Lcom/clevertap/android/sdk/SyncListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.ISyncListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setSyncListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.SyncListener']]"
			[Register ("setSyncListener", "(Lcom/clevertap/android/sdk/SyncListener;)V", "GetSetSyncListener_Lcom_clevertap_android_sdk_SyncListener_Handler")]
			set {
				const string __id = "setSyncListener.(Lcom/clevertap/android/sdk/SyncListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeElapsed;
#pragma warning disable 0169
		static Delegate GetGetTimeElapsedHandler ()
		{
			if (cb_getTimeElapsed == null)
				cb_getTimeElapsed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeElapsed);
			return cb_getTimeElapsed;
		}

		static int n_GetTimeElapsed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeElapsed;
		}
#pragma warning restore 0169

		public virtual unsafe int TimeElapsed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getTimeElapsed' and count(parameter)=0]"
			[Register ("getTimeElapsed", "()I", "GetGetTimeElapsedHandler")]
			get {
				const string __id = "getTimeElapsed.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTotalVisits;
#pragma warning disable 0169
		static Delegate GetGetTotalVisitsHandler ()
		{
			if (cb_getTotalVisits == null)
				cb_getTotalVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalVisits);
			return cb_getTotalVisits;
		}

		static int n_GetTotalVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalVisits;
		}
#pragma warning restore 0169

		public virtual unsafe int TotalVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getTotalVisits' and count(parameter)=0]"
			[Register ("getTotalVisits", "()I", "GetGetTotalVisitsHandler")]
			get {
				const string __id = "getTotalVisits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUTMDetails;
#pragma warning disable 0169
		static Delegate GetGetUTMDetailsHandler ()
		{
			if (cb_getUTMDetails == null)
				cb_getUTMDetails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUTMDetails);
			return cb_getUTMDetails;
		}

		static IntPtr n_GetUTMDetails (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UTMDetails);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.UTMDetail UTMDetails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getUTMDetails' and count(parameter)=0]"
			[Register ("getUTMDetails", "()Lcom/clevertap/android/sdk/UTMDetail;", "GetGetUTMDetailsHandler")]
			get {
				const string __id = "getUTMDetails.()Lcom/clevertap/android/sdk/UTMDetail;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.UTMDetail> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadInboxMessages;
#pragma warning disable 0169
		static Delegate GetGetUnreadInboxMessagesHandler ()
		{
			if (cb_getUnreadInboxMessages == null)
				cb_getUnreadInboxMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnreadInboxMessages);
			return cb_getUnreadInboxMessages;
		}

		static IntPtr n_GetUnreadInboxMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.CTInboxMessage>.ToLocalJniHandle (__this.UnreadInboxMessages);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.CTInboxMessage> UnreadInboxMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getUnreadInboxMessages' and count(parameter)=0]"
			[Register ("getUnreadInboxMessages", "()Ljava/util/ArrayList;", "GetGetUnreadInboxMessagesHandler")]
			get {
				const string __id = "getUnreadInboxMessages.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.CTInboxMessage>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_ABExperimentsUpdated;
#pragma warning disable 0169
		static Delegate GetABExperimentsUpdatedHandler ()
		{
			if (cb_ABExperimentsUpdated == null)
				cb_ABExperimentsUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ABExperimentsUpdated);
			return cb_ABExperimentsUpdated;
		}

		static void n_ABExperimentsUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ABExperimentsUpdated ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='ABExperimentsUpdated' and count(parameter)=0]"
		[Register ("ABExperimentsUpdated", "()V", "GetABExperimentsUpdatedHandler")]
		public virtual unsafe void ABExperimentsUpdated ()
		{
			const string __id = "ABExperimentsUpdated.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_addMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddMultiValueForKey (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='addMultiValueForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMultiValueForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddMultiValueForKey (string key, string value)
		{
			const string __id = "addMultiValueForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_addMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetAddMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_Handler ()
		{
			if (cb_addMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ == null)
				cb_addMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_);
			return cb_addMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_;
		}

		static void n_AddMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.AddMultiValuesForKey (key, values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='addMultiValuesForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("addMultiValuesForKey", "(Ljava/lang/String;Ljava/util/ArrayList;)V", "GetAddMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void AddMultiValuesForKey (string key, global::System.Collections.Generic.IList<string> values)
		{
			const string __id = "addMultiValuesForKey.(Ljava/lang/String;Ljava/util/ArrayList;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='changeCredentials' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("changeCredentials", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void ChangeCredentials (string accountID, string token)
		{
			const string __id = "changeCredentials.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_accountID = JNIEnv.NewString (accountID);
			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_accountID);
				__args [1] = new JniArgumentValue (native_token);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountID);
				JNIEnv.DeleteLocalRef (native_token);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='changeCredentials' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("changeCredentials", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void ChangeCredentials (string accountID, string token, string region)
		{
			const string __id = "changeCredentials.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_accountID = JNIEnv.NewString (accountID);
			IntPtr native_token = JNIEnv.NewString (token);
			IntPtr native_region = JNIEnv.NewString (region);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_accountID);
				__args [1] = new JniArgumentValue (native_token);
				__args [2] = new JniArgumentValue (native_region);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountID);
				JNIEnv.DeleteLocalRef (native_token);
				JNIEnv.DeleteLocalRef (native_region);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("createNotification", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public static unsafe void CreateNotification (global::Android.Content.Context context, global::Android.OS.Bundle extras)
		{
			const string __id = "createNotification.(Landroid/content/Context;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extras).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotification' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='int']]"
		[Register ("createNotification", "(Landroid/content/Context;Landroid/os/Bundle;I)V", "")]
		public static unsafe void CreateNotification (global::Android.Content.Context context, global::Android.OS.Bundle extras, int notificationId)
		{
			const string __id = "createNotification.(Landroid/content/Context;Landroid/os/Bundle;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extras).Handle);
				__args [2] = new JniArgumentValue (notificationId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotificationChannel' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register ("createNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;IZ)V", "")]
		public static unsafe void CreateNotificationChannel (global::Android.Content.Context context, string channelId, global::Java.Lang.ICharSequence channelName, string channelDescription, int importance, bool showBadge)
		{
			const string __id = "createNotificationChannel.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;IZ)V";
			IntPtr native_channelId = JNIEnv.NewString (channelId);
			IntPtr native_channelName = CharSequence.ToLocalJniHandle (channelName);
			IntPtr native_channelDescription = JNIEnv.NewString (channelDescription);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_channelId);
				__args [2] = new JniArgumentValue (native_channelName);
				__args [3] = new JniArgumentValue (native_channelDescription);
				__args [4] = new JniArgumentValue (importance);
				__args [5] = new JniArgumentValue (showBadge);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channelId);
				JNIEnv.DeleteLocalRef (native_channelName);
				JNIEnv.DeleteLocalRef (native_channelDescription);
			}
		}

		public static void CreateNotificationChannel (global::Android.Content.Context context, string channelId, string channelName, string channelDescription, int importance, bool showBadge)
		{
			global::Java.Lang.String jls_channelName = channelName == null ? null : new global::Java.Lang.String (channelName);
			CreateNotificationChannel (context, channelId, jls_channelName, channelDescription, importance, showBadge);
			jls_channelName?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotificationChannel' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='java.lang.String']]"
		[Register ("createNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;IZLjava/lang/String;)V", "")]
		public static unsafe void CreateNotificationChannel (global::Android.Content.Context context, string channelId, global::Java.Lang.ICharSequence channelName, string channelDescription, int importance, bool showBadge, string sound)
		{
			const string __id = "createNotificationChannel.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;IZLjava/lang/String;)V";
			IntPtr native_channelId = JNIEnv.NewString (channelId);
			IntPtr native_channelName = CharSequence.ToLocalJniHandle (channelName);
			IntPtr native_channelDescription = JNIEnv.NewString (channelDescription);
			IntPtr native_sound = JNIEnv.NewString (sound);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_channelId);
				__args [2] = new JniArgumentValue (native_channelName);
				__args [3] = new JniArgumentValue (native_channelDescription);
				__args [4] = new JniArgumentValue (importance);
				__args [5] = new JniArgumentValue (showBadge);
				__args [6] = new JniArgumentValue (native_sound);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channelId);
				JNIEnv.DeleteLocalRef (native_channelName);
				JNIEnv.DeleteLocalRef (native_channelDescription);
				JNIEnv.DeleteLocalRef (native_sound);
			}
		}

		public static void CreateNotificationChannel (global::Android.Content.Context context, string channelId, string channelName, string channelDescription, int importance, bool showBadge, string sound)
		{
			global::Java.Lang.String jls_channelName = channelName == null ? null : new global::Java.Lang.String (channelName);
			CreateNotificationChannel (context, channelId, jls_channelName, channelDescription, importance, showBadge, sound);
			jls_channelName?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotificationChannel' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='boolean']]"
		[Register ("createNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;ILjava/lang/String;Z)V", "")]
		public static unsafe void CreateNotificationChannel (global::Android.Content.Context context, string channelId, global::Java.Lang.ICharSequence channelName, string channelDescription, int importance, string groupId, bool showBadge)
		{
			const string __id = "createNotificationChannel.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;ILjava/lang/String;Z)V";
			IntPtr native_channelId = JNIEnv.NewString (channelId);
			IntPtr native_channelName = CharSequence.ToLocalJniHandle (channelName);
			IntPtr native_channelDescription = JNIEnv.NewString (channelDescription);
			IntPtr native_groupId = JNIEnv.NewString (groupId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_channelId);
				__args [2] = new JniArgumentValue (native_channelName);
				__args [3] = new JniArgumentValue (native_channelDescription);
				__args [4] = new JniArgumentValue (importance);
				__args [5] = new JniArgumentValue (native_groupId);
				__args [6] = new JniArgumentValue (showBadge);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channelId);
				JNIEnv.DeleteLocalRef (native_channelName);
				JNIEnv.DeleteLocalRef (native_channelDescription);
				JNIEnv.DeleteLocalRef (native_groupId);
			}
		}

		public static void CreateNotificationChannel (global::Android.Content.Context context, string channelId, string channelName, string channelDescription, int importance, string groupId, bool showBadge)
		{
			global::Java.Lang.String jls_channelName = channelName == null ? null : new global::Java.Lang.String (channelName);
			CreateNotificationChannel (context, channelId, jls_channelName, channelDescription, importance, groupId, showBadge);
			jls_channelName?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotificationChannel' and count(parameter)=8 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='boolean'] and parameter[8][@type='java.lang.String']]"
		[Register ("createNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;ILjava/lang/String;ZLjava/lang/String;)V", "")]
		public static unsafe void CreateNotificationChannel (global::Android.Content.Context context, string channelId, global::Java.Lang.ICharSequence channelName, string channelDescription, int importance, string groupId, bool showBadge, string sound)
		{
			const string __id = "createNotificationChannel.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;Ljava/lang/String;ILjava/lang/String;ZLjava/lang/String;)V";
			IntPtr native_channelId = JNIEnv.NewString (channelId);
			IntPtr native_channelName = CharSequence.ToLocalJniHandle (channelName);
			IntPtr native_channelDescription = JNIEnv.NewString (channelDescription);
			IntPtr native_groupId = JNIEnv.NewString (groupId);
			IntPtr native_sound = JNIEnv.NewString (sound);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_channelId);
				__args [2] = new JniArgumentValue (native_channelName);
				__args [3] = new JniArgumentValue (native_channelDescription);
				__args [4] = new JniArgumentValue (importance);
				__args [5] = new JniArgumentValue (native_groupId);
				__args [6] = new JniArgumentValue (showBadge);
				__args [7] = new JniArgumentValue (native_sound);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channelId);
				JNIEnv.DeleteLocalRef (native_channelName);
				JNIEnv.DeleteLocalRef (native_channelDescription);
				JNIEnv.DeleteLocalRef (native_groupId);
				JNIEnv.DeleteLocalRef (native_sound);
			}
		}

		public static void CreateNotificationChannel (global::Android.Content.Context context, string channelId, string channelName, string channelDescription, int importance, string groupId, bool showBadge, string sound)
		{
			global::Java.Lang.String jls_channelName = channelName == null ? null : new global::Java.Lang.String (channelName);
			CreateNotificationChannel (context, channelId, jls_channelName, channelDescription, importance, groupId, showBadge, sound);
			jls_channelName?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='createNotificationChannelGroup' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.CharSequence']]"
		[Register ("createNotificationChannelGroup", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;)V", "")]
		public static unsafe void CreateNotificationChannelGroup (global::Android.Content.Context context, string groupId, global::Java.Lang.ICharSequence groupName)
		{
			const string __id = "createNotificationChannelGroup.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/CharSequence;)V";
			IntPtr native_groupId = JNIEnv.NewString (groupId);
			IntPtr native_groupName = CharSequence.ToLocalJniHandle (groupName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_groupId);
				__args [2] = new JniArgumentValue (native_groupName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_groupId);
				JNIEnv.DeleteLocalRef (native_groupName);
			}
		}

		public static void CreateNotificationChannelGroup (global::Android.Content.Context context, string groupId, string groupName)
		{
			global::Java.Lang.String jls_groupName = groupName == null ? null : new global::Java.Lang.String (groupName);
			CreateNotificationChannelGroup (context, groupId, jls_groupName);
			jls_groupName?.Dispose ();
		}

		static Delegate cb_deleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_;
#pragma warning disable 0169
		static Delegate GetDeleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_Handler ()
		{
			if (cb_deleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_ == null)
				cb_deleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_);
			return cb_deleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_;
		}

		static void n_DeleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInboxMessage message = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.DeleteInboxMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='deleteInboxMessage' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTInboxMessage']]"
		[Register ("deleteInboxMessage", "(Lcom/clevertap/android/sdk/CTInboxMessage;)V", "GetDeleteInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_Handler")]
		public virtual unsafe void DeleteInboxMessage (global::Com.Clevertap.Android.Sdk.CTInboxMessage message)
		{
			const string __id = "deleteInboxMessage.(Lcom/clevertap/android/sdk/CTInboxMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='deleteNotificationChannel' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteNotificationChannel", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DeleteNotificationChannel (global::Android.Content.Context context, string channelId)
		{
			const string __id = "deleteNotificationChannel.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_channelId = JNIEnv.NewString (channelId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_channelId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_channelId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='deleteNotificationChannelGroup' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteNotificationChannelGroup", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void DeleteNotificationChannelGroup (global::Android.Content.Context context, string groupId)
		{
			const string __id = "deleteNotificationChannelGroup.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_groupId = JNIEnv.NewString (groupId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_groupId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_groupId);
			}
		}

		static Delegate cb_disablePersonalization;
#pragma warning disable 0169
		static Delegate GetDisablePersonalizationHandler ()
		{
			if (cb_disablePersonalization == null)
				cb_disablePersonalization = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisablePersonalization);
			return cb_disablePersonalization;
		}

		static void n_DisablePersonalization (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisablePersonalization ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='disablePersonalization' and count(parameter)=0]"
		[Register ("disablePersonalization", "()V", "GetDisablePersonalizationHandler")]
		public virtual unsafe void DisablePersonalization ()
		{
			const string __id = "disablePersonalization.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enableDeviceNetworkInfoReporting_Z;
#pragma warning disable 0169
		static Delegate GetEnableDeviceNetworkInfoReporting_ZHandler ()
		{
			if (cb_enableDeviceNetworkInfoReporting_Z == null)
				cb_enableDeviceNetworkInfoReporting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableDeviceNetworkInfoReporting_Z);
			return cb_enableDeviceNetworkInfoReporting_Z;
		}

		static void n_EnableDeviceNetworkInfoReporting_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDeviceNetworkInfoReporting (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='enableDeviceNetworkInfoReporting' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableDeviceNetworkInfoReporting", "(Z)V", "GetEnableDeviceNetworkInfoReporting_ZHandler")]
		public virtual unsafe void EnableDeviceNetworkInfoReporting (bool value)
		{
			const string __id = "enableDeviceNetworkInfoReporting.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_enablePersonalization;
#pragma warning disable 0169
		static Delegate GetEnablePersonalizationHandler ()
		{
			if (cb_enablePersonalization == null)
				cb_enablePersonalization = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnablePersonalization);
			return cb_enablePersonalization;
		}

		static void n_EnablePersonalization (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnablePersonalization ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='enablePersonalization' and count(parameter)=0]"
		[Register ("enablePersonalization", "()V", "GetEnablePersonalizationHandler")]
		public virtual unsafe void EnablePersonalization ()
		{
			const string __id = "enablePersonalization.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetGetBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_Handler ()
		{
			if (cb_getBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_ == null)
				cb_getBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_);
			return cb_getBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_;
		}

		static IntPtr n_GetBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBooleanVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getBooleanVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("getBooleanVariable", "(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;", "GetGetBooleanVariable_Ljava_lang_String_Ljava_lang_Boolean_Handler")]
		public virtual unsafe global::Java.Lang.Boolean GetBooleanVariable (string name, global::Java.Lang.Boolean defaultValue)
		{
			const string __id = "getBooleanVariable.(Ljava/lang/String;Ljava/lang/Boolean;)Ljava/lang/Boolean;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((defaultValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultValue).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCount_Ljava_lang_String_Handler ()
		{
			if (cb_getCount_Ljava_lang_String_ == null)
				cb_getCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetCount_Ljava_lang_String_);
			return cb_getCount_Ljava_lang_String_;
		}

		static int n_GetCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string e = JNIEnv.GetString (native_e, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetCount (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCount", "(Ljava/lang/String;)I", "GetGetCount_Ljava_lang_String_Handler")]
		public virtual unsafe int GetCount (string e)
		{
			const string __id = "getCount.(Ljava/lang/String;)I";
			IntPtr native_e = JNIEnv.NewString (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDefaultInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDefaultInstance", "(Landroid/content/Context;)Lcom/clevertap/android/sdk/CleverTapAPI;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI GetDefaultInstance (global::Android.Content.Context context)
		{
			const string __id = "getDefaultInstance.(Landroid/content/Context;)Lcom/clevertap/android/sdk/CleverTapAPI;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDefaultInstance' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDefaultInstance", "(Landroid/content/Context;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapAPI;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI GetDefaultInstance (global::Android.Content.Context context, string cleverTapID)
		{
			const string __id = "getDefaultInstance.(Landroid/content/Context;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapAPI;";
			IntPtr native_cleverTapID = JNIEnv.NewString (cleverTapID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_cleverTapID);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cleverTapID);
			}
		}

		static Delegate cb_getDetails_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDetails_Ljava_lang_String_Handler ()
		{
			if (cb_getDetails_Ljava_lang_String_ == null)
				cb_getDetails_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDetails_Ljava_lang_String_);
			return cb_getDetails_Ljava_lang_String_;
		}

		static IntPtr n_GetDetails_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string e = JNIEnv.GetString (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDetails (e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDetails' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDetails", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/EventDetail;", "GetGetDetails_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.EventDetail GetDetails (string e)
		{
			const string __id = "getDetails.(Ljava/lang/String;)Lcom/clevertap/android/sdk/EventDetail;";
			IntPtr native_e = JNIEnv.NewString (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.EventDetail> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_getDevicePushToken_Lcom_clevertap_android_sdk_PushType_;
#pragma warning disable 0169
		static Delegate GetGetDevicePushToken_Lcom_clevertap_android_sdk_PushType_Handler ()
		{
			if (cb_getDevicePushToken_Lcom_clevertap_android_sdk_PushType_ == null)
				cb_getDevicePushToken_Lcom_clevertap_android_sdk_PushType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDevicePushToken_Lcom_clevertap_android_sdk_PushType_);
			return cb_getDevicePushToken_Lcom_clevertap_android_sdk_PushType_;
		}

		static IntPtr n_GetDevicePushToken_Lcom_clevertap_android_sdk_PushType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.PushType type = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.PushType> (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDevicePushToken (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDevicePushToken' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.PushType']]"
		[Register ("getDevicePushToken", "(Lcom/clevertap/android/sdk/PushType;)Ljava/lang/String;", "GetGetDevicePushToken_Lcom_clevertap_android_sdk_PushType_Handler")]
		public virtual unsafe string GetDevicePushToken (global::Com.Clevertap.Android.Sdk.PushType type)
		{
			const string __id = "getDevicePushToken.(Lcom/clevertap/android/sdk/PushType;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDoubleVariable_Ljava_lang_String_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetGetDoubleVariable_Ljava_lang_String_Ljava_lang_Double_Handler ()
		{
			if (cb_getDoubleVariable_Ljava_lang_String_Ljava_lang_Double_ == null)
				cb_getDoubleVariable_Ljava_lang_String_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDoubleVariable_Ljava_lang_String_Ljava_lang_Double_);
			return cb_getDoubleVariable_Ljava_lang_String_Ljava_lang_Double_;
		}

		static IntPtr n_GetDoubleVariable_Ljava_lang_String_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDoubleVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getDoubleVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Double']]"
		[Register ("getDoubleVariable", "(Ljava/lang/String;Ljava/lang/Double;)Ljava/lang/Double;", "GetGetDoubleVariable_Ljava_lang_String_Ljava_lang_Double_Handler")]
		public virtual unsafe global::Java.Lang.Double GetDoubleVariable (string name, global::Java.Lang.Double defaultValue)
		{
			const string __id = "getDoubleVariable.(Ljava/lang/String;Ljava/lang/Double;)Ljava/lang/Double;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((defaultValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultValue).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getFirstTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFirstTime_Ljava_lang_String_Handler ()
		{
			if (cb_getFirstTime_Ljava_lang_String_ == null)
				cb_getFirstTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetFirstTime_Ljava_lang_String_);
			return cb_getFirstTime_Ljava_lang_String_;
		}

		static int n_GetFirstTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string e = JNIEnv.GetString (native_e, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetFirstTime (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getFirstTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFirstTime", "(Ljava/lang/String;)I", "GetGetFirstTime_Ljava_lang_String_Handler")]
		public virtual unsafe int GetFirstTime (string e)
		{
			const string __id = "getFirstTime.(Ljava/lang/String;)I";
			IntPtr native_e = JNIEnv.NewString (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_getInboxMessageForId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInboxMessageForId_Ljava_lang_String_Handler ()
		{
			if (cb_getInboxMessageForId_Ljava_lang_String_ == null)
				cb_getInboxMessageForId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInboxMessageForId_Ljava_lang_String_);
			return cb_getInboxMessageForId_Ljava_lang_String_;
		}

		static IntPtr n_GetInboxMessageForId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_messageId)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string messageId = JNIEnv.GetString (native_messageId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInboxMessageForId (messageId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getInboxMessageForId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInboxMessageForId", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/CTInboxMessage;", "GetGetInboxMessageForId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Clevertap.Android.Sdk.CTInboxMessage GetInboxMessageForId (string messageId)
		{
			const string __id = "getInboxMessageForId.(Ljava/lang/String;)Lcom/clevertap/android/sdk/CTInboxMessage;";
			IntPtr native_messageId = JNIEnv.NewString (messageId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_messageId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_messageId);
			}
		}

		static Delegate cb_getIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_getIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_getIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_getIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static IntPtr n_GetIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIntegerVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getIntegerVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("getIntegerVariable", "(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;", "GetGetIntegerVariable_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Java.Lang.Integer GetIntegerVariable (string name, global::Java.Lang.Integer defaultValue)
		{
			const string __id = "getIntegerVariable.(Ljava/lang/String;Ljava/lang/Integer;)Ljava/lang/Integer;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((defaultValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultValue).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getLastTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLastTime_Ljava_lang_String_Handler ()
		{
			if (cb_getLastTime_Ljava_lang_String_ == null)
				cb_getLastTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetLastTime_Ljava_lang_String_);
			return cb_getLastTime_Ljava_lang_String_;
		}

		static int n_GetLastTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string e = JNIEnv.GetString (native_e, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetLastTime (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getLastTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastTime", "(Ljava/lang/String;)I", "GetGetLastTime_Ljava_lang_String_Handler")]
		public virtual unsafe int GetLastTime (string e)
		{
			const string __id = "getLastTime.(Ljava/lang/String;)I";
			IntPtr native_e = JNIEnv.NewString (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_getListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_);
			return cb_getListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.ToLocalJniHandle (__this.GetListOfBooleanVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getListOfBooleanVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Boolean&gt;']]"
		[Register ("getListOfBooleanVariable", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetListOfBooleanVariable_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Boolean> GetListOfBooleanVariable (string name, global::System.Collections.Generic.IList<global::Java.Lang.Boolean> defaultValue)
		{
			const string __id = "getListOfBooleanVariable.(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_);
			return cb_getListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (__this.GetListOfDoubleVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getListOfDoubleVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Double&gt;']]"
		[Register ("getListOfDoubleVariable", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetListOfDoubleVariable_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Double> GetListOfDoubleVariable (string name, global::System.Collections.Generic.IList<global::Java.Lang.Double> defaultValue)
		{
			const string __id = "getListOfDoubleVariable.(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_);
			return cb_getListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.GetListOfIntegerVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getListOfIntegerVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("getListOfIntegerVariable", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetListOfIntegerVariable_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> GetListOfIntegerVariable (string name, global::System.Collections.Generic.IList<global::Java.Lang.Integer> defaultValue)
		{
			const string __id = "getListOfIntegerVariable.(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getListOfStringVariable_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetListOfStringVariable_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_getListOfStringVariable_Ljava_lang_String_Ljava_util_List_ == null)
				cb_getListOfStringVariable_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListOfStringVariable_Ljava_lang_String_Ljava_util_List_);
			return cb_getListOfStringVariable_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_GetListOfStringVariable_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<string>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetListOfStringVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getListOfStringVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getListOfStringVariable", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "GetGetListOfStringVariable_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetListOfStringVariable (string name, global::System.Collections.Generic.IList<string> defaultValue)
		{
			const string __id = "getListOfStringVariable.(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_getMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_getMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_);
			return cb_getMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_GetMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.GetMapOfBooleanVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getMapOfBooleanVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Boolean&gt;']]"
		[Register ("getMapOfBooleanVariable", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;", "GetGetMapOfBooleanVariable_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> GetMapOfBooleanVariable (string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> defaultValue)
		{
			const string __id = "getMapOfBooleanVariable.(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_getMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_getMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_);
			return cb_getMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_GetMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.ToLocalJniHandle (__this.GetMapOfDoubleVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getMapOfDoubleVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Double&gt;']]"
		[Register ("getMapOfDoubleVariable", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;", "GetGetMapOfDoubleVariable_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> GetMapOfDoubleVariable (string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Double> defaultValue)
		{
			const string __id = "getMapOfDoubleVariable.(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_getMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_getMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_);
			return cb_getMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_GetMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (__this.GetMapOfIntegerVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getMapOfIntegerVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("getMapOfIntegerVariable", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;", "GetGetMapOfIntegerVariable_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> GetMapOfIntegerVariable (string name, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> defaultValue)
		{
			const string __id = "getMapOfIntegerVariable.(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_getMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_getMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_getMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_);
			return cb_getMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_GetMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetMapOfStringVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getMapOfStringVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getMapOfStringVariable", "(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;", "GetGetMapOfStringVariable_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapOfStringVariable (string name, global::System.Collections.Generic.IDictionary<string, string> defaultValue)
		{
			const string __id = "getMapOfStringVariable.(Ljava/lang/String;Ljava/util/Map;)Ljava/util/Map;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getNotificationInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getNotificationInfo", "(Landroid/os/Bundle;)Lcom/clevertap/android/sdk/NotificationInfo;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.NotificationInfo GetNotificationInfo (global::Android.OS.Bundle extras)
		{
			const string __id = "getNotificationInfo.(Landroid/os/Bundle;)Lcom/clevertap/android/sdk/NotificationInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extras).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.NotificationInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getProperty_Ljava_lang_String_ == null)
				cb_getProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProperty_Ljava_lang_String_);
			return cb_getProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProperty (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetProperty_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetProperty (string name)
		{
			const string __id = "getProperty.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getStringVariable_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringVariable_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getStringVariable_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getStringVariable_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringVariable_Ljava_lang_String_Ljava_lang_String_);
			return cb_getStringVariable_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetStringVariable_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_defaultValue)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string defaultValue = JNIEnv.GetString (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='getStringVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringVariable", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetStringVariable_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetStringVariable (string name, string defaultValue)
		{
			const string __id = "getStringVariable.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_defaultValue = JNIEnv.NewString (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		static Delegate cb_inAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetInAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_Handler ()
		{
			if (cb_inAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ == null)
				cb_inAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_);
			return cb_inAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_;
		}

		static void n_InAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_inAppNotification, IntPtr native_formData, IntPtr native_keyValueMap)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_inAppNotification, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle formData = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_formData, JniHandleOwnership.DoNotTransfer);
			var keyValueMap = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_keyValueMap, JniHandleOwnership.DoNotTransfer);
			__this.InAppNotificationDidClick (context, inAppNotification, formData, keyValueMap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='inAppNotificationDidClick' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CTInAppNotification'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("inAppNotificationDidClick", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;Ljava/util/HashMap;)V", "GetInAppNotificationDidClick_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Ljava_util_HashMap_Handler")]
		public virtual unsafe void InAppNotificationDidClick (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification, global::Android.OS.Bundle formData, global::System.Collections.Generic.IDictionary<string, string> keyValueMap)
		{
			const string __id = "inAppNotificationDidClick.(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;Ljava/util/HashMap;)V";
			IntPtr native_keyValueMap = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (keyValueMap);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((inAppNotification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppNotification).Handle);
				__args [2] = new JniArgumentValue ((formData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formData).Handle);
				__args [3] = new JniArgumentValue (native_keyValueMap);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_keyValueMap);
			}
		}

		static Delegate cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetInAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler ()
		{
			if (cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ == null)
				cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_);
			return cb_inAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
		}

		static void n_InAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_inAppNotification, IntPtr native_formData)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_inAppNotification, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle formData = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_formData, JniHandleOwnership.DoNotTransfer);
			__this.InAppNotificationDidDismiss (context, inAppNotification, formData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='inAppNotificationDidDismiss' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CTInAppNotification'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("inAppNotificationDidDismiss", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V", "GetInAppNotificationDidDismiss_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler")]
		public virtual unsafe void InAppNotificationDidDismiss (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification, global::Android.OS.Bundle formData)
		{
			const string __id = "inAppNotificationDidDismiss.(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((inAppNotification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppNotification).Handle);
				__args [2] = new JniArgumentValue ((formData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_inAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetInAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler ()
		{
			if (cb_inAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ == null)
				cb_inAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_);
			return cb_inAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_;
		}

		static void n_InAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_inAppNotification, IntPtr native_formData)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_inAppNotification, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle formData = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_formData, JniHandleOwnership.DoNotTransfer);
			__this.InAppNotificationDidShow (context, inAppNotification, formData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='inAppNotificationDidShow' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CTInAppNotification'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("inAppNotificationDidShow", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V", "GetInAppNotificationDidShow_Landroid_content_Context_Lcom_clevertap_android_sdk_CTInAppNotification_Landroid_os_Bundle_Handler")]
		public virtual unsafe void InAppNotificationDidShow (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification, global::Android.OS.Bundle formData)
		{
			const string __id = "inAppNotificationDidShow.(Landroid/content/Context;Lcom/clevertap/android/sdk/CTInAppNotification;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((inAppNotification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppNotification).Handle);
				__args [2] = new JniArgumentValue ((formData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initializeInbox;
#pragma warning disable 0169
		static Delegate GetInitializeInboxHandler ()
		{
			if (cb_initializeInbox == null)
				cb_initializeInbox = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitializeInbox);
			return cb_initializeInbox;
		}

		static void n_InitializeInbox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitializeInbox ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='initializeInbox' and count(parameter)=0]"
		[Register ("initializeInbox", "()V", "GetInitializeInboxHandler")]
		public virtual unsafe void InitializeInbox ()
		{
			const string __id = "initializeInbox.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='instanceWithConfig' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CleverTapInstanceConfig']]"
		[Register ("instanceWithConfig", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;)Lcom/clevertap/android/sdk/CleverTapAPI;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI InstanceWithConfig (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig config)
		{
			const string __id = "instanceWithConfig.(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;)Lcom/clevertap/android/sdk/CleverTapAPI;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='instanceWithConfig' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CleverTapInstanceConfig'] and parameter[3][@type='java.lang.String']]"
		[Register ("instanceWithConfig", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapAPI;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapAPI InstanceWithConfig (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig config, string cleverTapID)
		{
			const string __id = "instanceWithConfig.(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapAPI;";
			IntPtr native_cleverTapID = JNIEnv.NewString (cleverTapID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue (native_cleverTapID);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cleverTapID);
			}
		}

		static Delegate cb_markReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_;
#pragma warning disable 0169
		static Delegate GetMarkReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_Handler ()
		{
			if (cb_markReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_ == null)
				cb_markReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MarkReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_);
			return cb_markReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_;
		}

		static void n_MarkReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInboxMessage message = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.MarkReadInboxMessage (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='markReadInboxMessage' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTInboxMessage']]"
		[Register ("markReadInboxMessage", "(Lcom/clevertap/android/sdk/CTInboxMessage;)V", "GetMarkReadInboxMessage_Lcom_clevertap_android_sdk_CTInboxMessage_Handler")]
		public virtual unsafe void MarkReadInboxMessage (global::Com.Clevertap.Android.Sdk.CTInboxMessage message)
		{
			const string __id = "markReadInboxMessage.(Lcom/clevertap/android/sdk/CTInboxMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_;
#pragma warning disable 0169
		static Delegate GetNotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_Handler ()
		{
			if (cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ == null)
				cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_NotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_);
			return cb_notificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_;
		}

		static void n_NotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inAppNotification)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInAppNotification> (native_inAppNotification, JniHandleOwnership.DoNotTransfer);
			__this.NotificationReady (inAppNotification);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='notificationReady' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTInAppNotification']]"
		[Register ("notificationReady", "(Lcom/clevertap/android/sdk/CTInAppNotification;)V", "GetNotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_Handler")]
		public virtual unsafe void NotificationReady (global::Com.Clevertap.Android.Sdk.CTInAppNotification inAppNotification)
		{
			const string __id = "notificationReady.(Lcom/clevertap/android/sdk/CTInAppNotification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((inAppNotification == null) ? IntPtr.Zero : ((global::Java.Lang.Object) inAppNotification).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='onActivityPaused' and count(parameter)=0]"
		[Register ("onActivityPaused", "()V", "")]
		public static unsafe void OnActivityPaused ()
		{
			const string __id = "onActivityPaused.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnActivityResumed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityResumed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='onActivityResumed' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;Ljava/lang/String;)V", "")]
		public static unsafe void OnActivityResumed (global::Android.App.Activity activity, string cleverTapID)
		{
			const string __id = "onActivityResumed.(Landroid/app/Activity;Ljava/lang/String;)V";
			IntPtr native_cleverTapID = JNIEnv.NewString (cleverTapID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (native_cleverTapID);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cleverTapID);
			}
		}

		static Delegate cb_onUserLogin_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnUserLogin_Ljava_util_Map_Handler ()
		{
			if (cb_onUserLogin_Ljava_util_Map_ == null)
				cb_onUserLogin_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserLogin_Ljava_util_Map_);
			return cb_onUserLogin_Ljava_util_Map_;
		}

		static void n_OnUserLogin_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_profile)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var profile = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_profile, JniHandleOwnership.DoNotTransfer);
			__this.OnUserLogin (profile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='onUserLogin' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onUserLogin", "(Ljava/util/Map;)V", "GetOnUserLogin_Ljava_util_Map_Handler")]
		public virtual unsafe void OnUserLogin (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> profile)
		{
			const string __id = "onUserLogin.(Ljava/util/Map;)V";
			IntPtr native_profile = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (profile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_profile);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_profile);
			}
		}

		static Delegate cb_onUserLogin_Ljava_util_Map_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUserLogin_Ljava_util_Map_Ljava_lang_String_Handler ()
		{
			if (cb_onUserLogin_Ljava_util_Map_Ljava_lang_String_ == null)
				cb_onUserLogin_Ljava_util_Map_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUserLogin_Ljava_util_Map_Ljava_lang_String_);
			return cb_onUserLogin_Ljava_util_Map_Ljava_lang_String_;
		}

		static void n_OnUserLogin_Ljava_util_Map_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_profile, IntPtr native_cleverTapID)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var profile = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_profile, JniHandleOwnership.DoNotTransfer);
			string cleverTapID = JNIEnv.GetString (native_cleverTapID, JniHandleOwnership.DoNotTransfer);
			__this.OnUserLogin (profile, cleverTapID);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='onUserLogin' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("onUserLogin", "(Ljava/util/Map;Ljava/lang/String;)V", "GetOnUserLogin_Ljava_util_Map_Ljava_lang_String_Handler")]
		public virtual unsafe void OnUserLogin (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> profile, string cleverTapID)
		{
			const string __id = "onUserLogin.(Ljava/util/Map;Ljava/lang/String;)V";
			IntPtr native_profile = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (profile);
			IntPtr native_cleverTapID = JNIEnv.NewString (cleverTapID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_profile);
				__args [1] = new JniArgumentValue (native_cleverTapID);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_profile);
				JNIEnv.DeleteLocalRef (native_cleverTapID);
			}
		}

		static Delegate cb_pushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetPushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_Handler ()
		{
			if (cb_pushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_ == null)
				cb_pushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_);
			return cb_pushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_;
		}

		static void n_PushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chargeDetails, IntPtr native_items)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chargeDetails = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_chargeDetails, JniHandleOwnership.DoNotTransfer);
			var items = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.FromJniHandle (native_items, JniHandleOwnership.DoNotTransfer);
			__this.PushChargedEvent (chargeDetails, items);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushChargedEvent' and count(parameter)=2 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='java.util.ArrayList&lt;java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;&gt;']]"
		[Register ("pushChargedEvent", "(Ljava/util/HashMap;Ljava/util/ArrayList;)V", "GetPushChargedEvent_Ljava_util_HashMap_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void PushChargedEvent (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> chargeDetails, global::System.Collections.Generic.IList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>> items)
		{
			const string __id = "pushChargedEvent.(Ljava/util/HashMap;Ljava/util/ArrayList;)V";
			IntPtr native_chargeDetails = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (chargeDetails);
			IntPtr native_items = global::Android.Runtime.JavaList<global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>>.ToLocalJniHandle (items);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_chargeDetails);
				__args [1] = new JniArgumentValue (native_items);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_chargeDetails);
				JNIEnv.DeleteLocalRef (native_items);
			}
		}

		static Delegate cb_pushDeepLink_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetPushDeepLink_Landroid_net_Uri_Handler ()
		{
			if (cb_pushDeepLink_Landroid_net_Uri_ == null)
				cb_pushDeepLink_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushDeepLink_Landroid_net_Uri_);
			return cb_pushDeepLink_Landroid_net_Uri_;
		}

		static void n_PushDeepLink_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.PushDeepLink (uri);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushDeepLink' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("pushDeepLink", "(Landroid/net/Uri;)V", "GetPushDeepLink_Landroid_net_Uri_Handler")]
		public virtual unsafe void PushDeepLink (global::Android.Net.Uri uri)
		{
			const string __id = "pushDeepLink.(Landroid/net/Uri;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pushError_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPushError_Ljava_lang_String_IHandler ()
		{
			if (cb_pushError_Ljava_lang_String_I == null)
				cb_pushError_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PushError_Ljava_lang_String_I);
			return cb_pushError_Ljava_lang_String_I;
		}

		static void n_PushError_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_errorMessage, int errorCode)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string errorMessage = JNIEnv.GetString (native_errorMessage, JniHandleOwnership.DoNotTransfer);
			__this.PushError (errorMessage, errorCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("pushError", "(Ljava/lang/String;I)V", "GetPushError_Ljava_lang_String_IHandler")]
		public virtual unsafe void PushError (string errorMessage, int errorCode)
		{
			const string __id = "pushError.(Ljava/lang/String;I)V";
			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_errorMessage);
				__args [1] = new JniArgumentValue (errorCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		static Delegate cb_pushEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPushEvent_Ljava_lang_String_Handler ()
		{
			if (cb_pushEvent_Ljava_lang_String_ == null)
				cb_pushEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushEvent_Ljava_lang_String_);
			return cb_pushEvent_Ljava_lang_String_;
		}

		static void n_PushEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventName)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventName = JNIEnv.GetString (native_eventName, JniHandleOwnership.DoNotTransfer);
			__this.PushEvent (eventName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("pushEvent", "(Ljava/lang/String;)V", "GetPushEvent_Ljava_lang_String_Handler")]
		public virtual unsafe void PushEvent (string eventName)
		{
			const string __id = "pushEvent.(Ljava/lang/String;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
			}
		}

		static Delegate cb_pushEvent_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPushEvent_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_pushEvent_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_pushEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PushEvent_Ljava_lang_String_Ljava_util_Map_);
			return cb_pushEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_PushEvent_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventName, IntPtr native_eventActions)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventName = JNIEnv.GetString (native_eventName, JniHandleOwnership.DoNotTransfer);
			var eventActions = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_eventActions, JniHandleOwnership.DoNotTransfer);
			__this.PushEvent (eventName, eventActions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("pushEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetPushEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void PushEvent (string eventName, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> eventActions)
		{
			const string __id = "pushEvent.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native_eventActions = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (eventActions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native_eventActions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native_eventActions);
			}
		}

		static Delegate cb_pushFacebookUser_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetPushFacebookUser_Lorg_json_JSONObject_Handler ()
		{
			if (cb_pushFacebookUser_Lorg_json_JSONObject_ == null)
				cb_pushFacebookUser_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushFacebookUser_Lorg_json_JSONObject_);
			return cb_pushFacebookUser_Lorg_json_JSONObject_;
		}

		static void n_PushFacebookUser_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_graphUser)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject graphUser = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_graphUser, JniHandleOwnership.DoNotTransfer);
			__this.PushFacebookUser (graphUser);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushFacebookUser' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("pushFacebookUser", "(Lorg/json/JSONObject;)V", "GetPushFacebookUser_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void PushFacebookUser (global::Org.Json.JSONObject graphUser)
		{
			const string __id = "pushFacebookUser.(Lorg/json/JSONObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((graphUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) graphUser).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pushFcmRegistrationId_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPushFcmRegistrationId_Ljava_lang_String_ZHandler ()
		{
			if (cb_pushFcmRegistrationId_Ljava_lang_String_Z == null)
				cb_pushFcmRegistrationId_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PushFcmRegistrationId_Ljava_lang_String_Z);
			return cb_pushFcmRegistrationId_Ljava_lang_String_Z;
		}

		static void n_PushFcmRegistrationId_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_fcmId, bool register)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fcmId = JNIEnv.GetString (native_fcmId, JniHandleOwnership.DoNotTransfer);
			__this.PushFcmRegistrationId (fcmId, register);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushFcmRegistrationId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("pushFcmRegistrationId", "(Ljava/lang/String;Z)V", "GetPushFcmRegistrationId_Ljava_lang_String_ZHandler")]
		public virtual unsafe void PushFcmRegistrationId (string fcmId, bool register)
		{
			const string __id = "pushFcmRegistrationId.(Ljava/lang/String;Z)V";
			IntPtr native_fcmId = JNIEnv.NewString (fcmId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fcmId);
				__args [1] = new JniArgumentValue (register);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fcmId);
			}
		}

		static Delegate cb_pushInstallReferrer_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetPushInstallReferrer_Landroid_content_Intent_Handler ()
		{
			if (cb_pushInstallReferrer_Landroid_content_Intent_ == null)
				cb_pushInstallReferrer_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushInstallReferrer_Landroid_content_Intent_);
			return cb_pushInstallReferrer_Landroid_content_Intent_;
		}

		static void n_PushInstallReferrer_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.PushInstallReferrer (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushInstallReferrer' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("pushInstallReferrer", "(Landroid/content/Intent;)V", "GetPushInstallReferrer_Landroid_content_Intent_Handler")]
		public virtual unsafe void PushInstallReferrer (global::Android.Content.Intent intent)
		{
			const string __id = "pushInstallReferrer.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_pushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_pushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_pushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_medium, IntPtr native_campaign)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string source = JNIEnv.GetString (native_source, JniHandleOwnership.DoNotTransfer);
			string medium = JNIEnv.GetString (native_medium, JniHandleOwnership.DoNotTransfer);
			string campaign = JNIEnv.GetString (native_campaign, JniHandleOwnership.DoNotTransfer);
			__this.PushInstallReferrer (source, medium, campaign);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushInstallReferrer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("pushInstallReferrer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetPushInstallReferrer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PushInstallReferrer (string source, string medium, string campaign)
		{
			const string __id = "pushInstallReferrer.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_source = JNIEnv.NewString (source);
			IntPtr native_medium = JNIEnv.NewString (medium);
			IntPtr native_campaign = JNIEnv.NewString (campaign);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_source);
				__args [1] = new JniArgumentValue (native_medium);
				__args [2] = new JniArgumentValue (native_campaign);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_source);
				JNIEnv.DeleteLocalRef (native_medium);
				JNIEnv.DeleteLocalRef (native_campaign);
			}
		}

		static Delegate cb_pushNotificationClickedEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetPushNotificationClickedEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_pushNotificationClickedEvent_Landroid_os_Bundle_ == null)
				cb_pushNotificationClickedEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushNotificationClickedEvent_Landroid_os_Bundle_);
			return cb_pushNotificationClickedEvent_Landroid_os_Bundle_;
		}

		static void n_PushNotificationClickedEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle extras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_extras, JniHandleOwnership.DoNotTransfer);
			__this.PushNotificationClickedEvent (extras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushNotificationClickedEvent' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("pushNotificationClickedEvent", "(Landroid/os/Bundle;)V", "GetPushNotificationClickedEvent_Landroid_os_Bundle_Handler")]
		public virtual unsafe void PushNotificationClickedEvent (global::Android.OS.Bundle extras)
		{
			const string __id = "pushNotificationClickedEvent.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pushNotificationViewedEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetPushNotificationViewedEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_pushNotificationViewedEvent_Landroid_os_Bundle_ == null)
				cb_pushNotificationViewedEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushNotificationViewedEvent_Landroid_os_Bundle_);
			return cb_pushNotificationViewedEvent_Landroid_os_Bundle_;
		}

		static void n_PushNotificationViewedEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle extras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_extras, JniHandleOwnership.DoNotTransfer);
			__this.PushNotificationViewedEvent (extras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushNotificationViewedEvent' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("pushNotificationViewedEvent", "(Landroid/os/Bundle;)V", "GetPushNotificationViewedEvent_Landroid_os_Bundle_Handler")]
		public virtual unsafe void PushNotificationViewedEvent (global::Android.OS.Bundle extras)
		{
			const string __id = "pushNotificationViewedEvent.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pushProfile_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPushProfile_Ljava_util_Map_Handler ()
		{
			if (cb_pushProfile_Ljava_util_Map_ == null)
				cb_pushProfile_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushProfile_Ljava_util_Map_);
			return cb_pushProfile_Ljava_util_Map_;
		}

		static void n_PushProfile_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_profile)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var profile = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_profile, JniHandleOwnership.DoNotTransfer);
			__this.PushProfile (profile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='pushProfile' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("pushProfile", "(Ljava/util/Map;)V", "GetPushProfile_Ljava_util_Map_Handler")]
		public virtual unsafe void PushProfile (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> profile)
		{
			const string __id = "pushProfile.(Ljava/util/Map;)V";
			IntPtr native_profile = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (profile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_profile);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_profile);
			}
		}

		static Delegate cb_recordScreen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecordScreen_Ljava_lang_String_Handler ()
		{
			if (cb_recordScreen_Ljava_lang_String_ == null)
				cb_recordScreen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordScreen_Ljava_lang_String_);
			return cb_recordScreen_Ljava_lang_String_;
		}

		static void n_RecordScreen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_screenName)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string screenName = JNIEnv.GetString (native_screenName, JniHandleOwnership.DoNotTransfer);
			__this.RecordScreen (screenName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='recordScreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("recordScreen", "(Ljava/lang/String;)V", "GetRecordScreen_Ljava_lang_String_Handler")]
		public virtual unsafe void RecordScreen (string screenName)
		{
			const string __id = "recordScreen.(Ljava/lang/String;)V";
			IntPtr native_screenName = JNIEnv.NewString (screenName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_screenName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_screenName);
			}
		}

		static Delegate cb_registerBooleanVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterBooleanVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerBooleanVariable_Ljava_lang_String_ == null)
				cb_registerBooleanVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterBooleanVariable_Ljava_lang_String_);
			return cb_registerBooleanVariable_Ljava_lang_String_;
		}

		static void n_RegisterBooleanVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBooleanVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerBooleanVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerBooleanVariable", "(Ljava/lang/String;)V", "GetRegisterBooleanVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterBooleanVariable (string name)
		{
			const string __id = "registerBooleanVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerDoubleVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterDoubleVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerDoubleVariable_Ljava_lang_String_ == null)
				cb_registerDoubleVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterDoubleVariable_Ljava_lang_String_);
			return cb_registerDoubleVariable_Ljava_lang_String_;
		}

		static void n_RegisterDoubleVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDoubleVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerDoubleVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerDoubleVariable", "(Ljava/lang/String;)V", "GetRegisterDoubleVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterDoubleVariable (string name)
		{
			const string __id = "registerDoubleVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerIntegerVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterIntegerVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerIntegerVariable_Ljava_lang_String_ == null)
				cb_registerIntegerVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterIntegerVariable_Ljava_lang_String_);
			return cb_registerIntegerVariable_Ljava_lang_String_;
		}

		static void n_RegisterIntegerVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterIntegerVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerIntegerVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerIntegerVariable", "(Ljava/lang/String;)V", "GetRegisterIntegerVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterIntegerVariable (string name)
		{
			const string __id = "registerIntegerVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerListOfBooleanVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterListOfBooleanVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerListOfBooleanVariable_Ljava_lang_String_ == null)
				cb_registerListOfBooleanVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListOfBooleanVariable_Ljava_lang_String_);
			return cb_registerListOfBooleanVariable_Ljava_lang_String_;
		}

		static void n_RegisterListOfBooleanVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfBooleanVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerListOfBooleanVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerListOfBooleanVariable", "(Ljava/lang/String;)V", "GetRegisterListOfBooleanVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterListOfBooleanVariable (string name)
		{
			const string __id = "registerListOfBooleanVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerListOfDoubleVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterListOfDoubleVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerListOfDoubleVariable_Ljava_lang_String_ == null)
				cb_registerListOfDoubleVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListOfDoubleVariable_Ljava_lang_String_);
			return cb_registerListOfDoubleVariable_Ljava_lang_String_;
		}

		static void n_RegisterListOfDoubleVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfDoubleVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerListOfDoubleVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerListOfDoubleVariable", "(Ljava/lang/String;)V", "GetRegisterListOfDoubleVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterListOfDoubleVariable (string name)
		{
			const string __id = "registerListOfDoubleVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerListOfIntegerVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterListOfIntegerVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerListOfIntegerVariable_Ljava_lang_String_ == null)
				cb_registerListOfIntegerVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListOfIntegerVariable_Ljava_lang_String_);
			return cb_registerListOfIntegerVariable_Ljava_lang_String_;
		}

		static void n_RegisterListOfIntegerVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfIntegerVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerListOfIntegerVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerListOfIntegerVariable", "(Ljava/lang/String;)V", "GetRegisterListOfIntegerVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterListOfIntegerVariable (string name)
		{
			const string __id = "registerListOfIntegerVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerListOfStringVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterListOfStringVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerListOfStringVariable_Ljava_lang_String_ == null)
				cb_registerListOfStringVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterListOfStringVariable_Ljava_lang_String_);
			return cb_registerListOfStringVariable_Ljava_lang_String_;
		}

		static void n_RegisterListOfStringVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfStringVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerListOfStringVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerListOfStringVariable", "(Ljava/lang/String;)V", "GetRegisterListOfStringVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterListOfStringVariable (string name)
		{
			const string __id = "registerListOfStringVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerMapOfBooleanVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterMapOfBooleanVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerMapOfBooleanVariable_Ljava_lang_String_ == null)
				cb_registerMapOfBooleanVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterMapOfBooleanVariable_Ljava_lang_String_);
			return cb_registerMapOfBooleanVariable_Ljava_lang_String_;
		}

		static void n_RegisterMapOfBooleanVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfBooleanVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerMapOfBooleanVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerMapOfBooleanVariable", "(Ljava/lang/String;)V", "GetRegisterMapOfBooleanVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterMapOfBooleanVariable (string name)
		{
			const string __id = "registerMapOfBooleanVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerMapOfDoubleVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterMapOfDoubleVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerMapOfDoubleVariable_Ljava_lang_String_ == null)
				cb_registerMapOfDoubleVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterMapOfDoubleVariable_Ljava_lang_String_);
			return cb_registerMapOfDoubleVariable_Ljava_lang_String_;
		}

		static void n_RegisterMapOfDoubleVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfDoubleVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerMapOfDoubleVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerMapOfDoubleVariable", "(Ljava/lang/String;)V", "GetRegisterMapOfDoubleVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterMapOfDoubleVariable (string name)
		{
			const string __id = "registerMapOfDoubleVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerMapOfIntegerVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterMapOfIntegerVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerMapOfIntegerVariable_Ljava_lang_String_ == null)
				cb_registerMapOfIntegerVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterMapOfIntegerVariable_Ljava_lang_String_);
			return cb_registerMapOfIntegerVariable_Ljava_lang_String_;
		}

		static void n_RegisterMapOfIntegerVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfIntegerVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerMapOfIntegerVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerMapOfIntegerVariable", "(Ljava/lang/String;)V", "GetRegisterMapOfIntegerVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterMapOfIntegerVariable (string name)
		{
			const string __id = "registerMapOfIntegerVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerMapOfStringVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterMapOfStringVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerMapOfStringVariable_Ljava_lang_String_ == null)
				cb_registerMapOfStringVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterMapOfStringVariable_Ljava_lang_String_);
			return cb_registerMapOfStringVariable_Ljava_lang_String_;
		}

		static void n_RegisterMapOfStringVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfStringVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerMapOfStringVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerMapOfStringVariable", "(Ljava/lang/String;)V", "GetRegisterMapOfStringVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterMapOfStringVariable (string name)
		{
			const string __id = "registerMapOfStringVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_registerStringVariable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterStringVariable_Ljava_lang_String_Handler ()
		{
			if (cb_registerStringVariable_Ljava_lang_String_ == null)
				cb_registerStringVariable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterStringVariable_Ljava_lang_String_);
			return cb_registerStringVariable_Ljava_lang_String_;
		}

		static void n_RegisterStringVariable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterStringVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='registerStringVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerStringVariable", "(Ljava/lang/String;)V", "GetRegisterStringVariable_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterStringVariable (string name)
		{
			const string __id = "registerStringVariable.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMultiValueForKey_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultiValueForKey (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='removeMultiValueForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMultiValueForKey", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveMultiValueForKey_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMultiValueForKey (string key, string value)
		{
			const string __id = "removeMultiValueForKey.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetRemoveMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_Handler ()
		{
			if (cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ == null)
				cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_);
			return cb_removeMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_;
		}

		static void n_RemoveMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultiValuesForKey (key, values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='removeMultiValuesForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("removeMultiValuesForKey", "(Ljava/lang/String;Ljava/util/ArrayList;)V", "GetRemoveMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void RemoveMultiValuesForKey (string key, global::System.Collections.Generic.IList<string> values)
		{
			const string __id = "removeMultiValuesForKey.(Ljava/lang/String;Ljava/util/ArrayList;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		static Delegate cb_removeValueForKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveValueForKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeValueForKey_Ljava_lang_String_ == null)
				cb_removeValueForKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveValueForKey_Ljava_lang_String_);
			return cb_removeValueForKey_Ljava_lang_String_;
		}

		static void n_RemoveValueForKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.RemoveValueForKey (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='removeValueForKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeValueForKey", "(Ljava/lang/String;)V", "GetRemoveValueForKey_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveValueForKey (string key)
		{
			const string __id = "removeValueForKey.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setAppForeground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAppForeground", "(Z)V", "")]
		public static unsafe void SetAppForeground (bool appForeground)
		{
			const string __id = "setAppForeground.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (appForeground);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CleverTapAPI.LogLevel']]"
		[Register ("setDebugLevel", "(Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;)V", "")]
		public static unsafe void SetDebugLevel (global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel level)
		{
			const string __id = "setDebugLevel.(Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_;
#pragma warning disable 0169
		static Delegate GetSetInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_Handler ()
		{
			if (cb_setInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_ == null)
				cb_setInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_);
			return cb_setInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_;
		}

		static void n_SetInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener listener = (global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetInAppNotificationButtonListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setInAppNotificationButtonListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.InAppNotificationButtonListener']]"
		[Register ("setInAppNotificationButtonListener", "(Lcom/clevertap/android/sdk/InAppNotificationButtonListener;)V", "GetSetInAppNotificationButtonListener_Lcom_clevertap_android_sdk_InAppNotificationButtonListener_Handler")]
		public virtual unsafe void SetInAppNotificationButtonListener (global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener listener)
		{
			const string __id = "setInAppNotificationButtonListener.(Lcom/clevertap/android/sdk/InAppNotificationButtonListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_;
#pragma warning disable 0169
		static Delegate GetSetInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_Handler ()
		{
			if (cb_setInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_ == null)
				cb_setInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_);
			return cb_setInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_;
		}

		static void n_SetInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener listener = (global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetInboxMessageButtonListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setInboxMessageButtonListener' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.InboxMessageButtonListener']]"
		[Register ("setInboxMessageButtonListener", "(Lcom/clevertap/android/sdk/InboxMessageButtonListener;)V", "GetSetInboxMessageButtonListener_Lcom_clevertap_android_sdk_InboxMessageButtonListener_Handler")]
		public virtual unsafe void SetInboxMessageButtonListener (global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener listener)
		{
			const string __id = "setInboxMessageButtonListener.(Lcom/clevertap/android/sdk/InboxMessageButtonListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_setLibrary_Ljava_lang_String_ == null)
				cb_setLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLibrary_Ljava_lang_String_);
			return cb_setLibrary_Ljava_lang_String_;
		}

		static void n_SetLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_library)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string library = JNIEnv.GetString (native_library, JniHandleOwnership.DoNotTransfer);
			__this.SetLibrary (library);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLibrary", "(Ljava/lang/String;)V", "GetSetLibrary_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLibrary (string library)
		{
			const string __id = "setLibrary.(Ljava/lang/String;)V";
			IntPtr native_library = JNIEnv.NewString (library);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_library);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_library);
			}
		}

		static Delegate cb_setMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ == null)
				cb_setMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_);
			return cb_setMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_;
		}

		static void n_SetMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_values)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList<string>.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiValuesForKey (key, values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setMultiValuesForKey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
		[Register ("setMultiValuesForKey", "(Ljava/lang/String;Ljava/util/ArrayList;)V", "GetSetMultiValuesForKey_Ljava_lang_String_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void SetMultiValuesForKey (string key, global::System.Collections.Generic.IList<string> values)
		{
			const string __id = "setMultiValuesForKey.(Ljava/lang/String;Ljava/util/ArrayList;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		static Delegate cb_setOffline_Z;
#pragma warning disable 0169
		static Delegate GetSetOffline_ZHandler ()
		{
			if (cb_setOffline_Z == null)
				cb_setOffline_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOffline_Z);
			return cb_setOffline_Z;
		}

		static void n_SetOffline_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffline (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setOffline' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOffline", "(Z)V", "GetSetOffline_ZHandler")]
		public virtual unsafe void SetOffline (bool value)
		{
			const string __id = "setOffline.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOptOut_Z;
#pragma warning disable 0169
		static Delegate GetSetOptOut_ZHandler ()
		{
			if (cb_setOptOut_Z == null)
				cb_setOptOut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOptOut_Z);
			return cb_setOptOut_Z;
		}

		static void n_SetOptOut_Z (IntPtr jnienv, IntPtr native__this, bool userOptOut)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOptOut (userOptOut);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setOptOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOptOut", "(Z)V", "GetSetOptOut_ZHandler")]
		public virtual unsafe void SetOptOut (bool userOptOut)
		{
			const string __id = "setOptOut.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (userOptOut);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='setUIEditorConnectionEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUIEditorConnectionEnabled", "(Z)V", "")]
		public static unsafe void SetUIEditorConnectionEnabled (bool enabled)
		{
			const string __id = "setUIEditorConnectionEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_showAppInbox;
#pragma warning disable 0169
		static Delegate GetShowAppInboxHandler ()
		{
			if (cb_showAppInbox == null)
				cb_showAppInbox = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowAppInbox);
			return cb_showAppInbox;
		}

		static void n_ShowAppInbox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAppInbox ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='showAppInbox' and count(parameter)=0]"
		[Register ("showAppInbox", "()V", "GetShowAppInboxHandler")]
		public virtual unsafe void ShowAppInbox ()
		{
			const string __id = "showAppInbox.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_showAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_;
#pragma warning disable 0169
		static Delegate GetShowAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_Handler ()
		{
			if (cb_showAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_ == null)
				cb_showAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_);
			return cb_showAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_;
		}

		static void n_ShowAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_styleConfig)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapAPI __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig styleConfig = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (native_styleConfig, JniHandleOwnership.DoNotTransfer);
			__this.ShowAppInbox (styleConfig);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapAPI']/method[@name='showAppInbox' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CTInboxStyleConfig']]"
		[Register ("showAppInbox", "(Lcom/clevertap/android/sdk/CTInboxStyleConfig;)V", "GetShowAppInbox_Lcom_clevertap_android_sdk_CTInboxStyleConfig_Handler")]
		public virtual unsafe void ShowAppInbox (global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig styleConfig)
		{
			const string __id = "showAppInbox.(Lcom/clevertap/android/sdk/CTInboxStyleConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((styleConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) styleConfig).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener"
		public event EventHandler<global::Com.Clevertap.Android.Sdk.InAppNotificationButtonEventArgs> InAppNotificationButton {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener, global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor>(
						ref weak_implementor_SetInAppNotificationButtonListener,
						__CreateIInAppNotificationButtonListenerImplementor,
						SetInAppNotificationButtonListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListener, global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor>(
						ref weak_implementor_SetInAppNotificationButtonListener,
						global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor.__IsEmpty,
						__v => SetInAppNotificationButtonListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetInAppNotificationButtonListener;

		global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor __CreateIInAppNotificationButtonListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Clevertap.Android.Sdk.IInboxMessageButtonListener"
		public event EventHandler<global::Com.Clevertap.Android.Sdk.InboxMessageButtonEventArgs> InboxMessageButton {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener, global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor>(
						ref weak_implementor_SetInboxMessageButtonListener,
						__CreateIInboxMessageButtonListenerImplementor,
						SetInboxMessageButtonListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListener, global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor>(
						ref weak_implementor_SetInboxMessageButtonListener,
						global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor.__IsEmpty,
						__v => SetInboxMessageButtonListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetInboxMessageButtonListener;

		global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor __CreateIInboxMessageButtonListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Clevertap.Android.Sdk.ICTExperimentsListener"
		public event EventHandler CTExperiments {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.ICTExperimentsListener, global::Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor>(
						ref weak_implementor___SetCTExperimentsListener,
						__CreateICTExperimentsListenerImplementor,
						__v => CTExperimentsListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.ICTExperimentsListener, global::Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor>(
						ref weak_implementor___SetCTExperimentsListener,
						global::Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor.__IsEmpty,
						__v => CTExperimentsListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetCTExperimentsListener;

		global::Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor __CreateICTExperimentsListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Clevertap.Android.Sdk.ICTInboxListener"
		public event EventHandler InboxDidInitialize {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.ICTInboxListener, global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor>(
						ref weak_implementor___SetCTNotificationInboxListener,
						__CreateICTInboxListenerImplementor,
						__v => CTNotificationInboxListener = __v,
						__h => __h.InboxDidInitializeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.ICTInboxListener, global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor>(
						ref weak_implementor___SetCTNotificationInboxListener,
						global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor.__IsEmpty,
						__v => CTNotificationInboxListener = null,
						__h => __h.InboxDidInitializeHandler -= value);
			}
		}

		public event EventHandler InboxMessagesDidUpdate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.ICTInboxListener, global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor>(
						ref weak_implementor___SetCTNotificationInboxListener,
						__CreateICTInboxListenerImplementor,
						__v => CTNotificationInboxListener = __v,
						__h => __h.InboxMessagesDidUpdateHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.ICTInboxListener, global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor>(
						ref weak_implementor___SetCTNotificationInboxListener,
						global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor.__IsEmpty,
						__v => CTNotificationInboxListener = null,
						__h => __h.InboxMessagesDidUpdateHandler -= value);
			}
		}

		WeakReference weak_implementor___SetCTNotificationInboxListener;

		global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor __CreateICTInboxListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener"
		public event EventHandler<global::Com.Clevertap.Android.Sdk.CleverTapAPI.DevicePushTokenRefreshEventArgs> DevicePushTokenRefresh {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener, global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListenerImplementor>(
						ref weak_implementor___SetDevicePushTokenRefreshListener,
						__CreateIDevicePushTokenRefreshListenerImplementor,
						__v => DevicePushTokenRefreshListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListener, global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListenerImplementor>(
						ref weak_implementor___SetDevicePushTokenRefreshListener,
						global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListenerImplementor.__IsEmpty,
						__v => DevicePushTokenRefreshListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetDevicePushTokenRefreshListener;

		global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListenerImplementor __CreateIDevicePushTokenRefreshListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.CleverTapAPI.IDevicePushTokenRefreshListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Clevertap.Android.Sdk.IInAppNotificationListener"
		public event EventHandler<global::Com.Clevertap.Android.Sdk.BeforeShowEventArgs> BeforeShow {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener, global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor>(
						ref weak_implementor___SetInAppNotificationListener,
						__CreateIInAppNotificationListenerImplementor,
						__v => InAppNotificationListener = __v,
						__h => __h.BeforeShowHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener, global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor>(
						ref weak_implementor___SetInAppNotificationListener,
						global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor.__IsEmpty,
						__v => InAppNotificationListener = null,
						__h => __h.BeforeShowHandler -= value);
			}
		}

		public event EventHandler<global::Com.Clevertap.Android.Sdk.DismissedEventArgs> Dismissed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener, global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor>(
						ref weak_implementor___SetInAppNotificationListener,
						__CreateIInAppNotificationListenerImplementor,
						__v => InAppNotificationListener = __v,
						__h => __h.OnDismissedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.IInAppNotificationListener, global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor>(
						ref weak_implementor___SetInAppNotificationListener,
						global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor.__IsEmpty,
						__v => InAppNotificationListener = null,
						__h => __h.OnDismissedHandler -= value);
			}
		}

		WeakReference weak_implementor___SetInAppNotificationListener;

		global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor __CreateIInAppNotificationListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Clevertap.Android.Sdk.ISyncListener"
		public event EventHandler<global::Com.Clevertap.Android.Sdk.ProfileDataUpdatedEventArgs> ProfileDataUpdated {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.ISyncListener, global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor>(
						ref weak_implementor___SetSyncListener,
						__CreateISyncListenerImplementor,
						__v => SyncListener = __v,
						__h => __h.ProfileDataUpdatedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.ISyncListener, global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor>(
						ref weak_implementor___SetSyncListener,
						global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor.__IsEmpty,
						__v => SyncListener = null,
						__h => __h.ProfileDataUpdatedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Clevertap.Android.Sdk.ProfileDidInitializeEventArgs> ProfileDidInitialize {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Clevertap.Android.Sdk.ISyncListener, global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor>(
						ref weak_implementor___SetSyncListener,
						__CreateISyncListenerImplementor,
						__v => SyncListener = __v,
						__h => __h.ProfileDidInitializeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Clevertap.Android.Sdk.ISyncListener, global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor>(
						ref weak_implementor___SetSyncListener,
						global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor.__IsEmpty,
						__v => SyncListener = null,
						__h => __h.ProfileDidInitializeHandler -= value);
			}
		}

		WeakReference weak_implementor___SetSyncListener;

		global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor __CreateISyncListenerImplementor ()
		{
			return new global::Com.Clevertap.Android.Sdk.ISyncListenerImplementor (this);
		}
#endregion
	}
}
