using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using NetMobile.ViewModels.Base;

namespace NetMobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        // verbinden alle UserViewModel properties mit View, und davon erstellen einen user, und senden in command nach server

        #region Properties

        UserViewModel userToRegister;
        public UserViewModel UserToRegister
        {
            get { return userToRegister; }
            set
            {
                if (userToRegister != value)
                {
                    userToRegister = value;
                    OnPropertyChanged("UserToRegister");
                }
            }
        }

        #endregion

        #region Commands 

        public ICommand RegisterCommand { get; protected set; }
        private async Task ExecuteRegister()
        {

        }

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            UserToRegister = new UserViewModel();
            RegisterCommand = new Command(async () => await ExecuteRegister());
        }

        #endregion


    }
}
