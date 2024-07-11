using System.Collections.Generic;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/reverse-linked-list/description/
public class ReversedLinkedListProblem
{
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

    public class Solution
    {
        //Follow up: A linked list can be reversed either iteratively or recursively.Could you implement both?

        //-------------------------------------------
        //recursive solution

        public ListNode ReverseList(ListNode head)
        {
            return Reverse(head, null);
        }

        private ListNode Reverse(ListNode curr, ListNode prev)
        {
            if (curr == null)
                return prev;

            var next = curr.next;
            curr.next = prev;

            return Reverse(next, curr);
        }



        //-------------------------------------------
        //iterative solution
        //public ListNode Head;

        //public ListNode ReverseList(ListNode head)
        //{
        //    var node = head;
        //    while (node != null)
        //    {

        //        this.AddAtHead(node.val);
        //        node = node.next;
        //    }

        //    return this.Head;
        //}

        //public void AddAtHead(int val)
        //{
        //    var newNode = new ListNode(val);
        //    if (Head == null)
        //        Head = newNode;
        //    else
        //    {
        //        newNode.next = Head;
        //        Head = newNode;
        //    }
        //}
    }
}
