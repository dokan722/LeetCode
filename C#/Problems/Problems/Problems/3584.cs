using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3584 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -1, -9, 2, 3, -2, -3, 1 };
            var m = 1;

            var expected = 81;

            var result = MaximumProduct(nums, m);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumProduct(int[] nums, int m)
        {
            var n = nums.Length;
            long mx = int.MinValue;
            long mn = int.MaxValue;
            long result = long.MinValue;
            for (int i = m - 1; i < n; ++i)
            {
                var last = i - (m - 1);
                mx = Math.Max(mx, nums[last]);
                mn = Math.Min(mn, nums[last]);
                result = Math.Max(result, Math.Max(nums[i] * mx, nums[i] * mn));
            }

            return result;
        }
    }
}
