using SP.Services;
using SP.Services.Mock;
using SP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudyProgrammesPage : ContentPage
    {
        private IStudyProgrammeService _studyProgrammeService;
        public StudyProgrammesPage()
        {
            InitializeComponent();
            _studyProgrammeService = new StudyProgrammeService();

            var model = new StudyProgrammesViewModel();
            model.StudyProgrammes = _studyProgrammeService.GetAll();
            model.Title = "Ontdek onze opleidingen";

            BindingContext = model;
        }

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
        }
    }
}