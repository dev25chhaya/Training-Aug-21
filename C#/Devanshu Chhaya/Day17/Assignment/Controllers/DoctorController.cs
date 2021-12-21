using Healthcare.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Interfaces;

namespace Healthcare.Controllers
{
    
    [ApiController]
    [Authorize]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctor;

        public DoctorController(IDoctorRepository doctor)
        {
            _doctor = doctor;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetDoctors()
        {
            return Ok(_doctor.GetDoctors());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetDoctor(int id)
        {
            var doctor = _doctor.GetDoctor(id);
            if (doctor != null)
            {
                return Ok(doctor);
            }
            return NotFound($"doctor with id {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddDoctor(Doctor doctor)
        {
            _doctor.AddDoctor(doctor);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + doctor.Id, doctor);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditCustomer(int id, Doctor doctor)
        {
            var ExistingDoctor = _doctor.GetDoctor(id);
            if (ExistingDoctor != null)
            {
                doctor.Id = ExistingDoctor.Id;
                _doctor.EditDoctor(doctor);
            }
            return Ok(doctor);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var doctor = _doctor.GetDoctor(id);
            if (doctor != null)
            {
                _doctor.DeleteDoctor(doctor);
                return Ok();
            }
            return NotFound($"Doctor with Id {id} was not found");

        }
    }
}
