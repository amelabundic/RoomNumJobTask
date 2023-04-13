using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomNumber
{
    public class RoomNumber
    {
        //Implement one or more unit-tests to check your solution --- I have not done this because  
        //I've never really done a Unit test.

        RangeOfRoomNumbers rangeOfRoomNumbers = new RangeOfRoomNumbers();
        public int numberOfSets(int roomNumber)
        {
            if (!rangeOfRoomNumbers.InRange(roomNumber))
            {
                return 0;
            }

            int[] digits = new int[10];

            while (roomNumber > 0)
            {
                digits[roomNumber % 10]++;
                roomNumber /= 10;
            }

            int result = (int)Math.Ceiling((digits[6] + digits[9]) / 2.0);

            for (int i = 0; i < 10; i++)
            {
                if (i == 6 || i == 9)
                {
                    continue;
                }
                result = Math.Max(result, digits[i]);
            }
            return result;

        }
    }
}
