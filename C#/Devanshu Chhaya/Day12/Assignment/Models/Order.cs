using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class Order
    {
        public int OrderId { get; set; }
        
        public int TotalAmount { get; set; }

        public int TotalDiscount { get; set; }

        public int NetAmount { get; set; }


        

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Purchase> Purchase { get; set; }

    }
}
