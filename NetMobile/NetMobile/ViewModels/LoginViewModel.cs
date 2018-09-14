using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NetMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Properties 

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        #endregion

        #region Commands 

        public ICommand LoginCommand { get; protected set; }
        private async Task ExecuteLogin()
        {

        }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await ExecuteLogin());
        }

        #endregion
    }
}
