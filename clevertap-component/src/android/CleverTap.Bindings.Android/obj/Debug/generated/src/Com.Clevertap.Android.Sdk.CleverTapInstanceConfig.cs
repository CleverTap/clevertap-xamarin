using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CleverTapInstanceConfig", DoNotGenerateAcw=true)]
	public partial class CleverTapInstanceConfig : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CleverTapInstanceConfig", typeof (CleverTapInstanceConfig));
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

		protected CleverTapInstanceConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAccountId;
#pragma warning disable 0169
		static Delegate GetGetAccountIdHandler ()
		{
			if (cb_getAccountId == null)
				cb_getAccountId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountId);
			return cb_getAccountId;
		}

		static IntPtr n_GetAccountId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountId);
		}
#pragma warning restore 0169

		public virtual unsafe string AccountId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getAccountId' and count(parameter)=0]"
			[Register ("getAccountId", "()Ljava/lang/String;", "GetGetAccountIdHandler")]
			get {
				const string __id = "getAccountId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccountRegion;
#pragma warning disable 0169
		static Delegate GetGetAccountRegionHandler ()
		{
			if (cb_getAccountRegion == null)
				cb_getAccountRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountRegion);
			return cb_getAccountRegion;
		}

		static IntPtr n_GetAccountRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountRegion);
		}
#pragma warning restore 0169

		public virtual unsafe string AccountRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getAccountRegion' and count(parameter)=0]"
			[Register ("getAccountRegion", "()Ljava/lang/String;", "GetGetAccountRegionHandler")]
			get {
				const string __id = "getAccountRegion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAccountToken;
#pragma warning disable 0169
		static Delegate GetGetAccountTokenHandler ()
		{
			if (cb_getAccountToken == null)
				cb_getAccountToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccountToken);
			return cb_getAccountToken;
		}

		static IntPtr n_GetAccountToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccountToken);
		}
#pragma warning restore 0169

		public virtual unsafe string AccountToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getAccountToken' and count(parameter)=0]"
			[Register ("getAccountToken", "()Ljava/lang/String;", "GetGetAccountTokenHandler")]
			get {
				const string __id = "getAccountToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAnalyticsOnly;
#pragma warning disable 0169
		static Delegate GetIsAnalyticsOnlyHandler ()
		{
			if (cb_isAnalyticsOnly == null)
				cb_isAnalyticsOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnalyticsOnly);
			return cb_isAnalyticsOnly;
		}

		static bool n_IsAnalyticsOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnalyticsOnly;
		}
#pragma warning restore 0169

		static Delegate cb_setAnalyticsOnly_Z;
#pragma warning disable 0169
		static Delegate GetSetAnalyticsOnly_ZHandler ()
		{
			if (cb_setAnalyticsOnly_Z == null)
				cb_setAnalyticsOnly_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAnalyticsOnly_Z);
			return cb_setAnalyticsOnly_Z;
		}

		static void n_SetAnalyticsOnly_Z (IntPtr jnienv, IntPtr native__this, bool analyticsOnly)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnalyticsOnly = analyticsOnly;
		}
#pragma warning restore 0169

		public virtual unsafe bool AnalyticsOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='isAnalyticsOnly' and count(parameter)=0]"
			[Register ("isAnalyticsOnly", "()Z", "GetIsAnalyticsOnlyHandler")]
			get {
				const string __id = "isAnalyticsOnly.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='setAnalyticsOnly' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnalyticsOnly", "(Z)V", "GetSetAnalyticsOnly_ZHandler")]
			set {
				const string __id = "setAnalyticsOnly.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDebugLevel;
#pragma warning disable 0169
		static Delegate GetGetDebugLevelHandler ()
		{
			if (cb_getDebugLevel == null)
				cb_getDebugLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDebugLevel);
			return cb_getDebugLevel;
		}

		static int n_GetDebugLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DebugLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setDebugLevel_I;
#pragma warning disable 0169
		static Delegate GetSetDebugLevel_IHandler ()
		{
			if (cb_setDebugLevel_I == null)
				cb_setDebugLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDebugLevel_I);
			return cb_setDebugLevel_I;
		}

		static void n_SetDebugLevel_I (IntPtr jnienv, IntPtr native__this, int debugLevel)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DebugLevel = debugLevel;
		}
#pragma warning restore 0169

		public virtual unsafe int DebugLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getDebugLevel' and count(parameter)=0]"
			[Register ("getDebugLevel", "()I", "GetGetDebugLevelHandler")]
			get {
				const string __id = "getDebugLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDebugLevel", "(I)V", "GetSetDebugLevel_IHandler")]
			set {
				const string __id = "setDebugLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFcmSenderId;
#pragma warning disable 0169
		static Delegate GetGetFcmSenderIdHandler ()
		{
			if (cb_getFcmSenderId == null)
				cb_getFcmSenderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFcmSenderId);
			return cb_getFcmSenderId;
		}

		static IntPtr n_GetFcmSenderId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FcmSenderId);
		}
