using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility
{
    //https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem
    //there is a formula -> http://en.wikipedia.org/wiki/1_%2B_2_%2B_3_%2B_4_%2B_%E2%8B%AF
    //https://stackoverflow.com/a/57085596
    public static class PermMissingElementProblem
    {
        public static int Solution(int[] A)
        {
            if (A.Length == 0)
                return 1;

            var sumA = 0;
            foreach (int i in A)
                sumA += i;

            var sumB = 0;
            for (int i = 1; i <= A.Length + 1; i++)
                sumB = sumB + i;

            if (sumA == sumB)
                return A.Length;

            return sumB - sumA;
        }
    }
}
