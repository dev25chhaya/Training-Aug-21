using StaySafeHotels.ApplicationDto;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IHotel: IGenericInterface<Hotel>
    {
        IEnumerable<Hotel> getAllHotels();
        HotelDTO GetHotelById(int id);
    }
}
