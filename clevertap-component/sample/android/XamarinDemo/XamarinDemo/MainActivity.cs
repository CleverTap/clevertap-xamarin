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

namespace XamarinDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            //Intialise CT SDK
            CleverTapAPI cleverTapAPI = CleverTapAPI.GetDefaultInstance(Android.App.Application.Context);

            CleverTapAPI.SetDebugLevel(CleverTapAPI.LogLevel.Debug);

            //Push Event
            cleverTapAPI.PushEvent("Product View Via Xamarin");
            
            //Push Profile

            IDictionary<string, Java.Lang.Object> profileData = new Dictionary<string, Java.Lang.Object>();

            profileData.Add("Name", "Jack Montana");    // String
            profileData.Add("Identity", 61026032);      // String or number
            profileData.Add("Email", "jack@gmail.com"); // Email address of the user
            profileData.Add("Phone", "+14155551234");   // Phone (with the country code, starting with +)
            profileData.Add("Gender", "M");             // Can be either M or F
            profileData.Add("DOB", new Date());         // Date of Birth. Set the Date object to the appropriate value first - requires java.util


            cleverTapAPI.PushProfile(profileData);


            //onUserLogin Profile

            IDictionary<string, Java.Lang.Object> profile = new Dictionary<string, Java.Lang.Object>();

            profile.Add("Name", "Jack Montana");    // String
            profile.Add("Identity", 61026032);      // String or number
            profile.Add("Email", "jack@gmail.com"); // Email address of the user
            profile.Add("Phone", "+14155551234");   // Phone (with the country code, starting with +)
            profile.Add("Gender", "M");             // Can be either M or F
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
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool IsPlayServicesAvailable()
        {
            int resultCode = GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(this);
            if (resultCode != ConnectionResult.Success)
            {
                if (GoogleApiAvailability.Instance.IsUserResolvableError(resultCode))
                {
                    //tester
                }
                else
                {
                    Finish();
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

