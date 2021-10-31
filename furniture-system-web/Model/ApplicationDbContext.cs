﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace furniture_system_web.Model
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL5052.site4now.net;Initial Catalog=db_a7a466_supunsam;User Id=db_a7a466_supunsam_admin;Password=supun3510");
        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Production> productions { get; set; }
        public DbSet<ProductionCart> ProductionCarts { get; set; }
    }
}
