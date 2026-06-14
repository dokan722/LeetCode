using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2130 : IProblem
    {
        public bool Test()
        {
            var head = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));

            var expected = 6;

            var result = PairSum(head);

            Console.WriteLine(result);

            return result == expected;
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

        private int PairSum(ListNode head)
        {
            var slow = head;
            var fast = head.next;
            var stack = new Stack<int>();
            while (fast != null)
            {
                stack.Push(slow.val);
                slow = slow.next;
                fast = fast.next?.next;
            }
            var result = 0;
            while (slow != null)
            {
                result = Math.Max(result, stack.Pop() + slow.val);
                slow = slow.next;
            }

            return result;
        }
    }
}
