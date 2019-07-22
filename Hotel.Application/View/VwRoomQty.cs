using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.View
{
    public class VwRoomQty
    {
        public int GetRoomQty()
        {
            Console.WriteLine("Please insert the number of existing rooms of this type in your hotel.");
            var roomqty = Console.ReadLine();
            int.TryParse(roomqty, out int result);
            var looproomqty = result;

            while (looproomqty == 0)
            {
                Console.WriteLine("Invalid Number. Please insert the number of existing rooms of this type in your hotel.");
                roomqty = Console.ReadLine();
                int.TryParse(roomqty, out int result1);
                looproomqty = result1;
            }

            return Convert.ToInt32(roomqty);
        }
    }
}