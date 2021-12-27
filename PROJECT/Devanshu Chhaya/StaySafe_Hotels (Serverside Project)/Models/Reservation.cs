using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        [Required]
        public Customer Customer { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
