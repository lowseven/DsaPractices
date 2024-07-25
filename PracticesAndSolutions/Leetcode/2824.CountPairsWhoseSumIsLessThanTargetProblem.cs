namespace PracticesAndSolutions.Leetcode;

public class CountPairsWhoseSumIsLessThanTargetProblem
{
    //https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/description/
    public static int CountPairs(IList<int> nums, int target)
    {
        var count = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (i != j && i < j)
                    if (nums[i] + nums[j] < target)
                        count++;
            }
        }

        return count;
    }
}
