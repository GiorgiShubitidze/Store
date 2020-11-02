using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.Domain.DB
{
    public class SportsStoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Test2;Trusted_Connection=True;integrated security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                 new Product
                 {

                     ProductId = i,
                     Name = $"Product {i}",
                     Price = 20 + i,
                     CategoryId = rnd.Next(1, 6)
                 }
                 );
            }
            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<ProductImage>().HasData(
                 new ProductImage
                 {
                     ImageUrl = "https://via.placeholder.com/150",
                     IsThumbnail = true,     // rnd.Next(100) < 50 ? true : false,
                     ProductId = i,
                     ProductImageId = i
                 }
                 );
            }
            for (int i = 101; i <= 200; i++)
            {
                modelBuilder.Entity<ProductImage>().HasData(
                 new ProductImage
                 {
                     ImageUrl = "https://via.placeholder.com/100",
                     IsThumbnail = false,     // rnd.Next(100) < 50 ? true : false,
                     ProductId = i-100,
                     ProductImageId = i
                 }
                 );
            }
            
        }
    }
}
