using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility
{
    internal class MissingIntegerProblem
    {
        //https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
        public static int Solution(int[] A)
        {
            var dict = new Dictionary<int, bool>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0 || dict.ContainsKey(A[i]))
                    continue;
                else
                {
                    dict.Add(A[i], true);
                }
            }

            var result = 1;
            while (dict.ContainsKey(result))
                result++;

            return result;
        }
    }
}
