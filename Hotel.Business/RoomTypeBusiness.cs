using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Repository;

namespace Hotel.Business
{
    public class RoomTypeBusiness
    {
        RoomTypeRepository _roomtypeRepository;

        public RoomTypeBusiness()
        {
            _roomtypeRepository = new RoomTypeRepository();
        }

        public bool Add(RoomType roomtype)
        {
            return _roomtypeRepository.Add(roomtype);
        }

        public List<RoomType> GetList()
        {
            return _roomtypeRepository.GetList();
        }
    }
}
