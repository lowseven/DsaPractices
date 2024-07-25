using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class KokoEatingBananasProblem
    {
        //https://leetcode.com/problems/koko-eating-bananas/description/
        public static int MinEatingSpeed(int[] piles, int h)
        {
            long right = 0;
            for (int i = 0; i < piles.Length; ++i)
                right = piles[i] < right ? right : piles[i];

            long left = 1;
            long res = right;
            while (left <= right)
            {
                var m = (left + right) / 2;
                double sum = 0;
                for (int i = 0; i < piles.Length; i++)
                    sum += Math.Ceiling(piles[i] * 1.0 / m);

                if (sum <= h)
                {
                    res = Math.Min(res, m);
                    right = m - 1;
                }
                else
                    left = m + 1;
            }

            return (int)res;
        }
    }
}
