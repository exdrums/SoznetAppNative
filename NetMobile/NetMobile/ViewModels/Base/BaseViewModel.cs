using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using NetMobile.Models;
using NetMobile.Services;
using System.Threading.Tasks;

namespace NetMobile.ViewModels.Base
{
    public class BaseViewModel : ExtendedBindableObject
    {
        // public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>() ?? new MockDataStore();

        /// <summary>
        /// Navigation is logik 
        /// </summary>
        protected readonly INavigationService NavigationService;

        protected readonly IDialogService DialogService;


        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set 
            {
                isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        //string title = string.Empty;
        //public string Title
        //{
        //    get { return title; }
        //    set { SetProperty(ref title, value); }
        //}

        //protected bool SetProperty<T>(ref T backingStore, T value,
        //    [CallerMemberName]string propertyName = "",
        //    Action onChanged = null)
        //{
        //    if (EqualityComparer<T>.Default.Equals(backingStore, value))
        //        return false;

        //    backingStore = value;
        //    onChanged?.Invoke();
        //    OnPropertyChanged(propertyName);
        //    return true;
        //}
        public BaseViewModel()
        {
            DialogService = ViewModelInjector.Resolve<IDialogService>();
            NavigationService = ViewModelInjector.Resolve<INavigationService>();

            // var settingsService = ViewModelInjector.Resolve<ISettingsService>();

            // GlobalSetting.Instance.BaseIdentityEndpoint = settingsService.IdentityEndpointBase;
            // GlobalSetting.Instance.BaseGatewayShoppingEndpoint = settingsService.GatewayShoppingEndpointBase;
            // GlobalSetting.Instance.BaseGatewayMarketingEndpoint = settingsService.GatewayMarketingEndpointBase;
        }

        /// <summary>
        /// To override in each VM if data is need by navigation.
        /// </summary>
        /// <param name="navigationData">Data parameter.</param>
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }

        //#region INotifyPropertyChanged
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    var changed = PropertyChanged;
        //    if (changed == null)
        //        return;

        //    changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //#endregion
    }
}
