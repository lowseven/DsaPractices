using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    //https://leetcode.com/problems/first-bad-version/description/
    public class FirstBadVersionProblem
    {
        public static int FirstBadVersion(int n)
        {
            if (n == 1)
                return 1;

            long left = 1;
            long right = n;
            while (left <= right)
            {
                long m = (left + right) / 2;

                var isBadV = IsBadVersion((int)m);
                if (isBadV)
                    right = m - 1;
                else
                    left = m + 1;
            }
            return (int)left;
        }

        public static bool IsBadVersion(int i)
        {
            return i >= 1702766719;
        }
    }
}
