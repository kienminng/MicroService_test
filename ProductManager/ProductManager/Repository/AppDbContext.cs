using Microsoft.EntityFrameworkCore;
using ProductManager.Entity;

namespace ProductManager.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public virtual DbSet<PhieuXemNhas> PhieuXemNhas { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductImgs> ProductImgs { get; set; }
    public virtual DbSet<ProductStatus> ProductStatus { get; set; }
}