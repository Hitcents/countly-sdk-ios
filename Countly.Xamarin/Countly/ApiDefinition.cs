using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using WatchConnectivity;

namespace CountlySDK
{
	//// @protocol CountlyUserDetailsNullableString <NSObject>
	//[Protocol, Model]
	//[BaseType (typeof(NSObject))]
	//interface CountlyUserDetailsNullableString
	//{
	//}

	//// @interface NSStringWithCountlyUserDetailsNullableString (NSString) <CountlyUserDetailsNullableString>
	//[Category]
	//[BaseType (typeof(NSString))]
	//interface NSString_NSStringWithCountlyUserDetailsNullableString : ICountlyUserDetailsNullableString
	//{
	//}

	//// @interface NSNullWithCountlyUserDetailsNullableString (NSNull) <CountlyUserDetailsNullableString>
	//[Category]
	//[BaseType (typeof(NSNull))]
	//interface NSNull_NSNullWithCountlyUserDetailsNullableString : ICountlyUserDetailsNullableString
	//{
	//}

	//// @protocol CountlyUserDetailsNullableDictionary <NSObject>
	//[Protocol, Model]
	//[BaseType (typeof(NSObject))]
	//interface CountlyUserDetailsNullableDictionary
	//{
	//}

	//// @interface NSDictionaryWithCountlyUserDetailsNullableDictionary (NSDictionary) <CountlyUserDetailsNullableDictionary>
	//[Category]
	//[BaseType (typeof(NSDictionary))]
	//interface NSDictionary_NSDictionaryWithCountlyUserDetailsNullableDictionary : ICountlyUserDetailsNullableDictionary
	//{
	//}

	//// @interface NSNullWithCountlyUserDetailsNullableDictionary (NSNull) <CountlyUserDetailsNullableDictionary>
	//[Category]
	//[BaseType (typeof(NSNull))]
	//interface NSNull_NSNullWithCountlyUserDetailsNullableDictionary : ICountlyUserDetailsNullableDictionary
	//{
	//}

	//// @protocol CountlyUserDetailsNullableNumber <NSObject>
	//[Protocol, Model]
	//[BaseType (typeof(NSObject))]
	//interface CountlyUserDetailsNullableNumber
	//{
	//}

	//// @interface NSDictionaryWithCountlyUserDetailsNullableNumber (NSNumber) <CountlyUserDetailsNullableNumber>
	//[Category]
	//[BaseType (typeof(NSNumber))]
	//interface NSNumber_NSDictionaryWithCountlyUserDetailsNullableNumber : ICountlyUserDetailsNullableNumber
	//{
	//}

	//// @interface NSNullWithCountlyUserDetailsNullableNumber (NSNull) <CountlyUserDetailsNullableNumber>
	//[Category]
	//[BaseType (typeof(NSNull))]
	//interface NSNull_NSNullWithCountlyUserDetailsNullableNumber : ICountlyUserDetailsNullableNumber
	//{
	//}

