using System;

namespace Project_Euler_Problems.Problems
{
    public class P007
    {
        /* Problem 7
         * 10001st prime
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         */
        public static void Start()
        {
            P007 p7 = new P007();
            p7.FindSpecificPrimeNum(10001);
        }

        private static bool CheckIfPrime(int num)
        {
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        private void FindSpecificPrimeNum(int primeIndex)
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

        static void NewFindSpecificPrimeNum(int primeIndex)
        {
            int[] previousPrimes = { 2, };
            int primeCandidate = 3;
            /* New thing I want to implement
            1. Define array to hold prime numbers.
            2. populate prime numbers array with '2'.
            3. set first prime candidate to '3'
            4. set test limit to square root of prime candidate.
            5. Check if prime candidate is divisible by numbers in prime array. 
            (upper limit for testing prime number<=root from step 4.) 
            If divisible discard else add to prime numbers array.
            6. increment prime candidate by 2.
            7. goto step 4. This has served fairly well for me. 
            Difficulties lie in deciding how many prime numbers are needed. 
            The progress is slower as the prime candidate gets bigger.
            */
        }
    }
}