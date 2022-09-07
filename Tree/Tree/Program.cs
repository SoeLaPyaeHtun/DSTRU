using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = new int[] { 27, 14, 35, 10, 19, 31, 42 };
            BST bst = new BST();

            for (int i = 0; i < keys.Length; i++)
            {
                bst.Insert(new Node(keys[i]));
            }


            // depth-first traversal
            bst.DepthFirst(BST.prefix);
            bst.DepthFirst(BST.infix);
            bst.DepthFirst(BST.postfix);

            Console.WriteLine(bst.Find(42));
           
            // breadth-first traversal
            bst.BreadthFirst();

        }
    }
}

