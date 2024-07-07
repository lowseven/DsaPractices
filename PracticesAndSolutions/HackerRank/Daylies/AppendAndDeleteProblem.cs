namespace PracticesAndSolutions.HackerRank.Daylies;

//https://www.hackerrank.com/challenges/append-and-delete/problem
public static class AppendAndDeleteProblem
{
    /*
    * Complete the 'appendAndDelete' function below.
    *
    * The function is expected to return a STRING.
    * The function accepts following parameters:
    *  1. STRING s
    *  2. STRING t
    *  3. INTEGER k
    */

    public static string AppendAndDelete(string s, string t, int k)
    {
        if (k >= t.Length + s.Length)
            return "Yes";

        var min = Math.Min(t.Length, s.Length);
        var i = 0;
        for (; i < min && t[i] == s[i]; i++) ;

        k -= t.Length - i;
        k -= s.Length - i;

        return (k >= 0 && k % 2 == 0) ? "Yes" : "No";
    }

}
