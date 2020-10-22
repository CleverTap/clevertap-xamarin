# Example JS Usage

#### Record an event
```c#
CleverTap.SharedInstance()?.RecordEvent("Product Viewed Via Xamarin");
```

#### Update a user profile

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
