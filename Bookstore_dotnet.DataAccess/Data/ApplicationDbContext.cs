using Bookstore_dotnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bookstore_dotnet.DataAccess.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
            new Category { Id = 3, Name = "History", DisplayOrder = 3 }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Title = "Book 1", Description = "Description 1", ISBN = "ISBN1", Author = "Author 1", ListPrice = 100, Price = 90, Price50 = 80, Price100 = 70, CategoryId = 1, ImageUrl = "" },
            new Product { Id = 2, Title = "Book 2", Description = "Description 2", ISBN = "ISBN2", Author = "Author 2", ListPrice = 150, Price = 140, Price50 = 130, Price100 = 120, CategoryId = 2, ImageUrl = "" },
            new Product { Id = 3, Title = "Book 3", Description = "Description 3", ISBN = "ISBN3", Author = "Author 3", ListPrice = 200, Price = 180, Price50 = 160, Price100 = 150, CategoryId = 3, ImageUrl = "" }
        );
    }
}
    