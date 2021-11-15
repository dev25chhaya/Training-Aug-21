using System;
using System.Collections.Generic;
using System.Text;

namespace ToysManufacturingCompany.Models
{
    class Address
    {
        public int AddressId { get; set; }
        public string AddressLine { get; set; }

        public string City { get; set; }
        public int Pincode { get; set; }
        public string State { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Order> Orders { get; set; }
        
    }
}
