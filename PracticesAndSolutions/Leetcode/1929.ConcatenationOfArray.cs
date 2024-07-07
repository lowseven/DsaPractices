using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

public static class ConcatenationOfArrayProblem
{
    public static int[] GetConcatenation(int[] nums)
    {
        var res = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length; ++i)
        {
            res[i] = nums[i];
            res[i + nums.Length] = nums[i];
        }

        return res;
    }
}
