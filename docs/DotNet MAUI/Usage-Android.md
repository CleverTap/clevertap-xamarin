# Example Usage

### Init Clevertap
```c#
CleverTapAPI cleverTapInstance = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
```

### Recording events
- Recording a User Event called Product Viewed.

```c#
cleverTapInstance.PushEvent("Product View Via DotNet");
```

- Recording a User Event called Product Viewed with custom properties
```c#
IDictionary<string, Java.Lang.Object> prodViewedProperties = new Dictionary<string, Java.Lang.Object>
{
    { "Product Name", "Casio Chronograph Watch" },
    { "Category", "Mens Accessories" },
    { "Price", 59.99 }, // Ensure price is double
    { "Date", new Date()} // Use DateTime for current date
};
cleverTapInstance.PushEvent("Product viewed", prodViewedProperties);
```

-  Recording a Charged Event
> ⚠️ **NOTE**
Currently Clevertap only supports Charged Event with an empty items list for DotNet

```c#
IDictionary<string, Java.Lang.Object> chargedDetails = new Dictionary<string, Java.Lang.Object>();
chargedDetails.Add("Total Amount", 400);

List<IDictionary<string, Java.Lang.Object>> items = new List<IDictionary<string, Java.Lang.Object>>{};

cleverTapInstance.PushChargedEvent(chargedDetails, items);
```

