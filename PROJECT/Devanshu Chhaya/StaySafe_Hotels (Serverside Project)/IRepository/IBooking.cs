using StaySafeHotels.ApplicationDto;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IBooking: IGenericInterface<Booking>
    {
        BookingDTO GetBookingById(int id);
        bool updateBooking(Booking booking);
    }
}
