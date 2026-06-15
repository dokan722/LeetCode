using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2095 : IProblem
    {
        public bool Test()
        {
            var head = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));

            var expected = new ListNode(5, new ListNode(4, new ListNode(1)));

            var result = DeleteMiddle(head);

            while (expected != null && result != null)
            {
                Console.Write($"{result.val} ");
                if (expected.val != result.val)
                    return false;
                expected = expected.next;
                result = result.next;
            }

            return true;
        }

        private class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        private ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null)
                return null;
            var slow = head;
            var fast = head.next;
            while (fast?.next?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;

            return head;
        }
    }
}
