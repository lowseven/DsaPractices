using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    //https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
    public class EvaluateReversePolishNotationProblem
    {
        public static int EvalRPN(string[] tokens)
        {
            var s = new Stack<int>();
            for (int i = 0; i < tokens.Length; ++i)
            {
                int res;
                int a;
                int b;
                switch (tokens[i])
                {
                    case "/":
                        a = s.Pop();
                        b = s.Pop();
                        res = b / a;
                        s.Push(res);
                        break;
                    case "-":
                        a = s.Pop();
                        b = s.Pop();
                        res = b - a;
                        s.Push(res);
                        break;
                    case "+":
                        a = s.Pop();
                        b = s.Pop();
                        res = b + a;
                        s.Push(res);
                        break;
                    case "*":
                        a = s.Pop();
                        b = s.Pop();
                        res = b * a;
                        s.Push(res);
                        break;
                    default:
                        s.Push(int.Parse(tokens[i]));
                        break;
                }
            }

            return s.Peek();
        }
    }
}
