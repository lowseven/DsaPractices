using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility
{
    //https://app.codility.com/programmers/lessons/1-iterations/binary_gap/start/
    public static class BinaryGapProblem
    {
        public static int Solution(int N)
        {
            var bin = Convert.ToString(N, 2);
            var res = 0;
            var left = 0;
            var right = 1;

            while (right < bin.Length && left < bin.Length)
            {
                if (bin[left] == '1')
                {
                    if (bin[right] == '0')
                    {
                        right++;
                    }
                    else
                    {
                        res = Math.Max(res, right - left - 1);
                        left = right;
                        right++;
                    }
                }
                else
                {
                    left++;
                }

            }


            return res;
        }
    }
}
