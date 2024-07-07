namespace HackerRankTest.Daylies;

//https://www.hackerrank.com/challenges/lisa-workbook/problem
public static class LisaWorkbookProblem
{
    /*
     * Complete the 'workbook' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY arr
     */

    public static int Workbook(int n, int k, List<int> arr)
    {
        var pageIndex = 1;
        var specialProblems = 0;
        var chProb = 0;
        foreach (int i in arr)
        {
            var prob = i;//cannot hange foreach iterator values at runtime
            while (prob > 0)
            {
                int pgprob = Math.Min(k, prob);
                chProb += pgprob;

                if (pageIndex >= (chProb - pgprob + 1) && pageIndex <= chProb)
                    specialProblems++;

                prob -= pgprob;
                pageIndex++;
            }

            chProb = 0;
        }

        return specialProblems;
    }
}
