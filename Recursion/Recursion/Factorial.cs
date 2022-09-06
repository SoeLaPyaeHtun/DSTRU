using System;
namespace Recursion
{
    public class Factorial
    {
        public Factorial()
        {
        }

        //recursion factorial
        public static int Factorial_Rec(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial_Rec(n - 1);
        }


        //iteration factorial
        public static int Factorial_(int n)
        {
            int fact = 1;

            for (int i = n; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}

