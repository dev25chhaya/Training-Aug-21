using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class BookingTypeRepository:GenericRepository<BookingType>,IBookingType
    {
        public BookingTypeRepository(StaySafeDBContext context) : base(context)
        {

        }
        public override void Delete(int id)
        {
            var bookintype = _context.BookingTypes
                                .Where(x => x.BookingTypeId == id)
                                .SingleOrDefault();
            _context.BookingTypes.Remove(bookintype);
            _context.SaveChanges();
        }
    }
}
