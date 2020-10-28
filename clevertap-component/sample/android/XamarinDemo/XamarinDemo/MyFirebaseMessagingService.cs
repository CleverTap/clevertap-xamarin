using Android.App;
using Android.Util;
using Firebase.Messaging;
using Com.Clevertap.Android.Sdk;
using Com.Clevertap.Android.Sdk.Pushnotification;
using System.Collections.Generic;
using Android.OS;

namespace XamarinDemo
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMessagingService";
        public override void OnMessageReceived(RemoteMessage message)
        {
            Log.Debug(TAG, "From: " + message.From);
            Bundle bundle = new Bundle();
            foreach (KeyValuePair<string, string> entry in message.Data)
            {
                bundle.PutString(entry.Key, entry.Value);
            }
            Log.Debug(TAG, "Notification Message Body: " + bundle);
            CleverTapAPI.CreateNotification(this,bundle);
        }

        public override void OnNewToken(string token)
        {
            Log.Debug(TAG, "Refreshed token: " + token);
            SendRegistrationToServer(token);
        }

        void SendRegistrationToServer(string token)
        {
            CleverTapAPI.TokenRefresh(this, token, PushConstantsPushType.Fcm);
            // Add custom implementation, as needed.
        }
    }
}
