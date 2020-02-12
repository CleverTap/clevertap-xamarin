using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxMessageContent", DoNotGenerateAcw=true)]
	public partial class CTInboxMessageContent : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxMessageContent", typeof (CTInboxMessageContent));
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

		protected CTInboxMessageContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/constructor[@name='CTInboxMessageContent' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe CTInboxMessageContent (global::Android.OS.Parcel @in)
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

		static Delegate cb_getActionUrl;
#pragma warning disable 0169
		static Delegate GetGetActionUrlHandler ()
		{
			if (cb_getActionUrl == null)
				cb_getActionUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionUrl);
			return cb_getActionUrl;
		}

		static IntPtr n_GetActionUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActionUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string ActionUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getActionUrl' and count(parameter)=0]"
			[Register ("getActionUrl", "()Ljava/lang/String;", "GetGetActionUrlHandler")]
			get {
				const string __id = "getActionUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				const string __id = "getContentType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Icon);
		}
#pragma warning restore 0169

		public virtual unsafe string Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Ljava/lang/String;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLinks;
#pragma warning disable 0169
		static Delegate GetGetLinksHandler ()
		{
			if (cb_getLinks == null)
				cb_getLinks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinks);
			return cb_getLinks;
		}

		static IntPtr n_GetLinks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Links);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONArray Links {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinks' and count(parameter)=0]"
			[Register ("getLinks", "()Lorg/json/JSONArray;", "GetGetLinksHandler")]
			get {
				const string __id = "getLinks.()Lorg/json/JSONArray;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMedia;
#pragma warning disable 0169
		static Delegate GetGetMediaHandler ()
		{
			if (cb_getMedia == null)
				cb_getMedia = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMedia);
			return cb_getMedia;
		}

		static IntPtr n_GetMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Media);
		}
#pragma warning restore 0169

		public virtual unsafe string Media {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getMedia' and count(parameter)=0]"
			[Register ("getMedia", "()Ljava/lang/String;", "GetGetMediaHandler")]
			get {
				const string __id = "getMedia.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				const string __id = "getMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageColor;
#pragma warning disable 0169
		static Delegate GetGetMessageColorHandler ()
		{
			if (cb_getMessageColor == null)
				cb_getMessageColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageColor);
			return cb_getMessageColor;
		}

		static IntPtr n_GetMessageColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageColor);
		}
#pragma warning restore 0169

		public virtual unsafe string MessageColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getMessageColor' and count(parameter)=0]"
			[Register ("getMessageColor", "()Ljava/lang/String;", "GetGetMessageColorHandler")]
			get {
				const string __id = "getMessageColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPosterUrl;
#pragma warning disable 0169
		static Delegate GetGetPosterUrlHandler ()
		{
			if (cb_getPosterUrl == null)
				cb_getPosterUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosterUrl);
			return cb_getPosterUrl;
		}

		static IntPtr n_GetPosterUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PosterUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setPosterUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPosterUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setPosterUrl_Ljava_lang_String_ == null)
				cb_setPosterUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosterUrl_Ljava_lang_String_);
			return cb_setPosterUrl_Ljava_lang_String_;
		}

		static void n_SetPosterUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_posterUrl)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string posterUrl = JNIEnv.GetString (native_posterUrl, JniHandleOwnership.DoNotTransfer);
			__this.PosterUrl = posterUrl;
		}
#pragma warning restore 0169

		public virtual unsafe string PosterUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getPosterUrl' and count(parameter)=0]"
			[Register ("getPosterUrl", "()Ljava/lang/String;", "GetGetPosterUrlHandler")]
			get {
				const string __id = "getPosterUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='setPosterUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPosterUrl", "(Ljava/lang/String;)V", "GetSetPosterUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPosterUrl.(Ljava/lang/String;)V";
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

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleColor;
#pragma warning disable 0169
		static Delegate GetGetTitleColorHandler ()
		{
			if (cb_getTitleColor == null)
				cb_getTitleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitleColor);
			return cb_getTitleColor;
		}

		static IntPtr n_GetTitleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TitleColor);
		}
