using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class DivisibleSumPairsProblem
{
    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */
    //https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
    public static int DivisibleSumPairs(int n, int k, List<int> ar)
    {
        int res = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            for (int j = i; j < ar.Count; j++)
            {
                if (i == j)
                    continue;

                if ((ar[i] + ar[j]) % k == 0)
                    res++;
            }
        }

        return res;
    }
}
