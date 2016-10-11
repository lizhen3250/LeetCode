using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if(l1.val < l2.val)
            {
                ListNode temp = l1;
                temp.next = MergeTwoLists(l1.next, l2);
                return temp;
            }
            else
            {
                ListNode temp = l2;
                temp.next = MergeTwoLists(l1, l2.next);
                return temp;
            }
        }
    }
}
