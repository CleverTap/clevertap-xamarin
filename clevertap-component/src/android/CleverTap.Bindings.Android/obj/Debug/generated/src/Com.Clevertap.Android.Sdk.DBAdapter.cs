using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Clevertap.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter']"
	[global::Android.Runtime.Register ("com/clevertap/android/sdk/DBAdapter", DoNotGenerateAcw=true)]
	public partial class DBAdapter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter']/field[@name='DB_UNDEFINED_CODE']"
		[Register ("DB_UNDEFINED_CODE")]
		public const int DbUndefinedCode = (int) -3;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.DatabaseHelper']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/DBAdapter$DatabaseHelper", DoNotGenerateAcw=true)]
		public partial class DatabaseHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {

			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/DBAdapter$DatabaseHelper", typeof (DatabaseHelper));
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

			protected DatabaseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == null)
					cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_);
				return cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_db)
			{
				global::Com.Clevertap.Android.Sdk.DBAdapter.DatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.DatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase db = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_db, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate (db);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.DatabaseHelper']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler")]
			public override unsafe void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase db)
			{
				const string __id = "onCreate.(Landroid/database/sqlite/SQLiteDatabase;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
#pragma warning disable 0169
			static Delegate GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler ()
			{
				if (cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == null)
					cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II);
				return cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			}

			static void n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II (IntPtr jnienv, IntPtr native__this, IntPtr native_db, int oldVersion, int newVersion)
			{
				global::Com.Clevertap.Android.Sdk.DBAdapter.DatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.DatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase db = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_db, JniHandleOwnership.DoNotTransfer);
				__this.OnUpgrade (db, oldVersion, newVersion);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.DatabaseHelper']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
			public override unsafe void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase db, int oldVersion, int newVersion)
			{
				const string __id = "onUpgrade.(Landroid/database/sqlite/SQLiteDatabase;II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((db == null) ? IntPtr.Zero : ((global::Java.Lang.Object) db).Handle);
					__args [1] = new JniArgumentValue (oldVersion);
					__args [2] = new JniArgumentValue (newVersion);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']"
		[global::Android.Runtime.Register ("com/clevertap/android/sdk/DBAdapter$Table", DoNotGenerateAcw=true)]
		public sealed partial class Table : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='EVENTS']"
			[Register ("EVENTS")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table Events {
				get {
					const string __id = "EVENTS.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='INBOX_MESSAGES']"
			[Register ("INBOX_MESSAGES")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table InboxMessages {
				get {
					const string __id = "INBOX_MESSAGES.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='PROFILE_EVENTS']"
			[Register ("PROFILE_EVENTS")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table ProfileEvents {
				get {
					const string __id = "PROFILE_EVENTS.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='PUSH_NOTIFICATIONS']"
			[Register ("PUSH_NOTIFICATIONS")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table PushNotifications {
				get {
					const string __id = "PUSH_NOTIFICATIONS.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='PUSH_NOTIFICATION_VIEWED']"
			[Register ("PUSH_NOTIFICATION_VIEWED")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table PushNotificationViewed {
				get {
					const string __id = "PUSH_NOTIFICATION_VIEWED.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='UNINSTALL_TS']"
			[Register ("UNINSTALL_TS")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table UninstallTs {
				get {
					const string __id = "UNINSTALL_TS.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/field[@name='USER_PROFILES']"
			[Register ("USER_PROFILES")]
			public static global::Com.Clevertap.Android.Sdk.DBAdapter.Table UserProfiles {
				get {
					const string __id = "USER_PROFILES.Lcom/clevertap/android/sdk/DBAdapter$Table;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/DBAdapter$Table", typeof (Table));
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

			internal Table (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/clevertap/android/sdk/DBAdapter$Table;", "")]
			public static unsafe global::Com.Clevertap.Android.Sdk.DBAdapter.Table ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/clevertap/android/sdk/DBAdapter$Table;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Clevertap.Android.Sdk.DBAdapter.Table> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.clevertap.android.sdk']/class[@name='DBAdapter.Table']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/clevertap/android/sdk/DBAdapter$Table;", "")]
			public static unsafe global::Com.Clevertap.Android.Sdk.DBAdapter.Table[] Values ()
			{
				const string __id = "values.()[Lcom/clevertap/android/sdk/DBAdapter$Table;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Clevertap.Android.Sdk.DBAdapter.Table[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Clevertap.Android.Sdk.DBAdapter.Table));
				} finally {
				}
			}

		}

		internal static new readonly JniPeerMembers _members = new XAPeerMembers ("com/clevertap/android/sdk/DBAdapter", typeof (DBAdapter));
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

		protected DBAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
