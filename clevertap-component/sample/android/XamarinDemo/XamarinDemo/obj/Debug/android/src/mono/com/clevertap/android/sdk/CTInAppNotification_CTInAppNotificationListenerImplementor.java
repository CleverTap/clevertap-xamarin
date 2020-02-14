package mono.com.clevertap.android.sdk;


public class CTInAppNotification_CTInAppNotificationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.CTInAppNotification.CTInAppNotificationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_notificationReady:(Lcom/clevertap/android/sdk/CTInAppNotification;)V:GetNotificationReady_Lcom_clevertap_android_sdk_CTInAppNotification_Handler:Com.Clevertap.Android.Sdk.CTInAppNotification/ICTInAppNotificationListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.CTInAppNotification+ICTInAppNotificationListenerImplementor, CleverTap.Bindings.Android", CTInAppNotification_CTInAppNotificationListenerImplementor.class, __md_methods);
	}


	public CTInAppNotification_CTInAppNotificationListenerImplementor ()
	{
		super ();
		if (getClass () == CTInAppNotification_CTInAppNotificationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.CTInAppNotification+ICTInAppNotificationListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void notificationReady (com.clevertap.android.sdk.CTInAppNotification p0)
	{
		n_notificationReady (p0);
	}

	private native void n_notificationReady (com.clevertap.android.sdk.CTInAppNotification p0);

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
