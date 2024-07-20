using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    public static class ValidAnagramProblem
    {
        //https://leetcode.com/problems/valid-anagram/description/

        //another approach, more efficient as we dont need to sort
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var arr = new int[26];
            for (int i = 0; i < s.Length; i++)
                arr[s[i] - 'a']++;

            for (int i = 0; i < t.Length; i++)
            {
                if (arr[t[i] - 'a'] > 0)
                    arr[t[i] - 'a']--;
                else
                    return false;
            }

            return true;
        }

        //public static bool IsAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //        return false;

        //    var ss = s.ToCharArray();
        //    var tt = t.ToCharArray();
        //    Array.Sort(ss);
        //    Array.Sort(tt);

        //    return ss.SequenceEqual(tt);
        //}
    }
}
