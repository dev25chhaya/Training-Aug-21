using Assignment.Models;
using Assignment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controller
{

    [ApiController]
    public class empsController : ControllerBase
    {
        private readonly IEmployeeRepository _employee;

        public empsController(IEmployeeRepository employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("api/[controller]")]      
        public IActionResult GetEmployees()
        {
            return Ok(_employee.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = _employee.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Customer with id {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employee.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.EMployeeID, employee);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(int id, Employee employee)
        {
            var ExistingEmployee = _employee.GetEmployee(id);
            if (ExistingEmployee != null)
            {
                employee.EMployeeID = ExistingEmployee.EMployeeID;
                _employee.EditEmployee(employee);
            }
            return Ok(employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employee.GetEmployee(id);
            if (employee != null)
            {
                _employee.DeleteEmployee(employee);
                return Ok();
            }
            return NotFound($"Employee with Id {id} was not found");

        }
    }
}
