package mono.com.clevertap.android.sdk;


public class InboxMessageButtonListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.InboxMessageButtonListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInboxButtonClick:(Ljava/util/HashMap;)V:GetOnInboxButtonClick_Ljava_util_HashMap_Handler:Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor, CleverTap.Bindings.Android", InboxMessageButtonListenerImplementor.class, __md_methods);
	}


	public InboxMessageButtonListenerImplementor ()
	{
		super ();
		if (getClass () == InboxMessageButtonListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.IInboxMessageButtonListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void onInboxButtonClick (java.util.HashMap p0)
	{
		n_onInboxButtonClick (p0);
	}

	private native void n_onInboxButtonClick (java.util.HashMap p0);

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
