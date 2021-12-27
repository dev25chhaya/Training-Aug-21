using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaySafeHotels.ApplicationDto;
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
    public class CityController : ControllerBase
    {
        private readonly ICity cities;

        public CityController(ICity context)
        {
            cities = context;
        }
        //Get: api/StaySafe/City
        [HttpGet]
        public ActionResult<IEnumerable<City>> GetCity()
        {
            return Ok(cities.GetAllCities());
        }

        //Get: api/StaySafe/City/3
        //[Authorize(Roles = UserRoles.Admin)]
        [HttpGet("{id}")]
        
        public ActionResult<CityDto> GetCity(int id)
        {
            var city = cities.GetCityById(id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }


        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public ActionResult<City> PostCity(City city)
        {
            cities.Create(city);
            return Ok();
        }

        //
        [HttpGet("{id}/Hotels")]
        public ActionResult<Hotel> GetHotelByCity(int id)
        {
            var hotel = cities.GetHotelByCityId(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        [HttpGet("state/{id}")]
        public ActionResult<Hotel> GetCityByState(int id)
        {
            var city = cities.GetCitiesByState(id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdateCity(City city)
        {
            if (cities.updateCity(city) == true)
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
        public IActionResult DeleteCity(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid");
            }
            cities.Delete(id);
            return Ok();
        }

    }
}
