namespace PracticesAndSolutions.Codility
{
    public class MaxCountersProblem
    {
        public static int[] Solution(int N, int[] A)
        {
            int[] ints = new int[N];
            var counterMax = 0;
            var globalMax = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] <= N)
                {
                    if (ints[A[i] - 1] < globalMax)
                    {
                        ints[A[i] - 1] = globalMax;
                    }

                    ints[A[i] - 1]++;
                    if (counterMax < ints[A[i] - 1])
                        counterMax = ints[A[i] - 1];
                }
                else
                {
                    globalMax = counterMax;
                }
            }

            for (int i = 0; i < A.Length; ++i)
                if (A[i] < globalMax)
                    A[i] = globalMax;

            return ints;
        }
    }
}
