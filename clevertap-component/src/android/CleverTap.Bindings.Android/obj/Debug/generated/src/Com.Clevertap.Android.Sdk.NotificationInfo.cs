using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='NotificationInfo']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/NotificationInfo", DoNotGenerateAcw=true)]
	public sealed partial class NotificationInfo : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='NotificationInfo']/field[@name='fromCleverTap']"
		[Register ("fromCleverTap")]
		public bool FromCleverTap {
			get {
				const string __id = "fromCleverTap.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "fromCleverTap.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/NotificationInfo", typeof (NotificationInfo));
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

		internal NotificationInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
