using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("hello"));

        }


        static string Reverse(string input)
        {
            if(input.Length == 0)
            {
                return "";
            }
            return input[input.Length - 1] + Reverse(input.Substring(0,input.Length-1));
        }



        static int CountWord(string input)
        {

            if (input.Length > 0)
            {
                return 1 + CountWord(input.Substring(1, input.Length - 1));
            }

            return 0;
        }       
    }
}

