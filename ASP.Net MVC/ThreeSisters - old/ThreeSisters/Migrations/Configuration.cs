namespace ThreeSisters.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ThreeSisters.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ThreeSisters.Models.SistersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ThreeSisters.Models.SistersDbContext context)
        {
            var listings = new List<Listing> {

                new Listing {
                    MSL = "BL3845",
                    Street1 = "65440 NW 76th St",
                    Street2 = "",
                    City = "Bend",
                    State = "OR",
                    Zipcode = "97701",
                    Neighborhood = "",
                    SalesPrice = 619000.00m,
                    DateListed = DateTime.Parse("2015-01-08"),
                    Bedrooms = 3,
                    Bathrooms = 4,
                    GarageSize = "2 car garage",
                    SquareFeet = 2714,
                    LotSize = 2.39m,
                    Description = "Spectacular in every way! Enjoy this impeccably kept custom built home that offers 2,714 sf of luxurious living w/ an open floor plan and sumptuous interior appointments. Located on a spacious 2.3 acre lot that provides extreme privacy. The moment you walk through the door this home makes you feel welcome. As you explore notice the many gorgeous finishes including the kitchen you have always dreamed of, breath taking high vaulted ceilings in living room area with a ledger stone fireplace."
                }
            };

            listings.ForEach(l => context.Listings.AddOrUpdate(p => p.MSL, l));
            context.SaveChanges();
        }
    }
}
