using Microsoft.EntityFrameworkCore;
using WEBAPI_STAJ.Models;

namespace WEBAPI_STAJ.DataAccessLayer
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=PRODUCT; Integrated Security=True; TrustServerCertificate=True;");
        }
    }
}