using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();

            while(head != null)
            {
                if (visited.Contains(head))
                    return true;
                else
                    visited.Add(head);

                head = head.next;
            }

            return false;
        }
    }
}
