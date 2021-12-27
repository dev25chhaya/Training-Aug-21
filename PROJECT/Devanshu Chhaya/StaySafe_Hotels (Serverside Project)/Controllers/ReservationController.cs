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
    public class ReservationController : ControllerBase
    {
        public readonly IReservation reservations;

        public ReservationController(IReservation context)
        {
            reservations = context;
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        public ActionResult<IEnumerable<Reservation>> GetBookingtype()
        {
            return Ok(reservations.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet("{id}")]
        public ActionResult<Reservation> GetReservationByID(int id)
        {
            var res = reservations.GetById(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.User)]

        public ActionResult<Reservation> PostReservation(Reservation reservation)
        {
            reservations.Create(reservation);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateReservation(Reservation reservation)
        {
            var id = reservation.ReservationID;
            reservations.Update(id, reservation);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeleteReservation(int id)
        {
            reservations.Delete(id);
            return Ok();
        }
    }
}
