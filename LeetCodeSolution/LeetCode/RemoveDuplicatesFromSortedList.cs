using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode current = head, after = head.next;

            while(after != null)
            {
                if (current.val == after.val)
                {
                    current.next = after.next;
                    after = after.next;
                }
                else
                {
                    current = after;
                    after = after.next;
                }
            }
            return head;
        }
    }
}
