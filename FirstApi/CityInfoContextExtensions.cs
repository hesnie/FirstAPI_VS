using FirstApi.Entities;
using FirstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi
{
    public static class CityInfoContextExtensions
    {

        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
             new City()
                {
                    Name = "New york",
                    Description = "big Apple",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "A park"
                        },

                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A fuckign building"
                        },
                    }
                },
                new City()
                {
                    Name = "Belgium",
                    Description = "fuck my waffle"
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "cathredal"
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
