using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Ch1Q4_PalindromePermutation
    {
        public bool isPalindromePermutation(string str)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            // Corner cases
            if (str == null || str.Length == 0) return false;

            // Add str to dictionary as chars
            for (int i = 0; i < str.Length; i++)
            {
                if (d.ContainsKey(str[i]))
                {
                    int count = d[str[i]];
                    d[str[i]] = ++count;
                }
                else
                {
                    d.Add(str[i], 1);
                }
            }

            int countOdds = 0;
            foreach(KeyValuePair<char, int> entry in d)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
                if (str.Length % 2 == 0)    // entry string was even
                {
                    if (entry.Value % 2 != 0)  // an odd char count exists
                    {
                        return false;
                    }
                }
                if (str.Length % 2 == 1)        // entry string was odd
                {
                    if (entry.Value % 2 != 0)       // an odd char count exists
                    {
                        if (countOdds <= 1) countOdds++;  // it's the first odd char count
                        if (countOdds > 1) return false;  // it's not the first odd char count - non palindrome
                    }
                }
            }
            return true;
        }

        public void Run()
        {
            Console.WriteLine(isPalindromePermutation("tactcoa"));
        }
    }
}
