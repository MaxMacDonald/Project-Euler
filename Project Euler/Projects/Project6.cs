using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Projects
{

    //The sum of the squares of the first ten natural numbers is,

    //1^2 + 2^2 + ... + 10^2 = 385
    //The square of the sum of the first ten natural numbers is,

    //(1 + 2 + ... + 10)^2 = 552 = 3025
    //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

    public class Project6
    {
        Project6() { }

        public static void Solution()
        {
            double sumOfSquare;
            double squareOfSum;
            double sumCounter = 0;
            double squareCounter = 0;
            double diff = 0;

            for (double i = 0; i <= 100; i++)
            {
                sumCounter += (i * i);
                squareCounter += i;
            }
            squareOfSum = squareCounter * squareCounter;
            sumOfSquare = sumCounter;

            diff = squareOfSum - sumOfSquare;

            Console.WriteLine(diff);

        }

    }
}
