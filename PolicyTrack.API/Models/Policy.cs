namespace PolicyTrack.API.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public string Type { get; set; }  // e.g., Home, Auto
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Premium { get; set; }
        public int PolicyHolderId { get; set; }
        public PolicyHolder PolicyHolder { get; set; }
        public List<Claim> Claims { get; set; }
    }

}
