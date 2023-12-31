﻿using FreshMvvm;
using SP.Domain.Models;
using SP.Domain.Services;
using SP.Domain.Validators;
using SP.Services;
using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SP.ViewModels
{
    public class SettingsViewModel : FreshBasePageModel
    {
        private IPushService _pushService;
        private ISettingsService _settingsService;

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

        
        public SettingsViewModel(IPushService pushService, ISettingsService settingsService)
        {
            _pushService = pushService;
            _settingsService = settingsService;

        }

        public async override void Init(object initData)
        {
           
            
        }

        protected override async  void ViewIsAppearing(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(await SecureStorage.GetAsync("token")))
            {
                try
                {
                    var settings = await _settingsService.GetSettings();
                    Email = settings.Email;
                    NumberOfCertificates = settings.NumberOfCertificates;
                    ReceiveWeeklyStats = settings.ReceiveWeeklyStats;
                    UserName = settings.UserName;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    await CoreMethods.DisplayAlert("Error", ex.Message, "cancel");
                }


            }
            else
            {
                await CoreMethods.PushPageModel<LoginViewModel>();
            }
        }

        public ICommand ShowNotificationCommand
        {
            get
            {
                return new Command(() =>
                {
                    _pushService.SendNotification("Boe !");
                });
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
