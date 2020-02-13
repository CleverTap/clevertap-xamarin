using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTCarouselViewPagerAdapter']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/CTCarouselViewPagerAdapter", DoNotGenerateAcw=true)]
	public partial class CTCarouselViewPagerAdapter : global::Android.Support.V4.View.PagerAdapter {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/CTCarouselViewPagerAdapter", typeof (CTCarouselViewPagerAdapter));
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

		protected CTCarouselViewPagerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.CTCarouselViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTCarouselViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTCarouselViewPagerAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler ()
		{
			if (cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == null)
				cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_);
			return cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		}

		static bool n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_o)
		{
			global::Com.Clevertap.Android.Sdk.CTCarouselViewPagerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.CTCarouselViewPagerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object o = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_o, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsViewFromObject (view, o);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='CTCarouselViewPagerAdapter']/method[@name='isViewFromObject' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public override unsafe bool IsViewFromObject (global::Android.Views.View view, global::Java.Lang.Object o)
		{
			const string __id = "isViewFromObject.(Landroid/view/View;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
