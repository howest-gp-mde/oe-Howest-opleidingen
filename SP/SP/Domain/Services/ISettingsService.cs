using SP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Domain.Services
{
    public interface ISettingsService
    {
        Task<Settings> GetSettings();
    }
}
