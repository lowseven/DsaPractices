namespace PracticesAndSolutions.Codility;

public static class TapeEquilibriumProblem
{
    //https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
    public static int Solution(int[] A)
    {
        var total = A.Sum();
        var leftSum = A[0];
        var rightSum = total - leftSum;
        var min = Math.Abs(rightSum - leftSum);
        for (var i = 1; i < A.Length - 1; i++)
        {
            leftSum += A[i];
            rightSum = total - leftSum;
            var ope = Math.Abs(rightSum - leftSum);
            if (min > ope)
                min = ope;
        }

        return min;
    }
}
