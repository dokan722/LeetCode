using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3740 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 1, 1, 3 };

            var expected = 6;

            var result = MinimumDistance(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumDistance(int[] nums)
        {
            var n = nums.Length;
            var prevs = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                prevs[i] = new[] { -1, -1 };
            var result = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                if (prevs[nums[i]][0] != -1 && prevs[nums[i]][1] != -1)
                    result = Math.Min(result, prevs[nums[i]][1] - prevs[nums[i]][0] + i - prevs[nums[i]][1] + i - prevs[nums[i]][0]);
                prevs[nums[i]][0] = prevs[nums[i]][1];
                prevs[nums[i]][1] = i;
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
