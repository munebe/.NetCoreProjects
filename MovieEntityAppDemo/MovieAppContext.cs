using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MovieEntityAppDemo;

public class MovieAppContext:DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    
    //consolda çıktı olarak sql sorgularını verecektir
    public static readonly ILoggerFactory MyLoggerFactory
        = LoggerFactory.Create(builder => { builder.AddConsole(); });
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //todo connectionString yazırlacak
        optionsBuilder
            .UseLoggerFactory(MyLoggerFactory) //loglama yapısı için
            .UseSqlServer("{connectionString}");
    }
}