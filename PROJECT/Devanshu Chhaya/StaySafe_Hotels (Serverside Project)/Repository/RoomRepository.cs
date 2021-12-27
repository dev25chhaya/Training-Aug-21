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
    public class RoomRepository: GenericRepository<Room>,IRoom
    {
        private readonly IMapper _mapper;

        public RoomRepository(StaySafeDBContext context,IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public RoomDTO GetRoomById(int id)
        {
            var room = GetById(id);
            
            if (room.IsActive == true)
            {
                var roomDto = _mapper.Map<RoomDTO>(room);
                var hotel = _context.Hotels.Find(room.HotelId);
                var bed = _context.BedTypes.Find(room.BedTypeId);
                var roomtype = _context.RoomTypes.Find(room.RoomTypeId);

                roomDto.Hotel = hotel.HotelName;
                roomDto.BedType = bed.BedTypeName;
                roomDto.RoomType = roomtype.RoomTypeName;
                return roomDto;
            }
            else
            {
                return null;
            }


        }

        public override void Create(Room entity)
        {
            var hotel = _context.Hotels.SingleOrDefault(x=>x.HotelName == entity.Hotel.HotelName);
            var room = _context.RoomTypes.SingleOrDefault(x => x.RoomTypeName == entity.RoomType.RoomTypeName);
            var bed = _context.BedTypes.SingleOrDefault(x => x.BedTypeName == entity.BedType.BedTypeName);
            var man = _context.Managers.SingleOrDefault(x => x.FullName == entity.Manager.FullName);
            _context.Rooms.Add(
                new Room()
                {
                    RoomNumber=entity.RoomNumber,
                    HotelId=hotel.HotelId,
                    RoomTypeId=room.RoomTypeID,
                    BedTypeId=bed.BedTypeId,
                    SquareFeet=entity.SquareFeet,
                    ManagerID=man.ManagerID,
                    IsActive=entity.IsActive
                });
            _context.SaveChanges();

            if (entity.RoomAminities.Count > 0)
            {
                _context.RoomAminities.AddRange(entity.RoomAminities);
            }
        }

        public bool Updateroom( Room entity)
        {
            var old = _context.Rooms.Find(entity.RoomId);
            var hotel = _context.Hotels.SingleOrDefault(x => x.HotelName == entity.Hotel.HotelName);
            var room = _context.RoomTypes.SingleOrDefault(x => x.RoomTypeName == entity.RoomType.RoomTypeName);
            var bed = _context.BedTypes.SingleOrDefault(x => x.BedTypeName == entity.BedType.BedTypeName);
            var man = _context.Managers.SingleOrDefault(x => x.FullName == entity.Manager.FullName);


            if (entity != null)
            {
                old.RoomNumber = entity.RoomNumber;
                old.HotelId = hotel.HotelId;
                old.RoomTypeId = room.RoomTypeID;
                old.BedTypeId = bed.BedTypeId;
                old.SquareFeet = entity.SquareFeet;
                old.ManagerID = man.ManagerID;
                old.IsActive = entity.IsActive;
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
            var room = _context.Rooms
                                .Where(x => x.RoomId == id)
                                .SingleOrDefault();
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }
    }
}
