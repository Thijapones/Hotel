using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.View
{
    public class VwRoomPrice
    {
        public double GetRoomPrice()
        {
            Console.WriteLine("Please set the daily price to be charged for this type of room. (e.g. 123.45)");
            var roomprice = Console.ReadLine();
            double.TryParse(roomprice, out double result);
            var looproomprice = result;

            while (looproomprice == 0)
            {
                Console.WriteLine("Invalid Number. Please set the daily price to be charged for this type of room. (e.g. 123.45)");
                roomprice = Console.ReadLine();
                double.TryParse(roomprice, out double result1);
                looproomprice = result1;
            }

            return Convert.ToDouble(roomprice);
        }
    }
}
