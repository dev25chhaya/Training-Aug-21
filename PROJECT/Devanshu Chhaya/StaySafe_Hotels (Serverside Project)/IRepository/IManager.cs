using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IManager:IGenericInterface<Manager>
    {
       bool updateMan(Manager managnager);
    }
}
