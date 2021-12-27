using AutoMapper;
using StaySafeHotels.ApplicationDto;
using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class CityRepository: GenericRepository<City>,ICity
    {
        public readonly IMapper _mapper;
        public CityRepository(StaySafeDBContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public IEnumerable<CityDto> GetAllCities()
        {
            var city = _context.Cities.Select(x => new CityDto()
            {
                CityID=x.CityID,
                Name=x.Name,
                State=_context.States.SingleOrDefault(y=>y.StateID==x.StateId).StateName
            });
            return city;
            
        }

        public CityDto GetCityById(int id)
        {
            var city = GetById(id);
            if (city.IsActive == true)
            {
                var cityDto = _mapper.Map<CityDto>(city);
                var state = _context.States.Find(city.StateId);
                cityDto.State = state.StateName;
                return cityDto;
            }
            else
            {
                return null;
            }
        } 

        public List<City> GetCitiesByState(int stateid)
        {
            try
            {
                return _context.Cities.Where(x => x.StateId == stateid).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //get hotels of perticular city

        public List<Hotel> GetHotelByCityId(int id)
        {
            var hotels = _context.Hotels
                                .Where(x => x.CityID == id).ToList();
            return hotels;
        }

        public bool updateCity(City city)
        {
            var oldCity = _context.Cities.Find(city.CityID);
            var state = _context.States.SingleOrDefault(x => x.StateName == city.State.StateName);

            if (oldCity != null)
            {
                oldCity.Name = city.Name;
                oldCity.StateId = state.StateID;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        //delete city

        public override void Delete(int id)
        {
            var city = _context.Cities
                                .Where(x => x.CityID == id)
                                .SingleOrDefault();
            _context.Cities.Remove(city);
            _context.SaveChanges();
        }
    }
}
