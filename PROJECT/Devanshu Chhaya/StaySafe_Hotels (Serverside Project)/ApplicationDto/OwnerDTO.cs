using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.ApplicationDto
{
    public class OwnerDTO
    {
        public string OwnerFullName { get; set; }
        public string Hotel { get; set; }
        public string EmailID { get; set; }

        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public bool IsActive { get; set; }
    }
}
