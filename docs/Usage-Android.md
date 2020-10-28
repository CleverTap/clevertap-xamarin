# Example Usage

### Init Clevertap
```c#
CleverTapAPI cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
```

### Record an event
 An example of recording a User Event called Product Viewed.

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).PushEvent("Product View Via Xamarin");
```

### Record Charged Event
 An example of recording a Charged Event, more details [here](https://developer.clevertap.com/docs/concepts-events#section-recording-customer-purchases).

```c#
IDictionary<string, Java.Lang.Object> chargedDetails = new Dictionary<string, Java.Lang.Object>();
chargedDetails.Add("Total Amount", 400);

IDictionary<string, Java.Lang.Object> item1 = new Dictionary<string, Java.Lang.Object>();
item1.Add("Product Name", "Harry Potter");
item1.Add("ProductID", "4756");
item1.Add("Price", 300);

IDictionary<string, Java.Lang.Object> item2 = new Dictionary<string, Java.Lang.Object>();
item2.Add("Product Name", "Harry Potter 2");
item2.Add("ProductID", "4776");
item2.Add("Price", 100);

List<IDictionary<string, Java.Lang.Object>> items = new List<IDictionary<string, Java.Lang.Object>>();
items.Add(item1);
items.Add(item2);

CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).PushChargedEvent(chargedDetails, items);
```

### Update a user profile

- Using `pushProfile`

```c#
IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

profileData.Add("Name", "user1");    // String
profileData.Add("Identity", 97839492);      // String or number
profileData.Add("Email", "user1@gmail.com"); // Email address of the user
profileData.Add("Phone", "7012801820919");   // Phone (with the country code, starting with +)
profileData.Add("Gender", "M");             // Can be either M or F
profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util

CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).PushProfile(profileData);
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

CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).OnUserLogin(profile);
```

Note: Please go through our documentation on handling [user profile](https://developer.clevertap.com/docs/concepts-user-profiles#section-overview).

### Notification
- `Channel creation`

```c#
CleverTapAPI.CreateNotificationChannel(Android.App.Application.Context, "YourChannelId", "Your Channel Name", "Your Channel Description", 5, true);
//Create Channel Group
CleverTapAPI.CreateNotificationChannelGroup(Android.App.Application.Context, "YourGroupId", "Your Group Name");
```

- `FCM Integration` [Refer](https://docs.microsoft.com/en-us/xamarin/android/data-cloud/google-messaging/firebase-cloud-messaging)

- `Sending FCM Token to Server`

```c#
var instanceIdResult = await FirebaseInstanceId.Instance.GetInstanceId().AsAsync<IInstanceIdResult>();
string token = instanceIdResult.Token;

CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).PushFcmRegistrationId(token, true);
```

- `Notification Creation & Push Impression`

```c#
// Notification message received in your FirebaseMessagingService subclass implementation.
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
     CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).PushNotificationViewedEvent(SampleExtras);
}
```

### App Inbox

- `Initialize the CleverTap App Inbox Method`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).InitializeInbox();
```

- `Registeration CleverTap App Inbox Method Callbacks`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).CTNotificationInboxListener = this;
```

- `CleverTap App Inbox Button Callbacks`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).SetInboxMessageButtonListener(this);
```

- `Present App Inbox`

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

CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).ShowAppInbox(styleConfig); //Opens activity with Tabs
//OR
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).ShowAppInbox();//Opens Activity with default style config
```

##### Dynamic Variable

- `Callback Registration`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).CTExperimentsListener = this;
```

##### Feature Flag 

- `Callbacks Registration`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).SetCTFeatureFlagsListener(this);
```

##### Product Config

- `Callback Registration`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).SetCTProductConfigListener(this);
```

- `Fetch`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).ProductConfig().Fetch();
```

- `Activate`

```c#
CleverTapAPI.GetDefaultInstance(Android.App.Application.Context).ProductConfig().Activate();
```
