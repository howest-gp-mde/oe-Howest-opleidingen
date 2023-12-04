using FreshMvvm;
using SP.Domain.Services.Api;
using SP.Domain.Services.File;
using SP.Services;
using SP.Services.Mock;
using SP.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // old style
            // MainPage = new NavigationPage(new MainPage());

            FreshIOC.Container.Register(DependencyService.Get<IPushService>());

            // dependencies
            FreshIOC.Container.Register<IStudyProgrammeService, StudyProgrammeApiService>();
            FreshIOC.Container.Register<IApiClient, CustomHttpClient>().AsSingleton();

            // change to FreshMVVM
            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
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
