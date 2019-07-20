using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.View
{
    public class VwRoomQty
    {
        public int GetRoomQty()
        {
            Console.WriteLine("Welcome to your Hotel Application powered by FiveStars.\n Please insert the number of rooms existing in your hotel.");
            var roomqty = Console.ReadLine();
            int.TryParse(roomqty, out int result);
            var looproomqty = result;

            while (looproomqty == 0)
            {
                Console.WriteLine("Invalid Number. Please insert the number of rooms existing in your hotel.");
                roomqty = Console.ReadLine();
                int.TryParse(roomqty, out int result1);
                looproomqty = result1;
            }

            return Convert.ToInt32(roomqty);
        }
    }
}