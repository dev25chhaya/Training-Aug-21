using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class RoomTypeRepository: GenericRepository<RoomType>,IRoomType
    {
        public RoomTypeRepository(StaySafeDBContext context) : base(context)
        {

        }

        public override void Delete(int id)
        {
            var roomTypes = _context.RoomTypes
                                .Where(x => x.RoomTypeID == id)
                                .SingleOrDefault();
            _context.RoomTypes.Remove(roomTypes);
            _context.SaveChanges();
        }
    }
}
