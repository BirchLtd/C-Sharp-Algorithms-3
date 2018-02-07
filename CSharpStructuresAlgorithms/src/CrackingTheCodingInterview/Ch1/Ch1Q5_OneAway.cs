using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Ch1Q5_OneAway
    {
        public bool OneAway(string x, string y)
        {
            if (x == null || y == null) return false;

            int wrongCounter = 0; // count how many errors
            int xPosition = 0;
            int yPosition = 0;

            while(wrongCounter <= 1 && xPosition < x.Length && yPosition < y.Length)
            {
                Console.WriteLine(xPosition + " " + yPosition);
                // If the positions have unequal values
                if(x[xPosition] != y[yPosition])
                {
                    wrongCounter++;
                    if (x[++xPosition] == y[++yPosition])  // is one character different / wrong
                    {
                        continue;
                    }
                    else if (x[++xPosition] == y[yPosition]) xPosition += 1;  // is one word longer than the other 
                    else if (y[++yPosition] == x[xPosition]) yPosition += 1;  // is one word longer than the other 
                    else return false;
                }
                xPosition++;
                yPosition++;
            }

            if (wrongCounter > 1) return false;

            return true;
        }

        public void Run()
        {
            Console.WriteLine(OneAway("pale", "ple"));
            Console.WriteLine(OneAway("pales", "pale"));
            Console.WriteLine(OneAway("pale", "bale"));
            Console.WriteLine(OneAway("pale", "bake"));
        }
    }
}
