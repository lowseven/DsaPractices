using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility
{
    //https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
    public class FrogRiverOneProblem
    {
        public static int Solution(int X, int[] A)
        {
            var b = new bool[X];
            for (int i = 0; i < A.Length; i++)
            {
                if (b[A[i - 1]] == false)
                {
                    b[A[i] - 1] = true;
                    X--;
                    if (X == 0)
                        return i;
                }
            }


            return -1;
        }
    }
}
