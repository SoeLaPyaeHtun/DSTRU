using System;
using System.Collections.Generic;
using System.Linq;

namespace CA_MINI_RAPV
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 2, 4, 3 };

            int target = 6;


            Console.WriteLine("{0} ", string.Join(", \n", TwoSum(arr, target)));

          
        }

        // assuming array and target are provided.
        public static List<int> TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            var Ans = new List<int>();
            for (int i = 0; i < nums.Count(); ++i)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    Ans.Add(dict[target - nums[i]]);
                    Ans.Add(i);
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }

            return Ans;

        }
    }
}


