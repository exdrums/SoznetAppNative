using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NetMobile.Views;
using System.Threading.Tasks;
using NetMobile.ViewModels;
using NetMobile.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NetMobile
{
    public partial class App : Application
    {
        ISettingsService _settingsService;


        public App()
        {
            InitializeComponent();

            InitApp();
            if (Device.RuntimePlatform == Device.UWP)
            {
                InitNavigation();
            }
        }

        private void InitApp()
        {
            _settingsService = ViewModelInjector.Resolve<ISettingsService>();
            //if (!_settingsService.UseMocks)
                //ViewModelLocator.UpdateDependencies(_settingsService.UseMocks);
        }

        /// <summary>
        /// Creates new NavigatonService object in DI container, and returns a reference to it,
        /// before invoking InitializeAsync()
        /// </summary>
        private Task InitNavigation()
        {
            var navigationService = ViewModelInjector.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
