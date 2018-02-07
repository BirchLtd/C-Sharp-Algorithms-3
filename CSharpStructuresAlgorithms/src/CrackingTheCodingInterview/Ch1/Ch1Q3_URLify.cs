using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web; // Contains Url encode method
using System.Threading.Tasks;

namespace Chapter1
{
    class Ch1Q3_URLify
    {
        // SOLUTION 1: Change it in-place in the string
        // WHY: Saves space to do it with one string
        public string URLifySolution1(string s, int length)
        {
            // TO DO: This solution
            return s; 
        }

        // SOLUTION 2: Use URLEncode (C#.NET specific)
        public string URLifySolution2(string str)
        {
            str = str.Trim();     // trim off white space
            str = Uri.EscapeUriString(str);   // Add %20s 
            return str;
        }

        // Run Tests
        public void Run()
        {
            // TO DO: WRITE A TEST CASE HERE
            string test = "Test string is here    ";
            ///Console.Write(URLifySolution1(test, 23)); er
            Console.Write(URLifySolution2(test));
        }
    }
}
