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
    public class BedTypeController : ControllerBase
    {
        public readonly IBedType beds;

        public BedTypeController(IBedType context)
        {
            beds = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BedType>> GetBedtype()
        {
            return Ok(beds.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<BedType> GetBedtypeID(int id)
        {
            var cust = beds.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<BedType> PostBedtype(BedType bedType)
        {
            beds.Create(bedType);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult UpdateBedtype(BedType bedType)
        {
            var id = bedType.BedTypeId;
            beds.Update(id, bedType);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteBedtype(int id)
        {
            beds.Delete(id);
            return Ok();
        }
    }
}
