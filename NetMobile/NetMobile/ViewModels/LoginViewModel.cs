using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using NetMobile.ViewModels.Base;
using NetMobile.Validations;

namespace NetMobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Properties 

        private ValidatableObject<string> username;
        public ValidatableObject<string> Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    RaisePropertyChanged(() => Username);
                }
            }
        }

        private ValidatableObject<string> password;
        public ValidatableObject<string> Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    RaisePropertyChanged(() => Password);
                }
            }
        }

        #endregion

        #region Commands 

        public ICommand LoginCommand => new Command(async () => await ExecuteLogin());
        public ICommand ValidateUserNameCommand => new Command(() => ValidateUserName());
        public ICommand ValidatePasswordCommand => new Command(() => ValidatePassword());

        #endregion

        #region Constructor

        public LoginViewModel()
        {

        }

        #endregion

        #region Private methods

        private async Task ExecuteLogin()
        {

        }

        /// <summary>
        /// Validate this instance.
        /// </summary>
        private bool Validate()
        {
            bool isValidUser = ValidateUserName();
            bool isValidPassword = ValidatePassword();

            return isValidUser && isValidPassword;
        }

        private bool ValidateUserName()
        {
            return username.Validate();
        }

        private bool ValidatePassword()
        {
            return password.Validate();
        }

        /// <summary>
        /// Adds the validation rules to the Validations collection of each ValidatableObject,
        /// specifying ValidationMessage.
        /// </summary>
        private void AddValidations()
        {
            username.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A username is required." });
            password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A password is required." });
        }

        #endregion
    }
}
