namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/two-sum
public static class TwoIntegerSumProblem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        //Brute force o(n^2)
        //for (var i = 0; i < nums.Length; ++i)
        //{
        //    for (var j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] + nums[j] == target)
        //            return new int[] { i, j };
        //    }
        //}

        //return new int[0];


        //-------
        //improve to O(n) and space O(n)

        var cache = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; ++i)
        {
            var key = target - nums[i];
            if (cache.ContainsKey(key))
                //return new int[] { Math.Min(i, cache[key]), Math.Max(i, cache[key]) };
                return new int[] { cache[key], i };
            else
                cache[nums[i]] = i;
        }

        return new int[0];
    }
}
