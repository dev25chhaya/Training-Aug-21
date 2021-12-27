using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Models
{
    public class Highlights
    {
        public Highlights()
        {
            HotelHasHighlight = new HashSet<HotelHasHighlights>();
        }
        public int HighlightsId { get; set; }

        public string Name { get; set; }
        public ICollection<HotelHasHighlights> HotelHasHighlight { get; set; }
    }
}
