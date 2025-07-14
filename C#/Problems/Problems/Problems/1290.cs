using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1290 : IProblem
    {
        public bool Test()
        {
            var node1 = new ListNode(1);
            var node2 = new ListNode(0);
            var node3 = new ListNode(1);
            node1.next = node2;
            node2.next = node3;

            var expected = 5;

            var result = GetDecimalValue(node1);

            Console.WriteLine(result);

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

        public int GetDecimalValue(ListNode head)
        {
            var curr = head;
            var result = 0;
            while (curr != null)
            {
                result *= 2;
                result += curr.val;
                curr = curr.next;
            }

            return result;
        }
    }
}
