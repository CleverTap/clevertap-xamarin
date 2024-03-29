using System;
using AVFoundation;
using CloudKit;
using Contacts;
using CoreAnimation;
using CoreData;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using CoreLocation;
using CoreVideo;
using FileProvider;
using Foundation;
using IOSurface;
using ImageIO;
using Intents;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;
using WebKit;
using System.Runtime.InteropServices;

namespace CleverTapSDK
{
    // @interface CTLogger : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTLogger
    {
        // +(void)setDebugLevel:(int)level;
        [Static]
        [Export("setDebugLevel:")]
        void SetDebugLevel(int level);

        // +(int)getDebugLevel;
        [Static]
        [Export("getDebugLevel")]
        int DebugLevel { get; }
    }

    // @interface CTDeviceInfo : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTDeviceInfo
    {
        // @property (readonly, strong) NSString * sdkVersion;
        [Export("sdkVersion", ArgumentSemantic.Strong)]
        string SdkVersion { get; }

        // @property (readonly, strong) NSString * appVersion;
        [Export("appVersion", ArgumentSemantic.Strong)]
        string AppVersion { get; }

        // @property (readonly, strong) NSString * appBuild;
        [Export("appBuild", ArgumentSemantic.Strong)]
        string AppBuild { get; }

        // @property (readonly, strong) NSString * bundleId;
        [Export("bundleId", ArgumentSemantic.Strong)]
        string BundleId { get; }

        // @property (readonly, strong) NSString * osName;
        [Export("osName", ArgumentSemantic.Strong)]
        string OsName { get; }

        // @property (readonly, strong) NSString * osVersion;
        [Export("osVersion", ArgumentSemantic.Strong)]
        string OsVersion { get; }

        // @property (readonly, strong) NSString * manufacturer;
        [Export("manufacturer", ArgumentSemantic.Strong)]
        string Manufacturer { get; }

        // @property (readonly, atomic) NSString * model;
        [Export("model")]
        string Model { get; }

        // @property (readonly, strong) NSString * carrier;
        [Export("carrier", ArgumentSemantic.Strong)]
        string Carrier { get; }

        // @property (readonly, strong) NSString * countryCode;
        [Export("countryCode", ArgumentSemantic.Strong)]
        string CountryCode { get; }

        // @property (readonly, strong) NSString * timeZone;
        [Export("timeZone", ArgumentSemantic.Strong)]
        string TimeZone { get; }

        // @property (readonly, strong) NSString * radio;
        [Export("radio", ArgumentSemantic.Strong)]
        string Radio { get; }

        // @property (readonly, strong) NSString * vendorIdentifier;
        [Export("vendorIdentifier", ArgumentSemantic.Strong)]
        string VendorIdentifier { get; }

        // @property (readonly, strong) NSString * deviceWidth;
        [Export("deviceWidth", ArgumentSemantic.Strong)]
        string DeviceWidth { get; }

        // @property (readonly, strong) NSString * deviceHeight;
        [Export("deviceHeight", ArgumentSemantic.Strong)]
        string DeviceHeight { get; }

        // @property (readonly, atomic) NSString * deviceId;
        [Export("deviceId")]
        string DeviceId { get; }

        // @property (readonly, atomic) NSString * fallbackDeviceId;
        [Export("fallbackDeviceId")]
        string FallbackDeviceId { get; }

        // @property (readwrite, atomic) NSString * library;
        [Export("library")]
        string Library { get; set; }

        // @property (readonly, assign) BOOL wifi;
        [Export("wifi")]
        bool Wifi { get; }

        // @property (readonly, strong) NSMutableArray<CTValidationResult *> * validationErrors;
        [Export("validationErrors", ArgumentSemantic.Strong)]
        NSMutableArray<CTValidationResult> ValidationErrors { get; }

        // @property (readonly, strong) NSString * signedCallSDKVersion;
        [Export("signedCallSDKVersion", ArgumentSemantic.Strong)]
        string SignedCallSDKVersion { get; }

        // -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config andCleverTapID:(NSString *)cleverTapID;
        [Export("initWithConfig:andCleverTapID:")]
        IntPtr Constructor(CleverTapInstanceConfig config, string cleverTapID);

        // -(void)forceUpdateDeviceID:(NSString *)newDeviceID;
        [Export("forceUpdateDeviceID:")]
        void ForceUpdateDeviceID(string newDeviceID);

        // -(void)forceNewDeviceID;
        [Export("forceNewDeviceID")]
        void ForceNewDeviceID();

        // -(void)forceUpdateCustomDeviceID:(NSString *)cleverTapID;
        [Export("forceUpdateCustomDeviceID:")]
        void ForceUpdateCustomDeviceID(string cleverTapID);

        // -(BOOL)isErrorDeviceID;
        [Export("isErrorDeviceID")]
        bool IsErrorDeviceID { get; }

        // -(void)setSignedCallSDKVersion:(NSString *)version;
        [Export("setSignedCallSDKVersion:")]
        void SetSignedCallSDKVersion(string version);
    }

    // @interface CleverTap : NSObject

