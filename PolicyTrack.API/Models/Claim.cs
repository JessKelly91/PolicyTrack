namespace PolicyTrack.API.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateFiled { get; set; }
        public string Status { get; set; }  // e.g., Pending, Approved, Denied
        public int PolicyId { get; set; }
        public Policy Policy { get; set; }
    }

}
