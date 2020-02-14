using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxStyleConfig", DoNotGenerateAcw=true)]
	public partial class CTInboxStyleConfig : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxStyleConfig", typeof (CTInboxStyleConfig));
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

		protected CTInboxStyleConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/constructor[@name='CTInboxStyleConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CTInboxStyleConfig ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/constructor[@name='CTInboxStyleConfig' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe CTInboxStyleConfig (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBackButtonColor;
#pragma warning disable 0169
		static Delegate GetGetBackButtonColorHandler ()
		{
			if (cb_getBackButtonColor == null)
				cb_getBackButtonColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackButtonColor);
			return cb_getBackButtonColor;
		}

		static IntPtr n_GetBackButtonColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackButtonColor);
		}
#pragma warning restore 0169

		static Delegate cb_setBackButtonColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackButtonColor_Ljava_lang_String_Handler ()
		{
			if (cb_setBackButtonColor_Ljava_lang_String_ == null)
				cb_setBackButtonColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackButtonColor_Ljava_lang_String_);
			return cb_setBackButtonColor_Ljava_lang_String_;
		}

		static void n_SetBackButtonColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_backButtonColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string backButtonColor = JNIEnv.GetString (native_backButtonColor, JniHandleOwnership.DoNotTransfer);
			__this.BackButtonColor = backButtonColor;
		}
#pragma warning restore 0169

		public virtual unsafe string BackButtonColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getBackButtonColor' and count(parameter)=0]"
			[Register ("getBackButtonColor", "()Ljava/lang/String;", "GetGetBackButtonColorHandler")]
			get {
				const string __id = "getBackButtonColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setBackButtonColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBackButtonColor", "(Ljava/lang/String;)V", "GetSetBackButtonColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBackButtonColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInboxBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetInboxBackgroundColorHandler ()
		{
			if (cb_getInboxBackgroundColor == null)
				cb_getInboxBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInboxBackgroundColor);
			return cb_getInboxBackgroundColor;
		}

		static IntPtr n_GetInboxBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InboxBackgroundColor);
		}
#pragma warning restore 0169

		static Delegate cb_setInboxBackgroundColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetInboxBackgroundColor_Ljava_lang_String_Handler ()
		{
			if (cb_setInboxBackgroundColor_Ljava_lang_String_ == null)
				cb_setInboxBackgroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInboxBackgroundColor_Ljava_lang_String_);
			return cb_setInboxBackgroundColor_Ljava_lang_String_;
		}

		static void n_SetInboxBackgroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inboxBackgroundColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string inboxBackgroundColor = JNIEnv.GetString (native_inboxBackgroundColor, JniHandleOwnership.DoNotTransfer);
			__this.InboxBackgroundColor = inboxBackgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe string InboxBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getInboxBackgroundColor' and count(parameter)=0]"
			[Register ("getInboxBackgroundColor", "()Ljava/lang/String;", "GetGetInboxBackgroundColorHandler")]
			get {
				const string __id = "getInboxBackgroundColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setInboxBackgroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInboxBackgroundColor", "(Ljava/lang/String;)V", "GetSetInboxBackgroundColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setInboxBackgroundColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNavBarColor;
#pragma warning disable 0169
		static Delegate GetGetNavBarColorHandler ()
		{
			if (cb_getNavBarColor == null)
				cb_getNavBarColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNavBarColor);
			return cb_getNavBarColor;
		}

		static IntPtr n_GetNavBarColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NavBarColor);
		}
#pragma warning restore 0169

		static Delegate cb_setNavBarColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNavBarColor_Ljava_lang_String_Handler ()
		{
			if (cb_setNavBarColor_Ljava_lang_String_ == null)
				cb_setNavBarColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNavBarColor_Ljava_lang_String_);
			return cb_setNavBarColor_Ljava_lang_String_;
		}

		static void n_SetNavBarColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_navBarColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string navBarColor = JNIEnv.GetString (native_navBarColor, JniHandleOwnership.DoNotTransfer);
			__this.NavBarColor = navBarColor;
		}
#pragma warning restore 0169

		public virtual unsafe string NavBarColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getNavBarColor' and count(parameter)=0]"
			[Register ("getNavBarColor", "()Ljava/lang/String;", "GetGetNavBarColorHandler")]
			get {
				const string __id = "getNavBarColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setNavBarColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNavBarColor", "(Ljava/lang/String;)V", "GetSetNavBarColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNavBarColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNavBarTitle;
#pragma warning disable 0169
		static Delegate GetGetNavBarTitleHandler ()
		{
			if (cb_getNavBarTitle == null)
				cb_getNavBarTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNavBarTitle);
			return cb_getNavBarTitle;
		}

		static IntPtr n_GetNavBarTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NavBarTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setNavBarTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNavBarTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setNavBarTitle_Ljava_lang_String_ == null)
				cb_setNavBarTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNavBarTitle_Ljava_lang_String_);
			return cb_setNavBarTitle_Ljava_lang_String_;
		}

		static void n_SetNavBarTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_navBarTitle)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string navBarTitle = JNIEnv.GetString (native_navBarTitle, JniHandleOwnership.DoNotTransfer);
			__this.NavBarTitle = navBarTitle;
		}
