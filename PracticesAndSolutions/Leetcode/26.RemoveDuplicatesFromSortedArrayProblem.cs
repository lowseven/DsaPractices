using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
public static class RemoveDuplicatesFromSortedArrayProblem
{
    public static int RemoveDuplicates(int[] nums)
    {
        //was ok but i have to change "nums" array directly
        //var newNums = new int[nums.Length];
        //var newI = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    newNums[newI] = nums[i];
        //    for (int ii = i + 1; ii < nums.Length - 1; ii++)
        //    {
        //        if (nums[i] != nums[ii])
        //            break;

        //        i++;
        //    }
        //    newI++;
        //}

        var i = 0;
        for (int ii = 1; ii < nums.Length; ii++)
        {
            if (nums[i] != nums[ii])
            {
                i++;
                nums[i] = nums[ii];
            }
        }

        return i + 1;//n-1

        //int j = 0;
        //for (int i = 1; i < nums.Length; i++)
        //{
        //    if (nums[j] != nums[i])
        //    {
        //        nums[++j] = nums[i];
        //    }
        //}

        //return j + 1;
    }
}
