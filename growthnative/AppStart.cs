using System;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using System.Threading.Tasks;
using GrowthNative.Core.ViewModels;

namespace GrowthNative.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService navigationService) : base(app, navigationService)
        {

        }
        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<MainViewModel>();
        }
    }
}
