using FreshMvvm;
using SP.Domain.Models;
using SP.Pages;
using SP.Services;
using SP.Services.Mock;
using SP.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SP.ViewModels
{
    public class StudyProgrammesViewModel : FreshBasePageModel
    {
        private IStudyProgrammeService _studyProgrammeService;

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        private StudyProgramme selectedStudyProgramme;

        public StudyProgramme SelectedStudyProgramme
        {
            get { return selectedStudyProgramme; }
            set
            {
                selectedStudyProgramme = value;
                RaisePropertyChanged(nameof(StudyProgramme));
                OnItemSelected(value);
            }
        }



        private ObservableCollection<StudyProgramme> studyProgrammes;

        public ObservableCollection<StudyProgramme> StudyProgrammes
        {
            get { return studyProgrammes; }
            set
            {
                studyProgrammes = value;
                RaisePropertyChanged(nameof(StudyProgrammes));
            }
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                RaisePropertyChanged(nameof(IsBusy));
            }
        }



        public StudyProgrammesViewModel(IStudyProgrammeService service)
        {
            _studyProgrammeService = service;

        }

        public override void Init(object initData)
        {

            this.Title = "Ontdek onze opleidingen";
            this.LoadData.Execute(null);
        }

        public ICommand LoadData
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;
                    var programmes = await _studyProgrammeService.GetAll();
                    IsBusy = false;
                    this.StudyProgrammes = new ObservableCollection<StudyProgramme>(programmes);
                });
            }
        }


        public override void ReverseInit(object value)
        {
            base.ReverseInit(value);
        }




        private async void OnItemSelected(StudyProgramme item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            // await App.Current.MainPage.Navigation.PushAsync(new StudyProgrammeDetailPage(SelectedStudyProgramme));

            await CoreMethods.PushPageModel<StudyProgrammeDetailViewModel>(SelectedStudyProgramme, true, true);
        }
    }
}
