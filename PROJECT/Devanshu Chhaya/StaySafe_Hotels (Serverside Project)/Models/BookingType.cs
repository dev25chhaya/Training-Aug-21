using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class BookingType
    {
        public int BookingTypeId { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
