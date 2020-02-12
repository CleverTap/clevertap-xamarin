package mono.com.clevertap.android.sdk;


public class SyncListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.SyncListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_profileDataUpdated:(Lorg/json/JSONObject;)V:GetProfileDataUpdated_Lorg_json_JSONObject_Handler:Com.Clevertap.Android.Sdk.ISyncListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_profileDidInitialize:(Ljava/lang/String;)V:GetProfileDidInitialize_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.ISyncListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.ISyncListenerImplementor, CleverTap.Bindings.Android", SyncListenerImplementor.class, __md_methods);
	}


	public SyncListenerImplementor ()
	{
		super ();
		if (getClass () == SyncListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.ISyncListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void profileDataUpdated (org.json.JSONObject p0)
	{
		n_profileDataUpdated (p0);
	}

	private native void n_profileDataUpdated (org.json.JSONObject p0);


	public void profileDidInitialize (java.lang.String p0)
	{
		n_profileDidInitialize (p0);
	}

	private native void n_profileDidInitialize (java.lang.String p0);

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
