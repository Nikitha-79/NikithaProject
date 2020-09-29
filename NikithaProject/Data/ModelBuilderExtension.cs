using Microsoft.EntityFrameworkCore;
using NikithaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikithaProject.Data
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Cookies", Description = "Freshly Baked Choco chip Cookies", Price = 25.50f, ImageName = "ChocolateChipCookies.jpg" },
                new Product { Id = 2, Name = "CupCake", Description = "Delicious Baked CupCake", Price = 55.50f, ImageName = "Cupcake.jpg" },
                new Product { Id = 3, Name = "Donut", Description = "Chololate Donut", Price = 25.50f, ImageName = "Donut.jpg" },
                new Product { Id = 4, Name = "Veg Puff", Description = "Spicy vegetarian Puff", Price = 20.00f, ImageName = "VegPuffs.jpg"}
                );

            return builder;
        }
    }
}
