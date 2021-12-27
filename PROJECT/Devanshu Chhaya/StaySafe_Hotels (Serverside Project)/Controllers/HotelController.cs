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
    [Route("api/StaySafe/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        public readonly IHotel hotels;

        protected readonly StaySafeDBContext _context;

        
        public HotelController(IHotel context, StaySafeDBContext con)
        {
            hotels = context;
            _context = con;
        }
        
        //get: api/StaySafe/hotel
        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> GetHotel()
        {
            return Ok(hotels.getAllHotels());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            var hotel = hotels.GetHotelById(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        public ActionResult<Hotel> PostHotel(Hotel hotel)
        {
            hotels.Create(hotel);
            //_context.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpPut("{id}")]
        public IActionResult update(int id, Hotel hotel)
        {
            hotels.Update(id, hotel);
            return Ok();
        }

        [Authorize(Roles = UserRoles.Admin)]
        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            hotels.Delete(id);
            return Ok();
        }
    }
}
