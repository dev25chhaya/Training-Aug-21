using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class RoomType
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public int RatePerNight { get; set; }
        public int RatePerNightWithBreakfast { get; set; }
        public string RoomInformation { get; set; }
        public string CancellationPolicy { get; set; }
        public string MaximumCapacity { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<HotelHasRoomType> HotelHasRoomTypes { get; set; }
    }
}
