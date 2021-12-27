using StaySafeHotels.ApplicationDto;
using StaySafeHotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaySafeHotels.IRepository
{
    public interface IRoom: IGenericInterface<Room>
    {
        bool Updateroom(Room entity);
        RoomDTO GetRoomById(int id);
    }
}
