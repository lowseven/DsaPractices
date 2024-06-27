namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/permutation-equation/problem
public static class PermutationEquationProblem
{
    /*
     * Complete the 'permutationEquation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY p as parameter.
     */

    public static List<int> PermutationEquation(List<int> p)
    {
        var res = new List<int>();
        var max = p.Max();
        var d = new Dictionary<int, int>(p.Count);

        for (int i = 0; i < p.Count; i++)
            d.Add(p[i], i + 1);

        for (int i = 1; i <= max; i++)
        {
            res.Add(d[d[i]]);
        }

        return res;
    }
}
