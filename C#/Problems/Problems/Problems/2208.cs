using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2208 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 5, 19, 8, 1 };

            var expected = 3;

            var result = HalveArray(nums);

            return expected == result;
        }

        public int HalveArray(int[] nums)
        {
            var initialSum = 0.0;
            var queue = new PriorityQueue<double, double>(Comparer<double>.Create((x, y) => y.CompareTo(x)));

            foreach (var num in nums)
            {
                initialSum += num;
                queue.Enqueue(num, num);
            }

            int result = 0;
            var sum = initialSum;
            while (sum > initialSum / 2)
            {
                queue.TryDequeue(out _, out var max);
                max /= 2;
                sum -= max;
                queue.Enqueue(max, max);
                result++;
            }

            return result;
        }
    }
}
