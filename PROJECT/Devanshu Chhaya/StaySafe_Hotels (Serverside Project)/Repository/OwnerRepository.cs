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
    public class OwnerRepository: GenericRepository<Owner>,IOwner
    {
        private readonly IMapper _mapper;

        public OwnerRepository(StaySafeDBContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public OwnerDTO GetRoomById(int id)
        {
            var owner = GetById(id);

            if (owner.IsActive == true)
            {
                var ownerDto = _mapper.Map<OwnerDTO>(owner);
                var hotel = _context.Hotels.Find(owner.HotelId);
                var city = _context.Cities.Find(owner.CityID);
                
                ownerDto.Hotel = hotel.HotelName;
                ownerDto.City = city.Name;
                return ownerDto;
            }
            else
            {
                return null;
            }


        }
        public bool updateOwnre(Owner owner)
        {
            var old = _context.Owners.Find(owner.OwnerID);
            var city = _context.Cities.SingleOrDefault(x => x.Name == owner.City.Name);
            var hotel = _context.Hotels.SingleOrDefault(x => x.HotelName == owner.Hotel.HotelName);

            if (old != null && city!=null && hotel!=null)
            {
                old.HotelId = hotel.HotelId;
                old.OwnerFullName = owner.OwnerFullName;
                old.EmailID = owner.EmailID;
                old.Address = owner.Address;
                old.PhoneNumber = owner.PhoneNumber;
                old.CityID = city.CityID;
                old.Zipcode = owner.Zipcode;
                old.IsActive = owner.IsActive;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Delete(int id)
        {
            var owner = _context.Owners.Find(id);
            _context.Owners.Remove(owner);
            _context.SaveChanges();
        }
    }
}
