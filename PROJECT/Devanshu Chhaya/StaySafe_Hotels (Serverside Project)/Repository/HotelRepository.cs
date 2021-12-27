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
    public class HotelRepository: GenericRepository<Hotel>,IHotel
    {
        private readonly IMapper _mapper;

        public HotelRepository(StaySafeDBContext context,IMapper mapper): base(context)
        {
            _mapper = mapper;
        }

        public IEnumerable<Hotel> getAllHotels()
        {
            var hotels = _context.Hotels.Where(x => x.IsActive == true);

            var h = from x in hotels
                    select new Hotel
                    {
                        HotelName = x.HotelName,
                        PhoneNumber1 = x.PhoneNumber1,
                        PhoneNumber2 = x.PhoneNumber2,
                        EmailID = x.EmailID,
                        Address = x.Address,
                        CityID = x.CityID,
                        City = _context.Cities.SingleOrDefault(p => p.CityID == x.CityID),
                        ZipCode = x.ZipCode,
                        OverView=x.OverView,
                        Image=x.Image,
                        RailwayStationDistanceInKM=x.RailwayStationDistanceInKM,
                        BusStationDistanceInKM=x.BusStationDistanceInKM,
                        IsActive=x.IsActive
                    };
            return h;
        }

        public HotelDTO GetHotelById(int id)
        {
            var hotel = GetById(id);
            if (hotel.IsActive == true)
            {
                var hotelDto = _mapper.Map<HotelDTO>(hotel);
                var owner = _context.Owners.Where(x => x.HotelId == hotel.HotelId).FirstOrDefault();
                var types = _context.HotelHasRoomTypes.Where(x => x.HotelId == hotel.HotelId).ToArray();
                var city = _context.Cities.Find(hotel.CityID);
                hotelDto.City = city.Name;
                hotelDto.Owner = owner.OwnerFullName;
                //for (int j= 0; j<=types.Length; j++)
                //{
                //    hotelDto.RoomTypes[j] = types[j];
                        
                //}
                return hotelDto;
            }
            else
            {
                return null;
            }

        } 

        public override void Create(Hotel entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

            if (entity.HotelHasHighlights.Count > 0)
            {
                _context.HotelHasHighlights.AddRange(entity.HotelHasHighlights);
                //_context.SaveChanges();
            }

            if (entity.HotelHasRoomTypes.Count > 0)
            {
                _context.HotelHasRoomTypes.AddRange(entity.HotelHasRoomTypes);
            }
        }
        public override void Delete(int id)
        {
            var hotel = _context.Hotels
                                .Where(s => s.HotelId == id)
                                .SingleOrDefault();
            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
        }

    }
}
