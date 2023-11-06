using SP.Domain.Models;
using SP.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SP.Domain.Services.File
{
    public class StudyProgrammeFileService : IStudyProgrammeService
    {
        public async Task<List<StudyProgramme>> GetAll()
        {
            var assembly = typeof(StudyProgrammeFileService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("SP.Files.opleidingen.json");
            //List<StudyProgramme> list = new List<StudyProgramme>();

            //using (var reader = new StreamReader(stream)) 
            //{
            //    string text = await reader.ReadToEndAsync();
                List<StudyProgramme> list = await JsonSerializer.DeserializeAsync<List<StudyProgramme>>(stream, 
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                    );
            //}
            
            return list;
        }
    }
}
