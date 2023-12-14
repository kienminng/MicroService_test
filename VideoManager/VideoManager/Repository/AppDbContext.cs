using Microsoft.EntityFrameworkCore;
using VideoManager.Entity;

namespace VideoManager.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public virtual DbSet<VideoBaiHocStatus>VideoBaiHocStatus { get; set; }
    public virtual DbSet<VideoBaiHocs> VideoBaiHocs { get; set; }
}