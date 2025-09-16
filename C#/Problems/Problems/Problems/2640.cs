using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2640 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 3, 7, 5, 10 };

            var expected = new long[] { 4, 10, 24, 36, 56 };

            var result = FindPrefixScore(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public long[] FindPrefixScore(int[] nums)
        {
            var n = nums.Length;
            var result = new long[n];
            var max = nums[0];
            result[0] = 2 * max;
            for (int i = 1; i < n; i++)
            {
                max = Math.Max(max, nums[i]);
                result[i] = result[i - 1] + nums[i] + max;
            }

            return result;
        }
    }
}
