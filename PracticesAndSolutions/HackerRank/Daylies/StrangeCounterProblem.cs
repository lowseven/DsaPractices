namespace PracticesAndSolutions.HackerRank.Daylies;

//https://www.hackerrank.com/challenges/strange-code/problem
public static class StrangeCounterProblem
{
    /*
         * Complete the 'strangeCounter' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER t as parameter.
         */

    public static long StrangeCounter(long t)
    {
        //ERROR: TME
        //var counter = 3;
        //var ct = 1;

        //while (ct + counter <= t)
        //{
        //    ct += counter;
        //    counter *= 2;
        //}

        //var i = counter;
        //for (; i > 0 && t != ct; i--)
        //    ct++;

        //return i;
        //------
        // best solution that i found in c# in the discussion tab
        /*
            long cycle = 1;
            for (long i = 0; i < 41; i++)
            {
            cycle = (long)(cycle + (3 * Math.Pow(2,i)));
            if (cycle > t)
                {
                break;
                }
            }
            return (cycle - t);
         */
        //------

        //------

        //Sumbited in c++
        var counter = 3;
        var ct = 3;
        while (t > ct)
        {
            counter *= 2;
            ct += counter;
        }

        return ct - t + 1;
    }
}
