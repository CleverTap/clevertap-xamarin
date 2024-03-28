namespace StarterDotNet;
using CleverTapSDK;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
        CleverTap.SetDebugLevel(4);
        CleverTap.AutoIntegrate();

        // create a new window instance based on the screen size
        Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController with a single UILabel
		var vc = new UIViewController ();
		vc.View!.AddSubview(new UILabel(Window!.Frame)
		{
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = "Hello, iOS!",
			AutoresizingMask = UIViewAutoresizing.All,
		});

        Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();

		CallCleverTapMethods();

		return true;
	}

    public static void CallCleverTapMethods()
	{
		// Record Event
        CleverTap.SharedInstance()?.RecordEvent("DotNet Test Event");

		// Profile Push
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
}

