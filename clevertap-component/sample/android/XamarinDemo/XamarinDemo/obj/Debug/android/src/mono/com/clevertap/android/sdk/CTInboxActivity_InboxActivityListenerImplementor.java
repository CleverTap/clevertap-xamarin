package mono.com.clevertap.android.sdk;


public class CTInboxActivity_InboxActivityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.CTInboxActivity.InboxActivityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_messageDidClick:(Lcom/clevertap/android/sdk/CTInboxActivity;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;Ljava/util/HashMap;)V:GetMessageDidClick_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Ljava_util_HashMap_Handler:Com.Clevertap.Android.Sdk.CTInboxActivity/IInboxActivityListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_messageDidShow:(Lcom/clevertap/android/sdk/CTInboxActivity;Lcom/clevertap/android/sdk/CTInboxMessage;Landroid/os/Bundle;)V:GetMessageDidShow_Lcom_clevertap_android_sdk_CTInboxActivity_Lcom_clevertap_android_sdk_CTInboxMessage_Landroid_os_Bundle_Handler:Com.Clevertap.Android.Sdk.CTInboxActivity/IInboxActivityListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.CTInboxActivity+IInboxActivityListenerImplementor, CleverTap.Bindings.Android", CTInboxActivity_InboxActivityListenerImplementor.class, __md_methods);
	}


	public CTInboxActivity_InboxActivityListenerImplementor ()
	{
		super ();
		if (getClass () == CTInboxActivity_InboxActivityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.CTInboxActivity+IInboxActivityListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public void messageDidClick (com.clevertap.android.sdk.CTInboxActivity p0, com.clevertap.android.sdk.CTInboxMessage p1, android.os.Bundle p2, java.util.HashMap p3)
	{
		n_messageDidClick (p0, p1, p2, p3);
	}

	private native void n_messageDidClick (com.clevertap.android.sdk.CTInboxActivity p0, com.clevertap.android.sdk.CTInboxMessage p1, android.os.Bundle p2, java.util.HashMap p3);


	public void messageDidShow (com.clevertap.android.sdk.CTInboxActivity p0, com.clevertap.android.sdk.CTInboxMessage p1, android.os.Bundle p2)
	{
		n_messageDidShow (p0, p1, p2);
	}

	private native void n_messageDidShow (com.clevertap.android.sdk.CTInboxActivity p0, com.clevertap.android.sdk.CTInboxMessage p1, android.os.Bundle p2);

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
