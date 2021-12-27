using StaySafeHotels.IRepository;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.Repository
{
    public class BedTypeRepository: GenericRepository<BedType>, IBedType
    {
        public BedTypeRepository(StaySafeDBContext context) : base(context)
        {

        }
        public override void Delete(int id)
        {
            var bedType = _context.BedTypes
                                .Where(x => x.BedTypeId == id)
                                .SingleOrDefault();
            _context.BedTypes.Remove(bedType);
            _context.SaveChanges();
        }
    }
}
