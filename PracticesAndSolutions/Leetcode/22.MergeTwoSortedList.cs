using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticesAndSolutions.Leetcode.ReversedLinkedListProblem;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/merge-two-sorted-lists/description/

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

public class MergeTwoSortedListProblem
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummyHead = new ListNode(-9999);
        var curr = dummyHead;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                list2 = list2.next;
            }
            curr = curr.next;
        }

        curr.next = list1 ?? list2;

        return dummyHead.next;
    }
}
