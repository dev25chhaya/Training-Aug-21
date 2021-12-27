using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.ApplicationDto
{
    public class RoomDTO
    {
        public int RoomNumber { get; set; }
        public string Hotel { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }
        public int squareFeet { get; set; }
        public string Manager { get; set; }
    }
}
