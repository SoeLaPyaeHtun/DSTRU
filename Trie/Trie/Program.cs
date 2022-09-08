using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "andy", "any", "and", "a", "an", "booy", "boo", "boat" };

            Trie trie = new Trie();

            // build Trie
            foreach (string word in words)
            {
                trie.Insert(word);
            }

            trie.Delete("an");

            if (trie._Search("a") == true)
                Console.WriteLine("exit");
            else Console.WriteLine("dont exit");

        }
    }
}

