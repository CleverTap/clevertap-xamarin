# Example Usage (DotNet)

## Recording Events

### Record an event
 An example of recording a User Event called Product Viewed.

```c#
CleverTap.SharedInstance()?.RecordEvent("Product Viewed");
```

### Record an event with properties
An example of recording a User Event called Product Viewed with custom properties.

```c#
var item = new NSDictionary(
    new NSString("Product Name"), new NSString("Hacking with Swift"),
    new NSString("ProductID"), new NSNumber(556),
    new NSString("Price"), new NSNumber(1000)
);
CleverTap.SharedInstance()?.RecordEvent("Product Viewed", properties: item);
```

### Record a Charged Event without items
An example of recording a Charged Event with empty items.

```c#
var chargedDetails = new NSDictionary(
  new NSString("Total Amount"), new NSNumber(100)
);

CleverTap.SharedInstance()?.RecordChargedEventWithDetails(chargedDetails, []);
```

### Record a Charged Event with items
An example of recording a Charged Event with non-empty items.

```c#
var chargedDetails = new NSDictionary(
  new NSString("Total Amount"), new NSNumber(100)
);

var item1 = new NSDictionary(
 new NSString("Product Name"), new NSString("Hacking with Swift"),
 new NSString("ProductID"), new NSNumber(556),
 new NSString("Price"), new NSNumber(1000)
);
var item2 = new NSDictionary(
 new NSString("Product Name"), new NSString("Programming in Objective C"),
 new NSString("ProductID"), new NSNumber(956),
 new NSString("Price"), new NSNumber(700)
);

var items = new[] { item1, item2 };
CleverTap.SharedInstance()?.RecordChargedEventWithDetails(chargedDetails, items);
```

