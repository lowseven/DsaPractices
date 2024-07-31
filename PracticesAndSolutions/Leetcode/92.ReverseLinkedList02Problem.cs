namespace PracticesAndSolutions.Leetcode;

public class ReverseLinkedList02Problem
{
    //https://leetcode.com/problems/reverse-linked-list-ii/description/
    public static ListNode ReverseBetween(ListNode head, int left, int right)
    {
        //clever solution from the solution section
        //he traversed a list switching the values and not the next node link
        //IList<ListNode> arr = new List<ListNode>(128);
        ///// add to array and swap values in place then return 1st elem in array...
        //for (ListNode i = head; i != null; i = i.next)
        //    arr.Add(i);

        //for (int i = left - 1, ii = right - 1; i < ii; i++, ii--)
        //{
        //    int val = arr[i].val;
        //    arr[i].val = arr[ii].val;
        //    arr[ii].val = val;
        //}
        //return arr[0];

        if (head == null
            || head.next == null
            || left == right)
            return head;

        ListNode dummy = new ListNode(-1, head);

        // 1. reach node at position "left"
        ListNode lleft = dummy;
        ListNode node = head;
        var leftVal = left;
        while (node != null && leftVal > 1)
        {
            lleft = node;
            node = node.next;
            leftVal--;
        }

        // 2. now current "left" and lleft nod ebefore "left"
        // reverse from left to right
        var steps = right - left + 1;//as the list is not 0 based
        ListNode prev = null;
        while (node != null && steps > 0)
        {
            var next = node.next;

            node.next = prev;
            prev = node;
            node = next;
            steps--;
        }

        //3. update pointers to linke the reversed sub linkedList
        lleft.next.next = node;
        lleft.next = prev;

        return dummy.next;
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
