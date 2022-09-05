using System;
namespace LinkedList
{
    public class Node
    {
        public Node(string date)
        {
            Data = date;
            Next = null;
        }
        public Node()
        {

        }

        public string Data { get; set; }
        public Node Next { get; set; }
    }
}

