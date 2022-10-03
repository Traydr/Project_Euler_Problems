using System;

namespace Project_Euler_Problems.Problems
{
    public class P5
    {
        /* Problem 5
         * Smallest Multiple
         * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */

        public static void Start()
        {
            P5 p5 = new P5();
            p5.SmallestMultiple();
        }

        private void SmallestMultiple()
        {
            bool isSmallestMultiple = false;
            long counter = 2520;
            while (isSmallestMultiple != true)
            {
                if (CheckIfDivisbleByFirstTwentyNums(counter))
                {
                    isSmallestMultiple = true;
                }
                else
                {
                    counter += 2520;
                }
            }
            
            Console.WriteLine($"The smallest multiple is: {counter}");
        }

        bool CheckIfDivisbleByFirstTwentyNums(long num)
        {
            bool isDivisble = true;

            for (int i = 1; i <= 20; i++)
            {
                if (num % i != 0)
                {
                    isDivisble = false;
                    Console.WriteLine($"Num: {num}, Failed at {i}");
                    return isDivisble;
                }
            }

            return isDivisble;
        }
    }
}