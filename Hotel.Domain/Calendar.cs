using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain
{
    public class Calendar
    {
        public DateTime Date { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
