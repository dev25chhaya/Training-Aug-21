using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class RoomAminity
    {
        public int RoomAminityID { get; set; }
        [Required]
        public Room Room { get; set; }
        [Required]
        public Aminity Aminity { get; set; }
    }
}
