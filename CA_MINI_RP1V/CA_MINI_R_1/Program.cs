using System;
using System.Collections.Generic;
using System.Linq;

namespace CA_MINI_RP1V
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 3, 3, 2, 4, 3 };  
            int target = 6;

            Console.WriteLine("[{0}]", string.Join(", ", TwoSum(numList, target)));          
        }



        // array and target value are provided.
        public static int[] TwoSum(int[] numList, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();  //
            for (int i = 0; i < numList.Count(); ++i) //for loop is N * O(1), which is O(N) overall
            {
                if (dictionary.ContainsKey(target - numList[i]))  //ContainsKey method approaches an O(1) operation.
                    return new int[] { dictionary[target - numList[i]], i };
                else
                    dictionary[numList[i]] = i;
            }
            return null;
        }
    }
}


