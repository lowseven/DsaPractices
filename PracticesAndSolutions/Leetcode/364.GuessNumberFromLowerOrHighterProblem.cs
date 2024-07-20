using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class GuessNumberFromLowerOrHighterProblem
    {
        public static int GuessNumber(int n)
        {
            long left = 1;
            long right = n;
            while (left <= right)
            {
                var m = (left + right) / 2;
                var g = guess((int)m);
                if (g == 0)
                    return (int)m;
                else if (g == 1)
                {
                    left = m + 1;
                }
                else
                {
                    right = m - 1;
                }
            }

            return -1;
        }

        public static int guess(int n)
        {
            return -1;
        }
    }
}
