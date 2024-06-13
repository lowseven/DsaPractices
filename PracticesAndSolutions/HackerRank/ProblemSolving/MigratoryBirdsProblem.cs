using System.Collections.Specialized;

namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/migratory-birds/problem
public static class MigratoryBirdsProblem
{
    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int MigratoryBirds(List<int> arr)
    {
        //note from the problem: It is guaranteed that each type is 1, 2, 3, 4, or 5
        var a = new int[5];
        foreach (int i in arr)
        {
            a[i - 1]++;
        }

        int b = 0;
        int maxCount = 0;
        for (int i = 0; i < a.Length; ++i)
        {
            if (a[i] >= maxCount)
            {
                if (a[i] == maxCount)
                    b = Math.Min(b, i);
                else
                    b = i;
                maxCount = a[i];
            }
        }

        return b + 1;
    }
}
