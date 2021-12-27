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
    public class ManagerController : ControllerBase
    {
        public readonly IManager managers;

        public ManagerController(IManager context)
        {
            managers = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Manager>> GetManager()
        {
            return Ok(managers.GetAll());
        }

        
        [HttpGet("{id}")]
        public ActionResult<Manager> GetManagerByID(int id)
        {
            var cust = managers.GetById(id);
            if (cust == null)
            {
                return NotFound();
            }
            return Ok(cust);
        }

        [HttpPost]
        public ActionResult<Manager> PostManager(Manager manager)
        {
            managers.Create(manager);
            return Ok();
        }

        public IActionResult updateManager(Manager manager)
        {
            if (managers.updateMan(manager) == true)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteManager(int id)
        {
            managers.Delete(id);
            return Ok();
        }
    }
}
