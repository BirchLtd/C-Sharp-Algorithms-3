using System;
using System.Collections.Generic;  // Hash Set is here
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Ch1Q1_IsUnique
    {
        // Solution 1: Using a HashSet O(n) complexity
        // Why:  HashSet.Add will skip a new item if it's deemed equal to one of the existing items
        public bool IsUniqueSolution1(string str)
        {
            HashSet<char> myHashSet = new HashSet<char>();

            foreach (var item in str)
            {
                if (myHashSet.Contains(item))   // If found item in HashSet, return false
                {
                    return false;
                }

                myHashSet.Add(item);            // otherwise, add item to HashSet
            }
            return true;
        }

        // Solution 2: Using a Boolean Array **BOOK ANSWER**
        // Why: Ask if the string is ASCII or Unicode to set up flagging system
        // ASCII - 256 extended characters.  O(1) time complexity for fixed dataset
        public bool IsUniqueSolution2(string str)
        {
            if (str.Length > 256)          //  String must duplicate letters length exceeds alphabet       
            {
                return false;
            }

            bool[] char_set = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int currentChar = str[i];
                if (char_set[currentChar])  // if already found this char in the string
                {                           // it will have a true value at it's location
                    return false;
                }
                char_set[currentChar] = true;
            }
            return true;    // no duplicates found
        }

        // Run
        public void Run()
        {
            // Inputs
            string[] words = { "abc", "hello", "apple", "dog", "person", "grapple" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + IsUniqueSolution1(word) + " " + IsUniqueSolution2(word));
            }
        }
    }
}
