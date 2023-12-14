using Microsoft.EntityFrameworkCore;
using UserManager.Entity;

namespace UserManager.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamStatus> TeamStatuses { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<UserStatus> UserStatuses { get; set; }
     }
}
