using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode;

#region [Double LinkedList]

//public class NodeList
//{
//    public NodeList Next;
//    public NodeList Previous;
//    public string Value { get; set; }

//    public NodeList(string val, NodeList next = null, NodeList prev = null)
//    {
//        this.Value = val;
//        this.Next = next;
//        this.Previous = prev;

//    }
//}

//public class BrowserHistory
//{
//    NodeList node;

//    public BrowserHistory(string homepage)
//    {
//        node = new NodeList(homepage);
//    }

//    public void Visit(string url)
//    {
//        var newNode = new NodeList(url, prev: node);
//        node.Next = newNode;
//        node = newNode;
//    }

//    public string Back(int steps)
//    {
//        while (node.Previous != null && steps > 0)
//        {
//            node = node.Previous;
//            steps--;
//        }

//        return node.Value;
//    }

//    public string Forward(int steps)
//    {
//        while (node.Next != null && steps > 0)
//        {
//            node = node.Next;
//            steps--;
//        }

//        return node.Value;
//    }
//}

#endregion

#region [Single list solution]

public class BrowserHistory
{
    public List<string> pages;
    public int endIdx = 0;
    public int currentIndex = 0;

    public BrowserHistory(string homepage)
    {
        pages = new List<string>(1000) { homepage };
    }

    public void Visit(string url)
    {
        //endIdx = ++currentIndex;
        //or
        currentIndex++;
        endIdx = currentIndex;

        pages.Insert(endIdx, url);
    }

    public string Back(int steps)
    {
        currentIndex = Math.Max(currentIndex - steps, 0);

        return pages[currentIndex];
    }

    public string Forward(int steps)
    {
        currentIndex = Math.Min(currentIndex + steps, endIdx);

        return pages[currentIndex];
    }
}

#endregion [Single list solution]

#region [Double stack solution]
//public class BrowserHistory
//{
//    private Stack<string> bHistory;
//    private Stack<string> fHistory;

//    public BrowserHistory(string homepage)
//    {
//        bHistory = new Stack<string>(1000);
//        fHistory = new Stack<string>(1000);

//        bHistory.Push(homepage);
//    }

//    public void Visit(string url)
//    {
//        bHistory.Push(url);
//        //fHistory.Clear();
//        fHistory = new Stack<string>(1000) 
//    }

//    public string Back(int steps)
//    {
//        while (steps > 0 && bHistory.Count > 1)
//        {
//            var page = bHistory.Pop();
//            fHistory.Push(page);
//            steps--;
//        }

//        return bHistory.Peek();
//    }

//    public string Forward(int steps)
//    {
//        while (steps > 0 && fHistory.Count >= 1)
//        {
//            var page = fHistory.Pop();
//            bHistory.Push(page);
//            steps--;
//        }

//        return bHistory.Peek();
//    }
//}
#endregion [Double stack solution]
