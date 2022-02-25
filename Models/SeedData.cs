using GBC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
namespace GBC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GBCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GBCContext>>()))
            {
                // Look for any products.
                if (context.ManageProducts.Any())
                {
                    return;   // DB has been seeded
                }
                context.ManageProducts.AddRange(
                    new ManageProducts
                    {
                        //Id = 10
                        //Code = "TRNY10",
                        Name = "Tournament Master 1.0",
                        Price = 4.99M,
                        ReleaseDate now = DateTime.Now,
                        ReleaseDate modifiedDataTime = now.AddHours(6)
                    },

                    new ManageProducts
                    {
                        //Id = 11,
                        //Code = "LEAG10",
                        Name = "League Scheduler 1.0",
                        Price = 4.99M,
                        //ReleaseDate = DateTime.Parse("2016-01-05")
                        ReleaseDate now = DateTime.Now,
                        ReleaseDate modifiedDataTime = now.AddHours(6)
                    },

                    new ManageProducts
                    {
                        //Id = 12,
                        //Code = "LEAGD10",
                        Name = "League Scheduler Deluxe 1.0",
                        Price = 7.99M,
                        //ReleaseDate = DateTime.Parse("2016-01-08")
                        ReleaseDate now = DateTime.Now,
                        ReleaseDate modifiedDataTime = now.AddHours(6)
                    },

                    new ManageProducts
                    {
                        //Id = 13,
                        //Code = "DRAFT10",
                        Name = "Draft Manager 1.0",
                        Price = 4.99M,
                        //ReleaseDate = DateTime.Parse("2017-01-02")
                        ReleaseDate now = DateTime.Now,
                        ReleaseDate modifiedDataTime = now.AddHours(6)
                    }
                );;
                context.SaveChanges();
            }
        }
    }
}
