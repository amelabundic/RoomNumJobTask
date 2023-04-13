using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomNumber
{
    public class RangeOfRoomNumbers
    {
        public bool InRange(int roomNumber)
        {
            if (roomNumber < 1 || roomNumber > 1000000)
            {
                return false;
            }
            return true;
        }
    }
}
