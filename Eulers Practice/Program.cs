﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eulers_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problem 1
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            /*
            int x = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    x = x + i;                 
                }                        
            }
            Console.WriteLine(x);
            Console.ReadLine();
            */

            //Problem 2
            //Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
            //
            // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            /*
            int x = 0;
            int y = 1;
            int z = 0;
            int answer = 0;

            while (z < 4000000)
            {
                if (z % 2 == 0)
                    answer = answer + z;
                z = x + y;
                x = y;
                y = z;
            }
            Console.WriteLine(answer);
            Console.ReadLine();
            */

            //Problem 3
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?
            /*
            long x = 600851475143;
            double root = Math.Round(Math.Sqrt(x));
            int answer = 0;

            for (int i = 3; i < root; i++)
            {
                if (x % i == 0 && isPrime(i) == true)
                {
                    answer = i;
                }
                
            }
            Console.WriteLine(answer);
            Console.ReadLine();
            */

            //Problem 4
            //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            //Find the largest palindrome made from the product of two 3 - digit numbers.
            /*
            List<int> list = new List<int>();

            for(int i = 100; i < 1000; i++)
            {
                for(int j = 100; j < 1000; j++)
                {
                    int x = i * j;
                    string forward = x.ToString();
                    string reverse = reverseString(forward);
                    if (forward == reverse)
                    {
                        list.Add(x);
                    }
                }
            }
            var answer = list.Max();
            Console.WriteLine(answer);
            Console.ReadLine();
            */

            //Problem 5
            //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?


            /******* BRUTE FORCE TOOK A WHILE TO SOLVE ***********/
            long answer = 0;
            int p = 20;
            long ticker = 2520;

            while (ticker < 100000000000000)
            {
                if(superMod(ticker, p) == true)
                {
                    answer = ticker;
                    break;
                }
                ticker = ticker + 2;
            }

            Console.WriteLine(answer);
            Console.ReadLine();

        }
        public static bool superMod(long value, int p)
        {
            int inc = 0;
            for (int i = 1; i <= p; i++)
            {
                if (value % i == 0)
                {
                    inc++;
                }
            }
            if (inc == p) return true;
            return false;
        }

        public static string reverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static bool isPrime(int value)
        {
            if ((value == 1) || (value == 2)) return false;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0) return false;
            }
            return true;
        }
    }
}
