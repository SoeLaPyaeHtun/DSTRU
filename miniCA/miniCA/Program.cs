using System;
using System.Diagnostics;
using System.Threading;

namespace miniCA
{
    class Program
    {
        static void Main(string[] args)
        {

            sum1(1000);
            sum3(1000);

            sum1(10000);
            sum3(10000);

            sum1(100000);
            sum3(100000);


        }


        static void sum1(long n)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                sum += i;
               
            }
            Console.WriteLine($"Run {sw.Elapsed.TotalMilliseconds}ns.");
        }

        static void sum3(long n)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long sum = n * (n + 1) / 2;
            Console.WriteLine($"Run {sw.Elapsed.TotalMilliseconds}ns.");

        }
    }
}

