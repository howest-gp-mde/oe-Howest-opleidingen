using SP.Services;
using SP.Services.Mock;
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
    public partial class StudyProgrammesPage : ContentPage
    {
        //private IStudyProgrammeService _studyProgrammeService;
        public StudyProgrammesPage()
        {
            InitializeComponent();
            //_studyProgrammeService = new StudyProgrammeService();

            //var model = new StudyProgrammesViewModel();
            //model.StudyProgrammes = _studyProgrammeService.GetAll();
            //model.Title = "Ontdek onze opleidingen";

            
            // BindingContext = new StudyProgrammesViewModel();
        }

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
        }
    }
}