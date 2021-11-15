using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class Purchase
    {
        public int PurchaseId { get; set; }

        public int ToysId { get; set; }
        public Toys Toys { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }


    }
}
