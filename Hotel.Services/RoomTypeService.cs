using Hotel.Business;
using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services
{
    public class RoomTypeService
    {
        private readonly RoomTypeBusiness _roomtypeBusiness;
        public RoomTypeService(RoomTypeBusiness roomtypeBusiness)
        {
            _roomtypeBusiness = roomtypeBusiness;
        }

        public List<RoomType> Insert(RoomType roomtype)
        {
            _roomtypeBusiness.Add(roomtype);

            return _roomtypeBusiness.GetList();
        }
    }
    }
}
