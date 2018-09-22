using System;
using NetMobile.ViewModels;
using Xamarin.Forms;

namespace NetMobile.Services
{
    // TODO: Implement interface
    public class NavigationService : INavigationService
    {
        #region Properties

        private readonly ISettingsService _settingsService;

        public BaseViewModel PreviousPageViewModel
        {
            get
            {
                var mainPage = Application.Current.MainPage as NavigationPage;
                var viewModel = mainPage.Navigation.NavigationStack[mainPage.Navigation.NavigationStack.Count - 2].BindingContext;
                return viewModel as BaseViewModel;
            }
        }

        #endregion

        #region Constructor

        public NavigationService(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Private Methods



        #endregion
    }
}
