using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        [Required]
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        [Required]
        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
        [Required]
        public int BedTypeId { get; set; }
        public BedType BedType { get; set; }
        public int SquareFeet { get; set; }
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }
        public bool IsActive { get; set; }

        public ICollection<RoomAminity> RoomAminities { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
