namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class GetMoneySpentProblem
{
    /*
    * Complete the getMoneySpent function below.
    */
    public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
    {
        var expensive = 0;
        foreach (var k in keyboards)
        {
            if (b - k <= 0)
                continue;

            foreach (var d in drives)
            {
                if (b - k - d < 0)
                    continue;
                expensive = expensive < k + d ? k + d : expensive;
            }
        }

        return expensive == 0 ? -1 : expensive;
    }
}
