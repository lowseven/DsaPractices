using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndSolutions.Leetcode
{
    //https://leetcode.com/problems/palindrome-linked-list/description/
    public class PalindromeLinkedListProblem
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return false;

            if (head.next == null)
                return true;

            var l = new List<int>();
            var s = new Stack<int>();
            while (head != null)
            {
                l.Add(head.val);
                s.Push(head.val);
                head = head.next;
            }

            return l.SequenceEqual(s);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
