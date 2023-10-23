using SP.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SP.Services
{
    public interface IStudyProgrammeService
    {
        Task<List<StudyProgramme>> GetAll();
    }
}