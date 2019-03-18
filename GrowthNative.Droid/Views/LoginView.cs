
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using GrowthNative.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GrowthNative.Droid.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "LoginView")]

    public class LoginView : MvxAppCompatActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

        }
        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

        }

    }
}
