using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3364 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, -2, 1, 4 };
            var l = 2;
            var r = 3;

            var expected = 1;

            var result = MinimumSumSubarray(nums, l, r);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumSumSubarray(IList<int> nums, int l, int r)
        {
            var n = nums.Count;
            var result = int.MaxValue;
            for (int i = l; i <= r; ++i)
            {
                var cur = 0;
                for (int j = 0; j < i; ++j)
                    cur += nums[j];
                if (cur > 0)
                    result = Math.Min(result, cur);
                for (int j = i; j < n; ++j)
                {
                    cur += nums[j];
                    cur -= nums[j - i];
                    if (cur > 0)
                        result = Math.Min(result, cur);
                }
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
