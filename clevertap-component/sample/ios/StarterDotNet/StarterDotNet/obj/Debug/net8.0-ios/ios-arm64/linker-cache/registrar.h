#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CoreLocation/CoreLocation.h>
#import <CoreGraphics/CoreGraphics.h>
#import <WebKit/WebKit.h>
#import <CloudKit/CloudKit.h>

@class Microsoft_iOS__UIKit_UIApplicationDelegate;
@class AppDelegate;
@class SceneDelegate;
@protocol CleverTap;
@protocol CleverTapConfigValue;
@protocol CleverTapDisplayUnit;
@protocol CleverTapDisplayUnitContent;
@protocol CleverTapDisplayUnitDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapDisplayUnitDelegate;
@protocol CleverTapDomainDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapDomainDelegate;
@protocol CleverTapEventDetail;
@protocol CleverTapFeatureFlags;
@protocol CleverTapFeatureFlagsDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapFeatureFlagsDelegate;
@protocol CleverTapInAppNotificationDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapInAppNotificationDelegate;
@protocol CleverTapInboxMessage;
@protocol CleverTapInboxMessageContent;
@protocol CleverTapInboxStyleConfig;
@protocol CleverTapInboxViewController;
@protocol CleverTapInboxViewControllerDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapInboxViewControllerDelegate;
@protocol CleverTapInstanceConfig;
@protocol CleverTapJSInterface;
@protocol CleverTapProductConfig;
@protocol CleverTapProductConfigDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapProductConfigDelegate;
@protocol CleverTapPushNotificationDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapPushNotificationDelegate;
@protocol CleverTapSyncDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapSyncDelegate;
@protocol CleverTapTrackedViewController;
@protocol CleverTapURLDelegate;
@class ApiDefinition__CleverTapSDK_CleverTapURLDelegate;
@protocol CleverTapUTMDetail;
@protocol CTDeviceInfo;
@protocol CTEventBuilder;
@protocol CTFlexibleIdentityRepo;
@class ApiDefinition__CleverTapSDK_CTIdentityRepo;
@protocol CTIdentityRepoFactory;
@protocol CTInAppDisplayViewController;
@protocol CTInAppFCManager;
@protocol CTInAppNotification;
@protocol CTInAppNotificationDisplayDelegate;
@class ApiDefinition__CleverTapSDK_CTInAppNotificationDisplayDelegate;
@protocol CTInAppPassThroughView;
@protocol CTInAppPassThroughViewDelegate;
@class ApiDefinition__CleverTapSDK_CTInAppPassThroughViewDelegate;
@protocol CTInAppPassThroughWindow;
@protocol CTInAppUtils;
@protocol CTKnownProfileFields;
@protocol CTLegacyIdentityRepo;
@protocol CTLocalDataStore;
@protocol CTLocationManager;
@protocol CTLogger;
@protocol CTLoginInfoProvider;
@protocol CTNotificationButton;
@protocol CTPlistInfo;
@protocol CTPreferences;
@protocol CTProfileBuilder;
@protocol CTUIUtils;
@protocol CTUriHelper;
@protocol CTUtils;
@protocol CTValidationResult;
@protocol CTValidationResultStack;
@protocol CTValidator;
@class UIKit_UIView_UIViewAppearance;
@class CleverTapSDK_CTInAppPassThroughView_CTInAppPassThroughViewAppearance;
@class UIKit_UIWindow_UIWindowAppearance;
@class CleverTapSDK_CTInAppPassThroughWindow_CTInAppPassThroughWindowAppearance;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class __NSObject_Disposer;

@interface Microsoft_iOS__UIKit_UIApplicationDelegate : NSObject<UIApplicationDelegate> {
}
	-(id) init;
