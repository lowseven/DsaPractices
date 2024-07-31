using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class PalindromeNumberProblem
    {
        //https://leetcode.com/problems/palindrome-number/description/
        public static bool IsPalindrome(int x)
        {
            /* without converting "x" into string
              int r = 0, c = x;
                while (c > 0)
                {
                    r = r * 10 + c % 10;//reverse int
                    c /= 10;
                }
                return r == x; 
             */


            var xx = x.ToString();
            var XXRight = xx.Length - 1;
            for (var i = 0; i < xx.Length && XXRight > 0; i++)
            {
                if (xx[i] != xx[XXRight])
                    return false;
                else if (i == XXRight)
                    return true;
                XXRight--;
            }

            return true;
        }
    }
}
