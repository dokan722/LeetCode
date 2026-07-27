using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2256 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 5, 3, 9, 5, 3 };

            var expected = 3;

            var result = MinimumAverageDifference(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumAverageDifference(int[] nums)
        {
            var n = nums.Length;
            long s = 0;
            foreach (var num in nums)
                s += num;
            long cur = 0;
            long best = int.MaxValue;
            var result = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                cur += nums[i];
                var pre = cur / (i + 1);
                var suf = (s - cur) / (n - i - 1);
                var val = Math.Abs(pre - suf);
                if (val < best)
                {
                    best = val;
                    result = i;
                }
            }
            if (s / n < best)
                result = n - 1;

            return result;
        }
    }
}
