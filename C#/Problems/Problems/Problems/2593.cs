using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2593 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 3, 4, 5, 2 };

            var expected = 7;

            var result = FindScore(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long FindScore(int[] nums)
        {
            var n = nums.Length;
            var queue = new PriorityQueue<int, (int, int)>();
            var marked = new bool[n + 2];
            for (int i = 0; i < n; i++)
                queue.Enqueue(i, (nums[i], i));

            long result = 0;
            while (queue.TryDequeue(out var id, out var score))
            {
                if (!marked[id + 1])
                {
                    marked[id] = true;
                    marked[id + 1] = true;
                    marked[id + 2] = true;
                    result += score.Item1;
                }
            }

            return result;
        }
    }
}
