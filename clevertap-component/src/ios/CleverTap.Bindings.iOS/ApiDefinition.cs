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

		// @property (readonly, strong) NSString * model;
		[Export("model", ArgumentSemantic.Strong)]
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

		// @property (readonly, strong) NSString * advertisingIdentitier;
		[Export("advertisingIdentitier", ArgumentSemantic.Strong)]
		string AdvertisingIdentitier { get; }

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

		// @property (readonly, assign) BOOL wifi;
		[Export("wifi")]
		bool Wifi { get; }

		// @property (readonly, assign) BOOL advertisingTrackingEnabled;
		[Export("advertisingTrackingEnabled")]
		bool AdvertisingTrackingEnabled { get; }

		// @property (readonly, strong) NSMutableArray<CTValidationResult *> * validationErrors;
		[Export("validationErrors", ArgumentSemantic.Strong)]
		NSMutableArray<CTValidationResult> ValidationErrors { get; }

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
	}

	// @interface CTInAppUtils : NSObject
	[BaseType(typeof(NSObject))]
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

		// +(NSString * _Nullable)XibNameForControllerName:(NSString * _Nonnull)controllerName;
		[Static]
		[Export("XibNameForControllerName:")]
		[return: NullAllowed]
		string XibNameForControllerName(string controllerName);

		// +(UIImage * _Nullable)imageForName:(NSString * _Nonnull)name type:(NSString * _Nonnull)type;
		[Static]
		[Export("imageForName:type:")]
		[return: NullAllowed]
		UIImage ImageForName(string name, string type);

		// +(UIColor * _Nullable)ct_colorWithHexString:(NSString * _Nonnull)string;
		[Static]
		[Export("ct_colorWithHexString:")]
		[return: NullAllowed]
		UIColor Ct_colorWithHexString(string @string);

		// +(UIColor * _Nullable)ct_colorWithHexString:(NSString * _Nonnull)string withAlpha:(CGFloat)alpha;
		[Static]
		[Export("ct_colorWithHexString:withAlpha:")]
		[return: NullAllowed]
		UIColor Ct_colorWithHexString(string @string, nfloat alpha);
	}

	// @interface CTNotificationButton : NSObject
	[BaseType(typeof(NSObject))]
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
	[Protocol, Model(AutoGeneratedName = true)]
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
	interface CTInAppPassThroughWindow
	{
	}

	// @protocol CTInAppPassThroughViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
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

		[Static]
		// @property (readwrite, nonatomic, strong) CTInAppNotification * notification;
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
	[BaseType(typeof(NSObject))]
	interface CTInAppFCManager
	{
		// -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config;
		[Export("initWithConfig:")]
		IntPtr Constructor(CleverTapInstanceConfig config);

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

		// -(void)changeUser;
		[Export("changeUser")]
		void ChangeUser();

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

	// @interface CTInAppResources : NSObject
	[BaseType(typeof(NSObject))]
	interface CTInAppResources
	{
		// +(NSBundle * _Nonnull)bundle;
		[Static]
		[Export("bundle")]

		NSBundle Bundle { get; }

		// +(NSString * _Nonnull)XibNameForControllerName:(NSString * _Nonnull)controllerName;
		[Static]
		[Export("XibNameForControllerName:")]
		string XibNameForControllerName(string controllerName);

		// +(UIImage * _Nonnull)imageForName:(NSString * _Nonnull)name type:(NSString * _Nonnull)type;
		[Static]
		[Export("imageForName:type:")]
		UIImage ImageForName(string name, string type);

		// +(UIApplication * _Nonnull)getSharedApplication;
		[Static]
		[Export("getSharedApplication")]

		UIApplication SharedApplication { get; }
	}

	// @interface CTKnownProfileFields : NSObject
	[BaseType(typeof(NSObject))]
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

	// @interface CTLocalDataStore : NSObject
	[BaseType(typeof(NSObject))]
	interface CTLocalDataStore
	{
		// -(instancetype)initWithConfig:(CleverTapInstanceConfig *)config andProfileValues:(NSDictionary *)profileValues;
		[Export("initWithConfig:andProfileValues:")]
		IntPtr Constructor(CleverTapInstanceConfig config, NSDictionary profileValues);

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
	interface CTLocationManager
	{
	}

	// @interface CTPlistInfo : NSObject
	[BaseType(typeof(NSObject))]
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

		// +(instancetype _Nullable)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		[return: NullAllowed]
		CTPlistInfo SharedInstance();

		// -(void)changeCredentialsWithAccountID:(NSString * _Nonnull)accountID token:(NSString * _Nonnull)token region:(NSString * _Nullable)region;
		[Export("changeCredentialsWithAccountID:token:region:")]
		void ChangeCredentialsWithAccountID(string accountID, string token, [NullAllowed] string region);
	}

	// @interface CTPreferences : NSObject
	[BaseType(typeof(NSObject))]
	interface CTPreferences
	{
		// +(long)getIntForKey:(NSString *)key withResetValue:(long)resetValue;
		[Static]
		[Export("getIntForKey:withResetValue:")]
		nint GetIntForKey(string key, nint resetValue);

		// +(void)putInt:(long)resetValue forKey:(NSString *)key;
		[Static]
		[Export("putInt:forKey:")]
		void PutInt(nint resetValue, string key);

		// +(NSString *)getStringForKey:(NSString *)key withResetValue:(NSString *)resetValue;
		[Static]
		[Export("getStringForKey:withResetValue:")]
		string GetStringForKey(string key, string resetValue);

		// +(void)putString:(NSString *)resetValue forKey:(NSString *)key;
		[Static]
		[Export("putString:forKey:")]
		void PutString(string resetValue, string key);

		// +(id)getObjectForKey:(NSString *)key;
		[Static]
		[Export("getObjectForKey:")]
		NSObject GetObjectForKey(string key);

		// +(void)putObject:(id)object forKey:(NSString *)key;
		[Static]
		[Export("putObject:forKey:")]
		void PutObject(NSObject @object, string key);

		// +(void)removeObjectForKey:(NSString *)key;
		[Static]
		[Export("removeObjectForKey:")]
		void RemoveObjectForKey(string key);

		// +(id)unarchiveFromFile:(NSString *)filePath removeFile:(BOOL)remove;
		[Static]
		[Export("unarchiveFromFile:removeFile:")]
		NSObject UnarchiveFromFile(string filePath, bool remove);

		// +(BOOL)archiveObject:(id)object forFileName:(NSString *)fileName;
		[Static]
		[Export("archiveObject:forFileName:")]
		bool ArchiveObject(NSObject @object, string fileName);
	}

	// @interface CTProfileBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface CTProfileBuilder
	{
		// +(void)build:(NSDictionary * _Nonnull)profile completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
		[Static]
		[Export("build:completionHandler:")]
		void Build(NSDictionary profile, Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion);

		// +(void)buildGraphUser:(id _Nonnull)graphUser completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
		[Static]
		[Export("buildGraphUser:completionHandler:")]
		void BuildGraphUser(NSObject graphUser, Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion);

		// +(void)buildGooglePlusUser:(id _Nonnull)googleUser completionHandler:(void (^ _Nonnull)(NSDictionary * _Nullable, NSDictionary * _Nullable, NSArray<CTValidationResult *> * _Nullable))completion;
		[Static]
		[Export("buildGooglePlusUser:completionHandler:")]
		void BuildGooglePlusUser(NSObject googleUser, Action<NSDictionary, NSDictionary, NSArray<CTValidationResult>> completion);

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

	// @interface CTUriHelper : NSObject
	[BaseType(typeof(NSObject))]
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

	// @interface CleverTap : NSObject
	[BaseType(typeof(NSObject))]
	interface CleverTap
	{
		// @property (readonly, nonatomic, strong) CleverTapInstanceConfig * _Nonnull config;
		[Export("config", ArgumentSemantic.Strong)]
		CleverTapInstanceConfig Config { get; }

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

		// -(void)profilePushGraphUser:(id _Nonnull)fbGraphUser;
		[Export("profilePushGraphUser:")]
		void ProfilePushGraphUser(NSObject fbGraphUser);

		// -(void)profilePushGooglePlusUser:(id _Nonnull)googleUser;
		[Export("profilePushGooglePlusUser:")]
		void ProfilePushGooglePlusUser(NSObject googleUser);

		// -(id _Nullable)profileGet:(NSString * _Nonnull)propertyName;
		[Export("profileGet:")]
		[return: NullAllowed]
		NSObject ProfileGet(string propertyName);

		// -(NSString * _Nullable)profileGetCleverTapID;
		[NullAllowed, Export("profileGetCleverTapID")]

		string ProfileGetCleverTapID { get; }

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

		// -(void)setInAppNotificationDelegate:(id<CleverTapInAppNotificationDelegate> _Nullable)delegate;
		[Export("setInAppNotificationDelegate:")]
		void SetInAppNotificationDelegate([NullAllowed] CleverTapInAppNotificationDelegate @delegate);

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

		// -(void)showInAppNotificationIfAny;
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
	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull CleverTapProfileDidChangeNotification;
		[Field("CleverTapProfileDidChangeNotification", "__Internal")]
		NSString CleverTapProfileDidChangeNotification { get; }

		// extern NSString *const _Nonnull CleverTapProfileDidInitializeNotification;
		[Field("CleverTapProfileDidInitializeNotification", "__Internal")]
		NSString CleverTapProfileDidInitializeNotification { get; }
	}

	// typedef void (^CleverTapExperimentsUpdatedBlock)();
	delegate void CleverTapExperimentsUpdatedBlock();

	// @interface ABTesting (CleverTap)
	[Category]
	[BaseType(typeof(CleverTap))]
	interface CleverTap_ABTesting
	{
		// +(void)setUIEditorConnectionEnabled:(BOOL)enabled;
		[Static]
		[Export("setUIEditorConnectionEnabled:")]
		void SetUIEditorConnectionEnabled(bool enabled);

		// +(BOOL)isUIEditorConnectionEnabled;
		[Static]
		[Export("isUIEditorConnectionEnabled")]

		bool IsUIEditorConnectionEnabled { get; }

		// -(void)registerExperimentsUpdatedBlock:(CleverTapExperimentsUpdatedBlock _Nonnull)block;
		[Export("registerExperimentsUpdatedBlock:")]
		void RegisterExperimentsUpdatedBlock(CleverTapExperimentsUpdatedBlock block);

		// -(void)registerBoolVariableWithName:(NSString * _Nonnull)name;
		[Export("registerBoolVariableWithName:")]
		void RegisterBoolVariableWithName(string name);

		// -(void)registerDoubleVariableWithName:(NSString * _Nonnull)name;
		[Export("registerDoubleVariableWithName:")]
		void RegisterDoubleVariableWithName(string name);

		// -(void)registerIntegerVariableWithName:(NSString * _Nonnull)name;
		[Export("registerIntegerVariableWithName:")]
		void RegisterIntegerVariableWithName(string name);

		// -(void)registerStringVariableWithName:(NSString * _Nonnull)name;
		[Export("registerStringVariableWithName:")]
		void RegisterStringVariableWithName(string name);

		// -(void)registerArrayOfBoolVariableWithName:(NSString * _Nonnull)name;
		[Export("registerArrayOfBoolVariableWithName:")]
		void RegisterArrayOfBoolVariableWithName(string name);

		// -(void)registerArrayOfDoubleVariableWithName:(NSString * _Nonnull)name;
		[Export("registerArrayOfDoubleVariableWithName:")]
		void RegisterArrayOfDoubleVariableWithName(string name);

		// -(void)registerArrayOfIntegerVariableWithName:(NSString * _Nonnull)name;
		[Export("registerArrayOfIntegerVariableWithName:")]
		void RegisterArrayOfIntegerVariableWithName(string name);

		// -(void)registerArrayOfStringVariableWithName:(NSString * _Nonnull)name;
		[Export("registerArrayOfStringVariableWithName:")]
		void RegisterArrayOfStringVariableWithName(string name);

		// -(void)registerDictionaryOfBoolVariableWithName:(NSString * _Nonnull)name;
		[Export("registerDictionaryOfBoolVariableWithName:")]
		void RegisterDictionaryOfBoolVariableWithName(string name);

		// -(void)registerDictionaryOfDoubleVariableWithName:(NSString * _Nonnull)name;
		[Export("registerDictionaryOfDoubleVariableWithName:")]
		void RegisterDictionaryOfDoubleVariableWithName(string name);

		// -(void)registerDictionaryOfIntegerVariableWithName:(NSString * _Nonnull)name;
		[Export("registerDictionaryOfIntegerVariableWithName:")]
		void RegisterDictionaryOfIntegerVariableWithName(string name);

		// -(void)registerDictionaryOfStringVariableWithName:(NSString * _Nonnull)name;
		[Export("registerDictionaryOfStringVariableWithName:")]
		void RegisterDictionaryOfStringVariableWithName(string name);

		// -(BOOL)getBoolVariableWithName:(NSString * _Nonnull)name defaultValue:(BOOL)defaultValue;
		[Export("getBoolVariableWithName:defaultValue:")]
		bool GetBoolVariableWithName(string name, bool defaultValue);

		// -(double)getDoubleVariableWithName:(NSString * _Nonnull)name defaultValue:(double)defaultValue;
		[Export("getDoubleVariableWithName:defaultValue:")]
		double GetDoubleVariableWithName(string name, double defaultValue);

		// -(int)getIntegerVariableWithName:(NSString * _Nonnull)name defaultValue:(int)defaultValue;
		[Export("getIntegerVariableWithName:defaultValue:")]
		int GetIntegerVariableWithName(string name, int defaultValue);

		// -(NSString * _Nonnull)getStringVariableWithName:(NSString * _Nonnull)name defaultValue:(NSString * _Nonnull)defaultValue;
		[Export("getStringVariableWithName:defaultValue:")]
		string GetStringVariableWithName(string name, string defaultValue);

		// -(NSArray<NSNumber *> * _Nonnull)getArrayOfBoolVariableWithName:(NSString * _Nonnull)name defaultValue:(NSArray<NSNumber *> * _Nonnull)defaultValue;
		[Export("getArrayOfBoolVariableWithName:defaultValue:")]
		NSNumber[] GetArrayOfBoolVariableWithName(string name, NSNumber[] defaultValue);

		// -(NSArray<NSNumber *> * _Nonnull)getArrayOfDoubleVariableWithName:(NSString * _Nonnull)name defaultValue:(NSArray<NSNumber *> * _Nonnull)defaultValue;
		[Export("getArrayOfDoubleVariableWithName:defaultValue:")]
		NSNumber[] GetArrayOfDoubleVariableWithName(string name, NSNumber[] defaultValue);

		// -(NSArray<NSNumber *> * _Nonnull)getArrayOfIntegerVariableWithName:(NSString * _Nonnull)name defaultValue:(NSArray<NSNumber *> * _Nonnull)defaultValue;
		[Export("getArrayOfIntegerVariableWithName:defaultValue:")]
		NSNumber[] GetArrayOfIntegerVariableWithName(string name, NSNumber[] defaultValue);

		// -(NSArray<NSString *> * _Nonnull)getArrayOfStringVariableWithName:(NSString * _Nonnull)name defaultValue:(NSArray<NSString *> * _Nonnull)defaultValue;
		[Export("getArrayOfStringVariableWithName:defaultValue:")]
		string[] GetArrayOfStringVariableWithName(string name, string[] defaultValue);

		// -(NSDictionary<NSString *,NSNumber *> * _Nonnull)getDictionaryOfBoolVariableWithName:(NSString * _Nonnull)name defaultValue:(NSDictionary<NSString *,NSNumber *> * _Nonnull)defaultValue;
		[Export("getDictionaryOfBoolVariableWithName:defaultValue:")]
		NSDictionary<NSString, NSNumber> GetDictionaryOfBoolVariableWithName(string name, NSDictionary<NSString, NSNumber> defaultValue);

		// -(NSDictionary<NSString *,NSNumber *> * _Nonnull)getDictionaryOfDoubleVariableWithName:(NSString * _Nonnull)name defaultValue:(NSDictionary<NSString *,NSNumber *> * _Nonnull)defaultValue;
		[Export("getDictionaryOfDoubleVariableWithName:defaultValue:")]
		NSDictionary<NSString, NSNumber> GetDictionaryOfDoubleVariableWithName(string name, NSDictionary<NSString, NSNumber> defaultValue);

		// -(NSDictionary<NSString *,NSNumber *> * _Nonnull)getDictionaryOfIntegerVariableWithName:(NSString * _Nonnull)name defaultValue:(NSDictionary<NSString *,NSNumber *> * _Nonnull)defaultValue;
		[Export("getDictionaryOfIntegerVariableWithName:defaultValue:")]
		NSDictionary<NSString, NSNumber> GetDictionaryOfIntegerVariableWithName(string name, NSDictionary<NSString, NSNumber> defaultValue);

		// -(NSDictionary<NSString *,NSString *> * _Nonnull)getDictionaryOfStringVariableWithName:(NSString * _Nonnull)name defaultValue:(NSDictionary<NSString *,NSString *> * _Nonnull)defaultValue;
		[Export("getDictionaryOfStringVariableWithName:defaultValue:")]
		NSDictionary<NSString, NSString> GetDictionaryOfStringVariableWithName(string name, NSDictionary<NSString, NSString> defaultValue);
	}

	// @interface CleverTapDisplayUnit : NSObject
	[BaseType(typeof(NSObject))]
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
	[Protocol, Model(AutoGeneratedName = true)]
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
		[Static]
		[Export("getAllDisplayUnits")]
		CleverTapDisplayUnit[] AllDisplayUnits { get; }

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
	[Protocol, Model(AutoGeneratedName = true)]
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

	// @interface CleverTapInboxMessage : NSObject
	[BaseType(typeof(NSObject))]
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
	[Protocol, Model(AutoGeneratedName = true)]
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
	}

	// @interface CleverTapInboxViewController : UITableViewController
	[BaseType(typeof(UITableViewController))]
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

		// -(NSUInteger)getInboxMessageCount;
		[Static]
		[Export("getInboxMessageCount")]

		nuint InboxMessageCount { get; }

		// -(NSUInteger)getInboxMessageUnreadCount;
		[Static]
		[Export("getInboxMessageUnreadCount")]

		nuint InboxMessageUnreadCount { get; }

		// -(NSArray<CleverTapInboxMessage *> * _Nonnull)getAllInboxMessages;
		[Static]
		[Export("getAllInboxMessages")]
		CleverTapInboxMessage[] AllInboxMessages { get; }

		// -(NSArray<CleverTapInboxMessage *> * _Nonnull)getUnreadInboxMessages;
		[Static]
		[Export("getUnreadInboxMessages")]
		CleverTapInboxMessage[] UnreadInboxMessages { get; }

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
	[Protocol, Model(AutoGeneratedName = true)]
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

	// @interface SSLPinning (CleverTap)
	[Category]
	[BaseType(typeof(CleverTap))]
	interface CleverTap_SSLPinning
	{
	}

	// @interface CleverTapEventDetail : NSObject
	[BaseType(typeof(NSObject))]
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
	[Protocol, Model(AutoGeneratedName = true)]
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

		// @property (assign, nonatomic) CleverTapLogLevel logLevel;
		[Export("logLevel", ArgumentSemantic.Assign)]
		CleverTapLogLevel LogLevel { get; set; }

		// -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken;
		[Export("initWithAccountId:accountToken:")]
		IntPtr Constructor(string accountId, string accountToken);

		// -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken accountRegion:(NSString * _Nonnull)accountRegion;
		[Export("initWithAccountId:accountToken:accountRegion:")]
		IntPtr Constructor(string accountId, string accountToken, string accountRegion);
	}

	// @interface  (CleverTapInstanceConfig) <NSCopying>
	[Static]
	[Category]
	[BaseType(typeof(CleverTapInstanceConfig))]
	interface CleverTapInstanceConfig_ //awak: INSCopying
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

		// -(instancetype _Nonnull)initWithAccountId:(NSString * _Nonnull)accountId accountToken:(NSString * _Nonnull)accountToken accountRegion:(NSString * _Nullable)accountRegion isDefaultInstance:(BOOL)isDefault;
		//awak[Export("initWithAccountId:accountToken:accountRegion:isDefaultInstance:")]
		//awakIntPtr Constructor(string accountId, string accountToken, [NullAllowed] string accountRegion, bool isDefault);
	}

	// @protocol CleverTapSyncDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
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
	interface CleverTapTrackedViewController
	{
		// @property (readwrite, copy, nonatomic) NSString * screenName;
		[Export("screenName")]
		string ScreenName { get; set; }
	}

	// @interface CleverTapUTMDetail : NSObject
	[BaseType(typeof(NSObject))]
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
