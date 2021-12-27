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
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController : ControllerBase
    {
        public readonly IPaymentType payments;

        public PaymentTypeController(IPaymentType context)
        {
            payments = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PaymentType>> GetPymenttype()
        {
            return Ok(payments.GetAll());
        }

        //Get: api/StaySafe/hotel/3
        [HttpGet("{id}")]
        public ActionResult<PaymentType> GetPaymenttypeByID(int id)
        {
            var payment = payments.GetById(id);
            if(payment == null)
            {
                return NotFound();
            }
            return Ok(payment);
        }

        [HttpPost]
        [Authorize(Roles = UserRoles.Admin)]

        public ActionResult<PaymentType> PostPaymenttype(PaymentType paymentType)
        {
            payments.Create(paymentType);
            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult UpdatePaymenttype(PaymentType paymentType)
        {
            var id = paymentType.PaymentTypeID;
            payments.Update(id, paymentType);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = UserRoles.Admin)]

        public IActionResult DeletePaymenttype(int id)
        {
            payments.Delete(id);
            return Ok();
        }
    }
}
