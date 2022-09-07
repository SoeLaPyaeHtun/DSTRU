using System;
using System.Collections.Generic;

namespace Tree
{
    public class BST
    {
        private Node root;
        public const int prefix = 1;
        public const int infix = 2;
        public const int postfix = 3;


        public BST()
        {
            root = null;
        }

        public bool Insert(Node node)
        {
            if(node == null)
            {
                //cannot insert
                return false;
            }

            if(root == null)
            {
                //tree has no node yet,set this one as root
                root = node;
                return false;
            }
            return _Insert(node,root);
        }


        public bool Find(int key)
        {
            return _Find(root, key);
        }

        private bool _Find(Node node, int key)
        {
            if(node == null)
            {
                return false;
            }

            if(key == node.Key)
            {
                return true;
            }

            if (key < node.Key)
            {
                node = node.Left;
                return true;
            }

            if (key > node.Key)
            {
                node = node.Right;
                return true;
            }

            return false;

        }

        private bool _Insert(Node node, Node curr)
        {
            if(node.Key == curr.Key)
            {
                return false; //no duplicate keys allowed
            }

            if(node.Key < curr.Key)
            {
                if(curr.Left == null)
                {
                    curr.Left = node;
                    return true;
                }
                return _Insert(node, curr.Left);
            }
            else
            {
                if(curr.Right == null)
                {
                    curr.Right = node;
                    return true;
                }
                return _Insert(node, curr.Right);
            }
        }





        public void DepthFirst(int mode)
        {
            if(mode == prefix)
            {
                Prefix(root);
            }else if(mode == infix)
            {
                Infix(root);
            }else if(mode == postfix)
            {
                Postfix(root);
            }

            Console.WriteLine("");

        }

        private void Prefix(Node node)
        {
            if(node == null)
            {
                return;
            }
            Console.Write($"{node.Key} ");
            Prefix(node.Left);
            Prefix(node.Right);
        }

        private void Infix(Node node)
        {
            if (node == null)
            {
                return;
            }
            
            Prefix(node.Left);
            Console.Write($"{node.Key} ");
            Prefix(node.Right);
        }

        private void Postfix(Node node)
        {
            if (node == null)
            {
                return;
            }
            
            Prefix(node.Left);
            Prefix(node.Right);
            Console.Write($"{node.Key} ");
        }

        public void BreadthFirst()
        {
            List<Node> nodes = new List<Node>();

            if(root != null)
            {
                nodes.Add(root);
            }

            while(nodes.Count > 0)
            {
                Node node = nodes[0];
                Console.Write($"{node.Key} ");

                if(node.Left == null)
                {
                    nodes.Add(node.Left);
                }

                if(node.Right == null)
                {
                    nodes.Add(node.Right);
                }

                nodes.RemoveAt(0);
            }
            Console.WriteLine(" ");
        }

       
    }
}

