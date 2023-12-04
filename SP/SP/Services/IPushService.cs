using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SP.Services
{
    public interface IPushService
    {
        void Initialize();
        void SendNotification(string message);
    }
}
