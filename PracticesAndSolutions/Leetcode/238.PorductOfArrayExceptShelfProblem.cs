using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/product-of-array-except-self/description/
public static class ProductOfArrayExceptShelfProblem
{
    public static int[] ProductExceptSelf(int[] nums)
    {

        //------------------------------------
        // O(n) time and O(1) space
        var res = new int[nums.Length];
        var prefix = 1;
        for (var i = 0; i < nums.Length; ++i)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }

        var postfix = 1;
        for (var i = nums.Length - 1; i >= 0; --i)
        {
            res[i] *= postfix;
            postfix *= nums[i];
        }

        return res;

        //------------------------------------
        //erro: TME
        //var res = new int[nums.Length];
        //for (int i = 0; i < nums.Length; i++)
        //{       
        //    var sum = 1;
        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        if (i == j) 
        //            continue;

        //        sum *= nums[j];
        //    }

        //    res[i] = sum;
        //}

        //return res;

        //------------------------------------
    }
}
