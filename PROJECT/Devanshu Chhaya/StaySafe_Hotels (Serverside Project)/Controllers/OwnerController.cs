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
    [Authorize(Roles = UserRoles.Admin)]
    [Route("api/StaySafe/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {

        public readonly IOwner owners;

        public OwnerController(IOwner context)
        {
            owners = context;
        }

        //get: api/StaySafe/hotel
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> GetOwner()
        {
            return Ok(owners.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<Owner> GetOwnerByID(int id)
        {
            var cust = owners.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        public ActionResult<Owner> PostOwner(Owner owner)
        {
            owners.Create(owner);
            return Ok();
        }

        [HttpPut]
        public IActionResult updateOwner(Owner owner)
        {
            if (owners.updateOwnre(owner) == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOwner(int id)
        {
            owners.Delete(id);
            return Ok();
        }
    }
}
