using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToysCompany.Interfaces;
using ToysCompany.Models;

namespace ToysCompany.Controllers
{
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customer;

        public CustomersController(ICustomerRepository customer)
        {
            _customer = customer;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(_customer.GetCustomers());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCustomer(Guid id)
        {
            var customer = _customer.GetCustomer(id);
            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound($"Customer with id {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCustomer(Customer customer)
        {
            _customer.AddCustomer(customer);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + customer.CustomerID, customer);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult EditCustomer(Guid id, Customer customer)
        {
            var ExistingCustomer = _customer.GetCustomer(id);
            if (ExistingCustomer != null)
            {
                customer.CustomerID = ExistingCustomer.CustomerID;
                _customer.EditCustomer(customer);
            }
            return Ok(customer);

        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var customer = _customer.GetCustomer(id);
            if (customer != null)
            {
                _customer.DeleteCustomer(customer);
                return Ok();
            }
            return NotFound($"Employee with Id {id} was not found");

        }

    }
}
