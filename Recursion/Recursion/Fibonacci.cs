using System;
namespace Recursion
{
    public class Fibonacci
    {
        public Fibonacci()
        {
        }

        //recursion fibonacci
        public static int Fibonacci_Rec(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fibonacci_Rec(n - 1) + Fibonacci_Rec(n - 2);
        }
        //iteraition fibonacci
        public static int Fibonacci_(int n)
        {
            int first = 0;
            int second = 1;
            int fib = 0;
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            for (int i = 2; i <= n; i++)
            {
                fib = first + second;
                first = second;
                second = fib;
            }

            return fib;
        }

    }
}

