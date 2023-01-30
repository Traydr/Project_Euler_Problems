using System;
using Project_Euler_Problems.Utilities;

namespace Project_Euler_Problems.Problems
{
    public class P003
    {
        /* Problem 3
         * Largest Prime Factor
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         */
        public static void Start()
        {
            P003 p3 = new P003();
            p3.FindLargestPrimeFactorOfNum();
        }

        private void FindLargestPrimeFactorOfNum()
        {
            long targetNumber = 600851475143;
            int[] allPrimeFactors = new int[100];
            int indexCounter = 0;
            int maxPrimeFactor = 0;

            for (int i = 3; i <= targetNumber && targetNumber != 0;)
            {
                if (Primes.IsPrime(i))
                {
                    if (targetNumber % i == 0)
                    {
                        targetNumber /= i;
                        allPrimeFactors[indexCounter] = i;

                        Console.WriteLine($"Current targetNum {targetNumber} | Current i {i}");
                    }
                }

                i += 2;
            }

            for (int x = 0; x < allPrimeFactors.Length; x++)
            {
                if (maxPrimeFactor < allPrimeFactors[x])
                {
                    maxPrimeFactor = allPrimeFactors[x];
                }
            }

            Console.WriteLine(maxPrimeFactor);
        }
    }
}