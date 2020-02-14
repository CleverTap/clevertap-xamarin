package mono.com.clevertap.android.sdk;


public class CTExperimentsListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.CTExperimentsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_CTExperimentsUpdated:()V:GetCTExperimentsUpdatedHandler:Com.Clevertap.Android.Sdk.ICTExperimentsListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor, CleverTap.Bindings.Android", CTExperimentsListenerImplementor.class, __md_methods);
	}


	public CTExperimentsListenerImplementor ()
	{
		super ();
		if (getClass () == CTExperimentsListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.ICTExperimentsListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void CTExperimentsUpdated ()
	{
		n_CTExperimentsUpdated ();
	}

	private native void n_CTExperimentsUpdated ();

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
