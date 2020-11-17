<p align="center">
  <img src="https://github.com/CleverTap/clevertap-xamarin/blob/master/images/clevertap-logo.png" width="300"/>
</p>

# CleverTap Xamarin Bindings SDK

<p>
    <a href="https://github.com/CleverTap/clevertap-xamarin/releases">
        <img src="https://img.shields.io/github/release/CleverTap/clevertap-xamarin.svg" />
    </a>
</p>

## 👋 Introduction
The CleverTap Xamarin Bindings SDK for Mobile Customer Engagement and Analytics solutions.

For more information check out our [website](https://clevertap.com/ "CleverTap")  and  [documentation](https://developer.clevertap.com/docs/ "CleverTap Technical Documentation").

## 🚀 Installation and Quick Start

## 👨‍💻 Android Guide

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

- In your AndroidManifest.xml file, add the following snippet within the <application></application> tags.

```xml
<application
    android:label="@string/app_name"
    android:icon="@drawable/ic_launcher"
    android:name="com.clevertap.android.sdk.Application">
```

- Next add the snippet below in the same file, so the CleverTap Xamarin SDK can access the internet.

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

### For more information,
- See included [Sample Application](https://github.com/CleverTap/clevertap-xamarin/blob/master/clevertap-component/sample/android/XamarinDemo/XamarinDemo/)
- See [Usage README](https://github.com/CleverTap/clevertap-xamarin/blob/master/docs/Usage-Android.md) 


## 👩‍💻 iOS Guide

1. Install the SDK 

     Use the [DLL](https://github.com/CleverTap/clevertap-xamarin/tree/master/clevertap-component/lib/ios) and add it to the Reference

2. Integrating the CleverTap SDK

      * Follow the integration instruction [starting with Step 2 here](https://developer.clevertap.com/docs/ios-quickstart-guide#section-step-2-add-clever-tap-credentials).
      * Add CleverTap to your `AppDelegate.cs` and add the following snippet in `FinishedLaunching` method.
      
      

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

### For more information,
- See included [Sample Application](https://github.com/CleverTap/clevertap-xamarin/tree/master/clevertap-component/sample/ios/Starter)
- See [Usage README](https://github.com/CleverTap/clevertap-xamarin/blob/master/docs/Usage-iOS.md) 

## 🆕 Changelog

Refer to the [CleverTap Xamarin SDK Change Log](https://github.com/CleverTap/clevertap-xamarin/blob/master/CHANGELOG.md).

## ❓Questions

If you have questions or concerns, you can reach out to the CleverTap support team from the CleverTap Dashboard.
 
## 📄 License #

CleverTap Xamarin SDK is MIT licensed, as found in the [LICENSE file](https://github.com/CleverTap/clevertap-xamarin/blob/master/LICENSE).

