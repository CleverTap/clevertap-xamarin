using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='EventDetail']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/EventDetail", DoNotGenerateAcw=true)]
	public partial class EventDetail : global::Java.Lang.Object {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/EventDetail", typeof (EventDetail));
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

		protected EventDetail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='EventDetail']/constructor[@name='EventDetail' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(IIILjava/lang/String;)V", "")]
		public unsafe EventDetail (int count, int firstTime, int lastTime, string name)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (firstTime);
				__args [2] = new JniArgumentValue (lastTime);
				__args [3] = new JniArgumentValue (native_name);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

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
			global::Com.Clevertap.Android.Sdk.EventDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.EventDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='EventDetail']/method[@name='getCount' and count(parameter)=0]"
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

		static Delegate cb_getFirstTime;
#pragma warning disable 0169
		static Delegate GetGetFirstTimeHandler ()
		{
			if (cb_getFirstTime == null)
				cb_getFirstTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstTime);
			return cb_getFirstTime;
		}

		static int n_GetFirstTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.EventDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.EventDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstTime;
		}
#pragma warning restore 0169

		public virtual unsafe int FirstTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='EventDetail']/method[@name='getFirstTime' and count(parameter)=0]"
			[Register ("getFirstTime", "()I", "GetGetFirstTimeHandler")]
			get {
				const string __id = "getFirstTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastTime;
#pragma warning disable 0169
		static Delegate GetGetLastTimeHandler ()
		{
			if (cb_getLastTime == null)
				cb_getLastTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastTime);
			return cb_getLastTime;
		}

		static int n_GetLastTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.EventDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.EventDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastTime;
		}
#pragma warning restore 0169

		public virtual unsafe int LastTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='EventDetail']/method[@name='getLastTime' and count(parameter)=0]"
			[Register ("getLastTime", "()I", "GetGetLastTimeHandler")]
			get {
				const string __id = "getLastTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::Com.Clevertap.Android.Sdk.EventDetail __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.EventDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='EventDetail']/method[@name='getName' and count(parameter)=0]"
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

	}
}
