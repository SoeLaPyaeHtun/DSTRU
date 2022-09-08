using System;
using System.Collections.Generic;

namespace Heap
{
    public class Heap
    {

        private List<int> heap;

        public Heap()
        {
            heap = new List<int>();
        }

        public int Count
        {
            get
            {
                return heap.Count;
            }
        }

        public void Insert(int n)
        {
            heap.Add(n);

            if(heap.Count == 1)
            {
                return;
            }

            int child = heap.Count - 1 ;

            while (true)
            {
                int parent = (child - 1) / 2;

                if (child == parent)
                {
                    break;
                }

                if (heap[parent] < heap[child])
                {
                   
                    int tmp = heap[parent];
                    heap[parent] = heap[child];
                    heap[child] = tmp;

                    child = parent;
                }
                else
                {
                    break;
                }

            }
        }

        public int Remove()
        {
            if(heap.Count == 0)
            {
                new Exception("There is no heap");
            }

            int min = heap[0];

            if(heap.Count == 1)
            {
                heap.RemoveAt(0);
            }
            else
            {
                min = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);
            }

            if(heap.Count > 1)
            {
                int parent = 0;
                int smallest = parent;

                while (true)
                {
                    int left_child = 2 * parent + 1;
                    int right_child = 2 * parent + 2;

                    if(left_child < heap.Count)
                    {
                        if (heap[left_child] < heap[smallest])
                        {
                            smallest = left_child;
                        }
                    }

                    if(right_child < heap.Count)
                    {
                        if (heap[right_child] < heap[smallest])
                        {
                            smallest = right_child;
                        }
                    }

                    if(smallest == parent)
                    {
                        break;
                    }
                    else
                    {
                        int tmp = heap[parent];
                        heap[parent] = heap[smallest];
                        heap[smallest] = tmp;

                        parent = smallest;
                    }
                }
            }

            return 1;

        }





       public void Print()
        {
            if(Count == 0)
            {
                Console.WriteLine("heap is empty");
            }
            else
            {
                string outp = "Heap: ";
                foreach (int key in heap)
                {
                    outp += key + " ";
                }
                Console.WriteLine(outp);
            }
        }
       
    }
}

