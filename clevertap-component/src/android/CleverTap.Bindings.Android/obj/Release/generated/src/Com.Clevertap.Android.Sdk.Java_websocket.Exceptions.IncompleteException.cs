using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='IncompleteException']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/exceptions/IncompleteException", DoNotGenerateAcw=true)]
	public partial class IncompleteException : global::Java.Lang.Exception {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/exceptions/IncompleteException", typeof (IncompleteException));
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

		protected IncompleteException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='IncompleteException']/constructor[@name='IncompleteException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe IncompleteException (int preferredSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (preferredSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getPreferredSize;
#pragma warning disable 0169
		static Delegate GetGetPreferredSizeHandler ()
		{
			if (cb_getPreferredSize == null)
				cb_getPreferredSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreferredSize);
			return cb_getPreferredSize;
		}

		static int n_GetPreferredSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.IncompleteException __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Exceptions.IncompleteException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredSize;
		}
#pragma warning restore 0169

		public virtual unsafe int PreferredSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.exceptions']/class[@name='IncompleteException']/method[@name='getPreferredSize' and count(parameter)=0]"
			[Register ("getPreferredSize", "()I", "GetGetPreferredSizeHandler")]
			get {
				const string __id = "getPreferredSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
