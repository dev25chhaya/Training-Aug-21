using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Interfaces;
using ToysManufacturingCompany.Models;

namespace ToysCompany.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _toy;

        public ProductController(IProductRepository toy)
        {
            _toy = toy;
        }

        [HttpGet]
        
        public IActionResult GetToys()
        {
            return Ok(_toy.GetToys());
        }

        [HttpGet]
        public IActionResult GetToy(Guid id)
        {
            var toy = _toy.GetToy(id);
            if (toy != null)
            {
                return Ok(toy);
            }
            return NotFound($"Not Found");
        }

        [HttpPost]
        public IActionResult AddToy(Toys toy)
        {
            return Ok(_toy.AddToy(toy));
        }

        [HttpPatch]
        public IActionResult EditToy(Guid id, Toys toy)
        {
            var ExistingToy = _toy.GetToy(id);
            
            if (ExistingToy != null)
            {
                ExistingToy.Name = toy.Name;
                _toy.EditToy(toy);
            }
            return Ok(toy);

        }

        [HttpDelete]
        public IActionResult DeleteToy(Guid id)
        {
            var toy = _toy.GetToy(id);
            if (toy != null)
            {
                _toy.DeleteToy(toy);
                return Ok();
            }
            return NotFound($"Not found");

        }
    }
}
