using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class HotelHasHighlights
    {
        public int HotelHasHighlightsID { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int HighlightsId { get; set; }
        public Highlights Highlights { get; set; }
    }
}
