using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Framing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/framing/FramedataImpl1", DoNotGenerateAcw=true)]
	public abstract partial class FramedataImpl1 : global::Java.Lang.Object, global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/framing/FramedataImpl1", typeof (FramedataImpl1));
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

		protected FramedataImpl1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/constructor[@name='FramedataImpl1' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode']]"
		[Register (".ctor", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;)V", "")]
		public unsafe FramedataImpl1 (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode op)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isFin;
#pragma warning disable 0169
		static Delegate GetIsFinHandler ()
		{
			if (cb_isFin == null)
				cb_isFin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFin);
			return cb_isFin;
		}

		static bool n_IsFin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFin;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='isFin' and count(parameter)=0]"
			[Register ("isFin", "()Z", "GetIsFinHandler")]
			get {
				const string __id = "isFin.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRSV1;
#pragma warning disable 0169
		static Delegate GetIsRSV1Handler ()
		{
			if (cb_isRSV1 == null)
				cb_isRSV1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRSV1);
			return cb_isRSV1;
		}

		static bool n_IsRSV1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRSV1;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRSV1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='isRSV1' and count(parameter)=0]"
			[Register ("isRSV1", "()Z", "GetIsRSV1Handler")]
			get {
				const string __id = "isRSV1.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRSV2;
#pragma warning disable 0169
		static Delegate GetIsRSV2Handler ()
		{
			if (cb_isRSV2 == null)
				cb_isRSV2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRSV2);
			return cb_isRSV2;
		}

		static bool n_IsRSV2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRSV2;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRSV2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='isRSV2' and count(parameter)=0]"
			[Register ("isRSV2", "()Z", "GetIsRSV2Handler")]
			get {
				const string __id = "isRSV2.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRSV3;
#pragma warning disable 0169
		static Delegate GetIsRSV3Handler ()
		{
			if (cb_isRSV3 == null)
				cb_isRSV3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRSV3);
			return cb_isRSV3;
		}

		static bool n_IsRSV3 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRSV3;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRSV3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='isRSV3' and count(parameter)=0]"
			[Register ("isRSV3", "()Z", "GetIsRSV3Handler")]
			get {
				const string __id = "isRSV3.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpcode;
#pragma warning disable 0169
		static Delegate GetGetOpcodeHandler ()
		{
			if (cb_getOpcode == null)
				cb_getOpcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpcode);
			return cb_getOpcode;
		}

		static IntPtr n_GetOpcode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Opcode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode Opcode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='getOpcode' and count(parameter)=0]"
			[Register ("getOpcode", "()Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;", "GetGetOpcodeHandler")]
			get {
				const string __id = "getOpcode.()Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPayloadData;
#pragma warning disable 0169
		static Delegate GetGetPayloadDataHandler ()
		{
			if (cb_getPayloadData == null)
				cb_getPayloadData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayloadData);
			return cb_getPayloadData;
		}

		static IntPtr n_GetPayloadData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PayloadData);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer PayloadData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='getPayloadData' and count(parameter)=0]"
			[Register ("getPayloadData", "()Ljava/nio/ByteBuffer;", "GetGetPayloadDataHandler")]
			get {
				const string __id = "getPayloadData.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransfereMasked;
#pragma warning disable 0169
		static Delegate GetGetTransfereMaskedHandler ()
		{
			if (cb_getTransfereMasked == null)
				cb_getTransfereMasked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTransfereMasked);
			return cb_getTransfereMasked;
		}

		static bool n_GetTransfereMasked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransfereMasked;
		}
