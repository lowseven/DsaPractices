using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.Daylies
{
    //https://www.hackerrank.com/challenges/strange-advertising/problem 
    public static class ViralAdvertisingProblem
    {
        /*
         * Complete the 'viralAdvertising' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int ViralAdvertising(int n)
        {
            var set = new Dictionary<int, int>();
            var shared = 5;
            var cummulative = 0;
            for (int i = 1; i <= n; i++)
            {
                var likes = shared / 2;

                cummulative += likes;
                set[i] = cummulative;

                shared = likes * 3;
            }

            return set[n];
        }
    }
}
