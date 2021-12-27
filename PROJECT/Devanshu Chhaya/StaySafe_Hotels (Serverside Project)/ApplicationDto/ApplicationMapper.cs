using AutoMapper;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.ApplicationDto
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper()
        {
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Hotel, OwnerDTO>().ReverseMap();
            CreateMap<Owner, HotelDTO>().ReverseMap();
            CreateMap<Room, RoomDTO>().ReverseMap();
            CreateMap<Booking, BookingDTO>().ReverseMap();
        }
    }
}
