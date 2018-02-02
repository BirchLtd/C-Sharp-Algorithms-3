using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* -----------------------------------------------------------------------------------
 * QUESTION: 
 * -----------------------------------------------------------------------------------
 * CHECK PERMUTATION: Given two strings, write a method to decide if one is a 
 * permutation of the other.
 * -----------------------------------------------------------------------------------*/

namespace Chapter1
{
    class C1Q2_CheckPermutation
    {
        // SOLUTION 1: Sort the strings **BOOK_ANSWER**
        // WHY: Sorted strings will be in the same order and easily compared
        public string SortString (string s)
        {
            char[] content = s.ToCharArray();       // string to char Array, for easy sorting
            Array.Sort(content);                    // Array.Sort returns a sorted char Array
            return new string(content);             // return the char Array as a new string
        }

        public bool CheckPermutationSolution1(string a, string b)
        {
            if (a.Length != b.Length)   // strings must have equal length to qualify to be permutations
            {
                return false;
            }
            return SortString(a).Equals(SortString(b));     // return the bool of if a.Equals(b) when sorted
        }

        // Run to Test Function
        public void Run()
        {
            Console.WriteLine(CheckPermutationSolution1("dogggg", "god"));
            Console.WriteLine(CheckPermutationSolution1("   dog", "god"));
            Console.WriteLine(CheckPermutationSolution1("dog", "god"));
            Console.WriteLine(CheckPermutationSolution1("Memo", "Demo"));
        }
    }
}
