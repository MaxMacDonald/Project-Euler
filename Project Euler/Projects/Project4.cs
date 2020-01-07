using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Projects
{
    //----------------------------------------------------------------COMPLETE--------------------------------------------------------------------------------------

    //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

    //Find the largest palindrome made from the product of two 3-digit numbers.
    class Project4
    {
        Project4() { }

        public static void Solution()
        {
            double holder = 0;
            double highest = 0;
            string whole;
            string firstHalf;
            string secondHalf;

            for (double i = 101; i <= 999; i++)
            {
                for (double v = 100; v <= 999; v++)
                {
                    holder = i * v;
                    if (holder > 99999 && holder % 11 == 0 && holder > highest)
                    {
                        whole = holder.ToString();
        
                        firstHalf = whole.Substring(0, 3);
                        secondHalf = whole.Substring(3, 3);
                        if (firstHalf[0] == secondHalf[2] && firstHalf[1] == secondHalf[1] && firstHalf[2] == secondHalf[0])
                        {
                            highest = holder;
                        }

                    }
                }
            }
            Console.WriteLine(highest);
        }

    }
}
// for any palindromic number, the last digit is the same as the first, therefore this should be the first check.
// all palindromic numbers with an even number of digits are divisible by 11
// 