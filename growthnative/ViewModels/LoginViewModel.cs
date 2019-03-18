using System;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.IoC;
using GrowthNative.Core;
using System.Threading.Tasks;

namespace GrowthNative.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        IMvxNavigationService _navigationService;

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            OnLoginSelected = new MvxCommand(ShowAuthoPage);
        }

        //dive into icommand utilization in models


        //Mvvm Commands
        public ICommand OnLoginSelected;

        public async void ShowAuthoPage()
        {
            var success = await _navigationService.Navigate<AuthoViewModel>();

        }
    }
}
