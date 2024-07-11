namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/valid-parentheses/
public static class ValidateParenthesisProblem
{
    public static bool IsValid(string s)
    {
        //with hashmap
        var stack = new Stack<char>();
        var hm = new Dictionary<char, char>()
        {
            [']'] = '[',
            ['}'] = '{',
            [')'] = '(',
        };

        var count = 0;
        while (count < s.Length)
        {
            if (!hm.ContainsKey(s[count]))
                stack.Push(s[count]);
            else
            {
                if (stack.Count == 0)
                    return false;
                if (hm[s[count]] == stack.Peek())
                    stack.Pop();
                else
                    return false;
            }

            count++;
        }

        return stack.Count == 0;

        //----------------------
        //clever dolution took from the submissions but is O(n^2) due to the s.Contains(...)
        //while (s.Contains("()")
        //    || s.Contains("[]")
        //    || s.Contains("{}"))
        //{
        //    s = s.Replace("[]", string.Empty).Replace("{}", string.Empty).Replace("()", string.Empty);
        //}

        //return s.Length == 0;

        //----------------------
        //OK solution 34.21% - O(n) runtime and O(n) space
        //var stack = new Stack<char>();
        //var count = 0;
        //while (count < s.Length)
        //{
        //    if (s[count] == '('
        //        || s[count] == '['
        //        || s[count] == '{')
        //        stack.Push(s[count]);
        //    else
        //    {
        //        if(stack.Count == 0)
        //            return false;

        //        var p = stack.Peek();
        //        if (s[count] == ')' && p != '('
        //            || s[count] == ']' && p != '['
        //            ||  s[count] == '}' && p != '{')
        //                break;
        //        stack.Pop();

        //    }
        //    count++;
        //}

        //return stack.Count == 0;
    }
}
