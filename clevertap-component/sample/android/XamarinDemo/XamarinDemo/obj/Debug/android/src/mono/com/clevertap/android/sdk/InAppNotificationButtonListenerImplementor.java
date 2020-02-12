package mono.com.clevertap.android.sdk;


public class InAppNotificationButtonListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.InAppNotificationButtonListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInAppButtonClick:(Ljava/util/HashMap;)V:GetOnInAppButtonClick_Ljava_util_HashMap_Handler:Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor, CleverTap.Bindings.Android", InAppNotificationButtonListenerImplementor.class, __md_methods);
	}


	public InAppNotificationButtonListenerImplementor ()
	{
		super ();
		if (getClass () == InAppNotificationButtonListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.IInAppNotificationButtonListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void onInAppButtonClick (java.util.HashMap p0)
	{
		n_onInAppButtonClick (p0);
	}

	private native void n_onInAppButtonClick (java.util.HashMap p0);

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
