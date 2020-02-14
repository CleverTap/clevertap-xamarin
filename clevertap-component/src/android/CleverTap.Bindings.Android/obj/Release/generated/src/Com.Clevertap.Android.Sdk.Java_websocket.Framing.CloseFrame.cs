using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Framing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/framing/CloseFrame", DoNotGenerateAcw=true)]
	public partial class CloseFrame : global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.ControlFrame {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='ABNORMAL_CLOSE']"
		[Register ("ABNORMAL_CLOSE")]
		public const int AbnormalClose = (int) 1006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='BAD_GATEWAY']"
		[Register ("BAD_GATEWAY")]
		public const int BadGateway = (int) 1014;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='BUGGYCLOSE']"
		[Register ("BUGGYCLOSE")]
		public const int Buggyclose = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='EXTENSION']"
		[Register ("EXTENSION")]
		public const int Extension = (int) 1010;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='FLASHPOLICY']"
		[Register ("FLASHPOLICY")]
		public const int Flashpolicy = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='GOING_AWAY']"
		[Register ("GOING_AWAY")]
		public const int GoingAway = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='NEVER_CONNECTED']"
		[Register ("NEVER_CONNECTED")]
		public const int NeverConnected = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='NOCODE']"
		[Register ("NOCODE")]
		public const int Nocode = (int) 1005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public const int Normal = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='NO_UTF8']"
		[Register ("NO_UTF8")]
		public const int NoUtf8 = (int) 1007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='POLICY_VALIDATION']"
		[Register ("POLICY_VALIDATION")]
		public const int PolicyValidation = (int) 1008;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='PROTOCOL_ERROR']"
		[Register ("PROTOCOL_ERROR")]
		public const int ProtocolError = (int) 1002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='REFUSE']"
		[Register ("REFUSE")]
		public const int Refuse = (int) 1003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='SERVICE_RESTART']"
		[Register ("SERVICE_RESTART")]
		public const int ServiceRestart = (int) 1012;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='TLS_ERROR']"
		[Register ("TLS_ERROR")]
		public const int TlsError = (int) 1015;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='TOOBIG']"
		[Register ("TOOBIG")]
		public const int Toobig = (int) 1009;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='TRY_AGAIN_LATER']"
		[Register ("TRY_AGAIN_LATER")]
		public const int TryAgainLater = (int) 1013;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/field[@name='UNEXPECTED_CONDITION']"
		[Register ("UNEXPECTED_CONDITION")]
		public const int UnexpectedCondition = (int) 1011;
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/framing/CloseFrame", typeof (CloseFrame));
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

		protected CloseFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/constructor[@name='CloseFrame' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloseFrame ()
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

		static Delegate cb_getCloseCode;
#pragma warning disable 0169
		static Delegate GetGetCloseCodeHandler ()
		{
			if (cb_getCloseCode == null)
				cb_getCloseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCloseCode);
			return cb_getCloseCode;
		}

		static int n_GetCloseCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseCode;
		}
#pragma warning restore 0169

		public virtual unsafe int CloseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/method[@name='getCloseCode' and count(parameter)=0]"
			[Register ("getCloseCode", "()I", "GetGetCloseCodeHandler")]
			get {
				const string __id = "getCloseCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/method[@name='getMessage' and count(parameter)=0]"
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

		static Delegate cb_setCode_I;
#pragma warning disable 0169
		static Delegate GetSetCode_IHandler ()
		{
			if (cb_setCode_I == null)
				cb_setCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCode_I);
			return cb_setCode_I;
		}

		static void n_SetCode_I (IntPtr jnienv, IntPtr native__this, int code)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCode (code);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCode", "(I)V", "GetSetCode_IHandler")]
		public virtual unsafe void SetCode (int code)
		{
			const string __id = "setCode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReason_Ljava_lang_String_Handler ()
		{
			if (cb_setReason_Ljava_lang_String_ == null)
				cb_setReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReason_Ljava_lang_String_);
			return cb_setReason_Ljava_lang_String_;
		}

		static void n_SetReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reason)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.CloseFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string reason = JNIEnv.GetString (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.SetReason (reason);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='CloseFrame']/method[@name='setReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReason", "(Ljava/lang/String;)V", "GetSetReason_Ljava_lang_String_Handler")]
		public virtual unsafe void SetReason (string reason)
		{
			const string __id = "setReason.(Ljava/lang/String;)V";
			IntPtr native_reason = JNIEnv.NewString (reason);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reason);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reason);
			}
		}

	}
}
