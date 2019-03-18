using Foundation;
using MvvmCross;
using MvvmCross.Platforms.Ios.Core;
using GrowthNative.Core;
using UIKit;


namespace GrowthNative.IOS
{

    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate< Setup, App>
    {

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            // here is where your custom code should be placed

            return result;


        }
    }
}