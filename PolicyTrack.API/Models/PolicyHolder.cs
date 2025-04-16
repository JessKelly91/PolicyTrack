namespace PolicyTrack.API.Models
{
    public class PolicyHolder
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Policy> Policies { get; set; }
    }

}
