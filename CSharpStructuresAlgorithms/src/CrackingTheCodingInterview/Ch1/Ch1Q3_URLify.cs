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
        public void URLifySolution1(char[] str, int length)
        {
            int spaceCount = 0;
            int newLength;
            
            for (int i = 0; i < length; i++)        // First, count the number of spaces
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }

            newLength = length + spaceCount * 2;    // Space
            str[newLength] = '\0';
            for (int i = length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[newLength - 1] = '0';
                    str[newLength - 2] = '2';
                    str[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    str[newLength - 1] = str[i];
                    newLength = newLength - 1;
                }
            }
        }

        // SOLUTION 2: Use StringBuilder
        // WHY: If additional data structures are allowed, this is simple solution

        public void URLifySolution2()
        {

        }

        // Run Tests
        public void Run()
        {

        }
    }
}
