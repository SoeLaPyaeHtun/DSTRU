using System;
namespace Trie
{
    public class Trie
    {
        
        private Node root;

        public Trie()
        {
            root = new Node();
            root.IsWord = false;
        }

        public bool Insert(string word)
        {
            Node curr = root;

            foreach(char ch in word)
            {
                if (!curr.CharMap.ContainsKey(ch))
                {
                    curr.CharMap[ch] = new Node();
                }
                curr = curr.CharMap[ch];    
            }

            curr.IsWord = true;
            return true;
        }

        public bool Delete(string word)
        {
            Node curr = root;

            foreach (char ch in word)
            {
                if (!curr.CharMap.ContainsKey(ch))
                {
                    curr.CharMap[ch] = new Node();
                }
                curr = curr.CharMap[ch];
            }

            curr.IsWord = false;
            return true;
        }


        public Node Search(string word)
        {
            Node curr = root;

            for(int i = 0; i< word.Length; i++)
            {
                char cur = word[i];
                if (root.CharMap.ContainsKey(cur))
                {
                    root = root.CharMap[cur];
                }
                else
                {
                    return null;
                }
            }
            return root;
        }

        public Boolean _Search(string word)
        {
            Node node = Search(word);
            
            return node != null && node.IsWord;
            
        }




       




    }
}

