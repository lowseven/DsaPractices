namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/save-the-prisoner/problem
public static class SaveThePrisionerProblem
{
    /*
    * Complete the 'saveThePrisoner' function below.
    *
    * The function is expected to return an INTEGER.
    * The function accepts following parameters:
    *  1. INTEGER n
    *  2. INTEGER m
    *  3. INTEGER s
    */

    public static int SaveThePrisoner(int n, int m, int s)
    {
        var res = (s + m - 1) % n;
        return res == 0 ? n : res;
    }
}
