using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk.Java_websocket.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='CompressionExtension']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/extensions/CompressionExtension", DoNotGenerateAcw=true)]
	public abstract partial class CompressionExtension : global::Com.Clevertap.Android.Sdk.Java_websocket.Extensions.DefaultExtension {

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/extensions/CompressionExtension", typeof (CompressionExtension));
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

		protected CompressionExtension (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.clevertap.android.sdk.java_websocket.extensions']/class[@name='CompressionExtension']/constructor[@name='CompressionExtension' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CompressionExtension ()
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

	}

	[global::Android.Runtime.Register ("com/clevertap/android/sdk/java_websocket/extensions/CompressionExtension", DoNotGenerateAcw=true)]
	internal partial class CompressionExtensionInvoker : CompressionExtension {

		public CompressionExtensionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/java_websocket/extensions/CompressionExtension", typeof (CompressionExtensionInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
