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
    public class BookingRepository: GenericRepository<Booking>,IBooking
    {
        private readonly IMapper _mapper;

        public BookingRepository(StaySafeDBContext context,IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        //public IEnumerable<CityDto> GetAllCities()
        //{
        //    var city = _context.Cities.Select(x => new CityDto()
        //    {
        //        CityID = x.CityID,
        //        Name = x.Name,
        //        State = _context.States.SingleOrDefault(y => y.StateID == x.StateId).StateName
        //    });
        //    return city;

        //}

        public BookingDTO GetBookingById(int id)
        {
            var booking = GetById(id);
            var book = _mapper.Map<BookingDTO>(booking);
            var res = _context.Reservations.Find(booking.ReservationID);
            var room = _context.Rooms.Find(booking.RoomId);
            var hotel = _context.Hotels.Where(x=>x.HotelId==booking.Room.HotelId).FirstOrDefault();
            var bookingType = _context.BookingTypes.Find(booking.BookingTypeId);
            var paymentType = _context.PaymentTypes.Find(booking.PaymentTypeID);

            book.Room = room.RoomId;
            book.ReservationID = res.ReservationID;
            book.CustomerId = res.Customer.CustomerID;
            book.Hotel = hotel.HotelName;
            book.BookingType = bookingType.Type;
            book.PaymetType = paymentType.PaymentTypeName;
            return book;
            
        }

        public bool updateBooking(Booking booking)
        {
            var old = _context.Bookings.Find(booking.BookigID);
            if (old != null)
            {
                old.ReservationID = booking.ReservationID;
                old.RoomId = booking.RoomId;
                old.BookingTypeId = booking.BookingTypeId;
                old.PhoneNumber = booking.PhoneNumber;
                old.EmailId = booking.EmailId;
                old.CheckInDate = booking.CheckInDate;
                old.CheckOutDate = booking.CheckOutDate;
                old.PaymentTypeID = booking.PaymentTypeID;
                old.TotalNoOfGuest = booking.TotalNoOfGuest;
                old.IsActive = booking.IsActive;
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
            var booking = _context.Bookings
                                .Where(x => x.BookingTypeId == id)
                                .SingleOrDefault();
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
        }
    }
}
