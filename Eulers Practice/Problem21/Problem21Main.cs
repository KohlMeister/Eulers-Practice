using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers_Practice.Problem21
{
    class Problem21Main
    {
        /* Problem Description:
         * Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
         * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
         * For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
         * Evaluate the sum of all the amicable numbers under 10000.
         */


        public void Run(int num)
        {
            List<int> amicableNums = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                ProcessNum(i, amicableNums);
            }
            var answer = amicableNums.Sum();
            Console.WriteLine(answer);
            Console.Read();
        }

        private void ProcessNum(int num, List<int> amicableNums)
        {
            // find proper divisors of num
            List<int> properDivisors = GetProperDivisors(num);

            // sum proper divisors
            int sumOfDivisors = SumProperDivisors(properDivisors);

            // repeat for sum
            List<int> properDivisorsB = GetProperDivisors(sumOfDivisors);
            int sumOfDivisorsB = SumProperDivisors(properDivisorsB);

            if (sumOfDivisorsB == num && sumOfDivisors != num)
            {
                amicableNums.Add(num);
                //amicableNums.Add(sumOfDivisors);
            }
        }

        private List<int> GetProperDivisors(int num)
        {
            List<int> properDivisors = new List<int>();

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    properDivisors.Add(i);
                }
            }

            return properDivisors;
        }

        private int SumProperDivisors(List<int> properDivisors)
        {
            return properDivisors.Sum();
        }
    }
}
