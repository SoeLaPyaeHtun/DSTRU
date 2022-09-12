using System;
namespace LinkedList
{
    public class LList
    {

        public Node Head { get; set; }
        private int numElements;

        public LList()
        {
            Head = null;
            numElements = 0;
        }


        //getting node index
        public Node GetNodeAt(int index)
        {
            Node curNode = Head;
            for (int i = 0; i < index; i++)
            {
                curNode = curNode.Next;
            }
            return curNode;
        }



        //linkedlist add method
        public LList Add(string newElement)
        {
            Node newNode = new Node(newElement);
            if(numElements == 0)
            {
                Head = newNode;
            }
            else
            {
                Node lastNode = GetNodeAt(numElements - 1);
                lastNode.Next = newNode;
            }
            numElements++;
            return null;
        }

        //linkedlist insert method
        public void InsertAt(int index, string newElement)
        {
            if(index >= 0 && index <= numElements)
            {
                Node newNode = new Node(newElement);
                if(index == 0)
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
                else
                {
                    Node nodeBefore = GetNodeAt(index - 1);
                    Node nodeAfter = nodeBefore.Next;

                    nodeBefore.Next = newNode;
                    newNode.Next = nodeAfter;
                }
                numElements++;
            }
        }

        //linkedlist contain method
        public void Replace(int index, string newElement)
        {
            if (index >= 0 && index <= numElements)
            {
                Node newNode = new Node(newElement);

                if (index == 0)
                {
                    Head = Head.Next;
                    InsertAt(index, newElement);
                }
                else
                {

                    Node nodeBefore = GetNodeAt(index - 1); //before
                    Node nodeToRemove = nodeBefore.Next; //remove node
                    
                    Node nodeAfter = nodeToRemove.Next; //after
                    nodeBefore.Next = nodeAfter;
                    InsertAt(index, newElement);

                }
            }
        }



        //linkedlist remove method
        public void RemoveAt(int index)
        {
            if(index >= 0 && index <= numElements -1 )
            {
                if(index == 0)
                {
                    Head = Head.Next;
                }
                else
                {
                    Node nodeBefore = GetNodeAt(index - 1);
                    Node nodeToRemove = nodeBefore.Next;
                    Node nodeAfter = nodeToRemove.Next;

                    nodeBefore.Next = nodeAfter;
                }
                numElements--;
            }
        }


        //linkedlist count
        public int Count()
        {
            int i = 0;

            Node countNode = new Node();
            countNode = this.Head;

            while(countNode != null)
            {
                i++;
                countNode = countNode.Next;
            }


            return i;
        }

        //linkedlist get method
        public string GetAt(int index)
        {
            Node currentNode = GetNodeAt(index);
            return currentNode.Data;
        }


      
        //linkedList contail method
        public bool Contains(string element)
        {
            bool output = true;
           for(int i = 0; i < numElements; i++)
            {
                if(GetAt(i) == element)
                {
                    output = true;
                    break;
                }
                else
                {
                    output = false;
                }
            }
            return output;
            

        }
                
        

    }
}

