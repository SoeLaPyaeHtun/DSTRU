using System;
using System.Collections.Generic;

namespace TwoArrCom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 3 , 2};
            int[] b = { 1, 4, 3, 2 , 5};


            Console.WriteLine(AreIdenticalSets(a, b));
        }


        public static bool AreIdenticalSets(int[] a, int[] b)
        {
            if(a.Length != b.Length)
            {
                return false;
            }

            Dictionary<int, int> A = CountFrequency(a);
            Dictionary<int, int> B = CountFrequency(b);

            return isSame(A, B);
        }



        private static Dictionary<int, int> CountFrequency(int[] arr)
        {
            Dictionary<int, int> CountFreq = new Dictionary<int, int>();

            foreach(int number in arr)
            {
                int occur;
                if(CountFreq.TryGetValue(number, out occur))
                {
                    int newOccur = occur + 1;
                    CountFreq[number] = newOccur;
                }
                else
                {
                    CountFreq.Add(number, 1);
                }
            }

            return CountFreq;
        }

        private static bool isSame(Dictionary<int, int> a, Dictionary<int, int> b)
        {
            return IsEveryAInB(a, b) && IsEveryAInB(b, a);
        }

        private static bool IsEveryAInB(Dictionary<int, int> a,Dictionary<int, int> b)
        {
            foreach(KeyValuePair<int,int> twin in a)
            {
                int key = twin.Key;
                int value = twin.Value;

                if(!(b.ContainsKey(key) && b[key] == value))
                {
                    return false;
                }
            }

            return true;
        }


    }
}

