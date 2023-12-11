using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SP.Domain.Services.Api
{
    public class SettingsApiService: ISettingsService
    {
        private readonly IApiClient _client;

        public SettingsApiService(IApiClient client)
        {
            _client = client;

        }

        public async Task<Settings> GetSettings()
        {
            var token = await SecureStorage.GetAsync("token");

            return await _client
              .GetApiResult<Settings>($"{Constants.ApiBaseUrl}api/profile", token);
        }
    }
}
