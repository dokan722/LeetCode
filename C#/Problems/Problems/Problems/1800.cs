using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1800 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 12, 17, 15, 13, 10, 11, 12 };

            var expected = 33;

            var result = MaxAscendingSum(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxAscendingSum(int[] nums)
        {
            var n = nums.Length;
            var result = 0;
            var runningSum = nums[0];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] <= nums[i - 1])
                {
                    result = Math.Max(result, runningSum);
                    runningSum = nums[i];
                }
                else
                    runningSum += nums[i];
            }
            result = Math.Max(result, runningSum);

            return result;
        }
    }
}
