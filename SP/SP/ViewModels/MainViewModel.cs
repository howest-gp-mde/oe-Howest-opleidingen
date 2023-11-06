using FreshMvvm;
using SP.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SP.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {

        public ICommand GoToOverviewCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await CoreMethods.PushPageModel<StudyProgrammesViewModel>(true);
                });
            }
        }

        public ICommand GoToSettingsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    // await App.Current.MainPage.Navigation.PushAsync(new SettingsPage());
                    await CoreMethods.PushPageModel<SettingsViewModel>(true);
                });
            }
        }
    }
}
