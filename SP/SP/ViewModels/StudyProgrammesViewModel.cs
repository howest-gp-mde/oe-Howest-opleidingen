using SP.Domain.Models;
using SP.Services;
using SP.Services.Mock;
using SP.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SP.ViewModel
{
    public class StudyProgrammesViewModel : BaseViewModel
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

        public ICommand RemoveSPCommand
        {
            get
            {
                return new Command(async () => 
                {
                    if(SelectedStudyProgramme != null)
                    {
                        await App.Current.MainPage.Navigation.PushAsync(new SettingsPage());
                    }
                });
            }
        }


        public StudyProgrammesViewModel()
        {
            _studyProgrammeService = new StudyProgrammeMockService();
            this.Title = "Ontdek onze opleidingen";
            this.studyProgrammes = new ObservableCollection<StudyProgramme>(_studyProgrammeService.GetAll());
        }
    }
}
