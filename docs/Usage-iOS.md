# Example Usage

### Record an event
 An example of recording a User Event called Product Viewed.

```c#
CleverTap.SharedInstance()?.RecordEvent("Product Viewed");
```

### Record Charged Event
 An example of recording a Charged Event, more details [here](https://developer.clevertap.com/docs/concepts-events#section-recording-customer-purchases).

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

### Update a user profile

- Using `pushProfile`

```c#
var profileData = new NSDictionary(
  new NSString("Name"), new NSString("Jack Montana"),
  new NSString("Identity"), new NSString("61026032"),
  new NSString("Email"), new NSString("Jack Montana"),
  new NSString("Phone"), new NSString("14155551234"),
  new NSString("Gender"), new NSString("F"),
  new NSString("DOB"), new NSDate()
);
CleverTap.SharedInstance()?.ProfilePush(profileData);
```

- Using `onUserLogin`

```c#
var profileData = new NSDictionary(
  new NSString("Name"), new NSString("Jack Montana"),
  new NSString("Identity"), new NSString("61026032"),
  new NSString("Email"), new NSString("Jack Montana"),
  new NSString("Phone"), new NSString("14155551234"),
  new NSString("Gender"), new NSString("F"),
  new NSString("DOB"), new NSDate()
);
CleverTap.SharedInstance()?.OnUserLogin(profileData);
```

Note: Please go through our documentation on handling [user profile](https://developer.clevertap.com/docs/concepts-user-profiles#section-overview).

### App Inbox

##### Initialize the CleverTap App Inbox Method

```c#
CleverTap.SharedInstance()?.InitializeInboxWithCallback((bool success) => {
    if (success) {
        Console.WriteLine("App Inbox Initialised.");
     }
});
```

##### Present App Inbox 

```c#
CleverTapInboxViewController inboxVC = CleverTap.SharedInstance().NewInboxViewControllerWithConfig(null, null);
var navController = new UINavigationController(inboxVC);
if (inboxVC == null) {
    Console.WriteLine("CleverTap Inbox View Controller is null.");
} else {
    NavigationController.PresentModalViewController(navController, true);
}
```

&nbsp;
&nbsp;
&nbsp;

---------------------------------


## iOS (Optional) - only required for iOS Simulator builds

The following is required to prevent crashes when running on iOS simulator.

1. Right-click on your iOS project and select Options.
2. Select Build > iOS Build, then make sure iPhoneSimulator is selected under “Platform:” at the top.
3. Under `Additional mtouch arguments:` enter `--registrar:static`.



<p align="center">
  <img src="https://github.com/CleverTap/clevertap-xamarin/blob/master/images/Xamarin-iOS.png"/>
</p>


