using System;

namespace Project_Euler_Problems.Problems
{
    public class P1
    {
        /* Problem 1 Description
         * Multiples of 3 and 5
         * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
         * Find the sum of all the multiples of 3 or 5 below 1000.
         */
        public static void Start()
        {
            P1 p1 = new P1();
            p1.CalcSumOfMultiplesBelowOneThousand();
        }

        private void CalcSumOfMultiplesBelowOneThousand()
        {
            int sumOfMultiples = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (CheckIfMultipleOfFive(i) || CheckIfMultipleOfThree(i))
                {
                    sumOfMultiples += i;
                }
            }
            
            Console.WriteLine(sumOfMultiples);
        }

        static bool CheckIfMultipleOfThree(int possibleMultiple)
        {
            bool isMultiple = possibleMultiple % 3 == 0;

            return isMultiple;
        }

        static bool CheckIfMultipleOfFive(int possibleMultiple)
        {
            bool isMultiple = possibleMultiple % 5 == 0;

            return isMultiple;
        }
    }
}