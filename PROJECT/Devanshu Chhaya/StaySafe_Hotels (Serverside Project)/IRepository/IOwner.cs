using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IOwner: IGenericInterface<Owner>
    {
        bool updateOwnre(Owner owner);
    }
}
