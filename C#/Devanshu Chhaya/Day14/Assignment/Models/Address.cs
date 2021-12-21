using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ToysCompany.Models;

namespace ToysManufacturingCompany.Models
{
    public class Address
    {
        [Key]
        public Guid AddressId { get; set; }
        public string AddressLine { get; set; }

        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Order> Orders { get; set; }
        
    }
}
