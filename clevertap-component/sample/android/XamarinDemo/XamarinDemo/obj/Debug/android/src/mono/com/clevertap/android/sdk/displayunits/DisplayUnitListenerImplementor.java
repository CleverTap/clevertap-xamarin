package mono.com.clevertap.android.sdk.displayunits;


public class DisplayUnitListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.displayunits.DisplayUnitListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDisplayUnitsLoaded:(Ljava/util/ArrayList;)V:GetOnDisplayUnitsLoaded_Ljava_util_ArrayList_Handler:Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerImplementor, CleverTap.Bindings.Android", DisplayUnitListenerImplementor.class, __md_methods);
	}


	public DisplayUnitListenerImplementor ()
	{
		super ();
		if (getClass () == DisplayUnitListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void onDisplayUnitsLoaded (java.util.ArrayList p0)
	{
		n_onDisplayUnitsLoaded (p0);
	}

	private native void n_onDisplayUnitsLoaded (java.util.ArrayList p0);

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
