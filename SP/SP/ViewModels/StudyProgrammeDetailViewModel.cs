using FreshMvvm;
using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SP.ViewModels
{
    public  class StudyProgrammeDetailViewModel: FreshBasePageModel
    {
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

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public ICommand GoBackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    // await App.Current.MainPage.Navigation.PopAsync();
                    await CoreMethods.PopPageModel();
                });
            }
        }

        public StudyProgrammeDetailViewModel()
        {
            
        }

        public override void Init(object initData)
        {
            var selectedStudyProgramme = initData as StudyProgramme;

            this.Title = selectedStudyProgramme.Title;
            this.Image = selectedStudyProgramme.Image;
            this.Description = selectedStudyProgramme.Description;
        }

        public override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
        }

    }
}
