using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2 : IProblem
    {
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

        private bool AreSame(ListNode l1, ListNode l2)
        {
            var it1 = l1;
            var it2 = l2;
            while (it1 != null && it2 != null)
            {
                if (it1.val != it2.val)
                    return false;
                it1 = it1.next;
                it2 = it2.next;
            }
            if (it1 != null || it2 != null)
                return false;

            return true;
        }

        public bool Test()
        {
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            var expected = new ListNode(7, new ListNode(0, new ListNode(8))); ;

            var result = AddTwoNumbers(l1, l2);

            return AreSame(expected, result);
        }


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            var currNode = result;
            var it1 = l1;
            var it2 = l2;
            var addNext = 0;
            while (it1 != null || it2 != null || addNext != 0)
            {
                var val1 = 0;
                var val2 = 0;
                if (it1 != null)
                {
                    val1 = it1.val;
                    it1 = it1.next;
                }
                if (it2 != null)
                {
                    val2 = it2.val;
                    it2 = it2.next;
                }
                var newValue = val1 + val2 + addNext;
                if (newValue >= 10)
                {
                    addNext = 1;
                    newValue -= 10;
                }
                else
                    addNext = 0;
                var newNode = new ListNode(newValue);
                currNode.next = newNode;
                currNode = newNode;

            }
            return result.next;
        }
    }
}
