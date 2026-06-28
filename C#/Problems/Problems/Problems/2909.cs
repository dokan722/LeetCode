using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2909 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 8, 6, 1, 5, 3 };

            var expected = 9;

            var result = MinimumSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumSum(int[] nums)
        {
            var n = nums.Length;
            var rightMins = new int[n];
            rightMins[n - 1] = nums[n - 1];
            for (int i = n - 2; i > 0; --i)
            {
                rightMins[i] = Math.Min(nums[i], rightMins[i + 1]);
            }
            var curMin = nums[0];
            var result = int.MaxValue;
            for (int i = 1; i < n - 1; ++i)
            {
                if (nums[i] > curMin && nums[i] > rightMins[i + 1])
                    result = Math.Min(result, curMin + nums[i] + rightMins[i + 1]);
                curMin = Math.Min(curMin, nums[i]);
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
