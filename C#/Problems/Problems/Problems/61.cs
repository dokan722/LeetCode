using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _61 : IProblem
    {
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

        public bool Test()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var k = 2;

            var expected = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(2, new ListNode(3)))));

            var result = RotateRight(head, k);

            while (expected != null && result != null)
            {
                if (expected.val != result.val)
                    return false;
                expected = expected.next;
                result = result.next;
            }

            return expected == null && result == null;
        }

        private ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;
            if (k == 0)
                return head;
            var tail = head;
            var n = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                n++;
            }
            k = k % n;
            k = n - k - 1;
            var b = head;
            while (k > 0)
            {
                b = b.next;
                k--;
            }
            tail.next = head;
            var nHead = b.next;
            b.next = null;

            return nHead;
        }
    }
}
