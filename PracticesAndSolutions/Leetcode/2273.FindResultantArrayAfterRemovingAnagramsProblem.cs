namespace PracticesAndSolutions.Leetcode;

public class FindResultantArrayAfterRemovingAnagramsProblem
{
    //https://leetcode.com/problems/find-resultant-array-after-removing-anagrams/description/
    public static IList<string> RemoveAnagrams(string[] words)
    {
        var l = new List<string>();
        var lastAna = string.Empty.ToCharArray();

        for (int i = 0; i < words.Length; i++)
        {
            var w1 = words[i].ToCharArray();
            Array.Sort(w1);

            if (w1.SequenceEqual(lastAna) == false)
            {
                l.Add(words[i]);
                lastAna = words[i].ToCharArray();
                Array.Sort(lastAna);
            }
        }

        return l;
    }
}
