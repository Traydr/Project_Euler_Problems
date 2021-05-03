using System;
using System.Security.Permissions;

namespace Project_Euler_Problems
{
    public class ProblemSeven
    {
        /* Problem 7
         * 10001st prime
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         */
        public static void Start()
        {
            FindSpecificPrimeNum(10001);
        }

        static bool CheckIfPrime(int num)
        {
            bool isPrime = true;

            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }

            return isPrime;
        }

        static void FindSpecificPrimeNum(int primeIndex)
        {
            int currentPrimeIndex = 6;
            int lastPrime = 13;
            int counter = lastPrime + 1;

            while (currentPrimeIndex != primeIndex)
            {
                if (CheckIfPrime(counter))
                {
                    currentPrimeIndex += 1;
                    lastPrime = counter;
                }

                counter += 1;
            }
            
            Console.WriteLine($"Prime: {lastPrime} \nPrime Index: {currentPrimeIndex}");
        }
    }
}