## User Profile Management
For more details, refer to [CleverTap User Profiles](https://developer.clevertap.com/docs/concepts-user-profiles#section-overview).

### Update a user profile using ProfilePush

```c#
var profileData = new NSDictionary(
    new NSString("Name"), new NSString("Jack Montana"),
    new NSString("Identity"), new NSString("61026032"),
    new NSString("Email"), new NSString("jackmontana@gmail.com"),
    new NSString("Phone"), new NSString("14155551112"),
    new NSString("Gender"), new NSString("M"),
    new NSString("DOB"), new NSDate()
);
CleverTap.SharedInstance()?.ProfilePush(profileData);
```

### Update a user profile using OnUserLogin

```c#
var profileData = new NSDictionary(
    new NSString("Name"), new NSString("Jack Montana"),
    new NSString("Identity"), new NSString("61026032"),
    new NSString("Email"), new NSString("jackmontana@gmail.com"),
    new NSString("Phone"), new NSString("14155551112"),
    new NSString("Gender"), new NSString("M"),
    new NSString("DOB"), new NSDate()
);
CleverTap.SharedInstance()?.OnUserLogin(profileData);
```

## App Inbox

### Initialize the CleverTap App Inbox Method

```c#
CleverTap.SharedInstance()?.InitializeInboxWithCallback((bool success) => {
    if (success) {
        Console.WriteLine("App Inbox Initialised.");
     }
});
```

### Present App Inbox 

```c#
var style = new CleverTapInboxStyleConfig();
var tags = new[] {
    new NSString("Tag1"),
    new NSString("Tag2")
};
style.MessageTags = tags;
style.Title = "App Inbox";
style.BackgroundColor = UIColor.LightGray;

CleverTap.SharedInstance()?.InitializeInboxWithCallback(_ =>
{
    CleverTapInboxViewController inboxVC = CleverTap.SharedInstance().NewInboxViewControllerWithConfig(style, null);
    var navController = new UINavigationController(inboxVC);
    if (inboxVC == null)
    {
        Console.WriteLine("CleverTap Inbox View Controller is null.");
    }
    else
    {
        NavigationController.PresentModalViewController(navController, true);
    }
});
```

### App Inbox Public APIs
You can choose to create your own App Inbox with the help of the following APIs -

```c#
//Initialize App Inbox
CleverTap.SharedInstance()?.InitializeInboxWithCallback(_ =>
{
    // Add your code here.
});

//Get Inbox Message Count
var count = CleverTap.SharedInstance().InboxMessageCount();
Console.WriteLine("CleverTap Inbox message count:" + count);

//Get Inbox Unread Message Count
var unreadCount = CleverTap.SharedInstance().InboxMessageUnreadCount();
Console.WriteLine("CleverTap Inbox unread message count:" + unreadCount);

//Get All Inbox Messages
var allInboxMessages = CleverTap.SharedInstance()?.AllInboxMessages();
Console.WriteLine("CleverTap All Inbox Messages: {0}", allInboxMessages);

//Get Unread Inbox Messages
var unreadMessages = CleverTap.SharedInstance()?.UnreadInboxMessages();
Console.WriteLine("CleverTap Unread Inbox Messages: {0}", unreadMessages);

//Get Inbox message object(CleverTapInboxMessage) for given message id
var message = CleverTap.SharedInstance().GetInboxMessageForId("messageID");
Console.WriteLine("CleverTap Inbox message for id: {0}", message);

//Delete message from the Inbox. MessageId should be a String
CleverTap.SharedInstance().DeleteInboxMessageForID(allInboxMessages[0].MessageId);

//Delete message from the Inbox. Message should be object of type CleverTapInboxMessage
CleverTap.SharedInstance().DeleteInboxMessage(allInboxMessages[0]);

//Mark Message as Read. MessageId should be a String
CleverTap.SharedInstance().MarkReadInboxMessageForID(unreadMessages[0].MessageId);

//Mark message as Read. Message should object of CleverTapInboxMessage
CleverTap.SharedInstance().MarkReadInboxMessage(unreadMessages[0]);

//Raise Notification Viewed event for Inbox Message. Message id should be a String
CleverTap.SharedInstance().RecordInboxNotificationViewedEventForID(allInboxMessages[0].MessageId);

//Raise Notification Clicked event for Inbox Message. Message id should be a String
CleverTap.SharedInstance().RecordInboxNotificationClickedEventForID(allInboxMessages[0].MessageId);
```

### App Inbox Callbacks
```c#
// Create a class to handle App Inbox delegate methods
public class AppInboxDelegate : CleverTapInboxViewControllerDelegate
{
    // This callback is triggered when inbox message/button is clicked
    public override void MessageDidSelect(CleverTapInboxMessage inboxMessage, int index, int buttonIndex)
    {
        Console.WriteLine($"Index: {index}, ButtonIndex: {buttonIndex}");
        Console.WriteLine($"MessageDidSelect called: {inboxMessage}");
    }

    // This callback is triggered when inbox button is clicked with custom key-value pairs
    public override void MessageButtonTappedWithCustomExtras(NSDictionary customExtras)
    {
        Console.WriteLine($"MessageButtonTappedWithCustomExtras called: {customExtras}");
    }
}

// Pass the delegate while initialising new inbox controller
CleverTap.SharedInstance()?.InitializeInboxWithCallback(_ =>
{
    var style = new CleverTapInboxStyleConfig();
    CleverTapInboxViewControllerDelegate inboxDelegate = new CleverTapInboxViewControllerDelegate();
    inboxDelegate = new AppInboxDelegate();
    CleverTapInboxViewController inboxVC = CleverTap.SharedInstance().NewInboxViewControllerWithConfig(style, inboxDelegate);
    var navController = new UINavigationController(inboxVC);
    if (inboxVC == null)
    {
        Console.WriteLine("CleverTap Inbox View Controller is null.");
    }
    else
    {
        NavigationController.PresentModalViewController(navController, true);
    }
});


// Register a block of code which is called when inbox is updated
CleverTap.SharedInstance()?.RegisterInboxUpdatedBlock(inboxUpdatedblock);
void inboxUpdatedblock()
{
    Console.WriteLine("Inbox Updated");
} 
```

## In-App Notifications

### In-App Control APIs
```c#
// This method suspends inapps and saves inapps notifications until resume method is called for current session.
CleverTap.SharedInstance()?.SuspendInAppNotifications();

// This method discards inapps until resume method is called for current session.
CleverTap.SharedInstance()?.DiscardInAppNotifications();

// This method resumes displaying in-app notifications.
CleverTap.SharedInstance()?.ResumeInAppNotifications();
```

### In-App Callbacks
```c#
// Set the CleverTapInAppNotificationDelegate to get callbacks
CleverTapInAppNotificationDelegate inappDelegate = new CleverTapInAppNotificationDelegate();
inappDelegate = new InAppDelegate();
CleverTap.SharedInstance().SetInAppNotificationDelegate(inappDelegate);


// Create a class to handle InApp Notifications delegate methods
public class InAppDelegate : CleverTapInAppNotificationDelegate
{
    // This delegate method is called when inapp notification is about to be rendered,
    // If you'd like this notification to not be rendered, then return false.
    public override bool ShouldShowInAppNotificationWithExtras(NSDictionary extras)
    {
        Console.WriteLine($"ShouldShowInAppNotificationWithExtras called: {extras}");
        return true;
    }

    // This delegate method is called when an in-app notification is dismissed (either by the close button, or a call to action)
    public override void InAppNotificationDismissedWithExtras(NSDictionary extras, NSDictionary actionExtras)
    {
        Console.WriteLine($"InAppNotificationDismissedWithExtras called: {extras} and actionExtras: {actionExtras}");
    }

    // This delegate method is called when an in-app notification is dismissed by a call to action with custom extras
    public override void InAppNotificationButtonTappedWithCustomExtras(NSDictionary customExtras)
    {
        Console.WriteLine($"inAppNotificationButtonTappedWithCustomExtras called: {customExtras}");
    }
}
```

## Push Notifications

### Push Notification Callback
```c#
// Set the CleverTapPushNotificationDelegate to get callbacks
CleverTapPushNotificationDelegate pushDelegate = new CleverTapPushNotificationDelegate();
pushDelegate = new PushNotificationDelegate();
CleverTap.SharedInstance().SetPushNotificationDelegate(pushDelegate);

// Create a class to handle Push Notifications delegate methods
public class PushNotificationDelegate : CleverTapPushNotificationDelegate
{
    // This delegate method is called when a push notification is clicked with custom extras
    public override void PushNotificationTappedWithCustomExtras(NSDictionary extras)
    {
        Console.WriteLine($"PushNotificationTappedWithCustomExtras called: {extras}");
    }
}
```

## Native Display
Refer to the [iOS Native Display](https://developer.clevertap.com/docs/native-display-ios) for detailed guidance.

### Native Display APIs
```c#
// Get all native display units.
var allDisplayUnits = CleverTap.SharedInstance()?.AllDisplayUnits();
foreach (var unit in allDisplayUnits)
{
    Console.WriteLine($"DisplayUnit: {unit.Json}");
}

//Get native display unit for id(String)
var displayUnit = CleverTap.SharedInstance()?.GetDisplayUnitForID(allDisplayUnits[0].UnitID);
Console.WriteLine($"Display Unit for id: {displayUnit.Json}");

//Raise Notification Viewed event for Native Display id(String)
CleverTap.SharedInstance()?.RecordDisplayUnitViewedEventForID(allDisplayUnits[0].UnitID);

//Raise Notification Clicked event for Native Display id(String)
CleverTap.SharedInstance().RecordDisplayUnitClickedEventForID(allDisplayUnits[0].UnitID);
```

### Native Display Callback
```c#
// Set the CleverTapDisplayUnitDelegate to get callbacks
CleverTapDisplayUnitDelegate displayUnitDelegate = new CleverTapDisplayUnitDelegate();
displayUnitDelegate = new NativeDisplayDelegate();
CleverTap.SharedInstance().SetDisplayUnitDelegate(displayUnitDelegate);

// Create a class to handle Native Display delegate methods
public class NativeDisplayDelegate : CleverTapDisplayUnitDelegate
{
    public override void DisplayUnitsUpdated(CleverTapDisplayUnit[] displayUnit)
    {
        Console.WriteLine("DisplayUnitsUpdated called");
        foreach (var unit in displayUnit)
        {
            Console.WriteLine($"DisplayUnit: {unit.Json}");
        }
    }
}
```




