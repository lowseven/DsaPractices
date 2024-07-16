using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility;

public static class OddOcurrencyInArrayProblem
{
    //https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
    public static int Solution(int[] A)
    {
        var s = new Dictionary<int, int>();

        for (int i = 0; i < A.Length; i++)
        {
            if (s.ContainsKey(A[i]) == false)
                s.Add(A[i], A[i]);
            else
                s.Remove(A[i]);
        }

        return s.Values.First();
    }
}
