using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Hotel
    {
        public Hotel()
        {
            HotelHasHighlights = new HashSet<HotelHasHighlights>();
        }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        
        public long PhoneNumber1 { get; set; }
        
        public long PhoneNumber2 { get; set; }
        [EmailAddress]
        public string EmailID { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int ZipCode { get; set; }
        public string OverView { get; set; }
        public string Image { get; set; }
        public string RailwayStationDistanceInKM { get; set; }
        public string BusStationDistanceInKM { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public ICollection<Owner> Owners { get; set; }
        public ICollection<HotelHasHighlights> HotelHasHighlights { get; set; }
        public ICollection<HotelHasRoomType> HotelHasRoomTypes { get; set; }
    }
}
