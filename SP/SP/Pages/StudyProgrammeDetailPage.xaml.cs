using SP.Domain.Models;
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
	public partial class StudyProgrammeDetailPage : ContentPage
	{
		public StudyProgrammeDetailPage (/**StudyProgramme programme**/)
		{
			InitializeComponent ();

			// this.BindingContext = new StudyProgrammeDetailViewModel(programme);
		}
	}
}