using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    //https://leetcode.com/problems/binary-gap/

    public class BinaryGapProblem
    {
        public static int BinaryGap(int n)
        {
            var bin = Convert.ToString(n, 2);
            var counter = 0;
            var left = 0;
            for (int i = 0; i < bin.Length; ++i)
            {
                if (bin[i] == '1')
                {
                    counter = Math.Max(counter, i - left);
                    left = i;
                }
            }

            return counter;
        }
    }
}
