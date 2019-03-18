using System;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.Commands;
using MvvmCross.IoC;
using GrowthNative.Core;


namespace GrowthNative.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;


            _navigationService.Navigate<LoginViewModel>();
        }

        public override Task Initialize()
        {
            return base.Initialize();

        }

        public IMvxAsyncCommand ShowLoginCommand { get; private set; }
    }
}
