using Microsoft.EntityFrameworkCore;
using PetShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Data.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Adopter> Adopters { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Service>Services { get; set; }
        public DbSet<Volunteer>Volunteers { get; set; }

    }
}
