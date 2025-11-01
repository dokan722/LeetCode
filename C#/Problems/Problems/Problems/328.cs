using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _328 : IProblem
    {
        public bool Test()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            var expected = new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(2, new ListNode(4)))));

            var result = OddEvenList(head);

            while (result != null && expected != null)
            {
                if (result.val != expected.val)
                    return false;
                result = result.next;
                expected = expected.next;
            }

            return result == expected;
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

        public ListNode OddEvenList(ListNode head)
        {
            var even = new ListNode();
            var odd = new ListNode();
            var currEven = even;
            var currOdd = odd;
            var curr = head;
            var cnt = 1;
            while (curr != null)
            {
                if (cnt % 2 == 0)
                {
                    currEven.next = curr;
                    currEven = currEven.next;
                }
                else
                {
                    currOdd.next = curr;
                    currOdd = currOdd.next;
                }
                curr = curr.next;
                cnt++;
            }

            currEven.next = null;
            currOdd.next = even.next;

            return odd.next;
        }
    }
}
