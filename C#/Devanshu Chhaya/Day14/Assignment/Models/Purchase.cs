using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    public class Purchase
    {
        [Key]
        public Guid PurchaseId { get; set; }

        public Guid ToysId { get; set; }
        public Toys Toys { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }


    }
}