    [Preserve]
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTap
    {
        // @property (readonly, nonatomic, strong) CleverTapInstanceConfig * _Nonnull config;
        [Export("config", ArgumentSemantic.Strong)]
        CleverTapInstanceConfig Config { get; }

        // @property (readwrite, nonatomic, strong) NSString * _Nullable signedCallDomain;
        [NullAllowed, Export("signedCallDomain", ArgumentSemantic.Strong)]
        string SignedCallDomain { get; set; }

        // +(instancetype _Nullable)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        [return: NullAllowed]
        CleverTap SharedInstance();

        // +(instancetype _Nullable)sharedInstanceWithCleverTapID:(NSString * _Nonnull)cleverTapID;
        [Static]
        [Export("sharedInstanceWithCleverTapID:")]
        [return: NullAllowed]
        CleverTap SharedInstanceWithCleverTapID(string cleverTapID);

        // +(instancetype _Nullable)autoIntegrate;
        [Static]
        [Export("autoIntegrate")]
        [return: NullAllowed]
        CleverTap AutoIntegrate();

        // +(instancetype _Nullable)autoIntegrateWithCleverTapID:(NSString * _Nonnull)cleverTapID;
        [Static]
        [Export("autoIntegrateWithCleverTapID:")]
        [return: NullAllowed]
        CleverTap AutoIntegrateWithCleverTapID(string cleverTapID);

        // +(instancetype _Nonnull)instanceWithConfig:(CleverTapInstanceConfig * _Nonnull)config;
        [Static]
        [Export("instanceWithConfig:")]
        CleverTap InstanceWithConfig(CleverTapInstanceConfig config);

        // +(instancetype _Nonnull)instanceWithConfig:(CleverTapInstanceConfig * _Nonnull)config andCleverTapID:(NSString * _Nonnull)cleverTapID;
        [Static]
        [Export("instanceWithConfig:andCleverTapID:")]
        CleverTap InstanceWithConfig(CleverTapInstanceConfig config, string cleverTapID);

        // +(CleverTap * _Nullable)getGlobalInstance:(NSString * _Nonnull)accountId;
        [Static]
        [Export("getGlobalInstance:")]
        [return: NullAllowed]
        CleverTap GetGlobalInstance(string accountId);

        // +(void)changeCredentialsWithAccountID:(NSString * _Nonnull)accountID andToken:(NSString * _Nonnull)token __attribute__((deprecated("Deprecated as of version 3.1.7, use setCredentialsWithAccountID:andToken instead")));
        [Static]
        [Export("changeCredentialsWithAccountID:andToken:")]
        void ChangeCredentialsWithAccountID(string accountID, string token);

        // +(void)changeCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token region:(NSString * _Nonnull)region __attribute__((deprecated("Deprecated as of version 3.1.7, use setCredentialsWithAccountID:token:region instead")));
        [Static]
        [Export("changeCredentialsWithAccountID:token:region:")]
        void ChangeCredentialsWithAccountID(string accountID, string token, string region);

        // +(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID andToken:(NSString * _Nonnull)token;
        [Static]
        [Export("setCredentialsWithAccountID:andToken:")]
        void SetCredentialsWithAccountID(string accountID, string token);

        // +(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token region:(NSString * _Nonnull)region;
        [Static]
        [Export("setCredentialsWithAccountID:token:region:")]
        void SetCredentialsWithAccountID(string accountID, string token, string region);

        // +(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token proxyDomain:(NSString * _Nonnull)proxyDomain;
        // TODO:
        //[Static]
        //[Export("setCredentialsWithAccountID:token:proxyDomain:")]
        //void SetCredentialsWithAccountID(string accountID, string token, string proxyDomain);

        // +(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token proxyDomain:(NSString * _Nonnull)proxyDomain spikyProxyDomain:(NSString * _Nonnull)spikyProxyDomain;
        [Static]
        [Export("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:")]
        void SetCredentialsWithAccountID(string accountID, string token, string proxyDomain, string spikyProxyDomain);

        // -(void)notifyApplicationLaunchedWithOptions:(id)launchOptions;
        [Export("notifyApplicationLaunchedWithOptions:")]
        void NotifyApplicationLaunchedWithOptions(NSObject launchOptions);

        // +(void)enablePersonalization;
        [Static]
        [Export("enablePersonalization")]
        void EnablePersonalization();

        // +(void)disablePersonalization;
        [Static]
        [Export("disablePersonalization")]
        void DisablePersonalization();

        // +(void)setLocation:(CLLocationCoordinate2D)location;
        [Static]
        [Export("setLocation:")]
        void SetLocation(CLLocationCoordinate2D location);

        // -(void)setLocation:(CLLocationCoordinate2D)location;
        // TODO: 
        //[Export("setLocation:")]
        //void SetLocation(CLLocationCoordinate2D location);

        // +(void)getLocationWithSuccess:(void (^ _Nonnull)(CLLocationCoordinate2D))success andError:(void (^ _Nullable)(NSString * _Nullable))error;
        [Static]
        [Export("getLocationWithSuccess:andError:")]
        void GetLocationWithSuccess(Action<CLLocationCoordinate2D> success, [NullAllowed] Action<NSString> error);

        // -(void)onUserLogin:(NSDictionary * _Nonnull)properties;
        [Export("onUserLogin:")]
        void OnUserLogin(NSDictionary properties);

        // -(void)onUserLogin:(NSDictionary * _Nonnull)properties withCleverTapID:(NSString * _Nonnull)cleverTapID;
        [Export("onUserLogin:withCleverTapID:")]
        void OnUserLogin(NSDictionary properties, string cleverTapID);

        // -(void)setOptOut:(BOOL)enabled;
        [Export("setOptOut:")]
        void SetOptOut(bool enabled);

        // -(void)setOffline:(BOOL)offline;
        [Export("setOffline:")]
        void SetOffline(bool offline);

        // -(void)enableDeviceNetworkInfoReporting:(BOOL)enabled;
        [Export("enableDeviceNetworkInfoReporting:")]
        void EnableDeviceNetworkInfoReporting(bool enabled);

        // -(void)profilePush:(NSDictionary * _Nonnull)properties;
        [Export("profilePush:")]
        void ProfilePush(NSDictionary properties);

        // -(void)profileRemoveValueForKey:(NSString * _Nonnull)key;
        [Export("profileRemoveValueForKey:")]
        void ProfileRemoveValueForKey(string key);

        // -(void)profileSetMultiValues:(NSArray<NSString *> * _Nonnull)values forKey:(NSString * _Nonnull)key;
        [Export("profileSetMultiValues:forKey:")]
        void ProfileSetMultiValues(string[] values, string key);

        // -(void)profileAddMultiValue:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)key;
        [Export("profileAddMultiValue:forKey:")]
        void ProfileAddMultiValue(string value, string key);

        // -(void)profileAddMultiValues:(NSArray<NSString *> * _Nonnull)values forKey:(NSString * _Nonnull)key;
        [Export("profileAddMultiValues:forKey:")]
        void ProfileAddMultiValues(string[] values, string key);

        // -(void)profileRemoveMultiValue:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)key;
        [Export("profileRemoveMultiValue:forKey:")]
        void ProfileRemoveMultiValue(string value, string key);

        // -(void)profileRemoveMultiValues:(NSArray<NSString *> * _Nonnull)values forKey:(NSString * _Nonnull)key;
        [Export("profileRemoveMultiValues:forKey:")]
        void ProfileRemoveMultiValues(string[] values, string key);

        // -(void)profileIncrementValueBy:(NSNumber * _Nonnull)value forKey:(NSString * _Nonnull)key;
        [Export("profileIncrementValueBy:forKey:")]
        void ProfileIncrementValueBy(NSNumber value, string key);

        // -(void)profileDecrementValueBy:(NSNumber * _Nonnull)value forKey:(NSString * _Nonnull)key;
        [Export("profileDecrementValueBy:forKey:")]
        void ProfileDecrementValueBy(NSNumber value, string key);

        // -(id _Nullable)profileGet:(NSString * _Nonnull)propertyName;
        [Export("profileGet:")]
        [return: NullAllowed]
        NSObject ProfileGet(string propertyName);

        // -(NSString * _Nullable)profileGetCleverTapID;
        [NullAllowed, Export("profileGetCleverTapID")]
        string ProfileGetCleverTapID { get; }

        // -(NSString * _Nullable)getAccountID;
        [NullAllowed, Export("getAccountID")]
        string AccountID { get; }

        // -(NSString * _Nullable)profileGetCleverTapAttributionIdentifier;
        [NullAllowed, Export("profileGetCleverTapAttributionIdentifier")]
        string ProfileGetCleverTapAttributionIdentifier { get; }

        // -(void)recordEvent:(NSString * _Nonnull)event;
        [Export("recordEvent:")]
        void RecordEvent(string @event);

        // -(void)recordEvent:(NSString * _Nonnull)event withProps:(NSDictionary * _Nonnull)properties;
        [Export("recordEvent:withProps:")]
        void RecordEvent(string @event, NSDictionary properties);

        // -(void)recordChargedEventWithDetails:(NSDictionary * _Nonnull)chargeDetails andItems:(NSArray * _Nonnull)items;
        [Export("recordChargedEventWithDetails:andItems:")]
        void RecordChargedEventWithDetails(NSDictionary chargeDetails, NSObject[] items);

        // -(void)recordErrorWithMessage:(NSString * _Nonnull)message andErrorCode:(int)code;
        [Export("recordErrorWithMessage:andErrorCode:")]
        void RecordErrorWithMessage(string message, int code);

        // -(void)recordScreenView:(NSString * _Nonnull)screenName;
        [Export("recordScreenView:")]
        void RecordScreenView(string screenName);

        // -(void)recordNotificationViewedEventWithData:(id _Nonnull)notificationData;
        [Export("recordNotificationViewedEventWithData:")]
        void RecordNotificationViewedEventWithData(NSObject notificationData);

        // -(void)recordNotificationClickedEventWithData:(id _Nonnull)notificationData;
        [Export("recordNotificationClickedEventWithData:")]
        void RecordNotificationClickedEventWithData(NSObject notificationData);

        // -(NSTimeInterval)eventGetFirstTime:(NSString * _Nonnull)event;
        [Export("eventGetFirstTime:")]
        double EventGetFirstTime(string @event);

        // -(NSTimeInterval)eventGetLastTime:(NSString * _Nonnull)event;
        [Export("eventGetLastTime:")]
        double EventGetLastTime(string @event);

        // -(int)eventGetOccurrences:(NSString * _Nonnull)event;
        [Export("eventGetOccurrences:")]
        int EventGetOccurrences(string @event);

        // -(NSDictionary * _Nullable)userGetEventHistory;
        [NullAllowed, Export("userGetEventHistory")]
        NSDictionary UserGetEventHistory { get; }

        // -(CleverTapEventDetail * _Nullable)eventGetDetail:(NSString * _Nullable)event;
        [Export("eventGetDetail:")]
        [return: NullAllowed]
        CleverTapEventDetail EventGetDetail([NullAllowed] string @event);

        // -(NSTimeInterval)sessionGetTimeElapsed;
        [Export("sessionGetTimeElapsed")]
        double SessionGetTimeElapsed { get; }

        // -(CleverTapUTMDetail * _Nullable)sessionGetUTMDetails;
        [NullAllowed, Export("sessionGetUTMDetails")]
        CleverTapUTMDetail SessionGetUTMDetails { get; }

        // -(int)userGetTotalVisits;
        [Export("userGetTotalVisits")]
        int UserGetTotalVisits { get; }

        // -(int)userGetScreenCount;
        [Export("userGetScreenCount")]
        int UserGetScreenCount { get; }

        // -(NSTimeInterval)userGetPreviousVisitTime;
        [Export("userGetPreviousVisitTime")]
        double UserGetPreviousVisitTime { get; }

        // -(void)setSyncDelegate:(id<CleverTapSyncDelegate> _Nullable)delegate;
        [Export("setSyncDelegate:")]
        void SetSyncDelegate([NullAllowed] CleverTapSyncDelegate @delegate);

        // -(void)setPushNotificationDelegate:(id<CleverTapPushNotificationDelegate> _Nullable)delegate;
        [Export("setPushNotificationDelegate:")]
        void SetPushNotificationDelegate([NullAllowed] CleverTapPushNotificationDelegate @delegate);

        // -(void)setInAppNotificationDelegate:(id<CleverTapInAppNotificationDelegate> _Nullable)delegate;
        [Export("setInAppNotificationDelegate:")]
        void SetInAppNotificationDelegate([NullAllowed] CleverTapInAppNotificationDelegate @delegate);

        // -(void)setUrlDelegate:(id<CleverTapURLDelegate> _Nullable)delegate;
        [Export("setUrlDelegate:")]
        void SetUrlDelegate([NullAllowed] CleverTapURLDelegate @delegate);

        // -(void)setPushToken:(NSData * _Nonnull)pushToken;
        [Export("setPushToken:")]
        void SetPushToken(NSData pushToken);

        // -(void)setPushTokenAsString:(NSString * _Nonnull)pushTokenString;
        [Export("setPushTokenAsString:")]
        void SetPushTokenAsString(string pushTokenString);

        // -(void)handleNotificationWithData:(id _Nonnull)data;
        [Export("handleNotificationWithData:")]
        void HandleNotificationWithData(NSObject data);

        // -(void)handleNotificationWithData:(id _Nonnull)data openDeepLinksInForeground:(BOOL)openInForeground;
        [Export("handleNotificationWithData:openDeepLinksInForeground:")]
        void HandleNotificationWithData(NSObject data, bool openInForeground);

        // +(void)handlePushNotification:(NSDictionary * _Nonnull)notification openDeepLinksInForeground:(BOOL)openInForeground;
        [Static]
        [Export("handlePushNotification:openDeepLinksInForeground:")]
        void HandlePushNotification(NSDictionary notification, bool openInForeground);

        // -(BOOL)isCleverTapNotification:(NSDictionary * _Nonnull)payload;
        [Export("isCleverTapNotification:")]
        bool IsCleverTapNotification(NSDictionary payload);

        // -(void)showInAppNotificationIfAny __attribute__((deprecated("Use resumeInAppNotifications to show pending InApp notifications. This will be removed soon.")));
        [Export("showInAppNotificationIfAny")]
        void ShowInAppNotificationIfAny();

        // -(void)handleOpenURL:(NSURL * _Nonnull)url sourceApplication:(NSString * _Nullable)sourceApplication;
        [Export("handleOpenURL:sourceApplication:")]
        void HandleOpenURL(NSUrl url, [NullAllowed] string sourceApplication);

        // +(void)handleOpenURL:(NSURL * _Nonnull)url;
        [Static]
        [Export("handleOpenURL:")]
        void HandleOpenURL(NSUrl url);

        // -(void)pushInstallReferrerSource:(NSString * _Nullable)source medium:(NSString * _Nullable)medium campaign:(NSString * _Nullable)campaign;
        [Export("pushInstallReferrerSource:medium:campaign:")]
        void PushInstallReferrerSource([NullAllowed] string source, [NullAllowed] string medium, [NullAllowed] string campaign);

        // +(void)setDebugLevel:(int)level;
        [Static]
        [Export("setDebugLevel:")]
        void SetDebugLevel(int level);

        // +(CleverTapLogLevel)getDebugLevel;
        [Static]
        [Export("getDebugLevel")]
        CleverTapLogLevel DebugLevel { get; }

        // -(void)setLibrary:(NSString * _Nonnull)name;
        [Export("setLibrary:")]
        void SetLibrary(string name);

        // -(void)setLocationForGeofences:(CLLocationCoordinate2D)location withPluginVersion:(NSString * _Nullable)version;
        [Export("setLocationForGeofences:withPluginVersion:")]
        void SetLocationForGeofences(CLLocationCoordinate2D location, [NullAllowed] string version);

        // -(void)didFailToRegisterForGeofencesWithError:(NSError * _Nullable)error;
        [Export("didFailToRegisterForGeofencesWithError:")]
        void DidFailToRegisterForGeofencesWithError([NullAllowed] NSError error);

        // -(void)recordGeofenceEnteredEvent:(NSDictionary * _Nonnull)geofenceDetails;
        [Export("recordGeofenceEnteredEvent:")]
        void RecordGeofenceEnteredEvent(NSDictionary geofenceDetails);

        // -(void)recordGeofenceExitedEvent:(NSDictionary * _Nonnull)geofenceDetails;
        [Export("recordGeofenceExitedEvent:")]
        void RecordGeofenceExitedEvent(NSDictionary geofenceDetails);

        // -(void)recordSignedCallEvent:(int)eventRawValue forCallDetails:(NSDictionary * _Nonnull)calldetails;
        [Export("recordSignedCallEvent:forCallDetails:")]
        void RecordSignedCallEvent(int eventRawValue, NSDictionary calldetails);

        // -(void)setSignedCallVersion:(NSString * _Nullable)version;
        [Export("setSignedCallVersion:")]
        void SetSignedCallVersion([NullAllowed] string version);

        // -(void)setDomainDelegate:(id<CleverTapDomainDelegate> _Nullable)delegate;
        [Export("setDomainDelegate:")]
        void SetDomainDelegate([NullAllowed] CleverTapDomainDelegate @delegate);

        // -(NSString * _Nullable)getDomainString;
        [NullAllowed, Export("getDomainString")]
        string DomainString { get; }

        // +(BOOL)isValidCleverTapId:(NSString * _Nullable)cleverTapID;
        [Static]
        [Export("isValidCleverTapId:")]
        bool IsValidCleverTapId([NullAllowed] string cleverTapID);
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const kCTApiDomain;
        [Field("kCTApiDomain", "__Internal")]
        NSString kCTApiDomain { get; }

        // extern NSString *const kCTNotifViewedApiDomain;
        [Field("kCTNotifViewedApiDomain", "__Internal")]
        NSString kCTNotifViewedApiDomain { get; }

        // extern NSString *const _Nonnull CleverTapGeofencesDidUpdateNotification;
        [Field("CleverTapGeofencesDidUpdateNotification", "__Internal")]
        NSString CleverTapGeofencesDidUpdateNotification { get; }

        // extern NSString *const _Nonnull CleverTapProfileDidChangeNotification;
        [Field("CleverTapProfileDidChangeNotification", "__Internal")]
        NSString CleverTapProfileDidChangeNotification { get; }

        // extern NSString *const _Nonnull CleverTapProfileDidInitializeNotification;
        [Field("CleverTapProfileDidInitializeNotification", "__Internal")]
        NSString CleverTapProfileDidInitializeNotification { get; }
    }

