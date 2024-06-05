using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.ProblemSolving
{
    //https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    public static class BirthdayCandles
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int BirthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            return candles.Sum(i => i == candles.Last() ? 1 : 0);
        }
    }
}
