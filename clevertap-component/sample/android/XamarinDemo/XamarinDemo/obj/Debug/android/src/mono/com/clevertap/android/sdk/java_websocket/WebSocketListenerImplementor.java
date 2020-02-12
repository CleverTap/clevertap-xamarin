package mono.com.clevertap.android.sdk.java_websocket;


public class WebSocketListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.clevertap.android.sdk.java_websocket.WebSocketListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getLocalSocketAddress:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;:GetGetLocalSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_getRemoteSocketAddress:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)Ljava/net/InetSocketAddress;:GetGetRemoteSocketAddress_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketClose:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V:GetOnWebsocketClose_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketCloseInitiated:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;)V:GetOnWebsocketCloseInitiated_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketClosing:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;ILjava/lang/String;Z)V:GetOnWebsocketClosing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_ILjava_lang_String_ZHandler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketError:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/Exception;)V:GetOnWebsocketError_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_Exception_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketHandshakeReceivedAsClient:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshake;)V:GetOnWebsocketHandshakeReceivedAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Lcom_clevertap_android_sdk_java_websocket_handshake_ServerHandshake_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketHandshakeReceivedAsServer:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/drafts/Draft;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)Lcom/clevertap/android/sdk/java_websocket/handshake/ServerHandshakeBuilder;:GetOnWebsocketHandshakeReceivedAsServer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_drafts_Draft_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketHandshakeSentAsClient:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/ClientHandshake;)V:GetOnWebsocketHandshakeSentAsClient_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_ClientHandshake_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketMessage:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/lang/String;)V:GetOnWebsocketMessage_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_lang_String_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketMessageBuffer:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Ljava/nio/ByteBuffer;)V:GetOnWebsocketMessageBuffer_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Ljava_nio_ByteBuffer_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketOpen:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/handshake/Handshakedata;)V:GetOnWebsocketOpen_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_handshake_Handshakedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketPing:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V:GetOnWebsocketPing_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWebsocketPong:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;Lcom/clevertap/android/sdk/java_websocket/framing/Framedata;)V:GetOnWebsocketPong_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Lcom_clevertap_android_sdk_java_websocket_framing_Framedata_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"n_onWriteDemand:(Lcom/clevertap/android/sdk/java_websocket/WebSocket;)V:GetOnWriteDemand_Lcom_clevertap_android_sdk_java_websocket_WebSocket_Handler:Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerInvoker, CleverTap.Bindings.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerImplementor, CleverTap.Bindings.Android", WebSocketListenerImplementor.class, __md_methods);
	}


	public WebSocketListenerImplementor ()
	{
		super ();
		if (getClass () == WebSocketListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Clevertap.Android.Sdk.Java_websocket.IWebSocketListenerImplementor, CleverTap.Bindings.Android", "", this, new java.lang.Object[] {  });
	}


	public java.net.InetSocketAddress getLocalSocketAddress (com.clevertap.android.sdk.java_websocket.WebSocket p0)
	{
		return n_getLocalSocketAddress (p0);
	}

	private native java.net.InetSocketAddress n_getLocalSocketAddress (com.clevertap.android.sdk.java_websocket.WebSocket p0);


	public java.net.InetSocketAddress getRemoteSocketAddress (com.clevertap.android.sdk.java_websocket.WebSocket p0)
	{
		return n_getRemoteSocketAddress (p0);
	}

	private native java.net.InetSocketAddress n_getRemoteSocketAddress (com.clevertap.android.sdk.java_websocket.WebSocket p0);


	public void onWebsocketClose (com.clevertap.android.sdk.java_websocket.WebSocket p0, int p1, java.lang.String p2, boolean p3)
	{
		n_onWebsocketClose (p0, p1, p2, p3);
	}

	private native void n_onWebsocketClose (com.clevertap.android.sdk.java_websocket.WebSocket p0, int p1, java.lang.String p2, boolean p3);


	public void onWebsocketCloseInitiated (com.clevertap.android.sdk.java_websocket.WebSocket p0, int p1, java.lang.String p2)
	{
		n_onWebsocketCloseInitiated (p0, p1, p2);
	}

	private native void n_onWebsocketCloseInitiated (com.clevertap.android.sdk.java_websocket.WebSocket p0, int p1, java.lang.String p2);


	public void onWebsocketClosing (com.clevertap.android.sdk.java_websocket.WebSocket p0, int p1, java.lang.String p2, boolean p3)
	{
		n_onWebsocketClosing (p0, p1, p2, p3);
	}

	private native void n_onWebsocketClosing (com.clevertap.android.sdk.java_websocket.WebSocket p0, int p1, java.lang.String p2, boolean p3);


	public void onWebsocketError (com.clevertap.android.sdk.java_websocket.WebSocket p0, java.lang.Exception p1)
	{
		n_onWebsocketError (p0, p1);
	}

	private native void n_onWebsocketError (com.clevertap.android.sdk.java_websocket.WebSocket p0, java.lang.Exception p1);


	public void onWebsocketHandshakeReceivedAsClient (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake p1, com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake p2)
	{
		n_onWebsocketHandshakeReceivedAsClient (p0, p1, p2);
	}

	private native void n_onWebsocketHandshakeReceivedAsClient (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake p1, com.clevertap.android.sdk.java_websocket.handshake.ServerHandshake p2);


	public com.clevertap.android.sdk.java_websocket.handshake.ServerHandshakeBuilder onWebsocketHandshakeReceivedAsServer (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.drafts.Draft p1, com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake p2)
	{
		return n_onWebsocketHandshakeReceivedAsServer (p0, p1, p2);
	}

	private native com.clevertap.android.sdk.java_websocket.handshake.ServerHandshakeBuilder n_onWebsocketHandshakeReceivedAsServer (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.drafts.Draft p1, com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake p2);


	public void onWebsocketHandshakeSentAsClient (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake p1)
	{
		n_onWebsocketHandshakeSentAsClient (p0, p1);
	}

	private native void n_onWebsocketHandshakeSentAsClient (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.handshake.ClientHandshake p1);


	public void onWebsocketMessage (com.clevertap.android.sdk.java_websocket.WebSocket p0, java.lang.String p1)
	{
		n_onWebsocketMessage (p0, p1);
	}

	private native void n_onWebsocketMessage (com.clevertap.android.sdk.java_websocket.WebSocket p0, java.lang.String p1);


	public void onWebsocketMessageBuffer (com.clevertap.android.sdk.java_websocket.WebSocket p0, java.nio.ByteBuffer p1)
	{
		n_onWebsocketMessageBuffer (p0, p1);
	}

	private native void n_onWebsocketMessageBuffer (com.clevertap.android.sdk.java_websocket.WebSocket p0, java.nio.ByteBuffer p1);


	public void onWebsocketOpen (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.handshake.Handshakedata p1)
	{
		n_onWebsocketOpen (p0, p1);
	}

	private native void n_onWebsocketOpen (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.handshake.Handshakedata p1);


	public void onWebsocketPing (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.framing.Framedata p1)
	{
		n_onWebsocketPing (p0, p1);
	}

	private native void n_onWebsocketPing (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.framing.Framedata p1);


	public void onWebsocketPong (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.framing.Framedata p1)
	{
		n_onWebsocketPong (p0, p1);
	}

	private native void n_onWebsocketPong (com.clevertap.android.sdk.java_websocket.WebSocket p0, com.clevertap.android.sdk.java_websocket.framing.Framedata p1);


	public void onWriteDemand (com.clevertap.android.sdk.java_websocket.WebSocket p0)
	{
		n_onWriteDemand (p0);
	}

	private native void n_onWriteDemand (com.clevertap.android.sdk.java_websocket.WebSocket p0);

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
