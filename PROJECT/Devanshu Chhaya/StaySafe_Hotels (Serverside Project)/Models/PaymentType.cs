using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class PaymentType
    {
        public int PaymentTypeID { get; set; }
        public string PaymentTypeName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
