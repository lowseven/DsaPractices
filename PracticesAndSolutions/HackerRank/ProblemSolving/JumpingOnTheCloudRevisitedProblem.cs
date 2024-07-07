namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem
public static class JumpingOnTheCloudRevisitedProblem
{
    public static int JumpingOnClouds(int[] c, int k)
    {
        var e = 100;
        var i = 0;

        do
        {
            e -= c[i] == 1 ? 3 : 1;
            i = (i + k) % c.Length;
        } while (i != 0);

        return e;
    }
}
