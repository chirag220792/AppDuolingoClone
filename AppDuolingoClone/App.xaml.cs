using System;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppDuolingoClone.ViewModels;
using AppDuolingoClone.Views;

namespace AppDuolingoClone
{
    public partial class App : PrismApplication
    {
        public App() : base(null) { }
        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var mainPage = $"{nameof(NavigationPage)}/{nameof(MainPage)}";

            await NavigationService.NavigateAsync(mainPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<LessonsView, LessonsViewModel>();
            containerRegistry.RegisterForNavigation<TrainingView, TrainingViewModel>();
            containerRegistry.RegisterForNavigation<ProfileView, ProfileViewModel>();
            containerRegistry.RegisterForNavigation<RankingView, RankingViewModel>();
            containerRegistry.RegisterForNavigation<StoreView, StoreViewModel>();
        }
        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

     
    }
}
