using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 6, 10, 9, 7 };

            Heap heap = new Heap();

            // building a Heap
            for (int i = 0; i < arr.Length; i++)
            {
                heap.Insert(arr[i]);
            }


            heap.Print();

            while (heap.Count > 0)
            {
                Console.WriteLine("Removed: {0}", heap.Remove());
                heap.Print();
            }
        }


    }
}

