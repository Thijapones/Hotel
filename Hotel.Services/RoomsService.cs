using Hotel.Business;
using Hotel.Business.Interfaces;
using Hotel.Domain;
using System;
using System.Collections.Generic;

namespace Hotel.Services
{
    public class RoomsService
    {
        private readonly RoomsBusiness _roomsBusiness;
        public RoomsService(RoomsBusiness roomsBusiness)
        {
            _roomsBusiness = roomsBusiness;
        }

        public List<Room> Insert(Room room)
        {
            _roomsBusiness.Add(room);

            return _roomsBusiness.GetList();
        }
    }
}
