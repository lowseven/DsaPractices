using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public class LongestCommonPrefixProblem
    {
        //https://leetcode.com/problems/longest-common-prefix/description/
        public static string LongestCommonPrefix(string[] strs)
        {
            var res = strs[0];
            while (res.Length > 0)
            {
                var startWith = true;
                for (int i = 1; i < strs.Length; i++)
                {
                    startWith &= strs[i].StartsWith(res);
                }

                if (startWith == false)
                    res = res.Substring(0, res.Length - 1);
                else
                    return res;
            }

            return res;
        }
    }
}
