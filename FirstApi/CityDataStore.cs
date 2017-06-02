using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;

namespace FirstApi
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New york",
                    Description = "big Apple",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {

                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "A park"
                        },

                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A fuckign building"
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Belgium",
                    Description = "fuck my waffle"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Antwerp",
                    Description = "cathredal"
                },
            };
        }
    }
}