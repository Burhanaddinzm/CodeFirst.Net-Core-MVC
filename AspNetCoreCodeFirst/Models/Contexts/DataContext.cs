using AspNetCoreCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreCodeFirst.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Size> Sizes { get; set; } = null!;
        public DbSet<Color> Colors { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
    }
}
