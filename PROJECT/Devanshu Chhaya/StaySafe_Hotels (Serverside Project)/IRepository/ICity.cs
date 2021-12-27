using StaySafeHotels.ApplicationDto;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface ICity: IGenericInterface<City>
    {
        List<Hotel> GetHotelByCityId(int id);
        List<City> GetCitiesByState(int stateid);
        bool updateCity(City city);
        CityDto GetCityById(int id);
        IEnumerable<CityDto> GetAllCities();
    }
}
