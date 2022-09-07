using System;
using System.Collections.Generic;

namespace Trie
{
    public class Node
    {
        
        public Node()
        {
            IsWord = false;
            CharMap = new Dictionary<char, Node>();
        }

        public bool IsWord { get; set; }
        public Dictionary<char,Node> CharMap { get; set; }

       

    }
}

