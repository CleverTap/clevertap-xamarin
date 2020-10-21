<p align="center">
  <img src="https://github.com/CleverTap/clevertap-xamarin/blob/master/clevertap-logo.png" width="300"/>
</p>

# CleverTap Xamarin Bindings SDK

The CleverTap Xamarin SDK for Mobile Customer Engagement and Analytics solutions 

CleverTap brings together real-time user insights, an advanced segmentation engine, and easy-to-use marketing tools in one mobile marketing platform — giving your team the power to create amazing experiences that deepen customer relationships. Our intelligent mobile marketing platform provides the insights you need to keep users engaged and drive long-term retention and growth.

For more information check out our [website](https://clevertap.com "CleverTap") and [documentation](https://developer.clevertap.com/docs/ "CleverTap Technical Documentation").

## Getting Started #

### Steps for Android

1. Install the SDK

Use the [CleverTap.Bindings.Android DLL file](https://github.com/CleverTap/clevertap-xamarin/tree/master/clevertap-component/lib/android) and add it to the References.

2. Add Your CleverTap Credentials in AndroidManifest.xml

```xml
<meta-data
    android:name="CLEVERTAP_ACCOUNT_ID"
    android:value="Your CleverTap Account ID"/>
<meta-data
    android:name="CLEVERTAP_TOKEN"
    android:value="Your CleverTap Account Token"/>
<!-- IMPORTANT: To force use Google AD ID to uniquely identify  users, use the following meta tag. GDPR mandates that if you are using this tag, there is prominent disclousure to your end customer in their application. Read more about GDPR here - https://clevertap.com/blog/in-preparation-of-gdpr-compliance/ -->
<meta-data
    android:name="CLEVERTAP_USE_GOOGLE_AD_ID"
    android:value="1"/> 
```

3. Enable Tracking by Adding Permissions

In your AndroidManifest.xml file, add the following snippet within the <application></application> tags.

```xml
<application
    android:label="@string/app_name"
    android:icon="@drawable/ic_launcher"
    android:name="com.clevertap.android.sdk.Application">
```

Next add the snippet below in the same file, so the CleverTap Xamarin SDK can access the internet.

```xml
<!-- Required to allow the app to send events and user profile information -->
<uses-permission android:name="android.permission.INTERNET"/>
<!-- Recommended so that CleverTap knows when to attempt a network call -->
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE"/>
```

4. Initialize the CleverTap SDK

```c#
CleverTapAPI cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
```

5. Add Information to a User Profile

```c#
IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

profileData.Add("Name", "Jack Montana");    // String
profileData.Add("Identity", 61026032);      // String or number
profileData.Add("Email", "jack@gmail.com"); // Email address of the user
profileData.Add("Phone", "+14155551234");   // Phone (with the country code, starting with +)
profileData.Add("Gender", "M");             // Can be either M or F
profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util


cleverTapAPI.PushProfile(profileData);
```

6. Track Custom Events

```c#
cleverTapAPI.PushEvent("Product View Via Xamarin");
```

Follow the [Xamarin Demo Project](https://github.com/CleverTap/clevertap-xamarin/blob/master/clevertap-component/sample/android/XamarinDemo/XamarinDemo/MainActivity.cs) for examples


### Steps for iOS

1. Install the SDK 

     Use the [DLL](https://github.com/CleverTap/clevertap-xamarin/tree/master/clevertap-component/lib/ios) and add it to the Reference

2. Integrating the CleverTap SDK

      * Follow the integration instruction [starting with Step 2 here](https://developer.clevertap.com/docs/ios-quickstart-guide#section-step-2-add-clever-tap-credentials).
      * Add CleverTap to your AppDelegate.cs in your FinishedLaunching method.

```c#
using CleverTapSDK;

public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
{
    // Override point for customization after application launch.
    // If not required for your application you can safely delete this method

    CleverTap.AutoIntegrate();
    return true;
}
```

3. Track Custom Events
```c#
CleverTap.SharedInstance()?.RecordEvent("Product Viewed Via Xamarin");
```

4. Add Information to a User Profile
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

Please checkout the [Starter Project](https://github.com/CleverTap/clevertap-xamarin/tree/master/clevertap-component/sample/ios/Starter) directory for the sample app.

## Changelog #

Check out the CleverTap Xamarin SDK [Change Log](https://github.com/CleverTap/clevertap-xamarin/blob/master/CHANGELOG.md) here.

## Questions? #

If you have questions or concerns, you can reach out to the CleverTap support team from the CleverTap Dashboard.
 
 ## License #

Check out the CleverTap Xamarin SDK [License](https://github.com/CleverTap/clevertap-xamarin/blob/master/LICENSE) here.

