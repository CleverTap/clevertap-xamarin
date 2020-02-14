package mono.com.clevertap.android.sdk.ab_testing.gesture;


public class ConnectionGesture_OnGestureListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.ab_testing.gesture.ConnectionGesture.OnGestureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGesture:()V:GetOnGestureHandler:Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture/IOnGestureListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture+IOnGestureListenerImplementor, CleverTap.Bindings.Android", ConnectionGesture_OnGestureListenerImplementor.class, __md_methods);
	}


	public ConnectionGesture_OnGestureListenerImplementor ()
	{
		super ();
		if (getClass () == ConnectionGesture_OnGestureListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.Ab_testing.Gesture.ConnectionGesture+IOnGestureListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void onGesture ()
	{
		n_onGesture ();
	}

	private native void n_onGesture ();

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
