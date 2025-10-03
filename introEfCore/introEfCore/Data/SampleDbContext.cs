using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEfCore.Data
{
    public class SampleDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=turktelekomsampledb;Integrated Security=True;Encrypt=True");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Kozmetik" }, new Category { Id = 2, Name = "Kırtasiye" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Krem", Description = "El kremi", Price = 1, CategoryId = 1 },
                new Product { Id = 2, Name = "Kalem", Description = "El kalemi", Price = 5, CategoryId = 2 }

                );


        }
    }
}
