using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportsApp.Data;
using System;
using System.Linq;

namespace SportsApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SportsAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SportsAppContext>>()))
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
                        Code = "TRNY10",
                        Name = "Tournament Master 1.0",
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2015-01-12")
                    },

                    new ManageProducts
                    {
                        //Id = 11,
                        Code = "LEAG10",
                        Name = "League Scheduler 1.0",
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2016-01-05")
                    },

                    new ManageProducts
                    {
                        //Id = 12,
                        Code = "LEAGD10",
                        Name = "League Scheduler Deluxe 1.0",
                        Price = 7.99M,
                        ReleaseDate = DateTime.Parse("2016-01-08")
                    },

                    new ManageProducts
                    {
                        //Id = 13,
                        Code = "DRAFT10",
                        Name = "Draft Manager 1.0",
                        Price = 4.99M,
                        ReleaseDate = DateTime.Parse("2017-01-02")
                    }
                );
                context.SaveChanges();



                // Look for any products.
                if (context.TechnicianManager.Any())
                {
                    return;   // DB has been seeded
                }
                context.TechnicianManager.AddRange(
                    new TechnicianManager
                    {
                        //Id = 10
                        TechnicianName = "Mark Sloan",
                        TechnicianEmail = "mark@sportsapplication.com",
                        TechnicianPhone = 888-555-6569
                      
                    },

                    new TechnicianManager
                    {
                        TechnicianName = "Kendrick Lamar",
                        TechnicianEmail = "kendrick@lamar.com",
                        TechnicianPhone = 888-555-8541
                    }
                );
                context.SaveChanges();


                // Look for any products.
                if (context.CustomerManager.Any())
                {
                    return;   // DB has been seeded
                }
                context.CustomerManager.AddRange(
                    new CustomerManager
                    {
                        //Id = 10
                        CustomerFirstName = "Dan",
                        CustomerLastName = "Fresh",
                        CustomerAddress = "50 Charming Ave",
                        CustomerCity = "Toronto",
                        CustomerState = "ON",
                        CustomerPostal = "M2K 2K2",
                        CustomerCountry = "Canada",
                        CustomerEmail = "boring@gmail.com",
                        CustomerPhone = 777 - 255 - 3256

                    },

                    new CustomerManager
                    {
                        CustomerFirstName = "Jane",
                        CustomerLastName = "Doe",
                        CustomerAddress = "50 Charming Ave",
                        CustomerCity = "Toronto",
                        CustomerState = "ON",
                        CustomerPostal = "M2K 2K2",
                        CustomerCountry = "Canada",
                        CustomerEmail = "boring@gmail.com",
                        CustomerPhone = 777-255-3256
                    }
                );
                context.SaveChanges();


                // Look for any products.
                if (context.IncidentPage.Any())
                {
                    return;   // DB has been seeded
                }
                context.IncidentPage.AddRange(
                    new IncidentPage
                    {
                        //Id = 10
                        Product = "fifa",
                        Title = "broken",
                        Description = "no messi",
                        Technician = "Michael",
                        DateOpened = DateTime.Parse("2015-01-12"),
                        DateClosed = DateTime.Parse("2015-12-12"),

                    },

                    new IncidentPage
                    {
                        Product = "cod",
                        Title = "p2w",
                        Description = "boring",
                        Technician = "activision",
                        DateOpened = DateTime.Parse("2015-01-12"),
                        DateClosed = DateTime.Parse("2015-12-12"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}