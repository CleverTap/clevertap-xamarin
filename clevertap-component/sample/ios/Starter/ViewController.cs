


using Foundation;
using System;
using UIKit;
using CleverTapSDK;
using System.Collections.Generic;
using System.Collections;

namespace Starter
{
    public partial class ViewController : UIViewController
    {
        //public string DisplayUnitID { get; set; }

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // Set Native Display Delegate
            CleverTapDisplayUnitDelegate nativeDisplayDelegate = new CleverTapDisplayUnitDelegate();
            nativeDisplayDelegate = new ViewControllerNativeDisplayDelegate();
            CleverTap.SharedInstance().SetDisplayUnitDelegate(nativeDisplayDelegate);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton1713_TouchUpInside(UIButton sender)
        {
            CleverTap.SharedInstance()?.RecordEvent("Xamarin Test Event");
            CleverTap.SharedInstance()?.RegisterArrayOfBoolVariableWithName("Bool name");

        }

        partial void UIButton1714_TouchUpInside(UIButton sender)
        {
            var profileData = new NSDictionary(
                new NSString("Name"), new NSString("Aditi Agrawal"),
                new NSString("Identity"), new NSString("303030"),
                new NSString("Email"), new NSString("aditi@aditi.com"),
                new NSString("Phone"), new NSString("14155551234"),
                new NSString("Gender"), new NSString("F"),
                new NSString("DOB"), new NSDate()
            );
            CleverTap.SharedInstance()?.ProfilePush(profileData);
        }

        partial void UIButton1715_TouchUpInside(UIButton sender)
        {
            var chargedDetails = new NSDictionary(
                new NSString("Total Amount"), new NSNumber(100)
            );

            var item1 = new NSDictionary(
               new NSString("Product Name"), new NSString("Hacking with Swift"),
               new NSString("ProductID"), new NSNumber(556),
               new NSString("Price"), new NSNumber(1000)
            );
            var item2 = new NSDictionary(
               new NSString("Product Name"), new NSString("Programming in Objective C"),
               new NSString("ProductID"), new NSNumber(956),
               new NSString("Price"), new NSNumber(700)
            );

            var items = new[] { item1, item2 };
            CleverTap.SharedInstance()?.RecordChargedEventWithDetails(chargedDetails, items);
        }

        partial void UIButton1716_TouchUpInside(UIButton sender)
        {
            var style = new CleverTapInboxStyleConfig();
            var tags = new[] {
                new NSString("Tag1"),
                new NSString("Tag2")
            };
            style.MessageTags = tags;
            style.Title = "App Inbox";
            style.BackgroundColor = UIColor.LightGray;

            CleverTap.SharedInstance()?.InitializeInboxWithCallback(_ =>
            {
                Console.WriteLine("App Inbox Initialised.");
                CleverTapInboxViewController inboxVC = CleverTap.SharedInstance().NewInboxViewControllerWithConfig(style, null);
                var navController = new UINavigationController(inboxVC);

                if (inboxVC == null)
                {
                    Console.WriteLine("CleverTap Inbox View Controller is null.");
                }
                else
                {
                    NavigationController.PresentModalViewController(navController, true);
                    Console.WriteLine("CleverTap Inbox read count " + CleverTap.SharedInstance().InboxMessageCount());
                    Console.WriteLine("CleverTap Inbox unread count " + CleverTap.SharedInstance().InboxMessageUnreadCount());

                }
            });
        }

        partial void UIButton1717_TouchUpInside(UIButton sender)
        {
            Console.WriteLine("Recording Notification Viewed/Clicked for Native Display for ID:" + (string)ViewControllerNativeDisplayDelegate.DisplayUnitList[0]);
            CleverTap.SharedInstance()?.RecordDisplayUnitClickedEventForID((string)ViewControllerNativeDisplayDelegate.DisplayUnitList[0]);
            CleverTap.SharedInstance()?.RecordDisplayUnitViewedEventForID((string)ViewControllerNativeDisplayDelegate.DisplayUnitList[0]);
        }
    }

    public class ViewControllerNativeDisplayDelegate : CleverTapDisplayUnitDelegate
    {
        public static ArrayList DisplayUnitList { get; private set; }

        public override void DisplayUnitsUpdated(CleverTapDisplayUnit[] displayUnits)
        {
            Console.WriteLine("Recieved Native Display Units");

            DisplayUnitList = new ArrayList();

            for (int i = 0; i < displayUnits.Length; i++)
            {
                CleverTapDisplayUnit displayUnit = displayUnits[i];
                Console.WriteLine("Display Unit Display Unit Json: " + displayUnit.Json);
                Console.WriteLine("Display Unit Custom Extras: " + displayUnit.CustomExtras);
                Console.WriteLine("Display Unit Id: " + displayUnit.UnitID);

                DisplayUnitList.Add(displayUnit.UnitID);
            }
        }
    }
}

