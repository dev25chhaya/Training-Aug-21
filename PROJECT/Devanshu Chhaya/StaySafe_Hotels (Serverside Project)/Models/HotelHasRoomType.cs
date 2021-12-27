using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class HotelHasRoomType
    {
        public int HotelHasRoomTypeId { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoomTypeID { get; set; }
        public RoomType RoomType { get; set; }

    }
}
