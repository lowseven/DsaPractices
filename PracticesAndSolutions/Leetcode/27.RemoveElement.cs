using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

public static class RemoveElementProblem
{
    //https://leetcode.com/problems/remove-element/description/
    public static int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;

        var ii = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[ii] = nums[i];
                ii++;
            }
        }

        return ii;//n-1
    }
}
