using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Ch1Q6_StringCompression
    {
        public string StringCompression(string str)
        {
            StringBuilder sb = new StringBuilder();

            int countChar = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countChar += 1;
                if (i != str.Length - 1)
                {
                    if (str[i] != str[i+1])
                    {
                        sb.Append(str[i]);
                        sb.Append(countChar);
                        countChar = 0;
                    }
                }
                else
                {
                    sb.Append(str[i]);
                    sb.Append(countChar);
                }
            }

            if (str.Length <= sb.Length) return str;

            return sb.ToString();
        }

        public void Run()
        {
            Console.WriteLine(StringCompression("aabcccccaaa"));
            Console.WriteLine(StringCompression("aabbcc"));
        }
    }
}
