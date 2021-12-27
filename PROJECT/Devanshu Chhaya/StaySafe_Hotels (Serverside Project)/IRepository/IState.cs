using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IState: IGenericInterface<State>
    {
        public bool updateState(State states);
    }
}
