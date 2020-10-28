using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Clevertap.Android.Sdk;
using System.Collections.Generic;
using Java.Util;
using Com.Clevertap.Android.Sdk.Displayunits.Model;
using Android.Util;
using Firebase.Iid;
using Google.Android.Material.Snackbar;
using Google.Android.Material.FloatingActionButton;
using Android.Gms.Extensions;
using Java.Lang;
using Com.Clevertap.Android.Sdk.Displayunits;
using Com.Clevertap.Android.Sdk.Product_config;
using AndroidX.AppCompat.App;

namespace XamarinDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, ICTInboxListener, ICTExperimentsListener, IDisplayUnitListener, ICTFeatureFlagsListener, ICTProductConfigListener, IInAppNotificationButtonListener, IInboxMessageButtonListener

    {
        private CleverTapAPI cleverTapAPI;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            init();

            initClevertap();

            userLoginPushProfile();

            sendEvents();

            notification();

            inapp();

            inbox();

            dynamicVariables();

            displayUnit();

            featureFlag();

            productConfig();

        }

        // Init Views, click listeners etc.
        private void init()
        {
            SetContentView(Resource.Layout.activity_main);

            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
            showInbox();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        //*****************           CLEVERTAP METHODS   ****************************

        // Init CleverTap
        private void initClevertap()
        {
            CleverTapAPI.SetDebugLevel(CleverTapAPI.LogLevel.Debug);
            cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
        }

        // PushProfile onUserLogin to Clevertap
        private void userLoginPushProfile()
        {
            //Push Profile

            IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

            profileData.Add("Name", "user1");    // String
            profileData.Add("Identity", 97839492);      // String or number
            profileData.Add("Email", "user1@gmail.com"); // Email address of the user
            profileData.Add("Phone", "7012801820919");   // Phone (with the country code, starting with +)
            profileData.Add("Gender", "M");             // Can be either M or F
            profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util


            cleverTapAPI.PushProfile(profileData);


            //onUserLogin Profile

            IDictionary<string, Java.Lang.Object> profile = new Dictionary<string, Java.Lang.Object>();

            profile.Add("Name", "user2");    // String
            profile.Add("Identity", 321323112);      // String or number
            profile.Add("Email", "user2@gmail.com"); // Email address of the user
            profile.Add("Phone", "1212");   // Phone (with the country code, starting with +)
            profile.Add("Gender", "M");               // Can be either M or F
            profile.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util

            cleverTapAPI.OnUserLogin(profile);
        }

        // Send Events to CleverTap
        private void sendEvents()
        {
            // Add custom implementation, as needed.
            //Push Event
            cleverTapAPI.PushEvent("Product View Via Xamarin");

            //Record Charged
            IDictionary<string, Java.Lang.Object> chargedDetails = new Dictionary<string, Java.Lang.Object>();
            chargedDetails.Add("Total Amount", 400);

            IDictionary<string, Java.Lang.Object> item1 = new Dictionary<string, Java.Lang.Object>();
            item1.Add("Product Name", "Harry Potter");
            item1.Add("ProductID", "4756");
            item1.Add("Price", 300);

            IDictionary<string, Java.Lang.Object> item2 = new Dictionary<string, Java.Lang.Object>();
            item2.Add("Product Name", "Harry Potter 2");
            item2.Add("ProductID", "4776");
            item2.Add("Price", 100);

            List<IDictionary<string, Java.Lang.Object>> items = new List<IDictionary<string, Java.Lang.Object>>();
            items.Add(item1);
            items.Add(item2);

            cleverTapAPI.PushChargedEvent(chargedDetails, items);
        }

        // Init Notification Configuration
        private void notification()
        {
            //Create Channel

            //CleverTapAPI.CreateNotificationChannel(Android.App.Application.Context, "YourChannelId", "Your Channel Name", "Your Channel Description", 5, true);
            CleverTapAPI.CreateNotificationChannel(Android.App.Application.Context, "BRTesting", "BRTesting", "BRTesting", 5, true);
            //Create Channel Group
            CleverTapAPI.CreateNotificationChannelGroup(Android.App.Application.Context, "YourGroupId", "Your Group Name");

            PushTokenAsync();
        }

        // Sending FCM token to Clevertap
        private async System.Threading.Tasks.Task PushTokenAsync()
        {
            var instanceIdResult = await FirebaseInstanceId.Instance.GetInstanceId().AsAsync<IInstanceIdResult>();
            string token = instanceIdResult.Token;

            cleverTapAPI.PushFcmRegistrationId(token, true);
            Log.Debug("TOken", "token Sent" + token);
        }

        //init Inapp
        private void inapp()
        {
            cleverTapAPI.SetInAppNotificationButtonListener(this);
        }

        // Init Inbox
        private void inbox()
        {
            //Initialize the inbox and wait for callbacks on overridden methods
            cleverTapAPI.CTNotificationInboxListener = this;
            cleverTapAPI.SetInboxMessageButtonListener(this);
            cleverTapAPI.InitializeInbox();
        }

        // Init Display Units
        private void displayUnit()
        {
            cleverTapAPI.SetDisplayUnitListener(this);
        }

        //show Inbox Screen
        private void showInbox()
        {
            IList<string> tabs = new List<string>();
            tabs.Add("Promotions");
            tabs.Add("Offers");
            tabs.Add("Others");//We support upto 2 tabs only. Additional tabs will be ignored

            CTInboxStyleConfig styleConfig = new CTInboxStyleConfig();
            styleConfig.Tabs = tabs;//Do not use this if you don't want to use tabs
            styleConfig.TabBackgroundColor = "#FF0000";//provide Hex code in string ONLY
            styleConfig.SelectedTabIndicatorColor = "#0000FF";
            styleConfig.SelectedTabColor = "#000000";
            styleConfig.UnselectedTabColor = "#FFFFFF";
            styleConfig.BackButtonColor = "#FF0000";
            styleConfig.NavBarTitleColor = "#FF0000";
            styleConfig.NavBarTitle = "MY INBOX";
            styleConfig.NavBarColor = "#FFFFFF";
            styleConfig.InboxBackgroundColor = "#00FF00";

            cleverTapAPI.ShowAppInbox(styleConfig); //Opens activity with Tabs
            //OR
            //cleverTapAPI.ShowAppInbox();//Opens Activity with default style config
        }

        // Dynamic Variables Init
        private void dynamicVariables()
        {
            cleverTapAPI.CTExperimentsListener = this;
        }

        // Init Feature Flag
        private void featureFlag()
        {
            cleverTapAPI.SetCTFeatureFlagsListener(this);
        }

        // Init Product Config
        private void productConfig()
        {
            cleverTapAPI.SetCTProductConfigListener(this);
            cleverTapAPI.ProductConfig().Fetch(0);
        }

        //******************           INAPP CALLBACKS       *******************

        // Called when Inapp Button having payload is clicked
        public void OnInAppButtonClick(IDictionary<string, string> p0)
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "InApp Button Clicked", ToastLength.Short).Show();
                Log.Debug("CLEVERTAP", "InApp Button Clicked");
            });
        }

        //******************           INBOX CALLBACKS       *******************

        // Called when Inbox is Initialized
        public void InboxDidInitialize()
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "Inbox Initialized", ToastLength.Short).Show();
                Log.Debug("CLEVERTAP", "Inbox Initialized");
            });
        }

        // Called when a new message is updated in Inbox
        public void InboxMessagesDidUpdate()
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "Inbox Updated", ToastLength.Short).Show();
                Log.Debug("CLEVERTAP", "Inbox UPdated");
            });
        }

        // Called when InBox Button having payload is clicked
        public void OnInboxButtonClick(IDictionary<string, string> p0)
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "Inbox Button Clicked", ToastLength.Short).Show();
                Log.Debug("CLEVERTAP", "Inbox Button Clicked");
            });
        }

        //******************           DYNAMIC VARIABLE CALLBACKS       *******************

        // Called when latest dynamic variables are loaded
        public void CTExperimentsUpdated()
        {
            RunOnUiThread(() =>
            {
                Integer intval = cleverTapAPI.GetIntegerVariable("testint", new Java.Lang.Integer(1));
                Java.Lang.Boolean boolVal = cleverTapAPI.GetBooleanVariable("testbool", new Java.Lang.Boolean(false));
                Toast.MakeText(Android.App.Application.Context, "Experiments Updated[testInt-" + intval + " , Bool-" + boolVal + "]", ToastLength.Long).Show();
                Log.Debug("CLEVERTAP", "Experiments Updated");
            });
        }

        //******************           DISPLAY UNIT CALLBACKS          *******************

        // Called when display units are loaded
        public void OnDisplayUnitsLoaded(IList<CleverTapDisplayUnit> p0)
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "Display Units Loaded", ToastLength.Short).Show();
                Log.Debug("CLEVERTAP", "Display Units Loaded");

            });
        }

        //******************           FEATURE FLAG CALLBACKS          *******************


        // Called when feature flags fetch has completed
        public void FeatureFlagsUpdated()
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "FF[Key-AppInbox, Value-" + cleverTapAPI.FeatureFlag().Get("AppInbox", false) + " ]", ToastLength.Long).Show();
                Log.Debug("CLEVERTAP", "FeatureFlagsUpdated");
            });
        }

        //******************           PRODUCT CONFIG CALLBACKS          *******************

        // Called when Product Config is initialized
        public void OnInit()
        {
        }

        // Called when Product Config fetch has completed
        public void OnFetched()
        {
            cleverTapAPI.ProductConfig().Activate();
        }

        // Called when Product Config activation has completed
        public void OnActivated()
        {
            RunOnUiThread(() =>
            {
                Toast.MakeText(Android.App.Application.Context, "Product Config[Key-ContactUs, Value-" + cleverTapAPI.ProductConfig().GetString("ContactUs") + " ]", ToastLength.Long).Show();
                Log.Debug("CLEVERTAP", "FeatureFlagsUpdated");
            });
        }

    }
}