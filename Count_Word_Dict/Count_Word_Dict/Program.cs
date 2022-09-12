using System;
using System.Collections.Generic;

namespace Count_Word_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = { "count", "word", "dictionary", "hello", "count", "word" };


            DisplayOccur(CountOccur(wordList));
        }


        public static Dictionary<string, int> CountOccur(string[] wordList)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach(string word in wordList)
            {
                int occur;
                if(dictionary.TryGetValue(word, out occur))
                {
                    int newOccur = occur + 1;
                    dictionary[word] = newOccur;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            return dictionary;

        }

        public static void DisplayOccur(Dictionary<string, int> dictionary)
        {
            Dictionary<string, int>.KeyCollection Keys = dictionary.Keys;

            foreach(string word in Keys)
            {
                Console.WriteLine($"{word}  {dictionary[word]}");
            }
        }
    }
}

