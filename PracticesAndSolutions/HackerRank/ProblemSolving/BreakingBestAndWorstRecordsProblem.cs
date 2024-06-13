namespace PracticesAndSolutions.HackerRank.ProblemSolving
{
    //https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    public static class BreakingBestAndWorstRecordsProblem
    {
        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */

        public static List<int> BreakingRecords(List<int> scores)
        {
            var min = scores[0];
            var max = scores[0];
            var minCount = 0; var maxCount = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] < min)
                {
                    minCount++;
                    min = scores[i];
                }

                if (scores[i] > max)
                {
                    maxCount++;
                    max = scores[i];
                }
            }

            return [maxCount, minCount];
        }
    }
}
