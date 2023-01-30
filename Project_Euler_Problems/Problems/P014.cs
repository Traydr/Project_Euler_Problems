using System;

namespace Project_Euler_Problems.Problems;

public class P014
{
    public static void Start()
    {
        long longestChain = 0;
        long longestNum = 0;
        for (long i = 999999; i > 0; i--)
        {
            long chainLength = CollatzSeqRecursive(i);

            if (chainLength > longestChain)
            {
                longestChain = chainLength;
                longestNum = i;
            }
        }

        Console.WriteLine($"The longest chain was {longestChain} numbers long, the initial num was {longestNum}\n");
    }

    private static long CollatzSeqRecursive(long num)
    {
        if (num == 1)
        {
            return 1;
        }

        if (num % 2 == 0)
        {
            return CollatzSeqRecursive(num / 2) + 1;
        }

        return CollatzSeqRecursive(3 * num + 1) + 1;
    }
}