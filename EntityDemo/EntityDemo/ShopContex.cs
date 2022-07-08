using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace EntityDemo;

public class ShopContext : DbContext
{
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Categorie> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //todo connectionString yazırlacak
        optionsBuilder.UseSqlServer("{connectionString}");
    }
}