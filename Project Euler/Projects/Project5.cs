using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Projects
{
    //----------------------------------------------------------------COMPLETE--------------------------------------------------------------------------------------

    //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

    public class Project5
    {
        Project5() { }

        public static void Solution()
        {
            bool x = true;
            int counter = 1;
            while (x == true)
            {
                if (counter % 20 == 0 && counter % 19 == 0 && counter % 18 == 0 && counter % 17 == 0 && counter % 16 == 0 &&
                    counter % 15 == 0 && counter % 14 == 0 && counter % 13 == 0 && counter % 12 == 0 && counter % 11 == 0)
                {
                    Console.WriteLine(counter);
                    break;
                }
                counter++;
            }
        }

    }
}
// 20 -> 10 & 5
// 19
// 18 -> 9, 3, 2, 6
// 17
// 16 -> 8, 4, 2
// 15
// 14 -> 7
// 13
// 12
// 11