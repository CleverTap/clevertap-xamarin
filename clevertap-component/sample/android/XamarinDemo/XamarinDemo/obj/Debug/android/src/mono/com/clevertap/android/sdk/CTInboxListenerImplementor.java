package mono.com.clevertap.android.sdk;


public class CTInboxListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.CTInboxListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_inboxDidInitialize:()V:GetInboxDidInitializeHandler:Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_inboxMessagesDidUpdate:()V:GetInboxMessagesDidUpdateHandler:Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor, CleverTap.Bindings.Android", CTInboxListenerImplementor.class, __md_methods);
	}


	public CTInboxListenerImplementor ()
	{
		super ();
		if (getClass () == CTInboxListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.ICTInboxListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void inboxDidInitialize ()
	{
		n_inboxDidInitialize ();
	}

	private native void n_inboxDidInitialize ();


	public void inboxMessagesDidUpdate ()
	{
		n_inboxMessagesDidUpdate ();
	}

	private native void n_inboxMessagesDidUpdate ();

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
