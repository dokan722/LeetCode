using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2163 :IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 7, 9, 5, 8, 1, 3 };

            var expected = 1;
            var result = MinimumDifference(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinimumDifference(int[] nums)
        {
            var n = nums.Length / 3;
            var first = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
            var second = new PriorityQueue<int, int>();
            var sumFirst = 0L;
            var sumSecond = 0L;
            for (int i = 0; i < n; i++)
            {
                first.Enqueue(nums[i], nums[i]);
                second.Enqueue(nums[^(i + 1)], nums[^(i + 1)]);
                sumFirst += nums[i];
                sumSecond += nums[^(i + 1)];
            }
            var mins = new long[n + 1];
            mins[0] = sumFirst;
            for (int i = 0; i < n; i++)
            {
                first.Enqueue(nums[n + i], nums[n + i]);
                var removed = first.Dequeue();
                mins[i + 1] = mins[i] - removed + nums[n + i];
            }

            var result = mins[n] - sumSecond;
            for (int i = 1; i <= n; i++)
            {
                second.Enqueue(nums[2 * n - i], nums[2 * n - i]);
                var removed = second.Dequeue();
                sumSecond = sumSecond  - removed + nums[2 * n - i];
                var diff = mins[n - i] - sumSecond;
                if (diff < result)
                    result = diff;
            }

            return result;
        }
    }
}
