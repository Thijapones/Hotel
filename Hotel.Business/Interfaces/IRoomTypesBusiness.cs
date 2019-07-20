using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Domain;

namespace Hotel.Business.Interfaces
{
    public interface IRoomTypesBusiness
    {
        bool Add(RoomType roomtype);

        List<RoomType> GetList();
    }
}
