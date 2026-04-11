using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2233 : IProblem
    {
        public bool Test()
        {
            var nums = new[] {0, 4};
            var k = 5;

            var expected = 20;

            var result = MaximumProduct(nums, k);

            Console.WriteLine(expected);

            return result == expected;
        }

        public int MaximumProduct(int[] nums, int k)
        {
            if (nums.Length == 1)
                return nums[0] + k;
            var que = new PriorityQueue<int, int>();
            foreach (var num in nums)
                que.Enqueue(num, num);
            while (k > 0)
            {
                var top = que.Dequeue();
                var dif = Math.Min(k, que.Peek() + 1 - top);
                que.Enqueue(top + dif, top + dif);
                k -= dif;
            }
            long result = 1;
            while (que.Count > 0)
                result = result * que.Dequeue() % 1000000007;
            return (int)result;
        }
    }
}
