using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Collections;

namespace Queues_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter : ");
            string input = "";
           
           
           
            Stack<char> myStack = new Stack<char>();
            //Queue<char> myQueue = new Queue<char>();

            //Using Only Stack
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (IsOpenDelimiter(input[i]))
            //    {
            //        myStack.Push(input[i]);
            //    }else if (IsCloseDelimiter(input[i]))
            //    {
            //        if(IsPaired(myStack.Peek(), input[i]))
            //        {
            //            myStack.Pop();
            //        }
            //    }
            //}
            //if(myStack.Count == 0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
          

            //using stack and queue
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (IsOpenDelimiter(input[i]))
            //    {
            //        myStack.Push(input[i]);
            //    }
            //    else if (IsCloseDelimiter(input[i]))
            //    {
            //        myQueue.Enqueue(input[i]);
            //    }
            //}
            //bool output = false;
            //while (myStack.Count > 0)
            //{
            //    if (IsPaired(myStack.Pop(), myQueue.Dequeue()))
            //    {
            //        output = true;
            //    }
            //    else
            //    {
            //        output = false;
            //        break;
            //    }

            //}
            //Console.WriteLine(output);




        }


        private static bool IsOpenDelimiter(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{';
        }

        private static bool IsCloseDelimiter(char ch)
        {
            return ch == ')' || ch == ']' || ch == '}';
        }

        private static bool IsPaired(char open, char close)
        {
            return (open == '(' && close == ')') ||
                      (open == '[' && close == ']') ||
                      (open == '{' && close == '}');
        }

    }
}

