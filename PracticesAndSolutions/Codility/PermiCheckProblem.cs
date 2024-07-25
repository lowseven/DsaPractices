using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility
{
    public class PermiCheckProblem
    {
        public static int Solution(int[] A)
        {
            var h = new HashSet<int>(100_000);
            for (int i = 0; i < A.Length; i++)
            {
                if (h.Contains(A[i]) == false)
                    h.Add(A[i]);
                else
                    return 0;
            }

            for (int i = 0; i < A.Length; i++)
                if (h.Contains(i + 1) == false)
                    return 0;

            return 1;
        }
    }
}
