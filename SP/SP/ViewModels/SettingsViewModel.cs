using FreshMvvm;
using SP.Domain.Models;
using SP.Domain.Validators;
using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Input;
using Xamarin.Forms;

namespace SP.ViewModels
{
    public class SettingsViewModel : FreshBasePageModel
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
                userName = value.Replace("@", "")
                    .Replace(".", "");
                RaisePropertyChanged(nameof(UserName));
            }
        }

        private int numberOfCertificates;

        public int NumberOfCertificates
        {
            get { return numberOfCertificates; }
            set
            {
                numberOfCertificates = value;
                RaisePropertyChanged(nameof(NumberOfCertificates));
            }
        }

        private string numberOfCertificatesError;
        public string NumberOfCertificatesError
        {
            get { return numberOfCertificatesError; }
            set
            {
                numberOfCertificatesError = value;
                RaisePropertyChanged(nameof(NumberOfCertificatesError));
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

        public SettingsViewModel()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = Path.Combine(folder, Domain.Models.Constants.SettingsFile);
            if (File.Exists(fullPath))
            {
                string output = File.ReadAllText(fullPath);
                var settings = JsonSerializer.Deserialize<Settings>(output);
                Email = settings.Email;
                NumberOfCertificates = settings.NumberOfCertificates;
                ReceiveWeeklyStats = settings.ReceiveWeeklyStats;
                UserName = settings.UserName;
            }
        }

        public override void Init(object initData)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = Path.Combine(folder, Domain.Models.Constants.SettingsFile);
            if (File.Exists(fullPath))
            {
                string output = File.ReadAllText(fullPath);
                var settings = JsonSerializer.Deserialize<Settings>(output);
                Email = settings.Email;
                NumberOfCertificates = settings.NumberOfCertificates;
                ReceiveWeeklyStats = settings.ReceiveWeeklyStats;
                UserName = settings.UserName;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var settings = new Settings
                    {
                        Email = Email,
                        NumberOfCertificates = NumberOfCertificates,
                        ReceiveWeeklyStats = ReceiveWeeklyStats,
                        UserName = UserName
                    };

                    if (Validate(settings))
                    {
                        string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        string fullPath = Path.Combine(folder, Domain.Models.Constants.SettingsFile);

                        File.WriteAllText(fullPath, JsonSerializer.Serialize(settings));
                        await App.Current.MainPage.DisplayAlert("Het is gelukt", $"{UserName}, {Email}", "Annuleer");
                    }
                });
            }
        }



        private bool receiveWeeklyStats;

        public bool ReceiveWeeklyStats
        {
            get { return receiveWeeklyStats; }
            set { receiveWeeklyStats = value; }
        }


        private bool Validate(Settings settings)
        {
            var validator = new SettingsValidator();

            var result = validator.Validate(settings);

            foreach (var error in result.Errors)
            {
                if (error.PropertyName == nameof(NumberOfCertificates))
                {
                    NumberOfCertificatesError = error.ErrorMessage;
                }

            }

            //NumberOfCertificatesError = "";

            //if(NumberOfCertificates == 0)
            //{
            //    NumberOfCertificatesError = Domain.Models.Constants.NumberOfPetsError;
            //    isValid = false;
            //}




            return result.IsValid;
        }

    }
}
