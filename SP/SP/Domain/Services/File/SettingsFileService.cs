using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.IO;
using System.Text;
using System.Text.Json;
using SP.Domain.Models;

namespace SP.Domain.Services.File
{
    public class SettingsFileService : ISettingsService
    {
        public Task<Settings> GetSettings()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string fullPath = Path.Combine(folder, Domain.Models.Constants.SettingsFile);
            if (System.IO.File.Exists(fullPath))
            {
                string output = System.IO.File.ReadAllText(fullPath);
                var settings = JsonSerializer.Deserialize<Settings>(output);
                return Task.FromResult(settings);

            }
            throw new Exception("Path is not correct");
        }
    }
}
