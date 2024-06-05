using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.HackerRank.Daylies;

//https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
public static class BeautifulDaysAtTheMovies
{
    /*
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i
     *  2. INTEGER j
     *  3. INTEGER k
     */

    public static int BeautifulDays(int i, int j, int k)
    {
        var bDays = 0;

        for (; i <= j; ++i)
        {
            var number = int.Parse(string.Join("", i.ToString().Reverse()));
            var bNumber = i - number;
            if (bNumber % k == 0)
            {
                bDays++;
            }
        }

        return bDays;
    }
}
