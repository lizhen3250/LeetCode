using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseLinkedList
    {
        public ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode newNode = ReverseListRecursive(head.next);
            head.next.next = head;
            head.next = null;
            return newNode;
        }

        public ListNode ReverseListIterative(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode prev = null;
            ListNode current = head;
            ListNode after = current.next;

            while(after != null)
            {
                ListNode temp = after.next;
                current.next = prev;
                after.next = current;
                prev = current;
                current = after;
                after = temp;
            }

            return current;
        }
    }
}
