using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    // SAME AS 2866 (almost)
    public class _2865 : IProblem
    {
        public bool Test()
        {
            var heights = new[] { 2, 4, 5, 2, 5, 5, 2, 1, 1, 3 };

            var expected = 23;

            var result = MaximumSumOfHeights(heights);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumSumOfHeights(int[] heights)
        {
            var n = heights.Length;
            var scopes = new long[n];
            long result = 0;
            var stack = new Stack<(int Id, long Val)>();
            long total = 0;
            for (int i = 0; i < n; ++i)
            {
                var curr = heights[i];
                var last = i;
                while (stack.TryPeek(out var top) && top.Val >= curr)
                {
                    total -= (long)(top.Val - curr) * (last - top.Id);
                    last = top.Id;
                    stack.Pop();
                }
                stack.Push((last, curr));
                total += curr;
                scopes[i] = total;
            }
            stack.Clear();
            total = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                var curr = heights[i];
                var last = i;
                while (stack.TryPeek(out var top) && top.Val >= curr)
                {
                    total -= (long)(top.Val - curr) * (top.Id - last);
                    last = top.Id;
                    stack.Pop();
                }
                stack.Push((last, curr));
                total += curr;
                result = Math.Max(result, total + scopes[i] - curr);
            }

            return result;
        }
    }
}
