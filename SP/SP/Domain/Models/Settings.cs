using System;
using System.Collections.Generic;
using System.Text;

namespace SP.Domain.Models
{
    public class Settings
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public int NumberOfCertificates { get; set; }

        public bool ReceiveWeeklyStats { get; set; }
    }
}
