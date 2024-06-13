namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class TheBirthdayBarProblem
{
    //https://www.hackerrank.com/challenges/the-birthday-bar/problem
    /*
    * Complete the 'birthday' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER_ARRAY s
    *  2. INTEGER d
    *  3. INTEGER m
    */

    public static int Birthday(List<int> s, int d, int m)
    {
        var res = 0;
        for (var i = 0; i < s.Count; i++)
        {
            var sum = 0;
            var j = 0;
            for (; j < m && j + i < s.Count; j++)
            {
                sum += s[j + i];
            }

            if (j == m && sum == d)
                res++;
        }

        return res;
    }

}
