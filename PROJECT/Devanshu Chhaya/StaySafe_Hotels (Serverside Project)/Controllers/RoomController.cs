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
    public class RoomController : ControllerBase
    {
        private readonly IRoom rooms;

        public RoomController(IRoom context)
        {
            rooms = context;
        }
        //Get: api/StaySafe/City
        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetRooms()
        {
            return Ok(rooms.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Room>> GetRoomById(int id)
        {
            var room = rooms.GetRoomById(id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Room> PostRoom(Room room)
        {
            rooms.Create(room);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult UpdateRoom(Room room)
        {
            if (rooms.Updateroom(room) == true)
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
        public IActionResult DeleteRoom(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid");
            }
            rooms.Delete(id);
            return Ok();
        }


    }
}
