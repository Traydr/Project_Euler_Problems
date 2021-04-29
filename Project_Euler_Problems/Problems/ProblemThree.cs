using System;
using System.Runtime.Remoting;

namespace Project_Euler_Problems
{
    public class ProblemThree
    {
        /* Problem 3
         * Largest Prime Factor
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         */

        public static void FindLargestPrimeFactorOfNum()
        {
            long targetNumber = 600851475143;
            int[] allPrimeFactors = new int[100];
            int indexCounter = 0;
            int maxPrimeFactor = 0;

            for (int i = 3; i < targetNumber / 3 && targetNumber != 0;)
            {
                if (CheckIfNumIsPrime(i))
                {
                    if (targetNumber % i == 0)
                    {
                        targetNumber /= i;
                        allPrimeFactors[indexCounter] = i;
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

        static bool CheckIfNumIsPrime(int num)
        {
            bool isNumPrime = false;

            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    
                }
                else
                {
                    isNumPrime = true;
                }
            }

            return isNumPrime;
        }
    }
}