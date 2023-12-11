using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Domain.Services
{
    public interface IIdentityService
    {

        string CreateAuthorizationRequest();
        string CreateLogoutRequest(string token);
        Task<UserToken> GetTokenAsync(string username, string password);
        Task<UserToken> GetTokenAsync(string code);
        Task<UserToken> RegisterTokenAsync(string email, string password);
    }
}
