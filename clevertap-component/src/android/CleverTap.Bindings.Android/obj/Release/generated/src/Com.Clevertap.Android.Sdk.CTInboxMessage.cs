using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTInboxMessage", DoNotGenerateAcw=true)]
	public partial class CTInboxMessage : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTInboxMessage", typeof (CTInboxMessage));
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

		protected CTInboxMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActionUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string ActionUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getActionUrl' and count(parameter)=0]"
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

		static Delegate cb_getBgColor;
#pragma warning disable 0169
		static Delegate GetGetBgColorHandler ()
		{
			if (cb_getBgColor == null)
				cb_getBgColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBgColor);
			return cb_getBgColor;
		}

		static IntPtr n_GetBgColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BgColor);
		}
#pragma warning restore 0169

		public virtual unsafe string BgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getBgColor' and count(parameter)=0]"
			[Register ("getBgColor", "()Ljava/lang/String;", "GetGetBgColorHandler")]
			get {
				const string __id = "getBgColor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Body);
		}
#pragma warning restore 0169

		public virtual unsafe string Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
			get {
				const string __id = "getBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Android.OS.IParcelableCreator CREATOR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getCREATOR' and count(parameter)=0]"
			[Register ("getCREATOR", "()Landroid/os/Parcelable$Creator;", "")]
			get {
				const string __id = "getCREATOR.()Landroid/os/Parcelable$Creator;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCampaignId;
#pragma warning disable 0169
		static Delegate GetGetCampaignIdHandler ()
		{
			if (cb_getCampaignId == null)
				cb_getCampaignId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaignId);
			return cb_getCampaignId;
		}

		static IntPtr n_GetCampaignId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CampaignId);
		}
#pragma warning restore 0169

		public virtual unsafe string CampaignId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getCampaignId' and count(parameter)=0]"
			[Register ("getCampaignId", "()Ljava/lang/String;", "GetGetCampaignIdHandler")]
			get {
				const string __id = "getCampaignId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCarouselImages;
#pragma warning disable 0169
		static Delegate GetGetCarouselImagesHandler ()
		{
			if (cb_getCarouselImages == null)
				cb_getCarouselImages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCarouselImages);
			return cb_getCarouselImages;
		}

		static IntPtr n_GetCarouselImages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.CarouselImages);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> CarouselImages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getCarouselImages' and count(parameter)=0]"
			[Register ("getCarouselImages", "()Ljava/util/ArrayList;", "GetGetCarouselImagesHandler")]
			get {
				const string __id = "getCarouselImages.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomData;
#pragma warning disable 0169
		static Delegate GetGetCustomDataHandler ()
		{
			if (cb_getCustomData == null)
				cb_getCustomData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomData);
			return cb_getCustomData;
		}

		static IntPtr n_GetCustomData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomData);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject CustomData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getCustomData' and count(parameter)=0]"
			[Register ("getCustomData", "()Lorg/json/JSONObject;", "GetGetCustomDataHandler")]
			get {
				const string __id = "getCustomData.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDate);
			return cb_getDate;
		}

		static long n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Date;
		}
#pragma warning restore 0169

		public virtual unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()J", "GetGetDateHandler")]
			get {
				const string __id = "getDate.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExpires;
#pragma warning disable 0169
		static Delegate GetGetExpiresHandler ()
		{
			if (cb_getExpires == null)
				cb_getExpires = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpires);
			return cb_getExpires;
		}

		static long n_GetExpires (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Expires;
		}
#pragma warning restore 0169

		public virtual unsafe long Expires {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getExpires' and count(parameter)=0]"
			[Register ("getExpires", "()J", "GetGetExpiresHandler")]
			get {
				const string __id = "getExpires.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				const string __id = "getImageUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInboxMessageContents;
#pragma warning disable 0169
		static Delegate GetGetInboxMessageContentsHandler ()
		{
			if (cb_getInboxMessageContents == null)
				cb_getInboxMessageContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInboxMessageContents);
			return cb_getInboxMessageContents;
		}

		static IntPtr n_GetInboxMessageContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent>.ToLocalJniHandle (__this.InboxMessageContents);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent> InboxMessageContents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getInboxMessageContents' and count(parameter)=0]"
			[Register ("getInboxMessageContents", "()Ljava/util/ArrayList;", "GetGetInboxMessageContentsHandler")]
			get {
				const string __id = "getInboxMessageContents.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Clevertap.Android.Sdk.CTInboxMessageContent>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRead;
#pragma warning disable 0169
		static Delegate GetIsReadHandler ()
		{
			if (cb_isRead == null)
				cb_isRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRead);
			return cb_isRead;
		}

		static bool n_IsRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRead;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='isRead' and count(parameter)=0]"
			[Register ("isRead", "()Z", "GetIsReadHandler")]
			get {
				const string __id = "isRead.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageId);
			return cb_getMessageId;
		}

		static IntPtr n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageId);
		}
#pragma warning restore 0169

		public virtual unsafe string MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()Ljava/lang/String;", "GetGetMessageIdHandler")]
			get {
				const string __id = "getMessageId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientation);
			return cb_getOrientation;
		}

		static IntPtr n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Orientation);
		}
#pragma warning restore 0169

		public virtual unsafe string Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()Ljava/lang/String;", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/List;", "GetGetTagsHandler")]
			get {
				const string __id = "getTags.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getTitle' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Enum Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Enum;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/Enum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWzrkParams;
#pragma warning disable 0169
		static Delegate GetGetWzrkParamsHandler ()
		{
			if (cb_getWzrkParams == null)
				cb_getWzrkParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWzrkParams);
			return cb_getWzrkParams;
		}

		static IntPtr n_GetWzrkParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WzrkParams);
		}
#pragma warning restore 0169

		public virtual unsafe global::Org.Json.JSONObject WzrkParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='getWzrkParams' and count(parameter)=0]"
			[Register ("getWzrkParams", "()Lorg/json/JSONObject;", "GetGetWzrkParamsHandler")]
			get {
				const string __id = "getWzrkParams.()Lorg/json/JSONObject;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.CTInboxMessage __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTInboxMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTInboxMessage']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
