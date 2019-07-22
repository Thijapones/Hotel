using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public int RoomType { get; set; }
        public int RoomStatus { get; set; }
    }
}
