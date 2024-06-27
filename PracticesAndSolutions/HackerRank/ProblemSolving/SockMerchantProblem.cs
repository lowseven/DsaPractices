namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class SockMerchantProblem
{
    //https://www.hackerrank.com/challenges/sock-merchant/problem
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int SockMerchant(int n, List<int> ar)
    {
        var s = new Dictionary<int, int>();
        foreach (var a in ar)
        {
            if (s.ContainsKey(a) is false)
                s.Add(a, 0);
            s[a]++;
        }

        int sum = 0;
        foreach (var k in s.Keys)
        {
            var val = s[k] / 2;
            if (val > 0)
                sum += val;
        }

        return sum;
    }
}
