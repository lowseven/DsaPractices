using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility
{
    public static class CyclicRotationProblem
    {
        //https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/

        public static int[] Solution(int[] a, int k)
        {
            if (a.Length == 0)
                return a;
            var l = new LinkedList<int>(a);

            while (k > 0)
            {
                var val = l.Last.Value;
                l.RemoveLast();
                l.AddFirst(val);
                k--;
            }

            return l.ToArray();
        }
    }
}