	// @interface CountlyUserDetails : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyUserDetails
	{
		// @property (nonatomic, strong) id<string> name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) id<string> username;
		[Export ("username", ArgumentSemantic.Strong)]
		string Username { get; set; }

		// @property (nonatomic, strong) id<string> email;
		[Export ("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) id<string> organization;
		[Export ("organization", ArgumentSemantic.Strong)]
		string Organization { get; set; }

		// @property (nonatomic, strong) id<string> phone;
		[Export ("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (nonatomic, strong) id<string> gender;
		[Export ("gender", ArgumentSemantic.Strong)]
		string Gender { get; set; }

		// @property (nonatomic, strong) id<string> pictureURL;
		[Export ("pictureURL", ArgumentSemantic.Strong)]
		string PictureURL { get; set; }

		// @property (nonatomic, strong) id<string> pictureLocalPath;
		[Export ("pictureLocalPath", ArgumentSemantic.Strong)]
		string PictureLocalPath { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableNumber> birthYear;
		[Export ("birthYear", ArgumentSemantic.Strong)]
		nint BirthYear { get; set; }

		// @property (nonatomic, strong) id<CountlyUserDetailsNullableDictionary> custom;
		[Export ("custom", ArgumentSemantic.Strong)]
		NSDictionary Custom { get; set; }

		// +(CountlyUserDetails *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		//[Verify (MethodToProperty)]
		CountlyUserDetails SharedInstance { get; }

		// -(void)recordUserDetails;
		[Export ("recordUserDetails")]
		void RecordUserDetails ();

		// -(NSString *)serialize;
		[Export ("serialize")]
		//[Verify (MethodToProperty)]
        string Serialize { get; }

		// -(NSData *)pictureUploadDataForRequest:(NSString *)requestString;
		[Export ("pictureUploadDataForRequest:")]
		NSData PictureUploadDataForRequest (string requestString);

		// -(void)set:(NSString *)key value:(NSString *)value;
		[Export ("set:value:")]
		void Set (string key, string value);

		// -(void)setOnce:(NSString *)key value:(NSString *)value;
		[Export ("setOnce:value:")]
		void SetOnce (string key, string value);

		// -(void)unSet:(NSString *)key;
		[Export ("unSet:")]
		void UnSet (string key);

		// -(void)increment:(NSString *)key;
		[Export ("increment:")]
		void Increment (string key);

		// -(void)incrementBy:(NSString *)key value:(NSInteger)value;
		[Export ("incrementBy:value:")]
		void IncrementBy (string key, nint value);

		// -(void)multiply:(NSString *)key value:(NSInteger)value;
		[Export ("multiply:value:")]
		void Multiply (string key, nint value);

		// -(void)max:(NSString *)key value:(NSInteger)value;
		[Export ("max:value:")]
		void Max (string key, nint value);

		// -(void)min:(NSString *)key value:(NSInteger)value;
		[Export ("min:value:")]
		void Min (string key, nint value);

		// -(void)push:(NSString *)key value:(NSString *)value;
		[Export ("push:value:")]
		void Push (string key, string value);

		// -(void)push:(NSString *)key values:(NSArray *)value;
		[Export ("push:values:")]
		//[Verify (StronglyTypedNSArray)]
		void Push (string key, NSObject[] value);

		// -(void)pushUnique:(NSString *)key value:(NSString *)value;
		[Export ("pushUnique:value:")]
		void PushUnique (string key, string value);

		// -(void)pushUnique:(NSString *)key values:(NSArray *)value;
		[Export ("pushUnique:values:")]
		//[Verify (StronglyTypedNSArray)]
		void PushUnique (string key, NSObject[] value);

		// -(void)pull:(NSString *)key value:(NSString *)value;
		[Export ("pull:value:")]
		void Pull (string key, string value);

		// -(void)pull:(NSString *)key values:(NSArray *)value;
		[Export ("pull:values:")]
		//[Verify (StronglyTypedNSArray)]
		void Pull (string key, NSObject[] value);

		// -(void)save;
		[Export ("save")]
		void Save ();
	}

	// @interface CountlyCrashReporter : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyCrashReporter
	{
		// @property (nonatomic, strong) NSDictionary * crashSegmentation;
		[Export ("crashSegmentation", ArgumentSemantic.Strong)]
		NSDictionary CrashSegmentation { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyCrashReporter SharedInstance ();

		// -(void)startCrashReporting;
		[Export ("startCrashReporting")]
		void StartCrashReporting ();

		// -(void)recordHandledException:(NSException *)exception;
		[Export ("recordHandledException:")]
		void RecordHandledException (NSException exception);

		// -(void)logWithFormat:(NSString *)format andArguments:(va_list)args;
		//[Export ("logWithFormat:andArguments:")]
		//unsafe void LogWithFormat (string format, sbyte* args);

		// -(void)crashTest;
		[Export ("crashTest")]
		void CrashTest ();

		// -(void)crashTest2;
		[Export ("crashTest2")]
		void CrashTest2 ();

		// -(void)crashTest3;
		[Export ("crashTest3")]
		void CrashTest3 ();

		// -(void)crashTest4;
		[Export ("crashTest4")]
		void CrashTest4 ();

		// -(void)crashTest5;
		[Export ("crashTest5")]
		void CrashTest5 ();

		// -(void)crashTest6;
		[Export ("crashTest6")]
		void CrashTest6 ();
	}

	//[Static]
	////[Verify (ConstantsInterfaceAssociation)]
	//partial interface Constants
	//{
	//	// extern NSString *const CLYMessaging;
	//	[Field ("CLYMessaging", "__Internal")]
	//	NSString CLYMessaging { get; }

	//	// extern NSString *const CLYCrashReporting;
	//	[Field ("CLYCrashReporting", "__Internal")]
	//	NSString CLYCrashReporting { get; }

	//	// extern NSString *const CLYAutoViewTracking;
	//	[Field ("CLYAutoViewTracking", "__Internal")]
	//	NSString CLYAutoViewTracking { get; }

	//	// extern NSString *const CLYAPM;
	//	[Field ("CLYAPM", "__Internal")]
	//	NSString CLYAPM { get; }

	//	// extern NSString *const CLYIDFV;
	//	[Field ("CLYIDFV", "__Internal")]
	//	NSString CLYIDFV { get; }

	//	// extern NSString *const CLYIDFA __attribute__((deprecated("Use CLYIDFV instead!")));
	//	[Field ("CLYIDFA", "__Internal")]
	//	NSString CLYIDFA { get; }

	//	// extern NSString *const CLYOpenUDID __attribute__((deprecated("Use CLYIDFV instead!")));
	//	[Field ("CLYOpenUDID", "__Internal")]
	//	NSString CLYOpenUDID { get; }
	//}

	// @interface CountlyConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyConfig
	{
		// @property (nonatomic, strong) NSString * host;
		[Export ("host", ArgumentSemantic.Strong)]
		string Host { get; set; }

		// @property (nonatomic, strong) NSString * appKey;
		[Export ("appKey", ArgumentSemantic.Strong)]
		string AppKey { get; set; }

		// @property (nonatomic, strong) NSArray * features;
		[Export ("features", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Features { get; set; }

		// @property (nonatomic, strong) NSDictionary * launchOptions;
		[Export ("launchOptions", ArgumentSemantic.Strong)]
		NSDictionary LaunchOptions { get; set; }

		// @property (nonatomic) BOOL isTestDevice;
		[Export ("isTestDevice")]
		bool IsTestDevice { get; set; }

		// @property (nonatomic, strong) NSDictionary * crashSegmentation;
		[Export ("crashSegmentation", ArgumentSemantic.Strong)]
		NSDictionary CrashSegmentation { get; set; }

		// @property (nonatomic, strong) NSString * deviceID;
		[Export ("deviceID", ArgumentSemantic.Strong)]
		string DeviceID { get; set; }

		// @property (nonatomic) BOOL forceDeviceIDInitialization;
		[Export ("forceDeviceIDInitialization")]
		bool ForceDeviceIDInitialization { get; set; }

		// @property (nonatomic) NSTimeInterval updateSessionPeriod;
		[Export ("updateSessionPeriod")]
		double UpdateSessionPeriod { get; set; }

		// @property (nonatomic) NSUInteger eventSendThreshold;
		[Export ("eventSendThreshold")]
		nuint EventSendThreshold { get; set; }

		// @property (nonatomic) NSUInteger storedRequestsLimit;
		[Export ("storedRequestsLimit")]
		nuint StoredRequestsLimit { get; set; }

		// @property (nonatomic, strong) NSString * ISOCountryCode;
		[Export ("ISOCountryCode", ArgumentSemantic.Strong)]
		string ISOCountryCode { get; set; }

		// @property (nonatomic, strong) NSString * city;
		[Export ("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic) CLLocationCoordinate2D location;
		[Export ("location", ArgumentSemantic.Assign)]
		CLLocationCoordinate2D Location { get; set; }

		// @property (nonatomic, strong) NSArray * pinnedCertificates;
		[Export ("pinnedCertificates", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] PinnedCertificates { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldName;
		[Export ("customHeaderFieldName", ArgumentSemantic.Strong)]
		string CustomHeaderFieldName { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldValue;
		[Export ("customHeaderFieldValue", ArgumentSemantic.Strong)]
		string CustomHeaderFieldValue { get; set; }

		// @property (nonatomic, strong) NSString * secretSalt;
		[Export ("secretSalt", ArgumentSemantic.Strong)]
		string SecretSalt { get; set; }

		// @property (nonatomic) BOOL alwaysUsePOST;
		[Export ("alwaysUsePOST")]
		bool AlwaysUsePOST { get; set; }

		// @property (nonatomic, strong) NSString * starRatingMessage;
		[Export ("starRatingMessage", ArgumentSemantic.Strong)]
		string StarRatingMessage { get; set; }

		// @property (nonatomic, strong) NSString * starRatingDismissButtonTitle;
		[Export ("starRatingDismissButtonTitle", ArgumentSemantic.Strong)]
		string StarRatingDismissButtonTitle { get; set; }

		// @property (nonatomic) NSUInteger starRatingSessionCount;
		[Export ("starRatingSessionCount")]
		nuint StarRatingSessionCount { get; set; }

		// @property (nonatomic) BOOL starRatingDisableAskingForEachAppVersion;
		[Export ("starRatingDisableAskingForEachAppVersion")]
		bool StarRatingDisableAskingForEachAppVersion { get; set; }
	}

	// @interface Countly : NSObject
	[BaseType (typeof(NSObject))]
	interface Countly
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		Countly SharedInstance ();

		// -(void)startWithConfig:(CountlyConfig *)config;
		[Export ("startWithConfig:")]
		void StartWithConfig (CountlyConfig config);

		// -(void)setNewDeviceID:(NSString *)deviceID onServer:(BOOL)onServer;
		[Export ("setNewDeviceID:onServer:")]
		void SetNewDeviceID (string deviceID, bool onServer);

		// -(void)setCustomHeaderFieldValue:(NSString *)customHeaderFieldValue;
		[Export ("setCustomHeaderFieldValue:")]
		void SetCustomHeaderFieldValue (string customHeaderFieldValue);

		// -(void)suspend;
		[Export ("suspend")]
		void Suspend ();

		// -(void)resume;
		[Export ("resume")]
		void Resume ();

		// -(void)recordEvent:(NSString *)key;
		[Export ("recordEvent:")]
		void RecordEvent (string key);

		// -(void)recordEvent:(NSString *)key count:(NSUInteger)count;
		[Export ("recordEvent:count:")]
		void RecordEvent (string key, nuint count);

		// -(void)recordEvent:(NSString *)key sum:(double)sum;
		[Export ("recordEvent:sum:")]
		void RecordEvent (string key, double sum);

		// -(void)recordEvent:(NSString *)key duration:(NSTimeInterval)duration;
		[Export ("recordEvent:duration:")]
		void RecordEventDuration (string key, double duration);

		// -(void)recordEvent:(NSString *)key count:(NSUInteger)count sum:(double)sum;
		[Export ("recordEvent:count:sum:")]
		void RecordEvent (string key, nuint count, double sum);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation;
		[Export ("recordEvent:segmentation:")]
		void RecordEvent (string key, NSDictionary segmentation);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count;
		[Export ("recordEvent:segmentation:count:")]
		void RecordEvent (string key, NSDictionary segmentation, nuint count);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum;
		[Export ("recordEvent:segmentation:count:sum:")]
		void RecordEvent (string key, NSDictionary segmentation, nuint count, double sum);

		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum duration:(NSTimeInterval)duration;
		[Export ("recordEvent:segmentation:count:sum:duration:")]
		void RecordEvent (string key, NSDictionary segmentation, nuint count, double sum, double duration);

		// -(void)startEvent:(NSString *)key;
		[Export ("startEvent:")]
		void StartEvent (string key);

		// -(void)endEvent:(NSString *)key;
		[Export ("endEvent:")]
		void EndEvent (string key);

		// -(void)endEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum;
		[Export ("endEvent:segmentation:count:sum:")]
		void EndEvent (string key, NSDictionary segmentation, nuint count, double sum);

		// -(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;
		[Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
		void DidRegisterForRemoteNotificationsWithDeviceToken (NSData deviceToken);

		// -(void)didFailToRegisterForRemoteNotifications;
		[Export ("didFailToRegisterForRemoteNotifications")]
		void DidFailToRegisterForRemoteNotifications ();

		// -(NSMutableSet *)countlyNotificationCategories;
		[Export ("countlyNotificationCategories")]
		//[Verify (MethodToProperty)]
		NSMutableSet CountlyNotificationCategories { get; }

		// -(NSMutableSet *)countlyNotificationCategoriesWithActionTitles:(NSArray *)actions;
		[Export ("countlyNotificationCategoriesWithActionTitles:")]
		//[Verify (StronglyTypedNSArray)]
		NSMutableSet CountlyNotificationCategoriesWithActionTitles (NSObject[] actions);

		// -(BOOL)handleRemoteNotification:(NSDictionary *)info withButtonTitles:(NSArray *)titles;
		[Export ("handleRemoteNotification:withButtonTitles:")]
		//[Verify (StronglyTypedNSArray)]
		bool HandleRemoteNotification (NSDictionary info, NSObject[] titles);

		// -(BOOL)handleRemoteNotification:(NSDictionary *)info;
		[Export ("handleRemoteNotification:")]
		bool HandleRemoteNotification (NSDictionary info);

		// -(void)recordPushOpenForCountlyDictionary:(NSDictionary *)c;
		[Export ("recordPushOpenForCountlyDictionary:")]
		void RecordPushOpenForCountlyDictionary (NSDictionary c);

		// -(void)recordPushActionForCountlyDictionary:(NSDictionary *)c;
		[Export ("recordPushActionForCountlyDictionary:")]
		void RecordPushActionForCountlyDictionary (NSDictionary c);

		// -(void)recordLocation:(CLLocationCoordinate2D)coordinate;
		[Export ("recordLocation:")]
		void RecordLocation (CLLocationCoordinate2D coordinate);

		// -(void)recordHandledException:(NSException *)exception;
		[Export ("recordHandledException:")]
		void RecordHandledException (NSException exception);

		// -(void)crashLog:(NSString *)format, ... __attribute__((format(NSString, 1, 2)));
		[Internal]
		[Export ("crashLog:", IsVariadic = true)]
		void CrashLog (string format, IntPtr varArgs);

		// -(void)addExceptionForAPM:(NSString *)exceptionURL;
		[Export ("addExceptionForAPM:")]
		void AddExceptionForAPM (string exceptionURL);

		// -(void)removeExceptionForAPM:(NSString *)exceptionURL;
		[Export ("removeExceptionForAPM:")]
		void RemoveExceptionForAPM (string exceptionURL);

		// -(void)reportView:(NSString *)viewName;
		[Export ("reportView:")]
		void ReportView (string viewName);

		// -(void)addExceptionForAutoViewTracking:(Class)exceptionViewControllerSubclass;
		[Export ("addExceptionForAutoViewTracking:")]
		void AddExceptionForAutoViewTracking (Class exceptionViewControllerSubclass);

		// -(void)removeExceptionForAutoViewTracking:(Class)exceptionViewControllerSubclass;
		[Export ("removeExceptionForAutoViewTracking:")]
		void RemoveExceptionForAutoViewTracking (Class exceptionViewControllerSubclass);

		// @property (nonatomic) BOOL isAutoViewTrackingEnabled;
		[Export ("isAutoViewTrackingEnabled")]
		bool IsAutoViewTrackingEnabled { get; set; }

		// +(CountlyUserDetails *)user;
		[Static]
		[Export ("user")]
		//[Verify (MethodToProperty)]
		CountlyUserDetails User { get; }

		// -(void)askForStarRating:(void (^)(NSInteger))completion;
		[Export ("askForStarRating:")]
		void AskForStarRating (Action<nint> completion);
	}

	// @interface CountlyAPM : NSObject <NSURLConnectionDelegate, NSURLConnectionDataDelegate>
	[BaseType (typeof(NSObject))]
	interface CountlyAPM : INSUrlConnectionDelegate, INSUrlConnectionDataDelegate
	{
		// @property (nonatomic, strong) NSMutableArray * _Nonnull exceptionURLs;
		[Export ("exceptionURLs", ArgumentSemantic.Strong)]
		NSMutableArray ExceptionURLs { get; set; }

		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyAPM SharedInstance ();

		// -(void)startAPM;
		[Export ("startAPM")]
		void StartAPM ();

		// -(void)addExceptionForAPM:(NSString * _Nonnull)exceptionURL;
		[Export ("addExceptionForAPM:")]
		void AddExceptionForAPM (string exceptionURL);

		// -(void)removeExceptionForAPM:(NSString * _Nonnull)exceptionURL;
		[Export ("removeExceptionForAPM:")]
		void RemoveExceptionForAPM (string exceptionURL);
	}

	// @interface CountlyAPM (NSURLConnection)
	[Category]
	[BaseType (typeof(NSUrlConnection))]
	interface NSURLConnection_CountlyAPM
	{
		//[Wrap ("WeakOriginalDelegate")]
		//NSObject OriginalDelegate { get; set; }

		// @property (nonatomic, strong) id<NSURLConnectionDataDelegate,NSURLConnectionDelegate> _Nonnull originalDelegate;
		//[NullAllowed, Export ("originalDelegate", ArgumentSemantic.Strong)]
		//NSObject WeakOriginalDelegate { get; set; }

		// @property (nonatomic, strong) int * _Nonnull APMNetworkLog;
		//[Export ("APMNetworkLog", ArgumentSemantic.Strong)]
		//unsafe int* APMNetworkLog { get; set; }

		// +(NSData * _Nullable)Countly_sendSynchronousRequest:(NSURLRequest * _Nonnull)request returningResponse:(NSURLResponse * _Nullable * _Nullable)response error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("Countly_sendSynchronousRequest:returningResponse:error:")]
		[return: NullAllowed]
		NSData Countly_sendSynchronousRequest (NSUrlRequest request, [NullAllowed] out NSUrlResponse response, [NullAllowed] out NSError error);

		// +(void)Countly_sendAsynchronousRequest:(NSURLRequest * _Nonnull)request queue:(NSOperationQueue * _Nonnull)queue completionHandler:(void (^ _Nullable)(NSURLResponse * _Nullable, NSData * _Nullable, NSError * _Nullable))handler;
		[Static]
		[Export ("Countly_sendAsynchronousRequest:queue:completionHandler:")]
		void Countly_sendAsynchronousRequest (NSUrlRequest request, NSOperationQueue queue, [NullAllowed] Action<NSUrlResponse, NSData, NSError> handler);

		// -(instancetype _Nullable)Countly_initWithRequest:(NSURLRequest * _Nonnull)request delegate:(id _Nullable)delegate;
		[Export ("Countly_initWithRequest:delegate:")]
		[return: NullAllowed]
		NSUrlConnection Countly_initWithRequest (NSUrlRequest request, [NullAllowed] NSObject @delegate);

		// -(instancetype _Nullable)Countly_initWithRequest:(NSURLRequest * _Nonnull)request delegate:(id _Nullable)delegate startImmediately:(BOOL)startImmediately;
		[Export ("Countly_initWithRequest:delegate:startImmediately:")]
		[return: NullAllowed]
		NSUrlConnection Countly_initWithRequest (NSUrlRequest request, [NullAllowed] NSObject @delegate, bool startImmediately);

		// -(void)Countly_start;
		[Export ("Countly_start")]
		void Countly_start ();
	}

	// @interface CountlyAPM (NSURLSession)
	[Category]
	[BaseType (typeof(NSUrlSession))]
	interface NSURLSession_CountlyAPM
	{
		// -(NSURLSessionDataTask * _Nullable)Countly_dataTaskWithRequest:(NSURLRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSData * _Nullable, NSURLResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("Countly_dataTaskWithRequest:completionHandler:")]
		[return: NullAllowed]
		NSUrlSessionDataTask Countly_dataTaskWithRequest (NSUrlRequest request, [NullAllowed] Action<NSData, NSUrlResponse, NSError> completionHandler);

		// -(NSURLSessionDownloadTask * _Nullable)Countly_downloadTaskWithRequest:(NSURLRequest * _Nonnull)request completionHandler:(void (^ _Nullable)(NSURL * _Nullable, NSURLResponse * _Nullable, NSError * _Nullable))completionHandler;
		[Export ("Countly_downloadTaskWithRequest:completionHandler:")]
		[return: NullAllowed]
		NSUrlSessionDownloadTask Countly_downloadTaskWithRequest (NSUrlRequest request, [NullAllowed] Action<NSUrl, NSUrlResponse, NSError> completionHandler);
	}

	// @interface CountlyAPM (NSURLSessionTask)
	[Category]
	[BaseType (typeof(NSUrlSessionTask))]
	interface NSURLSessionTask_CountlyAPM
	{
		// @property (nonatomic, strong) int * _Nonnull APMNetworkLog;
		//[Export ("APMNetworkLog", ArgumentSemantic.Strong)]
		//unsafe int* APMNetworkLog { get; set; }

		// -(void)Countly_resume;
		[Export ("Countly_resume")]
		void Countly_resume ();
	}

	// @interface CountlyAPMNetworkLog : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyAPMNetworkLog
	{
		// @property (nonatomic, strong) NSURLRequest * request;
		[Export ("request", ArgumentSemantic.Strong)]
		NSUrlRequest Request { get; set; }

		// +(instancetype)createWithRequest:(NSURLRequest *)request startImmediately:(BOOL)startImmediately;
		[Static]
		[Export ("createWithRequest:startImmediately:")]
		CountlyAPMNetworkLog CreateWithRequest (NSUrlRequest request, bool startImmediately);

		// -(void)start;
		[Export ("start")]
		void Start ();

		// -(void)updateWithResponse:(NSURLResponse *)response;
		[Export ("updateWithResponse:")]
		void UpdateWithResponse (NSUrlResponse response);

		// -(void)finish;
		[Export ("finish")]
		void Finish ();

		// -(void)finishWithStatusCode:(NSInteger)statusCode andDataSize:(long long)dataSize;
		[Export ("finishWithStatusCode:andDataSize:")]
		void FinishWithStatusCode (nint statusCode, long dataSize);
	}

	// @interface Countly_OpenUDID : NSObject
	[BaseType (typeof(NSObject))]
	interface Countly_OpenUDID
	{
		// +(NSString *)value;
		[Static]
		[Export ("value")]
		//[Verify (MethodToProperty)]
		string Value { get; }

		// +(NSString *)valueWithError:(NSError **)error;
		[Static]
		[Export ("valueWithError:")]
		string ValueWithError (out NSError error);

		// +(void)setOptOut:(BOOL)optOutValue;
		[Static]
		[Export ("setOptOut:")]
		void SetOptOut (bool optOutValue);
	}

	// @interface CountlyPersistency : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyPersistency
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyPersistency SharedInstance ();

		// -(void)addToQueue:(NSString *)queryString;
		[Export ("addToQueue:")]
		void AddToQueue (string queryString);

		// -(void)removeFromQueue:(NSString *)queryString;
		[Export ("removeFromQueue:")]
		void RemoveFromQueue (string queryString);

		// -(NSString *)firstItemInQueue;
		[Export ("firstItemInQueue")]
		//[Verify (MethodToProperty)]
		string FirstItemInQueue { get; }

		// -(void)recordEvent:(CountlyEvent *)event;
		[Export ("recordEvent:")]
		void RecordEvent (CountlyEvent @event);

		// -(NSString *)serializedRecordedEvents;
		[Export ("serializedRecordedEvents")]
		//[Verify (MethodToProperty)]
		string SerializedRecordedEvents { get; }

		// -(void)recordTimedEvent:(CountlyEvent *)event;
		[Export ("recordTimedEvent:")]
		void RecordTimedEvent (CountlyEvent @event);

		// -(CountlyEvent *)timedEventForKey:(NSString *)key;
		[Export ("timedEventForKey:")]
		CountlyEvent TimedEventForKey (string key);

		// -(void)clearAllTimedEvents;
		[Export ("clearAllTimedEvents")]
		void ClearAllTimedEvents ();

		// -(void)saveToFile;
		[Export ("saveToFile")]
		void SaveToFile ();

		// -(void)saveToFileSync;
		[Export ("saveToFileSync")]
		void SaveToFileSync ();

		// -(NSString *)retrieveStoredDeviceID;
		[Export ("retrieveStoredDeviceID")]
		//[Verify (MethodToProperty)]
		string RetrieveStoredDeviceID { get; }

		// -(void)storeDeviceID:(NSString *)deviceID;
		[Export ("storeDeviceID:")]
		void StoreDeviceID (string deviceID);

		// -(NSString *)retrieveWatchParentDeviceID;
		[Export ("retrieveWatchParentDeviceID")]
		//[Verify (MethodToProperty)]
		string RetrieveWatchParentDeviceID { get; }

		// -(void)storeWatchParentDeviceID:(NSString *)deviceID;
		[Export ("storeWatchParentDeviceID:")]
		void StoreWatchParentDeviceID (string deviceID);

		// -(NSDictionary *)retrieveStarRatingStatus;
		[Export ("retrieveStarRatingStatus")]
		//[Verify (MethodToProperty)]
		NSDictionary RetrieveStarRatingStatus { get; }

		// -(void)storeStarRatingStatus:(NSDictionary *)status;
		[Export ("storeStarRatingStatus:")]
		void StoreStarRatingStatus (NSDictionary status);

		// @property (nonatomic) NSUInteger eventSendThreshold;
		[Export ("eventSendThreshold")]
		nuint EventSendThreshold { get; set; }

		// @property (nonatomic) NSUInteger storedRequestsLimit;
		[Export ("storedRequestsLimit")]
		nuint StoredRequestsLimit { get; set; }
	}

	// @interface CountlyConnectionManager : NSObject <NSURLSessionDelegate>
	[BaseType (typeof(NSObject))]
	interface CountlyConnectionManager : INSUrlSessionDelegate
	{
		// @property (nonatomic, strong) NSString * appKey;
		[Export ("appKey", ArgumentSemantic.Strong)]
		string AppKey { get; set; }

		// @property (nonatomic, strong) NSString * appHost;
		[Export ("appHost", ArgumentSemantic.Strong)]
		string AppHost { get; set; }

		// @property (nonatomic, strong) NSURLSessionTask * connection;
		[Export ("connection", ArgumentSemantic.Strong)]
		NSUrlSessionTask Connection { get; set; }

		// @property (nonatomic) BOOL isTestDevice;
		[Export ("isTestDevice")]
		bool IsTestDevice { get; set; }

		// @property (nonatomic) NSTimeInterval updateSessionPeriod;
		[Export ("updateSessionPeriod")]
		double UpdateSessionPeriod { get; set; }

		// @property (nonatomic, strong) NSArray * pinnedCertificates;
		[Export ("pinnedCertificates", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] PinnedCertificates { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldName;
		[Export ("customHeaderFieldName", ArgumentSemantic.Strong)]
		string CustomHeaderFieldName { get; set; }

		// @property (nonatomic, strong) NSString * customHeaderFieldValue;
		[Export ("customHeaderFieldValue", ArgumentSemantic.Strong)]
		string CustomHeaderFieldValue { get; set; }

		// @property (nonatomic, strong) NSString * secretSalt;
		[Export ("secretSalt", ArgumentSemantic.Strong)]
		string SecretSalt { get; set; }

		// @property (nonatomic) BOOL alwaysUsePOST;
		[Export ("alwaysUsePOST")]
		bool AlwaysUsePOST { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyConnectionManager SharedInstance ();

		// -(void)beginSession;
		[Export ("beginSession")]
		void BeginSession ();

		// -(void)updateSessionWithDuration:(int)duration;
		[Export ("updateSessionWithDuration:")]
		void UpdateSessionWithDuration (int duration);

		// -(void)endSessionWithDuration:(int)duration;
		[Export ("endSessionWithDuration:")]
		void EndSessionWithDuration (int duration);

		// -(void)sendEvents;
		[Export ("sendEvents")]
		void SendEvents ();

		// -(void)sendUserDetails:(NSString *)userDetails;
		[Export ("sendUserDetails:")]
		void SendUserDetails (string userDetails);

		// -(void)sendPushToken:(NSString *)token;
		[Export ("sendPushToken:")]
		void SendPushToken (string token);

		// -(void)sendCrashReportLater:(NSString *)report;
		[Export ("sendCrashReportLater:")]
		void SendCrashReportLater (string report);

		// -(void)sendOldDeviceID:(NSString *)oldDeviceID;
		[Export ("sendOldDeviceID:")]
		void SendOldDeviceID (string oldDeviceID);

		// -(void)sendParentDeviceID:(NSString *)parentDeviceID;
		[Export ("sendParentDeviceID:")]
		void SendParentDeviceID (string parentDeviceID);

		// -(void)sendLocation:(CLLocationCoordinate2D)coordinate;
		[Export ("sendLocation:")]
		void SendLocation (CLLocationCoordinate2D coordinate);

		// -(NSString *)queryEssentials;
		[Export ("queryEssentials")]
		//[Verify (MethodToProperty)]
		string QueryEssentials { get; }

		// -(NSString *)boundary;
		[Export ("boundary")]
		//[Verify (MethodToProperty)]
		string Boundary { get; }

		// -(BOOL)isRequestSuccessful:(NSURLResponse *)response;
		[Export ("isRequestSuccessful:")]
		bool IsRequestSuccessful (NSUrlResponse response);

		// -(void)tick;
		[Export ("tick")]
		void Tick ();
	}

	// @interface CountlyEvent : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface CountlyEvent : INSCoding
	{
		// @property (nonatomic, strong) NSString * key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; set; }

		// @property (nonatomic, strong) NSDictionary * segmentation;
		[Export ("segmentation", ArgumentSemantic.Strong)]
		NSDictionary Segmentation { get; set; }

		// @property (nonatomic) NSUInteger count;
		[Export ("count")]
		nuint Count { get; set; }

		// @property (nonatomic) double sum;
		[Export ("sum")]
		double Sum { get; set; }

		// @property (nonatomic) NSTimeInterval timestamp;
		[Export ("timestamp")]
		double Timestamp { get; set; }

		// @property (nonatomic) NSUInteger hourOfDay;
		[Export ("hourOfDay")]
		nuint HourOfDay { get; set; }

		// @property (nonatomic) NSUInteger dayOfWeek;
		[Export ("dayOfWeek")]
		nuint DayOfWeek { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		// -(NSDictionary *)dictionaryRepresentation;
		[Export ("dictionaryRepresentation")]
		//[Verify (MethodToProperty)]
		NSDictionary DictionaryRepresentation { get; }
	}

	// @interface CountlyDeviceInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyDeviceInfo
	{
		// @property (nonatomic, strong) NSString * deviceID;
		[Export ("deviceID", ArgumentSemantic.Strong)]
		string DeviceID { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyDeviceInfo SharedInstance ();

		// -(void)initializeDeviceID:(NSString *)deviceID;
		[Export ("initializeDeviceID:")]
		void InitializeDeviceID (string deviceID);

		// -(NSString *)zeroSafeIDFA;
		[Export ("zeroSafeIDFA")]
		//[Verify (MethodToProperty)]
		string ZeroSafeIDFA { get; }

		// +(NSString *)device;
		[Static]
		[Export ("device")]
		//[Verify (MethodToProperty)]
		string Device { get; }

		// +(NSString *)osName;
		[Static]
		[Export ("osName")]
		//[Verify (MethodToProperty)]
		string OsName { get; }

		// +(NSString *)osVersion;
		[Static]
		[Export ("osVersion")]
		//[Verify (MethodToProperty)]
		string OsVersion { get; }

		// +(NSString *)carrier;
		[Static]
		[Export ("carrier")]
		//[Verify (MethodToProperty)]
		string Carrier { get; }

		// +(NSString *)resolution;
		[Static]
		[Export ("resolution")]
		//[Verify (MethodToProperty)]
		string Resolution { get; }

		// +(NSString *)density;
		[Static]
		[Export ("density")]
		//[Verify (MethodToProperty)]
		string Density { get; }

		// +(NSString *)locale;
		[Static]
		[Export ("locale")]
		//[Verify (MethodToProperty)]
		string Locale { get; }

		// +(NSString *)appVersion;
		[Static]
		[Export ("appVersion")]
		//[Verify (MethodToProperty)]
		string AppVersion { get; }

		// +(NSString *)appBuild;
		[Static]
		[Export ("appBuild")]
		//[Verify (MethodToProperty)]
		string AppBuild { get; }

		// +(NSString *)buildUUID;
		[Static]
		[Export ("buildUUID")]
		//[Verify (MethodToProperty)]
		string BuildUUID { get; }

		// +(NSString *)bundleId;
		[Static]
		[Export ("bundleId")]
		//[Verify (MethodToProperty)]
		string BundleId { get; }

		// +(NSInteger)hasWatch;
		[Static]
		[Export ("hasWatch")]
		//[Verify (MethodToProperty)]
		nint HasWatch { get; }

		// +(NSInteger)installedWatchApp;
		[Static]
		[Export ("installedWatchApp")]
		//[Verify (MethodToProperty)]
		nint InstalledWatchApp { get; }

		// +(NSString *)metrics;
		[Static]
		[Export ("metrics")]
		//[Verify (MethodToProperty)]
		string Metrics { get; }

		// +(NSUInteger)connectionType;
		[Static]
		[Export ("connectionType")]
		//[Verify (MethodToProperty)]
		nuint ConnectionType { get; }

		// +(unsigned long long)freeRAM;
		[Static]
		[Export ("freeRAM")]
		//[Verify (MethodToProperty)]
		ulong FreeRAM { get; }

		// +(unsigned long long)totalRAM;
		[Static]
		[Export ("totalRAM")]
		//[Verify (MethodToProperty)]
		ulong TotalRAM { get; }

		// +(unsigned long long)freeDisk;
		[Static]
		[Export ("freeDisk")]
		//[Verify (MethodToProperty)]
		ulong FreeDisk { get; }

		// +(unsigned long long)totalDisk;
		[Static]
		[Export ("totalDisk")]
		//[Verify (MethodToProperty)]
		ulong TotalDisk { get; }

		// +(NSInteger)batteryLevel;
		[Static]
		[Export ("batteryLevel")]
		//[Verify (MethodToProperty)]
		nint BatteryLevel { get; }

		// +(NSString *)orientation;
		[Static]
		[Export ("orientation")]
		//[Verify (MethodToProperty)]
		string Orientation { get; }

		// +(float)OpenGLESversion;
		[Static]
		[Export ("OpenGLESversion")]
		//[Verify (MethodToProperty)]
		float OpenGLESversion { get; }

		// +(BOOL)isJailbroken;
		[Static]
		[Export ("isJailbroken")]
		//[Verify (MethodToProperty)]
		bool IsJailbroken { get; }

		// +(BOOL)isInBackground;
		[Static]
		[Export ("isInBackground")]
		//[Verify (MethodToProperty)]
		bool IsInBackground { get; }
	}

	// @interface CountlyViewTracking : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyViewTracking
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyViewTracking SharedInstance ();

		// -(void)reportView:(NSString * _Nonnull)viewName;
		[Export ("reportView:")]
		void ReportView (string viewName);

		// -(void)endView;
		[Export ("endView")]
		void EndView ();

		// -(void)startAutoViewTracking;
		[Export ("startAutoViewTracking")]
		void StartAutoViewTracking ();

		// -(void)addExceptionForAutoViewTracking:(Class _Nullable)exceptionViewControllerSubclass;
		[Export ("addExceptionForAutoViewTracking:")]
		void AddExceptionForAutoViewTracking ([NullAllowed] Class exceptionViewControllerSubclass);

		// -(void)removeExceptionForAutoViewTracking:(Class _Nullable)exceptionViewControllerSubclass;
		[Export ("removeExceptionForAutoViewTracking:")]
		void RemoveExceptionForAutoViewTracking ([NullAllowed] Class exceptionViewControllerSubclass);

		// @property (nonatomic) BOOL isAutoViewTrackingEnabled;
		[Export ("isAutoViewTrackingEnabled")]
		bool IsAutoViewTrackingEnabled { get; set; }
	}

	// @interface CountlyViewTracking (UIViewController)
	[Category]
	[BaseType (typeof(UIViewController))]
	interface UIViewController_CountlyViewTracking
	{
		// -(void)Countly_viewDidAppear:(BOOL)animated;
		[Export ("Countly_viewDidAppear:")]
		void Countly_viewDidAppear (bool animated);
	}

	// @interface CountlyStarRating : NSObject
	[BaseType (typeof(NSObject))]
	interface CountlyStarRating
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyStarRating SharedInstance ();

		// -(void)showDialog:(void (^)(NSInteger))completion;
		[Export ("showDialog:")]
		void ShowDialog (Action<nint> completion);

		// -(void)checkForAutoAsk;
		[Export ("checkForAutoAsk")]
		void CheckForAutoAsk ();

		// @property (nonatomic, strong) NSString * message;
		[Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSString * dismissButtonTitle;
		[Export ("dismissButtonTitle", ArgumentSemantic.Strong)]
		string DismissButtonTitle { get; set; }

		// @property (nonatomic) NSUInteger sessionCount;
		[Export ("sessionCount")]
		nuint SessionCount { get; set; }

		// @property (nonatomic) BOOL disableAskingForEachAppVersion;
		[Export ("disableAskingForEachAppVersion")]
		bool DisableAskingForEachAppVersion { get; set; }
	}

	// @interface CountlyCommon : NSObject <WCSessionDelegate>
	[BaseType (typeof(NSObject))]
	interface CountlyCommon : IWCSessionDelegate
	{
		// @property (nonatomic, strong) NSString * ISOCountryCode;
		[Export ("ISOCountryCode", ArgumentSemantic.Strong)]
		string ISOCountryCode { get; set; }

		// @property (nonatomic, strong) NSString * city;
		[Export ("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic, strong) NSString * location;
		[Export ("location", ArgumentSemantic.Strong)]
		string Location { get; set; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CountlyCommon SharedInstance ();

		// -(NSInteger)hourOfDay;
		[Export ("hourOfDay")]
		//[Verify (MethodToProperty)]
		nint HourOfDay { get; }

		// -(NSInteger)dayOfWeek;
		[Export ("dayOfWeek")]
		//[Verify (MethodToProperty)]
		nint DayOfWeek { get; }

		// -(NSInteger)timeZone;
		[Export ("timeZone")]
		//[Verify (MethodToProperty)]
		nint TimeZone { get; }

		// -(long)timeSinceLaunch;
		[Export ("timeSinceLaunch")]
		//[Verify (MethodToProperty)]
		nint TimeSinceLaunch { get; }

		// -(NSTimeInterval)uniqueTimestamp;
		[Export ("uniqueTimestamp")]
		//[Verify (MethodToProperty)]
		double UniqueTimestamp { get; }

		// -(NSString *)optionalParameters;
		[Export ("optionalParameters")]
		//[Verify (MethodToProperty)]
		string OptionalParameters { get; }

		// -(void)activateWatchConnectivity;
		[Export ("activateWatchConnectivity")]
		void ActivateWatchConnectivity ();

		// -(void)transferParentDeviceID;
		[Export ("transferParentDeviceID")]
		void TransferParentDeviceID ();
	}

	// @interface URLEscaped (NSString)
	//[Category]
	//[BaseType (typeof(NSString))]
	//interface NSString_URLEscaped
	//{
	//	// -(NSString *)URLEscaped;
	//	[Export ("URLEscaped")]
	//	//[Verify (MethodToProperty)]
	//	string URLEscaped { get; }

	//	// -(NSString *)SHA1;
	//	[Export ("SHA1")]
	//	//[Verify (MethodToProperty)]
	//	string SHA1 { get; }

	//	// -(NSData *)dataUTF8;
	//	[Export ("dataUTF8")]
	//	//[Verify (MethodToProperty)]
	//	NSData DataUTF8 { get; }
	//}

	// @interface JSONify (NSArray)
	//[Category]
	//[BaseType (typeof(NSArray))]
	//interface NSArray_JSONify
	//{
	//	// -(NSString *)JSONify;
	//	[Export ("JSONify")]
	//	//[Verify (MethodToProperty)]
	//	string JSONify { get; }
	//}

	//// @interface JSONify (NSDictionary)
	//[Category]
	//[BaseType (typeof(NSDictionary))]
	//interface NSDictionary_JSONify
	//{
	//	// -(NSString *)JSONify;
	//	[Export ("JSONify")]
	//	//[Verify (MethodToProperty)]
	//	string JSONify { get; }
	//}

	//// @interface AppendStringUTF8 (NSMutableData)
	//[Category]
	//[BaseType (typeof(NSMutableData))]
	//interface NSMutableData_AppendStringUTF8
	//{
	//	// -(void)appendStringUTF8:(NSString *)string;
	//	[Export ("appendStringUTF8:")]
	//	void AppendStringUTF8 (string @string);
	//}

	//// @interface stringUTF8 (NSData)
	//[Category]
	//[BaseType (typeof(NSData))]
	//interface NSData_stringUTF8
	//{
	//	// -(NSString *)stringUTF8;
	//	[Export ("stringUTF8")]
	//	//[Verify (MethodToProperty)]
	//	string StringUTF8 { get; }
	//}

	// @interface RecordEventWithTimeStamp (Countly)
	[Category]
	[BaseType (typeof(Countly))]
	interface Countly_RecordEventWithTimeStamp
	{
		// -(void)recordEvent:(NSString *)key segmentation:(NSDictionary *)segmentation count:(NSUInteger)count sum:(double)sum duration:(NSTimeInterval)duration timestamp:(NSTimeInterval)timestamp;
		[Export ("recordEvent:segmentation:count:sum:duration:timestamp:")]
		void RecordEvent (string key, NSDictionary segmentation, nuint count, double sum, double duration, double timestamp);
	}
}
