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
    //https://www.hackerrank.com/challenges/between-two-sets/problem
    public static class BetweenTwoSets
    {

        /* Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int GetTotalX(List<int> a, List<int> b)
        {
            var l = new List<int>(a);
            l.AddRange(b);

            var min = l.Min();
            var max = l.Max();
            var count = 0;

            for (var i = min; i <= max; ++i)
            {
                if (a.All(aa => i % aa == 0) && b.All(aa => aa % i == 0))
                    count++;
            }

            return count;
        }

    }
}
