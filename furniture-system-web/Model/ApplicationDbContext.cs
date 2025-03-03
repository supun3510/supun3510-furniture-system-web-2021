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
            optionsBuilder.UseSqlServer("Data Source=SQL5109.site4now.net; Initial Catalog=db_a7f38c_sandamal;User Id=db_a7f38c_sandamal_admin;Password=sandamal99;");
        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Discount> discounts { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Production> productions { get; set; }
        public DbSet<CashProduction> cashProductions { get; set; }
        public DbSet<CheckProduction> checkProductions { get; set; }
        public DbSet<CardProduction> cardProductions { get; set; }
        public DbSet<ProductionCart> ProductionCarts { get; set; }
    }
}
