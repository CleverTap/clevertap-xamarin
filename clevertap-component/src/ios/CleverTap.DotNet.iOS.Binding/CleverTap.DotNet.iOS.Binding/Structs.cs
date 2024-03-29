using ObjCRuntime;

namespace CleverTapSDK
{
    public enum CleverTapLogLevel
    {
        Off = -1,
        Info = 0,
        Debug = 1
    }

    public enum CleverTapChannel
    {
        PushNotification = 0,
        AppInbox = 1,
        InAppNotification = 2
    }

    public enum CTSignedCallEvent
    {
        OutgoingEvent = 0,
        IncomingEvent,
        EndEvent
    }

    [Native]
    public enum CTInAppType : ulong
    {
        Unknown,
        Html,
        Interstitial,
        HalfInterstitial,
        Cover,
        Header,
        Footer,
        Alert,
        InterstitialImage,
        HalfInterstitialImage,
        CoverImage
    }

    public enum KnownField : uint
    {
        Name = 100,
        Email,
        Education,
        Married,
        Dob,
        Birthday,
        Employed,
        Gender,
        Phone,
        Age,
        Unknown
    }

    public enum CTValidatorContext
    {
        Event,
        Profile,
        Other
    }
}