#pragma warning restore 0169

		public virtual unsafe bool TransfereMasked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='getTransfereMasked' and count(parameter)=0]"
			[Register ("getTransfereMasked", "()Z", "GetGetTransfereMaskedHandler")]
			get {
				const string __id = "getTransfereMasked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
#pragma warning disable 0169
		static Delegate GetAppend_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler ()
		{
			if (cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ == null)
				cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_);
			return cb_append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_;
		}

		static void n_Append_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextframe)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata nextframe = (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata)global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata> (native_nextframe, JniHandleOwnership.DoNotTransfer);
			__this.Append (nextframe);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='append' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.framing.Framedata']]"
		[Register ("append", "(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V", "GetAppend_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler")]
		public virtual unsafe void Append (global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.IFramedata nextframe)
		{
			const string __id = "append.(Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nextframe == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nextframe).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.clevertap.android.sdk.java_websocket.enums.Opcode']]"
		[Register ("get", "(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;)Lcom/clevertap/android/sdk/java_websocket/framing/FramedataImpl1;", "")]
		public static unsafe global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 Get (global::Com.Clevertap.Android.Sdk.Java_websocket.Enums.Opcode opcode)
		{
			const string __id = "get.(Lcom/clevertap/android/sdk/java_websocket/enums/Opcode;)Lcom/clevertap/android/sdk/java_websocket/framing/FramedataImpl1;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((opcode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) opcode).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsValid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='isValid' and count(parameter)=0]"
		[Register ("isValid", "()V", "GetIsValidHandler")]
		public abstract void IsValid ();

		static Delegate cb_setFin_Z;
#pragma warning disable 0169
		static Delegate GetSetFin_ZHandler ()
		{
			if (cb_setFin_Z == null)
				cb_setFin_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFin_Z);
			return cb_setFin_Z;
		}

		static void n_SetFin_Z (IntPtr jnienv, IntPtr native__this, bool fin)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFin (fin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='setFin' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFin", "(Z)V", "GetSetFin_ZHandler")]
		public virtual unsafe void SetFin (bool fin)
		{
			const string __id = "setFin.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fin);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPayload_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSetPayload_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_setPayload_Ljava_nio_ByteBuffer_ == null)
				cb_setPayload_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_Ljava_nio_ByteBuffer_);
			return cb_setPayload_Ljava_nio_ByteBuffer_;
		}

		static void n_SetPayload_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer payload = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_payload, JniHandleOwnership.DoNotTransfer);
			__this.SetPayload (payload);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("setPayload", "(Ljava/nio/ByteBuffer;)V", "GetSetPayload_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void SetPayload (global::Java.Nio.ByteBuffer payload)
		{
			const string __id = "setPayload.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((payload == null) ? IntPtr.Zero : ((global::Java.Lang.Object) payload).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRSV1_Z;
#pragma warning disable 0169
		static Delegate GetSetRSV1_ZHandler ()
		{
			if (cb_setRSV1_Z == null)
				cb_setRSV1_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRSV1_Z);
			return cb_setRSV1_Z;
		}

		static void n_SetRSV1_Z (IntPtr jnienv, IntPtr native__this, bool rsv1)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRSV1 (rsv1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='setRSV1' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRSV1", "(Z)V", "GetSetRSV1_ZHandler")]
		public virtual unsafe void SetRSV1 (bool rsv1)
		{
			const string __id = "setRSV1.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rsv1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRSV2_Z;
#pragma warning disable 0169
		static Delegate GetSetRSV2_ZHandler ()
		{
			if (cb_setRSV2_Z == null)
				cb_setRSV2_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRSV2_Z);
			return cb_setRSV2_Z;
		}

		static void n_SetRSV2_Z (IntPtr jnienv, IntPtr native__this, bool rsv2)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRSV2 (rsv2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='setRSV2' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRSV2", "(Z)V", "GetSetRSV2_ZHandler")]
		public virtual unsafe void SetRSV2 (bool rsv2)
		{
			const string __id = "setRSV2.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rsv2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRSV3_Z;
#pragma warning disable 0169
		static Delegate GetSetRSV3_ZHandler ()
		{
			if (cb_setRSV3_Z == null)
				cb_setRSV3_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRSV3_Z);
			return cb_setRSV3_Z;
		}

		static void n_SetRSV3_Z (IntPtr jnienv, IntPtr native__this, bool rsv3)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRSV3 (rsv3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='setRSV3' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRSV3", "(Z)V", "GetSetRSV3_ZHandler")]
		public virtual unsafe void SetRSV3 (bool rsv3)
		{
			const string __id = "setRSV3.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rsv3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTransferemasked_Z;
#pragma warning disable 0169
		static Delegate GetSetTransferemasked_ZHandler ()
		{
			if (cb_setTransferemasked_Z == null)
				cb_setTransferemasked_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTransferemasked_Z);
			return cb_setTransferemasked_Z;
		}

		static void n_SetTransferemasked_Z (IntPtr jnienv, IntPtr native__this, bool transferemasked)
		{
			global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1 __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.Java_websocket.Framing.FramedataImpl1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransferemasked (transferemasked);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='setTransferemasked' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTransferemasked", "(Z)V", "GetSetTransferemasked_ZHandler")]
		public virtual unsafe void SetTransferemasked (bool transferemasked)
		{
			const string __id = "setTransferemasked.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (transferemasked);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/framing/FramedataImpl1", DoNotGenerateAcw=true)]
	internal partial class FramedataImpl1Invoker : FramedataImpl1 {

		public FramedataImpl1Invoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/framing/FramedataImpl1", typeof (FramedataImpl1Invoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.framing']/class[@name='FramedataImpl1']/method[@name='isValid' and count(parameter)=0]"
		[Register ("isValid", "()V", "GetIsValidHandler")]
		public override unsafe void IsValid ()
		{
			const string __id = "isValid.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
