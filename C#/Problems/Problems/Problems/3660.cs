using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3660 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 3 };

            var expected = new[] { 2, 2, 3 };

            var result = MaxValue(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] MaxValue(int[] nums)
        {
            var n = nums.Length;
            var mx = 0;
            var leftMax = new int[n];
            for (int i = 0; i < n; ++i)
            {
                mx = Math.Max(nums[i], mx);
                leftMax[i] = mx;
            }

            var result = new int[n];
            result[n - 1] = leftMax[n - 1];
            var mn = nums[n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                if (mn < leftMax[i])
                    result[i] = result[i + 1];
                else
                    result[i] = leftMax[i];
                mn = Math.Min(mn, nums[i]);
            }

            return result;
        }
    }
}