### User Profile Management
For more details, refer to [CleverTap User Profiles](https://developer.clevertap.com/docs/concepts-user-profiles#section-overview).

- Using `pushProfile`

```c#
IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

profileData.Add("Name", "user1");    // String
profileData.Add("Identity", 97839492);      // String or number
profileData.Add("Email", "user1@gmail.com"); // Email address of the user
profileData.Add("Phone", "7012801820919");   // Phone (with the country code, starting with +)
profileData.Add("Gender", "M");             // Can be either M or F
profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util

cleverTapInstance.PushProfile(profileData);
```

- Using `onUserLogin`

```c#
IDictionary<string, Java.Lang.Object> profile = new Dictionary<string, Java.Lang.Object>();

profile.Add("Name", "user2");    // String
profile.Add("Identity", 321323112);      // String or number
profile.Add("Email", "user2@gmail.com"); // Email address of the user
profile.Add("Phone", "1212");   // Phone (with the country code, starting with +)
profile.Add("Gender", "M");               // Can be either M or F
profile.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util

cleverTapInstance.OnUserLogin(profile);
```

### Push Notifications
#### Setup
1. Add `Xamarin.Firebase.Messaging` and `Xamarin.GooglePlayServices.Base` to the NuGet Packages.
2. Add `google-services.json` file to your project. For more details, refer to [Firebase Cloud Messaging setup](https://docs.microsoft.com/en-us/xamarin/android/data-cloud/google-messaging/firebase-cloud-messaging).
3. Create a class that extends `FirebaseMessagingService`. This class is responsible for creating a notification, recording push impressions and registering FCM token.
```c#
using Android.Util;
using Firebase.Messaging;
using Com.Clevertap.Android.Sdk;
using Com.Clevertap.Android.Sdk.Pushnotification;

namespace androiddemo
{
    [Service(Exported = true)]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        const string TAG = "MyFirebaseMessagingService";
        public override void OnMessageReceived(RemoteMessage message)
        {
            Log.Debug(TAG, "From: " + message.From);

            //Step 1: parsing message to bundle
            Bundle bundle = new Bundle();
            foreach (KeyValuePair<string, string> entry in message.Data)
            {
                bundle.PutString(entry.Key, entry.Value);
            }
            Log.Debug(TAG, "Notification Message Body: " + bundle);

            //Step 2: Creating Notification
            CleverTapAPI.CreateNotification(this, bundle);

            //Step 3: Raising push impression
            cleverTapInstance.PushNotificationViewedEvent(bundle);
        }

        public override void OnNewToken(string token)
        {
            Log.Debug(TAG, "Refreshed token: " + token);
            CleverTapAPI.TokenRefresh(this, token, IPushConstants.PushType.Fcm);
        }
    }
}
```
4. Register the above service, inside the `<application>` tag in `AndroidManifest.xml`
```xml
<service
    android:name="androiddemo.MyFirebaseMessagingService"
    android:exported="true">
    <intent-filter>
        <action android:name="com.google.firebase.MESSAGING_EVENT" />
    </intent-filter>
</service>
```

#### Notification Channels

- Creating a notification channel
```c#
CleverTapAPI.CreateNotificationChannel(Android.App.Application.Context, "YourChannelId", "Your Channel Name", "Your Channel Description", 5, true);

//Creating a Channel Group
CleverTapAPI.CreateNotificationChannelGroup(Android.App.Application.Context, "YourGroupId", "Your Group Name");
```

- Deleting a notification channel
```c#
CleverTapAPI.DeleteNotificationChannel(Android.App.Application.Context, "YourChannelId");

//Deleting a Channel Group
CleverTapAPI.DeleteNotificationChannelGroup(Android.App.Application.Context, "YourGroupId");
```

#### Pull Notifications

The SDK supports Pull Notifications. Pull Notifications is a capability that
allows you to reach users on devices which suppress notifications via GCM/FCM. To allow your app to
use CleverTap's Pull Notifications via background ping service, add the following fields in your
app's `AndroidManifest.xml`

```xml
<meta-data
    android:name="CLEVERTAP_BACKGROUND_SYNC"
    android:value="1"/>
```


### App Inbox

#### Initializing the App Inbox
```c#
cleverTapInstance.InitializeInbox();
```

#### Configure Styling and Showing the App Inbox
```c#
IList<string> tabs = new List<string>();
tabs.Add("Promotions");
tabs.Add("Offers");
tabs.Add("Others");//We support upto 2 tabs only. Additional tabs will be ignored

CTInboxStyleConfig styleConfig = new CTInboxStyleConfig();
styleConfig.Tabs = tabs;//Do not use this if you don't want to use tabs
styleConfig.TabBackgroundColor= "#FF0000";//provide Hex code in string ONLY
styleConfig.SelectedTabIndicatorColor="#0000FF";
styleConfig.SelectedTabColor = "#000000";
styleConfig.UnselectedTabColor = "#FFFFFF";
styleConfig.BackButtonColor = "#FF0000";
styleConfig.NavBarTitleColor = "#FF0000";
styleConfig.NavBarTitle = "MY INBOX";
styleConfig.NavBarColor = "#FFFFFF";
styleConfig.InboxBackgroundColor = "#00FF00";

cleverTapInstance.ShowAppInbox(styleConfig); //Opens activity with Tabs
//OR
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).ShowAppInbox();//Opens Activity with default style config
```

#### App Inbox Callbacks
1. Registering the Listeners
```c#
public class MainActivity : FragmentActivity, ICTInboxListener, IInboxMessageButtonListener, IInboxMessageListener
{
    protected override void OnResume() {
        cleverTapInstance.CTNotificationInboxListener = this;
        cleverTapInstance.SetInboxMessageButtonListener(this);
        cleverTapInstance.SetCTInboxMessageListener(this);
    }
}
```

2. Implementing the Interface Members
```c#
// This callback is triggered when the Inbox is initialised
public void InboxDidInitialize()
{
    Log.Debug(TAG, "Inbox Initialized");
}

// This callbacks notifies about idUpdate()
{
    Log.Debug(TAG, "Inbox Updated");
}

// This callback is triggered when an inbox button is clicked
public void OnInboxButtonClick(IDictionary<string, string> payload)
{
    Log.Debug("CLEVERTAP", "Inbox Button Clicked");
}

/**
* This callback is triggered when:
*    - App Inbox item click
*    - CTA clicks for which no custom key-value pairs are associated, i.e., DeepLink and Clipboard CTAs.
*/
public void OnInboxItemClicked(CTInboxMessage? message, int contentPageIndex, int buttonIndex)
{
    Log.Debug("CLEVERTAP", "Inbox Item Clicked");
}
```

#### Dismissing the App Inbox
Use the following method to dismiss the App Inbox Activity as per your business use case -

```c#
cleverTapInstance.DismissAppInbox();
```

#### App Inbox with Audio/Video Messages
To support audio/video inbox messages add the following dependencies to the NuGet Packages. Audio/Video messages will be dropped without these dependencies
1. `Xam.Plugins.Android.ExoPlayer`
2. `Xam.Plugins.Android.ExoPlayer.Hls`
3. `Xam.Plugins.Android.ExoPlayer.UI`

#### Creating your own App Inbox

You can choose to create your own App Inbox with the help of the following APIs -

```c#
//Initialize App Inbox
cleverTapInstance.InitializeInbox();

//Get Inbox Message Count
cleverTapInstance.GetInboxMessageCount();

//Get Inbox Unread Count
cleverTapInstance.GetInboxMessageUnreadCount();

//Get All messages
cleverTapInstance.GetAllInboxMessages();

//Get only Unread messages
cleverTapInstance.GetUnreadInboxMessages();

//Get message object belonging to the given message id only. Message id should be a String
cleverTapInstance.GetInboxMessageForId(messageId);

//Delete message from the Inbox. Message id should be a String
cleverTapInstance.DeleteInboxMessage(messageId);

//Delete message from the Inbox. Message should object of CTInboxMessage
cleverTapInstance.DeleteInboxMessage(message);

//Mark Message as Read. Message id should be a String
cleverTapInstance.MarkReadInboxMessage(messageId);

//Mark message as Read. Message should object of CTInboxMessage
cleverTapInstance.MarkReadInboxMessage(message);

//Raise Notification Viewed event for Inbox Message. Message id should be a String
cleverTapInstance.PushInboxNotificationViewedEvent(messageId);

//Raise Notification Clicked event for Inbox Message. Message id should be a String
cleverTapInstance.PushInboxNotificationClickedEvent(messageId);
```

### In-App Notifications
To use Header & Footer InApp Notification Templates of CleverTap, the `MainActivity` must inherit the `FragmentActivity`
```c#
public class MainActivity : FragmentActivity {}
```

#### CleverTap In-App Callbacks
1. Registering the Listeners
```c#
public class MainActivity : FragmentActivity, IInAppNotificationButtonListener, IInAppNotificationListener
{
    protected override void OnResume() {
        cleverTapInstance.InAppNotificationListener = this;
        cleverTapInstance.SetInAppNotificationButtonListener(this);
    }
}
```

2. Implementing the Interface Members
```c#

/**
 * This callback is triggered when an InApp notification is about to be rendered.
 * If you'd like this notification to not be rendered, then return false.
 * Returning true will cause this notification to be rendered immediately.
 */
public bool BeforeShow(IDictionary<string, Object>? extras)
{
    Log.Debug("CLEVERTAP", "InApp BeforeShow");
    return true;
}

/**
 * This callback is triggered when an InApp is dismissed (either by the close button, or a call to action),
 */
public void OnDismissed(IDictionary<string, Object>? extras, IDictionary<string, Object>? actionExtras)
{
    Log.Debug("CLEVERTAP", "InApp onDismissed");
}

// This callback is triggered when an InApp notification is rendered.
public void OnShow(CTInAppNotification notif)
{
    Log.Debug("CLEVERTAP", "InApp onShow");
}

// This callback is triggered when the InApp button is clicked
public void OnInAppButtonClick(IDictionary<string, string>? payload)
{
    Log.Debug(TAG, "InApp Button Clicked");
}
```


For more advanced features, refer to the [Android Advanced Features](https://developer.clevertap.com/docs/android-advanced-features) documentation for detailed guidance and inspiration



