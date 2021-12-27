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
    public class StateController : ControllerBase
    {
        private readonly IState state;

        public StateController(IState context)
        {
            state = context;
        }

        //Get: api/StaySafe/States
        [HttpGet]
        public ActionResult<IEnumerable<State>> GetStates()
        {
            return Ok(state.GetAll());
        }

        //Get: api/StaySafe/States/3
        [HttpGet("{id}")]
        public ActionResult<State> GetState(int id)
        {
            var states = state.GetById(id);
            if (states == null)
            {
                return NotFound();
            }
            return Ok(states);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]
        public ActionResult<State> PostState(State states)
        {
            state.Create(states);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]
        public IActionResult UpdateState(State states)
        {
            if (state.updateState(states) == true)
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
        public IActionResult DeleteState(int id)
        {
            state.Delete(id);
            return Ok();
        }
    }
}
