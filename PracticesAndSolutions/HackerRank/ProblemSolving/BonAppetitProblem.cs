namespace PracticesAndSolutions.HackerRank.ProblemSolving;

public static class BonAppetitProblem
{
    //https://www.hackerrank.com/challenges/bon-appetit/problem
    /*
      * Complete the 'bonAppetit' function below.
      *
      * The function accepts following parameters:
      *  1. INTEGER_ARRAY bill
      *  2. INTEGER k
      *  3. INTEGER b
      */

    public static string BonAppetit(List<int> bill, int k, int b)
    {
        var sum = 0;
        for (int i = 0; i < bill.Count; i++)
        {
            if (i == k) continue;
            sum+= bill[i];
        }

        //Console.WriteLine((sum / 2) == b
        //    ? "Bon Appetit"
        //    : (b - (sum / 2)));
        return (sum / 2) == b
            ? "Bon Appetit"
            : (b - (sum / 2)).ToString();
    }
}