#pragma warning restore 0169

		public virtual unsafe string NavBarTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getNavBarTitle' and count(parameter)=0]"
			[Register ("getNavBarTitle", "()Ljava/lang/String;", "GetGetNavBarTitleHandler")]
			get {
				const string __id = "getNavBarTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setNavBarTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNavBarTitle", "(Ljava/lang/String;)V", "GetSetNavBarTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNavBarTitle.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNavBarTitleColor;
#pragma warning disable 0169
		static Delegate GetGetNavBarTitleColorHandler ()
		{
			if (cb_getNavBarTitleColor == null)
				cb_getNavBarTitleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNavBarTitleColor);
			return cb_getNavBarTitleColor;
		}

		static IntPtr n_GetNavBarTitleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NavBarTitleColor);
		}
#pragma warning restore 0169

		static Delegate cb_setNavBarTitleColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNavBarTitleColor_Ljava_lang_String_Handler ()
		{
			if (cb_setNavBarTitleColor_Ljava_lang_String_ == null)
				cb_setNavBarTitleColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNavBarTitleColor_Ljava_lang_String_);
			return cb_setNavBarTitleColor_Ljava_lang_String_;
		}

		static void n_SetNavBarTitleColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_navBarTitleColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string navBarTitleColor = JNIEnv.GetString (native_navBarTitleColor, JniHandleOwnership.DoNotTransfer);
			__this.NavBarTitleColor = navBarTitleColor;
		}
#pragma warning restore 0169

		public virtual unsafe string NavBarTitleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getNavBarTitleColor' and count(parameter)=0]"
			[Register ("getNavBarTitleColor", "()Ljava/lang/String;", "GetGetNavBarTitleColorHandler")]
			get {
				const string __id = "getNavBarTitleColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setNavBarTitleColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNavBarTitleColor", "(Ljava/lang/String;)V", "GetSetNavBarTitleColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNavBarTitleColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSelectedTabColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedTabColorHandler ()
		{
			if (cb_getSelectedTabColor == null)
				cb_getSelectedTabColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedTabColor);
			return cb_getSelectedTabColor;
		}

		static IntPtr n_GetSelectedTabColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SelectedTabColor);
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedTabColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSelectedTabColor_Ljava_lang_String_Handler ()
		{
			if (cb_setSelectedTabColor_Ljava_lang_String_ == null)
				cb_setSelectedTabColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedTabColor_Ljava_lang_String_);
			return cb_setSelectedTabColor_Ljava_lang_String_;
		}

		static void n_SetSelectedTabColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedTabColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string selectedTabColor = JNIEnv.GetString (native_selectedTabColor, JniHandleOwnership.DoNotTransfer);
			__this.SelectedTabColor = selectedTabColor;
		}
#pragma warning restore 0169

		public virtual unsafe string SelectedTabColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getSelectedTabColor' and count(parameter)=0]"
			[Register ("getSelectedTabColor", "()Ljava/lang/String;", "GetGetSelectedTabColorHandler")]
			get {
				const string __id = "getSelectedTabColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setSelectedTabColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSelectedTabColor", "(Ljava/lang/String;)V", "GetSetSelectedTabColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSelectedTabColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSelectedTabIndicatorColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedTabIndicatorColorHandler ()
		{
			if (cb_getSelectedTabIndicatorColor == null)
				cb_getSelectedTabIndicatorColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedTabIndicatorColor);
			return cb_getSelectedTabIndicatorColor;
		}

		static IntPtr n_GetSelectedTabIndicatorColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SelectedTabIndicatorColor);
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedTabIndicatorColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSelectedTabIndicatorColor_Ljava_lang_String_Handler ()
		{
			if (cb_setSelectedTabIndicatorColor_Ljava_lang_String_ == null)
				cb_setSelectedTabIndicatorColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedTabIndicatorColor_Ljava_lang_String_);
			return cb_setSelectedTabIndicatorColor_Ljava_lang_String_;
		}

		static void n_SetSelectedTabIndicatorColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedTabIndicatorColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string selectedTabIndicatorColor = JNIEnv.GetString (native_selectedTabIndicatorColor, JniHandleOwnership.DoNotTransfer);
			__this.SelectedTabIndicatorColor = selectedTabIndicatorColor;
		}