    // @interface CTEventBuilder : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTEventBuilder
    {
        // +(void)build:(NSString * _Nonnull)eventName completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("build:completionHandler:")]
        void Build(string eventName, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)build:(NSString * _Nonnull)eventName withEventActions:(NSDictionary * _Nullable)eventActions completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("build:withEventActions:completionHandler:")]
        void Build(string eventName, [NullAllowed] NSDictionary eventActions, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildChargedEventWithDetails:(NSDictionary * _Nonnull)chargeDetails andItems:(NSArray * _Nullable)items completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildChargedEventWithDetails:andItems:completionHandler:")]
        void BuildChargedEventWithDetails(NSDictionary chargeDetails, [NullAllowed] NSObject[] items, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildPushNotificationEvent:(BOOL)clicked forNotification:(NSDictionary * _Nonnull)notification completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildPushNotificationEvent:forNotification:completionHandler:")]
        void BuildPushNotificationEvent(bool clicked, NSDictionary notification, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildInAppNotificationStateEvent:(BOOL)clicked forNotification:(CTInAppNotification * _Nonnull)notification andQueryParameters:(NSDictionary * _Nullable)params completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildInAppNotificationStateEvent:forNotification:andQueryParameters:completionHandler:")]
        void BuildInAppNotificationStateEvent(bool clicked, CTInAppNotification notification, [NullAllowed] NSDictionary @params, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildInboxMessageStateEvent:(BOOL)clicked forMessage:(CleverTapInboxMessage * _Nonnull)message andQueryParameters:(NSDictionary * _Nullable)params completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildInboxMessageStateEvent:forMessage:andQueryParameters:completionHandler:")]
        void BuildInboxMessageStateEvent(bool clicked, CleverTapInboxMessage message, [NullAllowed] NSDictionary @params, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildDisplayViewStateEvent:(BOOL)clicked forDisplayUnit:(CleverTapDisplayUnit * _Nonnull)displayUnit andQueryParameters:(NSDictionary * _Nullable)params completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildDisplayViewStateEvent:forDisplayUnit:andQueryParameters:completionHandler:")]
        void BuildDisplayViewStateEvent(bool clicked, CleverTapDisplayUnit displayUnit, [NullAllowed] NSDictionary @params, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildGeofenceStateEvent:(BOOL)entered forGeofenceDetails:(NSDictionary * _Nonnull)geofenceDetails completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildGeofenceStateEvent:forGeofenceDetails:completionHandler:")]
        void BuildGeofenceStateEvent(bool entered, NSDictionary geofenceDetails, Action<NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildSignedCallEvent:(int)eventRawValue forCallDetails:(NSDictionary * _Nonnull)callDetails completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildSignedCallEvent:forCallDetails:completionHandler:")]
        void BuildSignedCallEvent(int eventRawValue, NSDictionary callDetails, Action<NSDictionary, NSArray<CTValidationResult>> completion);
    }

    // @protocol CTIdentityRepo <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    //[Protocol]
    [Model]
    [BaseType(typeof(NSObject))]
    interface CTIdentityRepo
    {
        // @required -(NSArray *)getIdentities;
        [Abstract]
        [Export("getIdentities")]
        NSObject[] Identities { get; }

        // @required -(BOOL)isIdentity:(NSString *)key;
        [Abstract]
        [Export("isIdentity:")]
        bool IsIdentity(string key);
    }

    // @interface CleverTapInstanceConfig : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol]
    interface CleverTapInstanceConfig
    {
        // @property (readonly, nonatomic, strong) NSString * _Nonnull accountId;
        [Export("accountId", ArgumentSemantic.Strong)]
        string AccountId { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull accountToken;
        [Export("accountToken", ArgumentSemantic.Strong)]
        string AccountToken { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable accountRegion;
        [NullAllowed, Export("accountRegion", ArgumentSemantic.Strong)]
        string AccountRegion { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable proxyDomain;
        [NullAllowed, Export("proxyDomain", ArgumentSemantic.Strong)]
        string ProxyDomain { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable spikyProxyDomain;
        [NullAllowed, Export("spikyProxyDomain", ArgumentSemantic.Strong)]
        string SpikyProxyDomain { get; }

        // @property (assign, nonatomic) BOOL analyticsOnly;
        [Export("analyticsOnly")]
        bool AnalyticsOnly { get; set; }

        // @property (assign, nonatomic) BOOL disableAppLaunchedEvent;
        [Export("disableAppLaunchedEvent")]
        bool DisableAppLaunchedEvent { get; set; }

        // @property (assign, nonatomic) BOOL enablePersonalization;
        [Export("enablePersonalization")]
        bool EnablePersonalization { get; set; }

        // @property (assign, nonatomic) BOOL useCustomCleverTapId;
        [Export("useCustomCleverTapId")]
        bool UseCustomCleverTapId { get; set; }

        // @property (assign, nonatomic) BOOL disableIDFV;
        [Export("disableIDFV")]
        bool DisableIDFV { get; set; }

        // @property (assign, nonatomic) CleverTapLogLevel logLevel;
        [Export("logLevel", ArgumentSemantic.Assign)]
        CleverTapLogLevel LogLevel { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable identityKeys;
        [NullAllowed, Export("identityKeys", ArgumentSemantic.Strong)]
        NSObject[] IdentityKeys { get; set; }

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken;
        [Export("initWithAccountId:accountToken:")]
        IntPtr Constructor(string accountId, string accountToken);

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken accountRegion:(NSString * _Nonnull)accountRegion;
        [Export("initWithAccountId:accountToken:accountRegion:")]
        IntPtr Constructor(string accountId, string accountToken, string accountRegion);

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken proxyDomain:(NSString * _Nonnull)proxyDomain;
        // TODO:
        //[Export("initWithAccountId:accountToken:proxyDomain:")]
        //IntPtr Constructor(string accountId, string accountToken, string proxyDomain);

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken proxyDomain:(NSString * _Nonnull)proxyDomain spikyProxyDomain:(NSString * _Nonnull)spikyProxyDomain;
        [Export("initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:")]
        IntPtr Constructor(string accountId, string accountToken, string proxyDomain, string spikyProxyDomain);
    }

    // @interface CTValidationResult : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTValidationResult : INativeObject
    {
        // -(NSString *)errorDesc;
        // -(void)setErrorDesc:(NSString *)errorDsc;
        [Export("errorDesc")]
        string ErrorDesc { get; set; }

        // -(NSObject *)object;
        // -(void)setObject:(NSObject *)obj;
        [Export("object")]
        NSObject Object { get; set; }

        // -(int)errorCode;
        // -(void)setErrorCode:(int)errorCod;
        [Export("errorCode")]
        int ErrorCode { get; set; }

        // +(CTValidationResult *)resultWithErrorCode:(int)code andMessage:(NSString *)message;
        [Static]
        [Export("resultWithErrorCode:andMessage:")]
        CTValidationResult ResultWithErrorCode(int code, string message);
    }

    // @interface CTValidationResultStack : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTValidationResultStack
    {
        // -(void)pushValidationResults:(NSArray<CTValidationResult *> *)results;
        [Export("pushValidationResults:")]
        void PushValidationResults(CTValidationResult[] results);

        // -(void)pushValidationResult:(CTValidationResult *)vr;
        [Export("pushValidationResult:")]
        void PushValidationResult(CTValidationResult vr);

        // -(CTValidationResult *)popValidationResult;
        [Export("popValidationResult")]
        CTValidationResult PopValidationResult { get; }

        // -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config;
        [Export("initWithConfig:")]
        IntPtr Constructor(CleverTapInstanceConfig config);
    }

    // @interface CTFlexibleIdentityRepo : NSObject <CTIdentityRepo>
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTFlexibleIdentityRepo : CTIdentityRepo
    {
        // -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config deviceInfo:(CTDeviceInfo *)deviceInfo validationResultStack:(CTValidationResultStack *)validationResultStack;
        [Export("initWithConfig:deviceInfo:validationResultStack:")]
        IntPtr Constructor(CleverTapInstanceConfig config, CTDeviceInfo deviceInfo, CTValidationResultStack validationResultStack);
    }

    // @interface CTIdentityRepoFactory : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTIdentityRepoFactory
    {
        // +(id<CTIdentityRepo>)getRepoForConfig:(CleverTapInstanceConfig *)config deviceInfo:(CTDeviceInfo *)deviceInfo validationResultStack:(CTValidationResultStack *)validationResultStack;
        [Static]
        [Export("getRepoForConfig:deviceInfo:validationResultStack:")]
        CTIdentityRepo GetRepoForConfig(CleverTapInstanceConfig config, CTDeviceInfo deviceInfo, CTValidationResultStack validationResultStack);
    }

    // @interface CTInAppUtils : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTInAppUtils
    {
        // +(CTInAppType)inAppTypeFromString:(NSString * _Nonnull)type;
        [Static]
        [Export("inAppTypeFromString:")]
        CTInAppType InAppTypeFromString(string type);

        // +(NSBundle * _Nullable)bundle;
        [Static]
        [NullAllowed, Export("bundle")]
        NSBundle Bundle { get; }

        // +(NSString * _Nullable)getXibNameForControllerName:(NSString * _Nonnull)controllerName;
        [Static]
        [Export("getXibNameForControllerName:")]
        [return: NullAllowed]
        string GetXibNameForControllerName(string controllerName);
    }

    // @interface CTNotificationButton : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface CTNotificationButton
    {
        // @property (readonly, copy, nonatomic) NSString * text;
        [Export("text")]
        string Text { get; }

        // @property (readonly, copy, nonatomic) NSString * textColor;
        [Export("textColor")]
        string TextColor { get; }

        // @property (readonly, copy, nonatomic) NSString * borderRadius;
        [Export("borderRadius")]
        string BorderRadius { get; }

        // @property (readonly, copy, nonatomic) NSString * borderColor;
        [Export("borderColor")]
        string BorderColor { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * customExtras;
        [Export("customExtras", ArgumentSemantic.Copy)]
        NSDictionary CustomExtras { get; }

        // @property (readonly, copy, nonatomic) NSString * backgroundColor;
        [Export("backgroundColor")]
        string BackgroundColor { get; }

        // @property (readonly, nonatomic) NSURL * actionURL;
        [Export("actionURL")]
        NSUrl ActionURL { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * jsonDescription;
        [Export("jsonDescription", ArgumentSemantic.Copy)]
        NSDictionary JsonDescription { get; }

        // @property (readonly, nonatomic) NSString * error;
        [Export("error")]
        string Error { get; }

        // -(instancetype)initWithJSON:(NSDictionary *)json;
        [Export("initWithJSON:")]
        IntPtr Constructor(NSDictionary json);
    }

    // @interface CTInAppNotification : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    [Protocol]
    interface CTInAppNotification
    {
        // @property (readonly, nonatomic) NSString * Id;
        [Export("Id")]
        string Id { get; }

        // @property (readonly, nonatomic) NSString * campaignId;
        [Export("campaignId")]
        string CampaignId { get; }

        // @property (readonly, copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, nonatomic) CTInAppType inAppType;
        [Export("inAppType")]
        CTInAppType InAppType { get; }

        // @property (readonly, copy, nonatomic) NSString * html;
        [Export("html")]
        string Html { get; }

        // @property (readonly, copy, nonatomic) NSString * url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, nonatomic) BOOL excludeFromCaps;
        [Export("excludeFromCaps")]
        bool ExcludeFromCaps { get; }

        // @property (readonly, nonatomic) BOOL showClose;
        [Export("showClose")]
        bool ShowClose { get; }

        // @property (readonly, nonatomic) BOOL darkenScreen;
        [Export("darkenScreen")]
        bool DarkenScreen { get; }

        // @property (readonly, nonatomic) int maxPerSession;
        [Export("maxPerSession")]
        int MaxPerSession { get; }

        // @property (readonly, nonatomic) int totalLifetimeCount;
        [Export("totalLifetimeCount")]
        int TotalLifetimeCount { get; }

        // @property (readonly, nonatomic) int totalDailyCount;
        [Export("totalDailyCount")]
        int TotalDailyCount { get; }

        // @property (readonly, nonatomic) NSInteger timeToLive;
        [Export("timeToLive")]
        nint TimeToLive { get; }

        // @property (readonly, assign, nonatomic) char position;
        [Export("position")]
        sbyte Position { get; }

        // @property (readonly, assign, nonatomic) float height;
        [Export("height")]
        float Height { get; }

        // @property (readonly, assign, nonatomic) float heightPercent;
        [Export("heightPercent")]
        float HeightPercent { get; }

        // @property (readonly, assign, nonatomic) float width;
        [Export("width")]
        float Width { get; }

        // @property (readonly, assign, nonatomic) float widthPercent;
        [Export("widthPercent")]
        float WidthPercent { get; }

        // @property (readonly, nonatomic) NSData * image;
        [Export("image")]
        NSData Image { get; }

        // @property (readonly, nonatomic) NSData * imageLandscape;
        [Export("imageLandscape")]
        NSData ImageLandscape { get; }

        // @property (readonly, copy, nonatomic) NSString * contentType;
        [Export("contentType")]
        string ContentType { get; }

        // @property (readonly, copy, nonatomic) NSString * mediaUrl;
        [Export("mediaUrl")]
        string MediaUrl { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsVideo;
        [Export("mediaIsVideo")]
        bool MediaIsVideo { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsAudio;
        [Export("mediaIsAudio")]
        bool MediaIsAudio { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsImage;
        [Export("mediaIsImage")]
        bool MediaIsImage { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsGif;
        [Export("mediaIsGif")]
        bool MediaIsGif { get; }

        // @property (readonly, copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * titleColor;
        [Export("titleColor")]
        string TitleColor { get; }

        // @property (readonly, copy, nonatomic) NSString * message;
        [Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSString * messageColor;
        [Export("messageColor")]
        string MessageColor { get; }

        // @property (readonly, copy, nonatomic) NSString * backgroundColor;
        [Export("backgroundColor")]
        string BackgroundColor { get; }

        // @property (readonly, assign, nonatomic) BOOL showCloseButton;
        [Export("showCloseButton")]
        bool ShowCloseButton { get; }

        // @property (readonly, assign, nonatomic) BOOL tablet;
        [Export("tablet")]
        bool Tablet { get; }

        // @property (readonly, assign, nonatomic) BOOL hasLandscape;
        [Export("hasLandscape")]
        bool HasLandscape { get; }

        // @property (readonly, assign, nonatomic) BOOL hasPortrait;
        [Export("hasPortrait")]
        bool HasPortrait { get; }

        // @property (readonly, nonatomic) NSArray<CTNotificationButton *> * buttons;
        [Export("buttons")]
        CTNotificationButton[] Buttons { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * jsonDescription;
        [Export("jsonDescription", ArgumentSemantic.Copy)]
        NSDictionary JsonDescription { get; }

        // @property (readonly, nonatomic) NSString * error;
        [Export("error")]
        string Error { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * customExtras;
        [Export("customExtras", ArgumentSemantic.Copy)]
        NSDictionary CustomExtras { get; }

        // @property (readwrite, copy, nonatomic) NSDictionary * actionExtras;
        [Export("actionExtras", ArgumentSemantic.Copy)]
        NSDictionary ActionExtras { get; set; }

        // -(instancetype)initWithJSON:(NSDictionary *)json;
        [Export("initWithJSON:")]
        IntPtr Constructor(NSDictionary json);

        // -(void)prepareWithCompletionHandler:(void (^)(void))completionHandler;
        [Export("prepareWithCompletionHandler:")]
        void PrepareWithCompletionHandler(Action completionHandler);
    }

    // @interface CleverTapJSInterface : NSObject <WKScriptMessageHandler>
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapJSInterface : IWKScriptMessageHandler
    {
        // @property (nonatomic, strong) WKUserContentController * userContentController;
        [Export("userContentController", ArgumentSemantic.Strong)]
        WKUserContentController UserContentController { get; set; }

        // -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config;
        [Export("initWithConfig:")]
        IntPtr Constructor(CleverTapInstanceConfig config);
    }

    // @protocol CTInAppNotificationDisplayDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CTInAppNotificationDisplayDelegate
    {
        // @required -(void)handleNotificationCTA:(NSURL *)ctaURL buttonCustomExtras:(NSDictionary *)buttonCustomExtras forNotification:(CTInAppNotification *)notification fromViewController:(CTInAppDisplayViewController *)controller withExtras:(NSDictionary *)extras;
        [Abstract]
        [Export("handleNotificationCTA:buttonCustomExtras:forNotification:fromViewController:withExtras:")]
        void HandleNotificationCTA(NSUrl ctaURL, NSDictionary buttonCustomExtras, CTInAppNotification notification, CTInAppDisplayViewController controller, NSDictionary extras);

        // @required -(void)notificationDidDismiss:(CTInAppNotification *)notification fromViewController:(CTInAppDisplayViewController *)controller;
        [Abstract]
        [Export("notificationDidDismiss:fromViewController:")]
        void NotificationDidDismiss(CTInAppNotification notification, CTInAppDisplayViewController controller);

        // @optional -(void)notificationDidShow:(CTInAppNotification *)notification fromViewController:(CTInAppDisplayViewController *)controller;
        [Export("notificationDidShow:fromViewController:")]
        void NotificationDidShow(CTInAppNotification notification, CTInAppDisplayViewController controller);
    }

    // @interface CTInAppDisplayViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    [Protocol]
    [DisableDefaultCtor]
    interface CTInAppDisplayViewController
    {
        [Wrap("WeakDelegate")]
        CTInAppNotificationDisplayDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CTInAppNotificationDisplayDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) CTInAppNotification * notification;
        [Export("notification", ArgumentSemantic.Strong)]
        CTInAppNotification Notification { get; }

        // -(instancetype)initWithNotification:(CTInAppNotification *)notification;
        [Export("initWithNotification:")]
        IntPtr Constructor(CTInAppNotification notification);

        // -(instancetype)initWithNotification:(CTInAppNotification *)notification jsInterface:(CleverTapJSInterface *)jsInterface;
        [Export("initWithNotification:jsInterface:")]
        IntPtr Constructor(CTInAppNotification notification, CleverTapJSInterface jsInterface);

        // -(void)show:(BOOL)animated;
        [Export("show:")]
        void Show(bool animated);

        // -(void)hide:(BOOL)animated;
        [Export("hide:")]
        void Hide(bool animated);

        // -(BOOL)deviceOrientationIsLandscape;
        [Export("deviceOrientationIsLandscape")]
        bool DeviceOrientationIsLandscape { get; }
    }

    // @interface CTInAppPassThroughWindow : UIWindow
    [BaseType(typeof(UIWindow))]
    [Protocol]
    interface CTInAppPassThroughWindow
    {
    }

    // @protocol CTInAppPassThroughViewDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CTInAppPassThroughViewDelegate
    {
        // @required -(void)viewWillPassThroughTouch;
        [Abstract]
        [Export("viewWillPassThroughTouch")]
        void ViewWillPassThroughTouch();
    }

    // @interface CTInAppPassThroughView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface CTInAppPassThroughView
    {
        [Wrap("WeakDelegate")]
        CTInAppPassThroughViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CTInAppPassThroughViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }
    }

    // @interface  (CTInAppDisplayViewController) <CTInAppPassThroughViewDelegate>
    [Category]
    [BaseType(typeof(CTInAppDisplayViewController))]
    interface CTInAppDisplayViewController_ //awak: CTInAppPassThroughViewDelegate
    {
        // @property (nonatomic, strong) UIWindow * window;
        [Static]
        [Export("window", ArgumentSemantic.Strong)]
        UIWindow Window { get; set; }

        // @property (readwrite, nonatomic, strong) CTInAppNotification * notification;
        [Static]
        [Export("notification", ArgumentSemantic.Strong)]
        CTInAppNotification Notification { get; set; }

        // @property (assign, nonatomic) BOOL shouldPassThroughTouches;
        [Static]
        [Export("shouldPassThroughTouches")]
        bool ShouldPassThroughTouches { get; set; }

        // -(void)showFromWindow:(BOOL)animated;
        [Export("showFromWindow:")]
        void ShowFromWindow(bool animated);

        // -(void)hideFromWindow:(BOOL)animated;
        [Export("hideFromWindow:")]
        void HideFromWindow(bool animated);

        // -(void)tappedDismiss;
        [Export("tappedDismiss")]
        void TappedDismiss();

        // -(void)buttonTapped:(UIButton *)button;
        [Export("buttonTapped:")]
        void ButtonTapped(UIButton button);

        // -(void)handleButtonClickFromIndex:(int)index;
        [Export("handleButtonClickFromIndex:")]
        void HandleButtonClickFromIndex(int index);

        // -(void)handleImageTapGesture;
        [Export("handleImageTapGesture")]
        void HandleImageTapGesture();

        // -(UIButton *)setupViewForButton:(UIButton *)buttonView withData:(CTNotificationButton *)button withIndex:(NSInteger)index;
        [Export("setupViewForButton:withData:withIndex:")]
        UIButton SetupViewForButton(UIButton buttonView, CTNotificationButton button, nint index);
    }

    // @interface CTInAppFCManager : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CTInAppFCManager
    {
        // -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config guid:(NSString *)guid;
        [Export("initWithConfig:guid:")]
        IntPtr Constructor(CleverTapInstanceConfig config, string guid);

        // -(void)checkUpdateDailyLimits;
        [Export("checkUpdateDailyLimits")]
        void CheckUpdateDailyLimits();

        // -(BOOL)canShow:(CTInAppNotification *)inapp;
        [Export("canShow:")]
        bool CanShow(CTInAppNotification inapp);

        // -(void)didDismiss:(CTInAppNotification *)inapp;
        [Export("didDismiss:")]
        void DidDismiss(CTInAppNotification inapp);

        // -(void)resetSession;
        [Export("resetSession")]
        void ResetSession();

        // -(void)changeUserWithGuid:(NSString *)guid;
        [Export("changeUserWithGuid:")]
        void ChangeUserWithGuid(string guid);

        // -(void)didShow:(CTInAppNotification *)inapp;
        [Export("didShow:")]
        void DidShow(CTInAppNotification inapp);

        // -(void)updateLimitsPerDay:(int)perDay andPerSession:(int)perSession;
        [Export("updateLimitsPerDay:andPerSession:")]
        void UpdateLimitsPerDay(int perDay, int perSession);

        // -(void)attachToHeader:(NSMutableDictionary *)header;
        [Export("attachToHeader:")]
        void AttachToHeader(NSMutableDictionary header);

        // -(void)processResponse:(NSDictionary *)response;
        [Export("processResponse:")]
        void ProcessResponse(NSDictionary response);

        // -(BOOL)hasLifetimeCapacityMaxedOut:(CTInAppNotification *)dictionary;
        [Export("hasLifetimeCapacityMaxedOut:")]
        bool HasLifetimeCapacityMaxedOut(CTInAppNotification dictionary);

        // -(BOOL)hasDailyCapacityMaxedOut:(CTInAppNotification *)dictionary;
        [Export("hasDailyCapacityMaxedOut:")]
        bool HasDailyCapacityMaxedOut(CTInAppNotification dictionary);
    }

    // @interface CTKnownProfileFields : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTKnownProfileFields
    {
        // +(NSString *)getStorageValueForField:(KnownField)field;
        [Static]
        [Export("getStorageValueForField:")]
        string GetStorageValueForField(KnownField field);

        // +(KnownField)getKnownFieldIfPossibleForKey:(NSString *)key;
        [Static]
        [Export("getKnownFieldIfPossibleForKey:")]
        KnownField GetKnownFieldIfPossibleForKey(string key);
    }

    // @interface CTLegacyIdentityRepo : NSObject <CTIdentityRepo>
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTLegacyIdentityRepo : CTIdentityRepo
    {
    }

    // @interface CTLocalDataStore : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTLocalDataStore
    {
        // -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config profileValues:(NSDictionary *)profileValues andDeviceInfo:(CTDeviceInfo *)deviceInfo;
        [Export("initWithConfig:profileValues:andDeviceInfo:")]
        IntPtr Constructor(CleverTapInstanceConfig config, NSDictionary profileValues, CTDeviceInfo deviceInfo);

        // -(void)persistEvent:(NSDictionary *)event;
        [Export("persistEvent:")]
        void PersistEvent(NSDictionary @event);

        // -(void)addDataSyncFlag:(NSMutableDictionary *)event;
        [Export("addDataSyncFlag:")]
        void AddDataSyncFlag(NSMutableDictionary @event);

        // -(NSDictionary *)syncWithRemoteData:(NSDictionary *)responseData;
        [Export("syncWithRemoteData:")]
        NSDictionary SyncWithRemoteData(NSDictionary responseData);

        // -(NSTimeInterval)getFirstTimeForEvent:(NSString *)event;
        [Export("getFirstTimeForEvent:")]
        double GetFirstTimeForEvent(string @event);

        // -(NSTimeInterval)getLastTimeForEvent:(NSString *)event;
        [Export("getLastTimeForEvent:")]
        double GetLastTimeForEvent(string @event);

        // -(int)getOccurrencesForEvent:(NSString *)event;
        [Export("getOccurrencesForEvent:")]
        int GetOccurrencesForEvent(string @event);

        // -(NSDictionary *)getEventHistory;
        [Export("getEventHistory")]
        NSDictionary EventHistory { get; }

        // -(CleverTapEventDetail *)getEventDetail:(NSString *)event;
        [Export("getEventDetail:")]
        CleverTapEventDetail GetEventDetail(string @event);

        // -(void)setProfileFields:(NSDictionary *)fields;
        [Export("setProfileFields:")]
        void SetProfileFields(NSDictionary fields);

        // -(void)setProfileFieldWithKey:(NSString *)key andValue:(id)value;
        [Export("setProfileFieldWithKey:andValue:")]
        void SetProfileFieldWithKey(string key, NSObject value);

        // -(void)removeProfileFieldsWithKeys:(NSArray *)keys;
        [Export("removeProfileFieldsWithKeys:")]
        void RemoveProfileFieldsWithKeys(NSObject[] keys);

        // -(void)removeProfileFieldForKey:(NSString *)key;
        [Export("removeProfileFieldForKey:")]
        void RemoveProfileFieldForKey(string key);

        // -(id)getProfileFieldForKey:(NSString *)key;
        [Export("getProfileFieldForKey:")]
        NSObject GetProfileFieldForKey(string key);

        // -(void)persistLocalProfileIfRequired;
        [Export("persistLocalProfileIfRequired")]
        void PersistLocalProfileIfRequired();

        // -(NSDictionary *)generateBaseProfile;
        [Export("generateBaseProfile")]
        NSDictionary GenerateBaseProfile { get; }

        // -(void)changeUser;
        [Export("changeUser")]
        void ChangeUser();
    }

    // @interface CTLocationManager : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTLocationManager
    {
    }

    // @interface CTLoginInfoProvider : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTLoginInfoProvider
    {
        // -(void)cacheGUID:(NSString *)guid forKey:(NSString *)key andIdentifier:(NSString *)identifier;
        [Export("cacheGUID:forKey:andIdentifier:")]
        void CacheGUID(string guid, string key, string identifier);

        // -(BOOL)deviceIsMultiUser;
        [Export("deviceIsMultiUser")]
        bool DeviceIsMultiUser { get; }

        // -(NSDictionary *)getCachedGUIDs;
        [Export("getCachedGUIDs")]
        NSDictionary CachedGUIDs { get; }

        // -(void)setCachedGUIDs:(NSDictionary *)cache;
        [Export("setCachedGUIDs:")]
        void SetCachedGUIDs(NSDictionary cache);

        // -(NSString *)getCachedIdentities;
        [Export("getCachedIdentities")]
        string CachedIdentities { get; }

        // -(NSString *)getGUIDforKey:(NSString *)key andIdentifier:(NSString *)identifier;
        [Export("getGUIDforKey:andIdentifier:")]
        string GetGUIDforKey(string key, string identifier);

        // -(BOOL)isAnonymousDevice;
        [Export("isAnonymousDevice")]
        bool IsAnonymousDevice { get; }

        // -(BOOL)isLegacyProfileLoggedIn;
        [Export("isLegacyProfileLoggedIn")]
        bool IsLegacyProfileLoggedIn { get; }

        // -(void)setCachedIdentities:(NSString *)cache;
        [Export("setCachedIdentities:")]
        void SetCachedIdentities(string cache);

        // -(instancetype)initWithDeviceInfo:(CTDeviceInfo *)deviceInfo config:(CleverTapInstanceConfig *)config;
        [Export("initWithDeviceInfo:config:")]
        IntPtr Constructor(CTDeviceInfo deviceInfo, CleverTapInstanceConfig config);

        // -(void)removeValueFromCachedGUIDForKey:(NSString *)key andGuid:(NSString *)guid;
        [Export("removeValueFromCachedGUIDForKey:andGuid:")]
        void RemoveValueFromCachedGUIDForKey(string key, string guid);
    }

    // @interface CTPlistInfo : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTPlistInfo
    {
        // @property (readonly, nonatomic, strong) NSString * _Nullable accountId;
        [NullAllowed, Export("accountId", ArgumentSemantic.Strong)]
        string AccountId { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable accountToken;
        [NullAllowed, Export("accountToken", ArgumentSemantic.Strong)]
        string AccountToken { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable accountRegion;
        [NullAllowed, Export("accountRegion", ArgumentSemantic.Strong)]
        string AccountRegion { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable proxyDomain;
        [NullAllowed, Export("proxyDomain", ArgumentSemantic.Strong)]
        string ProxyDomain { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable spikyProxyDomain;
        [NullAllowed, Export("spikyProxyDomain", ArgumentSemantic.Strong)]
        string SpikyProxyDomain { get; }

        // @property (readonly, nonatomic, strong) NSArray<NSString *> * _Nullable registeredUrlSchemes;
        [NullAllowed, Export("registeredUrlSchemes", ArgumentSemantic.Strong)]
        string[] RegisteredUrlSchemes { get; }

        // @property (readonly, assign, nonatomic) BOOL disableAppLaunchedEvent;
        [Export("disableAppLaunchedEvent")]
        bool DisableAppLaunchedEvent { get; }

        // @property (readonly, assign, nonatomic) BOOL useCustomCleverTapId;
        [Export("useCustomCleverTapId")]
        bool UseCustomCleverTapId { get; }

        // @property (readonly, assign, nonatomic) BOOL beta;
        [Export("beta")]
        bool Beta { get; }

        // @property (readonly, assign, nonatomic) BOOL disableIDFV;
        [Export("disableIDFV")]
        bool DisableIDFV { get; }

        // +(instancetype _Nullable)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        [return: NullAllowed]
        CTPlistInfo SharedInstance();

        // -(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token region:(NSString * _Nullable)region;
        [Export("setCredentialsWithAccountID:token:region:")]
        void SetCredentialsWithAccountID(string accountID, string token, [NullAllowed] string region);

        // -(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token proxyDomain:(NSString * _Nonnull)proxyDomain;
        // TODO:
        //[Export("setCredentialsWithAccountID:token:proxyDomain:")]
        //void SetCredentialsWithAccountID(string accountID, string token, string proxyDomain);

        // -(void)setCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token proxyDomain:(NSString * _Nonnull)proxyDomain spikyProxyDomain:(NSString * _Nonnull)spikyProxyDomain;
        [Export("setCredentialsWithAccountID:token:proxyDomain:spikyProxyDomain:")]
        void SetCredentialsWithAccountID(string accountID, string token, string proxyDomain, string spikyProxyDomain);
    }

    // @interface CTPreferences : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTPreferences
    {
        // +(long)getIntForKey:(NSString * _Nonnull)key withResetValue:(long)resetValue;
        [Static]
        [Export("getIntForKey:withResetValue:")]
        nint GetIntForKey(string key, nint resetValue);

        // +(void)putInt:(long)resetValue forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("putInt:forKey:")]
        void PutInt(nint resetValue, string key);

        // +(NSString * _Nonnull)getStringForKey:(NSString * _Nonnull)key withResetValue:(NSString * _Nullable)resetValue;
        [Static]
        [Export("getStringForKey:withResetValue:")]
        string GetStringForKey(string key, [NullAllowed] string resetValue);

        // +(void)putString:(NSString * _Nonnull)resetValue forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("putString:forKey:")]
        void PutString(string resetValue, string key);

        // +(id _Nonnull)getObjectForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("getObjectForKey:")]
        NSObject GetObjectForKey(string key);

        // +(void)putObject:(id _Nonnull)object forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("putObject:forKey:")]
        void PutObject(NSObject @object, string key);

        // +(void)removeObjectForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("removeObjectForKey:")]
        void RemoveObjectForKey(string key);

        // +(id _Nonnull)unarchiveFromFile:(NSString * _Nonnull)filename ofType:(Class _Nonnull)cls removeFile:(BOOL)remove;
        [Static]
        [Export("unarchiveFromFile:ofType:removeFile:")]
        NSObject UnarchiveFromFile(string filename, Class cls, bool remove);

        // +(id _Nonnull)unarchiveFromFile:(NSString * _Nonnull)filename ofTypes:(NSSet<Class> * _Nonnull)classes removeFile:(BOOL)remove;
        [Static]
        [Export("unarchiveFromFile:ofTypes:removeFile:")]
        NSObject UnarchiveFromFile(string filename, NSSet<Class> classes, bool remove);

        // +(BOOL)archiveObject:(id _Nonnull)object forFileName:(NSString * _Nonnull)fileName;
        [Static]
        [Export("archiveObject:forFileName:")]
        bool ArchiveObject(NSObject @object, string fileName);

        // +(NSString *)storageKeyWithSuffix:(NSString *)suffix config:(CleverTapInstanceConfig *)config;
        [Static]
        [Export("storageKeyWithSuffix:config:")]
        string StorageKeyWithSuffix(string suffix, CleverTapInstanceConfig config);
    }

    // @interface CTProfileBuilder : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTProfileBuilder
    {
        // +(void)build:(NSDictionary * _Nonnull)profile completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("build:completionHandler:")]
        void Build(NSDictionary profile, Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildRemoveValueForKey:(NSString * _Nonnull)key completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildRemoveValueForKey:completionHandler:")]
        void BuildRemoveValueForKey(string key, Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion);

        // +(void)buildSetMultiValues:(NSArray<NSString *> * _Nonnull)values forKey:(NSString * _Nullable)key localDataStore:(CTLocalDataStore * _Nullable)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildSetMultiValues:forKey:localDataStore:completionHandler:")]
        void BuildSetMultiValues(string[] values, [NullAllowed] string key, [NullAllowed] CTLocalDataStore dataStore, Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion);

        // +(void)buildAddMultiValue:(NSString * _Nonnull)value forKey:(NSString * _Nullable)key localDataStore:(CTLocalDataStore * _Nullable)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildAddMultiValue:forKey:localDataStore:completionHandler:")]
        void BuildAddMultiValue(string value, [NullAllowed] string key, [NullAllowed] CTLocalDataStore dataStore, Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion);

        // +(void)buildAddMultiValues:(NSArray<NSString *> * _Nonnull)values forKey:(NSString * _Nullable)key localDataStore:(CTLocalDataStore * _Nullable)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildAddMultiValues:forKey:localDataStore:completionHandler:")]
        void BuildAddMultiValues(string[] values, [NullAllowed] string key, [NullAllowed] CTLocalDataStore dataStore, Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion);

        // +(void)buildRemoveMultiValue:(NSString * _Nonnull)value forKey:(NSString * _Nullable)key localDataStore:(CTLocalDataStore * _Nullable)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildRemoveMultiValue:forKey:localDataStore:completionHandler:")]
        void BuildRemoveMultiValue(string value, [NullAllowed] string key, [NullAllowed] CTLocalDataStore dataStore, Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion);

        // +(void)buildRemoveMultiValues:(NSArray<NSString *> * _Nonnull)values forKey:(NSString * _Nullable)key localDataStore:(CTLocalDataStore * _Nullable)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSArray * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildRemoveMultiValues:forKey:localDataStore:completionHandler:")]
        void BuildRemoveMultiValues(string[] values, [NullAllowed] string key, [NullAllowed] CTLocalDataStore dataStore, Action<NSDictionary, NSArray, NSArray<CTValidationResult>> completion);

        // +(void)buildIncrementValueBy:(NSNumber * _Nonnull)value forKey:(NSString * _Nonnull)key localDataStore:(CTLocalDataStore * _Nonnull)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSNumber * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildIncrementValueBy:forKey:localDataStore:completionHandler:")]
        void BuildIncrementValueBy(NSNumber value, string key, CTLocalDataStore dataStore, Action<NSDictionary, NSNumber, NSArray<CTValidationResult>> completion);

        // +(void)buildDecrementValueBy:(NSNumber * _Nonnull)value forKey:(NSString * _Nonnull)key localDataStore:(CTLocalDataStore * _Nonnull)dataStore completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSNumber * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
        [Static]
        [Export("buildDecrementValueBy:forKey:localDataStore:completionHandler:")]
        void BuildDecrementValueBy(NSNumber value, string key, CTLocalDataStore dataStore, Action<NSDictionary, NSNumber, NSArray<CTValidationResult>> completion);
    }

    // @interface CTSwizzle (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_CTSwizzle
    {
        // +(BOOL)ct_swizzleMethod:(SEL)origSel_ withMethod:(SEL)altSel_ error:(NSError **)error_;
        [Static]
        [Export("ct_swizzleMethod:withMethod:error:")]
        bool Ct_swizzleMethod(Selector origSel_, Selector altSel_, out NSError error_);

        // +(BOOL)ct_swizzleClassMethod:(SEL)origSel_ withClassMethod:(SEL)altSel_ error:(NSError **)error_;
        [Static]
        [Export("ct_swizzleClassMethod:withClassMethod:error:")]
        bool Ct_swizzleClassMethod(Selector origSel_, Selector altSel_, out NSError error_);

        // +(NSInvocation *)ct_swizzleMethod:(SEL)origSel withBlock:(id)block error:(NSError **)error;
        [Static]
        [Export("ct_swizzleMethod:withBlock:error:")]
        NSInvocation Ct_swizzleMethod(Selector origSel, NSObject block, out NSError error);

        // +(NSInvocation *)ct_swizzleClassMethod:(SEL)origSel withBlock:(id)block error:(NSError **)error;
        [Static]
        [Export("ct_swizzleClassMethod:withBlock:error:")]
        NSInvocation Ct_swizzleClassMethod(Selector origSel, NSObject block, out NSError error);
    }

    // @interface CTUIUtils : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTUIUtils
    {
        // +(NSBundle * _Nonnull)bundle;
        [Static]
        [Export("bundle")]
        NSBundle Bundle { get; }

        // +(NSBundle * _Nonnull)bundle:(Class _Nonnull)bundleClass;
        // TODO:
        //[Static]
        //[Export("bundle:")]
        //NSBundle Bundle(Class bundleClass);

        // +(UIApplication * _Nullable)getSharedApplication;
        [Static]
        [NullAllowed, Export("getSharedApplication")]
        UIApplication SharedApplication { get; }

        // +(UIWindow * _Nullable)getKeyWindow;
        [Static]
        [NullAllowed, Export("getKeyWindow")]
        UIWindow KeyWindow { get; }

        // +(BOOL)isDeviceOrientationLandscape;
        [Static]
        [Export("isDeviceOrientationLandscape")]
        bool IsDeviceOrientationLandscape { get; }

        // +(BOOL)isUserInterfaceIdiomPad;
        [Static]
        [Export("isUserInterfaceIdiomPad")]
        bool IsUserInterfaceIdiomPad { get; }

        // +(CGFloat)getLeftMargin;
        [Static]
        [Export("getLeftMargin")]
        nfloat LeftMargin { get; }

        // +(UIImage * _Nonnull)getImageForName:(NSString * _Nonnull)name;
        [Static]
        [Export("getImageForName:")]
        UIImage GetImageForName(string name);

        // +(UIColor * _Nonnull)ct_colorWithHexString:(NSString * _Nonnull)string;
        [Static]
        [Export("ct_colorWithHexString:")]
        UIColor Ct_colorWithHexString(string @string);

        // +(UIColor * _Nonnull)ct_colorWithHexString:(NSString * _Nonnull)string withAlpha:(CGFloat)alpha;
        [Static]
        [Export("ct_colorWithHexString:withAlpha:")]
        UIColor Ct_colorWithHexString(string @string, nfloat alpha);
    }

    // @interface CTUriHelper : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTUriHelper
    {
        // +(NSDictionary *)getUrchinFromUri:(NSString *)uri withSourceApp:(NSString *)sourceApp;
        [Static]
        [Export("getUrchinFromUri:withSourceApp:")]
        NSDictionary GetUrchinFromUri(string uri, string sourceApp);

        // +(NSDictionary *)getQueryParameters:(NSURL *)url andDecode:(BOOL)decode;
        [Static]
        [Export("getQueryParameters:andDecode:")]
        NSDictionary GetQueryParameters(NSUrl url, bool decode);
    }

    // @interface CTUtils : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTUtils
    {
        // +(NSString *)dictionaryToJsonString:(NSDictionary *)dict;
        [Static]
        [Export("dictionaryToJsonString:")]
        string DictionaryToJsonString(NSDictionary dict);

        // +(NSString *)urlEncodeString:(NSString *)s;
        [Static]
        [Export("urlEncodeString:")]
        string UrlEncodeString(string s);

        // +(BOOL)doesString:(NSString *)s startWith:(NSString *)prefix;
        [Static]
        [Export("doesString:startWith:")]
        bool DoesString(string s, string prefix);

        // +(NSString *)deviceTokenStringFromData:(NSData *)tokenData;
        [Static]
        [Export("deviceTokenStringFromData:")]
        string DeviceTokenStringFromData(NSData tokenData);

        // +(double)toTwoPlaces:(double)x;
        [Static]
        [Export("toTwoPlaces:")]
        double ToTwoPlaces(double x);
    }

    // @interface CTValidator : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CTValidator
    {
        // +(CTValidationResult *)cleanEventName:(NSString *)name;
        [Static]
        [Export("cleanEventName:")]
        CTValidationResult CleanEventName(string name);

        // +(CTValidationResult *)cleanObjectKey:(NSString *)name;
        [Static]
        [Export("cleanObjectKey:")]
        CTValidationResult CleanObjectKey(string name);

        // +(CTValidationResult *)cleanMultiValuePropertyKey:(NSString *)name;
        [Static]
        [Export("cleanMultiValuePropertyKey:")]
        CTValidationResult CleanMultiValuePropertyKey(string name);

        // +(CTValidationResult *)cleanMultiValuePropertyValue:(NSString *)value;
        [Static]
        [Export("cleanMultiValuePropertyValue:")]
        CTValidationResult CleanMultiValuePropertyValue(string value);

        // +(CTValidationResult *)cleanMultiValuePropertyArray:(NSArray *)multi forKey:(NSString *)key;
        [Static]
        [Export("cleanMultiValuePropertyArray:forKey:")]
        CTValidationResult CleanMultiValuePropertyArray(NSObject[] multi, string key);

        // +(CTValidationResult *)cleanObjectValue:(NSObject *)o context:(CTValidatorContext)context;
        [Static]
        [Export("cleanObjectValue:context:")]
        CTValidationResult CleanObjectValue(NSObject o, CTValidatorContext context);

        // +(BOOL)isRestrictedEventName:(NSString *)name;
        [Static]
        [Export("isRestrictedEventName:")]
        bool IsRestrictedEventName(string name);

        // +(BOOL)isDiscaredEventName:(NSString *)name;
        [Static]
        [Export("isDiscaredEventName:")]
        bool IsDiscaredEventName(string name);

        // +(void)setDiscardedEvents:(NSArray *)events;
        [Static]
        [Export("setDiscardedEvents:")]
        void SetDiscardedEvents(NSObject[] events);

        // +(BOOL)isValidCleverTapId:(NSString *)cleverTapID;
        [Static]
        [Export("isValidCleverTapId:")]
        bool IsValidCleverTapId(string cleverTapID);
    }

    // @interface CleverTapDisplayUnit : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapDisplayUnit
    {
        // -(instancetype _Nullable)initWithJSON:(NSDictionary * _Nullable)json;
        [Export("initWithJSON:")]
        IntPtr Constructor([NullAllowed] NSDictionary json);

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable json;
        [NullAllowed, Export("json", ArgumentSemantic.Copy)]
        NSDictionary Json { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable unitID;
        [NullAllowed, Export("unitID")]
        string UnitID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable type;
        [NullAllowed, Export("type")]
        string Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bgColor;
        [NullAllowed, Export("bgColor")]
        string BgColor { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable customExtras;
        [NullAllowed, Export("customExtras", ArgumentSemantic.Copy)]
        NSDictionary CustomExtras { get; }

        // @property (readonly, copy, nonatomic) NSArray<CleverTapDisplayUnitContent *> * _Nullable contents;
        [NullAllowed, Export("contents", ArgumentSemantic.Copy)]
        CleverTapDisplayUnitContent[] Contents { get; }
    }

    // @interface CleverTapDisplayUnitContent : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapDisplayUnitContent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable titleColor;
        [NullAllowed, Export("titleColor")]
        string TitleColor { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageColor;
        [NullAllowed, Export("messageColor")]
        string MessageColor { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable videoPosterUrl;
        [NullAllowed, Export("videoPosterUrl")]
        string VideoPosterUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable actionUrl;
        [NullAllowed, Export("actionUrl")]
        string ActionUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaUrl;
        [NullAllowed, Export("mediaUrl")]
        string MediaUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable iconUrl;
        [NullAllowed, Export("iconUrl")]
        string IconUrl { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsAudio;
        [Export("mediaIsAudio")]
        bool MediaIsAudio { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsVideo;
        [Export("mediaIsVideo")]
        bool MediaIsVideo { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsImage;
        [Export("mediaIsImage")]
        bool MediaIsImage { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsGif;
        [Export("mediaIsGif")]
        bool MediaIsGif { get; }

        // -(instancetype _Nullable)initWithJSON:(NSDictionary * _Nullable)jsonObject;
        [Export("initWithJSON:")]
        IntPtr Constructor([NullAllowed] NSDictionary jsonObject);
    }

    // @protocol CleverTapDisplayUnitDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapDisplayUnitDelegate
    {
        // @optional -(void)displayUnitsUpdated:(NSArray<CleverTapDisplayUnit *> * _Nonnull)displayUnits;
        [Export("displayUnitsUpdated:")]
        void DisplayUnitsUpdated(CleverTapDisplayUnit[] displayUnits);
    }

    // typedef void (^CleverTapDisplayUnitSuccessBlock)(BOOL);
    delegate void CleverTapDisplayUnitSuccessBlock(bool arg0);

    // @interface DisplayUnit (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_DisplayUnit
    {
        // -(NSArray<CleverTapDisplayUnit *> * _Nonnull)getAllDisplayUnits;
        [Export("getAllDisplayUnits")]
        CleverTapDisplayUnit[] AllDisplayUnits();

        // -(CleverTapDisplayUnit * _Nullable)getDisplayUnitForID:(NSString * _Nonnull)unitID;
        [Export("getDisplayUnitForID:")]
        [return: NullAllowed]
        CleverTapDisplayUnit GetDisplayUnitForID(string unitID);

        // -(void)setDisplayUnitDelegate:(id<CleverTapDisplayUnitDelegate> _Nonnull)delegate;
        [Export("setDisplayUnitDelegate:")]
        void SetDisplayUnitDelegate(CleverTapDisplayUnitDelegate @delegate);

        // -(void)recordDisplayUnitViewedEventForID:(NSString * _Nonnull)unitID;
        [Export("recordDisplayUnitViewedEventForID:")]
        void RecordDisplayUnitViewedEventForID(string unitID);

        // -(void)recordDisplayUnitClickedEventForID:(NSString * _Nonnull)unitID;
        [Export("recordDisplayUnitClickedEventForID:")]
        void RecordDisplayUnitClickedEventForID(string unitID);
    }

    // @protocol CleverTapFeatureFlagsDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapFeatureFlagsDelegate
    {
        // @optional -(void)ctFeatureFlagsUpdated;
        [Export("ctFeatureFlagsUpdated")]
        void CtFeatureFlagsUpdated();
    }

    // @interface FeatureFlags (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_FeatureFlags
    {
        // @property (readonly, atomic, strong) CleverTapFeatureFlags * _Nonnull featureFlags;
        [Static]
        [Export("featureFlags", ArgumentSemantic.Strong)]
        CleverTapFeatureFlags FeatureFlags { get; }
    }

    // @interface CleverTapFeatureFlags : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapFeatureFlags
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        CleverTapFeatureFlagsDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CleverTapFeatureFlagsDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(BOOL)get:(NSString * _Nonnull)key withDefaultValue:(BOOL)defaultValue;
        [Export("get:withDefaultValue:")]
        bool Get(string key, bool defaultValue);
    }

    // @interface InAppNotifications (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_InAppNotifications
    {
        // -(void)suspendInAppNotifications;
        [Export("suspendInAppNotifications")]
        void SuspendInAppNotifications();

        // -(void)discardInAppNotifications;
        [Export("discardInAppNotifications")]
        void DiscardInAppNotifications();

        // -(void)resumeInAppNotifications;
        [Export("resumeInAppNotifications")]
        void ResumeInAppNotifications();
    }

    // @interface CleverTapInboxMessage : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapInboxMessage
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable json;
        [NullAllowed, Export("json", ArgumentSemantic.Copy)]
        NSDictionary Json { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable customData;
        [NullAllowed, Export("customData", ArgumentSemantic.Copy)]
        NSDictionary CustomData { get; }

        // @property (readonly, assign, nonatomic) BOOL isRead;
        [Export("isRead")]
        bool IsRead { get; }

        // @property (readonly, assign, nonatomic) NSUInteger date;
        [Export("date")]
        nuint Date { get; }

        // @property (readonly, assign, nonatomic) NSUInteger expires;
        [Export("expires")]
        nuint Expires { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable relativeDate;
        [NullAllowed, Export("relativeDate")]
        string RelativeDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable type;
        [NullAllowed, Export("type")]
        string Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageId;
        [NullAllowed, Export("messageId")]
        string MessageId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable campaignId;
        [NullAllowed, Export("campaignId")]
        string CampaignId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable tagString;
        [NullAllowed, Export("tagString")]
        string TagString { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable tags;
        [NullAllowed, Export("tags", ArgumentSemantic.Copy)]
        NSObject[] Tags { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable orientation;
        [NullAllowed, Export("orientation")]
        string Orientation { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor")]
        string BackgroundColor { get; }

        // @property (readonly, copy, nonatomic) NSArray<CleverTapInboxMessageContent *> * _Nullable content;
        [NullAllowed, Export("content", ArgumentSemantic.Copy)]
        CleverTapInboxMessageContent[] Content { get; }

        // -(void)setRead:(BOOL)read;
        [Export("setRead:")]
        void SetRead(bool read);
    }

    // @interface CleverTapInboxMessageContent : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapInboxMessageContent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable titleColor;
        [NullAllowed, Export("titleColor")]
        string TitleColor { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageColor;
        [NullAllowed, Export("messageColor")]
        string MessageColor { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor")]
        string BackgroundColor { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mediaUrl;
        [NullAllowed, Export("mediaUrl")]
        string MediaUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable videoPosterUrl;
        [NullAllowed, Export("videoPosterUrl")]
        string VideoPosterUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable iconUrl;
        [NullAllowed, Export("iconUrl")]
        string IconUrl { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable actionUrl;
        [NullAllowed, Export("actionUrl")]
        string ActionUrl { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable links;
        [NullAllowed, Export("links", ArgumentSemantic.Copy)]
        NSObject[] Links { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsAudio;
        [Export("mediaIsAudio")]
        bool MediaIsAudio { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsVideo;
        [Export("mediaIsVideo")]
        bool MediaIsVideo { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsImage;
        [Export("mediaIsImage")]
        bool MediaIsImage { get; }

        // @property (readonly, assign, nonatomic) BOOL mediaIsGif;
        [Export("mediaIsGif")]
        bool MediaIsGif { get; }

        // @property (readonly, assign, nonatomic) BOOL actionHasUrl;
        [Export("actionHasUrl")]
        bool ActionHasUrl { get; }

        // @property (readonly, assign, nonatomic) BOOL actionHasLinks;
        [Export("actionHasLinks")]
        bool ActionHasLinks { get; }

        // -(NSString * _Nullable)urlForLinkAtIndex:(int)index;
        [Export("urlForLinkAtIndex:")]
        [return: NullAllowed]
        string UrlForLinkAtIndex(int index);

        // -(NSDictionary * _Nullable)customDataForLinkAtIndex:(int)index;
        [Export("customDataForLinkAtIndex:")]
        [return: NullAllowed]
        NSDictionary CustomDataForLinkAtIndex(int index);
    }

    // @protocol CleverTapInboxViewControllerDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapInboxViewControllerDelegate
    {
        // @optional -(void)messageDidSelect:(CleverTapInboxMessage * _Nonnull)message atIndex:(int)index withButtonIndex:(int)buttonIndex;
        [Export("messageDidSelect:atIndex:withButtonIndex:")]
        void MessageDidSelect(CleverTapInboxMessage message, int index, int buttonIndex);

        // @optional -(void)messageButtonTappedWithCustomExtras:(NSDictionary * _Nullable)customExtras;
        [Export("messageButtonTappedWithCustomExtras:")]
        void MessageButtonTappedWithCustomExtras([NullAllowed] NSDictionary customExtras);
    }

    // @interface CleverTapInboxStyleConfig : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapInboxStyleConfig
    {
        // @property (nonatomic, strong) NSString * _Nullable title;
        [NullAllowed, Export("title", ArgumentSemantic.Strong)]
        string Title { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable messageTags;
        [NullAllowed, Export("messageTags", ArgumentSemantic.Strong)]
        NSObject[] MessageTags { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navigationBarTintColor;
        [NullAllowed, Export("navigationBarTintColor", ArgumentSemantic.Strong)]
        UIColor NavigationBarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navigationTintColor;
        [NullAllowed, Export("navigationTintColor", ArgumentSemantic.Strong)]
        UIColor NavigationTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabSelectedBgColor;
        [NullAllowed, Export("tabSelectedBgColor", ArgumentSemantic.Strong)]
        UIColor TabSelectedBgColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabSelectedTextColor;
        [NullAllowed, Export("tabSelectedTextColor", ArgumentSemantic.Strong)]
        UIColor TabSelectedTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabUnSelectedTextColor;
        [NullAllowed, Export("tabUnSelectedTextColor", ArgumentSemantic.Strong)]
        UIColor TabUnSelectedTextColor { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable noMessageViewText;
        [NullAllowed, Export("noMessageViewText", ArgumentSemantic.Strong)]
        string NoMessageViewText { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable noMessageViewTextColor;
        [NullAllowed, Export("noMessageViewTextColor", ArgumentSemantic.Strong)]
        UIColor NoMessageViewTextColor { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable firstTabTitle;
        [NullAllowed, Export("firstTabTitle", ArgumentSemantic.Strong)]
        string FirstTabTitle { get; set; }
    }

    // @interface CleverTapInboxViewController : UITableViewController
    [BaseType(typeof(UITableViewController))]
    [Protocol]
    interface CleverTapInboxViewController
    {
    }

    // typedef void (^CleverTapInboxSuccessBlock)(BOOL);
    delegate void CleverTapInboxSuccessBlock(bool arg0);

    // typedef void (^CleverTapInboxUpdatedBlock)();
    delegate void CleverTapInboxUpdatedBlock();

    // @interface Inbox (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_Inbox
    {
        // -(void)initializeInboxWithCallback:(CleverTapInboxSuccessBlock _Nonnull)callback;
        [Export("initializeInboxWithCallback:")]
        void InitializeInboxWithCallback(CleverTapInboxSuccessBlock callback);

        // -(NSInteger)getInboxMessageCount;
        [Export("getInboxMessageCount")]
        nuint InboxMessageCount();

        // -(NSInteger)getInboxMessageUnreadCount;
        [Export("getInboxMessageUnreadCount")]
        nuint InboxMessageUnreadCount();

        // -(NSArray<CleverTapInboxMessage *> * _Nonnull)getAllInboxMessages;
        [Export("getAllInboxMessages")]
        CleverTapInboxMessage[] AllInboxMessages();

        // -(NSArray<CleverTapInboxMessage *> * _Nonnull)getUnreadInboxMessages;
        [Export("getUnreadInboxMessages")]
        CleverTapInboxMessage[] UnreadInboxMessages();

        // -(CleverTapInboxMessage * _Nullable)getInboxMessageForId:(NSString * _Nonnull)messageId;
        [Export("getInboxMessageForId:")]
        [return: NullAllowed]
        CleverTapInboxMessage GetInboxMessageForId(string messageId);

        // -(void)deleteInboxMessage:(CleverTapInboxMessage * _Nonnull)message;
        [Export("deleteInboxMessage:")]
        void DeleteInboxMessage(CleverTapInboxMessage message);

        // -(void)markReadInboxMessage:(CleverTapInboxMessage * _Nonnull)message;
        [Export("markReadInboxMessage:")]
        void MarkReadInboxMessage(CleverTapInboxMessage message);

        // -(void)deleteInboxMessageForID:(NSString * _Nonnull)messageId;
        [Export("deleteInboxMessageForID:")]
        void DeleteInboxMessageForID(string messageId);

        // -(void)deleteInboxMessagesForIDs:(NSArray<NSString *> * _Nonnull)messageIds;
        [Export("deleteInboxMessagesForIDs:")]
        void DeleteInboxMessagesForIDs(string[] messageIds);

        // -(void)markReadInboxMessageForID:(NSString * _Nonnull)messageId;
        [Export("markReadInboxMessageForID:")]
        void MarkReadInboxMessageForID(string messageId);

        // -(void)registerInboxUpdatedBlock:(CleverTapInboxUpdatedBlock _Nonnull)block;
        [Export("registerInboxUpdatedBlock:")]
        void RegisterInboxUpdatedBlock(CleverTapInboxUpdatedBlock block);

        // -(CleverTapInboxViewController * _Nullable)newInboxViewControllerWithConfig:(CleverTapInboxStyleConfig * _Nullable)config andDelegate:(id<CleverTapInboxViewControllerDelegate> _Nullable)delegate;
        [Export("newInboxViewControllerWithConfig:andDelegate:")]
        [return: NullAllowed]
        CleverTapInboxViewController NewInboxViewControllerWithConfig([NullAllowed] CleverTapInboxStyleConfig config, [NullAllowed] CleverTapInboxViewControllerDelegate @delegate);

        // -(void)recordInboxNotificationViewedEventForID:(NSString * _Nonnull)messageId;
        [Export("recordInboxNotificationViewedEventForID:")]
        void RecordInboxNotificationViewedEventForID(string messageId);

        // -(void)recordInboxNotificationClickedEventForID:(NSString * _Nonnull)messageId;
        [Export("recordInboxNotificationClickedEventForID:")]
        void RecordInboxNotificationClickedEventForID(string messageId);
    }

    // @protocol CleverTapProductConfigDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapProductConfigDelegate
    {
        // @optional -(void)ctProductConfigFetched;
        [Export("ctProductConfigFetched")]
        void CtProductConfigFetched();

        // @optional -(void)ctProductConfigActivated;
        [Export("ctProductConfigActivated")]
        void CtProductConfigActivated();

        // @optional -(void)ctProductConfigInitialized;
        [Export("ctProductConfigInitialized")]
        void CtProductConfigInitialized();
    }

    // @interface ProductConfig (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_ProductConfig
    {
        // @property (readonly, atomic, strong) CleverTapProductConfig * _Nonnull productConfig;
        [Static]
        [Export("productConfig", ArgumentSemantic.Strong)]
        CleverTapProductConfig ProductConfig { get; }
    }

    // @interface CleverTapConfigValue : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapConfigValue : INSCopying
    {
        // @property (readonly, nonatomic) NSString * _Nullable stringValue;
        [NullAllowed, Export("stringValue")]
        string StringValue { get; }

        // @property (readonly, nonatomic) NSNumber * _Nullable numberValue;
        [NullAllowed, Export("numberValue")]
        NSNumber NumberValue { get; }

        // @property (readonly, nonatomic) NSData * _Nonnull dataValue;
        [Export("dataValue")]
        NSData DataValue { get; }

        // @property (readonly, nonatomic) BOOL boolValue;
        [Export("boolValue")]
        bool BoolValue { get; }

        // @property (readonly, nonatomic) id _Nullable jsonValue;
        [NullAllowed, Export("jsonValue")]
        NSObject JsonValue { get; }
    }

    // @interface CleverTapProductConfig : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapProductConfig
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        CleverTapProductConfigDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<CleverTapProductConfigDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)fetch;
        [Export("fetch")]
        void Fetch();

        // -(void)fetchWithMinimumInterval:(NSTimeInterval)minimumInterval;
        [Export("fetchWithMinimumInterval:")]
        void FetchWithMinimumInterval(double minimumInterval);

        // -(void)setMinimumFetchInterval:(NSTimeInterval)minimumFetchInterval;
        [Export("setMinimumFetchInterval:")]
        void SetMinimumFetchInterval(double minimumFetchInterval);

        // -(void)activate;
        [Export("activate")]
        void Activate();

        // -(void)fetchAndActivate;
        [Export("fetchAndActivate")]
        void FetchAndActivate();

        // -(void)setDefaults:(NSDictionary<NSString *,NSObject *> * _Nullable)defaults;
        [Export("setDefaults:")]
        void SetDefaults([NullAllowed] NSDictionary<NSString, NSObject> defaults);

        // -(void)setDefaultsFromPlistFileName:(NSString * _Nullable)fileName;
        [Export("setDefaultsFromPlistFileName:")]
        void SetDefaultsFromPlistFileName([NullAllowed] string fileName);

        // -(CleverTapConfigValue * _Nullable)get:(NSString * _Nonnull)key;
        [Export("get:")]
        [return: NullAllowed]
        CleverTapConfigValue Get(string key);

        // -(NSDate * _Nullable)getLastFetchTimeStamp;
        [NullAllowed, Export("getLastFetchTimeStamp")]
        NSDate LastFetchTimeStamp { get; }

        // -(void)reset;
        [Export("reset")]
        void Reset();
    }

    // @protocol CleverTapDomainDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapDomainDelegate
    {
        // @optional -(void)onSCDomainAvailable:(NSString * _Nonnull)domain;
        [Export("onSCDomainAvailable:")]
        void OnSCDomainAvailable(string domain);

        // @optional -(void)onSCDomainUnavailable;
        [Export("onSCDomainUnavailable")]
        void OnSCDomainUnavailable();
    }

    // @interface SCDomain (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_SCDomain
    {
    }

    // @interface SSLPinning (CleverTap)
    [Category]
    [BaseType(typeof(CleverTap))]
    interface CleverTap_SSLPinning
    {
    }

    // @interface CleverTapEventDetail : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapEventDetail
    {
        // @property (nonatomic, strong) NSString * eventName;
        [Export("eventName", ArgumentSemantic.Strong)]
        string EventName { get; set; }

        // @property (nonatomic) NSTimeInterval firstTime;
        [Export("firstTime")]
        double FirstTime { get; set; }

        // @property (nonatomic) NSTimeInterval lastTime;
        [Export("lastTime")]
        double LastTime { get; set; }

        // @property (nonatomic) NSUInteger count;
        [Export("count")]
        nuint Count { get; set; }
    }

    // @protocol CleverTapInAppNotificationDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapInAppNotificationDelegate
    {
        // @optional -(BOOL)shouldShowInAppNotificationWithExtras:(NSDictionary *)extras;
        [Export("shouldShowInAppNotificationWithExtras:")]
        bool ShouldShowInAppNotificationWithExtras(NSDictionary extras);

        // @optional -(void)inAppNotificationDismissedWithExtras:(NSDictionary *)extras andActionExtras:(NSDictionary *)actionExtras;
        [Export("inAppNotificationDismissedWithExtras:andActionExtras:")]
        void InAppNotificationDismissedWithExtras(NSDictionary extras, NSDictionary actionExtras);

        // @optional -(void)inAppNotificationButtonTappedWithCustomExtras:(NSDictionary *)customExtras;
        [Export("inAppNotificationButtonTappedWithCustomExtras:")]
        void InAppNotificationButtonTappedWithCustomExtras(NSDictionary customExtras);
    }

    // @interface  (CleverTapInstanceConfig) <NSCopying, NSCoding, NSSecureCoding>
    [Static]
    [Category]
    [BaseType(typeof(CleverTapInstanceConfig))]
    interface CleverTapInstanceConfig_ //awak: INSCopying, INSCoding, INSSecureCoding
    {
        // @property (readonly, assign, nonatomic) BOOL isDefaultInstance;
        [Static]
        [Export("isDefaultInstance")]
        bool IsDefaultInstance { get; }

        // @property (readonly, nonatomic, strong) NSString * _Nonnull queueLabel;
        [Static]
        [Export("queueLabel", ArgumentSemantic.Strong)]
        string QueueLabel { get; }

        // @property (assign, nonatomic) BOOL isCreatedPostAppLaunched;
        [Static]
        [Export("isCreatedPostAppLaunched")]
        bool IsCreatedPostAppLaunched { get; set; }

        // @property (assign, nonatomic) BOOL beta;
        [Static]
        [Export("beta")]
        bool Beta { get; set; }

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken accountRegion:(NSString * _Nullable)accountRegion isDefaultInstance:(BOOL)isDefault;
        //awak[Export("initWithAccountId:accountToken:accountRegion:isDefaultInstance:")]
        //awakIntPtr Constructor(string accountId, string accountToken, [NullAllowed] string accountRegion, bool isDefault);

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken proxyDomain:(NSString * _Nonnull)proxyDomain isDefaultInstance:(BOOL)isDefault;
        // TODO:
        //[Export("initWithAccountId:accountToken:proxyDomain:isDefaultInstance:")]
        //IntPtr Constructor(string accountId, string accountToken, string proxyDomain, bool isDefault);

        // -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken proxyDomain:(NSString * _Nonnull)proxyDomain spikyProxyDomain:(NSString * _Nonnull)spikyProxyDomain isDefaultInstance:(BOOL)isDefault;
        //awak[Export("initWithAccountId:accountToken:proxyDomain:spikyProxyDomain:isDefaultInstance:")]
        //awakIntPtr Constructor(string accountId, string accountToken, string proxyDomain, string spikyProxyDomain, bool isDefault);

        // +(NSString * _Nonnull)dataArchiveFileNameWithAccountId:(NSString * _Nonnull)accountId;
        [Static]
        [Export("dataArchiveFileNameWithAccountId:")]
        string DataArchiveFileNameWithAccountId(string accountId);
    }

    // @protocol CleverTapPushNotificationDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapPushNotificationDelegate
    {
        // @optional -(void)pushNotificationTappedWithCustomExtras:(NSDictionary *)customExtras;
        [Export("pushNotificationTappedWithCustomExtras:")]
        void PushNotificationTappedWithCustomExtras(NSDictionary customExtras);
    }

    // @protocol CleverTapSyncDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapSyncDelegate
    {
        // @optional -(void)profileDidInitialize:(NSString *)CleverTapID;
        [Export("profileDidInitialize:")]
        void ProfileDidInitialize(string CleverTapID);

        // @optional -(void)profileDidInitialize:(NSString *)CleverTapID forAccountId:(NSString *)accountId;
        [Export("profileDidInitialize:forAccountId:")]
        void ProfileDidInitialize(string CleverTapID, string accountId);

        // @optional -(void)profileDataUpdated:(NSDictionary *)updates;
        [Export("profileDataUpdated:")]
        void ProfileDataUpdated(NSDictionary updates);
    }

    // @interface CleverTapTrackedViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    [Protocol]
    interface CleverTapTrackedViewController
    {
        // @property (readwrite, copy, nonatomic) NSString * screenName;
        [Export("screenName")]
        string ScreenName { get; set; }
    }

    // @protocol CleverTapURLDelegate <NSObject>
    //[Protocol, Model(AutoGeneratedName = true)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface CleverTapURLDelegate
    {
        // @required -(BOOL)shouldHandleCleverTapURL:(NSURL * _Nullable)url forChannel:(CleverTapChannel)channel;
        [Abstract]
        [Export("shouldHandleCleverTapURL:forChannel:")]
        bool ForChannel([NullAllowed] NSUrl url, CleverTapChannel channel);
    }

    // @interface CleverTapUTMDetail : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface CleverTapUTMDetail
    {
        // @property (nonatomic, strong) NSString * source;
        [Export("source", ArgumentSemantic.Strong)]
        string Source { get; set; }

        // @property (nonatomic, strong) NSString * medium;
        [Export("medium", ArgumentSemantic.Strong)]
        string Medium { get; set; }

        // @property (nonatomic, strong) NSString * campaign;
        [Export("campaign", ArgumentSemantic.Strong)]
        string Campaign { get; set; }
    }
}
