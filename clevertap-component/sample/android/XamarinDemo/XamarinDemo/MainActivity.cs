using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget; 
using Com.Clevertap.Android.Sdk;
using Android.Gms.Common;
using System.Collections.Generic;
using Java.Util;
using Com.Clevertap.Android.Sdk.Displayunits.Model;
using Android.Util;
using Firebase.Iid;

namespace XamarinDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, ICTInboxListener, ICTExperimentsListener, Com.Clevertap.Android.Sdk.Displayunits.IDisplayUnitListener
    {
        private CleverTapAPI cleverTapAPI;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            CleverTapAPI.SetDebugLevel(CleverTapAPI.LogLevel.Debug);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            //Intialise CT SDK
            cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);
            String token = FirebaseInstanceId.Instance.Token;


            cleverTapAPI.PushFcmRegistrationId(token, true);
            Log.Debug("TOken", "token Sent" + token);
            // Add custom implementation, as needed.
            //Push Event
            cleverTapAPI.PushEvent("Product View Via Xamarin");
            ICTInboxListener cTNotificationInboxListener = cleverTapAPI.CTNotificationInboxListener;
            cleverTapAPI.SetDisplayUnitListener(this);
            ICTExperimentsListener cTExperimentsListener = cleverTapAPI.CTExperimentsListener;
            //Initialize the inbox and wait for callbacks on overridden methods
            cleverTapAPI.InitializeInbox();
            //Push Profile

            IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

            profileData.Add("Name", "Atul");    // String
            profileData.Add("Identity", 97839492);      // String or number
            profileData.Add("Email", "kumar@gmail.com"); // Email address of the user
            profileData.Add("Phone", "7012801820919");   // Phone (with the country code, starting with +)
            profileData.Add("Gender", "M");             // Can be either M or F
            profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util


            cleverTapAPI.PushProfile(profileData);


            //onUserLogin Profile

            IDictionary<string, Java.Lang.Object> profile = new Dictionary<string, Java.Lang.Object>();

            profile.Add("Name", "Atul");    // String
            profile.Add("Identity", 97839492);      // String or number
            profile.Add("Email", "kumar@gmail.com"); // Email address of the user
            profile.Add("Phone", "7012801820919");   // Phone (with the country code, starting with +)
            profile.Add("Gender", "M");               // Can be either M or F
            profile.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util


            cleverTapAPI.OnUserLogin(profile);

            //Create Channel
            CleverTapAPI.CreateNotificationChannel(Android.App.Application.Context, "1", "dkchannel", "dkchannel", 3, true);

            //Create Channel Group
            CleverTapAPI.CreateNotificationChannelGroup(Android.App.Application.Context, "1", "dkchannel");


            //Create Notification
            Bundle Extras = new Bundle();
            CleverTapAPI.CreateNotification(Android.App.Application.Context, Extras);

            //Push Impression
            Bundle SampleExtras = new Bundle();
            cleverTapAPI.PushNotificationViewedEvent(SampleExtras);

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
            cleverTapAPI.ShowAppInbox();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void InboxDidInitialize()
        {
            Toast.MakeText(Android.App.Application.Context, "Inbox Initialized", ToastLength.Short).Show();
            Log.Debug("CLEVERTAP", "Inbox Initialized");
            //throw new NotImplementedException();
        }

        public void InboxMessagesDidUpdate()
        {
            Toast.MakeText(Android.App.Application.Context, "Inbox Updated", ToastLength.Short).Show();
            Log.Debug("CLEVERTAP", "Inbox UPdated");
            //throw new NotImplementedException();
        }

        public void CTExperimentsUpdated()
        {
            Toast.MakeText(Android.App.Application.Context, "Experiments Updated", ToastLength.Short).Show();
            Log.Debug("CLEVERTAP", "Experiments Updated");
            //throw new NotImplementedException();
        }

        public void OnDisplayUnitsLoaded(IList<CleverTapDisplayUnit> p0)
        {
            Toast.MakeText(Android.App.Application.Context, "Display Units Loaded", ToastLength.Short).Show();
            Log.Debug("CLEVERTAP", "Display Units Loaded");
            //throw new NotImplementedException();
        }
    }
}

