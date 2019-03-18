using System;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using GrowthNative.Core;
using UIKit;
//using MvvmCross.Plugin.Json;

namespace GrowthNative.IOS
{
    public class Setup : MvxIosSetup<App>
    {

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            //regiester plugins and service i.e json plugin
        }
        protected override void InitializeLastChance()
        {
            base.InitializeLastChance();

            //var registry = Mvx.Resolve<IMvxTargetBindingFactoryRegistry>();
            //registry.RegisterFactory(new MvxCustomBindingFactory<UIViewController>("NetworkIndicator", (viewController) => new NetworkIndicatorTargetBinding(viewController)));
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }
    }
}
