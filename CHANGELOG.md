# CHANGE LOG
### Version 1.1.0 iOS DotNet (December 17, 2024)

* Fixes DotNet iOS build issue on different simulators.
* Supports [CleverTap iOS SDK v7.0.3](https://github.com/CleverTap/clevertap-ios-sdk/releases/tag/7.0.3)

### Version 2.0.0 DotNet (December 13, 2024)

* Fixes an issue for android where type or namespace `Clevertap` doesn't exist in the namespace `com`

### Version 1.0.1 DotNet (May 14, 2024)

* Adds privacy manifest file for iOS.
* Supports [CleverTap iOS SDK v6.2.1](https://github.com/CleverTap/clevertap-ios-sdk/releases/tag/6.2.1)

### Version 1.0.0 DotNet (March 29, 2024)

* Adds support for .NET binding library for .NET and MAUI applications.
* Supports [CleverTap Android SDK v6.1.1](https://github.com/CleverTap/clevertap-android-sdk/releases/tag/corev6.1.1)
* Supports [CleverTap iOS SDK v4.1.6](https://github.com/CleverTap/clevertap-ios-sdk/releases/tag/4.1.6)

### Version 4.0.0 (March 29, 2024)

* Adds support for Android 14
* Supports [CleverTap Android SDK v6.1.1](https://github.com/CleverTap/clevertap-android-sdk/releases/tag/corev6.1.1)
* For developers with [BACKGROUND_SYNC](https://developer.clevertap.com/docs/android-push#pull-notification) enabled in their previous app version and now upgrading to _clevertap-android-sdk v6.1.0+_, please add this to your `AndroidManifest.xml` to avoid `ClassNotFoundException` related crashes

```xml
<service 
    android:name="com.clevertap.android.sdk.pushnotification.amp.CTBackgroundJobService"
    android:exported="false"
    android:enabled="false"
    tools:ignore="MissingClass"/>
```

### Version 3.0.0 (November 29, 2023)

* Adds support for Android 13
* Supports [CleverTap Android SDK v5.2.1](https://github.com/CleverTap/clevertap-android-sdk/releases/tag/corev5.2.1_xpsv1.5.4)

### Version 2.0.0 (March 14, 2023)

* Adds support for Android 12
* Supports [CleverTap Android SDK v4.6.6](https://github.com/CleverTap/clevertap-android-sdk/releases/tag/corev4.6.6)
* Supports [CleverTap iOS SDK v4.1.6](https://github.com/CleverTap/clevertap-ios-sdk/releases/tag/4.1.6)

### Version 1.1.1 (November 9, 2021)

* Fixes App Inbox Public APIs for CleverTap iOS Bindings

### Version 1.1.0 (October 31, 2020)

* Supports [CleverTap iOS SDK v3.9.1](https://github.com/CleverTap/clevertap-ios-sdk/releases/tag/3.9.1)
* Supports [CleverTap Android SDK v4.0.0](https://github.com/CleverTap/clevertap-android-sdk/releases/tag/core-v4.0.0)
* Adds support for Custom Inbox, InApp and Inbox Click callbacks
* Adds support for Native Display & Dynamic Variables
* Adds support for Product Config and Feature Flags

### Version 1.0.0 (February 14, 2020)

* Initial Release.
* Supports CleverTap Android SDK v3.6.2
* Supports CleverTap iOS SDK v3.7.2

