using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class City
    {
        public int CityID { get; set; }
        [Required]
        public string Name { get; set; }

        public State State { get; set; }
        [Required]
        public int StateId { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public ICollection<CityInfo> cityInfos { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Owner> Owners { get; set; }
        public ICollection<Manager> Managers { get; set; }
    }
}
