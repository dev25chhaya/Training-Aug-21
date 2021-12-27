using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public string OwnerFullName { get; set; }
        [EmailAddress]
        public string EmailID { get; set; }
        
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
       
        public int CityID { get; set; }
        public City City { get; set; }
        public int Zipcode { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Manager> Managers { get; set; }
    }
}
