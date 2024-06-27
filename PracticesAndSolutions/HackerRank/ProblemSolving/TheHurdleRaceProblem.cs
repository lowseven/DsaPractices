namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class TheHurdleRaceProblem
{
    //https://www.hackerrank.com/challenges/the-hurdle-race/problem
    /*
    * Complete the 'hurdleRace' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER k
    *  2. INTEGER_ARRAY height
    */

    public static int HurdleRace(int k, List<int> height)
    {
        var max = 0;
        foreach (var i in height)
            if (i > max) max = i;

        return max > k ? Math.Abs(max - k) : 0;
    }
}
