using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SP.ViewModel
{
    public class StudyProgrammesViewModel
    {
        public StudyProgramme SelectedStudyProgramme { get; set; }
        public string Title { get; set; }
        public List<StudyProgramme> StudyProgrammes { get; set; }
    }
}
