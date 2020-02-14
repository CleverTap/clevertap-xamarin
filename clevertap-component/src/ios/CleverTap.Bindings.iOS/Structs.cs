using ObjCRuntime;

namespace CleverTapSDK
{
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

    public enum KnownField : ulong
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

    public enum CleverTapLogLevel
    {
        Off = -1,
        Info = 0,
        Debug = 1
    }
}