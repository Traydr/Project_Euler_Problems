using System;

namespace Project_Euler_Problems.Problems
{
    public class P4
    {
        /* Problem 4
         * Largest Palindrome Product
         * A palindromic number reads the same both ways.
         * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */

        public static void Start()
        {
            P4 p4 = new P4();
            p4.CheckForPalindromes();
        }

        private bool IsPalindrome(int num)
        {
            bool isPalindrome = false;
            string numAsString = num.ToString();
            string numReversed = "";

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                numReversed = numReversed + numAsString[i];
            }

            if (numReversed == numAsString)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        private void CheckForPalindromes()
        {
            int firstNum = 99;
            int palFirstNum = 0;
            int secondNum = 99;
            int palSecondNum = 0;
            int largestPalindrome = 0;

            for (int x = firstNum; x < 1000; x++)
            {
                for (int c = secondNum; c < 1000; c++)
                {
                    int productResult = x * c;
                    if (IsPalindrome(productResult) && largestPalindrome < productResult)
                    {
                        Console.WriteLine($"Product of X and C: {productResult}, Result of IsPalindrome: {IsPalindrome(productResult)}");
                        largestPalindrome = productResult;
                        palFirstNum = x;
                        palSecondNum = c;
                    }
                }
            }
            
            Console.WriteLine($"The largest palindrome is: {largestPalindrome} \n The Components are {palFirstNum} and {palSecondNum}");
        }
    }
}