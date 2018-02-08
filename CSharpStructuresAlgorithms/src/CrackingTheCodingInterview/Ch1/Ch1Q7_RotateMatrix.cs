using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStructuresAlgorithms.src.CrackingTheCodingInterview.Ch1
{
    class Ch1Q7_RotateMatrix
    {
        public void RotateMatrix(int[][] matrix)
        {
            int matrixLength = matrix.Length;

            for (int layer = 0; layer < matrixLength / 2; layer++)
            {
                int first = layer; // first element of layer starts at top left layer corner
                int last = (matrixLength - 1) - layer; // last element of layer start at end of array, then go in layer # towards center

                for (int i = first; i < last; i++) // for the chosen layer
                {
                    int offset = i - first; // for layers other than the top layer, offset helps keep on layer
                    // save top left
                    int top = matrix[first][i];
                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];
                    //  bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];
                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];
                    // top -> right
                    matrix[i][last] = top;
                }
            }
        }

        public void Run()
        {

        }
    }
}
