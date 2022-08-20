﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication3
{
    public class PracticeAdilaDbContext : DbContext

    {
        public PracticeAdilaDbContext() : base()
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            // previous string:
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-7M7OSA9; Initial Catalog = PracticeAdilaDb; Integrated Security = True");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Other possible methods:
            // .HasColumnName(“sName”)
            // .HasColumnType(“varchar”)
            // .HasColumnOrder(2)
            // HasMaxLength(255);
            // Are there any more important ones I'm missing?
            // modelBuilder.Entity<Review>().Property(review => review.ReviewerName).IsRequired();

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    City = "Hasselt",
                    Country = "Belgium",
                    Name = "Luigi's"
                });
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 2,
                    City = "Sint-Truiden",
                    Country = "Belgium",
                    Name = "Bombasta"
                });
            
        }
    }
}
