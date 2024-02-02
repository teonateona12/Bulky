using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) :base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name= "Action", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
               new Category { Id = 3, Name = "History", DisplayOrder = 3 },
               new Category { Id = 9, Name = "Oh BOy", DisplayOrder = 4 }

                );

            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Title = "Fortune of time", Author = "Billy Spark", Description = "present vitae solades livero.", ISBN = "SWD9999001", ListPrice = 99, Price = 90, Price100 = 80, Price50 = 85, CategoryId = 1 },
               new Product { Id = 2, Title = "Rock in the Ocean", Author = "Ron Parker", Description = "present vitae solades livero.", ISBN = "SOTJ1111111101", ListPrice = 30, Price = 27, Price100 = 20, Price50 = 25, CategoryId=2},
               new Product { Id = 3, Title = "Leaves and Wonders", Author = "Laura Phanton", Description = "present vitae solades livero.", ISBN = "FOT000000001", ListPrice = 25, Price = 23, Price100 = 20, Price50 = 22, CategoryId = 3 }
           );
        }
    }
}
