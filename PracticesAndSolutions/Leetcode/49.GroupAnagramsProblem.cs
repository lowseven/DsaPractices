namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/remove-element/description/
public static class GroupAnagramsProblem
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var kl = strs[i].ToList();
            kl.Sort();

            var k = string.Join("", kl);
            if (dict.ContainsKey(k))
                dict[k].Add(strs[i]);
            else
            {
                dict[k] = new List<string>()
         {
             strs[i]
         };
            }
        }

        var list = new List<IList<string>>();
        foreach (var key in dict.Keys)
        {
            list.Add(dict[key]);
        }

        return list;
    }
}