#pragma warning restore 0169

		public virtual unsafe string SelectedTabIndicatorColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getSelectedTabIndicatorColor' and count(parameter)=0]"
			[Register ("getSelectedTabIndicatorColor", "()Ljava/lang/String;", "GetGetSelectedTabIndicatorColorHandler")]
			get {
				const string __id = "getSelectedTabIndicatorColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setSelectedTabIndicatorColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSelectedTabIndicatorColor", "(Ljava/lang/String;)V", "GetSetSelectedTabIndicatorColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSelectedTabIndicatorColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTabBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetTabBackgroundColorHandler ()
		{
			if (cb_getTabBackgroundColor == null)
				cb_getTabBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTabBackgroundColor);
			return cb_getTabBackgroundColor;
		}

		static IntPtr n_GetTabBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TabBackgroundColor);
		}
#pragma warning restore 0169

		static Delegate cb_setTabBackgroundColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTabBackgroundColor_Ljava_lang_String_Handler ()
		{
			if (cb_setTabBackgroundColor_Ljava_lang_String_ == null)
				cb_setTabBackgroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTabBackgroundColor_Ljava_lang_String_);
			return cb_setTabBackgroundColor_Ljava_lang_String_;
		}

		static void n_SetTabBackgroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tabBackgroundColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tabBackgroundColor = JNIEnv.GetString (native_tabBackgroundColor, JniHandleOwnership.DoNotTransfer);
			__this.TabBackgroundColor = tabBackgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe string TabBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getTabBackgroundColor' and count(parameter)=0]"
			[Register ("getTabBackgroundColor", "()Ljava/lang/String;", "GetGetTabBackgroundColorHandler")]
			get {
				const string __id = "getTabBackgroundColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setTabBackgroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTabBackgroundColor", "(Ljava/lang/String;)V", "GetSetTabBackgroundColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTabBackgroundColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTabs;
#pragma warning disable 0169
		static Delegate GetGetTabsHandler ()
		{
			if (cb_getTabs == null)
				cb_getTabs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTabs);
			return cb_getTabs;
		}

		static IntPtr n_GetTabs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Tabs);
		}
#pragma warning restore 0169

		static Delegate cb_setTabs_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetTabs_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setTabs_Ljava_util_ArrayList_ == null)
				cb_setTabs_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTabs_Ljava_util_ArrayList_);
			return cb_setTabs_Ljava_util_ArrayList_;
		}

		static void n_SetTabs_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tabs)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tabs = global::Android.Runtime.JavaList<string>.FromJniHandle (native_tabs, JniHandleOwnership.DoNotTransfer);
			__this.Tabs = tabs;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Tabs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getTabs' and count(parameter)=0]"
			[Register ("getTabs", "()Ljava/util/ArrayList;", "GetGetTabsHandler")]
			get {
				const string __id = "getTabs.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setTabs' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
			[Register ("setTabs", "(Ljava/util/ArrayList;)V", "GetSetTabs_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setTabs.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUnselectedTabColor;
#pragma warning disable 0169
		static Delegate GetGetUnselectedTabColorHandler ()
		{
			if (cb_getUnselectedTabColor == null)
				cb_getUnselectedTabColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnselectedTabColor);
			return cb_getUnselectedTabColor;
		}

		static IntPtr n_GetUnselectedTabColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UnselectedTabColor);
		}
#pragma warning restore 0169

		static Delegate cb_setUnselectedTabColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUnselectedTabColor_Ljava_lang_String_Handler ()
		{
			if (cb_setUnselectedTabColor_Ljava_lang_String_ == null)
				cb_setUnselectedTabColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnselectedTabColor_Ljava_lang_String_);
			return cb_setUnselectedTabColor_Ljava_lang_String_;
		}

		static void n_SetUnselectedTabColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unselectedTabColor)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string unselectedTabColor = JNIEnv.GetString (native_unselectedTabColor, JniHandleOwnership.DoNotTransfer);
			__this.UnselectedTabColor = unselectedTabColor;
		}
#pragma warning restore 0169

		public virtual unsafe string UnselectedTabColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='getUnselectedTabColor' and count(parameter)=0]"
			[Register ("getUnselectedTabColor", "()Ljava/lang/String;", "GetGetUnselectedTabColorHandler")]
			get {
				const string __id = "getUnselectedTabColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='setUnselectedTabColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUnselectedTabColor", "(Ljava/lang/String;)V", "GetSetUnselectedTabColor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUnselectedTabColor.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxStyleConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxStyleConfig']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
