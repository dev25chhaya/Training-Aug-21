using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class HighlightsRepository: GenericRepository<Highlights>, IHighlights
    {
        public HighlightsRepository(StaySafeDBContext context): base(context)
        {

        }

        public override void Delete(int id)
        {
            var highlights = _context.Highlights
                                .Where(x => x.HighlightsId == id)
                                .SingleOrDefault();
            _context.Highlights.Remove(highlights);
            _context.SaveChanges();
        }
    }
}
