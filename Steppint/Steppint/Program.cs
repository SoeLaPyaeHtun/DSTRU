using System;

namespace Steppint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Step(3));
        }



        public static int Step(int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return 0;
            
            return Step(n - 3) + Step(n - 2) + Step(n - 1);

        }
    }
}

