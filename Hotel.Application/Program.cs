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

            var roomqty = new RoomQty();
            var qtyrooms = roomqty.GetRoomQty();

            int id = 1;

            while (id != qtyrooms)
            {
                roomsService.Insert(new Room { Id = id, RoomNumber = "Room_"+id, RoomStatus = false });
                id = id + 1;
            }


            var roomtype = roomtypeService.Insert(new RoomType
            {
                Type = "Single",
                Price = Domain.ValueObj.Price.Single
            }            );

            Console.WriteLine($"{alunos.Any()} {alunos.Count()} {alunos[0].Nome}");
            Console.WriteLine($"{turmas.Any()} {turmas.Count()} {turmas[0].Numero}");
        }
    }
}
