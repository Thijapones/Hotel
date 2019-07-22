using Hotel.Business;
using Hotel.Domain;
using Hotel.Services;
using System;
using System.Linq;

namespace Hotel.Application.View
{
    public class VwRoomType
    {
        public void GetRoomType()
        {
            var roomtypeBusiness = new RoomTypeBusiness();
            var roomtypeservice = new RoomTypeService(roomtypeBusiness);
            var roomavy = new VwRoomAvailability();
            var roomprice = new VwRoomPrice();

            Console.WriteLine("Welcome to your Hotel Application powered by FiveStars.\n Would you like to create Room Types for you Hotel? (y/n)\n" +
                "Select n to use the default settings: Single, Standard, Luxury");
            var answer = Console.ReadLine();

            while (answer.ToLower() != "n" && answer.ToLower() != "y")
            {
                Console.Clear();
                Console.WriteLine("Invalid Option.\n Would you like to create Room Types for you Hotel? (y/n)\n" +
                "Select n to use the default settings: Single, Standard, Luxury");
                answer = Console.ReadLine();
            }

            if (answer.ToLower() == "n")
            {
                roomtypeservice.Insertstd(new RoomType
                {
                    RTID = 1,
                    Type = "Single",
                    Price = Convert.ToDouble(Business.ValueObj.ObjRoomTypes.Single)
                }, new RoomType
                {
                    RTID = 2,
                    Type = "Standard",
                    Price = Convert.ToDouble(Business.ValueObj.ObjRoomTypes.Standard)
                }, new RoomType
                {
                    RTID = 3,
                    Type = "Luxury",
                    Price = Convert.ToDouble(Business.ValueObj.ObjRoomTypes.Luxury)
                });
            }

            while (answer.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("Please provide a room type.\n Currently registered types:");
                roomtypeBusiness.GetList();
                var newrtid = 1;
                var newtype = Console.ReadLine();
                var newprice = roomprice.GetRoomPrice();

                roomtypeservice.Insert(new RoomType
                {
                    RTID = newrtid,
                    Type = newtype,
                    Price = newprice
                });

                var newavy = roomavy.GetRoomAvy();


                               
                newrtid = newrtid + 1;

                Console.WriteLine("Would you like to register a new Room Type? (y/n)");

                while (answer.ToLower() != "n" && answer.ToLower() != "y")
                {
                    Console.WriteLine("Invalid option.\n Would you like to register a new Room Type? (y/n)");
                    answer = Console.ReadLine();
                }
            }

            return;
        }
    }
}
