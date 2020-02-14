package crc64876e1fb53e77978f;


public class MainActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.CTInboxListener,
		com.clevertap.android.sdk.CTExperimentsListener,
		com.clevertap.android.sdk.displayunits.DisplayUnitListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateOptionsMenu:(Landroid/view/Menu;)Z:GetOnCreateOptionsMenu_Landroid_view_Menu_Handler\n" +
			"n_onOptionsItemSelected:(Landroid/view/MenuItem;)Z:GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_inboxDidInitialize:()V:GetInboxDidInitializeHandler:Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_inboxMessagesDidUpdate:()V:GetInboxMessagesDidUpdateHandler:Com.Clevertap.Android.Sdk.ICTInboxListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_CTExperimentsUpdated:()V:GetCTExperimentsUpdatedHandler:Com.Clevertap.Android.Sdk.ICTExperimentsListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onDisplayUnitsLoaded:(Ljava/util/ArrayList;)V:GetOnDisplayUnitsLoaded_Ljava_util_ArrayList_Handler:Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("XamarinDemo.MainActivity, XamarinDemo", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("XamarinDemo.MainActivity, XamarinDemo", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onCreateOptionsMenu (android.view.Menu p0)
	{
		return n_onCreateOptionsMenu (p0);
	}

	private native boolean n_onCreateOptionsMenu (android.view.Menu p0);


	public boolean onOptionsItemSelected (android.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (android.view.MenuItem p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


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


	public void CTExperimentsUpdated ()
	{
		n_CTExperimentsUpdated ();
	}

	private native void n_CTExperimentsUpdated ();


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
