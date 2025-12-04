using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2574 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 4, 8, 3 };

            var expected = new[] { 15, 1, 11, 22 };

            var result = LeftRightDifference(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] LeftRightDifference(int[] nums)
        {
            var n = nums.Length;
            var sum = 0;
            for (int i = 0; i < n; ++i)
                sum += nums[i];
            var result = new int[n];
            var curr = 0;
            for (int i = 0; i < n; ++i)
            {
                result[i] = Math.Abs(2 * curr - sum + nums[i]);
                curr += nums[i];
            }

            return result;
        }
    }
}
