using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Booking
    {
        [Key]
        public int BookigID { get; set; }
        [Required]
        public int ReservationID { get; set; }
        public Reservation Reservation { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        [Required]
        public int BookingTypeId { get; set; }
        public BookingType BookingType { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int PaymentTypeID { get; set; }
        public PaymentType PaymentType { get; set; } 
        public int TotalNoOfGuest { get; set; }
        public bool IsActive { get; set; }

    }
}
