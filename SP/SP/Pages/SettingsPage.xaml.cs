using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        SettingsViewModel model = new SettingsViewModel();
        public SettingsPage()
        {
            InitializeComponent();  
            this.BindingContext = model;
        }

        //private async void BtnSave_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert(model.UserName, model.Email, model.ReceiveWeeklyStats.ToString());
        //}
    }
}