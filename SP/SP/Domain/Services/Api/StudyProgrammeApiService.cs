using SP.Domain.Models;
using SP.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Domain.Services.Api
{
    public class StudyProgrammeApiService : IStudyProgrammeService
    {
        private readonly IApiClient _client;

        public StudyProgrammeApiService(IApiClient client)
        {
            _client = client;

        }
        public async Task<List<StudyProgramme>> GetAll()
        {
            return await _client
               .GetApiResult<List<StudyProgramme>>($"{Constants.ApiBaseUrl}api/studyprogrammes");
        }
    }
}
