using System;
using TinyIoC;
using Xamarin.Forms;
using NetMobile.Services;
using System.Reflection;
using System.Globalization;

namespace NetMobile.ViewModels
{
    public static class ViewModelInjector
    {
        #region Properties

        private static TinyIoCContainer _container;

        public static readonly BindableProperty AutoWireViewModelProperty =
            BindableProperty.CreateAttached(
                "AutoWireViewModel",
                typeof(bool),
                typeof(ViewModelInjector),
                default(bool),
                propertyChanged: OnAutoWireViewModelChanged);


        #endregion

        #region Constructor

        static ViewModelInjector()
        {
            _container = new TinyIoCContainer();

            // View models - by default, TinyIoC will register concrete classes as multi-instance.
            _container.Register<LoginViewModel>();
            // ...

            // Services - by default, TinyIoC will register interface registrations as singletons.
            _container.Register<ISettingsService, SettingsService>();
            _container.Register<INavigationService, NavigationService>();
            // ...
        }

        #endregion

        #region Methods

        // ???
        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(ViewModelInjector.AutoWireViewModelProperty);
        }

        // ???
        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(ViewModelInjector.AutoWireViewModelProperty, value);
        }

        public static void RegisterSingleton<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            _container.Register<TInterface, T>().AsSingleton();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as Element;
            if (view == null)
            {
                return;
            }

            var viewType = view.GetType();
            var viewName = viewType.FullName.Replace(".Views.", ".ViewModels.");
            var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
            var viewModelName = string.Format(CultureInfo.InvariantCulture, "{0}Model, {1}", viewName, viewAssemblyName);

            var viewModelType = Type.GetType(viewModelName);
            if (viewModelType == null)
            {
                return;
            }
            var viewModel = _container.Resolve(viewModelType);
            view.BindingContext = viewModel;
        }

        #endregion
    }
}
