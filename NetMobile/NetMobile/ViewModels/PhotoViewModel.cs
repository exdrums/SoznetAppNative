using NetMobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetMobile.ViewModels
{
    public class PhotoViewModel : BaseViewModel
    {
        #region Properties

        public Photo Photo;

        public int Id
        {
            get { return Photo.Id; }
            set
            {
                if (Photo.Id != value)
                {
                    Photo.Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Url
        {
            get { return Photo.Url; }
            set
            {
                if (Photo.Url != value)
                {
                    Photo.Url = value;
                    OnPropertyChanged("Url");
                }
            }
        }
        public string Description
        {
            get { return Photo.Description; }
            set
            {
                if (Photo.Description != value)
                {
                    Photo.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public DateTime DateAdded
        {
            get { return Photo.DateAdded; }
            set
            {
                if (Photo.DateAdded != value)
                {
                    Photo.DateAdded = value;
                    OnPropertyChanged("DateAdded");
                }
            }
        }
        public bool IsMain
        {
            get { return Photo.IsMain; }
            set
            {
                if (Photo.IsMain != value)
                {
                    Photo.IsMain = value;
                    OnPropertyChanged("IsMain");
                }
            }
        }
        public bool IsApproved
        {
            get { return Photo.IsApproved; }
            set
            {
                if (Photo.IsApproved != value)
                {
                    Photo.IsApproved = value;
                    OnPropertyChanged("IsApproved");
                }
            }
        }

        #endregion

        #region Constructor 

        public PhotoViewModel()
        {
            this.Photo = new Photo();
        }

        #endregion
    }
}
