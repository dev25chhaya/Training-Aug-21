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
    public class AminityController : ControllerBase
    {
        public readonly IAminity aminities;

        public AminityController(IAminity context)
        {
            aminities = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Aminity>> GetAminities()
        {
            return Ok(aminities.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<Aminity> GetAminitybyID(int id)
        {
            var cust = aminities.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<Aminity> PostAminity(Aminity aminity)
        {
            aminities.Create(aminity);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult Update(Aminity aminity)
        {
            var id = aminity.AminityId;
            aminities.Update(id, aminity);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteAminity(int id)
        {
            aminities.Delete(id);
            return Ok();
        }
    }
}
