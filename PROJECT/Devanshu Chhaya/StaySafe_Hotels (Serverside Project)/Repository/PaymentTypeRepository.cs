using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class PaymentTypeRepository: GenericRepository<PaymentType>,IPaymentType
    {
        public PaymentTypeRepository(StaySafeDBContext context) : base(context)
        {

        }
        public override void Delete(int id)
        {
            var paymentType = _context.PaymentTypes
                                .Where(x => x.PaymentTypeID == id)
                                .SingleOrDefault();
            _context.PaymentTypes.Remove(paymentType);
            _context.SaveChanges();
        }
    }
}
