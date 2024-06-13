namespace PracticesAndSolutions.HackerRank.Daylies;

//https://www.hackerrank.com/challenges/counting-valleys/problem
public static class CountingValeysProblem
{
    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int CountingValleys(int steps, string path)
    {
        int valleysCount = 0;
        int init = 0;

        foreach (var p in path)
        {
            var incr = p == 'U' ? 1 : -1;

            if (init < 0 && init + incr == 0)
                valleysCount++;

            init += incr;
        }
        return valleysCount;
    }
}
