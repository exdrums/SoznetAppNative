using System;
using System.Collections.Generic;
using System.Text;
using NetMobile.ViewModels.Base;

namespace NetMobile.ViewModels
{
    public class MemberDetailViewModel : BaseViewModel
    {
        #region Properties

        UserViewModel user;
        public UserViewModel User
        {
            get { return user; }
            set
            {
                if (user != value)
                {
                    user = value;
                    OnPropertyChanged("User");
                }
            }
        }

        #endregion

        #region Constructor

        public MemberDetailViewModel(UserViewModel user)
        {
            User = user;
        }

        #endregion

    }
}
