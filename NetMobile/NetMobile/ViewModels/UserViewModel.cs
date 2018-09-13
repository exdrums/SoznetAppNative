using NetMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NetMobile.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        #region Propertiees

        public User User;

        public int Id
        {
            get { return User.Id; }
            set
            {
                if(User.Id != value)
                {
                    User.Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string UserName
        {
            get { return User.UserName; }
            set
            {
                if (User.UserName != value)
                {
                    User.UserName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        public string KnownAs
        {
            get { return User.KnownAs; }
            set
            {
                if (User.KnownAs != value)
                {
                    User.KnownAs = value;
                    OnPropertyChanged("KnownAs");
                }
            }
        }
        public int Age
        {
            get { return User.Age; }
            set
            {
                if (User.Age != value)
                {
                    User.Age = value;
                    OnPropertyChanged("Age");
                }
            }
        }
        public string Gender
        {
            get { return User.Gender; }
            set
            {
                if (User.Gender != value)
                {
                    User.Gender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }
        public DateTime Created
        {
            get { return User.Created; }
            set
            {
                if (User.Created != value)
                {
                    User.Created = value;
                    OnPropertyChanged("Created");
                }
            }
        }
        public DateTime LastActive
        {
            get { return User.LastActive; }
            set
            {
                if (User.LastActive != value)
                {
                    User.LastActive = value;
                    OnPropertyChanged("LastActive");
                }
            }
        }
        public string PhotoUrl
        {
            get { return User.PhotoUrl; }
            set
            {
                if (User.PhotoUrl != value)
                {
                    User.PhotoUrl = value;
                    OnPropertyChanged("PhotoUrl");
                }
            }
        }
        public string City
        {
            get { return User.City; }
            set
            {
                if (User.City != value)
                {
                    User.City = value;
                    OnPropertyChanged("City");
                }
            }
        }
        public string Country
        {
            get { return User.Country; }
            set
            {
                if (User.Country != value)
                {
                    User.Country = value;
                    OnPropertyChanged("Country");
                }
            }
        }
        public string Interests
        {
            get { return User.Interests; }
            set
            {
                if (User.Interests != value)
                {
                    User.Interests = value;
                    OnPropertyChanged("Interests");
                }
            }
        }
        public string Introdiction
        {
            get { return User.Introdiction; }
            set
            {
                if (User.Introdiction != value)
                {
                    User.Introdiction = value;
                    OnPropertyChanged("Introdiction");
                }
            }
        }
        public string LookingFor
        {
            get { return User.LookingFor; }
            set
            {
                if (User.LookingFor != value)
                {
                    User.LookingFor = value;
                    OnPropertyChanged("LookingFor");
                }
            }
        }
        public ObservableCollection<Photo> Photos { get; set; }
        public ObservableCollection<string> Roles { get; set; }

        #endregion

        #region Constructor

        public UserViewModel()
        {
            this.User = new User();
            this.Photos = new ObservableCollection<Photo>(User.Photos);
            this.Roles = new ObservableCollection<string>(User.Roles);
        }

        #endregion

    }
}
