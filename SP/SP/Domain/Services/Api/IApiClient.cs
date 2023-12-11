using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Domain.Services.Api
{
    public interface IApiClient
    {
        Task<TOut> DeleteCallApi<TOut>(string uri);
        Task<T> GetApiResult<T>(string uri, string token = null);
        Task<TOut> PostCallApi<TOut, TIn>(string uri, TIn entity);
        Task<TOut> PutCallApi<TOut, TIn>(string uri, TIn entity);
    }
}
