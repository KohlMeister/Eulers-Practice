using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Eulers_Practice
{
    class Problem10
    {
        //Problem 10
        //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        //Find the sum of all the primes below two million.
        //http://www.mathblog.dk/files/euler/Problem10.cs

        int value = 2000000;
               
        public void PrimesSum()
        {
            DateTime startTime = DateTime.Now;

            // Gets list of prime values
            int[] primes = GetPrimes(value);
            decimal primeSum = 0;

            // Loops through the array and sums the returned prime values
            for (int i = 0; i < primes.Length; i++)
            {
                primeSum += primes[i];
            }

            // Print to screen
            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;
            Console.WriteLine("Prime sum of all primes below {0} is {1} ", value, primeSum);
            Console.WriteLine("Solution took {0} ms using PrimesSum", duration.TotalMilliseconds);
            Console.ReadLine();
        }
        private int[] GetPrimes(int upperLimit)
        {
            // Variable definitions
            int counter = 3;
            bool isPrime;
            int j;
            List<int> primes = new List<int>();

            // Add 2 to be able to start at 3
            primes.Add(2);

            // Loop through odd numbers until limit to determine if prime
            while (counter <= upperLimit)
            {
                j = 0;
                isPrime = true;

                // Iterates through primes to determine if new counter is prime or not
                while (primes[j] * primes[j] <= counter)
                {
                    if (counter % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }

                // If prime, add the new value to the prime list
                if (isPrime)
                {
                    primes.Add(counter);
                }
                counter += 2;
            }
            return primes.ToArray();

        }
    }
}
