using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandInHandOut.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Books> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Books>().HasData(
                new Books
                {
                    id = 1,
                    Name = "C# For Dummies",
                    Author = "Syed Abdul Suboor",
                    Major = Major.ComputerScience,
                    BuyingAmount = 12.99,
                    RentingAmount = 0.2,
                    IsAvailable = Available.Yes,
                    NumberOfBooksAvailable = 20

                }
                );
        }
    }
}
