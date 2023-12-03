namespace SP.Api.DTO
{
    public class ProfileResponseDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public int NumberOfCertificates { get; set; }

        public bool ReceiveWeeklyStats { get; set; }
    }
}
