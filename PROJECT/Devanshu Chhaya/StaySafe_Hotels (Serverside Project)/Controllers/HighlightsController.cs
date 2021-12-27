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
    public class HighlightsController : ControllerBase
    {
        public readonly IHighlights highlight;

        public HighlightsController(IHighlights context)
        {
            highlight = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Highlights>> GetHighlights ()
        {
            return Ok(highlight.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<Highlights> GetHighlightsbyID(int id)
        {
            var cust = highlight.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public ActionResult<Highlights> PostHighlights (Highlights highlights)
        {
            highlight.Create(highlights);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult UpdateHighlights(Highlights highlights)
        {
            var id = highlights.HighlightsId;
            highlight.Update(id, highlights);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult DeleteBookingtype(int id)
        {
            highlight.Delete(id);
            return Ok();
        }
    }
}
