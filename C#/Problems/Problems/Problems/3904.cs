using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3904 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 0, 1, 4 };
            var k = 3;

            var expected = 3;

            var result = FirstStableIndex(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FirstStableIndex(int[] nums, int k)
        {
            var n = nums.Length;
            var mins = new int[n];
            mins[n - 1] = nums[n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                mins[i] = Math.Min(nums[i], mins[i + 1]);
            }

            var mx = -1;
            for (int i = 0; i < n; ++i)
            {
                mx = Math.Max(mx, nums[i]);
                if (mx - mins[i] <= k)
                    return i;
            }

            return -1;
        }
    }
}
