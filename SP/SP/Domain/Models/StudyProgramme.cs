using System;
using System.Collections.Generic;
using System.Text;

namespace SP.Domain.Models
{
    public class StudyProgramme
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string WebsiteUrl { get; set; }
        public string Location { get; set; }
        public List<string> StudyForm { get; set; }
        public string Description { get; set; }
    }
}
