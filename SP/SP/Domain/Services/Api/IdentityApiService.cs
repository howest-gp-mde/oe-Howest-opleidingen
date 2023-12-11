using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Domain.Services.Api
{
    public class IdentityApiService : IIdentityService
    {
        private readonly IApiClient _client;

        public IdentityApiService(IApiClient client)
        {
            _client = client;

        }

        public string CreateAuthorizationRequest()
        {
            throw new NotImplementedException();
        }

        public string CreateLogoutRequest(string token)
        {
            throw new NotImplementedException();
        }

        public async Task<UserToken> GetTokenAsync(string username, string password)
        {
            return await _client
              .PostCallApi<UserToken, GetTokenDTO>($"{Constants.ApiBaseUrl}api/account/login", new GetTokenDTO { Email = username, Password = password});
        }

        public Task<UserToken> GetTokenAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<UserToken> RegisterTokenAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }

    class GetTokenDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
