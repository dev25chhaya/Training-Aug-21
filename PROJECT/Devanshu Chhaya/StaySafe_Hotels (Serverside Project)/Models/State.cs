using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class State
    {
        public int StateID { get; set; }
        [Required]
        public string StateName { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public ICollection<City> Cities { get; set; }

    }
}
