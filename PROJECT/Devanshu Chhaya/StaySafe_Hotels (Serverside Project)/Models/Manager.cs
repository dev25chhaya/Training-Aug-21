using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public int OwnerID { get; set; }
        public Owner Owner { get; set; }
        public string FullName { get; set; }
        [EmailAddress]
        public string EmailID { get; set; }
        
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        [Required]
        public int CityID { get; set; }
        public City City { get; set; }
        public int ZipCode { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
