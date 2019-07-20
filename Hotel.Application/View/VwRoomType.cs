using Hotel.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.View
{
    public class VwRoomType
    {
        public string GetRoomType()
        {
            var roomtypeBusiness = new RoomTypeBusiness();
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
                return answer;
            }

            while (answer.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("Please provide a room type.\n Currently registered types:");
                roomtypeBusiness.GetList();
                var newtype = Console.ReadLine();
                roomprice.GetRoomPrice();

                Console.WriteLine("Would you like to register a new Room Type? (y/n)");

                while (answer.ToLower() != "n" && answer.ToLower() != "y")
                {
                    Console.WriteLine("Invalid option.\n Would you like to register a new Room Type? (y/n)");
                    answer = Console.ReadLine();
                }
            }

            return Convert.ToInt32(roomqty);
        }
    }
}
