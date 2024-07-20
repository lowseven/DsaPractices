using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class GuessNumberHigherorLowerProblem : GuessGame
    {
        //https://leetcode.com/problems/guess-number-higher-or-lower/description/
        public int GuessNumber(int n)
        {
            var arr = new uint[32];
            var i = 1;
            for (; i < 31; ++i)
            {
                arr[i] = (uint)Math.Pow(2, i);
                var g = guess((int)arr[i]);
                if (g == 0)
                    return (int)arr[i];
                else if (g == -1)
                    break;
            }

            uint left = arr[i - 1];
            uint right = (uint)n;
            while (left <= right)
            {
                var m = (left + right) / 2;
                if (guess((int)m) == 0)
                    return (int)m;
                else if (guess((int)m) == 1)
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
    }
    public abstract class GuessGame
    {
        protected virtual int guess(int n) { return 0; }
    }
}
