using System;
namespace Recursion
{
    public class Palindrome
    {
        public Palindrome()
        {
        }

        //recursion
        public static bool Palindrome_Rec(string input)
        {

            if (input.Length <= 1)
            {
                return true;
            }

            if (input[0] == input[input.Length - 1])
            {
                return Palindrome_Rec(input.Substring(1, input.Length - 2));
            }

            return false;

        }

        //iteration
        public static bool Palindrome_(string input)
        {
            Boolean output = false;

            if (input.Length <= 1)
            {
                output = true;
            }
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    output = true;
                }
            }
            return output;
        }
    }
}

