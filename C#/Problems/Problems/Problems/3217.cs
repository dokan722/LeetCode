using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3217 : IProblem
    {
        public bool Test()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            var nums = new[] { 1, 2, 3 };

            var expected = new ListNode(4, new ListNode(5));

            var result = ModifiedList(nums, head);

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

        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            var numsSet = new HashSet<int>(nums);
            var guard = new ListNode(0, head);
            var prev = guard;
            var curr = head;
            while (curr != null)
            {
                if (numsSet.Contains(curr.val))
                    prev.next = curr.next;
                else
                    prev = curr;
                curr = curr.next;
            }

            return guard.next;
        }
    }
}
