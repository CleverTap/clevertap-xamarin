using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Framing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='DataFrame']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/framing/DataFrame", DoNotGenerateAcw=true)]
	public abstract partial class DataFrame : global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/framing/DataFrame", typeof (DataFrame));
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

		protected DataFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='DataFrame']/constructor[@name='DataFrame' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;)V", "")]
		public unsafe DataFrame (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode opcode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((opcode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) opcode).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IsValid);
			return cb_isValid;
		}

		static void n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.DataFrame __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.DataFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsValid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='DataFrame']/method[@name='isValid' and count(parameter)=0]"
		[Register ("isValid", "()V", "GetIsValidHandler")]
		public override unsafe void IsValid ()
		{
			const string __id = "isValid.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/framing/DataFrame", DoNotGenerateAcw=true)]
	internal partial class DataFrameInvoker : DataFrame {

		public DataFrameInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/framing/DataFrame", typeof (DataFrameInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
