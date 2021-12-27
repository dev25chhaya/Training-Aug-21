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
    public class RoomTypeController : ControllerBase
    {
        public readonly IRoomType roomType;

        public RoomTypeController(IRoomType context)
        {
            roomType = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<RoomType>> GetRoomtype()
        {
            return Ok(roomType.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<RoomType> GetRoomtypeID(int id)
        {
            var cust = roomType.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public ActionResult<RoomType> PostRoomtype(RoomType roomtype)
        {
            roomType.Create(roomtype);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateRoomtype(RoomType roomtype)
        {
            var id = roomtype.RoomTypeID;
            roomType.Update(id, roomtype);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteRoomtype(int id)
        {
            roomType.Delete(id);
            return Ok();
        }
    }
}
