﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Service
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

        public City GetCity(int cityId, bool includePointsOfInterest)
        {
            if (includePointsOfInterest)
            {
                return _context.Cities.Include(c => c.PointsOfInterest).Where(c => c.Id == cityId).FirstOrDefault();
            }
            return _context.Cities.Where(c => c.Id == cityId).FirstOrDefault();
        }

        public PointOfInterest GetPointOfInterest(int cityId, int pointOfInterestId)
        {
            return _context.PointOfInterest.Where(p => p.CityId == cityId && p.Id == pointOfInterestId).FirstOrDefault();
        }

        public IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId)
        {
            return _context.PointOfInterest
                .Where(p => p.CityId == cityId).ToList();
        }

        public PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId)
        {
            return _context.PointOfInterest.
                Where(p => p.CityId == cityId && p.Id == pointOfInterestId).FirstOrDefault();
        }

        public bool CityExists(int cityId)
        {
            return _context.Cities.Any(c => c.Id == cityId);
        }
    }
}
