using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string UserName { get; set; }
        [EmailAddress]
        public string EamilID { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        
        public ICollection<Reservation> Reservations {get; set;}
    }
}
