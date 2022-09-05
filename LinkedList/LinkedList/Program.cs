using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList myList = new LList();
            myList.Add("FOPCS");
            myList.Add("OOPCS");
            myList.InsertAt(2, "MVC.NET");
            if (myList.Contains("OOPCS"))
                myList.InsertAt(3, "Design");
            myList.InsertAt(1, "Data Structures");
            myList.Replace(3, "Java");
            myList.RemoveAt(4);
            myList.Replace(1, "Android");
            for (int i = 0; i < myList.Count(); i++)
                Console.WriteLine(myList.GetAt(i));


        }
    }
}

