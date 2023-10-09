using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SP.ViewModel
{
    public class SettingsViewModel : BaseViewModel
    {
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                RaisePropertyChanged(nameof(UserName));
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;

                RaisePropertyChanged(nameof(Email));
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Het is gelukt", $"{UserName}, {Email}", "Annuleer");
                });
            }
        }


        public bool ReceiveWeeklyStats { get; set; }

       
    }
}
