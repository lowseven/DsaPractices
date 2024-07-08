using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

public class MinStackProblem
{
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    public MinStackProblem()
    {
    }

    public void Push(int val)
    {
        this.stack.Push(val);
        if (this.minStack.Count == 0)
            this.minStack.Push(val);
        else
        {
            if (val < minStack.Peek())
                minStack.Push(val);
            else
                minStack.Push(minStack.Peek());
        }
    }

    public void Pop()
    {
        if (stack.Count == 0)
            return;

        minStack.Pop();
        stack.Pop();
    }

    public int Top()
    {
        if (stack.Count == 0)
            return 0;

        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
