namespace PracticesAndSolutions.HackerRank.ProblemSolving;

//https://www.hackerrank.com/challenges/circular-array-rotation/problem
public static class CircularArrayRotationProblem
{
    /*
     * Complete the 'circularArrayRotation' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER k
     *  3. INTEGER_ARRAY queries
     */

    public static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
    {
        var res = new List<int>();
        var ll = new LinkedList<int>(a);
        while (k > 0)
        {
            var item = ll.Last;
            ll.RemoveLast();
            ll.AddFirst(item!.Value);

            k--;
        }

        a = ll.ToList();
        foreach (var q in queries)
            res.Add(a[q]);
        return res;
    }
}
