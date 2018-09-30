using System.Threading.Tasks;
using NetMobile.ViewModels.Base;

namespace NetMobile.Services
{
    public interface INavigationService
    {
        BaseViewModel PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<T>() where T : BaseViewModel;

        Task NavigateToAsync<T>(object parameter) where T : BaseViewModel;

        Task RemoveLastFromBackStackAsync();

        Task RemoveBackStackAsync();
    }
}