#pragma warning restore 0169

		public virtual unsafe string TitleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getTitleColor' and count(parameter)=0]"
			[Register ("getTitleColor", "()Ljava/lang/String;", "GetGetTitleColorHandler")]
			get {
				const string __id = "getTitleColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getLinkBGColor_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinkBGColor_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinkBGColor_Lorg_json_JSONObject_ == null)
				cb_getLinkBGColor_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinkBGColor_Lorg_json_JSONObject_);
			return cb_getLinkBGColor_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinkBGColor_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLinkBGColor (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinkBGColor' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinkBGColor", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLinkBGColor_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string GetLinkBGColor (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinkBGColor.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLinkColor_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinkColor_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinkColor_Lorg_json_JSONObject_ == null)
				cb_getLinkColor_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinkColor_Lorg_json_JSONObject_);
			return cb_getLinkColor_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinkColor_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLinkColor (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinkColor' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinkColor", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLinkColor_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string GetLinkColor (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinkColor.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLinkCopyText_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinkCopyText_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinkCopyText_Lorg_json_JSONObject_ == null)
				cb_getLinkCopyText_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinkCopyText_Lorg_json_JSONObject_);
			return cb_getLinkCopyText_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinkCopyText_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLinkCopyText (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinkCopyText' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinkCopyText", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLinkCopyText_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string GetLinkCopyText (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinkCopyText.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLinkKeyValue_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinkKeyValue_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinkKeyValue_Lorg_json_JSONObject_ == null)
				cb_getLinkKeyValue_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinkKeyValue_Lorg_json_JSONObject_);
			return cb_getLinkKeyValue_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinkKeyValue_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetLinkKeyValue (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinkKeyValue' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinkKeyValue", "(Lorg/json/JSONObject;)Ljava/util/HashMap;", "GetGetLinkKeyValue_Lorg_json_JSONObject_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetLinkKeyValue (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinkKeyValue.(Lorg/json/JSONObject;)Ljava/util/HashMap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLinkText_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinkText_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinkText_Lorg_json_JSONObject_ == null)
				cb_getLinkText_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinkText_Lorg_json_JSONObject_);
			return cb_getLinkText_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinkText_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLinkText (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinkText' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinkText", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLinkText_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string GetLinkText (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinkText.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLinkUrl_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinkUrl_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinkUrl_Lorg_json_JSONObject_ == null)
				cb_getLinkUrl_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinkUrl_Lorg_json_JSONObject_);
			return cb_getLinkUrl_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinkUrl_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLinkUrl (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinkUrl' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinkUrl", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLinkUrl_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string GetLinkUrl (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinkUrl.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getLinktype_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetGetLinktype_Lorg_json_JSONObject_Handler ()
		{
			if (cb_getLinktype_Lorg_json_JSONObject_ == null)
				cb_getLinktype_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLinktype_Lorg_json_JSONObject_);
			return cb_getLinktype_Lorg_json_JSONObject_;
		}

		static IntPtr n_GetLinktype_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_jsonObject)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject jsonObject = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_jsonObject, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetLinktype (jsonObject));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='getLinktype' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("getLinktype", "(Lorg/json/JSONObject;)Ljava/lang/String;", "GetGetLinktype_Lorg_json_JSONObject_Handler")]
		public virtual unsafe string GetLinktype (global::Org.Json.JSONObject jsonObject)
		{
			const string __id = "getLinktype.(Lorg/json/JSONObject;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mediaIsAudio;
#pragma warning disable 0169
		static Delegate GetMediaIsAudioHandler ()
		{
			if (cb_mediaIsAudio == null)
				cb_mediaIsAudio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MediaIsAudio);
			return cb_mediaIsAudio;
		}

		static bool n_MediaIsAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsAudio ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='mediaIsAudio' and count(parameter)=0]"
		[Register ("mediaIsAudio", "()Z", "GetMediaIsAudioHandler")]
		public virtual unsafe bool MediaIsAudio ()
		{
			const string __id = "mediaIsAudio.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_mediaIsGIF;
#pragma warning disable 0169
		static Delegate GetMediaIsGIFHandler ()
		{
			if (cb_mediaIsGIF == null)
				cb_mediaIsGIF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MediaIsGIF);
			return cb_mediaIsGIF;
		}

		static bool n_MediaIsGIF (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsGIF ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='mediaIsGIF' and count(parameter)=0]"
		[Register ("mediaIsGIF", "()Z", "GetMediaIsGIFHandler")]
		public virtual unsafe bool MediaIsGIF ()
		{
			const string __id = "mediaIsGIF.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_mediaIsImage;
#pragma warning disable 0169
		static Delegate GetMediaIsImageHandler ()
		{
			if (cb_mediaIsImage == null)
				cb_mediaIsImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MediaIsImage);
			return cb_mediaIsImage;
		}

		static bool n_MediaIsImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='mediaIsImage' and count(parameter)=0]"
		[Register ("mediaIsImage", "()Z", "GetMediaIsImageHandler")]
		public virtual unsafe bool MediaIsImage ()
		{
			const string __id = "mediaIsImage.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_mediaIsVideo;
#pragma warning disable 0169
		static Delegate GetMediaIsVideoHandler ()
		{
			if (cb_mediaIsVideo == null)
				cb_mediaIsVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_MediaIsVideo);
			return cb_mediaIsVideo;
		}

		static bool n_MediaIsVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsVideo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='mediaIsVideo' and count(parameter)=0]"
		[Register ("mediaIsVideo", "()Z", "GetMediaIsVideoHandler")]
		public virtual unsafe bool MediaIsVideo ()
		{
			const string __id = "mediaIsVideo.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
			global::Com.Clevertap.Android.Sdk.CTInboxMessageContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessageContent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
