using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class ReservationRepository: GenericRepository<Reservation>,IReservation
    {
        public ReservationRepository(StaySafeDBContext context) : base(context)
        {

        }

        public override void Delete(int id)
        {
            var reservations = _context.Reservations
                                .Where(x => x.ReservationID == id)
                                .SingleOrDefault();
            _context.Reservations.Remove(reservations);
            _context.SaveChanges();
        }
    }
}
