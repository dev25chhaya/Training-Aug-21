using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        
        public int TotalAmount { get; set; }

        public int TotalDiscount { get; set; }

        public int NetAmount { get; set; }


        

        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public ICollection<Purchase> Purchase { get; set; }

    }
}
