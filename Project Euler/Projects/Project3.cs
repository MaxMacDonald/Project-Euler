using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler.Projects
{
    //----------------------------------------------------------------COMPLETE--------------------------------------------------------------------------------------

    //The prime factors of 13195 are 5, 7, 13 and 29.

    //What is the largest prime factor of the number 600851475143 ?

    class Project3
    {
        Project3() { }

        public static void Solution()
        {
            const double num = 600851475143;
            double largestFactor = 0;
            double[] factors = new double[2];

            for (double i = 2; i*i < num; i++)
            {
                if (num % i == 0)
                {
                    factors[0] = i;
                    factors[1] = num / i;

                    for (int k = 0; k < 2; k++)
                    {
                        bool isPrime = true;
                        for (double j = 2; j*j < factors[k]; j++)
                        {
                            if (factors[k] % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                       if (isPrime && factors[k] > largestFactor)
                        {
                            largestFactor = factors[k];
                        }
                    }
                }
            }
            Console.WriteLine(largestFactor);
        }
    }
}
// determin if a number is prime. if it is then divide the given number by it. if this is a whole number then add it to a list of prime factors. Continue until all
// numbers are exhausted.
//Might be easier to find factors first.
// definitely find the factor first

    // only factors under sqr of number required as they can be used to find the others.