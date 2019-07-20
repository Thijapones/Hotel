using Hotel.Business.Interfaces;
using Hotel.Domain;
using Repository;
using System;
using System.Collections.Generic;

namespace Hotel.Business
{
    public class RoomsBusiness : IRoomsBusiness
    {
        RoomsRepository _roomsRepository;
        public RoomsBusiness()
        {
            _roomsRepository = new RoomsRepository();
        }

        public bool Add(Room room)
        {

            return _roomsRepository.Add(room);
        }

        public List<Room> GetList()
        {
            return _roomsRepository.GetList();
        }
    }
}
