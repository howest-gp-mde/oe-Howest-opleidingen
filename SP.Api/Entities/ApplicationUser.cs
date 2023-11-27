using Microsoft.AspNetCore.Identity;

namespace SP.Api.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int NumberOfCertificates { get; set; }

        public bool ReceiveWeeklyStats { get; set; }
    }
}
