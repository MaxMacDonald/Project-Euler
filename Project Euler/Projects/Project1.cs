using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Projects
{
    //----------------------------------------------------------------COMPLETE--------------------------------------------------------------------------------------

    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    //Find the sum of all the multiples of 3 or 5 below 1000.

    public class Project1
    {
        Project1() { }

        public static void Solution()
        {
            double[] numList = new double[1000];
            double total = 0;
            for (int i = 0; i < 1000; i++)
            {
                double v = i + 1;
                if (v %3 == 0 || v%5 == 0)
                {
                    numList[i] = v;
                }           
            }
            for (int i = 0; i< numList.Length; i++)
            {
                if (numList[i] != 0)
                {
                    total += numList[i];
                }
            }
            Console.WriteLine(total);
        }

        
    }
}
// make an array of all 1000 numbers, iterate through all of them to see if mod 3 or mod 5 = 0 if true, add to new array.
// make an array of all the multiples of 3 or 5, then multiply them.