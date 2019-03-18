using System;
using MvvmCross.ViewModels;


namespace GrowthNative.Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        protected BaseViewModel()
        {
        }
       // public string this[string index] => Strings.ResourceManager.GetString(index);
    }
    public abstract class BaseViewModel<TParam, TResult> : MvxViewModel
        where TParam : class
        where TResult : class
    {
        protected BaseViewModel()
        {

        }
        // public string this[string index] => Strings.ResourceManager.GetString(index);
    }
}
