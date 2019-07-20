using Hotel.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain
{
    public class RoomType
    {
        public int RTID { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
