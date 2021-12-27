using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class BedType
    {
        public int BedTypeId { get; set; }
        public string BedTypeName { get; set; }
        public int BedCapacity { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
