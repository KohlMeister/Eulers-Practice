﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Eulers_Practice
{
    public class Problems
    {
        static void Main(string[] args)
        {
            //new Problem10().PrimesSum();

            //new Problem12().NatNums();
            new Problem14().Collatz();
                       
            //Console.WriteLine(answer);
            //Console.ReadLine();
        }
        public static int problemNine(int target)
        {
            //Problem 9
            //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
            //a2 + b2 = c2
            //For example, 32 + 42 = 9 + 16 = 25 = 52.
            //There exists exactly one Pythagorean triplet for which a +b + c = 1000.
            //Find the product abc.
            //int answer = 0;
            //int target = 1000;

            for (int i = 1; i < 400; i++)
            {
                for (int j = i + 1; j < 400; j++)
                {
                    int product = (i * i) + (j * j);
                    double root = Math.Sqrt(product);
                    if (root % 1 == 0 && i + j + root == target)
                    {
                        int answer = i * j * Convert.ToInt32(root);
                        return answer;
                    }
                }
            }
            return 0;
            

        }
        public int problemSeven(int prime)
        {
            //Problem 7
            //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            //What is the 10 001st prime number?

            int answer = 0;
            int primeCount = 0;
            int i = 0;
            while (i <= 1000000000)
            {
                if (isPrime(i) == true)
                {
                    if (primeCount == prime)
                    {
                        break;
                    }
                    answer = i;
                    primeCount = primeCount + 1;
                }
                i++;
            }
            return answer;
        }
        public static int problemOne(int range)
        {
            //Problem 1
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.

            int answer = 0;

            for (int i = 1; i < range; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    answer = answer + i;
                }             
            }
            return answer;
        }
        public int problemTwo(int range)
        {
            //Problem 2
            //Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
            //
            // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //
            //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

            int x = 0;
            int y = 1;
            int z = 0;
            int answer = 0;

            while(z <= range)
            {
                if (z % 2 == 0)
                    answer = answer + z;
                z = x + y;
                x = y;
                y = z;
            }
            return answer;
        }
        public int problemThree(long number)
        {
            //Problem 3
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?

            long x = number;
            double root = Math.Round(Math.Sqrt(x));
            int answer = 0;

            for (int i = 3; i < root; i++)
            {
                if (x % i == 0 && isPrime(i) == true)
                {
                    answer = i;
                }

            }
            return answer;
        }
        public int problemFour()
        {
            //Problem 4
            //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            //Find the largest palindrome made from the product of two 3 - digit numbers.

            List<int> list = new List<int>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
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
            return answer;
        }
        public long problemFive(long max, long startingPoint, int divideBy)
        {
            //Problem 5
            //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?
            
            /******* BRUTE FORCE TOOK A WHILE TO SOLVE ***********/

            long answer = 0;
            int p = divideBy;
            long ticker = startingPoint;

            while (ticker < max)
            {
                if (superMod(ticker, p) == true)
                {
                    answer = ticker;
                    break;
                }
                ticker = ticker + 2;
            }
            return answer;
        }
        public long problemSix(int numberOfNumbers)
        {
            //Problem 6
            //The sum of the squares of the first ten natural numbers is,
            //12 + 22 + ... + 102 = 385
            //The square of the sum of the first ten natural numbers is,
            //(1 + 2 + ... + 10)2 = 552 = 3025
            //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            int nat = numberOfNumbers;
            int natsum = 0;
            int natsum2 = 0;

            for (int i = 1; i <= nat; i++)
            {
                natsum = natsum + (i * i);
            }
            for (int j = 1; j <= nat; j++)
            {
                natsum2 = natsum2 + j;
            }
            natsum2 = natsum2 * natsum2;
            int answer = natsum2 - natsum;
            return answer;
        }
        public bool superMod(long value, int p)
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

        public string reverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static bool isPrime(int value)
        {
            double root;
            int f;
            if (value == 1) return false;
            else if (value < 4) return true;
            else if (value % 2 == 0) return false;
            else if (value < 9) return true;
            else if (value % 3 == 0) return false;
            else
                root = Math.Round(Math.Sqrt(value));
                f = 5;
                while (f <= root)
                    if (value % f == 0) return false;
                    if (value % f + 2 == 0) return false;
                    f = f + 6;
                return true;
            /*
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0) return false;
            }
            return true;*/
        }
    }
}
