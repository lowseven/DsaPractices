using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Codility;

public static class FrogJmpProblem
{
    public static int Solution(int X, int Y, int D)
    {
        return (int)Math.Ceiling((decimal)((Y - X) / (D * 1.0)));

    }
}
