using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class SearchA2DMatrixProblem
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var left = 0;
            var right = matrix[0].Length * matrix.Length - 1;

            while (left <= right)
            {
                var m = (left + right) / 2;
                var val = matrix[(m / matrix[0].Length)][m % matrix[0].Length];
                if (val == target)
                    return true;
                else if (target > val)
                    left = m + 1;
                else
                    right = m - 1;
            }

            return false;


            /*
               var arr = new int[matrix[0].Length * matrix.Length];
                var column = 0;
                for (var i = 0; i < arr.Length; i++)
                {
                    if (i != 0 && i % matrix[0].Length == 0)
                        column++;
                    arr[i] = matrix[column][i % matrix[0].Length];
                }

                var left = 0;
                var right = arr.Length - 1;

                while (left <= right)
                {
                    var m = (left + right) / 2;
                    if (arr[m] == target)
                        return true;
                    else if (target > arr[m])
                        left = m + 1;
                    else
                        right = m - 1;
                }

                return false;
             */
        }
    }
}
