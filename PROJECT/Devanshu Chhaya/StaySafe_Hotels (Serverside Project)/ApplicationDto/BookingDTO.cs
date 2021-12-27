using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.ApplicationDto
{
    public class BookingDTO
    {
        public int BookigID { get; set; }
        public int ReservationID { get; set; }
        public int CustomerId { get; set; }
        public int Room { get; set; }
        public string Hotel { get; set; }
        public string BookingType { get; set; }
        public string PaymetType { get; set; }
        public int PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

    }
}
