using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1695 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 };

            var expected = 8;

            var result = MaximumUniqueSubarray(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximumUniqueSubarray(int[] nums)
        {
            int left = 0, right = 0;
            var result = int.MinValue;
            var runningSum = 0;
            var indices = new Dictionary<int, int>();

            while (right < nums.Length)
            {
                if (indices.ContainsKey(nums[right]))
                {
                    while (left < indices[nums[right]] + 1)
                    {
                        runningSum -= nums[left];
                        left++;
                    }

                }
                indices[nums[right]] = right;
                runningSum += nums[right];
                right++;
                if (runningSum > result)
                    result = runningSum;

            }

            return result;
        }
    }
}
