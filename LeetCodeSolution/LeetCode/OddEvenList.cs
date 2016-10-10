using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class OddEvenList
    {
        public ListNode OddEvenLinkedList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode oddHead = head, evenHead = head.next;
            ListNode prevOdd = oddHead, prevEven = evenHead;

            while(prevOdd.next != null && prevEven.next != null)
            {
                prevOdd.next = prevEven.next;
                prevOdd = prevOdd.next;

                prevEven.next = prevOdd.next;
                prevEven = prevEven.next;
            }
            prevOdd.next = evenHead;

            return oddHead;
        }
    }
}
