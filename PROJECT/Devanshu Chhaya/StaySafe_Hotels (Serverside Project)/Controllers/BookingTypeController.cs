using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class BookingTypeController : ControllerBase
    {
        public readonly IBookingType bookings;

        public BookingTypeController(IBookingType context)
        {
            bookings = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookingType>> GetBookingtype()
        {
            return Ok(bookings.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<BookingType> GetBookingtypeID(int id)
        {
            var cust = bookings.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<BookingType> PostBookingtype(BookingType bookingType)
        {
            bookings.Create(bookingType);
            return Ok();
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPut]
        public IActionResult UpdateBookingtype(BookingType bookingType)
        {
            var id = bookingType.BookingTypeId;
            bookings.Update(id, bookingType);
            return Ok();
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpDelete("{id}")]
        public IActionResult DeleteBookingtype(int id)
        {
            bookings.Delete(id);
            return Ok();
        }
    }
}
