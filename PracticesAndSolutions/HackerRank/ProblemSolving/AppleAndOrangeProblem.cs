using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class AppleAndOrangeProblem
{
    //https://www.hackerrank.com/challenges/apple-and-orange/problem
    /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

    public static string CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var applesCount = 0;
        var orangesCount = 0;
        foreach (var i in apples)
        {
            if (a + i >= s && a + i <= t)
                applesCount++;
        }

        foreach (var i in oranges)
        {
            if (b + i >= s && b + i <= t)
                orangesCount++;
        }
        //Console.WriteLine($"{applesCount}{Environment.NewLine}{orangesCount}");
        return $"{applesCount} {orangesCount}";
    }
}
