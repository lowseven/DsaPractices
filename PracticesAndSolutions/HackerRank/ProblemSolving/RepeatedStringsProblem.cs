namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/repeated-string
public static class RepeatedStringsProblem
{
    public static long RepeatedString(string s, long n)
    {
        var aCount = s.Count(a => a == 'a');
        if (aCount == 0)
            return 0;

        long repetitions = (n / s.Length) * aCount;

        return repetitions + s.Take((int)(n - (n / s.Length)*s.Length)).Count(a => a == 'a');
    }
}
