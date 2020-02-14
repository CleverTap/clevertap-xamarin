using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Ab_testing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/CTABTestController", DoNotGenerateAcw=true)]
	public partial class CTABTestController : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController.LayoutErrorMessage']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/CTABTestController$LayoutErrorMessage", DoNotGenerateAcw=true)]
		public partial class LayoutErrorMessage : global::Java.Lang.Object {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/CTABTestController$LayoutErrorMessage", typeof (LayoutErrorMessage));
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

			protected LayoutErrorMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController.LayoutErrorMessage']/constructor[@name='CTABTestController.LayoutErrorMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe LayoutErrorMessage (string type, string name)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_type = JNIEnv.NewString (type);
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_type);
					__args [1] = new JniArgumentValue (native_name);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_type);
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController.LayoutErrorMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController.LayoutErrorMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController.LayoutErrorMessage']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController.LayoutErrorMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController.LayoutErrorMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Type);
			}
#pragma warning restore 0169

			public virtual unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController.LayoutErrorMessage']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/CTABTestController", typeof (CTABTestController));
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

		protected CTABTestController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/constructor[@name='CTABTestController' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.clevertap.android.sdk.CleverTapInstanceConfig'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.clevertap.android.sdk.ab_testing.CTABTestListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;Ljava/lang/String;Lcom/clevertap/android/sdk/ab_testing/CTABTestListener;)V", "")]
		public unsafe CTABTestController (global::Android.Content.Context context, global::Com.Clevertap.Android.Sdk.CleverTapInstanceConfig config, string guid, global::Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/clevertap/android/sdk/CleverTapInstanceConfig;Ljava/lang/String;Lcom/clevertap/android/sdk/ab_testing/CTABTestListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_guid = JNIEnv.NewString (guid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue (native_guid);
				__args [3] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_guid);
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBooleanVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getBooleanVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDoubleVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getDoubleVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Double']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer defaultValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIntegerVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getIntegerVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.ToLocalJniHandle (__this.GetListOfBooleanVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getListOfBooleanVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Boolean&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Double>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Double>.ToLocalJniHandle (__this.GetListOfDoubleVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getListOfDoubleVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Double&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.GetListOfIntegerVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getListOfIntegerVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaList<string>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetListOfStringVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getListOfStringVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.GetMapOfBooleanVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getMapOfBooleanVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Boolean&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Double>.ToLocalJniHandle (__this.GetMapOfDoubleVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getMapOfDoubleVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Double&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (__this.GetMapOfIntegerVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getMapOfIntegerVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var defaultValue = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetMapOfStringVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getMapOfStringVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string defaultValue = JNIEnv.GetString (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringVariable (name, defaultValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='getStringVariable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBooleanVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerBooleanVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterDoubleVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerDoubleVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterIntegerVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerIntegerVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfBooleanVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerListOfBooleanVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfDoubleVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerListOfDoubleVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfIntegerVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerListOfIntegerVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterListOfStringVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerListOfStringVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfBooleanVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerMapOfBooleanVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfDoubleVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerMapOfDoubleVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfIntegerVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerMapOfIntegerVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMapOfStringVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerMapOfStringVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.RegisterStringVariable (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='registerStringVariable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_resetWithGuid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResetWithGuid_Ljava_lang_String_Handler ()
		{
			if (cb_resetWithGuid_Ljava_lang_String_ == null)
				cb_resetWithGuid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResetWithGuid_Ljava_lang_String_);
			return cb_resetWithGuid_Ljava_lang_String_;
		}

		static void n_ResetWithGuid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_guid)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string guid = JNIEnv.GetString (native_guid, JniHandleOwnership.DoNotTransfer);
			__this.ResetWithGuid (guid);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='resetWithGuid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resetWithGuid", "(Ljava/lang/String;)V", "GetResetWithGuid_Ljava_lang_String_Handler")]
		public virtual unsafe void ResetWithGuid (string guid)
		{
			const string __id = "resetWithGuid.(Ljava/lang/String;)V";
			IntPtr native_guid = JNIEnv.NewString (guid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_guid);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_guid);
			}
		}

		static Delegate cb_updateExperiments_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetUpdateExperiments_Lorg_json_JSONArray_Handler ()
		{
			if (cb_updateExperiments_Lorg_json_JSONArray_ == null)
				cb_updateExperiments_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateExperiments_Lorg_json_JSONArray_);
			return cb_updateExperiments_Lorg_json_JSONArray_;
		}

		static void n_UpdateExperiments_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_experiments)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.CTABTestController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray experiments = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_experiments, JniHandleOwnership.DoNotTransfer);
			__this.UpdateExperiments (experiments);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing']/class[@name='CTABTestController']/method[@name='updateExperiments' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("updateExperiments", "(Lorg/json/JSONArray;)V", "GetUpdateExperiments_Lorg_json_JSONArray_Handler")]
		public virtual unsafe void UpdateExperiments (global::Org.Json.JSONArray experiments)
		{
			const string __id = "updateExperiments.(Lorg/json/JSONArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((experiments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) experiments).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
