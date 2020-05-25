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
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton1713_TouchUpInside(UIButton sender)
        {
            CleverTap.SharedInstance()?.RecordEvent("Xamarin Test");
            CleverTap.SharedInstance()?.RecordEvent("Alert ios");
            CleverTap.SharedInstance()?.RecordEvent("Tablet only Header");
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
            style.BackgroundColor = UIColor.LightGray;

            CleverTap.SharedInstance()?.InitializeInboxWithCallback(_ =>
            {
                Console.WriteLine("App Inbox Initialised.");
                CleverTapInboxViewController inboxVC = CleverTap.SharedInstance().NewInboxViewControllerWithConfig(null, null);
                var navController = new UINavigationController(inboxVC);

                if (inboxVC == null)
                {
                    Console.WriteLine("CleverTap Inbox View Controller is null.");

                }
                else
                {
                    NavigationController.PresentModalViewController(navController, true);
                }
            });
        }
    }
}

