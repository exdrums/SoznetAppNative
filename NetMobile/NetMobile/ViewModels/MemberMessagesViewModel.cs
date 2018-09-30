using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NetMobile.ViewModels.Base;

namespace NetMobile.ViewModels
{
    public class MemberMessagesViewModel : BaseViewModel
    {
        #region Properties

        public ObservableCollection<MessageViewModel> Messages { get; set; }

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

        MessageViewModel newMessage;
        public MessageViewModel NewMessage
        {
            get { return newMessage; }
            set
            {
                if (newMessage != value)
                {
                    newMessage = value;
                    OnPropertyChanged("NewMessage");
                }
            }
        }

        #endregion

        #region Constructor

        public MemberMessagesViewModel()
        {
            Messages = new ObservableCollection<MessageViewModel>();
            NewMessage = new MessageViewModel();
        }

        #endregion
    }
}
