using System;
namespace LeetCodeProblems.DataStructures.LinkedLists
{
	public class FindMiddleNode
	{
        public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
        }
    }
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next?.next;
            }
            return slow;
        }
    }
}

