using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthNodeFromEnd(ListNode head, int n)
        {
            ListNode list1, list2;
            list2 = list1 = head;
            while (n-- > 0)
            {
                list2 = list2.next;
            }
            if (list2 == null)
            {
                return head.next;
            }
            while (list2.next != null)
            {
                list1 = list1.next;
                list2 = list2.next;
            }
            list1.next = list1.next.next;
            return head;

        }
    }
}
