using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _918 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, -3, 5 };

            var expected = 10;

            var result = MaxSubarraySumCircular(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSubarraySumCircular(int[] nums)
        {
            var runningMax = nums[0];
            var runningMin = nums[0];
            var maxSum = nums[0];
            var minSum = nums[0];
            var sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                runningMax = Math.Max(nums[i], runningMax + nums[i]);
                runningMin = Math.Min(nums[i], runningMin + nums[i]);

                maxSum = Math.Max(maxSum, runningMax);
                minSum = Math.Min(minSum, runningMin);

                sum += nums[i];
            }

            if (sum == minSum)
                return maxSum;

            return Math.Max(maxSum, sum - minSum);
        }
    }
}
