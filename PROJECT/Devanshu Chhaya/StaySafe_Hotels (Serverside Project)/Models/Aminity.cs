using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Aminity
    {
        public int AminityId { get; set; }
        [Required(ErrorMessage ="This filed is required")]
        public string AminintyName { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public ICollection<RoomAminity> RoomAminities { get; set; }
    }
}
