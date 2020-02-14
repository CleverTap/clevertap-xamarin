using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Ab_testing.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/models/CTABVariant", DoNotGenerateAcw=true)]
	public partial class CTABVariant : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant.CTVariantAction']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/ab_testing/models/CTABVariant$CTVariantAction", DoNotGenerateAcw=true)]
		public sealed partial class CTVariantAction : global::Java.Lang.Object {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/models/CTABVariant$CTVariantAction", typeof (CTVariantAction));
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

			internal CTVariantAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe string ActivityName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant.CTVariantAction']/method[@name='getActivityName' and count(parameter)=0]"
				[Register ("getActivityName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getActivityName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Org.Json.JSONObject Change {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant.CTVariantAction']/method[@name='getChange' and count(parameter)=0]"
				[Register ("getChange", "()Lorg/json/JSONObject;", "")]
				get {
					const string __id = "getChange.()Lorg/json/JSONObject;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant.CTVariantAction']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/ab_testing/models/CTABVariant", typeof (CTABVariant));
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

		protected CTABVariant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getActions;
#pragma warning disable 0169
		static Delegate GetGetActionsHandler ()
		{
			if (cb_getActions == null)
				cb_getActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActions);
			return cb_getActions;
		}

		static IntPtr n_GetActions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant.CTVariantAction>.ToLocalJniHandle (__this.Actions);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant.CTVariantAction> Actions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='getActions' and count(parameter)=0]"
			[Register ("getActions", "()Ljava/util/ArrayList;", "GetGetActionsHandler")]
			get {
				const string __id = "getActions.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant.CTVariantAction>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVars;
#pragma warning disable 0169
		static Delegate GetGetVarsHandler ()
		{
			if (cb_getVars == null)
				cb_getVars = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVars);
			return cb_getVars;
		}

		static IntPtr n_GetVars (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Vars);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONArray Vars {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='getVars' and count(parameter)=0]"
			[Register ("getVars", "()Lorg/json/JSONArray;", "GetGetVarsHandler")]
			get {
				const string __id = "getVars.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addActions_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetAddActions_Lorg_json_JSONArray_Handler ()
		{
			if (cb_addActions_Lorg_json_JSONArray_ == null)
				cb_addActions_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddActions_Lorg_json_JSONArray_);
			return cb_addActions_Lorg_json_JSONArray_;
		}

		static void n_AddActions_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_actions)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray actions = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_actions, JniHandleOwnership.DoNotTransfer);
			__this.AddActions (actions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='addActions' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("addActions", "(Lorg/json/JSONArray;)V", "GetAddActions_Lorg_json_JSONArray_Handler")]
		public virtual unsafe void AddActions (global::Org.Json.JSONArray actions)
		{
			const string __id = "addActions.(Lorg/json/JSONArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((actions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) actions).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addImageUrls_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddImageUrls_Ljava_util_List_Handler ()
		{
			if (cb_addImageUrls_Ljava_util_List_ == null)
				cb_addImageUrls_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImageUrls_Ljava_util_List_);
			return cb_addImageUrls_Ljava_util_List_;
		}

		static void n_AddImageUrls_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_urls)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var urls = global::Android.Runtime.JavaList<string>.FromJniHandle (native_urls, JniHandleOwnership.DoNotTransfer);
			__this.AddImageUrls (urls);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='addImageUrls' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addImageUrls", "(Ljava/util/List;)V", "GetAddImageUrls_Ljava_util_List_Handler")]
		public virtual unsafe void AddImageUrls (global::System.Collections.Generic.IList<string> urls)
		{
			const string __id = "addImageUrls.(Ljava/util/List;)V";
			IntPtr native_urls = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (urls);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_urls);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_urls);
			}
		}

		static Delegate cb_cleanup;
#pragma warning disable 0169
		static Delegate GetCleanupHandler ()
		{
			if (cb_cleanup == null)
				cb_cleanup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cleanup);
			return cb_cleanup;
		}

		static void n_Cleanup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cleanup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='cleanup' and count(parameter)=0]"
		[Register ("cleanup", "()V", "GetCleanupHandler")]
		public virtual unsafe void Cleanup ()
		{
			const string __id = "cleanup.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearActions;
#pragma warning disable 0169
		static Delegate GetClearActionsHandler ()
		{
			if (cb_clearActions == null)
				cb_clearActions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearActions);
			return cb_clearActions;
		}

		static void n_ClearActions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearActions ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='clearActions' and count(parameter)=0]"
		[Register ("clearActions", "()V", "GetClearActionsHandler")]
		public virtual unsafe void ClearActions ()
		{
			const string __id = "clearActions.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='initWithJSON' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("initWithJSON", "(Lorg/json/JSONObject;)Lcom/clevertap/android/sdk/ab_testing/models/CTABVariant;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant InitWithJSON (global::Org.Json.JSONObject json)
		{
			const string __id = "initWithJSON.(Lorg/json/JSONObject;)Lcom/clevertap/android/sdk/ab_testing/models/CTABVariant;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((json == null) ? IntPtr.Zero : ((global::Java.Lang.Object) json).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeActionsByName_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetRemoveActionsByName_Lorg_json_JSONArray_Handler ()
		{
			if (cb_removeActionsByName_Lorg_json_JSONArray_ == null)
				cb_removeActionsByName_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveActionsByName_Lorg_json_JSONArray_);
			return cb_removeActionsByName_Lorg_json_JSONArray_;
		}

		static void n_RemoveActionsByName_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_names)
		{
			global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Ab_testing.Models.CTABVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray names = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_names, JniHandleOwnership.DoNotTransfer);
			__this.RemoveActionsByName (names);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.ab_testing.models']/class[@name='CTABVariant']/method[@name='removeActionsByName' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("removeActionsByName", "(Lorg/json/JSONArray;)V", "GetRemoveActionsByName_Lorg_json_JSONArray_Handler")]
		public virtual unsafe void RemoveActionsByName (global::Org.Json.JSONArray names)
		{
			const string __id = "removeActionsByName.(Lorg/json/JSONArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((names == null) ? IntPtr.Zero : ((global::Java.Lang.Object) names).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
