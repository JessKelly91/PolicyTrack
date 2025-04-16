using PolicyTrack.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PolicyTrack.API.Data
{
    public class PolicyTrackContext : DbContext
    {
        public PolicyTrackContext(DbContextOptions<PolicyTrackContext> options)
            : base(options)
        { }

        public DbSet<PolicyHolder> PolicyHolders { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
