package mono.com.clevertap.android.sdk;


public class InAppNotificationListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.InAppNotificationListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_beforeShow:(Ljava/util/Map;)Z:GetBeforeShow_Ljava_util_Map_Handler:Com.Clevertap.Android.Sdk.IInAppNotificationListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onDismissed:(Ljava/util/Map;Ljava/util/Map;)V:GetOnDismissed_Ljava_util_Map_Ljava_util_Map_Handler:Com.Clevertap.Android.Sdk.IInAppNotificationListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor, CleverTap.Bindings.Android", InAppNotificationListenerImplementor.class, __md_methods);
	}


	public InAppNotificationListenerImplementor ()
	{
		super ();
		if (getClass () == InAppNotificationListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.IInAppNotificationListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public boolean beforeShow (java.util.Map p0)
	{
		return n_beforeShow (p0);
	}

	private native boolean n_beforeShow (java.util.Map p0);


	public void onDismissed (java.util.Map p0, java.util.Map p1)
	{
		n_onDismissed (p0, p1);
	}

	private native void n_onDismissed (java.util.Map p0, java.util.Map p1);

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
