using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 8, 4, -6, 28, 1 };
        }



        //Quick Sort
        public static void QuickSort(int[] arr, int right, int left)
        {
            int low = left;
            int pivot = right;
            right = pivot - 1;

            while (true)
            {
                while (left < pivot && arr[left] <= arr[pivot])
                {
                    left++;
                }

                while (right > low && arr[right] > arr[pivot])
                {
                    right--;
                }
                if (left < right)
                {
                    swap(ref arr[right], ref arr[left]);
                }
                else
                {
                    break;
                }
            }
        }
    



        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



        //insertion sort
        public static void InsectionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for(int pos = i; pos > 0; pos--)
                {
                    if (arr[pos] < arr[pos - 1])
                    {
                        int temp = arr[pos];
                        arr[pos] = arr[pos - 1];
                        arr[pos - 1] = temp;
                    }
                }
            }
        }



        //bubble sorting
        public static void BubbleSort(int[] arr)
        {
            for(int i= 0; i< arr.Length -1; i++)
            {
                for(int j = 0; j< arr.Length -1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //selection sort
        public static void SelectionSort(int[] arr)
        {
            for(int n = 0; n < arr.Length -1 ; n++)
            {
                int min_index = n;

                for(int m = n + 1; m < arr.Length; m++)
                {
                    if (arr[m] < arr[min_index])
                    {
                        min_index = m;
                    }
                }

                if(min_index != n)
                {
                    int temp = arr[n];
                    arr[n] = arr[min_index];
                    arr[min_index] = temp;
                }
            }
        }

       
    }
}

