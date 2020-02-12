package mono.com.clevertap.android.sdk.ab_testing;


public class CTABTestListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.ab_testing.CTABTestListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_ABExperimentsUpdated:()V:GetABExperimentsUpdatedHandler:Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListenerImplementor, CleverTap.Bindings.Android", CTABTestListenerImplementor.class, __md_methods);
	}


	public CTABTestListenerImplementor ()
	{
		super ();
		if (getClass () == CTABTestListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.Ab_testing.ICTABTestListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void ABExperimentsUpdated ()
	{
		n_ABExperimentsUpdated ();
	}

	private native void n_ABExperimentsUpdated ();

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
