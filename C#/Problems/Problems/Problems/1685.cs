using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1685 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 6, 8, 10 };

            var expected = new[] { 24, 15, 13, 15, 21 };

            var result = GetSumAbsoluteDifferences(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] GetSumAbsoluteDifferences(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];
            var sum = 0;
            foreach (var num in nums)
                sum += num;
            var preSum = 0;
            for (int i = 0; i < n; ++i)
            {
                var sumAfter = sum - preSum - (n - i) * nums[i];
                var sumBefore = i * nums[i] - preSum;
                result[i] = sumAfter + sumBefore;
                preSum += nums[i];
            }
            return result;
        }
    }
}
