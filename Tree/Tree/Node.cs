using System;
namespace Tree
{
    public class Node
    {
        public Node(int key)
        {
            Key = key;
            Left = null;
            Right = null;
        }

        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

    }
}

