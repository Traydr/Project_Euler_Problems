using System;
using static System.Math;

namespace Project_Euler_Problems.Problems
{
    public class P9
    {
        public static void Start()
        {
            P9 p9 = new P9();
            p9.FindPythagoreanTriplet(1000);
        }

        private void FindPythagoreanTriplet(int num)
        {
            int a = 0, b = 0, c = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (ValidPythag(k, j, i))
                        {
                            if (k + j + i == num)
                            {
                                a = k;
                                b = j;
                                c = i;
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine($"Triple is a:{a} b:{b} c:{c}");
            Console.WriteLine($"Sum of those is: {a * b * c}");
        }

        private bool ValidPythag(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}