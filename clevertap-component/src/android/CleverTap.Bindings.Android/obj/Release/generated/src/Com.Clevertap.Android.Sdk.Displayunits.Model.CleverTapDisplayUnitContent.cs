using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Displayunits.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnitContent", DoNotGenerateAcw=true)]
	public partial class CleverTapDisplayUnitContent : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/displayunits/model/CleverTapDisplayUnitContent", typeof (CleverTapDisplayUnitContent));
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

		protected CleverTapDisplayUnitContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ActionUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string ActionUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getActionUrl' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getContentType' and count(parameter)=0]"
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

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe string Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Ljava/lang/String;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Ljava/lang/String;";
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Icon);
		}
#pragma warning restore 0169

		public virtual unsafe string Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getIcon' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Media);
		}
#pragma warning restore 0169

		public virtual unsafe string Media {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getMedia' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getMessage' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageColor);
		}
#pragma warning restore 0169

		public virtual unsafe string MessageColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getMessageColor' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PosterUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string PosterUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getPosterUrl' and count(parameter)=0]"
			[Register ("getPosterUrl", "()Ljava/lang/String;", "GetGetPosterUrlHandler")]
			get {
				const string __id = "getPosterUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getTitle' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TitleColor);
		}
#pragma warning restore 0169

		public virtual unsafe string TitleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='getTitleColor' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsAudio ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='mediaIsAudio' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsGIF ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='mediaIsGIF' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='mediaIsImage' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaIsVideo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='mediaIsVideo' and count(parameter)=0]"
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
			global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Displayunits.Model.CleverTapDisplayUnitContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.displayunits.model']/class[@name='CleverTapDisplayUnitContent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
