using System;
using System.Collections.Generic;

namespace Project_Euler_Problems.Problems;

public class P12
{
    public static void Start()
    {
        int maxDivisors = 0;
        int targetDivisors = 500;

        // long lastTriangle = GetTriangleNum(1);

        long i = 2;
        while (maxDivisors < targetDivisors)
        {
            long triangle = GetTriangleNum(i);
            List<long> arr = FasterGetFactors(triangle);

            if (arr.Count > maxDivisors)
            {
                maxDivisors = arr.Count;
                Console.WriteLine($"New Max\n\tTriangle Number: {triangle}\n\tWith Num Factors: {arr.Count}");

                // string nums = String.Empty;
                // foreach (var item in arr)
                // {
                //     nums += $"{item}, ";
                // }

                // Console.WriteLine(nums);

                // lastTriangle = triangle;
            }

            i++;
        }
    }

    private static long GetTriangleNum(long numToGet)
    {
        long sum = 0;

        for (long i = numToGet; i > 0; i--)
        {
            sum += i;
        }

        return sum;
    }

    private static List<long> GetFactors(long input)
    {
        List<long> factors = new List<long>();
        switch (input)
        {
            case 0:
                return factors;
            case 1:
                factors.Add(1);
                return factors;
        }

        factors.Add(1);
        factors.Add(input);

        for (long i = 2; i < (input / 2) + 1; i++)
        {
            if (input % i == 0 && !factors.Contains(i))
            {
                factors.Add(i);
                factors.Add(input / i);
            }
        }

        return factors;
    }

    private static List<long> FasterGetFactors(long n)
    {
        // Taken from https://www.geeksforgeeks.org/find-all-divisors-of-a-natural-number-set-2/
        List<long> factors = new List<long>();
        for(int i = 1; i * i < n; i++)
        {
            if (n % i == 0) factors.Add(i);
        }
        for(int i = (int)Math.Sqrt(n); i >= 1; i--)
        {
            if (n % i == 0) factors.Add(n / i);
        }

        return factors;
    }
}