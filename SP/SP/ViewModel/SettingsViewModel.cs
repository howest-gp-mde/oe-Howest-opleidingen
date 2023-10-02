using System;
using System.Collections.Generic;
using System.Text;

namespace SP.ViewModel
{
    public class SettingsViewModel
    {
        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public string Email { get; set; }

        public bool ReceiveWeeklyStats { get; set; }
    }
}
