using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticesAndSolutions.HackerRank.ProblemSolving
{
    //https://www.hackerrank.com/challenges/kangaroo/problem
    public static class KangarooProblem
    {
        /* Complete the 'kangaroo' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER x1
         *  2. INTEGER v1
         *  3. INTEGER x2
         *  4. INTEGER v2
         */

        /*
         check your obsidian notes "Relative Velocity"

        Key Points:
        - The formula is valid only when (v_2 != v_1).
        - If (v_2 = v_1), the cars move in parallel, 
          and they never meet unless they started at the 
          same position.
         */

        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if (v1 != v2)
            {
                double jumps = (double)(x2 - x1) / (v1 - v2);

                if (jumps % 1 == 0 && jumps > 0)
                {
                    return "YES";
                }

            }

            return "NO";
        }
    }
}
