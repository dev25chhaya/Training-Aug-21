using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.ApplicationDto
{
    public class HotelDTO
    {
        public string HotelName { get; set; }
        public long PhoneNumber1 { get; set; }

        public long PhoneNumber2 { get; set; }
        [EmailAddress]
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string[] RoomTypes { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Owner { get; set; }
        public string OverView { get; set; }
        public string Image { get; set; }
        public string RailwayStationDistanceInKM { get; set; }
        public string BusStationDistanceInKM { get; set; }
        public bool IsActive { get; set; }
    }
}
