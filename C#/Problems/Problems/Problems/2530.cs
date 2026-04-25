using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2530 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 10, 10, 10, 10 };
            var k = 5;

            var expected = 50;

            var result = MaxKelements(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxKelements(int[] nums, int k)
        {
            var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            foreach (var num in nums)
                queue.Enqueue(num, num);
            long result = 0;
            for (int i = 0; i < k; ++i)
            {
                var top = queue.Dequeue();
                result += top;
                var next = (top + 2) / 3;
                queue.Enqueue(next, next);
            }

            return result;
        }
    }
}
