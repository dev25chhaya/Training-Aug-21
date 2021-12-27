using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class CustomerController : ControllerBase
    {
        public readonly ICustomer customers;

        public CustomerController(ICustomer context)
        {
            customers = context;
        }

        //get: api/StaySafe/hotel
        //    [HttpGet]
        //    public ActionResult<IEnumerable<Customer>> GetCustomer()
        //    {
        //        return Ok(customers.GetAll());
        //    }

        //    //Get: api/StaySafe/hotel/3
        //    [HttpGet("{id}")]
        //    public ActionResult<Customer> GetCustomerByID(int id)
        //    {
        //        var cust = customers.GetById(id);
        //        if (cust == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(cust);
        //    }

        //    [HttpPost]
        //    public ActionResult<Customer> PostCustomer(Customer customer)
        //    {
        //        customers.Create(customer);
        //        return Ok();
        //    }

        //    [HttpPut]
        //    public IActionResult UpdateCustomer(Customer customer)
        //    {
        //        if (customers.updateCustomer(customer) == true)
        //        {
        //            return Ok();
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }
        //    }

        //    [HttpDelete("{id}")]
        //    public IActionResult DeleteCustomer(int id)
        //    {
        //        customers.Delete(id);
        //        return Ok();
        //    }
        //}
    }
}
