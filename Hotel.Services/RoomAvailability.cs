using Hotel.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Services
{
    public class RoomAvailability
    {
        public void SetTypeAvailability(int roomtype, int nr_available)
        {
            var roomsbusiness = new RoomsBusiness();

            var getrooms = roomsbusiness.GetList().Where((a) => a.RoomType == roomtype).Take(nr_available).ToList();

            return;
        }
    }
}
