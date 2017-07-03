﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers_Practice
{
    class Problem_12
    {
        // Problem 12
        // The sequence of triangle numbers is generated by adding the natural numbers. 
        // So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
        // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        //
        // Let us list the factors of the first seven triangle numbers:
        //  1: 1
        //  3: 1,3
        //  6: 1,2,3,6
        // 10: 1,2,5,10
        // 15: 1,3,5,15
        // 21: 1,3,7,21
        // 28: 1,2,4,7,14,28
        //
        // We can see that 28 is the first triangle number to have over five divisors.
        // What is the value of the first triangle number to have over five hundred divisors?

        public void NatNums()
        {
            int divisors = 500;
            int answer = 0;
            int j = 1;
            int factorCount = 0;
            int sqrt = 0;

            while (factorCount < divisors)
            {
                
                answer = answer + j;
                List<int> factors = new List<int>();

                sqrt = (int)Math.Sqrt(answer);
                
                int i = 1;
                while (i <= sqrt)
                {
                    if (answer % i == 0)
                    {
                        factors.Add(i);
                        factors.Add(answer / i);
                    }
                    i++;
                }
                factorCount = factors.Count();
                j++;
            }
                  
            Console.WriteLine("The answer is {0}", answer);
            Console.WriteLine("The number of divisors it has is {0}", factorCount);
            Console.ReadLine();
        }

    }
}