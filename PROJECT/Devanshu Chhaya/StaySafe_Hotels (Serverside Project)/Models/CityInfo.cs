using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class CityInfo
    {
        public int CityInfoId { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        public string BestTimeToVisit { get; set; }

        [Required]
        public string HowToReach { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
