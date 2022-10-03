using System;

namespace Project_Euler_Problems.Utilities
{
    public class Primes
    {
        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            long boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 3; i <= boundary; i += 2) if (number % i == 0) return false;

            return true;
        }
    }
}