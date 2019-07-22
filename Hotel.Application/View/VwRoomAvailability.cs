using Hotel.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.View
{
    public class VwRoomAvailability
    {
        public int GetRoomAvy()
        {
            var roomavailability = new RoomAvailability();

            Console.Clear();
            Console.WriteLine("Thank you.\n Now, I will need to know how many rooms of this type are available.\n Please insert the number of rooms available in your hotel for this type.");
            var roomavy = Console.ReadLine();
            int.TryParse(roomavy, out int result);
            var looproomavy = result;

            while (looproomavy == 0)
            {
                Console.WriteLine("Invalid Number. Please insert the number of rooms available in your hotel for this type.");
                roomavy = Console.ReadLine();
                int.TryParse(roomavy, out int result1);
                looproomavy = result1;
            }

            return Convert.ToInt32(roomavy);
        }

        public int GetRoomStdAvy(string stdroomtype)
        {
            Console.Clear();
            Console.WriteLine("Thank you.\n Now, I will need to know how many " + stdroomtype + " rooms are available.\n Please insert the number of rooms available in your hotel for this type.");
            var roomstdavy = Console.ReadLine();
            int.TryParse(roomstdavy, out int result);
            var looproomstdavy = result;

            while (looproomstdavy == 0)
            {
                Console.WriteLine("Invalid Number. Please insert the number of rooms available in your hotel for this type.");
                roomstdavy = Console.ReadLine();
                int.TryParse(roomstdavy, out int result1);
                looproomstdavy = result1;
            }

            return Convert.ToInt32(roomstdavy);
        }
    }
}