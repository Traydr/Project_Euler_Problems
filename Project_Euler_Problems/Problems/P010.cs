using System;

namespace Project_Euler_Problems.Problems
{
    public class P010
    {
        public static void Start()
        {
            P010 p10 = new P010();
            p10.FindSumOfPrimesUnderLimit(2000000);
        }

        private void FindSumOfPrimesUnderLimit(int limit)
        {
            long sumOfPrimes = 0;
            
            for (int i = 2; i < limit; i++)
            {
                if (Utilities.Primes.IsPrime(i))
                {
                    sumOfPrimes += i;
                }
            }
            
            Console.WriteLine($"The sum of primes is {sumOfPrimes}");
        }
    }
}