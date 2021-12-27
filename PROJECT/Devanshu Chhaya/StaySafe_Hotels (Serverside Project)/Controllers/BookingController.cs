using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaySafeHotels.ApplicationDto;
using StaySafeHotels.Authentication;
using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBooking bookings;

        public BookingController(IBooking context)
        {
            bookings = context;
        }

        [HttpGet]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<IEnumerable<Booking>> GetBookings()
        {
            return Ok(bookings.GetAll());
        }

        [HttpGet("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<BookingDTO> GetbyId(int id)
        {
            var booking = bookings.GetBookingById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.User)]
        public ActionResult<Booking> PostBooking(Booking booking)
        {
            bookings.Create(booking);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult UpdateBooking(Booking booking)
        {
            var id = booking.BookigID;
            if (bookings.updateBooking(booking) == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteBooking(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid");
            }
            bookings.Delete(id);
            return Ok();
        }
    }
}
