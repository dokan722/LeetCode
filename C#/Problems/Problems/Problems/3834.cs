using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3834 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 1, 1, 2 };

            var expected = new long[] { 3, 4 };

            var result = MergeAdjacent(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<long> MergeAdjacent(int[] nums)
        {
            var n = nums.Length;
            var stack = new Stack<long>();
            stack.Push(nums[0]);
            for (int i = 1; i < n; ++i)
            {
                long next = nums[i];
                if (next == stack.Peek())
                {
                    while (stack.Count > 0 && next == stack.Peek())
                    {
                        var top = stack.Pop();
                        next += top;
                    }
                }
                stack.Push(next);
            }
            var result = new List<long>();
            while (stack.Count > 0)
                result.Add(stack.Pop());
            var m = result.Count;
            for (int i = 0; i < m / 2; ++i)
                (result[i], result[m - 1 - i]) = (result[m - 1 - i], result[i]);
            return result;
        }
    }
}
