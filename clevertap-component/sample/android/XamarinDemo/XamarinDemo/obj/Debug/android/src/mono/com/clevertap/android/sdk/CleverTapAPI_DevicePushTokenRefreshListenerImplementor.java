package mono.com.clevertap.android.sdk;


public class CleverTapAPI_DevicePushTokenRefreshListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.CleverTapAPI.DevicePushTokenRefreshListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_devicePushTokenDidRefresh:(Ljava/lang/String;Lcom/clevertap/android/sdk/PushType;)V:GetDevicePushTokenDidRefresh_Ljava_lang_String_Lcom_clevertap_android_sdk_PushType_Handler:Com.Clevertap.Android.Sdk.CleverTapAPI/IDevicePushTokenRefreshListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.CleverTapAPI+IDevicePushTokenRefreshListenerImplementor, CleverTap.Bindings.Android", CleverTapAPI_DevicePushTokenRefreshListenerImplementor.class, __md_methods);
	}


	public CleverTapAPI_DevicePushTokenRefreshListenerImplementor ()
	{
		super ();
		if (getClass () == CleverTapAPI_DevicePushTokenRefreshListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.CleverTapAPI+IDevicePushTokenRefreshListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void devicePushTokenDidRefresh (java.lang.String p0, com.clevertap.android.sdk.PushType p1)
	{
		n_devicePushTokenDidRefresh (p0, p1);
	}

	private native void n_devicePushTokenDidRefresh (java.lang.String p0, com.clevertap.android.sdk.PushType p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
