using Hotel.Business;
using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services
{
    public class InsertRooms
    {
        public void InsertRoom(int roomid, int roomtype)
        {
            var roomsbusiness = new RoomsBusiness();
            var roomsservice = new RoomsService(roomsbusiness);

            roomsservice.Insert(new Room { Id = roomid, RoomNumber = "Room_" + roomid, RoomType = roomtype, RoomStatus = 0 });
        }
    }
}