@end

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface SceneDelegate : UIResponder<UISceneDelegate, UIWindowSceneDelegate> {
}
	@property (nonatomic, assign) UIWindow * window;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(void) scene:(UIScene *)p0 willConnectToSession:(UISceneSession *)p1 options:(UISceneConnectionOptions *)p2;
	-(void) sceneDidDisconnect:(UIScene *)p0;
	-(void) sceneDidBecomeActive:(UIScene *)p0;
	-(void) sceneWillResignActive:(UIScene *)p0;
	-(void) sceneWillEnterForeground:(UIScene *)p0;
	-(void) sceneDidEnterBackground:(UIScene *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@protocol CleverTap
	@optional @property (nonatomic, retain, readonly) id config;
	@optional @property (nonatomic, retain) NSString * signedCallDomain;
	@optional @property (nonatomic, assign, readonly) NSString * profileGetCleverTapID;
	@optional @property (nonatomic, assign, readonly) NSString * getAccountID;
	@optional @property (nonatomic, assign, readonly) NSString * profileGetCleverTapAttributionIdentifier;
	@optional @property (nonatomic, assign, readonly) NSDictionary * userGetEventHistory;
	@optional @property (nonatomic, assign, readonly) double sessionGetTimeElapsed;
	@optional @property (nonatomic, assign, readonly) id sessionGetUTMDetails;
	@optional @property (nonatomic, assign, readonly) int userGetTotalVisits;
	@optional @property (nonatomic, assign, readonly) int userGetScreenCount;
	@optional @property (nonatomic, assign, readonly) double userGetPreviousVisitTime;
	@optional @property (nonatomic, assign, readonly) NSString * getDomainString;
	@optional +(id) sharedInstance;
	@optional +(id) sharedInstanceWithCleverTapID:(NSString *)p0;
	@optional +(id) autoIntegrate;
	@optional +(id) autoIntegrateWithCleverTapID:(NSString *)p0;
	@optional +(id) instanceWithConfig:(id)p0;
	@optional +(id) instanceWithConfig:(id)p0 andCleverTapID:(NSString *)p1;
	@optional +(id) getGlobalInstance:(NSString *)p0;
	@optional +(void) changeCredentialsWithAccountID:(NSString *)p0 andToken:(NSString *)p1;
	@optional +(void) changeCredentialsWithAccountID:(NSString *)p0 token:(NSString *)p1 region:(NSString *)p2;
	@optional +(void) setCredentialsWithAccountID:(NSString *)p0 andToken:(NSString *)p1;
	@optional +(void) setCredentialsWithAccountID:(NSString *)p0 token:(NSString *)p1 region:(NSString *)p2;
	@optional +(void) setCredentialsWithAccountID:(NSString *)p0 token:(NSString *)p1 proxyDomain:(NSString *)p2 spikyProxyDomain:(NSString *)p3;
	@optional -(void) notifyApplicationLaunchedWithOptions:(NSObject *)p0;
	@optional +(void) enablePersonalization;
	@optional +(void) disablePersonalization;
	@optional +(void) setLocation:(CLLocationCoordinate2D)p0;
	@optional +(void) getLocationWithSuccess:(void (^)(void *))p0 andError:(void (^)(void *))p1;
	@optional -(void) onUserLogin:(NSDictionary *)p0;
	@optional -(void) onUserLogin:(NSDictionary *)p0 withCleverTapID:(NSString *)p1;
	@optional -(void) setOptOut:(BOOL)p0;
	@optional -(void) setOffline:(BOOL)p0;
	@optional -(void) enableDeviceNetworkInfoReporting:(BOOL)p0;
	@optional -(void) profilePush:(NSDictionary *)p0;
	@optional -(void) profileRemoveValueForKey:(NSString *)p0;
	@optional -(void) profileSetMultiValues:(NSArray *)p0 forKey:(NSString *)p1;
	@optional -(void) profileAddMultiValue:(NSString *)p0 forKey:(NSString *)p1;
	@optional -(void) profileAddMultiValues:(NSArray *)p0 forKey:(NSString *)p1;
	@optional -(void) profileRemoveMultiValue:(NSString *)p0 forKey:(NSString *)p1;
	@optional -(void) profileRemoveMultiValues:(NSArray *)p0 forKey:(NSString *)p1;
	@optional -(void) profileIncrementValueBy:(NSNumber *)p0 forKey:(NSString *)p1;
	@optional -(void) profileDecrementValueBy:(NSNumber *)p0 forKey:(NSString *)p1;
	@optional -(NSObject *) profileGet:(NSString *)p0;
	@optional -(void) recordEvent:(NSString *)p0;
	@optional -(void) recordEvent:(NSString *)p0 withProps:(NSDictionary *)p1;
	@optional -(void) recordChargedEventWithDetails:(NSDictionary *)p0 andItems:(NSArray *)p1;
	@optional -(void) recordErrorWithMessage:(NSString *)p0 andErrorCode:(int)p1;
	@optional -(void) recordScreenView:(NSString *)p0;
	@optional -(void) recordNotificationViewedEventWithData:(NSObject *)p0;
	@optional -(void) recordNotificationClickedEventWithData:(NSObject *)p0;
	@optional -(double) eventGetFirstTime:(NSString *)p0;
	@optional -(double) eventGetLastTime:(NSString *)p0;
	@optional -(int) eventGetOccurrences:(NSString *)p0;
	@optional -(id) eventGetDetail:(NSString *)p0;
	@optional -(void) setSyncDelegate:(id)p0;
	@optional -(void) setPushNotificationDelegate:(id)p0;
	@optional -(void) setInAppNotificationDelegate:(id)p0;
	@optional -(void) setUrlDelegate:(id)p0;
	@optional -(void) setPushToken:(NSData *)p0;
	@optional -(void) setPushTokenAsString:(NSString *)p0;
	@optional -(void) handleNotificationWithData:(NSObject *)p0;
	@optional -(void) handleNotificationWithData:(NSObject *)p0 openDeepLinksInForeground:(BOOL)p1;
	@optional +(void) handlePushNotification:(NSDictionary *)p0 openDeepLinksInForeground:(BOOL)p1;
	@optional -(BOOL) isCleverTapNotification:(NSDictionary *)p0;
	@optional -(void) showInAppNotificationIfAny;
	@optional -(void) handleOpenURL:(NSURL *)p0 sourceApplication:(NSString *)p1;
	@optional +(void) handleOpenURL:(NSURL *)p0;
	@optional -(void) pushInstallReferrerSource:(NSString *)p0 medium:(NSString *)p1 campaign:(NSString *)p2;
	@optional +(void) setDebugLevel:(int)p0;
	@optional -(void) setLibrary:(NSString *)p0;
	@optional -(void) setLocationForGeofences:(CLLocationCoordinate2D)p0 withPluginVersion:(NSString *)p1;
	@optional -(void) didFailToRegisterForGeofencesWithError:(NSError *)p0;
	@optional -(void) recordGeofenceEnteredEvent:(NSDictionary *)p0;
	@optional -(void) recordGeofenceExitedEvent:(NSDictionary *)p0;
	@optional -(void) recordSignedCallEvent:(int)p0 forCallDetails:(NSDictionary *)p1;
	@optional -(void) setSignedCallVersion:(NSString *)p0;
	@optional -(void) setDomainDelegate:(id)p0;
	@optional +(BOOL) isValidCleverTapId:(NSString *)p0;
	@optional +(int) getDebugLevel;
@end

@protocol CleverTapConfigValue
	@optional @property (nonatomic, assign, readonly) NSString * stringValue;
	@optional @property (nonatomic, assign, readonly) NSNumber * numberValue;
	@optional @property (nonatomic, assign, readonly) NSData * dataValue;
	@optional @property (nonatomic, assign, readonly) BOOL boolValue;
	@optional @property (nonatomic, assign, readonly) NSObject * jsonValue;
@end

@protocol CleverTapDisplayUnit
	@optional @property (nonatomic, copy, readonly) NSDictionary * json;
	@optional @property (nonatomic, assign, readonly) NSString * unitID;
	@optional @property (nonatomic, assign, readonly) NSString * type;
	@optional @property (nonatomic, assign, readonly) NSString * bgColor;
	@optional @property (nonatomic, copy, readonly) NSDictionary * customExtras;
	@optional @property (nonatomic, copy, readonly) NSArray * contents;
@end

@protocol CleverTapDisplayUnitContent
	@optional @property (nonatomic, assign, readonly) NSString * title;
	@optional @property (nonatomic, assign, readonly) NSString * titleColor;
	@optional @property (nonatomic, assign, readonly) NSString * message;
	@optional @property (nonatomic, assign, readonly) NSString * messageColor;
	@optional @property (nonatomic, assign, readonly) NSString * videoPosterUrl;
	@optional @property (nonatomic, assign, readonly) NSString * actionUrl;
	@optional @property (nonatomic, assign, readonly) NSString * mediaUrl;
	@optional @property (nonatomic, assign, readonly) NSString * iconUrl;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsAudio;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsVideo;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsImage;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsGif;
@end

@protocol CleverTapDisplayUnitDelegate
	@optional -(void) displayUnitsUpdated:(NSArray *)p0;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapDisplayUnitDelegate : NSObject<CleverTapDisplayUnitDelegate> {
}
	-(id) init;
@end

@protocol CleverTapDomainDelegate
	@optional -(void) onSCDomainAvailable:(NSString *)p0;
	@optional -(void) onSCDomainUnavailable;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapDomainDelegate : NSObject<CleverTapDomainDelegate> {
}
	-(id) init;
@end

@protocol CleverTapEventDetail
	@optional @property (nonatomic, retain) NSString * eventName;
	@optional @property (nonatomic, assign) double firstTime;
	@optional @property (nonatomic, assign) double lastTime;
	@optional @property (nonatomic, assign) void * count;
@end

@protocol CleverTapFeatureFlags
	@optional @property (nonatomic, assign) NSObject * delegate;
	@optional -(BOOL) get:(NSString *)p0 withDefaultValue:(BOOL)p1;
@end

@protocol CleverTapFeatureFlagsDelegate
	@optional -(void) ctFeatureFlagsUpdated;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapFeatureFlagsDelegate : NSObject<CleverTapFeatureFlagsDelegate> {
}
	-(id) init;
@end

@protocol CleverTapInAppNotificationDelegate
	@optional -(BOOL) shouldShowInAppNotificationWithExtras:(NSDictionary *)p0;
	@optional -(void) inAppNotificationDismissedWithExtras:(NSDictionary *)p0 andActionExtras:(NSDictionary *)p1;
	@optional -(void) inAppNotificationButtonTappedWithCustomExtras:(NSDictionary *)p0;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapInAppNotificationDelegate : NSObject<CleverTapInAppNotificationDelegate> {
}
	-(id) init;
@end

@protocol CleverTapInboxMessage
	@optional @property (nonatomic, copy, readonly) NSDictionary * json;
	@optional @property (nonatomic, copy, readonly) NSDictionary * customData;
	@optional @property (nonatomic, assign, readonly) BOOL isRead;
	@optional @property (nonatomic, assign, readonly) void * date;
	@optional @property (nonatomic, assign, readonly) void * expires;
	@optional @property (nonatomic, assign, readonly) NSString * relativeDate;
	@optional @property (nonatomic, assign, readonly) NSString * type;
	@optional @property (nonatomic, assign, readonly) NSString * messageId;
	@optional @property (nonatomic, assign, readonly) NSString * campaignId;
	@optional @property (nonatomic, assign, readonly) NSString * tagString;
	@optional @property (nonatomic, copy, readonly) NSArray * tags;
	@optional @property (nonatomic, assign, readonly) NSString * orientation;
	@optional @property (nonatomic, assign, readonly) NSString * backgroundColor;
	@optional @property (nonatomic, copy, readonly) NSArray * content;
	@optional -(void) setRead:(BOOL)p0;
@end

@protocol CleverTapInboxMessageContent
	@optional @property (nonatomic, assign, readonly) NSString * title;
	@optional @property (nonatomic, assign, readonly) NSString * titleColor;
	@optional @property (nonatomic, assign, readonly) NSString * message;
	@optional @property (nonatomic, assign, readonly) NSString * messageColor;
	@optional @property (nonatomic, assign, readonly) NSString * backgroundColor;
	@optional @property (nonatomic, assign, readonly) NSString * mediaUrl;
	@optional @property (nonatomic, assign, readonly) NSString * videoPosterUrl;
	@optional @property (nonatomic, assign, readonly) NSString * iconUrl;
	@optional @property (nonatomic, assign, readonly) NSString * actionUrl;
	@optional @property (nonatomic, copy, readonly) NSArray * links;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsAudio;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsVideo;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsImage;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsGif;
	@optional @property (nonatomic, assign, readonly) BOOL actionHasUrl;
	@optional @property (nonatomic, assign, readonly) BOOL actionHasLinks;
	@optional -(NSString *) urlForLinkAtIndex:(int)p0;
	@optional -(NSDictionary *) customDataForLinkAtIndex:(int)p0;
@end

@protocol CleverTapInboxStyleConfig
	@optional @property (nonatomic, retain) NSString * title;
	@optional @property (nonatomic, retain) UIColor * backgroundColor;
	@optional @property (nonatomic, retain) NSArray * messageTags;
	@optional @property (nonatomic, retain) UIColor * navigationBarTintColor;
	@optional @property (nonatomic, retain) UIColor * navigationTintColor;
	@optional @property (nonatomic, retain) UIColor * tabSelectedBgColor;
	@optional @property (nonatomic, retain) UIColor * tabSelectedTextColor;
	@optional @property (nonatomic, retain) UIColor * tabUnSelectedTextColor;
	@optional @property (nonatomic, retain) NSString * noMessageViewText;
	@optional @property (nonatomic, retain) UIColor * noMessageViewTextColor;
	@optional @property (nonatomic, retain) NSString * firstTabTitle;
@end

@protocol CleverTapInboxViewController
@end

@protocol CleverTapInboxViewControllerDelegate
	@optional -(void) messageDidSelect:(id)p0 atIndex:(int)p1 withButtonIndex:(int)p2;
	@optional -(void) messageButtonTappedWithCustomExtras:(NSDictionary *)p0;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapInboxViewControllerDelegate : NSObject<CleverTapInboxViewControllerDelegate> {
}
	-(id) init;
@end

@protocol CleverTapInstanceConfig
	@optional @property (nonatomic, retain, readonly) NSString * accountId;
	@optional @property (nonatomic, retain, readonly) NSString * accountToken;
	@optional @property (nonatomic, retain, readonly) NSString * accountRegion;
	@optional @property (nonatomic, retain, readonly) NSString * proxyDomain;
	@optional @property (nonatomic, retain, readonly) NSString * spikyProxyDomain;
	@optional @property (nonatomic, assign) BOOL analyticsOnly;
	@optional @property (nonatomic, assign) BOOL disableAppLaunchedEvent;
	@optional @property (nonatomic, assign) BOOL enablePersonalization;
	@optional @property (nonatomic, assign) BOOL useCustomCleverTapId;
	@optional @property (nonatomic, assign) BOOL disableIDFV;
	@optional @property (nonatomic, assign) int logLevel;
	@optional @property (nonatomic, retain) NSArray * identityKeys;
@end

@protocol CleverTapJSInterface
	@optional @property (nonatomic, retain) WKUserContentController * userContentController;
@end

@protocol CleverTapProductConfig
	@optional @property (nonatomic, assign) NSObject * delegate;
	@optional @property (nonatomic, assign, readonly) NSDate * getLastFetchTimeStamp;
	@optional -(void) fetch;
	@optional -(void) fetchWithMinimumInterval:(double)p0;
	@optional -(void) setMinimumFetchInterval:(double)p0;
	@optional -(void) activate;
	@optional -(void) fetchAndActivate;
	@optional -(void) setDefaults:(NSDictionary <NSString *, NSObject *>*)p0;
	@optional -(void) setDefaultsFromPlistFileName:(NSString *)p0;
	@optional -(id) get:(NSString *)p0;
	@optional -(void) reset;
@end

@protocol CleverTapProductConfigDelegate
	@optional -(void) ctProductConfigFetched;
	@optional -(void) ctProductConfigActivated;
	@optional -(void) ctProductConfigInitialized;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapProductConfigDelegate : NSObject<CleverTapProductConfigDelegate> {
}
	-(id) init;
@end

@protocol CleverTapPushNotificationDelegate
	@optional -(void) pushNotificationTappedWithCustomExtras:(NSDictionary *)p0;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapPushNotificationDelegate : NSObject<CleverTapPushNotificationDelegate> {
}
	-(id) init;
@end

@protocol CleverTapSyncDelegate
	@optional -(void) profileDidInitialize:(NSString *)p0;
	@optional -(void) profileDidInitialize:(NSString *)p0 forAccountId:(NSString *)p1;
	@optional -(void) profileDataUpdated:(NSDictionary *)p0;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapSyncDelegate : NSObject<CleverTapSyncDelegate> {
}
	-(id) init;
@end

@protocol CleverTapTrackedViewController
	@optional @property (nonatomic, assign) NSString * screenName;
@end

@protocol CleverTapURLDelegate
	@required -(BOOL) shouldHandleCleverTapURL:(NSURL *)p0 forChannel:(int)p1;
@end

@interface ApiDefinition__CleverTapSDK_CleverTapURLDelegate : NSObject<CleverTapURLDelegate> {
}
	-(id) init;
@end

@protocol CleverTapUTMDetail
	@optional @property (nonatomic, retain) NSString * source;
	@optional @property (nonatomic, retain) NSString * medium;
	@optional @property (nonatomic, retain) NSString * campaign;
@end

@protocol CTDeviceInfo
	@optional @property (nonatomic, retain, readonly) NSString * sdkVersion;
	@optional @property (nonatomic, retain, readonly) NSString * appVersion;
	@optional @property (nonatomic, retain, readonly) NSString * appBuild;
	@optional @property (nonatomic, retain, readonly) NSString * bundleId;
	@optional @property (nonatomic, retain, readonly) NSString * osName;
	@optional @property (nonatomic, retain, readonly) NSString * osVersion;
	@optional @property (nonatomic, retain, readonly) NSString * manufacturer;
	@optional @property (nonatomic, assign, readonly) NSString * model;
	@optional @property (nonatomic, retain, readonly) NSString * carrier;
	@optional @property (nonatomic, retain, readonly) NSString * countryCode;
	@optional @property (nonatomic, retain, readonly) NSString * timeZone;
	@optional @property (nonatomic, retain, readonly) NSString * radio;
	@optional @property (nonatomic, retain, readonly) NSString * vendorIdentifier;
	@optional @property (nonatomic, retain, readonly) NSString * deviceWidth;
	@optional @property (nonatomic, retain, readonly) NSString * deviceHeight;
	@optional @property (nonatomic, assign, readonly) NSString * deviceId;
	@optional @property (nonatomic, assign, readonly) NSString * fallbackDeviceId;
	@optional @property (nonatomic, assign) NSString * library;
	@optional @property (nonatomic, assign, readonly) BOOL wifi;
	@optional @property (nonatomic, retain, readonly) NSMutableArray <id>* validationErrors;
	@optional @property (nonatomic, retain, readonly) NSString * signedCallSDKVersion;
	@optional @property (nonatomic, assign, readonly) BOOL isErrorDeviceID;
	@optional -(void) forceUpdateDeviceID:(NSString *)p0;
	@optional -(void) forceNewDeviceID;
	@optional -(void) forceUpdateCustomDeviceID:(NSString *)p0;
	@optional -(void) setSignedCallSDKVersion:(NSString *)p0;
@end

@protocol CTEventBuilder
	@optional +(void) build:(NSString *)p0 completionHandler:(void (^)(void *, void *))p1;
	@optional +(void) build:(NSString *)p0 withEventActions:(NSDictionary *)p1 completionHandler:(void (^)(void *, void *))p2;
	@optional +(void) buildChargedEventWithDetails:(NSDictionary *)p0 andItems:(NSArray *)p1 completionHandler:(void (^)(void *, void *))p2;
	@optional +(void) buildPushNotificationEvent:(BOOL)p0 forNotification:(NSDictionary *)p1 completionHandler:(void (^)(void *, void *))p2;
	@optional +(void) buildInAppNotificationStateEvent:(BOOL)p0 forNotification:(id)p1 andQueryParameters:(NSDictionary *)p2 completionHandler:(void (^)(void *, void *))p3;
	@optional +(void) buildInboxMessageStateEvent:(BOOL)p0 forMessage:(id)p1 andQueryParameters:(NSDictionary *)p2 completionHandler:(void (^)(void *, void *))p3;
	@optional +(void) buildDisplayViewStateEvent:(BOOL)p0 forDisplayUnit:(id)p1 andQueryParameters:(NSDictionary *)p2 completionHandler:(void (^)(void *, void *))p3;
	@optional +(void) buildGeofenceStateEvent:(BOOL)p0 forGeofenceDetails:(NSDictionary *)p1 completionHandler:(void (^)(void *, void *))p2;
	@optional +(void) buildSignedCallEvent:(int)p0 forCallDetails:(NSDictionary *)p1 completionHandler:(void (^)(void *, void *))p2;
@end

@protocol CTFlexibleIdentityRepo
@end

@interface ApiDefinition__CleverTapSDK_CTIdentityRepo : NSObject {
}
	-(id) init;
@end

@protocol CTIdentityRepoFactory
	@optional +(id) getRepoForConfig:(id)p0 deviceInfo:(id)p1 validationResultStack:(id)p2;
@end

@protocol CTInAppDisplayViewController
	@optional @property (nonatomic, assign) NSObject * delegate;
	@optional @property (nonatomic, retain, readonly) id notification;
	@optional @property (nonatomic, assign, readonly) BOOL deviceOrientationIsLandscape;
	@optional -(void) show:(BOOL)p0;
	@optional -(void) hide:(BOOL)p0;
@end

@protocol CTInAppFCManager
	@optional -(void) checkUpdateDailyLimits;
	@optional -(BOOL) canShow:(id)p0;
	@optional -(void) didDismiss:(id)p0;
	@optional -(void) resetSession;
	@optional -(void) changeUserWithGuid:(NSString *)p0;
	@optional -(void) didShow:(id)p0;
	@optional -(void) updateLimitsPerDay:(int)p0 andPerSession:(int)p1;
	@optional -(void) attachToHeader:(NSMutableDictionary *)p0;
	@optional -(void) processResponse:(NSDictionary *)p0;
	@optional -(BOOL) hasLifetimeCapacityMaxedOut:(id)p0;
	@optional -(BOOL) hasDailyCapacityMaxedOut:(id)p0;
@end

@protocol CTInAppNotification
	@optional @property (nonatomic, assign, readonly) NSString * Id;
	@optional @property (nonatomic, assign, readonly) NSString * campaignId;
	@optional @property (nonatomic, assign, readonly) NSString * type;
	@optional @property (nonatomic, assign, readonly) NSUInteger inAppType;
	@optional @property (nonatomic, assign, readonly) NSString * html;
	@optional @property (nonatomic, assign, readonly) NSString * url;
	@optional @property (nonatomic, assign, readonly) BOOL excludeFromCaps;
	@optional @property (nonatomic, assign, readonly) BOOL showClose;
	@optional @property (nonatomic, assign, readonly) BOOL darkenScreen;
	@optional @property (nonatomic, assign, readonly) int maxPerSession;
	@optional @property (nonatomic, assign, readonly) int totalLifetimeCount;
	@optional @property (nonatomic, assign, readonly) int totalDailyCount;
	@optional @property (nonatomic, assign, readonly) void * timeToLive;
	@optional @property (nonatomic, assign, readonly) signed char position;
	@optional @property (nonatomic, assign, readonly) float height;
	@optional @property (nonatomic, assign, readonly) float heightPercent;
	@optional @property (nonatomic, assign, readonly) float width;
	@optional @property (nonatomic, assign, readonly) float widthPercent;
	@optional @property (nonatomic, assign, readonly) NSData * image;
	@optional @property (nonatomic, assign, readonly) NSData * imageLandscape;
	@optional @property (nonatomic, assign, readonly) NSString * contentType;
	@optional @property (nonatomic, assign, readonly) NSString * mediaUrl;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsVideo;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsAudio;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsImage;
	@optional @property (nonatomic, assign, readonly) BOOL mediaIsGif;
	@optional @property (nonatomic, assign, readonly) NSString * title;
	@optional @property (nonatomic, assign, readonly) NSString * titleColor;
	@optional @property (nonatomic, assign, readonly) NSString * message;
	@optional @property (nonatomic, assign, readonly) NSString * messageColor;
	@optional @property (nonatomic, assign, readonly) NSString * backgroundColor;
	@optional @property (nonatomic, assign, readonly) BOOL showCloseButton;
	@optional @property (nonatomic, assign, readonly) BOOL tablet;
	@optional @property (nonatomic, assign, readonly) BOOL hasLandscape;
	@optional @property (nonatomic, assign, readonly) BOOL hasPortrait;
	@optional @property (nonatomic, assign, readonly) NSArray * buttons;
	@optional @property (nonatomic, copy, readonly) NSDictionary * jsonDescription;
	@optional @property (nonatomic, assign, readonly) NSString * error;
	@optional @property (nonatomic, copy, readonly) NSDictionary * customExtras;
	@optional @property (nonatomic, copy) NSDictionary * actionExtras;
	@optional -(void) prepareWithCompletionHandler:(void (^)())p0;
@end

@protocol CTInAppNotificationDisplayDelegate
	@required -(void) handleNotificationCTA:(NSURL *)p0 buttonCustomExtras:(NSDictionary *)p1 forNotification:(id)p2 fromViewController:(id)p3 withExtras:(NSDictionary *)p4;
	@required -(void) notificationDidDismiss:(id)p0 fromViewController:(id)p1;
	@optional -(void) notificationDidShow:(id)p0 fromViewController:(id)p1;
@end

@interface ApiDefinition__CleverTapSDK_CTInAppNotificationDisplayDelegate : NSObject<CTInAppNotificationDisplayDelegate> {
}
	-(id) init;
@end

@protocol CTInAppPassThroughView
	@optional @property (nonatomic, assign) NSObject * delegate;
@end

@protocol CTInAppPassThroughViewDelegate
	@required -(void) viewWillPassThroughTouch;
@end

@interface ApiDefinition__CleverTapSDK_CTInAppPassThroughViewDelegate : NSObject<CTInAppPassThroughViewDelegate> {
}
	-(id) init;
@end

@protocol CTInAppPassThroughWindow
@end

@protocol CTInAppUtils
	@optional +(NSUInteger) inAppTypeFromString:(NSString *)p0;
	@optional +(NSString *) getXibNameForControllerName:(NSString *)p0;
	@optional +(NSBundle *) bundle;
@end

@protocol CTKnownProfileFields
	@optional +(NSString *) getStorageValueForField:(unsigned int)p0;
	@optional +(unsigned int) getKnownFieldIfPossibleForKey:(NSString *)p0;
@end

@protocol CTLegacyIdentityRepo
@end

@protocol CTLocalDataStore
	@optional @property (nonatomic, assign, readonly) NSDictionary * getEventHistory;
	@optional @property (nonatomic, assign, readonly) NSDictionary * generateBaseProfile;
	@optional -(void) persistEvent:(NSDictionary *)p0;
	@optional -(void) addDataSyncFlag:(NSMutableDictionary *)p0;
	@optional -(NSDictionary *) syncWithRemoteData:(NSDictionary *)p0;
	@optional -(double) getFirstTimeForEvent:(NSString *)p0;
	@optional -(double) getLastTimeForEvent:(NSString *)p0;
	@optional -(int) getOccurrencesForEvent:(NSString *)p0;
	@optional -(id) getEventDetail:(NSString *)p0;
	@optional -(void) setProfileFields:(NSDictionary *)p0;
	@optional -(void) setProfileFieldWithKey:(NSString *)p0 andValue:(NSObject *)p1;
	@optional -(void) removeProfileFieldsWithKeys:(NSArray *)p0;
	@optional -(void) removeProfileFieldForKey:(NSString *)p0;
	@optional -(NSObject *) getProfileFieldForKey:(NSString *)p0;
	@optional -(void) persistLocalProfileIfRequired;
	@optional -(void) changeUser;
@end

@protocol CTLocationManager
@end

@protocol CTLogger
	@optional +(void) setDebugLevel:(int)p0;
	@optional +(int) getDebugLevel;
@end

@protocol CTLoginInfoProvider
	@optional @property (nonatomic, assign, readonly) BOOL deviceIsMultiUser;
	@optional @property (nonatomic, assign, readonly) NSDictionary * getCachedGUIDs;
	@optional @property (nonatomic, assign, readonly) NSString * getCachedIdentities;
	@optional @property (nonatomic, assign, readonly) BOOL isAnonymousDevice;
	@optional @property (nonatomic, assign, readonly) BOOL isLegacyProfileLoggedIn;
	@optional -(void) cacheGUID:(NSString *)p0 forKey:(NSString *)p1 andIdentifier:(NSString *)p2;
	@optional -(void) setCachedGUIDs:(NSDictionary *)p0;
	@optional -(NSString *) getGUIDforKey:(NSString *)p0 andIdentifier:(NSString *)p1;
	@optional -(void) setCachedIdentities:(NSString *)p0;
	@optional -(void) removeValueFromCachedGUIDForKey:(NSString *)p0 andGuid:(NSString *)p1;
@end

@protocol CTNotificationButton
	@optional @property (nonatomic, assign, readonly) NSString * text;
	@optional @property (nonatomic, assign, readonly) NSString * textColor;
	@optional @property (nonatomic, assign, readonly) NSString * borderRadius;
	@optional @property (nonatomic, assign, readonly) NSString * borderColor;
	@optional @property (nonatomic, copy, readonly) NSDictionary * customExtras;
	@optional @property (nonatomic, assign, readonly) NSString * backgroundColor;
	@optional @property (nonatomic, assign, readonly) NSURL * actionURL;
	@optional @property (nonatomic, copy, readonly) NSDictionary * jsonDescription;
	@optional @property (nonatomic, assign, readonly) NSString * error;
@end

@protocol CTPlistInfo
	@optional @property (nonatomic, retain, readonly) NSString * accountId;
	@optional @property (nonatomic, retain, readonly) NSString * accountToken;
	@optional @property (nonatomic, retain, readonly) NSString * accountRegion;
	@optional @property (nonatomic, retain, readonly) NSString * proxyDomain;
	@optional @property (nonatomic, retain, readonly) NSString * spikyProxyDomain;
	@optional @property (nonatomic, retain, readonly) NSArray * registeredUrlSchemes;
	@optional @property (nonatomic, assign, readonly) BOOL disableAppLaunchedEvent;
	@optional @property (nonatomic, assign, readonly) BOOL useCustomCleverTapId;
	@optional @property (nonatomic, assign, readonly) BOOL beta;
	@optional @property (nonatomic, assign, readonly) BOOL disableIDFV;
	@optional +(id) sharedInstance;
	@optional -(void) setCredentialsWithAccountID:(NSString *)p0 token:(NSString *)p1 region:(NSString *)p2;
	@optional -(void) setCredentialsWithAccountID:(NSString *)p0 token:(NSString *)p1 proxyDomain:(NSString *)p2 spikyProxyDomain:(NSString *)p3;
@end

@protocol CTPreferences
	@optional +(void *) getIntForKey:(NSString *)p0 withResetValue:(void *)p1;
	@optional +(void) putInt:(void *)p0 forKey:(NSString *)p1;
	@optional +(NSString *) getStringForKey:(NSString *)p0 withResetValue:(NSString *)p1;
	@optional +(void) putString:(NSString *)p0 forKey:(NSString *)p1;
	@optional +(NSObject *) getObjectForKey:(NSString *)p0;
	@optional +(void) putObject:(NSObject *)p0 forKey:(NSString *)p1;
	@optional +(void) removeObjectForKey:(NSString *)p0;
	@optional +(NSObject *) unarchiveFromFile:(NSString *)p0 ofType:(Class)p1 removeFile:(BOOL)p2;
	@optional +(NSObject *) unarchiveFromFile:(NSString *)p0 ofTypes:(NSSet <Class>*)p1 removeFile:(BOOL)p2;
	@optional +(BOOL) archiveObject:(NSObject *)p0 forFileName:(NSString *)p1;
	@optional +(NSString *) storageKeyWithSuffix:(NSString *)p0 config:(id)p1;
@end

@protocol CTProfileBuilder
	@optional +(void) build:(NSDictionary *)p0 completionHandler:(void (^)(void *, void *, void *))p1;
	@optional +(void) buildRemoveValueForKey:(NSString *)p0 completionHandler:(void (^)(void *, void *, void *))p1;
	@optional +(void) buildSetMultiValues:(NSArray *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
	@optional +(void) buildAddMultiValue:(NSString *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
	@optional +(void) buildAddMultiValues:(NSArray *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
	@optional +(void) buildRemoveMultiValue:(NSString *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
	@optional +(void) buildRemoveMultiValues:(NSArray *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
	@optional +(void) buildIncrementValueBy:(NSNumber *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
	@optional +(void) buildDecrementValueBy:(NSNumber *)p0 forKey:(NSString *)p1 localDataStore:(id)p2 completionHandler:(void (^)(void *, void *, void *))p3;
@end

@protocol CTUIUtils
	@optional +(UIImage *) getImageForName:(NSString *)p0;
	@optional +(UIColor *) ct_colorWithHexString:(NSString *)p0;
	@optional +(UIColor *) ct_colorWithHexString:(NSString *)p0 withAlpha:(CGFloat)p1;
	@optional +(NSBundle *) bundle;
	@optional +(UIApplication *) getSharedApplication;
	@optional +(UIWindow *) getKeyWindow;
	@optional +(BOOL) isDeviceOrientationLandscape;
	@optional +(BOOL) isUserInterfaceIdiomPad;
	@optional +(CGFloat) getLeftMargin;
@end

@protocol CTUriHelper
	@optional +(NSDictionary *) getUrchinFromUri:(NSString *)p0 withSourceApp:(NSString *)p1;
	@optional +(NSDictionary *) getQueryParameters:(NSURL *)p0 andDecode:(BOOL)p1;
@end

@protocol CTUtils
	@optional +(NSString *) dictionaryToJsonString:(NSDictionary *)p0;
	@optional +(NSString *) urlEncodeString:(NSString *)p0;
	@optional +(BOOL) doesString:(NSString *)p0 startWith:(NSString *)p1;
	@optional +(NSString *) deviceTokenStringFromData:(NSData *)p0;
	@optional +(double) toTwoPlaces:(double)p0;
@end

@protocol CTValidationResult
	@optional @property (nonatomic, assign) NSString * errorDesc;
	@optional @property (nonatomic, assign) NSObject * object;
	@optional @property (nonatomic, assign) int errorCode;
	@optional +(id) resultWithErrorCode:(int)p0 andMessage:(NSString *)p1;
@end

@protocol CTValidationResultStack
	@optional @property (nonatomic, assign, readonly) id popValidationResult;
	@optional -(void) pushValidationResults:(NSArray *)p0;
	@optional -(void) pushValidationResult:(id)p0;
@end

@protocol CTValidator
	@optional +(id) cleanEventName:(NSString *)p0;
	@optional +(id) cleanObjectKey:(NSString *)p0;
	@optional +(id) cleanMultiValuePropertyKey:(NSString *)p0;
	@optional +(id) cleanMultiValuePropertyValue:(NSString *)p0;
	@optional +(id) cleanMultiValuePropertyArray:(NSArray *)p0 forKey:(NSString *)p1;
	@optional +(id) cleanObjectValue:(NSObject *)p0 context:(int)p1;
	@optional +(BOOL) isRestrictedEventName:(NSString *)p0;
	@optional +(BOOL) isDiscaredEventName:(NSString *)p0;
	@optional +(void) setDiscardedEvents:(NSArray *)p0;
	@optional +(BOOL) isValidCleverTapId:(NSString *)p0;
@end

@interface UIKit_UIView_UIViewAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface CleverTapSDK_CTInAppPassThroughView_CTInAppPassThroughViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface UIKit_UIWindow_UIWindowAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface CleverTapSDK_CTInAppPassThroughWindow_CTInAppPassThroughWindowAppearance : UIKit_UIWindow_UIWindowAppearance {
}
@end


