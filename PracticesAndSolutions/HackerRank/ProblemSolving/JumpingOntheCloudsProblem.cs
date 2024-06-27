namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class JumpingOntheCloudsProblem
{
    //https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int JumpingOnClouds(List<int> c)
    {
        var jumps = 0;
        for (var i = 0; i < c.Count; i++)
        {
            if ((i + 2 < c.Count && c[i + 2] == 0))
            {
                jumps++;
                i++;
            }
            else if (i + 1 < c.Count && c[i + 1] == 0)
                jumps++;
        }

        return jumps;
    }

}
