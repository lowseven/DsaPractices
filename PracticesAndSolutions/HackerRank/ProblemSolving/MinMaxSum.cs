using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true
public static class MinMaxSum
{
    public static Tuple<long, long> MiniMaxSum(List<int> arr)
    {
        long min = arr.Min();
        long max = arr.Max();

        arr.Sort();

        var arr2 = arr.Select(i => (long)i);
        arr2 = arr2.Skip(1).SkipLast(1).ToList();
        long sum = arr2.Sum(i => i);

        return Tuple.Create(sum + min, sum + max);
    }
}
