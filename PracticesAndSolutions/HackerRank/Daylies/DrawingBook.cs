using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.Daylies
{
    //https://www.hackerrank.com/challenges/drawing-book/problem
    public static class DrawingBook
    {
        /*
        * Complete the 'pageCount' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. INTEGER p
        */

        public static int PageCount(int n, int p)
        {
            var ind = n / 2;
            var left = p / 2;

            if (ind < left)
                return 0;

            var right = ind - p / 2;

            return left <= right ? left : right;
        }
    }
}
