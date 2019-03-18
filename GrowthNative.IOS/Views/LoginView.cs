using Foundation;
using System;
using MvvmCross.Core;
using MvvmCross.Binding.BindingContext;
using GrowthNative.Core.ViewModels;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace GrowthNative.IOS.Views
{
    [MvxRootPresentation]
    public partial class LoginView : MvxViewController<LoginViewModel>
    {
        public LoginView () : base(nameof(LoginView), null)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<LoginView, LoginViewModel>();
           // set.Bind(LoginButton).To(vm => vm.OnLoginSelected);
            set.Apply();
        }
    }
}