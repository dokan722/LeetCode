using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2058 : IProblem
    {
        public bool Test()
        {
            var head = new ListNode(3, new ListNode(1));

            var expected = new[] { -1, -1 };

            var result = NodesBetweenCriticalPoints(head);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
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

        private int[] NodesBetweenCriticalPoints(ListNode head)
        {
            var pprev = head.val;
            var prev = head.next.val;
            var cur = head.next.next;
            if (cur == null)
                return new[] { -1, -1 };
            var first = -1;
            var last = -1;
            var mn = int.MaxValue;
            var c = 0;
            while (cur != null)
            {
                if ((long)(prev - pprev) * (prev - cur.val) > 0)
                {
                    if (last != -1)
                        mn = Math.Min(mn, c - last);
                    last = c;
                    if (first == -1)
                        first = c;
                }
                c++;
                pprev = prev;
                prev = cur.val;
                cur = cur.next;
            }
            if (first == last)
                return new[] { -1, -1 };

            return new[] { mn, last - first };
        }
    }
}
