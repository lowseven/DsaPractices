using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public static class ClimbingStarsProblem
    {
        public static int ClimbStairs(int n)
        {
            //O(1) on space...but still O(n) runtime
            //var prev = 1;
            //var curr = 1;
            //while (n > 1)
            //{
            //    var t = curr;
            //    curr += prev;
            //    prev = t;
            //    n--;
            //}
            if (n <= 2)
                return n;

            var stack = new List<int>() {
                  0,1,1,2
              };

            while (n > 2)
            {
                stack.Add(stack[stack.Count - 2] + stack[stack.Count - 1]);
                n--;
            }

            return stack[stack.Count - 1];
        }
    }
}
