using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/baseball-game/description/
public static class BaseBallGameProblem
{
    public static int CalPoints(string[] operations)
    {

        //Improved solution
        //use a simple for-loop instead of for each so we dont call the IEnumerable
        //and have a O(1) array lookup
        //--- SOLUTION OK: 85.33% TOP

        var stack = new Stack<int>(1000);// max length
        var sum = 0;
        for (var i = 0; i < operations.Length; ++i)
        {
            if (operations[i] == "C")
            {
                sum -= stack.Pop();
            }
            else if (operations[i] == "D")
            {
                var t = stack.Peek() * 2;
                stack.Push(t);

                sum += t;
            }
            else if (operations[i] == "+")
            {
                var t = stack.ElementAt(0) + stack.ElementAt(1);
                stack.Push(t);
                sum += t;
            }
            else
            {
                var t = int.Parse(operations[i]);
                stack.Push(t);

                sum += t;
            }
        }

        return sum;

        //--- SOLUTION OK: 82.64% TOP
        //var stack = new Stack<int>();
        //foreach (var operation in operations)
        //{
        //    if (operation == "C")
        //    {
        //        stack.Pop();
        //    }
        //    else if (operation == "D")
        //    {
        //        var sum = stack.Peek() * 2;
        //        stack.Push(sum);
        //    }
        //    else if (operation == "+")
        //    {
        //        stack.Push(stack.ElementAt(0) + stack.ElementAt(1));
        //    }
        //    else
        //    {
        //        stack.Push(int.Parse(operation));
        //    }
        //}

        //var s = 0;
        //foreach (var i in stack)
        //    s += i;

        //return s;
    }
}
