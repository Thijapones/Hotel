using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IRoomsBusiness
    {
        bool Add(Room room);

        List<Room> GetList();
    }
}
