using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers_Practice
{
    class Problem14
    {
        // The following iterative sequence is defined for the set of positive integers:

        // n → n/2 (n is even)
        // n → 3n + 1 (n is odd)

        // Using the rule above and starting with 13, we generate the following sequence:
        // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), 
        // it is thought that all starting numbers finish at 1.
        // Which starting number, under one million, produces the longest chain?

        public void Collatz()
        {
            int max = 0;
            int ceiling = 1000000;
            int target = 0;
            for (int i = 1; i < ceiling; i++)
            {
                int stage = CalcCollatz(i);
                
                if (max < stage)
                {
                    max = stage;
                    target = i;
                }
            }
                        
            Console.WriteLine("The answer is {0}", target);
            Console.ReadLine();
        }
        private int CalcCollatz(double n)
        {
            int chain = 0;
            while (n != 1)
            {
                if (n % 2 == 0) n = n / 2;
                else n = (3 * n) + 1;
                chain += 1;
            }
            return chain;
        }
    }
}
