using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;

namespace DataAccess.Concrete.EntityFramework;

public class NorthwindContext: DbContext
{
    public NorthwindContext()
    {
        // Load environment variables from the .env file
        DotNetEnv.Env.Load();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Get the password from the environment variable
        var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

        // Use the password in the connection string
        optionsBuilder.UseSqlServer(@$"Server=localhost;Database=Northwind;User Id=sa;Password={dbPassword};TrustServerCertificate=True");
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}