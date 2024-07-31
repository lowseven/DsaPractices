using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class RomanToIntegerProblem
    {
        //https://leetcode.com/problems/roman-to-integer/description/
        public static int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>
            {
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000,
            };

            var prev = s[s.Length - 1];
            var sum = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (dict[s[i]] < dict[prev])
                    sum -= dict[s[i]];
                else
                    sum += dict[s[i]];
                prev = s[i];
            }

            return sum;
        }
    }
}