#pragma warning restore 0169

		public virtual unsafe string FcmSenderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getFcmSenderId' and count(parameter)=0]"
			[Register ("getFcmSenderId", "()Ljava/lang/String;", "GetGetFcmSenderIdHandler")]
			get {
				const string __id = "getFcmSenderId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isABTestingEnabled;
#pragma warning disable 0169
		static Delegate GetIsABTestingEnabledHandler ()
		{
			if (cb_isABTestingEnabled == null)
				cb_isABTestingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsABTestingEnabled);
			return cb_isABTestingEnabled;
		}

		static bool n_IsABTestingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsABTestingEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsABTestingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='isABTestingEnabled' and count(parameter)=0]"
			[Register ("isABTestingEnabled", "()Z", "GetIsABTestingEnabledHandler")]
			get {
				const string __id = "isABTestingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isBeta;
#pragma warning disable 0169
		static Delegate GetIsBetaHandler ()
		{
			if (cb_isBeta == null)
				cb_isBeta = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBeta);
			return cb_isBeta;
		}

		static bool n_IsBeta (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBeta;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBeta {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='isBeta' and count(parameter)=0]"
			[Register ("isBeta", "()Z", "GetIsBetaHandler")]
			get {
				const string __id = "isBeta.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUIEditorEnabled;
#pragma warning disable 0169
		static Delegate GetIsUIEditorEnabledHandler ()
		{
			if (cb_isUIEditorEnabled == null)
				cb_isUIEditorEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUIEditorEnabled);
			return cb_isUIEditorEnabled;
		}

		static bool n_IsUIEditorEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUIEditorEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUIEditorEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='isUIEditorEnabled' and count(parameter)=0]"
			[Register ("isUIEditorEnabled", "()Z", "GetIsUIEditorEnabledHandler")]
			get {
				const string __id = "isUIEditorEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLogger;
#pragma warning disable 0169
		static Delegate GetGetLoggerHandler ()
		{
			if (cb_getLogger == null)
				cb_getLogger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogger);
			return cb_getLogger;
		}

		static IntPtr n_GetLogger (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logger);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Logger Logger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getLogger' and count(parameter)=0]"
			[Register ("getLogger", "()Lcom/clevertap/android/sdk/Logger;", "GetGetLoggerHandler")]
			get {
				const string __id = "getLogger.()Lcom/clevertap/android/sdk/Logger;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='createDefaultInstance' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createDefaultInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;", "")]
		protected static unsafe global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig CreateDefaultInstance (global::Android.Content.Context context, string accountId, string accountToken, string accountRegion)
		{
			const string __id = "createDefaultInstance.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;";
			IntPtr native_accountId = JNIEnv.NewString (accountId);
			IntPtr native_accountToken = JNIEnv.NewString (accountToken);
			IntPtr native_accountRegion = JNIEnv.NewString (accountRegion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_accountId);
				__args [2] = new JniArgumentValue (native_accountToken);
				__args [3] = new JniArgumentValue (native_accountRegion);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountId);
				JNIEnv.DeleteLocalRef (native_accountToken);
				JNIEnv.DeleteLocalRef (native_accountRegion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='createInstance' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("createInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig CreateInstance (global::Android.Content.Context context, string accountId, string accountToken)
		{
			const string __id = "createInstance.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;";
			IntPtr native_accountId = JNIEnv.NewString (accountId);
			IntPtr native_accountToken = JNIEnv.NewString (accountToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_accountId);
				__args [2] = new JniArgumentValue (native_accountToken);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountId);
				JNIEnv.DeleteLocalRef (native_accountToken);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='createInstance' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("createInstance", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig CreateInstance (global::Android.Content.Context context, string accountId, string accountToken, string accountRegion)
		{
			const string __id = "createInstance.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;";
			IntPtr native_accountId = JNIEnv.NewString (accountId);
			IntPtr native_accountToken = JNIEnv.NewString (accountToken);
			IntPtr native_accountRegion = JNIEnv.NewString (accountRegion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_accountId);
				__args [2] = new JniArgumentValue (native_accountToken);
				__args [3] = new JniArgumentValue (native_accountRegion);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accountId);
				JNIEnv.DeleteLocalRef (native_accountToken);
				JNIEnv.DeleteLocalRef (native_accountRegion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='createInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createInstance", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;", "")]
		protected static unsafe global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig CreateInstance (string jsonString)
		{
			const string __id = "createInstance.(Ljava/lang/String;)Lcom/clevertap/android/sdk/CleverTapInstanceConfig;";
			IntPtr native_jsonString = JNIEnv.NewString (jsonString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_jsonString);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_jsonString);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enablePersonalization_Z;
#pragma warning disable 0169
		static Delegate GetEnablePersonalization_ZHandler ()
		{
			if (cb_enablePersonalization_Z == null)
				cb_enablePersonalization_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnablePersonalization_Z);
			return cb_enablePersonalization_Z;
		}

		static void n_EnablePersonalization_Z (IntPtr jnienv, IntPtr native__this, bool enablePersonalization)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnablePersonalization (enablePersonalization);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='enablePersonalization' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enablePersonalization", "(Z)V", "GetEnablePersonalization_ZHandler")]
		public virtual unsafe void EnablePersonalization (bool enablePersonalization)
		{
			const string __id = "enablePersonalization.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enablePersonalization);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBackgroundSync_Z;
#pragma warning disable 0169
		static Delegate GetSetBackgroundSync_ZHandler ()
		{
			if (cb_setBackgroundSync_Z == null)
				cb_setBackgroundSync_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBackgroundSync_Z);
			return cb_setBackgroundSync_Z;
		}

		static void n_SetBackgroundSync_Z (IntPtr jnienv, IntPtr native__this, bool backgroundSync)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundSync (backgroundSync);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='setBackgroundSync' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBackgroundSync", "(Z)V", "GetSetBackgroundSync_ZHandler")]
		public virtual unsafe void SetBackgroundSync (bool backgroundSync)
		{
			const string __id = "setBackgroundSync.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (backgroundSync);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_;
#pragma warning disable 0169
		static Delegate GetSetDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_Handler ()
		{
			if (cb_setDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_ == null)
				cb_setDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_);
			return cb_setDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_;
		}

		static void n_SetDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_debugLevel)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel debugLevel = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel> (native_debugLevel, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLevel (debugLevel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.CleverTapAPI.LogLevel']]"
		[Register ("setDebugLevel", "(Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;)V", "GetSetDebugLevel_Lcom_clevertap_android_sdk_CleverTapAPI_LogLevel_Handler")]
		public virtual unsafe void SetDebugLevel (global::Com.Clevertap.Android.Sdk.CleverTapAPI.LogLevel debugLevel)
		{
			const string __id = "setDebugLevel.(Lcom/clevertap/android/sdk/CleverTapAPI$LogLevel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((debugLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) debugLevel).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDisableAppLaunchedEvent_Z;
#pragma warning disable 0169
		static Delegate GetSetDisableAppLaunchedEvent_ZHandler ()
		{
			if (cb_setDisableAppLaunchedEvent_Z == null)
				cb_setDisableAppLaunchedEvent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisableAppLaunchedEvent_Z);
			return cb_setDisableAppLaunchedEvent_Z;
		}

		static void n_SetDisableAppLaunchedEvent_Z (IntPtr jnienv, IntPtr native__this, bool disableAppLaunchedEvent)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisableAppLaunchedEvent (disableAppLaunchedEvent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='setDisableAppLaunchedEvent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDisableAppLaunchedEvent", "(Z)V", "GetSetDisableAppLaunchedEvent_ZHandler")]
		public virtual unsafe void SetDisableAppLaunchedEvent (bool disableAppLaunchedEvent)
		{
			const string __id = "setDisableAppLaunchedEvent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (disableAppLaunchedEvent);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEnableCustomCleverTapId_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableCustomCleverTapId_ZHandler ()
		{
			if (cb_setEnableCustomCleverTapId_Z == null)
				cb_setEnableCustomCleverTapId_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnableCustomCleverTapId_Z);
			return cb_setEnableCustomCleverTapId_Z;
		}

		static void n_SetEnableCustomCleverTapId_Z (IntPtr jnienv, IntPtr native__this, bool enableCustomCleverTapId)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnableCustomCleverTapId (enableCustomCleverTapId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='setEnableCustomCleverTapId' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableCustomCleverTapId", "(Z)V", "GetSetEnableCustomCleverTapId_ZHandler")]
		public virtual unsafe void SetEnableCustomCleverTapId (bool enableCustomCleverTapId)
		{
			const string __id = "setEnableCustomCleverTapId.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enableCustomCleverTapId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_useGoogleAdId_Z;
#pragma warning disable 0169
		static Delegate GetUseGoogleAdId_ZHandler ()
		{
			if (cb_useGoogleAdId_Z == null)
				cb_useGoogleAdId_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_UseGoogleAdId_Z);
			return cb_useGoogleAdId_Z;
		}

		static void n_UseGoogleAdId_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseGoogleAdId (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='useGoogleAdId' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("useGoogleAdId", "(Z)V", "GetUseGoogleAdId_ZHandler")]
		public virtual unsafe void UseGoogleAdId (bool value)
		{
			const string __id = "useGoogleAdId.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CleverTapInstanceConfig']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
