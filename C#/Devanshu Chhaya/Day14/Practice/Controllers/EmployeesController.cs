using ApiHTTPMethods.EmployeeData;
using ApiHTTPMethods.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHTTPMethods.Controllers
{
   
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeedata;
        public EmployeesController(IEmployeeData employeeData)
        {
            _employeedata = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeedata.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployees(Guid id)
        {
            var employee = _employeedata.GetEmployee(id);
            if(employee!= null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetEmployee(Employee employee)
        {
            _employeedata.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id,
                employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _employeedata.GetEmployee(id);
            if (employee != null)
            {
                _employeedata.DeleteEmployee(employee);
                return Ok();
            }
            return NotFound($"Employee with Id {id} was not found");

        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(Guid id, Employee employee)
        {
            var existingEmployee = _employeedata.GetEmployee(id);
            if(existingEmployee!= null)
            {
                employee.Id = existingEmployee.Id;
                _employeedata.EditEmployee(employee);
            }
            return Ok(employee);
        }
    }
}
