using SP.Domain.Models;
using System.Collections.Generic;

namespace SP.Services
{
    public interface IStudyProgrammeService
    {
        List<StudyProgramme> GetAll();
    }
}