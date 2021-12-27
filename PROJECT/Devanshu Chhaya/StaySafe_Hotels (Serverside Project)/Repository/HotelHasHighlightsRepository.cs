using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class HotelHasHighlightsRepository: GenericRepository<HotelHasHighlights>, IHotelHasHighlights
    {
        public HotelHasHighlightsRepository(StaySafeDBContext context): base(context)
        {

        }
    }
}
