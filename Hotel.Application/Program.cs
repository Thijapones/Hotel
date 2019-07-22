using Hotel.Application.View;
using Hotel.Business;
using Hotel.Domain;
using Hotel.Services;
using System;
using System.Collections.Generic;

namespace Hotel.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var roomsBusiness = new RoomsBusiness();
            var roomtypeBusiness = new RoomTypeBusiness();

            var roomsService = new RoomsService(roomsBusiness);
            var roomtypeService = new RoomTypeService(roomtypeBusiness);

            var roomqty = new VwRoomQty();
            var qtyrooms = roomqty.GetRoomQty();

            int id = 1;

            while (id != qtyrooms)
            {
                roomsService.Insert(new Room { Id = id, RoomNumber = "Room_"+id, RoomType = 0, RoomStatus = 0 });
                id = id + 1;
            }



        }
    }
}
