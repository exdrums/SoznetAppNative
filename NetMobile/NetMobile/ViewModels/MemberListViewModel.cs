using NetMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NetMobile.ViewModels
{
    public class MemberListViewModel : BaseViewModel
    {

        #region Properties

        /// <summary>
        /// Collection of users for this viewmodel
        /// </summary>
        public ObservableCollection<UserViewModel> Users { get; set; }


        /// <summary>
        /// Pagination object that will be from server recieved
        /// </summary>
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Selected user alles klar
        /// </summary>
        private UserViewModel selectedUser;
        public UserViewModel SelectedUser
        {
            get { return selectedUser; }
            set
            {
                if (selectedUser != value)
                {
                    selectedUser = value;
                    OnPropertyChanged("SelectedUser");
                    //Navigation.PushAsync(new UserPage(tempUser));
                }
            }
        }

        /// <summary>
        /// Navigation is logik 
        /// </summary>
        public INavigation Navigation { get; set; }

        #endregion

        #region Commands

        public ICommand LoadUsersCommand { get; protected set; }
        private async Task ExecuteLoadUsers()
        {

        }



        #endregion

        #region Constructor

        public MemberListViewModel()
        {
            Users = new ObservableCollection<UserViewModel>(); // to load 

            // Commands...

        }

        #endregion

        #region Methods



        #endregion

    }
}
