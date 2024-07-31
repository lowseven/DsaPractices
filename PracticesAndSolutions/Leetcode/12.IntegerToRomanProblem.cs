using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class IntegerToRomanProblem
    {
        //https://leetcode.com/problems/integer-to-roman/description/
        public string IntToRoman(int num)
        {
            var dict = new Dictionary<int, string>
            {
                [1] = "I",
                [4] = "IV",
                [5] = "V",
                [9] = "IX",
                [10] = "X",
                [40] = "XL",
                [50] = "L",
                [90] = "XC",
                [100] = "C",
                [400] = "CD",
                [500] = "D",
                [900] = "CM",
                [1000] = "M",
            };

            var l = dict.Keys.ToList();
            var i = l.Count - 1;
            var res = "";
            while (num > 0)
            {
                if (num / l[i] > 0)
                {
                    res += dict[l[i]];
                    num -= l[i];
                }
                else
                {
                    i--;
                }
            }

            return res;
        }
    }
}
