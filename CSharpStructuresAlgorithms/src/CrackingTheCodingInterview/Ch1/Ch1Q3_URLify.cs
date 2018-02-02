using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* -----------------------------------------------------------------------------------
 * QUESTION: 
 * -----------------------------------------------------------------------------------
 * URLify: Write a method to replace all spaces in a string with '%20'.  You may assume
 * that the string has sufficient space at the end to hold the additional characters, 
 * and that you are given the length of the string.  
 * -----------------------------------------------------------------------------------*/

namespace Chapter1
{
    class Ch1Q3_URLify
    {
        // SOLUTION 1: Change it in-place in the string
        // WHY: Saves space to do it with one string
        public string URLifySolution1(string s, int length)
        {
            char[] str = s.ToCharArray();
            int spaceCount = 0;
            int newLength;
            
            for (int i = 0; i < length; i++)        // First, count the number of spaces
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }

            newLength = length + spaceCount * 2;    // There is already 1 space for whitespace, add 2 more (" " (1) -> "%20" (3))
            str[newLength] = '\0';                  // Empty symbol at the end of string
            for (int i = length - 1; i >= 0; i--)   // iterate backwards through string
            {
                if (str[i] == ' ')                  // if a white space is found, place %20 in the space
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;      // reduce newlength by 3
                }
                else
                {
                    str[newLength - 1] = str[i];    // if non-whitespace char is found, add to string, reduce newLength by 1
                    newLength = newLength - 1;
                }
            }
            return str.ToString();  
        }

        // SOLUTION 2: Use StringBuilder
        // WHY: If additional data structures are allowed, this is simple solution, but uses up more memory

        public string URLifySolution2(string str)
        {
            StringBuilder strHelper = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == ' ')
                {
                    strHelper.Append("%20");
                }
                else
                {
                    strHelper.Append(str[i]);
                }
            }

            return strHelper.ToString();
        }

        // Run Tests
        public void Run()
        {
            // TO DO: WRITE A TEST CASE HERE
        }
    }
}
