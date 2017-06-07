using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Entities;

namespace FirstApi.Service
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();
        City GetCity(int cityId, bool includePointsOfInterest);
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
        bool CityExists(int cityId);
        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);
        bool Save();
        void DeletePointOfInterest(PointOfInterest pointOfInterest);
    }
}
