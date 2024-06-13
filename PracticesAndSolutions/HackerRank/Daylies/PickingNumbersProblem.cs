using System.Collections.Specialized;

namespace PracticesAndSolutions.HackerRank.Daylies;

//https://www.hackerrank.com/challenges/picking-numbers/problem
public static class PickingNumbersProblem
{
    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int PickingNumbers(List<int> a)
    {
        int max = 0;
        for (int i = 0; i < a.Count; i++)
        {
            var l = new List<int>();
            for (int j = 0; j < a.Count; j++)
            {
                if (a[i] == a[j]
                    || (a[i] - 1 >= 0 && a[i] - 1 == a[j]))
                    l.Add(a[j]);
            }

            max = l.Count > max ? l.Count : max;
        }

        return max;
    }
}