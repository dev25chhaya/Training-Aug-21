using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class AminityRepository: GenericRepository<Aminity>,IAminity
    {
        public AminityRepository(StaySafeDBContext context): base(context)
        {

        }
        public override void Delete(int id)
        {
            var aminity = _context.Aminities
                                .Where(x => x.AminityId == id)
                                .SingleOrDefault();
            _context.Aminities.Remove(aminity);
            _context.SaveChanges();
        }
    }
}
